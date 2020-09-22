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
    public partial class ucIonizedCalcium : UserControl
    {
        private static ucIonizedCalcium _instance;
        public static ucIonizedCalcium Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucIonizedCalcium();
                return _instance;
            }
        }
        public ucIonizedCalcium()
        {
            InitializeComponent();
        }

        private void ucIonizedCalcium_Load(object sender, EventArgs e)
        {
            unit1.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {

                Formx1 f2 = new Formx1();
                ionizedCalcium ui = new ionizedCalcium();



                TextObject text1 = (TextObject)ui.ReportDefinition.Sections["Section3"].ReportObjects["r1"];
                text1.Text = v1.Text.ToString();

                TextObject text2 = (TextObject)ui.ReportDefinition.Sections["Section3"].ReportObjects["r2"];
                text2.Text = v2.Text.ToString();

                TextObject text3 = (TextObject)ui.ReportDefinition.Sections["Section3"].ReportObjects["r3"];
                text3.Text = v3.Text.ToString();

                TextObject text17 = (TextObject)ui.ReportDefinition.Sections["Section4"].ReportObjects["remark"];
                text17.Text = re.Text.ToString();

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
                Console.WriteLine("Error: \n" + ex);
            }
        }
    }
}
