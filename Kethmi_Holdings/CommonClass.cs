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
        public static void setToolTipButtonStates(bool add,bool edit, bool save,bool print, bool delete, bool clear)
        {
            main =  Program.getMainForm();
            main.BtnAdd = add;
            main.BtnEdit = edit;
            main.BtnSave = save;
            main.BtnPrint = print;
            main.BtnDelete = delete;
            main.BtnClear = clear;
            
        }
        public static void setToolTipButtonStates(bool all)
        {
            main = Program.getMainForm();
            main.BtnAdd = main.BtnDelete = main.BtnEdit = main.BtnSave = main.BtnPrint = main.BtnClear = all;
        }

    }
    class ButtonsStates {
        bool btnAdd,btnDelete,btnEdit,btnSave,btnPrint,btnClear;
        static frm_Main main;
        

        public void save() {
            main = Program.getMainForm();

            btnAdd = main.BtnAdd;
            btnEdit = main.BtnEdit;
            btnSave = main.BtnSave;
            btnPrint = main.BtnPrint;
            btnDelete = main.BtnDelete;           
            btnClear = main.BtnClear;
        }

        public void restore() {
            CommonClass.setToolTipButtonStates(btnAdd,btnEdit,btnSave,btnPrint, btnDelete, btnClear);
        }

    }
}
