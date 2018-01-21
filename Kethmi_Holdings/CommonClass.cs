using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Kethmi_Holdings
{
    static class CommonClass
    {
        static frm_Main main;
        /// <summary>
        /// This method will sets the state of the side bar enable states according to respective parameters
        /// </summary>
        /// <param name="add"></param>
        /// <param name="edit"></param>
        /// <param name="save"></param>
        /// <param name="print"></param>
        /// <param name="delete"></param>
        public static void setToolTipStates(bool add,bool edit, bool save,bool print, bool delete)
        {
            main =  Program.getMainForm();
            main.setBtnAdd = add;
            main.setBtnDelete = delete;
            main.setBtnEdit = edit;
            main.setBtnSave = save;
            main.setBtnPrint = print;
        }

        public static void setToolTipStates(bool all) {
            main = Program.getMainForm();
            main.setBtnAdd = main.setBtnDelete = main.setBtnEdit = main.setBtnSave = main.setBtnPrint = all;
        }

    }
}
