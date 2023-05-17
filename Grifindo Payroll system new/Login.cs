using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Grifindo_Payroll_system_new
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            connection con = new connection();
            con.dataGet("Select * from [Users] where user_name ='" + txtusername.Text + "'and password ='" + txtpassword.Text + "'");
            DataTable dt = new DataTable();
            con.sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                this.Hide();
                Mainmenu frm = new Mainmenu();
                frm.Show();

            }
            else
            {
                MessageBox.Show("Invalid username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
         
        }

        private void txtpassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {

                btnlogin.PerformClick();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
