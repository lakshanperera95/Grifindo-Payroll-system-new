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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.cmbEmpRole = new System.Windows.Forms.ComboBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtphoneno = new System.Windows.Forms.TextBox();
            this.dtEmpDetailsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Grifindo_Payroll_system_new.DataSet1();
            this.empidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emp_Birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emp_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnsave = new DevExpress.XtraEditors.SimpleButton();
            this.btndelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnupdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnexit = new DevExpress.XtraEditors.SimpleButton();
            this.birthday = new System.Windows.Forms.DateTimePicker();
            this.dtEmpDetailsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.txtsalary = new System.Windows.Forms.TextBox();
            this.txtot = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtallownces = new System.Windows.Forms.TextBox();
            this.dtEmpDetailsBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.dtEmpDetailsBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.dgEmployee = new System.Windows.Forms.DataGridView();
            this.empidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empaddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empaddress1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emp_salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emp_Allowances = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empBirthdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emproleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empPhonenoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emp_OT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtEmpDetailsBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.dtEmpDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnclear = new DevExpress.XtraEditors.SimpleButton();
            this.dtEmpDetailsBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtEmpDetailsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEmpDetailsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEmpDetailsBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEmpDetailsBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEmpDetailsBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEmpDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEmpDetailsBindingSource6)).BeginInit();
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
            this.txtname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtname_KeyDown);
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
            this.txtid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtid_KeyDown);
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
            this.txtaddress1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtaddress1_KeyDown);
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
            this.txtemail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtemail_KeyDown);
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
            // cmbEmpRole
            // 
            this.cmbEmpRole.DataSource = this.dtEmpDetailsBindingSource6;
            this.cmbEmpRole.FormattingEnabled = true;
            this.cmbEmpRole.Location = new System.Drawing.Point(580, 103);
            this.cmbEmpRole.Name = "cmbEmpRole";
            this.cmbEmpRole.Size = new System.Drawing.Size(220, 21);
            this.cmbEmpRole.TabIndex = 11;
            this.cmbEmpRole.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.cmbEmpRole.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbEmpRole_KeyDown);
            // 
            // txtaddress
            // 
            this.txtaddress.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtaddress.Location = new System.Drawing.Point(165, 107);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(220, 23);
            this.txtaddress.TabIndex = 12;
            this.txtaddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtaddress_KeyDown);
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
            this.txtphoneno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtphoneno_KeyDown);
            // 
            // dtEmpDetailsBindingSource2
            // 
            this.dtEmpDetailsBindingSource2.DataMember = "dtEmpDetails";
            this.dtEmpDetailsBindingSource2.DataSource = this.dataSet1BindingSource;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
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
            this.btnsave.Location = new System.Drawing.Point(391, 219);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(94, 28);
            this.btnsave.TabIndex = 18;
            this.btnsave.Text = "Save";
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btndelete
            // 
            this.btndelete.Appearance.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Appearance.ForeColor = System.Drawing.Color.Red;
            this.btndelete.Appearance.Options.UseFont = true;
            this.btndelete.Appearance.Options.UseForeColor = true;
            this.btndelete.Location = new System.Drawing.Point(676, 219);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(94, 28);
            this.btndelete.TabIndex = 19;
            this.btndelete.Text = "Delete";
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Appearance.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.btnupdate.Appearance.Options.UseFont = true;
            this.btnupdate.Appearance.Options.UseForeColor = true;
            this.btnupdate.Location = new System.Drawing.Point(581, 219);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(94, 28);
            this.btnupdate.TabIndex = 20;
            this.btnupdate.Text = "Update";
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnexit
            // 
            this.btnexit.Appearance.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.btnexit.Appearance.Options.UseFont = true;
            this.btnexit.Appearance.Options.UseForeColor = true;
            this.btnexit.Location = new System.Drawing.Point(771, 219);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(94, 28);
            this.btnexit.TabIndex = 21;
            this.btnexit.Text = "Exit";
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // birthday
            // 
            this.birthday.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birthday.Location = new System.Drawing.Point(580, 63);
            this.birthday.Name = "birthday";
            this.birthday.Size = new System.Drawing.Size(220, 23);
            this.birthday.TabIndex = 22;
            this.birthday.KeyDown += new System.Windows.Forms.KeyEventHandler(this.birthday_KeyDown);
            // 
            // dtEmpDetailsBindingSource1
            // 
            this.dtEmpDetailsBindingSource1.DataMember = "dtEmpDetails";
            this.dtEmpDetailsBindingSource1.DataSource = this.dataSet1BindingSource;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(57, 186);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 19);
            this.label9.TabIndex = 23;
            this.label9.Text = "Basic salary :";
            // 
            // txtsalary
            // 
            this.txtsalary.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsalary.Location = new System.Drawing.Point(165, 186);
            this.txtsalary.Name = "txtsalary";
            this.txtsalary.Size = new System.Drawing.Size(220, 23);
            this.txtsalary.TabIndex = 24;
            // 
            // txtot
            // 
            this.txtot.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtot.Location = new System.Drawing.Point(580, 182);
            this.txtot.Name = "txtot";
            this.txtot.Size = new System.Drawing.Size(220, 23);
            this.txtot.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(462, 186);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 19);
            this.label10.TabIndex = 25;
            this.label10.Text = "OT for 1hour :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(14, 224);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(138, 19);
            this.label11.TabIndex = 27;
            this.label11.Text = "Other Allowances :";
            // 
            // txtallownces
            // 
            this.txtallownces.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtallownces.Location = new System.Drawing.Point(165, 224);
            this.txtallownces.Name = "txtallownces";
            this.txtallownces.Size = new System.Drawing.Size(220, 23);
            this.txtallownces.TabIndex = 28;
            // 
            // dtEmpDetailsBindingSource3
            // 
            this.dtEmpDetailsBindingSource3.DataMember = "dtEmpDetails";
            this.dtEmpDetailsBindingSource3.DataSource = this.dataSet1BindingSource;
            // 
            // dtEmpDetailsBindingSource4
            // 
            this.dtEmpDetailsBindingSource4.DataMember = "dtEmpDetails";
            this.dtEmpDetailsBindingSource4.DataSource = this.dataSet1BindingSource;
            // 
            // dgEmployee
            // 
            this.dgEmployee.AllowUserToAddRows = false;
            this.dgEmployee.AllowUserToDeleteRows = false;
            this.dgEmployee.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgEmployee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empidDataGridViewTextBoxColumn1,
            this.empnameDataGridViewTextBoxColumn,
            this.empaddressDataGridViewTextBoxColumn,
            this.empaddress1DataGridViewTextBoxColumn,
            this.Emp_salary,
            this.Emp_Allowances,
            this.empEmailDataGridViewTextBoxColumn,
            this.empBirthdayDataGridViewTextBoxColumn,
            this.emproleDataGridViewTextBoxColumn,
            this.empPhonenoDataGridViewTextBoxColumn,
            this.Emp_OT});
            this.dgEmployee.DataSource = this.dtEmpDetailsBindingSource5;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgEmployee.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgEmployee.Location = new System.Drawing.Point(-1, 253);
            this.dgEmployee.Name = "dgEmployee";
            this.dgEmployee.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgEmployee.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgEmployee.Size = new System.Drawing.Size(883, 195);
            this.dgEmployee.TabIndex = 17;
            this.dgEmployee.DoubleClick += new System.EventHandler(this.dgEmployee_DoubleClick);
            // 
            // empidDataGridViewTextBoxColumn1
            // 
            this.empidDataGridViewTextBoxColumn1.DataPropertyName = "Emp_id";
            this.empidDataGridViewTextBoxColumn1.HeaderText = "Emp_id";
            this.empidDataGridViewTextBoxColumn1.Name = "empidDataGridViewTextBoxColumn1";
            this.empidDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // empnameDataGridViewTextBoxColumn
            // 
            this.empnameDataGridViewTextBoxColumn.DataPropertyName = "Emp_name";
            this.empnameDataGridViewTextBoxColumn.HeaderText = "Emp_name";
            this.empnameDataGridViewTextBoxColumn.Name = "empnameDataGridViewTextBoxColumn";
            this.empnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // empaddressDataGridViewTextBoxColumn
            // 
            this.empaddressDataGridViewTextBoxColumn.DataPropertyName = "Emp_address";
            this.empaddressDataGridViewTextBoxColumn.HeaderText = "Emp_address";
            this.empaddressDataGridViewTextBoxColumn.Name = "empaddressDataGridViewTextBoxColumn";
            this.empaddressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // empaddress1DataGridViewTextBoxColumn
            // 
            this.empaddress1DataGridViewTextBoxColumn.DataPropertyName = "Emp_address_1";
            this.empaddress1DataGridViewTextBoxColumn.HeaderText = "Emp_address_1";
            this.empaddress1DataGridViewTextBoxColumn.Name = "empaddress1DataGridViewTextBoxColumn";
            this.empaddress1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Emp_salary
            // 
            this.Emp_salary.DataPropertyName = "Emp_salary";
            this.Emp_salary.HeaderText = "Emp_salary";
            this.Emp_salary.Name = "Emp_salary";
            this.Emp_salary.ReadOnly = true;
            // 
            // Emp_Allowances
            // 
            this.Emp_Allowances.DataPropertyName = "Emp_Allowances";
            this.Emp_Allowances.HeaderText = "Emp_Allowances";
            this.Emp_Allowances.Name = "Emp_Allowances";
            this.Emp_Allowances.ReadOnly = true;
            // 
            // empEmailDataGridViewTextBoxColumn
            // 
            this.empEmailDataGridViewTextBoxColumn.DataPropertyName = "Emp_Email";
            this.empEmailDataGridViewTextBoxColumn.HeaderText = "Emp_Email";
            this.empEmailDataGridViewTextBoxColumn.Name = "empEmailDataGridViewTextBoxColumn";
            this.empEmailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // empBirthdayDataGridViewTextBoxColumn
            // 
            this.empBirthdayDataGridViewTextBoxColumn.DataPropertyName = "Emp_Birthday";
            this.empBirthdayDataGridViewTextBoxColumn.HeaderText = "Emp_Birthday";
            this.empBirthdayDataGridViewTextBoxColumn.Name = "empBirthdayDataGridViewTextBoxColumn";
            this.empBirthdayDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emproleDataGridViewTextBoxColumn
            // 
            this.emproleDataGridViewTextBoxColumn.DataPropertyName = "Emp_role";
            this.emproleDataGridViewTextBoxColumn.HeaderText = "Emp_role";
            this.emproleDataGridViewTextBoxColumn.Name = "emproleDataGridViewTextBoxColumn";
            this.emproleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // empPhonenoDataGridViewTextBoxColumn
            // 
            this.empPhonenoDataGridViewTextBoxColumn.DataPropertyName = "Emp_Phoneno";
            this.empPhonenoDataGridViewTextBoxColumn.HeaderText = "Emp_Phoneno";
            this.empPhonenoDataGridViewTextBoxColumn.Name = "empPhonenoDataGridViewTextBoxColumn";
            this.empPhonenoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Emp_OT
            // 
            this.Emp_OT.DataPropertyName = "Emp_OT";
            this.Emp_OT.HeaderText = "Emp_OT";
            this.Emp_OT.Name = "Emp_OT";
            this.Emp_OT.ReadOnly = true;
            // 
            // dtEmpDetailsBindingSource5
            // 
            this.dtEmpDetailsBindingSource5.DataMember = "dtEmpDetails";
            this.dtEmpDetailsBindingSource5.DataSource = this.dataSet1BindingSource;
            // 
            // dtEmpDetailsBindingSource
            // 
            this.dtEmpDetailsBindingSource.DataMember = "dtEmpDetails";
            this.dtEmpDetailsBindingSource.DataSource = this.dataSet1;
            // 
            // btnclear
            // 
            this.btnclear.Appearance.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.btnclear.Appearance.Options.UseFont = true;
            this.btnclear.Appearance.Options.UseForeColor = true;
            this.btnclear.Location = new System.Drawing.Point(486, 219);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(94, 28);
            this.btnclear.TabIndex = 72;
            this.btnclear.Text = "Clear";
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // dtEmpDetailsBindingSource6
            // 
            this.dtEmpDetailsBindingSource6.DataMember = "dtEmpDetails";
            this.dtEmpDetailsBindingSource6.DataSource = this.dataSet1BindingSource;
            // 
            // FrmUserRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 448);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.dgEmployee);
            this.Controls.Add(this.txtallownces);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtot);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtsalary);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.birthday);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.txtphoneno);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.cmbEmpRole);
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
            this.MaximizeBox = false;
            this.Name = "FrmUserRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Registration";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmUserRegister_FormClosed);
            this.Load += new System.EventHandler(this.FrmUserRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtEmpDetailsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEmpDetailsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEmpDetailsBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEmpDetailsBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEmpDetailsBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEmpDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEmpDetailsBindingSource6)).EndInit();
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
        private System.Windows.Forms.ComboBox cmbEmpRole;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtphoneno;
        private System.Windows.Forms.BindingSource dtEmpDetailsBindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.DataGridViewTextBoxColumn empidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emp_Birthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emp_address;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private DevExpress.XtraEditors.SimpleButton btnsave;
        private DevExpress.XtraEditors.SimpleButton btndelete;
        private DevExpress.XtraEditors.SimpleButton btnupdate;
        private DevExpress.XtraEditors.SimpleButton btnexit;
        private System.Windows.Forms.DateTimePicker birthday;
        private System.Windows.Forms.BindingSource dtEmpDetailsBindingSource1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtsalary;
        private System.Windows.Forms.TextBox txtot;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtallownces;
        private System.Windows.Forms.BindingSource dtEmpDetailsBindingSource2;
        private System.Windows.Forms.BindingSource dtEmpDetailsBindingSource4;
        private System.Windows.Forms.BindingSource dtEmpDetailsBindingSource3;
        private System.Windows.Forms.DataGridView dgEmployee;
        private System.Windows.Forms.BindingSource dtEmpDetailsBindingSource5;
        private System.Windows.Forms.DataGridViewTextBoxColumn empidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn empnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empaddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empaddress1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emp_salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emp_Allowances;
        private System.Windows.Forms.DataGridViewTextBoxColumn empEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empBirthdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emproleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empPhonenoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emp_OT;
        private DevExpress.XtraEditors.SimpleButton btnclear;
        private System.Windows.Forms.BindingSource dtEmpDetailsBindingSource6;
    }
}