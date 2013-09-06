using System;
using System.Windows.Forms;
using System.Configuration;
using Microsoft.Data.ConnectionUI;

namespace ClearOffice.Utility
{
    public partial class DatabaseConnectionConfiguration : Form
    {
        public DatabaseConnectionConfiguration()
        {
            InitializeComponent();
        }

        private void LoadConfiguration()
        {
            var config = ConfigurationManager.OpenExeConfiguration("ClearOffice.exe");
            ConnectionStringsSection section = config.ConnectionStrings;
            var setting = section.ConnectionStrings["ClearOfficeEntities"];

            var dcd = new DataConnectionDialog();
            var dcs = new DataConnectionConfiguration(null);
            dcs.LoadConfiguration(dcd);

            if (DataConnectionDialog.Show(dcd) == DialogResult.OK)
            {
                var conString =
                    "metadata=res://*/ClearOfficeModel.csdl|res://*/ClearOfficeModel.ssdl|res://*/ClearOfficeModel.msl;provider=System.Data.SqlClient;provider connection string=\"";
                conString += dcd.ConnectionString;
                conString += ";multipleactiveresultsets=True;App=EntityFramework\"";
                setting.ConnectionString = conString;
                config.Save(ConfigurationSaveMode.Modified);                
            }
        }

        private void ConfigureButton_Click(object sender, EventArgs e)
        {
            this.LoadConfiguration();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
