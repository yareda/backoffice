using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClearOffice.Hrm.Business;
using ClearOffice.Infrastructure;
using DevExpress.XtraEditors;

namespace ClearOffice.Hrm.Views
{
    public partial class LeaveStatusView : DevExpress.XtraEditors.XtraForm,IListForm
    {
        private LeaveProxy _proxy = new LeaveProxy();
        public LeaveStatusView()
        {
            InitializeComponent();
        }

        public void ShowList()
        {
            leaveStatusBindingSource.DataSource = _proxy.Context.EmployeePtoStatusInfoes.ToList();
        }

        public void OpenSelectedItem()
        {
            throw new NotImplementedException();
        }

        public object GetSelectedItem()
        {
            throw new NotImplementedException();
        }

        public void RefreshList()
        {
            var proxy = new LeaveProxy();
            leaveStatusBindingSource.DataSource = proxy.Context.EmployeePtoStatusInfoes.ToList();
        }

        private void refreshBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RefreshList();
        }


        public void AuthorizeForm()
        {
            throw new NotImplementedException();
        }
    }
}