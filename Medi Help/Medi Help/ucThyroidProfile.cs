using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using Medi_Help.CrystalReports;

namespace Medi_Help
{
    public partial class ucThyroidProfile : UserControl
    {
        private static ucThyroidProfile _instance;
        public static ucThyroidProfile Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucThyroidProfile();
                return _instance;
            }
        }
        public ucThyroidProfile()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ucThyroidProfile_Load(object sender, EventArgs e)
        {
            unit1.ReadOnly = true;
            unit2.ReadOnly = true;
            unit3.ReadOnly = true;
            v2.ReadOnly = true;
            v4.ReadOnly = true;
            v6.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void unit3_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {

                Formx1 f2 = new Formx1();
                thyroidProfileReport ui = new thyroidProfileReport();



                TextObject text1 = (TextObject)ui.ReportDefinition.Sections["Section3"].ReportObjects["r1"];
                text1.Text = v2.Text.ToString();

                TextObject text2 = (TextObject)ui.ReportDefinition.Sections["Section3"].ReportObjects["r2"];
                text2.Text = v3.Text.ToString();

                TextObject text3 = (TextObject)ui.ReportDefinition.Sections["Section3"].ReportObjects["r3"];
                text3.Text = v5.Text.ToString();

                TextObject text4 = (TextObject)ui.ReportDefinition.Sections["Section3"].ReportObjects["r4"];
                text4.Text = v7.Text.ToString();

                TextObject text5 = (TextObject)ui.ReportDefinition.Sections["Section3"].ReportObjects["r5"];
                text5.Text = v8.Text.ToString();

                TextObject text6 = (TextObject)ui.ReportDefinition.Sections["Section3"].ReportObjects["r6"];
                text6.Text = v9.Text.ToString();

                TextObject text17 = (TextObject)ui.ReportDefinition.Sections["Section4"].ReportObjects["re"];
                text17.Text = remark.Text.ToString();

                //***Patient Details for crystal report***//


                TextObject text11 = (TextObject)ui.ReportDefinition.Sections["Section2"].ReportObjects["txtDate"];
                text11.Text = DateTime.Today.ToString();

                TextObject text12 = (TextObject)ui.ReportDefinition.Sections["Section2"].ReportObjects["txtReport"];
                text12.Text = global.rReportname;

                TextObject text13 = (TextObject)ui.ReportDefinition.Sections["Section2"].ReportObjects["txtMlt"];
                text13.Text = global.UserID;

                TextObject text14 = (TextObject)ui.ReportDefinition.Sections["Section2"].ReportObjects["txtPatient"];
                text14.Text = global.rPatientName;

                TextObject text15 = (TextObject)ui.ReportDefinition.Sections["Section2"].ReportObjects["txtDob"];
                text15.Text = global.rDob;

                TextObject text16 = (TextObject)ui.ReportDefinition.Sections["Section2"].ReportObjects["txtGender"];
                text16.Text = global.rGender;


                //***end***//




                f2.crystalReportViewer1.ReportSource = ui;
                f2.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Console.WriteLine("Error: " + ex);
            }
        }
    }
}
