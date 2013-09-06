using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClearOffice.FixedAsset.DataAccess;
using Microsoft.VisualBasic;
using ClearOffice.Infrastructure;
using Microsoft.VisualBasic.CompilerServices;

namespace ClearOffice.FixedAsset
{
    public class DepereciationHelper
    {

        #region Calculate Deperciation
        public static void CalculateDepreciation(object obj)
        {
            var context = new FixedAssetEntities();
            var asset = (Asset)obj;
            var disposalInfo = context.Disposals.FirstOrDefault(a => a.AssetId == asset.AssetId);
            //check whether the asset is disposed or not.
            if (disposalInfo != null)
            {
                ViewHelper.ShowErrorMessage("You can't calculate depriciation for a disposed asset.");
                return;
            }
            if (asset.AssetValue == null || asset.PurchaseDate == null || asset.SalvageValue == null || asset.UsefulLife == null)
            {
                var msg = string.Empty;
                if (asset.AssetValue == null)
                {
                    msg += "\t- Asset Value\n";
                }
                if (asset.PurchaseDate == null)
                {
                    msg += "\t- Purchase Date\n";
                }
                if (asset.SalvageValue == null)
                {
                    msg += "\t- Salvage Value\n";
                }
                if (asset.UsefulLife == null)
                {
                    msg += "\t- Usefull Life";
                }
                ViewHelper.ShowErrorMessage("Unable to calculate the deprciation.The following asset information are missing.\n" + msg);
                return;
            }
            if (asset.DepreciationMethod == (int)DepreciationMethods.StraightLine)
            {
                try
                {
                    CalculateStraightLineDeperciation(asset);
                    ViewHelper.ShowSuccessMessage("Depreciation calculation has successfully completed.");
                    return;
                }
                catch (Exception e)
                {
                    ViewHelper.ShowErrorMessage("Error has occured while calculating depreciation,please contact your system administrator.");
                    ErrorLogger.LogError("Depreciation", e);
                    return;
                }
            }
            if (asset.DepreciationMethod == (int)DepreciationMethods.DecliningBalance)
            {
                try
                {
                    CalculateDecliningBalanceDepreciation(asset);
                    ViewHelper.ShowSuccessMessage("Depreciation calculation has successfully completed.");
                    return;
                }
                catch (Exception)
                {
                    ViewHelper.ShowErrorMessage("Error has occured while calculating depreciation,please contact your system administrator.");
                    return;
                }
            }
        }
        #endregion

        #region Calculate Depreciation To All
        public static void CalculateDepreciationToAll()
        {
            var context = new FixedAssetEntities();
            var assetList = context.Assets.ToList();
            string errorMsg = "Deperciation calculaion for the following assets has failed\n";
            bool hasError = false;
            foreach (var asset in assetList)
            {
                var disposalInfo = context.Disposals.FirstOrDefault(a => a.AssetId == asset.AssetId);
                //check whether the asset is disposed or not.
                if (disposalInfo != null)
                    continue;
                if (asset.AssetValue == null || asset.PurchaseDate == null || asset.SalvageValue == null || asset.UsefulLife == null)
                {
                    hasError = true;
                    errorMsg += "\t " + asset.AssetNumber + "\n";
                    continue;
                }
                try
                {
                    if (asset.DepreciationMethod == (int)DepreciationMethods.StraightLine)
                    {
                        CalculateStraightLineDeperciation(asset);
                    }
                    if (asset.DepreciationMethod == (int)DepreciationMethods.DecliningBalance)
                    {
                        CalculateDecliningBalanceDepreciation(asset);
                    }
                }
                catch (Exception)
                {
                    hasError = true;
                    errorMsg += "\t " + asset.AssetNumber + "\n";
                    continue;
                }
            }
            if (hasError)
            {
                ViewHelper.ShowErrorMessage(errorMsg);
                return;
            }
            else
            {
                ViewHelper.ShowSuccessMessage("Depreciation calculation has successfully completed.");
                return;
            }
        }
        #endregion

