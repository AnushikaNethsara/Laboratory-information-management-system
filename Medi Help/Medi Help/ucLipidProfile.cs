using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using Medi_Help.CrystalReports;

namespace Medi_Help
{
    
    public partial class ucLipidProfile : UserControl
    {
        double val1, val2, val3, val4, val5;
        public ArrayList testDeatils = new ArrayList();
        private static ucLipidProfile _instance;
        public static ucLipidProfile Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucLipidProfile();
                return _instance;
            }
        }
        public ucLipidProfile()
        {
            InitializeComponent();
        }

        private void ucLipidProfile_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            try
            {

                Formx1 f2 = new Formx1();
                lipidProfile ui = new lipidProfile();



                TextObject text1 = (TextObject)ui.ReportDefinition.Sections["Section3"].ReportObjects["Text1"];
                text1.Text = v1.Text.ToString();

                TextObject text2 = (TextObject)ui.ReportDefinition.Sections["Section3"].ReportObjects["Text2"];
                text2.Text = v2.Text.ToString();

                TextObject text3 = (TextObject)ui.ReportDefinition.Sections["Section3"].ReportObjects["Text3"];
                text3.Text = v3.Text.ToString();

                TextObject text4 = (TextObject)ui.ReportDefinition.Sections["Section3"].ReportObjects["Text4"];
                text4.Text = v4.Text.ToString();

                TextObject text5 = (TextObject)ui.ReportDefinition.Sections["Section3"].ReportObjects["Text5"];
                text5.Text = v5.Text.ToString();

                TextObject text6 = (TextObject)ui.ReportDefinition.Sections["Section3"].ReportObjects["ss1"];
                text6.Text = s1.Text.ToString();

                TextObject text7 = (TextObject)ui.ReportDefinition.Sections["Section3"].ReportObjects["ss2"];
                text7.Text = s2.Text.ToString();

                TextObject text8 = (TextObject)ui.ReportDefinition.Sections["Section3"].ReportObjects["ss3"];
                text8.Text = s3.Text.ToString();

                TextObject text9 = (TextObject)ui.ReportDefinition.Sections["Section3"].ReportObjects["ss4"];
                text9.Text = s4.Text.ToString();

                TextObject text10 = (TextObject)ui.ReportDefinition.Sections["Section3"].ReportObjects["ss5"];
                text10.Text = s5.Text.ToString();

                TextObject text17 = (TextObject)ui.ReportDefinition.Sections["Section3"].ReportObjects["remark"];
                text17.Text = remark.Text.ToString();

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

        private void v1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                val1 = Convert.ToDouble(v1.Text);
                if (val1 < 220)
                {
                    s1.Text = "Normal";
                }
                else if (val1 > 220)
                {
                    s1.Text = "High";
                }
            }
            catch
            {
                s1.Text = "";
            }

        }

        private void v2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                val1 = Convert.ToDouble(v2.Text);
                if (val1 < 35)
                {
                    s2.Text = "Low";
                }
                else if (val1 > 65)
                {
                    s2.Text = "High";
                }
                else
                {
                    s2.Text = "Normal";
                }
            }
            catch
            {
                s2.Text = "";
            }
        }

        private void v3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                val1 = Convert.ToDouble(v3.Text);
                if (val3 < 10)
                {
                    s3.Text = "Low";
                }
                else if (val1 > 200)
                {
                    s3.Text = "High";
                }
                else
                {
                    s3.Text = "Normal";
                }
            }
            catch
            {
                s3.Text = "";
            }
        }

        private void v4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                val1 = Convert.ToDouble(v4.Text);
                if (val4 < 75)
                {
                    s4.Text = "Low";
                }
                else if (val1 > 160)
                {
                    s4.Text = "High";
                }
                else
                {
                    s4.Text = "Normal";
                }
            }
            catch
            {
                s4.Text = "";
            }
        }
    }
}
