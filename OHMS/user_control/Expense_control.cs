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
        Auto_increment aid = new Auto_increment();
        dbConnection dbConnect = new dbConnection();
        public Expense_control()
        {
            InitializeComponent();
        
        }

        private bool checkEmpty()
        {
            if (txt_exp_id.Text == "" || txt_amount.Text == "" || dtp_date.Text == "" || rich_purpose.Text == "" )
            {
                return true;

            }
            return false;

        }

        private void DisplayData()
        {
            MySqlConnection con = new MySqlConnection("datasource=localhost; username=root; password=; database=OHMS");
            //MySqlCommand cmd;
            MySqlDataAdapter adapt;
            con.Open();
            DataTable dt = new DataTable();
            adapt = new MySqlDataAdapter("select Date_paid,Amount,Purpose from expense", con);
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
            if (checkEmpty() == true)
            {
                MessageBox.Show("Please fill all the fields", "MESSAGE!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {

                    // pictureBox_photo.Image.Save(ms, pictureBox_photo.Image.RawFormat);
                    //  ConvertImageToBinary(pictureBox_photo.Image)
                   
                    dbConnect.OpenConnection();
                    dbConnect.ExecuteQueries("insert into expense(expense_Id,amount,date_paid, purpose) Values ('" + txt_exp_id.Text + "','" + txt_amount.Text + "','" + dtp_date.Text + "','" + rich_purpose.Text + "'");
                    MessageBox.Show("Added Sucessfully", "SAVED!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dbConnect.ShowDataInGridView(dataGridView1, "select * from expense");
                    dbConnect.CloseConnection();
                  
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
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
          //  DisplayData();
            dbConnect.OpenConnection();
            dbConnect.ShowDataInGridView(dataGridView1, "select * from expense");
            dbConnect.CloseConnection();
           //txt_exp_id.Text= aid.getPrimaryKey("EX", "SELECT expense_id FROM  expense Order BY expense_id DESC LIMIT 1");
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
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

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBoxBorder1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxBorder3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBoxBorder2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {

                dbConnect.OpenConnection();
                dbConnect.ExecuteQueries("delete from expense where expense_Id='" + txt_exp_id.Text + "'");
                DialogResult result = MessageBox.Show("Are you sure you Delete this record ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("DELETED Sucessfully", "MESSAGE!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                dbConnect.ShowDataInGridView(dataGridView1, "Select * from expense ");
                dbConnect.CloseConnection();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
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
                    dbConnect.ExecuteQueries("update expense set  amount='" + txt_amount.Text + "', date_paid='" + dtp_date.Text + "', purpose='" + rich_purpose.Text + "' where expense_Id='" + txt_exp_id.Text + "'");
                    MessageBox.Show("UPDATED Sucessfully", "SAVED!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dbConnect.ShowDataInGridView(dataGridView1, "select * from expense");
                    dbConnect.CloseConnection();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

            txt_exp_id.Text = dataGridView1.CurrentRow.Cells["expense_id"].Value.ToString();
            txt_amount.Text = dataGridView1.CurrentRow.Cells["amount"].Value.ToString();
            dtp_date.Text = dataGridView1.CurrentRow.Cells["date_paid"].Value.ToString();
            rich_purpose.Text = dataGridView1.CurrentRow.Cells["purpose"].Value.ToString();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {

            dbConnect.OpenConnection();
            string query = $"SELECT  `amount`, `date_paid`, `purpose` from expense WHERE `amount` LIKE \"%{txt_search.Text}%\" OR `date_paid` LIKE \"%{txt_search.Text}%\" OR `purpose` LIKE \"%{txt_search.Text}%\"";
            dbConnect.ShowDataInGridView(dataGridView1, query);
            dbConnect.CloseConnection();
        }
    }
}
