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
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }
        Database db;
        private void frm_Login_Load(object sender, EventArgs e)
        {
            db = new Database();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            db.insertUpdateDelete("INSERT INTO tblUser values('something','"+tb_username.Text+"','"+tb_passsword.Text+"','manager','0766613021',0)");
            MessageBox.Show("huraay");
            (new frm_Main()).Show();
        }
    }
}