        #region Straight Line Depreciation
        /// <summary>
        /// Get The number of periods in month for specific asset starting from the purcahased date.
        /// </summary>
        /// <param name="assetId"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        public static int GetNoPeriods(int assetId, DateTime year)
        {
            var context = new FixedAssetEntities();
            DateTime purchasedDate = new DateTime();
            var asset = context.Assets.FirstOrDefault(a => a.AssetId == assetId);
            if (asset != null)
            {
                purchasedDate = Convert.ToDateTime(asset.PurchaseDate);
            }
            int periods = Convert.ToInt32((year - purchasedDate).TotalDays) / 30;
            return periods;
        }
        /// <summary>
        /// Get The Depreciation Expence for each period for a straight line depereciation.
        /// </summary>
        /// <param name="assetId"></param>
        /// <param name="rate"></param>
        /// <returns></returns>
        public static double GetPeriodicalDepereciationStr(int assetId, double rate)
        {
            var context = new FixedAssetEntities();
            var asset = context.Assets.FirstOrDefault(a => a.AssetId == assetId);
            //if asset value is null assign 0;
            var assetValue = asset.AssetValue ?? 0;
            var salvageValue = asset.SalvageValue ?? 0;
            var usefullLife = asset.UsefulLife ?? 0;
            var pd = Convert.ToDouble((Convert.ToDouble(assetValue - salvageValue) * (rate / 100.00)) / 12);
            return pd;
        }
        /// <summary>
        ///  Returns Depreciation To Date value of a specific asset at a specific period for a straight line depreciation.
        /// </summary>
        /// <param name="assetId"></param>
        /// <param name="period"></param>
        /// <param name="rate"></param>
        /// <returns></returns>
        public static double GetDepreciationToDateStr(int assetId, int period, double rate)
        {
            var pd = GetPeriodicalDepereciationStr(assetId, rate);
            return pd * period;
        }
        /// <summary>
        /// Returns Book value a the end of a period for a specific asset for a straight line depreciation
        /// </summary>
        /// <param name="assetId"></param>
        /// <param name="period"></param>
        /// <param name="rate"></param>
        /// <returns></returns>
        public static double GetBookValueAtTheEndStr(int assetId, int period, double rate)
        {
            var context = new FixedAssetEntities();
            var asset = context.Assets.FirstOrDefault(a => a.AssetId == assetId);
            var assetValue = Convert.ToDouble(asset.AssetValue ?? 0);
            var depToDate = GetDepreciationToDateStr(assetId, period, rate);

            return Convert.ToDouble(assetValue - depToDate);
        }
        /// <summary>
        /// Returns Book value a the begging of a period for a specific asset for a straight line depreciation
        /// </summary>
        /// <param name="assetId"></param>
        /// <param name="period"></param>
        /// <param name="rate"></param>
        /// <returns></returns>
        public static double GetBookValueAtBeginnigStr(int assetId, int period, double rate)
        {
            var context = new FixedAssetEntities();
            var asset = context.Assets.FirstOrDefault(a => a.AssetId == assetId);
            var assetValue = Convert.ToDouble(asset.AssetValue ?? 0);
            var depToDate = GetDepreciationToDateStr(assetId, period - 1, rate);

            return Convert.ToDouble(assetValue - depToDate);
        }
        /// <summary>
        /// Calculate Straight Line Depriciation for a spesific Asset.
        /// </summary>
        /// <param name="ast"></param>
        public static void CalculateStraightLineDeperciation(object ast)
        {
            var obj = (Asset)ast;
            int assetId = obj.AssetId;
            var context = new FixedAssetEntities();
            //Delete the Depereciation Information for the given asset from the deperciation table.
            var dp = context.Depreciations.Where(d => d.AssetId == assetId);
            foreach (var depreciation in dp)
            {
                context.Depreciations.DeleteObject(depreciation);
            }
            context.SaveChanges();
            // end delete.

            //Recalculate the depreciation Information for the given asset.
            DateTime current = DateTime.Today;
            var asset = context.Assets.FirstOrDefault(a => a.AssetId == assetId);
            DateTime pud = Convert.ToDateTime(asset.PurchaseDate);
            var appSetting = context.ApplicationSettings.FirstOrDefault(ap => ap.SettingId == 1);
            DateTime fysd = Convert.ToDateTime(appSetting.FiscalYearStart);
            DateTime fyed = Convert.ToDateTime(appSetting.FiscalYearEnd);
            var rate = Convert.ToDouble(context.AssetCategories.FirstOrDefault(ac => ac.CategoryId == asset.Category).DepreciationRate);
            int year = Convert.ToDateTime(asset.PurchaseDate).Year;
            int month = Convert.ToDateTime(asset.PurchaseDate).Month;
            //  I Will use j to count years
            int j = 1;
            // md - stands for the month difference.
            int md = 0;

            // This Will Calculate the Month Diff untile the fiscal end date including the month of the purchased date.
            if (fyed.Month < pud.Month)
            {
                var dt2 = new DateTime(pud.Year + 1, fyed.Month, fysd.Day);
                md = (Convert.ToInt32(dt2.Subtract(pud).Days / (365.25 / 12))) + 1;
            }
            else
            {
                md = (fyed.Month - pud.Month) + 1;
            }

            var today = DateTime.Now;
            var days = today.Subtract(pud).Days;


            // I will use p to count the fysical periods.
            int p = 1;
            int sm = pud.Month;
            int fp = 0;
            for (int k = 1; k <= md; k++)
            {
                if ((sm + fysd.Month) > 13)
                    fp = ((sm + fysd.Month) - 12) - 1;
                else
                    fp = ((sm + fysd.Month) - 1);
                //check whether the asset has deprciated compelitly.
                if (GetBookValueAtTheEndStr(asset.AssetId, k, rate) <= 0)
                {
                    context.SaveChanges();
                    return;
                }
                var d = new Depreciation();
                d.AssetId = assetId;
                d.Fiscalyear = j.ToString();
                d.FiscalPeriod = fp;
                d.DeprecationExpense = Convert.ToDecimal(GetPeriodicalDepereciationStr(Convert.ToInt32(d.AssetId), rate));
                d.AccumulatedDepreciation = Convert.ToDecimal(GetDepreciationToDateStr(asset.AssetId, k, rate));
                d.BookValueAtBeginningOfYear = Convert.ToDecimal(GetBookValueAtBeginnigStr(asset.AssetId, k, rate));
                d.BookValueAtEndOfYear = Convert.ToDecimal(GetBookValueAtTheEndStr(asset.AssetId, k, rate));
                d.DepreciationRate = (decimal)rate;
                d.Year = year;
                d.Month = month;
                ++month;
                if (month > 12)
                {
                    month = 1;
                    ++year;
                }
                context.Depreciations.AddObject(d);
                ++p;
                ++sm;
            }
            // Increment the fisycal year. 
            ++j;
            var dt = new DateTime();
            // Since the portion of the date from the fiscal start date setting is the month,we will use the purcahse date's \n
            // year to calculate the approximate number of months.
            if (pud.Month <= fysd.Month)
                dt = new DateTime(pud.Year, fysd.Month, fysd.Day);
            else
                dt = new DateTime(pud.Year + 1, fysd.Month, fysd.Day);
            // Get the approximate month difference b/n the fiscal year start date (setting the purchased date year componet into the fiscal year  year componet.)  and the current date.
            md = (Convert.ToInt32(current.Subtract(dt).Days / (365.25 / 12))) + 1;
            if (md <= 12)
            {
                for (int k = 1; k <= md; k++)
                {
                    //check whether the asset has deprciated compelitly.
                    if (GetBookValueAtTheEndStr(asset.AssetId, k, rate) <= 0)
                    {
                        context.SaveChanges();
                        return;
                    }
                    var d = new Depreciation();
                    d.AssetId = assetId;
                    d.Fiscalyear = j.ToString();
                    d.FiscalPeriod = k;
                    d.DeprecationExpense = Convert.ToDecimal(GetPeriodicalDepereciationStr(Convert.ToInt32(d.AssetId), rate));
                    d.AccumulatedDepreciation = Convert.ToDecimal(GetDepreciationToDateStr(asset.AssetId, p, rate));
                    d.BookValueAtBeginningOfYear = Convert.ToDecimal(GetBookValueAtBeginnigStr(asset.AssetId, p, rate));
                    d.BookValueAtEndOfYear = Convert.ToDecimal(GetBookValueAtTheEndStr(asset.AssetId, p, rate));
                    d.DepreciationRate = (decimal)rate;
                    d.Month = month;
                    d.Year = year;
                    ++month;
                    if (month > 12)
                    {
                        ++year;
                        month = 1;
                    }
                    context.Depreciations.AddObject(d);
                    ++p;
                }
                context.SaveChanges();
                return;
            }
            else
            {
                int c = 12;
            // Temp will count the remaing uncalculated month.
            label: var temp = md - c;
                for (int k = 1; k <= 12; k++)
                {
                    //check whether the asset has deprciated compelitly.
                    if (GetBookValueAtTheEndStr(asset.AssetId, k, rate) <= 0)
                    {
                        context.SaveChanges();
                        return;
                    }
                    var d = new Depreciation();
                    d.AssetId = assetId;
                    d.Fiscalyear = j.ToString();
                    d.FiscalPeriod = k;
                    d.DeprecationExpense = Convert.ToDecimal(GetPeriodicalDepereciationStr(Convert.ToInt32(d.AssetId), rate));
                    d.AccumulatedDepreciation = Convert.ToDecimal(GetDepreciationToDateStr(asset.AssetId, p, rate));
                    d.BookValueAtBeginningOfYear = Convert.ToDecimal(GetBookValueAtBeginnigStr(asset.AssetId, p, rate));
                    d.BookValueAtEndOfYear = Convert.ToDecimal(GetBookValueAtTheEndStr(asset.AssetId, p, rate));
                    d.DepreciationRate = (decimal)rate;
                    d.Year = year;
                    d.Month = month;
                    ++month;
                    if (month > 12)
                    {
                        ++year;
                        month = 1;
                    }
                    context.Depreciations.AddObject(d);
                    ++p;
                }
                ++j;
                c = c + 12;
                if (temp <= 12)
                {
                    for (int k = 1; k <= temp; k++)
                    {
                        //check whether the asset has deprciated compelitly.
                        if (GetBookValueAtTheEndStr(asset.AssetId, k, rate) <= 0)
                        {
                            context.SaveChanges();
                            return;
                        }
                        var d = new Depreciation();
                        d.AssetId = assetId;
                        d.Fiscalyear = j.ToString();
                        d.FiscalPeriod = k;
                        d.DeprecationExpense = (decimal)GetPeriodicalDepereciationStr(Convert.ToInt32(d.AssetId), rate);
                        d.AccumulatedDepreciation = Convert.ToDecimal(GetDepreciationToDateStr(asset.AssetId, p, rate));
                        d.BookValueAtBeginningOfYear = Convert.ToDecimal(GetBookValueAtBeginnigStr(asset.AssetId, p, rate));
                        d.BookValueAtEndOfYear = Convert.ToDecimal(GetBookValueAtTheEndStr(asset.AssetId, p, rate));
                        d.DepreciationRate = (decimal)rate;
                        d.Month = month;
                        d.Year = year;
                        ++month;
                        if (month > 12)
                        {
                            ++year;
                            month = 1;
                        }
                        context.Depreciations.AddObject(d);
                        ++p;
                    }
                    context.SaveChanges();
                }
                else
                    goto label;

            }
        }
        #endregion

