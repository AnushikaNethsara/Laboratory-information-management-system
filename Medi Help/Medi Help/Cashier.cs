using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medi_Help
{
    public partial class Cashier : Form
    {
        //private bool arrayActive = true;
        private double totalPrice = 0;
        private string reportNumber;
        private ArrayList reportList = new ArrayList();
        public Cashier()
        {
            InitializeComponent();
        }

        private void Cashier_Load(object sender, EventArgs e)
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

            allTests.BorderStyle = BorderStyle.None;
            allTests.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            allTests.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            allTests.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            allTests.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            allTests.BackgroundColor = Color.White;

            allTests.EnableHeadersVisualStyles = false;
            allTests.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            allTests.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            allTests.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dateTimePicker1.Value= DateTime.Today;
            displayAvailableReports();
            clear();
            total.Text = totalPrice.ToString();
            total.ReadOnly = true;
            restoreTestList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           

            
        }

        private void clear()
        {
            name.Text = "";
            nic.Text = "";
            dob.Value = DateTime.Today;
            contact.Text = "";
            male.Checked = false;
            female.Checked = false;
            other.Checked = false;
            total.Text = "";
            des.Text = "";
            paidAmount.Text = "";
            txtBalance.Text = "";
            address.Text = "";
            test.Text = "";
            rDate.Value = DateTime.Today;
            allTests.Rows.Clear();

        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            



        }

        private void allTests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void age_KeyPress(object sender, KeyPressEventArgs e)
        {
            


        }

        private void test_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void rDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void txtBalance_TextChanged(object sender, EventArgs e)
        {

        }

        private void paidAmount_TextChanged(object sender, EventArgs e)
        {
            string paidAmount1 = paidAmount.Text;
            if (paidAmount.Text == "")
            {
                paidAmount1 = "0";
            }
            double balance1 =  Convert.ToDouble(paidAmount1)- totalPrice;
            if (balance1 < 0)
            {
                txtBalance.Text = "Invalid Paid Amount";
            }
            else
            {
                txtBalance.Text = balance1.ToString();
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void total_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
          

        }

        private void restoreTestList()
        {
            
            string[] testList = { "Lipid Profile", "Urine protein ratio", "Vitamine B12-Serum", "Ionized Calcium", "Serum Ferritin", "Thyroid Profile" };

            for(int i = 0; i < testList.Length; i++)
            {
                test.Items.Add(testList[i]);
            }
        }

        private void contact_KeyPress(object sender, KeyPressEventArgs e)
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

        private void displayAvailableReports()
        {
            try
            {
                DBconnection connection5 = new DBconnection();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(connection5.displayAvailableReports());
                da.Fill(dt);
                dataGrid.DataSource = dt;
                connection5.getConnection().Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error in Displaying Reports:\n"+ex, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                Console.WriteLine("Error: \n" + ex);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
            

        }

        private void contact_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string patientNic = nic.Text;
                DBconnection connection2 = new DBconnection();

                if (connection2.searchPatient(patientNic))
                {
                    int counter = 0;
                    ArrayList patientDetailsArray = new ArrayList();
                    //MessageBox.Show("Patient Found?", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    patientDetailsArray = connection2.getPatientDetails(patientNic);

                    foreach (string i in patientDetailsArray)
                    {
                        Console.WriteLine("\n console: "+i+" counter: "+counter);
                        if (counter == 0)
                        {
                            name.Text = i;
                        }
                        if (counter == 1)
                        {
                            dob.Value = DateTime.Parse(i);
                        }
                        //if (counter == 0)
                        //{
                        //    name.Text = i;
                        //}
                        if (counter == 2)
                        {
                            if (i.Equals("Male"))
                            {
                                male.Checked = true;
                            }
                            else if (i.Equals("Female"))
                            {
                                female.Checked = true;
                            }
                            else
                            {
                                other.Checked = true;
                            }
                        }
                        if (counter == 4)
                        {
                            contact.Text = i;

                        }
                        else
                        {
                            address.Text = i;
                        }
                        counter++;
                    }
                }
                else
                {
                    MessageBox.Show("No Patient Found?", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("No Patient Found ?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("error search: " + ex);
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            string test1 = test.Text;
            string requiredDate = rDate.Value.ToShortDateString();
            test.Text = "";

            if (test1.Trim() != string.Empty)
            {
                string price1 = "0";
                try
                {
                    DBconnection ob = new DBconnection();
                    price1 = ob.getprice(test1).ToString();
                    totalPrice = totalPrice + ob.getprice(test1);
                    total.Text = totalPrice.ToString();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Get Price Error \n" + ex);
                }


                if (test1.Equals("Test 4") || test1.Equals("Ionized Calcium") || test1.Equals("Serum Ferritin") || test1.Equals("Vitamine B12-Serum") || test1.Equals("Thyroid Profile") || test1.Equals("Lipid Profile") || test1.Equals("Urine protein ratio"))
                {

                    reportNumber = "R" + primaryKey.RandomString(6);
                    this.allTests.Rows.Add(reportNumber, test1, requiredDate, price1);
                    int index = test.SelectedIndex;
                    test.Items.RemoveAt(index);


                    //****add data to an array***//
                    global.reportStruct details = new global.reportStruct();
                    details.stReportNumber = reportNumber;
                    details.stRequiredDate = requiredDate;
                    details.stTest = test1;
                    details.price = price1;

                    reportList.Add(details);


                }
                else
                {
                    MessageBox.Show("Enter valid Test!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }




            }
            else
            {
                MessageBox.Show("Empty Test Field!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            restoreTestList();
            test.Text = "";
            rDate.Value = DateTime.Today;
            allTests.Rows.Clear();
            totalPrice = 0;
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            restoreTestList();
            clear();
            totalPrice = 0;
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            if (name.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Empty UserName Field!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (nic.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Empty NIC Field!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (contact.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Empty Contact Field!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (address.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Empty Address Field!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!male.Checked && !female.Checked && !other.Checked)
            {
                MessageBox.Show("Select Gender!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (paidAmount.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Empty Paid Amount Field!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                DialogResult answer;
                answer = MessageBox.Show("Are you sure want to Confirm Payment?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (answer == DialogResult.Yes)
                {
                    try
                    {
                        //******patient database*****//
                        DBconnection connection = new DBconnection();
                        string selectedGender = "";
                        if (male.Checked)
                        {
                            selectedGender = "Male";
                        }
                        else if (female.Checked)
                        {
                            selectedGender = "Female";
                        }
                        else
                        {
                            selectedGender = "Other";
                        }
                        var dateOf = dob.Value;
                        bill patientDetails = new bill(nic.Text, name.Text, dateOf.Date.ToString(), selectedGender, address.Text, Convert.ToInt32(contact.Text));


                        if (!connection.searchPatient(nic.Text))
                        {
                            connection.addPatient(patientDetails);
                        }

                        //******bill database******//

                        string billNumber = "B" + DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss.fff", CultureInfo.InvariantCulture);
                        string date = DateTime.UtcNow.Date.ToString();
                        string requiredDate = rDate.Value.ToShortDateString();
                        double total1 = Convert.ToDouble(total.Text);

                        bill billDetails = new bill(billNumber, date, requiredDate, global.UserID, nic.Text, total1, des.Text);

                        connection.addInvoice(billDetails);


                        //******report database******//
                        foreach (global.reportStruct i in reportList)
                        {
                            report patientReport = new report(nic.Text, i.stReportNumber, i.stTest, i.stRequiredDate);
                            DBconnection connection1 = new DBconnection();
                            connection1.Report(patientReport);
                        }

                        displayAvailableReports();
                        reportList.Clear();
                        clear();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error:\n" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Console.WriteLine("Error:\n" + ex);
                    }
                }
            }
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
