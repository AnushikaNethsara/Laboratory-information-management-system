using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Medi_Help
{
    public partial class Front : Form
    {
        public Front()
        {
            InitializeComponent();
            DBconnection ox = new DBconnection();
            //Console.WriteLine("me me: " + global.UserID);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin ob = new Admin();
            ob.ShowDialog();

        }

        private void cashierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void mLTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mlt ob = new Mlt();
            ob.ShowDialog();
        }

        private void paymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cashier ob = new Cashier();
            ob.ShowDialog();
        }

        private void chemicalAndEquipmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChemicalAndEquipment ob = new ChemicalAndEquipment();
            ob.ShowDialog();
        }

        private void logoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult answer;
            answer = MessageBox.Show("Are you sure want to Logout?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (answer == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Front_Load(object sender, EventArgs e)
        {
            log.Text = global.UserID;
        }





        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void aboutUsToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void chemicalToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            
        }

        public void enableButton()
        {
            
        }




        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nipuna");
        }

        private void guna2PictureBox4_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2PictureBox6_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2PictureBox5_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            Admin ob = new Admin();
            ob.ShowDialog();
        }

        private void guna2ImageButton4_Click(object sender, EventArgs e)
        {
            Mlt ob = new Mlt();
            ob.ShowDialog();
        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {
            Cashier ob = new Cashier();
            ob.ShowDialog();
        }

        private void guna2ImageButton5_Click(object sender, EventArgs e)
        {
            ChemicalAndEquipment ob = new ChemicalAndEquipment();
            ob.ShowDialog();
        }

        private void guna2ImageButton7_Click(object sender, EventArgs e)
        {
            Notification ob = new Notification();
            ob.ShowDialog();
        }

        private void guna2ImageButton6_Click(object sender, EventArgs e)
        {
            DBconnection ui = new DBconnection();
            ui.showNotificationTimeToTime();
        }

        private void guna2ImageButton2_Click_1(object sender, EventArgs e)
        {
            Admin ob = new Admin();
            ob.ShowDialog();
        }

        private void guna2ImageButton3_Click_1(object sender, EventArgs e)
        {
            Cashier ob = new Cashier();
            ob.ShowDialog();
        }

        private void guna2ImageButton4_Click_1(object sender, EventArgs e)
        {
            Mlt ob = new Mlt();
            ob.ShowDialog();
        }

        private void guna2ImageButton5_Click_1(object sender, EventArgs e)
        {
            ChemicalAndEquipment ob = new ChemicalAndEquipment();
            ob.ShowDialog();
        }

        private void guna2ImageButton7_Click_1(object sender, EventArgs e)
        {
            Notification ob = new Notification();
            ob.ShowDialog();
        }

        private void guna2ImageButton6_Click_1(object sender, EventArgs e)
        {
            DBconnection ui = new DBconnection();
            ui.showNotificationTimeToTime();
        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ImageButton2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                e.Handled = true;
                guna2ImageButton3.Focus();
            }
        }

        private void log_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox2_Click_1(object sender, EventArgs e)
        {
            
        }

        private void guna2ImageButton2_Click_2(object sender, EventArgs e)
        {
            DBconnection obb = new DBconnection();
            if (obb.adminLogin(global.UserID))
            {
                Admin ob = new Admin();
                ob.ShowDialog();
            }
            else
            {
                MessageBox.Show("Only Admin has access!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void guna2ImageButton8_Click(object sender, EventArgs e)
        {
            DialogResult answer;
            answer = MessageBox.Show("Are you sure want to Logout?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (answer == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
