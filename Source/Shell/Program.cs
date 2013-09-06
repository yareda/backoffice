using System;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using System.Configuration;

namespace ClearOffice.Infrastructure.Shell
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.UserSkins.OfficeSkins.Register();
            DevExpress.UserSkins.BonusSkins.Register();
            var skin = ConfigurationManager.AppSettings["skin"];
            UserLookAndFeel.Default.SetSkinStyle(skin);
            //Application.Run(new MainForm());
            Application.Run(new LogIn());
            
           
        }
    }
}
