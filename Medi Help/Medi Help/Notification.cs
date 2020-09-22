using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Timers;
using System.Threading;
using System.Threading.Tasks;
using System.Data.Common;
using System.Data.SqlClient;

namespace Medi_Help
{
    public partial class Notification : Form
    {
        public Notification()
        {
            InitializeComponent();
            
        }

        public static void AlertSend(string msg, Alert.enmType type)
        {
            Alert frm = new Alert();
            frm.showAlert(msg, type);
        }

        public void showNotification(string notificationText,string selected)
        {
            
            if (selected.Equals("Success Alert"))
            {
                AlertSend(notificationText, Alert.enmType.Success);
                //AlertSend(notificationText, Alert.enmType.Success);
            }
            else if (selected.Equals("Warning Alert"))
            {
                AlertSend(notificationText, Alert.enmType.Warning);
                //AlertSend(notificationText, Alert.enmType.Warning);
            }
            else if (selected.Equals("Error Alert"))
            {
                AlertSend(notificationText, Alert.enmType.Error);
                //AlertSend(notificationText, Alert.enmType.Error);
            }
            else
            {
                AlertSend(notificationText, Alert.enmType.Info);
                //AlertSend(notificationText, Alert.enmType.Info);
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {

            
            
        }

        private void clear()
        {
            nType.Text = "";
            notifi.Text = "";
            about.Text = "";
        }


        //timer
        private static System.Timers.Timer aTimer;
        private static void SetTimer()
        {
            aTimer = new System.Timers.Timer(1000);
            // Hook up the Elapsed event for the timer. 
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;            
        }
        
        private static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            //showNotification("Hello notifi", "Warning Alert");
            //MessageBox.Show("hello");
            //DBconnection ui = new DBconnection();
            //ui.showNotificationTimeToTime();
        }

        public void display()
        {
            
            try
            {
                DBconnection ob = new DBconnection();
                

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(ob.displayNotifi());
                da.Fill(dt);
                dataGrid.DataSource = dt;
                ob.getConnection().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Displaying Reports:\n" + ex, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                Console.WriteLine("Error: \n" + ex);
            }

        }


        private void Notification_Load(object sender, EventArgs e)
        {
            display();
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

            //ui.showNotificationTimeToTime();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //SetTimer();
            //showNotification("Hello notifi", "Warning Alert");
            //showNotification("Hello notifi", "Warning Alert");
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            if (notifi.Text.Trim() == string.Empty || nType.Text.Trim() == string.Empty || about.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Empty Fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                string selected = this.nType.GetItemText(this.nType.SelectedItem);
                showNotification(notifi.Text, selected);
                DBconnection ob = new DBconnection();
                string messageId = primaryKey.RandomString(6);
                Message ox = new Message(messageId, notifi.Text, nType.Text);
                ob.messageDatebase(ox);
                clear();
            }
            display();
        }

        string id = "";
        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (id == "")
            {
                MessageBox.Show("Select Message before Delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DBconnection ob = new DBconnection();
                ob.deleteNotify(id);
                display();
            }
            
        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                
                DataGridViewRow row = this.dataGrid.Rows[e.RowIndex];

                id = row.Cells["MessageId"].Value.ToString();

            }
        }
    }
}
