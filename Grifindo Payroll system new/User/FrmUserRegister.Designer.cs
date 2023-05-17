namespace Grifindo_Payroll_system_new.User
{
    partial class FrmUserRegister
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUserRegister));
            this.label1 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtaddress1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtphoneno = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.empidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empPhonenoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empBirthdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empaddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empaddress1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emproleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtEmpDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Grifindo_Payroll_system_new.DataSet1();
            this.empidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emp_Birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emp_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnsave = new DevExpress.XtraEditors.SimpleButton();
            this.btndelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnupdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnexit = new DevExpress.XtraEditors.SimpleButton();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.birthday = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEmpDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Name :";
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(165, 64);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(220, 23);
            this.txtname.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Employee ID :";
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(165, 21);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(220, 23);
            this.txtid.TabIndex = 3;
            this.txtid.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Employee Address :";
            // 
            // txtaddress1
            // 
            this.txtaddress1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtaddress1.Location = new System.Drawing.Point(165, 147);
            this.txtaddress1.Name = "txtaddress1";
            this.txtaddress1.Size = new System.Drawing.Size(220, 23);
            this.txtaddress1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(442, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Employee Email :";
            // 
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtemail.Location = new System.Drawing.Point(580, 22);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(220, 23);
            this.txtemail.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(420, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Employee Birthday :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(449, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Employee Role :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(580, 103);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(220, 21);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtaddress
            // 
            this.txtaddress.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtaddress.Location = new System.Drawing.Point(165, 107);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(220, 23);
            this.txtaddress.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(2, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = "Employee Address 1:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(420, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 19);
            this.label8.TabIndex = 14;
            this.label8.Text = "Employee Phone No :";
            // 
            // txtphoneno
            // 
            this.txtphoneno.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtphoneno.Location = new System.Drawing.Point(580, 143);
            this.txtphoneno.Name = "txtphoneno";
            this.txtphoneno.Size = new System.Drawing.Size(220, 23);
            this.txtphoneno.TabIndex = 15;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empidDataGridViewTextBoxColumn1,
            this.empnameDataGridViewTextBoxColumn,
            this.empPhonenoDataGridViewTextBoxColumn,
            this.empBirthdayDataGridViewTextBoxColumn,
            this.empaddressDataGridViewTextBoxColumn,
            this.empaddress1DataGridViewTextBoxColumn,
            this.emproleDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dtEmpDetailsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 210);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(866, 226);
            this.dataGridView1.TabIndex = 17;
            // 
            // empidDataGridViewTextBoxColumn1
            // 
            this.empidDataGridViewTextBoxColumn1.DataPropertyName = "Emp_id";
            this.empidDataGridViewTextBoxColumn1.HeaderText = "Emp_id";
            this.empidDataGridViewTextBoxColumn1.Name = "empidDataGridViewTextBoxColumn1";
            this.empidDataGridViewTextBoxColumn1.ReadOnly = true;
            this.empidDataGridViewTextBoxColumn1.Width = 50;
            // 
            // empnameDataGridViewTextBoxColumn
            // 
            this.empnameDataGridViewTextBoxColumn.DataPropertyName = "Emp_name";
            this.empnameDataGridViewTextBoxColumn.HeaderText = "Emp_name";
            this.empnameDataGridViewTextBoxColumn.Name = "empnameDataGridViewTextBoxColumn";
            this.empnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.empnameDataGridViewTextBoxColumn.Width = 150;
            // 
            // empPhonenoDataGridViewTextBoxColumn
            // 
            this.empPhonenoDataGridViewTextBoxColumn.DataPropertyName = "Emp_Phoneno";
            this.empPhonenoDataGridViewTextBoxColumn.HeaderText = "Emp_Phoneno";
            this.empPhonenoDataGridViewTextBoxColumn.Name = "empPhonenoDataGridViewTextBoxColumn";
            this.empPhonenoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // empBirthdayDataGridViewTextBoxColumn
            // 
            this.empBirthdayDataGridViewTextBoxColumn.DataPropertyName = "Emp_Birthday";
            this.empBirthdayDataGridViewTextBoxColumn.HeaderText = "Emp_Birthday";
            this.empBirthdayDataGridViewTextBoxColumn.Name = "empBirthdayDataGridViewTextBoxColumn";
            this.empBirthdayDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // empaddressDataGridViewTextBoxColumn
            // 
            this.empaddressDataGridViewTextBoxColumn.DataPropertyName = "Emp_address";
            this.empaddressDataGridViewTextBoxColumn.HeaderText = "Emp_address";
            this.empaddressDataGridViewTextBoxColumn.Name = "empaddressDataGridViewTextBoxColumn";
            this.empaddressDataGridViewTextBoxColumn.ReadOnly = true;
            this.empaddressDataGridViewTextBoxColumn.Width = 150;
            // 
            // empaddress1DataGridViewTextBoxColumn
            // 
            this.empaddress1DataGridViewTextBoxColumn.DataPropertyName = " Emp_address_1";
            this.empaddress1DataGridViewTextBoxColumn.HeaderText = " Emp_address_1";
            this.empaddress1DataGridViewTextBoxColumn.Name = "empaddress1DataGridViewTextBoxColumn";
            this.empaddress1DataGridViewTextBoxColumn.ReadOnly = true;
            this.empaddress1DataGridViewTextBoxColumn.Width = 150;
            // 
            // emproleDataGridViewTextBoxColumn
            // 
            this.emproleDataGridViewTextBoxColumn.DataPropertyName = "Emp_role";
            this.emproleDataGridViewTextBoxColumn.HeaderText = "Emp_role";
            this.emproleDataGridViewTextBoxColumn.Name = "emproleDataGridViewTextBoxColumn";
            this.emproleDataGridViewTextBoxColumn.ReadOnly = true;
            this.emproleDataGridViewTextBoxColumn.Width = 140;
            // 
            // dtEmpDetailsBindingSource
            // 
            this.dtEmpDetailsBindingSource.DataMember = "dtEmpDetails";
            this.dtEmpDetailsBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empidDataGridViewTextBoxColumn
            // 
            this.empidDataGridViewTextBoxColumn.DataPropertyName = "Emp_id";
            this.empidDataGridViewTextBoxColumn.HeaderText = "Emp_id";
            this.empidDataGridViewTextBoxColumn.Name = "empidDataGridViewTextBoxColumn";
            this.empidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Emp_Birthday
            // 
            this.Emp_Birthday.DataPropertyName = "Emp_Birthday";
            this.Emp_Birthday.HeaderText = "Emp_Birthday";
            this.Emp_Birthday.Name = "Emp_Birthday";
            // 
            // Emp_address
            // 
            this.Emp_address.DataPropertyName = "Emp_address";
            this.Emp_address.HeaderText = "Emp_address";
            this.Emp_address.Name = "Emp_address";
            // 
            // btnsave
            // 
            this.btnsave.Appearance.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.btnsave.Appearance.Options.UseFont = true;
            this.btnsave.Appearance.Options.UseForeColor = true;
            this.btnsave.Location = new System.Drawing.Point(143, 176);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(94, 28);
            this.btnsave.TabIndex = 18;
            this.btnsave.Text = "Save";
            // 
            // btndelete
            // 
            this.btndelete.Appearance.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Appearance.ForeColor = System.Drawing.Color.Red;
            this.btndelete.Appearance.Options.UseFont = true;
            this.btndelete.Appearance.Options.UseForeColor = true;
            this.btndelete.Location = new System.Drawing.Point(468, 176);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(94, 28);
            this.btndelete.TabIndex = 19;
            this.btndelete.Text = "Delete";
            // 
            // btnupdate
            // 
            this.btnupdate.Appearance.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.btnupdate.Appearance.Options.UseFont = true;
            this.btnupdate.Appearance.Options.UseForeColor = true;
            this.btnupdate.Location = new System.Drawing.Point(311, 176);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(94, 28);
            this.btnupdate.TabIndex = 20;
            this.btnupdate.Text = "Update";
            // 
            // btnexit
            // 
            this.btnexit.Appearance.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.btnexit.Appearance.Options.UseFont = true;
            this.btnexit.Appearance.Options.UseForeColor = true;
            this.btnexit.Location = new System.Drawing.Point(644, 176);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(94, 28);
            this.btnexit.TabIndex = 21;
            this.btnexit.Text = "Exit";
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // birthday
            // 
            this.birthday.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birthday.Location = new System.Drawing.Point(580, 63);
            this.birthday.Name = "birthday";
            this.birthday.Size = new System.Drawing.Size(220, 23);
            this.birthday.TabIndex = 22;
            // 
            // FrmUserRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 448);
            this.Controls.Add(this.birthday);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtphoneno);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtaddress1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmUserRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmUserRegister";
            this.Load += new System.EventHandler(this.FrmUserRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEmpDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtaddress1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtphoneno;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource dtEmpDetailsBindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.DataGridViewTextBoxColumn empidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn empnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empPhonenoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empBirthdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empaddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empaddress1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emproleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emp_Birthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emp_address;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private DevExpress.XtraEditors.SimpleButton btnsave;
        private DevExpress.XtraEditors.SimpleButton btndelete;
        private DevExpress.XtraEditors.SimpleButton btnupdate;
        private DevExpress.XtraEditors.SimpleButton btnexit;
        private System.Windows.Forms.DateTimePicker birthday;
    }
}