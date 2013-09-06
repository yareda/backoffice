using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClearOffice.Hrm.Business;
using ClearOffice.Hrm.Business.Data;

namespace ClearOffice.Hrm
{
    public class LeaveCalculationHelper
    {
        public static decimal GetRemaingLeaveAmount(DateTime year, int eid)
        {
            var proxy = new LeaveProxy();
            decimal sum = 0;
            var req = from row in proxy.Context.EmployeePtoTransactions
                      where row.EmployeeId == eid && row.Year == year.Year
                      select row;
            if (req.Count() == 0)
                sum = 0;
            else
            {
                sum = (from row in req
                       select row).Sum(r => r.NoDays);
            }
            var totalLeave = GetTotalAnnualLeave(year, eid);
            return totalLeave - sum;
        }
        /// <summary>
        /// Gets the total amount of leave day the employe have for the given year. ex  12,14,15 etc..
        /// </summary>
        /// <param name="year"></param>
        /// <param name="eid"></param>
        /// <returns></returns>
        public static decimal GetTotalAnnualLeave(DateTime year, int eid)
        {
            var proxy = new LeaveProxy();
            var employee = proxy.Context.Employees.FirstOrDefault(e => e.EmployeeId == eid);
            var hd = Convert.ToDateTime(employee.HireDate);
            var possition = proxy.Context.Jobs.FirstOrDefault(j => j.JobId == employee.JobId);
            if(possition==null)
            {
                var fullName = string.Format("{0} {1} {2} [{3}]", employee.PersonalDetail.FirstName, employee.PersonalDetail.LastName, employee.PersonalDetail.GrandFatherName,employee.EmployeeNo);
                throw new ApplicationException(
                    string.Format(
                        "You have error in one of your employee records. You have not provided Position attribute for {0}",
                        fullName));
            }

            int duration = year.Subtract(hd).Days / 365;
            return duration + Convert.ToDecimal(possition.InitialLeaveAmount);
        }
        public static decimal GetAmountTaken(DateTime year, int eid)
        {
            var proxy = new LeaveProxy();
            decimal sum = 0;
            var req = from row in proxy.Context.EmployeePtoTransactions
                      where row.EmployeeId == eid && row.Year == year.Year
                      select row;
            if (req.Count() == 0)
                sum = 0;
            else
            {
                sum = (from row in req
                       select row).Sum(r => r.NoDays);
            }
            return sum;
        }

