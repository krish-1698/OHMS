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
    public partial class Expense_control : UserControl
    {
        public Expense_control()
        {
            InitializeComponent();
        
        }


        private void DisplayData()
        {
            MySqlConnection con = new MySqlConnection("datasource=localhost; username=root; password=; database=OHMS");
            MySqlCommand cmd;
            MySqlDataAdapter adapt;
            con.Open();
            DataTable dt = new DataTable();
            adapt = new MySqlDataAdapter("select * from expense", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
           /* dataGridView1.AutoGenerateColumns = false;
            
            dataGridView1.AllowUserToAddRows = false;
            int i = 1;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells["Expense_ID"].Value = i;
                i++;
            }*/
            con.Close();

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           /* if (e.RowIndex > 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells["Employee_ID"].Value.ToString();
                textBox2.Text = row.Cells["Amount"].Value.ToString();
                textBox1.Text = row.Cells["Purpose"].Value.ToString();
            }*/
            

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
           /* textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();*/
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          //  textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
          //textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            //textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            
        }

        private void Expense_control_Load(object sender, EventArgs e)
        {
            DisplayData();
           /* MySqlConnection SqlConnection = new MySqlConnection("datasource=localhost; username=root; password=; database=OHMS");
            MySqlDataReader reader = null;

            
                SqlConnection.Open();//open the connction
                MySqlCommand command = new MySqlCommand("Select sum(amount) as total from expense", SqlConnection);
                reader = command.ExecuteReader();
            while (reader.Read())
            {
                textBox4.Text = reader["total"].ToString();
            }
            String total = textBox4.Text;
            using (income_report rep = new income_report(total))
            {
                rep.ShowDialog();
            }*/
                /*  DataGridViewLinkColumn Editlink = new DataGridViewLinkColumn();
                  Editlink.UseColumnTextForLinkValue = true;
                  Editlink.HeaderText = " ";
                  Editlink.DataPropertyName = "lnkColumn";
                  Editlink.LinkBehavior = LinkBehavior.SystemDefault;
                  Editlink.Text = "Edit";
                  dataGridView1.Columns.Add(Editlink);

                  DataGridViewLinkColumn Deletelink = new DataGridViewLinkColumn();
                  Deletelink.UseColumnTextForLinkValue = true;
                  Deletelink.HeaderText = "";
                  Deletelink.DataPropertyName = "lnkColumn";
                  Deletelink.LinkBehavior = LinkBehavior.SystemDefault;
                  Deletelink.Text = "Delete";
                  dataGridView1.Columns.Add(Deletelink);*/
            }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
