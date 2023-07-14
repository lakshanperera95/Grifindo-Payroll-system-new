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
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();

        }
        public static Setting GetForm { get; set; }
        connection con = new connection();
        ClsSettings ObjClsSettings = new ClsSettings();
     
        private void ClearData()
        {
            txtmonthid.Clear();
            txtmonth.Clear();
            startdate.Value = DateTime.Now;
            enddate.Value = DateTime.Now;
            txtsdate.Clear();
            Txtleave.Clear();
            btnsave.Enabled = false;
            btnupdate.Enabled = false;
            btnsave.Enabled = true;

        }

        private void txtmonthid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                DataSet dt = new DataSet();
                dt = ObjClsSettings.LoadMonthDetails(txtmonthid.Text);

                if (dt.Tables[0].Rows.Count > 0)
                {
                    txtmonth.Text = dt.Tables[0].Rows[0][0].ToString();
                    startdate.Text = dt.Tables[0].Rows[0][1].ToString();
                    enddate.Text = dt.Tables[0].Rows[0][2].ToString();
                    txtsdate.Text = dt.Tables[0].Rows[0][3].ToString();
                    Txtleave.Text = dt.Tables[0].Rows[0][4].ToString();

                }
                txtmonth.Focus();
            }
            
        }

        private void txtmonth_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtmonth.Text.Trim() != string.Empty)
            {

                {
                    startdate.Focus();

                }
            }
        }

        private void startdate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && startdate.Text.Trim() != string.Empty)
            {

                {
                    enddate.Focus();

                }
            }
        }

        private void txtsdate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtsdate.Text.Trim() != string.Empty)
            {

                {
                    Txtleave.Focus();

                }
            }
        }

        private void txtmonthid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void Setting_FormClosing(object sender, FormClosingEventArgs e)
        {
            GetForm = null;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtmonthid.Text.Trim() == string.Empty)
            {
                MessageBox.Show("invaliid Month id", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtmonthid.Focus();
                return;

            }
            if (txtmonth.Text.Trim() == string.Empty)
            {
                MessageBox.Show("invaliid Month", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtmonth.Focus();
                return;

            }
            if (startdate.Text.Trim() == string.Empty)
            {
                MessageBox.Show("invaliid start date", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                startdate.Focus();
                return;

            }
            if (enddate.Text.Trim() == string.Empty)
            {
                MessageBox.Show("invaliid enddate", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                enddate.Focus();
                return;

            }
            if (txtsdate.Text.Trim() == string.Empty)
            {
                MessageBox.Show("invaliid Date range", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtsdate.Focus();
                return;

            }
            if (Txtleave.Text.Trim() == string.Empty)
            {
                MessageBox.Show("invaliid Leave", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Txtleave.Focus();
                return;

            }
            if (MessageBox.Show("Sure to Save Employee?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // connection con = new connection();
                //String C = "INSERT INTO Setting(Setting_id, month, Monthdate, StartDate, End_date, lever_per_year)VALUES('" + txtmonthid.Text + "','" + txtmonth.Text + "','" + txtsdate.Text + "','" + startdate.Text + "','" + enddate.Text + "','" + Txtleave.Text + "')";
                //con.Datasend(C);
                ObjClsSettings.SaveMonthDetails(txtmonthid.Text, txtmonth.Text, txtsdate.Text, startdate.Text, enddate.Text, Txtleave.Text);
                MessageBox.Show("Record Save Succesful", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearData();

            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (txtmonthid.Text.Trim() == string.Empty)
            {
                MessageBox.Show("invaliid Month id", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtmonthid.Focus();
                return;

            }
            if (txtmonth.Text.Trim() == string.Empty)
            {
                MessageBox.Show("invaliid Month", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtmonth.Focus();
                return;

            }
            if (startdate.Text.Trim() == string.Empty)
            {
                MessageBox.Show("invaliid start date", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                startdate.Focus();
                return;

            }
            if (enddate.Text.Trim() == string.Empty)
            {
                MessageBox.Show("invaliid enddate", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                enddate.Focus();
                return;

            }
            if (txtsdate.Text.Trim() == string.Empty)
            {
                MessageBox.Show("invaliid Date range", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtsdate.Focus();
                return;

            }
            if (Txtleave.Text.Trim() == string.Empty)
            {
                MessageBox.Show("invaliid Leave", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Txtleave.Focus();
                return;

            }
            if (MessageBox.Show("Sure to update Employee?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //connection con = new connection();
                //String C = "update Setting set setting_id='" + txtmonthid.Text + "',month='" + txtmonth.Text + "',Monthdate='" + txtsdate.Text + "',startDate='" + startdate.Text + "',End_date='"+ enddate.Text + "',leaver_per_year='" + Txtleave.Text + "')";
                //con.Datasend(C);
                ObjClsSettings.UpdateMonthDetails(txtmonthid.Text, txtmonth.Text, txtsdate.Text, startdate.Text, enddate.Text, Txtleave.Text);
                MessageBox.Show("Record update Succesful", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearData();

            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void Setting_Load(object sender, EventArgs e)
        {

        }
    }
}
