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
        
        dbConnection dbConnect = new dbConnection();
        Auto_increment aid = new Auto_increment();
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
            dbConnect.OpenConnection();
             dbConnect.ShowDataInGridView(dataGridView2,"select * from donor");
            dbConnect.ShowDataInGridView(dataGridView1, "select * from donation");
            //   setDataToTable("select * from donor");

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
            dbConnect.CloseConnection();
            // con.Close();
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
                    MySqlCommand cmd = new MySqlCommand("delete from donor where donor_id=@code", con);
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
                String id;
                    int mobile;
                string fname, lname, nic, email;
                 id = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells["ID"].Value);
                 nic = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells["NIC_No"].Value);
                 fname = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells["First_name"].Value);
                 lname = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells["Last_name"].Value);
                 mobile = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells["mobile_no"].Value);
                email = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells["email"].Value);
                donor_form donor = new donor_form(id,nic,fname,lname,mobile,email);
                donor.ShowDialog();
            }
            dbConnect.ShowDataInGridView(dataGridView1, "select * from donation");
            dbConnect.ShowDataInGridView(dataGridView2, "select * from donor");
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form formbg = new Form();
            using (CheckDonorForm f1 = new CheckDonorForm())
            {
                /*formbg.FormBorderStyle = FormBorderStyle.None;
                formbg.Opacity = .50d;
                formbg.BackColor = Color.Black;
                formbg.Size = new Size(1386, 748);
                formbg.StartPosition = FormStartPosition.CenterScreen;
                formbg.Show();
                f1.Owner = formbg;*/
                f1.ShowDialog();
               // f1.Dispose();
            }
           /* using (CheckDonorForm f1 = new CheckDonorForm())
            {
                f1.ShowDialog();

            }*/
        }

        private void button7_Click(object sender, EventArgs e)
        {
          
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
           /* dbConnect.OpenConnection();
            string query = $"SELECT  `donor_id`, `nic_no`, `first_name`, `last_name`,`mobile_no`, `email`  FROM `donor` WHERE `donor_id` LIKE \"%{txt_search.Text}%\" OR `nic_no` LIKE \"%{txt_search.Text}%\" OR `first_name` LIKE \"%{txt_search.Text}%\"  OR `last_name` LIKE \"%{txt_search.Text}%\" OR `mobile_no` LIKE \"%{txt_search.Text}%\" OR `email` LIKE \"%{txt_search.Text}%\"";
             dbConnect.ShowDataInGridView(dataGridView2,query);
            dbConnect.CloseConnection();*/
           /* MySqlConnection con = new MySqlConnection("datasource=localhost; username=root; password=; database=OHMS");
            MySqlCommand cmd;
            con.Open();
            //(dataGridView2.DataSource as DataTable).DefaultView.RowFilter = string.Format("ID' LIKE '%{0}%' OR 'NIC_No' LIKE '%{0}%' OR 'First_name' LIKE '%{0}%'  OR 'Last_name' LIKE '%{0}%' OR 'mobile_no' LIKE '%{0}%' OR 'email' LIKE '%{0}%'", txt_search.Text);
             cmd = new MySqlCommand(query, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            MySqlDataAdapter adapt = new MySqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();*/
        }

        private void text_search_KeyUp(object sender, KeyEventArgs e)
        {
            dbConnect.OpenConnection();
            string query = $"SELECT  `donor_id`, `nic_no`, `first_name`, `last_name`,`mobile_no`, `email`  FROM `donor` WHERE `donor_id` LIKE \"%{txt_search.Text}%\" OR `nic_no` LIKE \"%{txt_search.Text}%\" OR `first_name` LIKE \"%{txt_search.Text}%\"  OR `last_name` LIKE \"%{txt_search.Text}%\" OR `mobile_no` LIKE \"%{txt_search.Text}%\" OR `email` LIKE \"%{txt_search.Text}%\"";
            dbConnect.ShowDataInGridView(dataGridView2, query);
            dbConnect.CloseConnection();
            //string query = $"SELECT  `donor_id`, `nic_no`, `first_name`, `last_name`,`mobile_no`, `email`  FROM `donor` WHERE `donor_id` LIKE \"%{txt_search.Text}%\" OR `nic_no` LIKE \"%{txt_search.Text}%\" OR `first_name` LIKE \"%{txt_search.Text}%\"  OR `last_name` LIKE \"%{txt_search.Text}%\" OR `mobile_no` LIKE \"%{txt_search.Text}%\" OR `email` LIKE \"%{txt_search.Text}%\"";
            /* MySqlConnection con = new MySqlConnection("datasource=localhost; username=root; password=; database=OHMS");
             //MySqlCommand cmd;
             con.Open();
            // cmd = new MySqlCommand(query, con);
             //MySqlDataReader reader = cmd.ExecuteReader();
             MySqlDataAdapter adapt = new MySqlDataAdapter(query,con);
              DataTable dt = new DataTable();
             adapt.Fill(dt);
             dataGridView2.DataSource = dt;
             con.Close();*/
            //setDataToTable(query);
        }


        void setDataToTable(string query)
        {
            dataGridView2.Rows.Clear();
            dataGridView2.Refresh();
            MySqlConnection con = new MySqlConnection("datasource=localhost; username=root; password=; database=OHMS");
            MySqlCommand cmd;
            con.Open();
            cmd = new MySqlCommand(query, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            
            //  dbConnection.DataReader read = new dbConnection.DataReader();
           
            while (reader.Read())
            {
                int x = dataGridView2.Rows.Add();
                dataGridView2.Rows[x].Cells[0].Value = reader.GetString("donor_id");
                dataGridView2.Rows[x].Cells[1].Value = reader.GetString("nic_no");
                dataGridView2.Rows[x].Cells[2].Value = reader.GetString("first_name");
                dataGridView2.Rows[x].Cells[3].Value = reader.GetString("last_name");
                dataGridView2.Rows[x].Cells[4].Value = reader.GetString("mobile_no");
                dataGridView2.Rows[x].Cells[5].Value = reader.GetString("email");
                //dataGridView1.Rows[x].Cells[6].Value = reader.GetString("ID");

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Donation_Id"].Value);
            Form formbg = new Form();
            using (donation_form f1 = new donation_form(id,"grid_click"))
            {
                f1.ShowDialog();
            }
        }
    }
}
