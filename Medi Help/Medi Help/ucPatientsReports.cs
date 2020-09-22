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
using System.Globalization;

namespace Medi_Help
{
    public partial class ucPatientsReports : UserControl
    {
        private static ucPatientsReports _instance;
        public static ucPatientsReports Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucPatientsReports();
                return _instance;
            }
        }
        public ucPatientsReports()
        {
            InitializeComponent();
        }

        private void ucPatientsReports_Load(object sender, EventArgs e)
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

            PatientReports();
        }
        public void PatientReports()
        {

            //string timestamp = DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss.fff",CultureInfo.InvariantCulture)+ primaryKey.RandomString(5);
            //MessageBox.Show("time: " + timestamp);
            try
            {
                DBconnection connection5 = new DBconnection();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(connection5.displayAllPatientsReports());
                da.Fill(dt);
                dataGrid.DataSource = dt;
                connection5.getConnection().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Displaying: \n" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("Error:\n" + ex);
            }
        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
