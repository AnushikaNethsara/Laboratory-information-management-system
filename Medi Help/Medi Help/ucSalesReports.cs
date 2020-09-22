using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;
using LiveCharts.Defaults;
using System.Data.SqlClient;

namespace Medi_Help
{
    public partial class ucSalesReports : UserControl
    {
        //public string conString = "Server=tcp:anushika.database.windows.net,1433;Initial Catalog=MediHelp;Persist Security Info=False;User ID=anushika;Password=im/2017/065;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        //public string conString = "Data Source=ANUSHH-IKKE;Initial Catalog=MediHelp;Integrated Security=True";

        public string conString = "Server=tcp:mnksql.database.windows.net,1433;Initial Catalog=MediHelp;Persist Security Info=False;User ID=mnk;Password=MitMediHelp1234;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        //public string conString = "Data Source=MNK-LAPTOP;Initial Catalog=MediHelp;Integrated Security=True";

        public SqlConnection getConnection()
        {

            SqlConnection con = new SqlConnection(conString);
            con.Open();
            return con;

        }
        private static ucSalesReports _instance;
        public static ucSalesReports Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucSalesReports();
                return _instance;
            }
        }
        public ucSalesReports()
        {
            InitializeComponent();
        }

        private void ucSales_Load(object sender, EventArgs e)
        {
            int[] mnkdates = new int[12];

            for (int i = 0; i < 12; i++)
            {
                mnkdates[i] = 0;
            }


            for (int i = 0; i < 12; i++)
            {
                try
                {
                    SqlCommand mnk = new SqlCommand("SELECT SUM(Total) as MNKTOTAL FROM dbo.Invoice WHERE Date LIKE '" + (i + 1) + "/%'", getConnection());
                    SqlDataReader reader = mnk.ExecuteReader();

                    while (reader.Read())
                    {
                        mnkdates[i] = Convert.ToInt32(reader["MNKTOTAL"]);
                        //MessageBox.Show(mnkdates[i].ToString());
                    }


                }
                catch (Exception ex)
                {
                    mnkdates[i] = 0;
                }

                finally
                {

                }
            }




            cartesianChart1.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Total Sales",
                    Values = new ChartValues<double> {mnkdates[0], mnkdates[1], mnkdates[2], mnkdates[3], mnkdates[4], mnkdates[5], mnkdates[6], mnkdates[7], mnkdates[8], mnkdates[9], mnkdates[10], mnkdates[11], }
                },

            };

            cartesianChart1.AxisX.Add(new Axis
            {
                Title = "Month",
                Labels = new[] { "Jan", "Feb", "Mar", "Apr", "May", "June", "July", "August", "September", "October", "November", "December" }
            });

            cartesianChart1.AxisY.Add(new Axis
            {
                Title = "Sales",
                LabelFormatter = value => value.ToString("C")
            });

            cartesianChart1.LegendLocation = LegendLocation.Right;

            //modifying the series collection will animate and update the chart
            /*cartesianChart1.Series.Add(new LineSeries
            {
                Values = new ChartValues<double> { 5, 3, 2, 4, 5 },
                LineSmoothness = 0, //straight lines, 1 really smooth lines
                PointGeometry = Geometry.Parse("m 25 70.36218 20 -28 -20 22 -8 -6 z"),
                PointGeometrySize = 50,
                PointForeground = System.Windows.Media.Brushes.Gray
            });*/

            //modifying any series values will also animate and update the chart
            cartesianChart1.Series[0].Values.Add(5d);


        }

        private void pieChart1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
