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
        [STAThread]
        static void Main()
        {

            SetDataManager();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (FrmLogin loginForm = new FrmLogin())
            {
                if (loginForm.ShowDialog() == DialogResult.OK)
                    Application.Run(new FrmContactList());
                else
                    MessageBox.Show("Authentication failed!", "Error");
            }
        }

        private static void SetDataManager()
        {
            DM._dataManager = new DataManager(new JsonDataManager());
        }
    }
}
