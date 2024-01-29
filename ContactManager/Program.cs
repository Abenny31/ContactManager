using ContactManager.Data;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactManager
{
    public static class Program
    {
        public static DataManager _dataManager;

        [STAThread]
        static void Main()
        {

            SetDataManager();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new FrmContactList());
            //using (FrmLogin loginForm = new FrmLogin(_dataManager))
            //{
            //    if (loginForm.ShowDialog() == DialogResult.OK)
            //        Application.Run(new FrmContactList());
            //    else
            //        MessageBox.Show("Authentication failed!", "Error");
            //}
        }

        private static void SetDataManager()
        {
            if (Global.UseDB)
                DM._dataManager = new DataManager(new DatabaseManager());
            else
                DM._dataManager = new DataManager(new JsonDataManager());
        }
    }
}
