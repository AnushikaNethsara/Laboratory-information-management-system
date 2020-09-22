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
    public partial class ucVitamineB12Serum : UserControl
    {
        private static ucVitamineB12Serum _instance;
        public static ucVitamineB12Serum Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucVitamineB12Serum();
                return _instance;
            }
        }

        public ucVitamineB12Serum()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ucVitamineB12Serum_Load(object sender, EventArgs e)
        {
            units.ReadOnly = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {

                Formx1 f2 = new Formx1();
                vitamineB12SerumReport ui = new vitamineB12SerumReport();

                TextObject text1 = (TextObject)ui.ReportDefinition.Sections["Section3"].ReportObjects["r1"];
                text1.Text = v1.Text.ToString();

                TextObject text2 = (TextObject)ui.ReportDefinition.Sections["Section3"].ReportObjects["r2"];
                text2.Text = v2.Text.ToString();

                TextObject text3 = (TextObject)ui.ReportDefinition.Sections["Section3"].ReportObjects["r3"];
                text3.Text = v3.Text.ToString();

                TextObject text4 = (TextObject)ui.ReportDefinition.Sections["Section3"].ReportObjects["r4"];
                text4.Text = v4.Text.ToString();

                //***Patient Details for crystal report***//


                TextObject text5 = (TextObject)ui.ReportDefinition.Sections["Section3"].ReportObjects["txtDate"];
                text5.Text = DateTime.Today.ToString();

                TextObject text6 = (TextObject)ui.ReportDefinition.Sections["Section3"].ReportObjects["txtReport"];
                text6.Text = global.rReportname;

                TextObject text7 = (TextObject)ui.ReportDefinition.Sections["Section3"].ReportObjects["txtMlt"];
                text7.Text = global.UserID;

                TextObject text8 = (TextObject)ui.ReportDefinition.Sections["Section3"].ReportObjects["txtPatient"];
                text8.Text = global.rPatientName;

                TextObject text9 = (TextObject)ui.ReportDefinition.Sections["Section3"].ReportObjects["txtDob"];
                text9.Text = global.rDob;

                TextObject text10 = (TextObject)ui.ReportDefinition.Sections["Section3"].ReportObjects["txtGender"];
                text10.Text = global.rGender;




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
