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
       //     main.BtnAdd = add;
       //     main.BtnEdit = edit;
      //      main.BtnSave = save;
      //      main.BtnPrint = print;
      //      main.BtnDelete = delete;
      //      main.BtnClear = clear;
            
        }
        public static void setToolTipButtonStates(bool all)
        {
            main = Program.getMainForm();
        //    main.BtnAdd = main.BtnDelete = main.BtnEdit = main.BtnSave = main.BtnPrint = main.BtnClear = all;
        }

    }
    class ButtonsStates {
        bool btnAdd,btnDelete,btnEdit,btnSave,btnPrint,btnClear;
        static frm_Main main;
        

        public void save() {
            main = Program.getMainForm();

//btnAdd = main.BtnAdd;
    //        btnEdit = main.BtnEdit;
     //       btnSave = main.BtnSave;
       //     btnPrint = main.BtnPrint;
       //     btnDelete = main.BtnDelete;           
     //       btnClear = main.BtnClear;
        }

        public void restore() {
            CommonClass.setToolTipButtonStates(btnAdd,btnEdit,btnSave,btnPrint, btnDelete, btnClear);
        }
        public void CloseToolStrip(frm_Main frmMdi)
        {
            ToolStrip t = new ToolStrip();
            t = (ToolStrip)frmMdi.Controls["ts_side"];
            t.Visible = false;
        }

        public void VisibleToolStrip(frm_Main frmMdi)
        {
            ToolStrip t = new ToolStrip();
            t = (ToolStrip)frmMdi.Controls["ts_side"];
            t.Visible = true;
        }

        public void ControlSideToolStrip(object parentForm, bool btnNew=false, bool btnEdit = false, bool btnSave = false, bool btnPrint = false, bool btnDelete = false, bool btnCancal = false)
        {
            frm_Main frmMDIHome = new frm_Main();
            frmMDIHome = (frm_Main)parentForm;
            ToolStrip t = new ToolStrip();
            t = (ToolStrip)frmMDIHome.Controls["ts_side"];

            if (btnNew == true)
                t.Items["btn_add"].Enabled = true;
            else
                t.Items["btn_add"].Enabled = false;

            if (btnEdit == true)
                t.Items["btn_edit"].Enabled = true;
            else
                t.Items["btn_edit"].Enabled = false;

            if(btnSave == true)
                t.Items["btn_save"].Enabled = true;
            else
                t.Items["btn_save"].Enabled = false;

            if (btnPrint == true)
                t.Items["btn_print"].Enabled = true;
            else
                t.Items["btn_print"].Enabled = false;

            if (btnDelete == true)
                t.Items["btn_delete"].Enabled = true;
            else
                t.Items["btn_delete"].Enabled = false;

            if (btnCancal == true)
                t.Items["btn_clear"].Enabled = true;
            else
                t.Items["btn_clear"].Enabled = false;
            
        }
    }
}
