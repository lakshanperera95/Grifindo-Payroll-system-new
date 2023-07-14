using ClsPayroll;
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
    public partial class Salary_Caluclate : Form
    {
        public Salary_Caluclate()
        {
            InitializeComponent();

        }
      


        public static Salary_Caluclate GetForm { get; set; }
        connection con = new connection();
        ClsSalary ObjClsSalary = new ClsSalary();
        private void txtid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (dataGridView1.Rows.Count > 0)
                {
                    txtid.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                    txtname.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();

                    con.dataGet("Select Emp_name,Emp_Salary,Emp_Allowances,Emp_OT from employee where Emp_id ='" + txtid.Text + "';select monthdate from setting");
                    DataSet dt = new DataSet();
                    con.sda.Fill(dt);
                    if (dt.Tables[0].Rows.Count > 0)
                    {
                        txtname.Text = dt.Tables[0].Rows[0][0].ToString();
                        txtsalary.Text = dt.Tables[0].Rows[0][1].ToString();
                        txtallownces.Text = dt.Tables[0].Rows[0][2].ToString();
                        txtOtRate.Text = dt.Tables[0].Rows[0][3].ToString();

                    }




                    txtsalary.Focus();
                }
            }
        }
        private void txtid_TextChanged(object sender, EventArgs e)
        {
            con.dataGet("Select top(10) Emp_id,Emp_name from employee where Emp_id like'" + txtid.Text + "%'");
            DataTable dt = new DataTable();
            con.sda.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void Salary_Caluclate_Load(object sender, EventArgs e)
        {
            string month_name = DateTime.Now.ToString("MMMM");
            txtmonth.Text = month_name;
            con.dataGet("select Monthdate,CONVERT(NVARCHAR(10),StartDate,103) AS StartDate,CONVERT(NVARCHAR(10),End_date,103) AS End_date from setting where month='" + month_name + "' ");
            DataSet dt = new DataSet();
            con.sda.Fill(dt);
            if (dt.Tables[0].Rows.Count > 0)
            {
                txtworkingDays.Text = dt.Tables[0].Rows[0][0].ToString();
                startdate.Text = dt.Tables[0].Rows[0][1].ToString();
                enddate.Text = dt.Tables[0].Rows[0][2].ToString();

            }


        }

        private void Salary_Caluclate_FormClosed(object sender, FormClosedEventArgs e)
        {
            GetForm = null;
        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {
            con.dataGet("Select top(10) Emp_id,Emp_name from employee where Emp_name like'" + txtname.Text + "%'");
            DataTable dt = new DataTable();
            con.sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void ClearData()
        {
            txtid.Clear();
            txtname.Clear();
            txtsalary.Clear();
            txtallownces.Clear();
            txtot.Clear();
            txttax.Clear();
            txtOtRate.Clear();
            txtNoPayDays.Clear();
            txtbase.Clear();
            txtnopay.Clear();
            txtgross.Clear();
            btnsave.Enabled = false;
            btnupdate.Enabled = false;
            btnsave.Enabled = true;
            startdate.Value = DateTime.Now;
            enddate.Value = DateTime.Now;
        }

       
        private void btncal_Click(object sender, EventArgs e)
        {

            //            Gross Pay need to calculate according to the below mentioned formula
            //            Gross Pay = Base_Pay_value – (No_pay_value + Base_Pay_value * government_tax_rate)
            // if (txtid.Text.Trim() == string.Empty || Convert.ToDecimal(txtid.Text) <= 0)
            if (txtid.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Enter Valid empid", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtid.Focus();
                return;
            }

            if (txttax.Text.Trim() == string.Empty || Convert.ToDecimal(txttax.Text) <= 0)
            {
                MessageBox.Show("Enter Valid Tax rate", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txttax.Focus();
                return;
            }

           
            if (txtot.Text.Trim() == string.Empty || Convert.ToDecimal(txtot.Text) <= 0)
            {
                MessageBox.Show("Enter Valid OT", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtot.Focus();
                return;
            }

            if (txtNoPayDays.Text.Trim() == string.Empty || Convert.ToDecimal(txtNoPayDays.Text) <= 0)
            {
                MessageBox.Show("Enter Valid NoPay Days", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNoPayDays.Focus();
                return;
            }

            else

            {
                decimal MonthlySalary = Convert.ToDecimal(txtsalary.Text);
                decimal Allowance = Convert.ToDecimal(txtallownces.Text);
                decimal OtRate = Convert.ToDecimal(txtOtRate.Text);
                decimal OtHours = Convert.ToDecimal(txtot.Text);

                decimal WorkingDays = Convert.ToDecimal(txtworkingDays.Text);
                decimal NopayDays = Convert.ToDecimal(txtNoPayDays.Text);
                decimal GovTax = Convert.ToDecimal(txttax.Text);

                //            Base Pay value = Monthly_Salary + Allowances + (Over_time_rate * no_of_overtime_hours)
                decimal BasPay = (MonthlySalary + Allowance) + (OtRate * OtHours);
                txtbase.Text = BasPay.ToString("N2");
                // NoPay 
                decimal NoPay = ((MonthlySalary + Allowance) / WorkingDays) * NopayDays;
                txtnopay.Text = NoPay.ToString("N2");

                //            Gross Pay = Base_Pay_value – (No_pay_value + Base_Pay_value * government_tax_rate)
                decimal GrossPay = BasPay - (NoPay + (BasPay * (GovTax / 100)));
                txtgross.Text = GrossPay.ToString("N2");
            }

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtid.Text.Trim() == string.Empty)
            {
                MessageBox.Show("invaliid id", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtid.Focus();
                return;

            }

           
            if (txtsalary.Text.Trim() == string.Empty)
            {
                MessageBox.Show("invaliid salary", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtsalary.Focus();
                return;

            }

            if (startdate.Text.Trim() == string.Empty)
            {
                MessageBox.Show("invaliid startdate", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                startdate.Focus();
                return;

            }
            if (enddate.Text.Trim() == string.Empty)
            {
                MessageBox.Show("invaliid enddate", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                enddate.Focus();
                return;

            }
            if (txtworkingDays.Text.Trim() == string.Empty)
            {
                MessageBox.Show("invaliid working days", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtworkingDays.Focus();
                return;

            }
            if (txtmonth.Text.Trim() == string.Empty)
            {
                MessageBox.Show("invaliid month", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtmonth.Focus();
                return;

            }
            if (txtname.Text.Trim() == string.Empty)
            {
                MessageBox.Show("invaliid name", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtname.Focus();
                return;

            }
            if (txtallownces.Text.Trim() == string.Empty)
            {
                MessageBox.Show("invaliid Allownces", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtallownces.Focus();
                return;

            }
            if (txttax.Text.Trim() == string.Empty)
            {
                MessageBox.Show("invaliid tax", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txttax.Focus();
                return;

            }
            if (txtOtRate.Text.Trim() == string.Empty)
            {
                MessageBox.Show("invaliid otrate", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtOtRate.Focus();
                return;

            }
            if (txtot.Text.Trim() == string.Empty)
            {
                MessageBox.Show("invaliid ot", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtot.Focus();
                return;

            }
            if (txtNoPayDays.Text.Trim() == string.Empty)
            {
                MessageBox.Show("invaliid no pay", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNoPayDays.Focus();
                return;

            }
            if (MessageBox.Show("Sure to Save Employee?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //connection con = new connection();
                //String C = "INSERT INTO Salary(Emp_id, Emp_Name, Salary, Allownces, Tax, OT_Rate, OT_Hours, Monthdate, Month, Basepay, Nopay_Deduct, Grosspay, NoPay_Days)VALUES('" + txtid.Text + "','" + txtname.Text + "','" + txtsalary.Text + "','" + txtallownces.Text + "','" + txttax.Text + "','" + txtOtRate.Text + "','" + txtot.Text + "','" + txtworkingDays.Text + "','" + txtmonth.Text + "','" + txtbase.Text + "','" + txtnopay.Text + "','" + txtgross.Text + "','" + txtNoPayDays.Text + "')";
                //con.Datasend(C);
                ObjClsSalary.SaveSalaryDetails(txtid.Text, txtname.Text, txtsalary.Text, txtallownces.Text, txttax.Text, txtOtRate.Text, txtot.Text, txtworkingDays.Text, txtmonth.Text, txtbase.Text, txtnopay.Text, txtgross.Text, txtNoPayDays.Text); ;
                MessageBox.Show("Record Save Succesful", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearData();

            }


        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (txtid.Text.Trim() == string.Empty)
            {
                MessageBox.Show("invaliid id", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtid.Focus();
                return;

            }


            if (txtsalary.Text.Trim() == string.Empty)
            {
                MessageBox.Show("invaliid salary", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtsalary.Focus();
                return;

            }

            if (startdate.Text.Trim() == string.Empty)
            {
                MessageBox.Show("invaliid startdate", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                startdate.Focus();
                return;

            }
            if (enddate.Text.Trim() == string.Empty)
            {
                MessageBox.Show("invaliid enddate", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                enddate.Focus();
                return;

            }
            if (txtworkingDays.Text.Trim() == string.Empty)
            {
                MessageBox.Show("invaliid working days", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtworkingDays.Focus();
                return;

            }
            if (txtmonth.Text.Trim() == string.Empty)
            {
                MessageBox.Show("invaliid month", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtmonth.Focus();
                return;

            }
            if (txtname.Text.Trim() == string.Empty)
            {
                MessageBox.Show("invaliid name", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtname.Focus();
                return;

            }
            if (txtallownces.Text.Trim() == string.Empty)
            {
                MessageBox.Show("invaliid Allownces", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtallownces.Focus();
                return;

            }
            if (txttax.Text.Trim() == string.Empty)
            {
                MessageBox.Show("invaliid tax", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txttax.Focus();
                return;

            }
            if (txtOtRate.Text.Trim() == string.Empty)
            {
                MessageBox.Show("invaliid otrate", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtOtRate.Focus();
                return;

            }
            if (txtot.Text.Trim() == string.Empty)
            {
                MessageBox.Show("invaliid ot", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtot.Focus();
                return;

            }
            if (txtNoPayDays.Text.Trim() == string.Empty)
            {
                MessageBox.Show("invaliid no pay", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNoPayDays.Focus();
                return;

            }
            if (MessageBox.Show("Sure to Update Employee?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //connection con = new connection();
                //String C = "update salary set emp_name='" + txtname.Text + "',salary='" + txtsalary.Text + "',Allownces='" + txtallownces.Text + "',Tax='" + txttax.Text + "',OT_Rate='" + txtOtRate.Text + "',OT_Hours='" + txtot.Text + "',Monthdate='" + txtworkingDays.Text + "',Month='" + txtmonth.Text + "',Basepay='" + txtbase.Text + "',Nopay_Deduct='" + txtnopay.Text + "',Grosspay='" + txtgross.Text + "',NoPay_Days='" + txtNoPayDays.Text + "')";
                //con.Datasend(C);
                ObjClsSalary.UpdateSalaryDetails(txtid.Text,txtname.Text,txtsalary.Text, txtallownces.Text, txttax.Text, txtOtRate.Text, txtot.Text, txtworkingDays.Text, txtmonth.Text, txtbase.Text, txtnopay.Text, txtgross.Text, txtNoPayDays.Text);
                MessageBox.Show("Record Update Succesful", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearData();

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


            if (txtsalary.Text.Trim() == string.Empty)
            {
                MessageBox.Show("invaliid salary", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtsalary.Focus();
                return;

            }

            if (startdate.Text.Trim() == string.Empty)
            {
                MessageBox.Show("invaliid startdate", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                startdate.Focus();
                return;

            }
            if (enddate.Text.Trim() == string.Empty)
            {
                MessageBox.Show("invaliid enddate", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                enddate.Focus();
                return;

            }
            if (txtworkingDays.Text.Trim() == string.Empty)
            {
                MessageBox.Show("invaliid working days", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtworkingDays.Focus();
                return;

            }
            if (txtmonth.Text.Trim() == string.Empty)
            {
                MessageBox.Show("invaliid month", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtmonth.Focus();
                return;

            }
            if (txtname.Text.Trim() == string.Empty)
            {
                MessageBox.Show("invaliid name", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtname.Focus();
                return;

            }
            if (txtallownces.Text.Trim() == string.Empty)
            {
                MessageBox.Show("invaliid Allownces", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtallownces.Focus();
                return;

            }
            if (txttax.Text.Trim() == string.Empty)
            {
                MessageBox.Show("invaliid tax", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txttax.Focus();
                return;

            }
            if (txtOtRate.Text.Trim() == string.Empty)
            {
                MessageBox.Show("invaliid otrate", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtOtRate.Focus();
                return;

            }
            if (txtot.Text.Trim() == string.Empty)
            {
                MessageBox.Show("invaliid ot", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtot.Focus();
                return;

            }
            if (txtNoPayDays.Text.Trim() == string.Empty)
            {
                MessageBox.Show("invaliid no pay", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNoPayDays.Focus();
                return;

            }
            if (MessageBox.Show("Sure to Delete Employee?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //connection con = new connection();
                //String C = "Delete from salary where emp_id='" + txtid.Text + "'";
                //con.Datasend(C);
                ObjClsSalary.DeleteSalaryDetails(txtid.Text, txtname.Text, txtsalary.Text, txtallownces.Text, txttax.Text, txtOtRate.Text, txtot.Text, txtworkingDays.Text, txtmonth.Text, txtbase.Text, txtnopay.Text, txtgross.Text, txtNoPayDays.Text);
                MessageBox.Show("Delete Succesful", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearData();

            }
            else
            {
                MessageBox.Show("User Not Exists... Try Save", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            ClearData();
        }
    }
}