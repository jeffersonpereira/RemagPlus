using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using RemagPlus.Formularios;

namespace RemagPlus
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
            //Application.Run(new frmPrincipal());
            frmLogin login= new frmLogin();
            if (login.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new frmPrincipal());
            }
            else if (login.ShowDialog() == DialogResult.No)
            {
                Application.Exit();
            }
        }
    }
}
