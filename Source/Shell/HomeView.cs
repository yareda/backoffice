using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ClearOffice.Infrastructure.Shell
{
    public partial class HomeView : DevExpress.XtraEditors.XtraForm
    {
        public HomeView()
        {
            InitializeComponent();
            LoadUrl();
        }

        private void LoadUrl()
        {
            var url = ConfigurationManager.AppSettings["reportUrl"];
            webBrowser1.Navigate(url);
        }
    }
}