        #region Declining Balance Deperciation
        public static void CalculateDecliningBalanceDepreciation(object ast)
        {
            var context = new FixedAssetEntities();
            var asset = (Asset)ast;
            //Delete the Depereciation Information for the given asset from the deperciation table.
            var dp = context.Depreciations.Where(d => d.AssetId == asset.AssetId);
            foreach (var depreciation in dp)
            {
                context.Depreciations.DeleteObject(depreciation);
            }
            context.SaveChanges();
            //recalculate the depreciation.
            var applicationSetting = context.ApplicationSettings.FirstOrDefault(a => a.SettingId == 1);
            DateTime fysd = Convert.ToDateTime(applicationSetting.FiscalYearStart);
            DateTime fyed = Convert.ToDateTime(applicationSetting.FiscalYearEnd);
            int fmd = 1;
            if (fyed.Month < Convert.ToDateTime(asset.PurchaseDate).Month)
            {
                var dt2 = new DateTime(Convert.ToDateTime(asset.PurchaseDate).Year + 1, fyed.Month, fysd.Day);
                fmd = (Convert.ToInt32(dt2.Subtract(Convert.ToDateTime(asset.PurchaseDate)).Days / (365.25 / 12))) + 1;
            }
            else
            {
                fmd = (fyed.Month - Convert.ToDateTime(asset.PurchaseDate).Month) + 1;
            }

            var md = (Convert.ToInt32(DateTime.Now.Subtract(Convert.ToDateTime(asset.PurchaseDate)).Days / (365.25 / 12))) + 1;
            int j = 1;
            int fp = 0;
            int sm = Convert.ToDateTime(asset.PurchaseDate).Month;
            decimal rate = Convert.ToDecimal(context.AssetCategories.FirstOrDefault(ac => ac.CategoryId == asset.Category).DepreciationRate / 100);
            int c = 1;
            int c2 = 1;
            double bvAtBg = Convert.ToDouble(asset.AssetValue);
            double bvAtEn = 0;
            double acumdepr = 0;
            int year = Convert.ToDateTime(asset.PurchaseDate).Year;
            int month = Convert.ToDateTime(asset.PurchaseDate).Month;
            for (int i = 1; i <= md; i++)
            {
                var depreciation = new Depreciation();
                if (j == 1)
                {
                    if (c2 <= fmd)
                    {
                        if ((sm + fysd.Month) > 13)
                            fp = ((sm + fysd.Month) - 12) - 1;
                        else
                            fp = ((sm + fysd.Month) - 1);
                        ++sm;
                    }
                    else
                    {
                        ++j;
                        fp = c;
                    }
                }
                double p = i/12.0;
                depreciation.AssetId = asset.AssetId;
                depreciation.Fiscalyear = j.ToString();
                depreciation.FiscalPeriod = fp;
                var depr = DDB(bvAtBg, Convert.ToDouble(asset.SalvageValue), Convert.ToDouble(asset.UsefulLife), p, Convert.ToDouble(rate));
                acumdepr = acumdepr + Convert.ToDouble(depr);
                depreciation.DeprecationExpense = Convert.ToDecimal(depr);
                depreciation.AccumulatedDepreciation = Convert.ToDecimal(acumdepr);
                depreciation.DepreciationRate = rate * 100;
                depreciation.BookValueAtBeginningOfYear = Convert.ToDecimal(bvAtBg);
                depreciation.Year = year;
                depreciation.Month = month;
                ++month;
                if (month > 12)
                {
                    ++year;
                    month = 1;
                }

                bvAtEn = bvAtBg - depr;
                if (bvAtEn <= 0)
                {
                    context.SaveChanges();
                    return;
                }
                bvAtBg = bvAtEn;
                depreciation.BookValueAtEndOfYear = Convert.ToDecimal(bvAtEn);
                if (j != 1)
                {
                    ++c;
                    fp = c;
                }
                else
                    ++c2;
                if (c > 12)
                {
                    c = 1;
                    fp = c;
                    ++j;
                }
                context.Depreciations.AddObject(depreciation);
            }
            context.SaveChanges();
        }

