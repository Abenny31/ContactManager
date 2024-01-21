using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactManager
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            using (FrmLogin loginForm = new FrmLogin())
            {             
                if (loginForm.ShowDialog() == DialogResult.OK )
                    Application.Run(new FrmContactList());
                else
                    MessageBox.Show("Authentication failed!", "Error");
            }           
        }
    }
}
