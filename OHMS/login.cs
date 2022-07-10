using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace OHMS
{
    public partial class login : Form
    {
        dbConnection dbConnect = new dbConnection();
        string uname = " ";
        //string id;
        public login()
        {
            InitializeComponent();
           
        }

        private void login_Load(object sender, EventArgs e)
        {
            button2.FlatAppearance.BorderSize = 0;
        }

       
        private void button1_Click(object sender, EventArgs e)
        {        
             uname = txt_username.Text;
            try
            {
                if (txt_username.Text == "" || txt_pasword.Text == "")
                {
                    MessageBox.Show("Please Fill Empty Fields!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                {
                    String query = "SELECT * FROM user WHERE username = '" + txt_username.Text + "' AND password =md5('" + txt_pasword.Text + "') ";
                    dbConnect.OpenConnection();
                    MySqlDataReader reader = dbConnect.DataReader(query);
                    if (reader.Read())
                    {
                        string role=reader.GetString("role");
                        if (role=="Admin")
                        {
                            using (Admin_Dashboard f1 = new Admin_Dashboard(uname))
                            {
                                this.Hide();
                                f1.ShowDialog();

                            }
                        }
                        else
                        {
                            using (Staff.Staff_Dashboard f1 = new Staff.Staff_Dashboard(uname))
                            {
                                this.Hide();
                                f1.ShowDialog();

                            }
                        }
                        dbConnect.CloseConnection();
                        //changePass ch1 = new changePass(id);
                    }

                    else
                    {
                        MessageBox.Show("USERNAME OR PASSWORD IS INCORRECT!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Unable to connect to the \n Database!", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.Message);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxBorder1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBoxBorder1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                txt_pasword.Focus();
                e.SuppressKeyPress = true; 
            }
            else if (e.KeyCode.Equals(Keys.Up))
            {
                txt_pasword.Focus();
            }
            else if (e.KeyCode.Equals(Keys.Down))
            {
                txt_pasword.Focus();
            }
        }

        private void textBoxBorder2_KeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                button1.PerformClick();
              //button1_Click(sender, e);
               // e.Handled = true;
              e.SuppressKeyPress = true;             
            }
            else if (e.KeyCode.Equals(Keys.Up))
            {
                txt_username.Focus();
            }
            else if (e.KeyCode.Equals(Keys.Down))
            {
                txt_username.Focus();
            }
        }

        private void textBoxBorder2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
