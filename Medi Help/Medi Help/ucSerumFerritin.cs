using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Medi_Help.CrystalReports;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;


namespace Medi_Help
{
    public partial class ucSerumFerritin : UserControl
    {
        private static ucSerumFerritin _instance;
        public static ucSerumFerritin Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucSerumFerritin();
                return _instance;
            }
        }
        public ucSerumFerritin()
        {
            InitializeComponent();
        }

        private void ucSerumFerritin_Load(object sender, EventArgs e)
        {
            units.ReadOnly = true;
            units2.ReadOnly = true;
            units3.ReadOnly = true;
            units4.ReadOnly = true;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void v4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {

                Formx1 f2 = new Formx1();
                serumFerritin ui = new serumFerritin();



                TextObject text1 = (TextObject)ui.ReportDefinition.Sections["Section3"].ReportObjects["r1"];
                text1.Text = v1.Text.ToString();

                TextObject text2 = (TextObject)ui.ReportDefinition.Sections["Section3"].ReportObjects["r2"];
                text2.Text = v2.Text.ToString();

                TextObject text3 = (TextObject)ui.ReportDefinition.Sections["Section3"].ReportObjects["r3"];
                text3.Text = v3.Text.ToString();

                TextObject text4 = (TextObject)ui.ReportDefinition.Sections["Section3"].ReportObjects["r4"];
                text4.Text = v4.Text.ToString();

                TextObject text5 = (TextObject)ui.ReportDefinition.Sections["Section3"].ReportObjects["r5"];
                text5.Text = v5.Text.ToString();

                TextObject text6 = (TextObject)ui.ReportDefinition.Sections["Section3"].ReportObjects["r6"];
                text6.Text = v6.Text.ToString();


                TextObject text17 = (TextObject)ui.ReportDefinition.Sections["Section3"].ReportObjects["remark"];
                text17.Text = v7.Text.ToString();

                //***Patient Details for crystal report***//


                TextObject text11 = (TextObject)ui.ReportDefinition.Sections["Section3"].ReportObjects["txtDate"];
                text11.Text = DateTime.Today.ToString();

                TextObject text12 = (TextObject)ui.ReportDefinition.Sections["Section3"].ReportObjects["txtReport"];
                text12.Text = global.rReportname;

                TextObject text13 = (TextObject)ui.ReportDefinition.Sections["Section3"].ReportObjects["txtMlt"];
                text13.Text = global.UserID;

                TextObject text14 = (TextObject)ui.ReportDefinition.Sections["Section3"].ReportObjects["txtPatient"];
                text14.Text = global.rPatientName;

                TextObject text15 = (TextObject)ui.ReportDefinition.Sections["Section3"].ReportObjects["txtDob"];
                text15.Text = global.rDob;

                TextObject text16 = (TextObject)ui.ReportDefinition.Sections["Section3"].ReportObjects["txtGender"];
                text16.Text = global.rGender;


                //***end***//




                f2.crystalReportViewer1.ReportSource = ui;
                f2.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
