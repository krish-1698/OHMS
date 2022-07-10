using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OHMS
{
    public partial class donor_form : Form
    {
        dbConnection dbConnect = new dbConnection();
        string donor_id;
        int mobile_no;
            string nic_no, f_name, l_name,email_add;

        private void donor_form_Load(object sender, EventArgs e)
        {
            txt_donor_id.Text = donor_id.ToString();
            txt_fname.Text = f_name;
            txt_lname.Text = l_name;
            txt_nic.Text = nic_no;
            txt_contact.Text = mobile_no.ToString();
            txt_email.Text = email_add;
        }

        private bool checkEmpty()
        {
            if (txt_donor_id.Text == "" || txt_fname.Text == "" || txt_lname.Text == "" || txt_nic.Text == "" || txt_email.Text == "" || txt_contact.Text == "")
            { 
                    return true;
                }
            return false;

        }

        private void textBoxBorder2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checkEmpty() == true)
            {
                MessageBox.Show("Please fill all the fields", "MESSAGE!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    
                    dbConnect.OpenConnection();
                    dbConnect.ExecuteQueries("update donor set  first_name='" + txt_fname.Text + "', last_Name='" + txt_lname.Text + "', nic_no='" + txt_nic.Text + "', mobile_no='" + txt_contact.Text + "', email='" + txt_email.Text + "' where donor_Id='" + txt_donor_id.Text + "'");
                    MessageBox.Show("UPDATED Sucessfully", "SAVED!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dbConnect.CloseConnection();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public donor_form(string id,string nic,string fname,string lname,int mobile,string email)
        {
            InitializeComponent();
            donor_id = id;
            nic_no = nic;
            f_name = fname;
            l_name = lname;
            mobile_no = mobile;
            email_add = email;
        }

        private void textBoxBorder5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxBorder6_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
