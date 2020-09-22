namespace Medi_Help
{
    partial class Cashier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cashier));
            this.allTests = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.test = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dob = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.address = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.female = new System.Windows.Forms.RadioButton();
            this.other = new System.Windows.Forms.RadioButton();
            this.male = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.contact = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.rDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            this.des = new System.Windows.Forms.RichTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.paidAmount = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.nic = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.allTests)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // allTests
            // 
            this.allTests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allTests.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column1,
            this.Column2,
            this.Column3});
            this.allTests.Location = new System.Drawing.Point(26, 150);
            this.allTests.Name = "allTests";
            this.allTests.RowHeadersWidth = 51;
            this.allTests.RowTemplate.Height = 24;
            this.allTests.Size = new System.Drawing.Size(566, 181);
            this.allTests.TabIndex = 38;
            this.allTests.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.allTests_CellContentClick);
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Report Number";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Test";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Required Date";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Price";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 17);
            this.label5.TabIndex = 37;
            this.label5.Text = "Required Date";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 17);
            this.label8.TabIndex = 27;
            this.label8.Text = "Test";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // test
            // 
            this.test.FormattingEnabled = true;
            this.test.Location = new System.Drawing.Point(149, 35);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(252, 24);
            this.test.TabIndex = 26;
            this.test.SelectedIndexChanged += new System.EventHandler(this.test_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dob);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.address);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.female);
            this.groupBox1.Controls.Add(this.other);
            this.groupBox1.Controls.Add(this.male);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.contact);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.Location = new System.Drawing.Point(12, 154);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(598, 253);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal Details";
            // 
            // dob
            // 
            this.dob.CheckedState.Parent = this.dob;
            this.dob.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dob.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dob.HoverState.Parent = this.dob;
            this.dob.Location = new System.Drawing.Point(128, 99);
            this.dob.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dob.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dob.Name = "dob";
            this.dob.ShadowDecoration.Parent = this.dob;
            this.dob.Size = new System.Drawing.Size(252, 28);
            this.dob.TabIndex = 58;
            this.dob.Value = new System.DateTime(2020, 9, 14, 1, 46, 52, 417);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CheckedState.Parent = this.dateTimePicker1;
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateTimePicker1.HoverState.Parent = this.dateTimePicker1;
            this.dateTimePicker1.Location = new System.Drawing.Point(126, 26);
            this.dateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShadowDecoration.Parent = this.dateTimePicker1;
            this.dateTimePicker1.Size = new System.Drawing.Size(252, 28);
            this.dateTimePicker1.TabIndex = 57;
            this.dateTimePicker1.Value = new System.DateTime(2020, 9, 14, 1, 46, 52, 417);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(126, 225);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(241, 22);
            this.address.TabIndex = 56;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(27, 228);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 17);
            this.label15.TabIndex = 55;
            this.label15.Text = "Address";
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.Location = new System.Drawing.Point(209, 144);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(75, 21);
            this.female.TabIndex = 53;
            this.female.TabStop = true;
            this.female.Text = "Female";
            this.female.UseVisualStyleBackColor = true;
            // 
            // other
            // 
            this.other.AutoSize = true;
            this.other.Location = new System.Drawing.Point(291, 142);
            this.other.Name = "other";
            this.other.Size = new System.Drawing.Size(65, 21);
            this.other.TabIndex = 52;
            this.other.TabStop = true;
            this.other.Text = "Other";
            this.other.UseVisualStyleBackColor = true;
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Location = new System.Drawing.Point(125, 142);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(59, 21);
            this.male.TabIndex = 51;
            this.male.TabStop = true;
            this.male.Text = "Male";
            this.male.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 17);
            this.label7.TabIndex = 47;
            this.label7.Text = "Date";
            // 
            // contact
            // 
            this.contact.Location = new System.Drawing.Point(125, 184);
            this.contact.MaxLength = 10;
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(241, 22);
            this.contact.TabIndex = 45;
            this.contact.TextChanged += new System.EventHandler(this.contact_TextChanged);
            this.contact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.contact_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 44;
            this.label6.Text = "Contact";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 43;
            this.label3.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 42;
            this.label4.Text = "Date of Birth";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 38;
            this.label1.Text = "Name";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(125, 64);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(241, 22);
            this.name.TabIndex = 37;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.guna2Button3);
            this.groupBox2.Controls.Add(this.guna2Button2);
            this.groupBox2.Controls.Add(this.rDate);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.test);
            this.groupBox2.Controls.Add(this.allTests);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 413);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(598, 343);
            this.groupBox2.TabIndex = 48;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Report Details";
            // 
            // guna2Button3
            // 
            this.guna2Button3.CheckedState.Parent = this.guna2Button3;
            this.guna2Button3.CustomImages.Parent = this.guna2Button3;
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.HoverState.Parent = this.guna2Button3;
            this.guna2Button3.Location = new System.Drawing.Point(424, 77);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.ShadowDecoration.Parent = this.guna2Button3;
            this.guna2Button3.Size = new System.Drawing.Size(156, 33);
            this.guna2Button3.TabIndex = 87;
            this.guna2Button3.Text = "Clear";
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Location = new System.Drawing.Point(424, 35);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(156, 33);
            this.guna2Button2.TabIndex = 86;
            this.guna2Button2.Text = "Add";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // rDate
            // 
            this.rDate.CheckedState.Parent = this.rDate;
            this.rDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.rDate.HoverState.Parent = this.rDate;
            this.rDate.Location = new System.Drawing.Point(149, 77);
            this.rDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.rDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.rDate.Name = "rDate";
            this.rDate.ShadowDecoration.Parent = this.rDate;
            this.rDate.Size = new System.Drawing.Size(252, 28);
            this.rDate.TabIndex = 58;
            this.rDate.Value = new System.DateTime(2020, 9, 14, 1, 46, 52, 417);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGrid);
            this.groupBox3.Location = new System.Drawing.Point(631, 48);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(779, 444);
            this.groupBox3.TabIndex = 49;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Available Reports List";
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(6, 30);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersWidth = 51;
            this.dataGrid.RowTemplate.Height = 24;
            this.dataGrid.Size = new System.Drawing.Size(767, 408);
            this.dataGrid.TabIndex = 45;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.guna2Button4);
            this.groupBox4.Controls.Add(this.guna2Button5);
            this.groupBox4.Controls.Add(this.des);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.txtBalance);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.paidAmount);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.total);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Location = new System.Drawing.Point(631, 514);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(779, 242);
            this.groupBox4.TabIndex = 50;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Payment Details";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // guna2Button4
            // 
            this.guna2Button4.CheckedState.Parent = this.guna2Button4;
            this.guna2Button4.CustomImages.Parent = this.guna2Button4;
            this.guna2Button4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.HoverState.Parent = this.guna2Button4;
            this.guna2Button4.Location = new System.Drawing.Point(596, 91);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.ShadowDecoration.Parent = this.guna2Button4;
            this.guna2Button4.Size = new System.Drawing.Size(156, 33);
            this.guna2Button4.TabIndex = 88;
            this.guna2Button4.Text = "Done";
            this.guna2Button4.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // guna2Button5
            // 
            this.guna2Button5.CheckedState.Parent = this.guna2Button5;
            this.guna2Button5.CustomImages.Parent = this.guna2Button5;
            this.guna2Button5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button5.ForeColor = System.Drawing.Color.White;
            this.guna2Button5.HoverState.Parent = this.guna2Button5;
            this.guna2Button5.Location = new System.Drawing.Point(596, 52);
            this.guna2Button5.Name = "guna2Button5";
            this.guna2Button5.ShadowDecoration.Parent = this.guna2Button5;
            this.guna2Button5.Size = new System.Drawing.Size(156, 33);
            this.guna2Button5.TabIndex = 89;
            this.guna2Button5.Text = "Clear";
            this.guna2Button5.Click += new System.EventHandler(this.guna2Button5_Click);
            // 
            // des
            // 
            this.des.Location = new System.Drawing.Point(141, 161);
            this.des.Name = "des";
            this.des.Size = new System.Drawing.Size(320, 69);
            this.des.TabIndex = 53;
            this.des.Text = "";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(42, 161);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 17);
            this.label14.TabIndex = 52;
            this.label14.Text = "Description";
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(141, 106);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(241, 22);
            this.txtBalance.TabIndex = 49;
            this.txtBalance.TextChanged += new System.EventHandler(this.txtBalance_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(42, 109);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 17);
            this.label11.TabIndex = 48;
            this.label11.Text = "Balance";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // paidAmount
            // 
            this.paidAmount.Location = new System.Drawing.Point(141, 65);
            this.paidAmount.Name = "paidAmount";
            this.paidAmount.Size = new System.Drawing.Size(241, 22);
            this.paidAmount.TabIndex = 47;
            this.paidAmount.TextChanged += new System.EventHandler(this.paidAmount_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(42, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 17);
            this.label10.TabIndex = 46;
            this.label10.Text = "paid Amount";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // total
            // 
            this.total.Location = new System.Drawing.Point(141, 34);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(241, 22);
            this.total.TabIndex = 45;
            this.total.TextChanged += new System.EventHandler(this.total_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(42, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 17);
            this.label9.TabIndex = 44;
            this.label9.Text = "Total Amount";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.guna2Button1);
            this.groupBox5.Controls.Add(this.nic);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Location = new System.Drawing.Point(12, 48);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(592, 100);
            this.groupBox5.TabIndex = 51;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Search Patient";
            // 
            // guna2Button1
            // 
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(390, 37);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(156, 38);
            this.guna2Button1.TabIndex = 85;
            this.guna2Button1.Text = "Search";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // nic
            // 
            this.nic.Location = new System.Drawing.Point(126, 46);
            this.nic.MaxLength = 10;
            this.nic.Name = "nic";
            this.nic.Size = new System.Drawing.Size(241, 22);
            this.nic.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 17);
            this.label2.TabIndex = 41;
            this.label2.Text = "NIC";
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.CheckedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.HoverState.Image")));
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(34, 34);
            this.guna2ImageButton1.HoverState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.Image")));
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(32, 32);
            this.guna2ImageButton1.Location = new System.Drawing.Point(1374, 6);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.PressedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Size = new System.Drawing.Size(41, 39);
            this.guna2ImageButton1.TabIndex = 86;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // Cashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 772);
            this.Controls.Add(this.guna2ImageButton1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Cashier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cashier";
            this.Load += new System.EventHandler(this.Cashier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.allTests)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView allTests;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox test;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox contact;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox paidAmount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox total;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton female;
        private System.Windows.Forms.RadioButton other;
        private System.Windows.Forms.RadioButton male;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox nic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.RichTextBox des;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Label label15;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dob;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTimePicker1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2DateTimePicker rDate;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}