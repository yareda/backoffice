using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ClearOffice.Infrastructure;
using ClearOffice.Security;
using DevExpress.XtraEditors;
using ClearOffice.FixedAsset.DataAccess;
using System.Linq;
namespace ClearOffice.FixedAsset.Views
{
    public partial class AssetDisposal : DevExpress.XtraEditors.XtraForm,IDetailForm
    {
        private FixedAssetEntities _context;
        private Disposal _disposal;
        private PermissionManager permissionManager;
        private FixedAssetPermissionHelper faph;
        public Disposal CurrentObject
        {
            get { return _disposal; }
        }

        private Asset _asset;
        public AssetDisposal()
        {
            InitializeComponent();
            _context = new FixedAssetEntities();
            permissionManager = PermissionManager.GetPermissionManager();
            faph = new FixedAssetPermissionHelper();    
            AuthorizeForm();
        }

        public void ShowObject(object keyValue)
        {
           _disposal= (Disposal) keyValue;
            _asset = _context.Assets.FirstOrDefault(a => a.AssetId == _disposal.AssetId);
           if (_disposal.DisposalId != 0)//if the user needs to see the disposal information.
               btnSave.Enabled = false;
            disposalBindingSource.DataSource = _disposal;
            disposalTypeBindingSource.DataSource =
                _context.LookupItems.Where(li => li.LookupId == (int) LookupItems.DisposalType);
        }

        public bool DataChanged()
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            _disposal = (Disposal) disposalBindingSource.Current;
            _asset.Status = (int) AssetStatuses.Disposed;
            if (!ValidateForm())
                return;
            _context.Disposals.AddObject(_disposal);
            try
            {
                _context.SaveChanges();
                this.DialogResult = DialogResult.OK;  
            }
            catch(Exception ex )
            {
                ViewHelper.ShowErrorMessage("Error occured while saving the current disposal information.", ex);
                return;
            }
            
        }

        public void DeleteObject()
        {
            throw new NotImplementedException();
        }

        public bool ValidateForm()
        {
            bool result = true;
            if (disposalTypeLookUpEdit.EditValue == DBNull.Value)
            {
                disposalErrorProvider.SetError(disposalTypeLookUpEdit, "Disposal Type Is Required.");
                result = false;
            }
            if (disposalTypeLookUpEdit.EditValue != DBNull.Value)
            {
                if ((int) disposalTypeLookUpEdit.EditValue == (int) DisposalTypes.Sold &&
                    amountTextBox.Text == string.Empty)
                {
                    disposalErrorProvider.SetError(amountTextBox, "Amount Sold Is Required.");
                    result = false;
                }
            }
            return result;
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }

        private void disposalTypeLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (disposalTypeLookUpEdit.EditValue != DBNull.Value)
            {
                amountTextBox.Enabled = (int)disposalTypeLookUpEdit.EditValue == (int)DisposalTypes.Sold;
            }
        }


        public void AuthorizeForm()
        {
            btnSave.Enabled = permissionManager.IsAuthorized(PermissionManager.FIXED_ASSET_APPLICATION,
                                                             faph.ItemName(
                                                                 FixedAssetPermissionHelper.Operation.DisposeAsset));
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}