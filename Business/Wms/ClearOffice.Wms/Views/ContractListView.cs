using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using ClearOffice.Security;
using ClearOffice.Wms.Business;
using ClearOffice.Wms.Properties;
using DevExpress.XtraEditors;
using ClearOffice.Infrastructure;
namespace ClearOffice.Wms.Views
{
    public partial class ContractListView : DevExpress.XtraEditors.XtraForm,IListForm
    {
        private WmsEntities _context;
        private Contract _contract;
        private PermissionManager _pm;
        private WorkshopPermissionHelper _wph;
        public ContractListView()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            _context = new WmsEntities();

            _pm = PermissionManager.GetPermissionManager();
            _wph = new WorkshopPermissionHelper();
            AuthorizeForm();
        }

        public void ShowList()
        {
            ContractListBindingSource.DataSource = LoadAllContracts();
        }

        private IEnumerable<ContractInfo> LoadAllContracts()
        {
            _context = new WmsEntities();
            return _context.ContractInfoes.ToList();
        }

        public void OpenSelectedItem()
        {
            if (_contract != null)
            {
                var contractDetailView = new ContractDetailView();
                contractDetailView.ShowObject(_contract);
                contractDetailView.MdiParent = this.MdiParent;
                contractDetailView.Show();
            }
        }

        public object GetSelectedItem()
        {
            Contract cont = null; 
            if (ContractListGridView.SelectedRowsCount > 0)
            {
                var selected = (ContractInfo)ContractListGridView.GetRow((int)ContractListGridView.GetSelectedRows().GetValue(0));
                if (null != selected)
                {
                    cont = _context.Contracts.First(ct => ct.ContractId == selected.ContractId);
                    
                }
            }
            return cont;
        }

        public void RefreshList()
        {
            ContractListBindingSource.DataSource = LoadAllContracts();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            this._contract = (Contract)GetSelectedItem();
            ControleDeleteButton();

            AuthorizeForm();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            //check if a contract is selected first.
            if(this._contract == null)
                return;
            var result = ViewHelper.ShowConfirmDialog("Are u sure u want to delete this contract?");
            if (result == DialogResult.Yes)
            {
                try
                {
                    DeleteContract();
                }
                catch (Exception)
                {
                    
                    ViewHelper.ShowDeleteError();
                }
                
            }
            return;
        }

        private void DeleteContract()
        {
            try
            {
                _context = new WmsEntities();
                var d = _context.Contracts.First(ct=>ct.ContractId == this._contract.ContractId);
                _context.DeleteObject(d);
                _context.SaveChanges();
                RefreshList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            var newContractView = new NewContractView();
            newContractView.ShowObject(null);
            newContractView.ShowDialog();
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            if (ContractListGridView.SelectedRowsCount > 0)
            {
                var selected = (ContractInfo)ContractListGridView.GetRow((int)ContractListGridView.GetSelectedRows().GetValue(0));
                if (null != selected)
                {
                    _contract = _context.Contracts.First(ct => ct.ContractId == selected.ContractId);

                }
            }
            OpenSelectedItem();

            AuthorizeForm();
        }
        private void ControleDeleteButton()
        {
            if (_contract != null)
            {
                BtnDelete.Enabled = true;
            }
            else
            {
                BtnDelete.Enabled = false;
            }
        }


        public void OpenSelected()
        {
            throw new NotImplementedException();
        }


        public void AuthorizeForm()
        {
            btnNew.Enabled = _pm.IsAuthorized(PermissionManager.WORKSHOP_APPLICATION,
                                              _wph.ItemName(WorkshopPermissionHelper.Operation.AddContract));
            BtnDelete.Enabled = _pm.IsAuthorized(PermissionManager.WORKSHOP_APPLICATION,
                                                 _wph.ItemName(WorkshopPermissionHelper.Operation.DeleteContract));
        }
    }
}