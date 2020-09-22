using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using Medi_Help.CrystalReports;

namespace Medi_Help
{
    public partial class Mlt : Form
    {
        string reportNumber, patientNic;
        public Mlt()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void Mlt_Load(object sender, EventArgs e)
        {
            dataGrid.BorderStyle = BorderStyle.None;
            dataGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGrid.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGrid.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGrid.BackgroundColor = Color.White;

            dataGrid.EnableHeadersVisualStyles = false;
            dataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            displayAvailableReports();
            string[] chemicalList = global.chemicaltList;
            
            for(int i = 0; i < chemicalList.Length; i++)
            {
                chemicalUsed.Items.Add(chemicalList[i]);
            }
        }

        private void displayAvailableReports()
        {
            try
            {
                DBconnection connection5 = new DBconnection();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(connection5.displayMLTAvailableReports());
                da.Fill(dt);
                dataGrid.DataSource = dt;
                connection5.getConnection().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in display Reports:\n" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGrid.Rows[e.RowIndex];

                name.Text = row.Cells["Name"].Value.ToString();
                
                nic.Text = row.Cells["PatientNic"].Value.ToString();
                dob.Value = DateTime.Parse(row.Cells["Dob"].Value.ToString());
                contact.Text = row.Cells["Phone"].Value.ToString();
                test.Text = row.Cells["ReportName"].Value.ToString();
                string gend = row.Cells["Gender"].Value.ToString();

                reportNumber= row.Cells["ReportNumber"].Value.ToString();
                patientNic= row.Cells["PatientNic"].Value.ToString();


                if (gend.Equals("Male"))
                {
                    male.Checked = true;
                    global.rGender = "Male";
                }
                else if (gend.Equals("Female"))
                {
                    female.Checked = true;
                    global.rGender = "Female";
                }
                else
                {
                    other.Checked = true;
                    global.rGender = "Other";
                }
                

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            
        }

        private void dataGrid_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGrid.Rows[e.RowIndex];

                name.Text = row.Cells["Name"].Value.ToString();

                nic.Text = row.Cells["PatientNic"].Value.ToString();
                //dob.Value = DateTime.Parse(row.Cells["Dob"].Value.ToString());
                contact.Text = row.Cells["Phone"].Value.ToString();
                test.Text = row.Cells["ReportName"].Value.ToString();
                string gend = row.Cells["Gender"].Value.ToString();

                reportNumber = row.Cells["ReportNumber"].Value.ToString();
                patientNic = row.Cells["PatientNic"].Value.ToString();


                if (gend.Equals("Male"))
                {
                    male.Checked = true;
                    global.rGender = "Male";
                }
                else if (gend.Equals("Female"))
                {
                    female.Checked = true;
                    global.rGender = "Female";
                }
                else
                {
                    other.Checked = true;
                    global.rGender = "Other";
                }


            }
        }
        private void clear()
        {
            name.Text = "";
            dob.Value = DateTime.Today;
            nic.Text = "";
            contact.Text = "";
            test.Text = "";
            male.Checked = false;
            female.Checked = false;
            other.Checked = false;
            chemicalUsed.SelectedItem = -1;
            quantity.Text = "";
            type.Text = "";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
           

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            global.rPatientName = name.Text;
            global.rReportname = test.Text;
            global.rDob = dob.Value.ToString();


            if (test.Text.Equals("Lipid Profile"))
            {
                if (!panelTest.Controls.Contains(ucLipidProfile.Instance))
                {
                    panelTest.Controls.Add(ucLipidProfile.Instance);
                    ucLipidProfile.Instance.Dock = DockStyle.Fill;
                    ucLipidProfile.Instance.BringToFront();
                }
                else
                {
                    ucLipidProfile.Instance.BringToFront();
                }
            }
            else if (test.Text.Equals("Urine protein ratio"))
            {
                if (!panelTest.Controls.Contains(ucUrineRatio.Instance))
                {
                    panelTest.Controls.Add(ucUrineRatio.Instance);
                    ucUrineRatio.Instance.Dock = DockStyle.Fill;
                    ucUrineRatio.Instance.BringToFront();
                }
                else
                {
                    ucUrineRatio.Instance.BringToFront();
                }
            }
            else if (test.Text.Equals("Vitamine B12-Serum"))
            {
                if (!panelTest.Controls.Contains(ucVitamineB12Serum.Instance))
                {
                    panelTest.Controls.Add(ucVitamineB12Serum.Instance);
                    ucVitamineB12Serum.Instance.Dock = DockStyle.Fill;
                    ucVitamineB12Serum.Instance.BringToFront();
                }
                else
                {
                    ucVitamineB12Serum.Instance.BringToFront();
                }
            }
            else if (test.Text.Equals("Ionized Calcium"))
            {
                if (!panelTest.Controls.Contains(ucIonizedCalcium.Instance))
                {
                    panelTest.Controls.Add(ucIonizedCalcium.Instance);
                    ucIonizedCalcium.Instance.Dock = DockStyle.Fill;
                    ucIonizedCalcium.Instance.BringToFront();
                }
                else
                {
                    ucIonizedCalcium.Instance.BringToFront();
                }
            }
            else if (test.Text.Equals("Thyroid Profile"))
            {
                if (!panelTest.Controls.Contains(ucThyroidProfile.Instance))
                {
                    panelTest.Controls.Add(ucThyroidProfile.Instance);
                    ucThyroidProfile.Instance.Dock = DockStyle.Fill;
                    ucThyroidProfile.Instance.BringToFront();
                }
                else
                {
                    ucThyroidProfile.Instance.BringToFront();
                }
            }
            else if (test.Text.Equals("Serum Ferritin"))
            {
                if (!panelTest.Controls.Contains(ucSerumFerritin.Instance))
                {
                    panelTest.Controls.Add(ucSerumFerritin.Instance);
                    ucSerumFerritin.Instance.Dock = DockStyle.Fill;
                    ucSerumFerritin.Instance.BringToFront();
                }
                else
                {
                    ucSerumFerritin.Instance.BringToFront();
                }
            }
            else
            {

            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            chemicalUsed.Text = "";
            quantity.Text = "";
            type.Text = "";
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            DBconnection con1 = new DBconnection();
            if (chemicalUsed.Text.Trim() != string.Empty && quantity.Text.Trim() != string.Empty)
            {
                if (con1.findChemicalEquipment(chemicalUsed.Text))
                {
                    string q = con1.getCurrentQuantity(chemicalUsed.Text);
                    //MessageBox.Show(q);
                    double quantityInTheStock = Convert.ToDouble(q);
                    double quantityEntered = Convert.ToDouble(quantity.Text);

                    if (quantityEntered > quantityInTheStock)
                    {
                        MessageBox.Show("Not Enough chemical in store!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        double newQuantity = quantityInTheStock - quantityEntered;
                        con1.updateChemicalAndEquipment(chemicalUsed.Text, newQuantity.ToString());
                        chemicalUsed.Text = "";
                        quantity.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Chemical not added to the Inventory!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

            try
            {
                if (nic.Text.Trim() != string.Empty && test.Text.Trim() != string.Empty)
                {
                    using (OpenFileDialog dig = new OpenFileDialog { Filter = "PDF Documents(*.pdf) | *.pdf", ValidateNames = true })
                    {
                        if (dig.ShowDialog() == DialogResult.OK)
                        {
                            DialogResult dialog = MessageBox.Show("Are you sure want to upload?", "File Upload", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (dialog == DialogResult.Yes)
                            {
                                string finishedDate = DateTime.Today.ToString();
                                string filename = dig.FileName;
                                DBconnection ob = new DBconnection();
                                ob.uploadReport(filename, reportNumber, patientNic, finishedDate);
                            }
                        }
                    }
                    clear();
                    displayAvailableReports();
                }
                else
                {
                    MessageBox.Show("Empty Fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error upload file:\n" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("upload: \n" + ex);
            }
            displayAvailableReports();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            displayAvailableReports();
            clear();
            Mlt_Load(null, EventArgs.Empty);

        }

        private void button6_Click(object sender, EventArgs e)
        {

            
        }


    }
}
