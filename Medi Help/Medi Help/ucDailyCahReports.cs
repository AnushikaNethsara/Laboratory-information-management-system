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
using System.Net;
using System.IO;
using WhatsAppApi;
using System.Net.Mail;

namespace Medi_Help
{
    public partial class ucDailyCahReports : UserControl
    {
        private static ucDailyCahReports _instance;
        string date = DateTime.UtcNow.Date.ToString();
        public static ucDailyCahReports Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucDailyCahReports();
                return _instance;
            }
        }
        public ucDailyCahReports()
        {
            InitializeComponent();
            displayTodayReport();
        }
        private void displayTodayReport()
        {
            try
            {
                DBconnection connection5 = new DBconnection();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(connection5.displayTodayReport(date));
                da.Fill(dt);
                dataGrid.DataSource = dt;
                connection5.getConnection().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Displaying Reports:\n" + ex, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                Console.WriteLine("Error: \n" + ex);
            }
        }

        private void ucDailyCahReports_Load(object sender, EventArgs e)
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

            cash.ReadOnly = true;
            cashInHand();
        }

        public void cashInHand()
        {
            
            DBconnection connection5 = new DBconnection();
            cash.Text = connection5.displayCashInHand(date);

        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
