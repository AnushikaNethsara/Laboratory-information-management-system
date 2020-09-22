namespace Medi_Help
{
    partial class Mlt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mlt));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dob = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.other = new Guna.UI2.WinForms.Guna2RadioButton();
            this.female = new Guna.UI2.WinForms.Guna2RadioButton();
            this.male = new Guna.UI2.WinForms.Guna2RadioButton();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.test = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nic = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.contact = new System.Windows.Forms.TextBox();
            this.panelTest = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.type = new System.Windows.Forms.ComboBox();
            this.chemicalUsed = new System.Windows.Forms.ComboBox();
            this.quantity = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.dob);
            this.groupBox1.Controls.Add(this.other);
            this.groupBox1.Controls.Add(this.female);
            this.groupBox1.Controls.Add(this.male);
            this.groupBox1.Controls.Add(this.guna2Button1);
            this.groupBox1.Controls.Add(this.test);
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nic);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.contact);
            this.groupBox1.Location = new System.Drawing.Point(14, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(508, 319);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Patient Details";
            // 
            // dob
            // 
            this.dob.CheckedState.Parent = this.dob;
            this.dob.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dob.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dob.HoverState.Parent = this.dob;
            this.dob.Location = new System.Drawing.Point(149, 101);
            this.dob.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dob.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dob.Name = "dob";
            this.dob.ShadowDecoration.Parent = this.dob;
            this.dob.Size = new System.Drawing.Size(287, 24);
            this.dob.TabIndex = 61;
            this.dob.Value = new System.DateTime(2020, 9, 14, 0, 24, 51, 991);
            // 
            // other
            // 
            this.other.AutoSize = true;
            this.other.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.other.CheckedState.BorderThickness = 0;
            this.other.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.other.CheckedState.InnerColor = System.Drawing.Color.White;
            this.other.CheckedState.InnerOffset = -4;
            this.other.Location = new System.Drawing.Point(364, 136);
            this.other.Name = "other";
            this.other.Size = new System.Drawing.Size(65, 21);
            this.other.TabIndex = 60;
            this.other.Text = "Other";
            this.other.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.other.UncheckedState.BorderThickness = 2;
            this.other.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.other.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.female.CheckedState.BorderThickness = 0;
            this.female.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.female.CheckedState.InnerColor = System.Drawing.Color.White;
            this.female.CheckedState.InnerOffset = -4;
            this.female.Location = new System.Drawing.Point(249, 136);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(75, 21);
            this.female.TabIndex = 59;
            this.female.Text = "Female";
            this.female.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.female.UncheckedState.BorderThickness = 2;
            this.female.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.female.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.male.CheckedState.BorderThickness = 0;
            this.male.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.male.CheckedState.InnerColor = System.Drawing.Color.White;
            this.male.CheckedState.InnerOffset = -4;
            this.male.Location = new System.Drawing.Point(149, 136);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(59, 21);
            this.male.TabIndex = 58;
            this.male.Text = "Male";
            this.male.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.male.UncheckedState.BorderThickness = 2;
            this.male.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.male.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // guna2Button1
            // 
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(314, 265);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(122, 45);
            this.guna2Button1.TabIndex = 57;
            this.guna2Button1.Text = "Test";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // test
            // 
            this.test.Location = new System.Drawing.Point(149, 220);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(287, 22);
            this.test.TabIndex = 56;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(149, 23);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(287, 22);
            this.name.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "NIC";
            // 
            // nic
            // 
            this.nic.Location = new System.Drawing.Point(149, 60);
            this.nic.Name = "nic";
            this.nic.Size = new System.Drawing.Size(287, 22);
            this.nic.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Date of Birth";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Test";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Gender";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Contact";
            // 
            // contact
            // 
            this.contact.Location = new System.Drawing.Point(149, 174);
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(287, 22);
            this.contact.TabIndex = 11;
            this.contact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox6_KeyPress);
            // 
            // panelTest
            // 
            this.panelTest.Location = new System.Drawing.Point(542, 69);
            this.panelTest.Name = "panelTest";
            this.panelTest.Size = new System.Drawing.Size(868, 608);
            this.panelTest.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.guna2Button3);
            this.groupBox2.Controls.Add(this.guna2Button2);
            this.groupBox2.Controls.Add(this.type);
            this.groupBox2.Controls.Add(this.chemicalUsed);
            this.groupBox2.Controls.Add(this.quantity);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(542, 691);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(520, 100);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " Chemical Description";
            // 
            // guna2Button3
            // 
            this.guna2Button3.CheckedState.Parent = this.guna2Button3;
            this.guna2Button3.CustomImages.Parent = this.guna2Button3;
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.HoverState.Parent = this.guna2Button3;
            this.guna2Button3.Location = new System.Drawing.Point(419, 62);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.ShadowDecoration.Parent = this.guna2Button3;
            this.guna2Button3.Size = new System.Drawing.Size(75, 32);
            this.guna2Button3.TabIndex = 62;
            this.guna2Button3.Text = "Submit";
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Location = new System.Drawing.Point(419, 21);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(75, 35);
            this.guna2Button2.TabIndex = 60;
            this.guna2Button2.Text = "Clear";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // type
            // 
            this.type.FormattingEnabled = true;
            this.type.Items.AddRange(new object[] {
            "Kg",
            "g",
            "mcg",
            "gills",
            "pint",
            "gallon",
            "ml ",
            "l"});
            this.type.Location = new System.Drawing.Point(314, 65);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(41, 24);
            this.type.TabIndex = 59;
            // 
            // chemicalUsed
            // 
            this.chemicalUsed.FormattingEnabled = true;
            this.chemicalUsed.Location = new System.Drawing.Point(150, 27);
            this.chemicalUsed.Name = "chemicalUsed";
            this.chemicalUsed.Size = new System.Drawing.Size(205, 24);
            this.chemicalUsed.TabIndex = 56;
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(150, 67);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(158, 22);
            this.quantity.TabIndex = 54;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 17);
            this.label9.TabIndex = 55;
            this.label9.Text = "Quantity Used";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 17);
            this.label5.TabIndex = 53;
            this.label5.Text = "Chemical Used";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Location = new System.Drawing.Point(3, 468);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(533, 344);
            this.panel3.TabIndex = 8;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGrid);
            this.groupBox3.Location = new System.Drawing.Point(3, 63);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(533, 399);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Available Tests";
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(14, 42);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersWidth = 51;
            this.dataGrid.RowTemplate.Height = 24;
            this.dataGrid.Size = new System.Drawing.Size(508, 402);
            this.dataGrid.TabIndex = 0;
            this.dataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellContentClick_1);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.guna2Button5);
            this.groupBox4.Controls.Add(this.guna2Button4);
            this.groupBox4.Location = new System.Drawing.Point(1069, 699);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(330, 92);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Submit";
            // 
            // guna2Button5
            // 
            this.guna2Button5.CheckedState.Parent = this.guna2Button5;
            this.guna2Button5.CustomImages.Parent = this.guna2Button5;
            this.guna2Button5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button5.ForeColor = System.Drawing.Color.White;
            this.guna2Button5.HoverState.Parent = this.guna2Button5;
            this.guna2Button5.Location = new System.Drawing.Point(182, 35);
            this.guna2Button5.Name = "guna2Button5";
            this.guna2Button5.ShadowDecoration.Parent = this.guna2Button5;
            this.guna2Button5.Size = new System.Drawing.Size(121, 35);
            this.guna2Button5.TabIndex = 64;
            this.guna2Button5.Text = "Clear";
            this.guna2Button5.Click += new System.EventHandler(this.guna2Button5_Click);
            // 
            // guna2Button4
            // 
            this.guna2Button4.CheckedState.Parent = this.guna2Button4;
            this.guna2Button4.CustomImages.Parent = this.guna2Button4;
            this.guna2Button4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.HoverState.Parent = this.guna2Button4;
            this.guna2Button4.Location = new System.Drawing.Point(25, 35);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.ShadowDecoration.Parent = this.guna2Button4;
            this.guna2Button4.Size = new System.Drawing.Size(120, 35);
            this.guna2Button4.TabIndex = 63;
            this.guna2Button4.Text = "Submit Report";
            this.guna2Button4.Click += new System.EventHandler(this.guna2Button4_Click);
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
            this.guna2ImageButton1.Location = new System.Drawing.Point(1358, 12);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.PressedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Size = new System.Drawing.Size(41, 39);
            this.guna2ImageButton1.TabIndex = 14;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // Mlt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1411, 803);
            this.Controls.Add(this.guna2ImageButton1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelTest);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Mlt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mlt";
            this.Load += new System.EventHandler(this.Mlt_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nic;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox contact;
        private System.Windows.Forms.Panel panelTest;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox type;
        private System.Windows.Forms.ComboBox chemicalUsed;
        private System.Windows.Forms.TextBox quantity;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox test;
        public System.Windows.Forms.TextBox name;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.GroupBox groupBox4;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2RadioButton male;
        private Guna.UI2.WinForms.Guna2DateTimePicker dob;
        private Guna.UI2.WinForms.Guna2RadioButton other;
        private Guna.UI2.WinForms.Guna2RadioButton female;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}