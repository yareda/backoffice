using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClearOffice.Infrastructure;
using ClearOffice.FixedAsset.DataAccess;
using ClearOffice.Security;
using DevExpress.XtraEditors;

namespace ClearOffice.FixedAsset.Views
{
    public partial class CustodianList : DevExpress.XtraEditors.XtraForm,IListForm,IDetailForm
    {
        private FixedAssetEntities _context;
        public Custodian _Custodian;
        private PermissionManager permissionManager;
        private FixedAssetPermissionHelper faph;
        public CustodianList()
        {
            InitializeComponent();
            _context = new FixedAssetEntities();
            permissionManager = PermissionManager.GetPermissionManager();
            faph = new FixedAssetPermissionHelper();
            AuthorizeForm();
            ShowList();
        }

        public void ShowList()
        {
            custiodianlistbindingSource.DataSource = _context.CustodianInfoes.ToList();
        }

        public void OpenSelectedItem()
        {
            if (_Custodian != null)
            {
                var custdetail = new CustodianDetail();
                custdetail.ShowObject(_Custodian);
                custdetail.ShowDialog();
            }
        }
        
        public void RefreshList()
        {
           _context =new FixedAssetEntities();
            custiodianlistbindingSource.DataSource = _context.CustodianInfoes.ToList();
        }
        private void btnNewCustodian_Click(object sender, EventArgs e)
        {
            var newcustodian = new NewCustodian();
            newcustodian.ShowObject(null);
            newcustodian.ShowDialog();
        }

        private void btnCustrefresh_Click(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void btnCustodianlistDelete_Click(object sender, EventArgs e)
        {
            var result = ViewHelper.ShowConfirmDialog("Are you sure you want to delete the current record?");
            if (result == DialogResult.Yes)
            {
                try
                {
                    DeleteObject();
                }
                catch (Exception)
                {
                    ViewHelper.ShowDeleteError();
                }
            }
            return;
        }

      public void DeleteObject()
        {
            try
            {
                _context = new FixedAssetEntities();
                var d = _context.Custodians.First(ct => ct.CustodianId == _Custodian.CustodianId);
                _context.DeleteObject(d);
                _context.SaveChanges();
                RefreshList();

            }
            catch (Exception)
            {
                throw;
            }
        }

       private void gridControl1_Click(object sender, EventArgs e)
        {
            if (custodiangridView.SelectedRowsCount > 0)
            {
                var selected = (CustodianInfo)custodiangridView.GetRow((int)custodiangridView.GetSelectedRows().GetValue(0));
                if (null != selected)
                {
                    _Custodian = _context.Custodians.FirstOrDefault(ct => ct.CustodianId == selected.CustodianId);

                }
            }
            GetSelectedItem();
            btnCustodianlistDelete.Enabled = true;
        }

       private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            if (custodiangridView.SelectedRowsCount > 0)
            {
                var selected = (CustodianInfo)custodiangridView.GetRow((int)custodiangridView.GetSelectedRows().GetValue(0));
                if (null != selected)
                {
                    _Custodian = _context.Custodians.FirstOrDefault(ct => ct.CustodianId == selected.CustodianId);

                }
            }
            OpenSelectedItem();
           AuthorizeForm();
        }

       public object GetSelectedItem()
       {
           return custiodianlistbindingSource.Current;
       }
       public void ShowObject(object keyValue)
       {
           throw new NotImplementedException();
       }

       public bool DataChanged()
       {
           throw new NotImplementedException();
       }

       public void SaveChanges()
       {
           throw new NotImplementedException();
       }
       public bool ValidateForm()
       {
           throw new NotImplementedException();
       }



       public void AuthorizeForm()
       {
           btnCustodianlistDelete.Enabled = permissionManager.IsAuthorized(PermissionManager.FIXED_ASSET_APPLICATION,
                                                                           faph.ItemName(
                                                                               FixedAssetPermissionHelper.Operation.
                                                                                   DeleteCustodian));
           btnNewCustodian.Enabled = permissionManager.IsAuthorized(PermissionManager.FIXED_ASSET_APPLICATION,
                                                                    faph.ItemName(
                                                                        FixedAssetPermissionHelper.Operation.
                                                                            AddCustodian));

       }
    }
}