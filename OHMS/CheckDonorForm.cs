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
    public partial class CheckDonorForm : Form
    {
        dbConnection dbConnect = new dbConnection();
        Auto_increment aid = new Auto_increment();
        public CheckDonorForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dbConnect.OpenConnection();
            MySqlDataReader dr = dbConnect.DataReader("select * from donor where nic_no='"+txt_Search.Text+"'");
            while (dr.Read())
            {
                if (dr.HasRows)
                {
                    string fname = dr.GetString("first_name");
                    string lname = dr.GetString("last_name");
                    string donor_id = dr.GetString("donor_id");
                    DialogResult result = MessageBox.Show("Donor already exists in the name " + (char)34 + fname + " " + lname + (char)34 + Environment.NewLine + Environment.NewLine + "DO YOU WANT TO ADD THE DONATION?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        this.Close();
                        Form formbg = new Form();
                        using (donation_form f1 = new donation_form(donor_id,"btn_add"))
                        {
                            /* formbg.FormBorderStyle = FormBorderStyle.None;
                             formbg.Opacity = .50d;
                             formbg.BackColor = Color.Black;
                             formbg.Size = new Size(1386, 748);
                             formbg.StartPosition = FormStartPosition.CenterScreen;
                             formbg.Show();*/
                            //f1.Owner = formbg;
                            f1.ShowDialog();
                            // f1.Dispose();
                        }

                    }
                    else
                    {
                        this.Close();

                    }
                }
            }
               if(!dr.HasRows)
                {
                    DialogResult result = MessageBox.Show("It is a new Donor", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                    {
                    string new_id = aid.getPrimaryKey("DN", "SELECT donor_id FROM donor Order BY donor_id DESC LIMIT 1");
                    this.Close();
                    Form formbg = new Form();
                        using (donation_form f1 = new donation_form(new_id,"btn_add"))
                        {
                           /* formbg.FormBorderStyle = FormBorderStyle.None;
                            formbg.Opacity = .50d;
                            formbg.BackColor = Color.Black;
                            formbg.Size = new Size(1386, 748);
                            formbg.StartPosition = FormStartPosition.CenterScreen;
                            formbg.Show();*/
                            //f1.Owner = formbg;
                            f1.ShowDialog();
                           // f1.Dispose();
                        }

                    }
                   
                }
            
          
            
            //this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void visitors1_Load(object sender, EventArgs e)
        {

        }

        private void CheckDonorForm_Load(object sender, EventArgs e)
        {

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