        /// <summary>
        /// Calculate the total number of leave days as of the requested date.
        /// </summary>
        /// <param name="eid"></param>
        /// <param name="numDays"></param>
        /// <param name="reqDate"></param>
        public static void ApproveLeaveRequest(int eid, decimal numDays, DateTime reqDate)
        {
            var proxy = new LeaveProxy();
            var employee = proxy.Context.Employees.FirstOrDefault(ep => ep.EmployeeId == eid);
            //ty - this year.
            var ty = reqDate.Year;
            //sy - service year. sy holds only the year part ignoring the month part. 
            int sy = reqDate.Subtract(Convert.ToDateTime(employee.HireDate)).Days / 365;
            //fy - the last service year just befor the request year.
            DateTime fy = new DateTime();
            fy = sy > 0 ? Convert.ToDateTime(employee.HireDate).AddYears(sy - 1) : Convert.ToDateTime(employee.HireDate);
            //fyv - the first year remaining leave value
            decimal fyv = 0;
            if (fy == Convert.ToDateTime(employee.HireDate))
                fyv = 0;
            else
                fyv = GetRemaingLeaveAmount(fy, eid);

            var fullYear = Convert.ToDateTime(employee.HireDate).AddYears(sy);
            decimal rate = Convert.ToDecimal(GetTotalAnnualLeave(reqDate, eid)) / 12;
            decimal md = Math.Round(Convert.ToDecimal(reqDate.Subtract(fullYear).Days / (362.25 / 12)));
            var v = Math.Round(md * rate) - GetAmountTaken(DateTime.Today, eid);
            decimal tyv = 0;
            if (v >= 0)
                tyv = v;
            var x = numDays;
            if (fyv > 0 && x > 0)
            {
                if (fyv >= x)
                {
                    var obj = new EmployeePtoTransaction()
                                  {
                                      ApprovedBy = "####",
                                      ApprovedDate = DateTime.Today,
                                      EmployeeId = eid,
                                      Year = fy.Year,
                                      NoDays = x
                                  };
                    var obj2 = proxy.Context.EmployeePtoStatus.FirstOrDefault(ep => ep.EmployeeId == eid);
                    if (obj2 != null)
                    {
                        obj2.PrevCount = fyv - x;
                        obj2.CurrentCount = tyv;
                    }
                    else
                    {
                        obj2 = new EmployeePtoStatus() { EmployeeId = eid, CurrentCount = tyv, PrevCount = fyv - x };
                        proxy.Context.EmployeePtoStatus.AddObject(obj2);
                    }
                    proxy.Context.EmployeePtoTransactions.AddObject(obj);
                    employee.CurrentLeaveDays = (fyv - x) + tyv;
                    proxy.Save();
                    return;
                }
                else
                {
                    x = x - fyv;
                    var obj = new EmployeePtoTransaction()
                    {
                        ApprovedBy = "####",
                        ApprovedDate = DateTime.Today,
                        EmployeeId = eid,
                        Year = fy.Year,
                        NoDays = fyv
                    };
                    proxy.Context.EmployeePtoTransactions.AddObject(obj);
                }
            }
            if (tyv > 0 && x > 0)
            {
                if (x >= tyv) // case of Overridden  
                {
                    var obj = new EmployeePtoTransaction()
                    {
                        ApprovedBy = "#####",
                        ApprovedDate = DateTime.Today,
                        EmployeeId = eid,
                        Year = ty,
                        NoDays = tyv
                    };
                    var obj2 = proxy.Context.EmployeePtoStatus.FirstOrDefault(ep => ep.EmployeeId == eid);
                    if (obj2 != null)
                    {
                        obj2.PrevCount = 0;
                        obj2.CurrentCount = 0;
                    }
                    else
                    {
                        obj2 = new EmployeePtoStatus() { EmployeeId = eid, PrevCount = 0, CurrentCount = 0 };
                        proxy.Context.EmployeePtoStatus.AddObject(obj2);
                    }
                    proxy.Context.EmployeePtoTransactions.AddObject(obj);
                    employee.CurrentLeaveDays = 0;
                    proxy.Save();
                    return;
                }
                else
                {
                    var obj = new EmployeePtoTransaction()
                    {
                        ApprovedBy = "#####",
                        ApprovedDate = DateTime.Today,
                        EmployeeId = eid,
                        Year = ty,
                        NoDays = x
                    };
                    var obj2 = proxy.Context.EmployeePtoStatus.FirstOrDefault(ep => ep.EmployeeId == eid);
                    if (obj2 != null)
                    {
                        obj2.PrevCount = 0;
                        obj2.CurrentCount = tyv - x;
                    }
                    else
                    {
                        obj2 = new EmployeePtoStatus() { EmployeeId = eid, PrevCount = 0, CurrentCount = tyv - x };
                        proxy.Context.EmployeePtoStatus.AddObject(obj2);
                    }
                    proxy.Context.EmployeePtoTransactions.AddObject(obj);
                    employee.CurrentLeaveDays = tyv - x;
                    proxy.Save();
                    return;
                }
            }
        }
        /// <summary>
        /// Calculate current leave values for every employees.
        /// </summary>
        public static void CalculateLeaveForAll()
        {
            var proxy = new LeaveProxy();
            var empList = proxy.Context.Employees.ToList();
            foreach (var em in empList)
            {
                int eid = em.EmployeeId;
                var employee = proxy.Context.Employees.FirstOrDefault(ep => ep.EmployeeId == eid);
                //if employee isn't active don't calculate the leave.
                if (employee.StatusId != Employee.StatusActive)
                    continue;
                //sy - service year. sy holds only the year part ignoring the month part. 
                int sy = DateTime.Today.Subtract(Convert.ToDateTime(employee.HireDate)).Days / 365;
                //fy - the last service year just befor the current year.
                DateTime fy = new DateTime();
                fy = sy > 0 ? Convert.ToDateTime(employee.HireDate).AddYears(sy - 1) : Convert.ToDateTime(employee.HireDate);
                //fyv - the first year remaining leave value
                decimal fyv = 0;
                if (fy == Convert.ToDateTime(employee.HireDate))
                    fyv = 0;
                else
                    fyv = GetRemaingLeaveAmount(fy, eid);

                var fullYear = Convert.ToDateTime(employee.HireDate).AddYears(sy);
                decimal rate = Convert.ToDecimal(GetTotalAnnualLeave(DateTime.Today, eid)) / 12;
                decimal md = Math.Round(Convert.ToDecimal(DateTime.Today.Subtract(fullYear).Days / (362.25 / 12)));
                //tyv - total leave value for the current year.
                decimal tyv = Math.Round(md * rate);

                var obj = proxy.Context.EmployeePtoStatus.FirstOrDefault(es => es.EmployeeId == eid);
                if (obj != null)
                {
                    obj.CurrentCount = tyv;
                    obj.PrevCount = fyv;
                }
                else
                {
                    obj = new EmployeePtoStatus() { EmployeeId = eid, CurrentCount = tyv, PrevCount = fyv };
                    proxy.Context.EmployeePtoStatus.AddObject(obj);
                }
                var asy = DateTime.Today.Subtract(Convert.ToDateTime(employee.HireDate)).Days / 365;
                employee.CurrentLeaveDays = fyv + tyv;
                employee.YearCount = asy;
            }
            proxy.Save();
        }
        /// <summary>
        /// Add the intial leave amount all employees.
        /// </summary>
        /// <param name="employees"></param>
        public static void AddInitialLeave(List<EmployeeInfo> employees)
        {
            var proxy = new LeaveProxy();
            foreach (var e in employees)
            {
                var hd = Convert.ToDateTime(e.HireDate);
                var eid = e.EmployeeId;
                int sy = DateTime.Today.Subtract(hd).Days / 365;
                var emp = proxy.Context.Employees.FirstOrDefault(ep => ep.EmployeeId == eid);
                decimal fyv = 0;
                decimal tv = 0;
                DateTime fy = sy > 0 ? Convert.ToDateTime(hd).AddYears(sy - 1) : Convert.ToDateTime(hd);
                decimal fyav = GetTotalAnnualLeave(fy, eid);
                // if the use enter a null value for the previous amount we will assum the employee hasn't taken any leave in previous year.
                // if the fy ==  hd  the employee hasn't have 1 year service year, so he willn't have transaction in the previous year.
                if (e.PrevValue != null && fy != hd)
                {
                    fyv = fyav - Convert.ToDecimal(e.PrevValue);
                    var obj = new EmployeePtoTransaction()
                                  {
                                      Year = fy.Year,
                                      EmployeeId = eid,
                                      NoDays = fyv,
                                      ApprovedBy = "#####",
                                      ApprovedDate = DateTime.Today
                                  };
                    proxy.Context.EmployeePtoTransactions.AddObject(obj);
                }
                if (e.CurrentValue != null)
                {
                    var fullYear = hd.AddYears(sy);
                    decimal rate = Convert.ToDecimal(GetTotalAnnualLeave(DateTime.Today, eid)) / 12;
                    decimal md = Math.Round(Convert.ToDecimal(DateTime.Today.Subtract(fullYear).Days / (362.25 / 12)));
                    //tyv - total leave value for the this year.
                    decimal tyv = Math.Round(md * rate);
                    tv = tyv - Convert.ToDecimal(e.CurrentValue);
                    if (tv > 0)
                    {
                        var obj = new EmployeePtoTransaction()
                                      {
                                          Year = DateTime.Today.Year,
                                          EmployeeId = eid,
                                          NoDays = tv,
                                          ApprovedBy = "#####",
                                          ApprovedDate = DateTime.Today
                                      };
                        proxy.Context.EmployeePtoTransactions.AddObject(obj);
                    }
                }


                if (e.PrevValue != null && e.CurrentValue != null)
                {
                    emp.CurrentLeaveDays = Math.Round(Convert.ToDecimal(e.PrevValue) + Convert.ToDecimal(e.CurrentValue));
                    var status = proxy.Context.EmployeePtoStatus.FirstOrDefault(es => es.EmployeeId == eid);
                    if (status != null)
                    {
                        status.PrevCount = e.PrevValue;
                        status.CurrentCount = e.CurrentValue;
                    }
                    else
                    {
                        status = new EmployeePtoStatus() { EmployeeId = eid, PrevCount = e.PrevValue, CurrentCount = e.CurrentValue };
                        proxy.Context.EmployeePtoStatus.AddObject(status);
                    }
                }
            }
            proxy.Save();
        }
    }
}
