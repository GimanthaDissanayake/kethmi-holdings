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
    public partial class frm_Customers : Form
    {
        int cusID;
        string strUsername = "",mode = "",strsql;
        Database db;

        ButtonsStates btnStat = new ButtonsStates();
        public frm_Customers(String s)
        {
            InitializeComponent();
            strUsername = s;           
        }

        private void frm_Customers_Load(object sender, EventArgs e)
        {
            enableEditing(false);
            loadData();
            btnStat.ControlSideToolStrip(this.ParentForm, true, false, false, false, false, false);
        }

        private void frm_Customers_FormClosing(object sender, FormClosingEventArgs e)
        {            
            btnStat.CloseToolStrip((frm_Main)this.MdiParent);
        }

        private void frm_Customers_Activated(object sender, EventArgs e)
        {
            btnStat.VisibleToolStrip((frm_Main)this.MdiParent);
        }

        private void getCusID()
        {
            db = new Database();
            cusID = Convert.ToInt32(db.getValue("SELECT TOP 1 cusID FROM ProjectMaster ORDER BY cusID DESC")) + 1;
        }

        private void loadData()
        {
            db = new Database();
            strsql = "SELECT projID as 'ID',projName as 'Project Name' FROM ProjectMaster WHERE isDeleted=0";
            dataGridView_CustomerList.DataSource = db.select(strsql);
            dataGridView_CustomerList.Enabled = true;
        }

        private void clearData()
        {
            txt_CusName.Clear();
            txt_NIC.Clear(); 
            txt_Phone.Clear();
            txt_ProjectName.Clear();
            txt_Type.Clear();
            txt_Address.Clear();
        }

        private void enableEditing(bool value)
        {
            txt_CusName.Enabled = value;
            txt_NIC.Enabled = value;
            txt_Phone.Enabled = value;
            txt_ProjectName.Enabled = value;
            txt_Type.Enabled = value;
            txt_Address.Enabled = value;
        }

        public void ButtonNew()
        {
            mode = "New";
            btnStat.ControlSideToolStrip(this.ParentForm, false, false, true, false, false, true);
            dataGridView_CustomerList.Enabled = false;
            clearData();
            enableEditing(true);
            txt_CusName.Focus();
        }
    }
}
