using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClearOffice.FixedAsset.Views;
using ClearOffice.Infrastructure;
using ClearOffice.FixedAsset.Views;

namespace ClearOffice.FixedAsset
{
    public class FixedAssetModuleManager:IModule
    {
        #region IModule Members
        public void Run()
        {
            throw new NotImplementedException();
        }

        public void AddServices()
        {
            throw new NotImplementedException();
        }

        public void AddViews()
        {
            throw new NotImplementedException();
        }

        public void ExtendRibbon()
        {
            throw new NotImplementedException();
        }

        public void ExtendStatusBar()
        {
            throw new NotImplementedException();
        } 
        #endregion

        #region Asset Management
        public NewAsset ShowNewAsset()
        {
            return new NewAsset();
        }

        public AssetList ShowAssetList()
        {
            return new AssetList();
        }
        #endregion

        #region Custodian
        public CustodianList ShowCustodianList()
        {
            return new CustodianList();
        }
        public CustodianAssetView ShowNewCustodianAsset()
        {
            return  new CustodianAssetView();
        }

    #endregion Custodian
      #region Look UpItem
        public LookUpList ShowLookUpList()
        {
            return new LookUpList();
        }
        public AssetCategoryList ShowAssetcategoryList()
        {
            return new AssetCategoryList();
        }
        public ApplicationSettingView ShowApplicationsettingList()
        {
            return new ApplicationSettingView();
        }
        #endregion LookUpItem
    }
}
