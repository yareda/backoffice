using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClearOffice.Security;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using ClearOffice.Infrastructure;
using ClearOffice.Fleet.Business;

namespace ClearOffice.Fleet.Views
{
    public partial class TireListView : DevExpress.XtraEditors.XtraForm, IListForm
    {
        private FleetEntities context= new FleetEntities();
        private PermissionManager _pm;
        private FleetPermissionHelper _fph;

        public TireListView()
        {
            InitializeComponent();
            _pm = PermissionManager.GetPermissionManager();
            _fph = new FleetPermissionHelper();

            AuthorizeForm();
        }

        public void ShowList()
        {
            this.tiresBindingSource.DataSource = context.TireInfoes.ToList();
        }

        public void OpenSelectedItem()
        {
            var selected = tiresBindingSource.Current as TireInfo;
            if (null != selected)
            {
                var form = new TireEdit();
                form.MdiParent = this.MdiParent;
                form.ShowObject(selected);
                form.Show();
            }
        }

        public object GetSelectedItem()
        {
            return tiresBindingSource.Current as TireInfo;
        }

        public void RefreshList()
        {
            context = new FleetEntities();
            this.tiresBindingSource.DataSource = context.TireInfoes.ToList();
        }

        public void AuthorizeForm()
        {
            //throw new NotImplementedException();
        }

        private void TireListView_Activated(object sender, EventArgs e)
        {
            var p = this.MdiParent as RibbonForm;
            p.Ribbon.SelectedPage = p.Ribbon.Pages["Fleet"];
        }

        private void refreshListBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RefreshList();
        }

        private void newTireBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            NewTire();
        }

        private void NewTire()
        {
            var form = new NewTire();
            form.ShowObject(null);
            var result = form.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                this.RefreshList();
                var item = form.GetCurrentObject();
                OpenRecord(item);
            }
        }

        private void OpenRecord(Tire item)
        {
            var form = new TireEdit();
            var obj = context.TireInfoes.FirstOrDefault(i => i.TireId== item.TireId);
            form.MdiParent = this.MdiParent;
            form.ShowObject(obj);
            form.Show();
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            var item = tiresBindingSource.Current as TireInfo;

            try
            {
                var tire = context.Tires.SingleOrDefault(t => t.TireId == item.TireId);
                OpenRecord(tire);
            }
            catch (Exception exception)
            {
                ViewHelper.ShowErrorMessage("Error loading tire detail");
            }

        }
    }
}