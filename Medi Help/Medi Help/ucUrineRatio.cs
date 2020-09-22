using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using Medi_Help.CrystalReports;

namespace Medi_Help
{
    public partial class ucUrineRatio : UserControl
    {
        private static ucUrineRatio _instance;
        public static ucUrineRatio Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucUrineRatio();
                return _instance;
            }
        }
        public ucUrineRatio()
        {
            InitializeComponent();
        }

        private void ucUrineRatio_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {

                Formx1 f2 = new Formx1();
                UrineRatio ui = new UrineRatio();



                TextObject text1 = (TextObject)ui.ReportDefinition.Sections["Section3"].ReportObjects["r1"];
                text1.Text = v2.Text.ToString();

                TextObject text2 = (TextObject)ui.ReportDefinition.Sections["Section3"].ReportObjects["r2"];
                text2.Text = v3.Text.ToString();

                TextObject text3 = (TextObject)ui.ReportDefinition.Sections["Section3"].ReportObjects["r3"];
                text3.Text = v4.Text.ToString();

                TextObject text4 = (TextObject)ui.ReportDefinition.Sections["Section3"].ReportObjects["r4"];
                text4.Text = v5.Text.ToString();

                TextObject text5 = (TextObject)ui.ReportDefinition.Sections["Section3"].ReportObjects["r5"];
                text5.Text = v7.Text.ToString();

                TextObject text6 = (TextObject)ui.ReportDefinition.Sections["Section3"].ReportObjects["r6"];
                text6.Text = v8.Text.ToString();

                TextObject text7 = (TextObject)ui.ReportDefinition.Sections["Section3"].ReportObjects["r7"];
                text7.Text = v9.Text.ToString();

                TextObject text8 = (TextObject)ui.ReportDefinition.Sections["Section3"].ReportObjects["r9"];
                text8.Text = v10.Text.ToString();


                TextObject text10 = (TextObject)ui.ReportDefinition.Sections["Section3"].ReportObjects["r10"];
                text10.Text = v11.Text.ToString();

                TextObject text15 = (TextObject)ui.ReportDefinition.Sections["Section3"].ReportObjects["r11"];
                text15.Text = v12.Text.ToString();

                TextObject text16 = (TextObject)ui.ReportDefinition.Sections["Section3"].ReportObjects["r12"];
                text16.Text = v13.Text.ToString();

                TextObject text17 = (TextObject)ui.ReportDefinition.Sections["Section3"].ReportObjects["r13"];
                text17.Text = v14.Text.ToString();         

                TextObject text19 = (TextObject)ui.ReportDefinition.Sections["Section3"].ReportObjects["r14"];
                text19.Text = v15.Text.ToString();

                TextObject text20 = (TextObject)ui.ReportDefinition.Sections["Section3"].ReportObjects["r15"];
                text20.Text = v16.Text.ToString();

                TextObject text21 = (TextObject)ui.ReportDefinition.Sections["Section3"].ReportObjects["r16"];
                text21.Text = v17.Text.ToString();


                TextObject text22 = (TextObject)ui.ReportDefinition.Sections["Section3"].ReportObjects["r17"];
                text22.Text = v18.Text.ToString();

                TextObject text23 = (TextObject)ui.ReportDefinition.Sections["Section3"].ReportObjects["r18"];
                text23.Text = v19.Text.ToString();

                TextObject text24 = (TextObject)ui.ReportDefinition.Sections["Section3"].ReportObjects["r19"];
                text24.Text = v20.Text.ToString();

                TextObject text25 = (TextObject)ui.ReportDefinition.Sections["Section3"].ReportObjects["r20"];
                text25.Text = v20.Text.ToString();



                TextObject text18 = (TextObject)ui.ReportDefinition.Sections["Section4"].ReportObjects["re"];
                text18.Text = remark.Text.ToString();
                //***Patient Details for crystal report***//


                TextObject text11 = (TextObject)ui.ReportDefinition.Sections["Section2"].ReportObjects["txtDate"];
                text11.Text = DateTime.Today.ToString();

                TextObject text12 = (TextObject)ui.ReportDefinition.Sections["Section2"].ReportObjects["txtReport"];
                text12.Text = global.rReportname;

                TextObject text13 = (TextObject)ui.ReportDefinition.Sections["Section2"].ReportObjects["txtMlt"];
                text13.Text = global.UserID;

                TextObject text14 = (TextObject)ui.ReportDefinition.Sections["Section2"].ReportObjects["txtPatient"];
                text14.Text = global.rPatientName;

                TextObject text55 = (TextObject)ui.ReportDefinition.Sections["Section2"].ReportObjects["txtDob"];
                text55.Text = global.rDob;

                TextObject text166 = (TextObject)ui.ReportDefinition.Sections["Section2"].ReportObjects["txtGender"];
                text166.Text = global.rGender;


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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void remark_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void v9_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
