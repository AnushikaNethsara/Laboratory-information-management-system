using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medi_Help
{
    public partial class Form1 : Form
    {
        Thread thread;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            DBconnection ob = new DBconnection();
            ob.priceList();
            if (!ob.checkUserName("admin"))
            {
                byte[] bytes = Encoding.ASCII.GetBytes("0x53797374656D2E427974655B5D");
                employee ox = new employee("admin", "admin", "1997/06/02", "admin", 123, "Admin", "admin", "admin", bytes);
                ob.addEmployees(ox);
            }
            else
            {
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            

            
        }
        private void openFront(object obj)
        {
            Application.Run(new Front());
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //int logCount = 0;
            bool permission = false;
            if (uName.Text.Trim() != string.Empty && pWord.Text.Trim() != string.Empty)
            {
                try
                {

                    login ob = new login(uName.Text, pWord.Text);
                    DBconnection ox = new DBconnection();
                    permission = ox.adminLogin(ob);


                    if (permission == true)
                    {

                        thread = new Thread(openFront);
                        thread.SetApartmentState(ApartmentState.STA);
                        thread.Start();
                        Dispose();
                    }
                    else
                    {
                     
                        MessageBox.Show("Invalid User Name or Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error\n" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void uName_TextChanged(object sender, EventArgs e)
        {

        }

        private void uName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void pWord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void guna2CustomCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
  
        }

        private void guna2Button1_DragEnter(object sender, DragEventArgs e)
        {
            bool permission = false;
            if (uName.Text.Trim() != string.Empty && pWord.Text.Trim() != string.Empty)
            {
                try
                {

                    login ob = new login(uName.Text, pWord.Text);
                    DBconnection ox = new DBconnection();
                    permission = ox.adminLogin(ob);


                    if (permission == true)
                    {

                        thread = new Thread(openFront);
                        thread.SetApartmentState(ApartmentState.STA);
                        thread.Start();
                        Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Invalid User Name or Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error\n" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
