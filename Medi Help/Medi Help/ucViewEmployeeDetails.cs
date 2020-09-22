using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Medi_Help
{
    public partial class ucViewEmployeeDetails : UserControl
    {
        private static ucViewEmployeeDetails _instance;
        public static ucViewEmployeeDetails Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucViewEmployeeDetails();
                return _instance;
            }
        }
        public ucViewEmployeeDetails()
        {
            InitializeComponent();
        }

        private void ucViewEmployeeDetails_Load(object sender, EventArgs e)
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

            name.ReadOnly = true;
            phone.ReadOnly = true;
            email.ReadOnly = true;
            nic.ReadOnly = true;
            empType.ReadOnly = true;
            dob.Enabled = false;


            displayEmployees();
        }

        public void displayEmployees()
        {
            DBconnection connection5 = new DBconnection();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(connection5.displayRegistredEmployees());
            da.Fill(dt);
            dataGrid.DataSource = dt;
            connection5.getConnection().Close();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        //to view employee details in another window
        string empId = "";

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

            //end *** to view employee details in another window
        }

        private void dataGrid_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGrid.Rows[e.RowIndex];

                empId = row.Cells["EmployeeNic"].Value.ToString();
                name.Text= row.Cells["Name"].Value.ToString();
                phone.Text = row.Cells["Phone"].Value.ToString();
                email.Text = row.Cells["Email"].Value.ToString();
                nic.Text= row.Cells["EmployeeNic"].Value.ToString();
                empType.Text = row.Cells["EmployeeType"].Value.ToString();
                dob.Value = DateTime.Parse(row.Cells["Dob"].Value.ToString());

                DBconnection connection = new DBconnection();
                //connection.getImage(empId);

                try
                {
                    SqlCommand command1 = new SqlCommand("select Photo from [dbo].[Employee] where EmployeeNic=@param", connection.getConnection());
                    SqlParameter myparam = command1.Parameters.Add("@param", SqlDbType.NVarChar, 30);
                    myparam.Value = empId;
                    byte[] img = (byte[])command1.ExecuteScalar();
                    MemoryStream str = new MemoryStream();
                    str.Write(img, 0, img.Length);
                    Bitmap bit = new Bitmap(str);
                    connection.getConnection().Close();
                }
                catch(Exception ex)
                {
                    Console.WriteLine("photo error: " + ex);
                }
                


            }
        }




    }
}
