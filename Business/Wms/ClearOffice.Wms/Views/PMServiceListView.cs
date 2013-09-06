using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ClearOffice.Infrastructure;
using ClearOffice.Security;
using ClearOffice.Wms.Business;
using DevExpress.XtraEditors;
using System.Linq;
namespace ClearOffice.Wms.Views
{
    public partial class PMServiceListView : DevExpress.XtraEditors.XtraForm,IListForm
    {
        private WmsEntities _context;
        private PmService _selectService;
        private PermissionManager _pm;
        private WorkshopPermissionHelper _wph;
        public PMServiceListView()
        {
            InitializeComponent();
            _context = new WmsEntities();
            _pm = PermissionManager.GetPermissionManager();
            _wph = new WorkshopPermissionHelper();

            AuthorizeForm();
        }
        public void ShowList()
        {
            pmserviceBindingSource.DataSource = _context.PmServiceInfoes.ToList();
        }
        public void OpenSelectedItem()
        {
            var pmsv = new PMServiceView();
            pmsv.ListView = this;
            pmsv.ShowObject(_selectService);
            pmsv.ShowDialog();
        }

        public object GetSelectedItem()
        {
            var pms = (PmServiceInfo) pmserviceBindingSource.Current;
            _selectService = _context.PmServices.FirstOrDefault(ps => ps.PmServiceId == pms.PmServiceId);
            return _selectService;
        }

        public void RefreshList()
        {
            pmserviceBindingSource.DataSource = _context.PmServiceInfoes.ToList();
        }

        public void OpenSelected()
        {
            throw new NotImplementedException();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            var pmsv = new PMServiceView();
            pmsv.ListView = this;
            pmsv.ShowObject(null);
            pmsv.ShowDialog();
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            var pmsinfo = (PmServiceInfo) pmserviceBindingSource.Current;
            if (pmsinfo != null)
            {
                _selectService = _context.PmServices.FirstOrDefault(ps => ps.PmServiceId == pmsinfo.PmServiceId);
                OpenSelectedItem();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = ViewHelper.ShowConfirmDialog("Are you sure you want to delete this PM service ?");
            if (result == DialogResult.Yes)
            {
                _context.PmServices.DeleteObject(_selectService);
                _context.SaveChanges();
                RefreshList();
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            var pmsinfo = (PmServiceInfo)pmserviceBindingSource.Current;
            if (pmsinfo != null)
            {
                btnDelete.Enabled = true;
                _selectService = _context.PmServices.FirstOrDefault(ps => ps.PmServiceId == pmsinfo.PmServiceId);
            }

            AuthorizeForm();
        }


        public void AuthorizeForm()
        {
            btnNew.Enabled = _pm.IsAuthorized(PermissionManager.WORKSHOP_APPLICATION,
                                                     _wph.ItemName(WorkshopPermissionHelper.Operation.AddNewPMService));
            btnDelete.Enabled = _pm.IsAuthorized(PermissionManager.WORKSHOP_APPLICATION,
                                                     _wph.ItemName(WorkshopPermissionHelper.Operation.DeletePMService));
        }
    }
}