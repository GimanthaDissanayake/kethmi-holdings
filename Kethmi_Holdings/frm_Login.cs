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
        static string strUsername = "";
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
            strUsername = tb_username.Text;
            this.Hide();
            (new frm_Main(strUsername)).Show();
            strUsername = tb_username.Text;
        }

        // THIS IS A TEST
    }
}
