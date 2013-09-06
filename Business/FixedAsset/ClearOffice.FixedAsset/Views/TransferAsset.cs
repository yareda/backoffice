using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ClearOffice.FixedAsset.DataAccess;
using ClearOffice.Infrastructure;
using ClearOffice.Security;
using DevExpress.XtraEditors;
using System.Linq;
namespace ClearOffice.FixedAsset.Views
{
    public partial class TransferAsset : DevExpress.XtraEditors.XtraForm ,IDetailForm
    {
        private FixedAssetEntities _context;
        public bool _newMode;
        public Asset asset;
        private PermissionManager permissionManager;
        private FixedAssetPermissionHelper faph;
        private CustodianAsset custodianassets;
        public CustodianAsset CurrentObject
        {
            get { return custodianassets; }
        }
        public TransferAsset()
        {
            InitializeComponent();
            _context =new FixedAssetEntities();
            permissionManager = PermissionManager.GetPermissionManager();
            faph = new FixedAssetPermissionHelper();
            AuthorizeForm();
         }

       public void ShowObject(object keyValue)
        {
            var value = (Asset)keyValue;
           _newMode = true;
            asset = value;
            custodianassets = new CustodianAsset() { AssetId = value.AssetId};
            custodianassettransferbindingSource.DataSource = custodianassets;
            Loadcustodian();
        }

       private void Loadcustodian()
       {
               var custodian = new Custodian();
               var cua = _context.CustodianAssets.FirstOrDefault(c => c.AssetId == asset.AssetId &&c.Status ==(int)CustodyAssignmentStatus.Assigned);
               if(cua!=null)
                   custodian= _context.Custodians.FirstOrDefault(c => c.CustodianId == cua.CustodianId);
               if (custodian != null) 
                   textBox1.Text = custodian.FirstName + custodian.LastName;
           newcustodianbindingSource.DataSource = _context.ActiveCustodianStatuses.ToList();
           lookupitembindingSource.DataSource = _context.LookupItems.Where(li => li.LookupId == (int)LookupItems.CustodyAssignmentStatus);
       }

       public void SaveChanges()
       {
           if (!ValidateForm()) return;
           custodianassettransferbindingSource.EndEdit();
           var nca = new CustodianAsset();
                nca.CustodianId = Convert.ToInt32(lookUpEdit2.EditValue);
                nca.AssetId = asset.AssetId;
                nca.DateFrom = DateTime.Now;
                nca.Status = (int) CustodyAssignmentStatus.Assigned;
                var ca = _context.CustodianAssets.Where(cass => cass.AssetId == asset.AssetId && cass.Status == (int)CustodyAssignmentStatus.Assigned).FirstOrDefault();
           if (ca != null) ca.Status = (int)CustodyAssignmentStatus.Transfered;
           _context.CustodianAssets.AddObject(nca);
              try
              {        
                  _context.SaveChanges();
                  ViewHelper.ShowSuccessMessage("The Asset has succesfully been Transfered.");
                  Close();
              }
              catch (Exception)
              {
                  ViewHelper.ShowSaveError();
                  return;
              }
       }

        public bool ValidateForm()
        {
            if (lookUpEdit2.Text == string.Empty)
            {
                errorProvider1.SetError(lookUpEdit2, "Custodian is required");
                return false;
            }
            if (dateEdit1.Text == string.Empty)
            {
                errorProvider1.SetError(dateEdit1, "Assigned Date is required");
                return false;
            }

            return true;

        }

        private void cmdTransferasset_Click(object sender, EventArgs e)
        {
            SaveChanges();
            
        }
        public bool DataChanged()
        {
            throw new NotImplementedException();
        }
        public void DeleteObject()
        {
            throw new NotImplementedException();
        }

        public void AuthorizeForm()
        {
            cmdTransferasset.Enabled =
            permissionManager.IsAuthorized(PermissionManager.FIXED_ASSET_APPLICATION,
                                           faph.ItemName(FixedAssetPermissionHelper.Operation.TransferAsset));
        }
    }
}