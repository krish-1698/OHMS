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
        int donor_id, mobile_no;
            string nic_no, f_name, l_name,email_add;

        private void donor_form_Load(object sender, EventArgs e)
        {
            textBoxBorder1.Text = donor_id.ToString();
            textBoxBorder2.Text = f_name;
            textBoxBorder3.Text = l_name;
            textBoxBorder4.Text = nic_no;
            textBoxBorder5.Text = mobile_no.ToString();
            textBoxBorder6.Text = email_add;
        }

        private void textBoxBorder2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public donor_form(int id,string nic,string fname,string lname,int mobile,string email)
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
