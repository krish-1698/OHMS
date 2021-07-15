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
    public partial class donation_control : UserControl
    {
        public donation_control()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void donation_control_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("datasource=localhost; username=root; password=; database=OHMS");
            con.Open();
            MySqlCommand cmd= new MySqlCommand("select * from donor",con);
            MySqlDataAdapter adapt= new MySqlDataAdapter(cmd);
          
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            dataGridView2.DataSource = dt;
          
            
            DataGridViewButtonColumn Editlink = new DataGridViewButtonColumn();
            Editlink.UseColumnTextForButtonValue = true;
            Editlink.HeaderText = "Update";
            Editlink.Text = "Update";
            dataGridView2.Columns.Add(Editlink);

            DataGridViewButtonColumn Deletelink = new DataGridViewButtonColumn();
            Deletelink.UseColumnTextForButtonValue = true;
            Deletelink.HeaderText = "Delete";
            Deletelink.Text = "Delete";
            dataGridView2.Columns.Add(Deletelink);
            con.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                DialogResult answer = MessageBox.Show("Are you sure you want to Delete", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells["ID"].Value);
                    // MessageBox.Show(id.ToString());
                    MySqlConnection con = new MySqlConnection("datasource=localhost; username=root; password=; database=OHMS");
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("delete from donor where donor_id= @code", con);
                    cmd.Parameters.AddWithValue("@code", id);
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Record deleted Successfully");

                    }
                    else
                    {
                        MessageBox.Show("Record doesn't exist");
                    }
                    con.Close();

                }
            }
            if (dataGridView2.Columns[e.ColumnIndex].HeaderText == "Update")
            {
                int id, mobile;
                string fname, lname, nic, email;
                 id = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells["ID"].Value);
                 nic = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells["NIC_No"].Value);
                 fname = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells["First_name"].Value);
                 lname = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells["Last_name"].Value);
                 mobile = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells["mobile_no"].Value);
                email = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells["email"].Value);
                donor_form donor = new donor_form(id,nic,fname,lname,mobile,email);
                donor.ShowDialog();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (CheckDonorForm f1 = new CheckDonorForm())
            {
                f1.ShowDialog();

            }
        }
    }
}
