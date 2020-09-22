using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Medi_Help
{
    public partial class ucCashReports : Medi_Help.ucDailyCahReports
    {

        private static ucCashReports _instance;
        string date = DateTime.UtcNow.Date.ToString();
        public static new ucDailyCahReports Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucCashReports();
                return _instance;
            }
        }
        public ucCashReports()
        {
            InitializeComponent();
            
        }
        DBconnection ob = new DBconnection();
        private void ucCashReports_Load(object sender, EventArgs e)
        {
            
        }
        
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string date1 = dateOne.ToString();
            string date2 = dateTwo.ToString();
            try
            {
                DBconnection connection5 = new DBconnection();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(connection5.displayReportBetweentwodays(date1,date2));
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

     
    }
}
