using System;
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
    public partial class ChemicalAndEquipment : Form
    {
        public ChemicalAndEquipment()
        {
            InitializeComponent();
        }

        private void ChemicalAndEquipment_Load(object sender, EventArgs e)
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

            date.Value = DateTime.Today;
            availableEquipmentsAndChemicals();
         
        }

        private void availableEquipmentsAndChemicals()
        {
            DBconnection connection5 = new DBconnection();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(connection5.displayAvailableChemicalsAndEquipments());
            da.Fill(dt);
            dataGrid.DataSource = dt;
            connection5.getConnection().Close();
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           

        }
        private void clearFileds()
        {
            core.SelectedIndex = -1;
            quantity.Text = "";
            name.Text = "";
            price.Text = "";
            reference.Text = "";
            cmbQuantity.SelectedIndex = -1;

        }

        private void clear_Click(object sender, EventArgs e)
        {
            


        }

        private void price_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void quantity_KeyPress(object sender, KeyPressEventArgs e)
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

        private void price_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {
   
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
  
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void quantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbQuantity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void core_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (core.Text.Equals("Equipment"))
            {
                name.Items.Clear();

                string[] equipmentList = global.equipmentList;

                for (int i = 0; i < equipmentList.Length; i++)
                {
                    name.Items.Add(equipmentList[i]);
                }



            }
            else
            {
                name.Items.Clear();
                string[] chemicaltList = global.chemicaltList;
                for (int i = 0; i < chemicaltList.Length; i++)
                {
                    name.Items.Add(chemicaltList[i]);
                }


            }
        }

        private void name_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void price_TextChanged(object sender, EventArgs e)
        {

        }

        private void reference_TextChanged(object sender, EventArgs e)
        {

        }

        private void date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            clearFileds();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (core.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Empty Chemical or ID Field!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (name.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Empty Name Field!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (price.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Empty Price Field!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (quantity.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Empty Quantity Field!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                DialogResult answer;
                answer = MessageBox.Show("Are you sure want to add "+ core.Text + "?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (answer == DialogResult.Yes)
                {

                    //******database connect ******
                    try
                    {
                        string date1 = date.Value.ToString();
                        if (core.Text.Equals("Chemical") || core.Text.Equals("Equipment"))
                        {
                            //float cPrice = float.Parse(price.Text);
                            string cPrice = price.Text;
                            string cQuantity = quantity.Text;
                            string cReference = reference.Text;
                            string cName = name.Text;

                            DBconnection dbconnection = new DBconnection();

                            if (dbconnection.findChemicalEquipment(cName))
                            {
                                string currentQuantity = dbconnection.getCurrentQuantity(name.Text);
                                int q = Convert.ToInt32(currentQuantity) + Convert.ToInt32(cQuantity);
                                string newQuantity = q.ToString();
                                dbconnection.updateChemicalAndEquipment(cName, newQuantity);
                            }
                            else
                            {
                                chemicalsAndEquipments chemicalsAndequipments = new chemicalsAndEquipments(date1, cName, cPrice, cQuantity, global.UserID, cReference);

                                dbconnection.addChemicalsAndEquipments(chemicalsAndequipments);
                            }
                            availableEquipmentsAndChemicals();
                            clearFileds();

                        }
                        else
                        {
                            MessageBox.Show("Enter valid Type(Chemical or Equipment)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }



                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error:\n" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Console.WriteLine("Error: \n" + ex);
                    }


                }
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
