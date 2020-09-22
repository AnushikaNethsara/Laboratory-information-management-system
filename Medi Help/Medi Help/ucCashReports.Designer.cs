namespace Medi_Help
{
    partial class ucCashReports
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateOne = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dateTwo = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.guna2Button1);
            this.panel1.Controls.Add(this.dateTwo);
            this.panel1.Controls.Add(this.dateOne);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(22, 455);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(854, 153);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Start";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "End";
            // 
            // dateOne
            // 
            this.dateOne.CheckedState.Parent = this.dateOne;
            this.dateOne.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateOne.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateOne.HoverState.Parent = this.dateOne;
            this.dateOne.Location = new System.Drawing.Point(176, 32);
            this.dateOne.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateOne.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateOne.Name = "dateOne";
            this.dateOne.ShadowDecoration.Parent = this.dateOne;
            this.dateOne.Size = new System.Drawing.Size(252, 28);
            this.dateOne.TabIndex = 59;
            this.dateOne.Value = new System.DateTime(2020, 9, 14, 1, 46, 52, 417);
            // 
            // dateTwo
            // 
            this.dateTwo.CheckedState.Parent = this.dateTwo;
            this.dateTwo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateTwo.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateTwo.HoverState.Parent = this.dateTwo;
            this.dateTwo.Location = new System.Drawing.Point(176, 76);
            this.dateTwo.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTwo.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTwo.Name = "dateTwo";
            this.dateTwo.ShadowDecoration.Parent = this.dateTwo;
            this.dateTwo.Size = new System.Drawing.Size(252, 28);
            this.dateTwo.TabIndex = 60;
            this.dateTwo.Value = new System.DateTime(2020, 9, 14, 1, 46, 52, 417);
            // 
            // guna2Button1
            // 
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(510, 26);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(156, 34);
            this.guna2Button1.TabIndex = 87;
            this.guna2Button1.Text = "Print";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // ucCashReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.Controls.Add(this.panel1);
            this.Name = "ucCashReports";
            this.Load += new System.EventHandler(this.ucCashReports_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTwo;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateOne;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}
