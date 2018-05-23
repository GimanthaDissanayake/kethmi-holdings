using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kethmi_Holdings
{
    public partial class frm_Recipts : Form
    {
        int cusID, pId, recID;
        Database db;

        ButtonsStates btnStat = new ButtonsStates();

        public frm_Recipts()
        {
            InitializeComponent();
        }

        public bool inputAreaEnabled {set { gb_inputArea.Enabled = value; } }

        public bool searchEnabled { set { gb_search.Enabled = value; } }

        ButtonsStates lastButtonStates;

        private void frm_Recipts_Activated(object sender, EventArgs e)
        {
            lastButtonStates.restore();
            btnStat.VisibleToolStrip((frm_Main)this.MdiParent);
        }

        private void frm_Recipts_Deactivate(object sender, EventArgs e)
        {
            lastButtonStates.save();
        }

        private void frm_Recipts_Load(object sender, EventArgs e)
        {
            lastButtonStates = new ButtonsStates();
        }

        private void frm_Recipts_FormClosing(object sender, FormClosingEventArgs e)
        {            
            btnStat.CloseToolStrip((frm_Main)this.MdiParent);
        }

        private void getReceiptId()
        {
            db = new Database();
            recID = Convert.ToInt32(db.getValue("SELECT TOP 1 reciptID FROM RecieptsMaster ORDER BY reciptID DESC"))+1;
        }

        private void getCusID()
        {
            db = new Database();
            cusID = Convert.ToInt32(db.getValue("SELECT cusID FROM Customer WHERE name = '"+txt_CusName.Text+"'"));            
        }

        private void getProjID()
        {
            db = new Database();
            pId = Convert.ToInt32(db.getValue("SELECT projID FROM ProjectMaster WHERE projName = '" + txt_ProjName.Text + "'"));
        }

        private void loadData()
        {

        }

        public void ButtonNew()
        {

        }

        public void ButtonEdit()
        {

        }

        public void ButtonClear()
        {

        }

        public void ButtonSave()
        {

        }

        public void ButtonDelete()
        {

        }

    }
}
