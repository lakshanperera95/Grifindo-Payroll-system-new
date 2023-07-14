using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grifindo_Payroll_system_new
{
    public partial class Mainmenu : Form
    {
        public Mainmenu()
        {
            InitializeComponent();
        }

        private void Empreg_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void Mainmenu_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if(User.FrmUserRegister.GetForm ==null)
            {
                User.FrmUserRegister.GetForm = new User.FrmUserRegister();
                User.FrmUserRegister.GetForm.MdiParent = this;
                User.FrmUserRegister.GetForm.StartPosition = FormStartPosition.CenterScreen;
                User.FrmUserRegister.GetForm.Show();
            }
            else
            {
                User.FrmUserRegister.GetForm.Focus();
            }
           
        }

        private void Mainmenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Want To Exit", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            //User.Salary_Caluclate frm = new User.Salary_Caluclate();

            if (Salary_Caluclate.GetForm == null)
            {
                Salary_Caluclate.GetForm = new Salary_Caluclate();
                Salary_Caluclate.GetForm.MdiParent = this;
                Salary_Caluclate.GetForm.StartPosition = FormStartPosition.CenterScreen;
                Salary_Caluclate.GetForm.Show();
            }
            else
            {
                Salary_Caluclate.GetForm.Focus();
            }
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            //User.setting frm = new User.setting();

            if (Setting.GetForm == null)
            {
                Setting.GetForm = new Setting();
                Setting.GetForm.MdiParent = this;
                Setting.GetForm.StartPosition = FormStartPosition.CenterScreen;
                Setting.GetForm.Show();
            }
            else
            {
                Setting.GetForm.Focus();
            }
        }
    }
}
