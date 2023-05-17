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

namespace Grifindo_Payroll_system_new.User
{
    public partial class FrmUserRegister : Form
    {
        public FrmUserRegister()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmUserRegister_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'payrollDataSet.employee' table. You can move, or remove it, as needed.
                //  this.employeeTableAdapter.Fill(this.payrollDataSet.employee);
                connection con = new connection();
                con.dataGet("Select Emp_Role,Emp_Role_id from [Employee_Role]");
                DataTable dt = new DataTable();
                con.sda.Fill(dt);

                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "Emp_Role";
                comboBox1.ValueMember = "Emp_Role_id";
            }
            catch (Exception ex)
            {
                connection.ErrLog(ex);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ActiveControl = txtid;
        }
        private bool IfUserNameExists( string empname)
        {
            connection con = new connection();
            con.dataGet("select 1 from [employee] where [emp_name]='" + empname + "'");
            DataTable dt = new DataTable();
            con.sda.Fill(dt);
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }
    }
}
