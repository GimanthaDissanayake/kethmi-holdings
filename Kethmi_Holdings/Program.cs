using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kethmi_Holdings
{
    static class Program
    {
        static frm_Main main;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            main = new frm_Main();
            Application.Run(main);
        }
        public static frm_Main getMainForm() {
            return main;
        }
    }
}