        public static double DDB(double Cost, double Salvage, double Life, double Period, double Factor)
        {
            if (Factor > 0.0)
            {
                if (Salvage >= 0.0)
                {
                    if (Period > 0.0)
                    {
                        if (Period <= Life + Period)
                        {
                            if (Cost <= 0.0)
                            {
                                return 0.0;
                            }
                            double num;
                            double num2;
                            if (Period > 1.0)
                            {
                                num = (Life - Factor) / Life;
                                double y = Period - 1.0;
                                num2 = Factor * Cost / Life * Math.Pow(num, y);
                                double num3 = Cost * (1.0 - Math.Pow(num, Period));
                                double num4 = num3 - Cost + Salvage;
                                if (num4 > 0.0)
                                {
                                    num2 -= num4;
                                }
                                double result;
                                if (num2 >= 0.0)
                                {
                                    result = num2;
                                }
                                else
                                {
                                    result = 0.0;
                                }
                                return result;
                            }
                            num2 = Cost * Factor / Life;
                            num = Cost - Salvage;
                            if (num2 > num)
                            {
                                return num;
                            }
                            return num2;
                        }
                    }
                }
            }
            throw new ArgumentException(Utils.GetResourceString("Argument_InvalidValue1", new string[]
	{
		"Factor"
	}));
        }
        #endregion

    }
}
