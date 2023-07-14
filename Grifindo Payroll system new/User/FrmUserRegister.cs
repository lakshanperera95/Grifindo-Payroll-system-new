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
            LoadData();
        }
        public static FrmUserRegister GetForm { get; set; }

      

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

                cmbEmpRole.DataSource = dt;
                cmbEmpRole.DisplayMember = "Emp_Role";
                cmbEmpRole.ValueMember = "Emp_Role_id";
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
        private void ClearData()
        {
            txtid.Clear();
            txtname.Clear();
            txtphoneno.Clear();
            txtemail.Clear();
            txtaddress.Clear();
            txtaddress1.Clear();
            txtsalary.Clear();
            txtallownces.Clear();
            txtot.Clear();
            cmbEmpRole.ResetText();
            btnsave.Enabled = false;
            btnupdate.Enabled = false;
            btnsave.Enabled = true;
            birthday.Value = DateTime.Now;
        }
        
        private bool IfUserNameExists( string empname)
        {
            connection con = new connection();
            con.dataGet("select 1 from [employee] where [Emp_id]='" + empname + "'");
            DataTable dt = new DataTable();
            con.sda.Fill(dt);
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtid.Text.Trim() == string.Empty)
            {
                MessageBox.Show("invaliid id", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtid.Focus();
                return;

            }

            if (txtname.Text.Trim() == string.Empty)
            {
                MessageBox.Show("invaliid name", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtname.Focus();
                return;

            }

            if (txtaddress.Text.Trim() == string.Empty)
            {
                MessageBox.Show("invaliid Address", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtaddress.Focus();
                return;

            }
            if (txtaddress1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("invaliid Address 1", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtaddress1.Focus();
                return;

            }
            if (txtsalary.Text.Trim() == string.Empty)
            {
                MessageBox.Show("invaliid salary", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtsalary.Focus();
                return;

            }
            if (txtallownces.Text.Trim() == string.Empty)
            {
                MessageBox.Show("invaliid Allowances", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtallownces.Focus();
                return;

            }
            if (txtemail.Text.Trim() == string.Empty)
            {
                MessageBox.Show("invaliid email", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtemail.Focus();
                return;

            }
            if (txtphoneno.Text.Trim() == string.Empty)
            {
                MessageBox.Show("invaliid Address 1", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtphoneno.Focus();
                return;

            }
            if (txtot.Text.Trim() == string.Empty)
            {
                MessageBox.Show("invaliid OT", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtot.Focus();
                return;

            }
            if (IfUserNameExists(txtid.Text) == true)
            {
                //Update User
                MessageBox.Show("User Allready Exists... Try Update", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                //Insert User
                if (MessageBox.Show("Sure to Save Employee?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    connection con = new connection();
                    String C = "INSERT INTO dbo.employee(Emp_id,Emp_name, Emp_Phoneno, Emp_Birthday, Emp_Email, Emp_address, Emp_address_1, Emp_Role_id,Emp_salary,Emp_OT,Emp_Allowances)VALUES('" + txtid.Text + "','" + txtname.Text + "','" + txtphoneno.Text + "','" + birthday.Text + "','" + txtemail.Text + "','" + txtaddress.Text + "','" + txtaddress1.Text + "','" + cmbEmpRole.SelectedValue.ToString() + "','" + txtsalary.Text + "','" + txtot.Text + "','" + txtallownces.Text + "')";
                    con.Datasend(C);
                    MessageBox.Show("Record Save Succesful", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearData();
                    LoadData();
                }
            }
        }

        private void LoadData()
        {
            connection con = new connection();
            con.dataGet("select Emp_id,Emp_name, Emp_Phoneno, Emp_Birthday, Emp_Email, Emp_address, Emp_address_1,Emp_role,Emp_Phoneno,Emp_salary,Emp_OT,Emp_Allowances  from employee E join Employee_Role ER on E.Emp_Role_id=Er.Emp_Role_id");
            DataTable dt = new DataTable();
 
            con.sda.Fill(dt);

            dgEmployee.DataSource = dt;




        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (txtid.Text.Trim() == string.Empty)
            {
                MessageBox.Show("invaliid id", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtid.Focus();
                return;

            }

            if (txtname.Text.Trim() == string.Empty)
            {
                MessageBox.Show("invaliid name", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtname.Focus();
                return;

            }

            if (txtaddress.Text.Trim() == string.Empty)
            {
                MessageBox.Show("invaliid Address", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtaddress.Focus();
                return;

            }
            if (txtaddress1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("invaliid Address 1", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtaddress1.Focus();
                return;

            }
            if (txtsalary.Text.Trim() == string.Empty)
            {
                MessageBox.Show("invaliid salary", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtsalary.Focus();
                return;

            }
            if (txtallownces.Text.Trim() == string.Empty)
            {
                MessageBox.Show("invaliid Allownces", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtallownces.Focus();
                return;

            }
            if (txtemail.Text.Trim() == string.Empty)
            {
                MessageBox.Show("invaliid email", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtemail.Focus();
                return;

            }
            if (txtphoneno.Text.Trim() == string.Empty)
            {
                MessageBox.Show("invaliid phoneno", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtphoneno.Focus();
                return;

            }
            if (txtot.Text.Trim() == string.Empty)
            {
                MessageBox.Show("invaliid OT", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtot.Focus();
                return;

            }

            if (IfUserNameExists(txtid.Text) == true)
            {
                if (MessageBox.Show("Sure to Update Employee?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    connection con = new connection();
                    //String C = "INSERT INTO dbo.employee(Emp_id,Emp_name, Emp_Phoneno, Emp_Birthday, Emp_Email, Emp_address, Emp_address_1, Emp_Role_id)VALUES('" + txtid.Text + "','" + txtname.Text + "','" + txtphoneno.Text + "','" + birthday.Value.ToString("dd/mm/yyyy") + "','" + txtemail.Text + "','" + txtaddress.Text + "','" + txtaddress1.Text + "','" + comboBox1.SelectedValue.ToString() + "')";
                    String C = " update employee set Emp_name='" + txtname.Text + "',Emp_Phoneno='" + txtphoneno.Text + "',Emp_Birthday='" + birthday.Text + "',Emp_Email='" + txtemail.Text + "', Emp_address='" + txtaddress.Text + "', Emp_address_1='" + txtaddress1.Text + "',Emp_salary='" + txtsalary.Text + "', Emp_Allowances ='" + txtallownces.Text + "',Emp_OT ='" + txtot.Text + "', Emp_Role_id='" + cmbEmpRole.SelectedValue.ToString() + "' Where Emp_id= '" + txtid.Text + "'";
                    con.Datasend(C);
                    MessageBox.Show("Record Update Succesful", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearData();
                    LoadData();
                }
            }
            else
            {
                //Insert User
                //Update User
                MessageBox.Show("User Not Exists... Try Save", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dgEmployee_DoubleClick(object sender, EventArgs e)
        {
            if (dgEmployee.SelectedRows.Count <= 0 || dgEmployee.SelectedRows[0].Cells[0].ToString() == "")
            {
                MessageBox.Show("Select Data", "Select", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                txtid.Text = dgEmployee.SelectedRows[0].Cells[0].Value.ToString();
                txtname.Text = dgEmployee.SelectedRows[0].Cells[1].Value.ToString();
                txtaddress.Text = dgEmployee.SelectedRows[0].Cells[2].Value.ToString();
                txtaddress1.Text = dgEmployee.SelectedRows[0].Cells[3].Value.ToString();
                txtsalary.Text = dgEmployee.SelectedRows[0].Cells[4].Value.ToString();
                txtallownces.Text = dgEmployee.SelectedRows[0].Cells[5].Value.ToString();
                txtemail.Text = dgEmployee.SelectedRows[0].Cells[6].Value.ToString();
                birthday.Text = dgEmployee.SelectedRows[0].Cells[7].Value.ToString();
                cmbEmpRole.Text = dgEmployee.SelectedRows[0].Cells[8].Value.ToString();
                txtphoneno.Text = dgEmployee.SelectedRows[0].Cells[9].Value.ToString();
                txtot.Text = dgEmployee.SelectedRows[0].Cells[10].Value.ToString();

                btnupdate.Enabled = true;
                txtname.Focus();

            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (txtid.Text.Trim() == string.Empty)
            {
                MessageBox.Show("invaliid id", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtid.Focus();
                return;

            }

            if (txtname.Text.Trim() == string.Empty)
            {
                MessageBox.Show("invaliid name", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtname.Focus();
                return;

            }

            if (txtaddress.Text.Trim() == string.Empty)
            {
                MessageBox.Show("invaliid Address", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtaddress.Focus();
                return;

            }
            if (txtaddress1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("invaliid Address 1", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtaddress1.Focus();
                return;


            }
            if (txtsalary.Text.Trim() == string.Empty)
            {
                MessageBox.Show("invaliid salary", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtsalary.Focus();
                return;

            }
            if (txtallownces.Text.Trim() == string.Empty)
            {
                MessageBox.Show("invaliid Allowances", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtallownces.Focus();
                return;

            }
            if (txtemail.Text.Trim() == string.Empty)
            {
                MessageBox.Show("invaliid email", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtemail.Focus();
                return;

            }
            if (txtphoneno.Text.Trim() == string.Empty)
            {
                MessageBox.Show("invaliid Address 1", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtphoneno.Focus();
                return;

            }
            if (IfUserNameExists(txtid.Text) == true)
            {
                if (MessageBox.Show("Sure to Delete Employee?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    connection con = new connection();
                    //String C = "INSERT INTO dbo.employee(Emp_id,Emp_name, Emp_Phoneno, Emp_Birthday, Emp_Email, Emp_address, Emp_address_1, Emp_Role_id)VALUES('" + txtid.Text + "','" + txtname.Text + "','" + txtphoneno.Text + "','" + birthday.Value.ToString("dd/mm/yyyy") + "','" + txtemail.Text + "','" + txtaddress.Text + "','" + txtaddress1.Text + "','" + comboBox1.SelectedValue.ToString() + "')";
                    String C = " Delete from  employee  where Emp_id= '" + txtid.Text + "' ";
                    con.Datasend(C);
                    MessageBox.Show("Record Delete Succesful", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearData();
                    LoadData();
                }
            }
            else
            {
                //Insert User
                //Update User
                MessageBox.Show("User Not Exists... Try Save", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtid_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter && txtid.Text.Trim()!=string.Empty)
            {
                txtname.Focus();
            }
        }

        private void txtname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtname.Text.Trim() != string.Empty)
            {
                txtaddress.Focus();
            }
        }

        private void txtaddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtaddress.Text.Trim() != string.Empty)
            {
                txtaddress1.Focus();
            }
        }

        private void txtaddress1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtaddress1.Text.Trim() != string.Empty)
            {
                txtemail.Focus();
            }
        }

        private void txtemail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtemail.Text.Trim() != string.Empty)
            {
                birthday.Focus();
            }
        }

        private void birthday_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter )
            {
                cmbEmpRole.Focus();
            }
        }

        private void cmbEmpRole_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && cmbEmpRole.Text.Trim() != string.Empty)
            {
                txtphoneno.Focus();
            }
        }

        private void txtphoneno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtphoneno.Text.Trim() != string.Empty)
            {
                btnsave.Focus();
            }
        }

        
        private void FrmUserRegister_FormClosed(object sender, FormClosedEventArgs e)
        {
            GetForm = null;
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            ClearData();
        }
    }
}

