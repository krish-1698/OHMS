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

namespace OHMS.user_control
{
    public partial class visitors : UserControl
    {
        dbConnection dbConnect = new dbConnection();
        public visitors()
        {
            InitializeComponent();
        }


        private void getlastId()
        {
            int id;

            MySqlConnection con = new MySqlConnection("datasource=localhost; username=root; password=; database=OHMS");
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select Max(visitor_id) from visitor", con);
            //  MySqlDataScalar dr = cmd.ExecuteScalar();
            // String id = cmd.ExecuteScalar();
            Object o = cmd.ExecuteScalar();
            if (o == null)
            {
               
                 id = Convert.ToInt32(o);
            }
            else
            {
                id = Convert.ToInt32(cmd.ExecuteScalar());
                int result = (id + 1);
                textBoxBorder1.Text = result.ToString();
            }
           
          
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void visitors_Load(object sender, EventArgs e)
        {
            //getlastId();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "dd/MM/yyyy hh:mm tt";
         
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "dd/MM/yyyy hh:mm tt";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            dbConnect.ExecuteQueries("insert into visitor(nic_no,name,date_in_time,date_out_time) Values ('" + textBoxBorder3.Text + "','" + textBoxBorder1.Text + "','" + dateTimePicker1.Text + "','" + dateTimePicker2.Text +  "')");
            MessageBox.Show("Added Sucessfully", "SAVED!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
