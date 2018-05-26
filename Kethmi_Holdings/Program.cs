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


            Application.Run(new frm_Login());
        }
        public static frm_Main getMainForm() {
            main = new frm_Main("");
            return main;
        }
    }
}
