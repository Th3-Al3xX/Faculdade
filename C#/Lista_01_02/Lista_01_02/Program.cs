using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Lista_01_e_02;

namespace Lista_01_02
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
            Application.Run(new frmPrincipal());
        }
    }
}
