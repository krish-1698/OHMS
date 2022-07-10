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
    public partial class staffAttendance_control : UserControl
    {
        Auto_increment aid = new Auto_increment();
        dbConnection dbConnect = new dbConnection();
        public staffAttendance_control()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private bool checkEmpty()
        {
            if (txt_staff_id.Text == "" || txt_name.Text == "" ||  dtp_inTime.Text == "" || cal_date.Text == ""  || dtp_outTime.Text == "")
            {
                return true;

            }
            return false;

        }
        //cal_date.Text == "" ||

        private void btn_add_Click(object sender, EventArgs e)
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
                    dbConnect.ExecuteQueries("insert into staff_attendance(staff_attendance_id,staff_id,Date,in_time,out_time) Values ('" + txt_staffAttend.Text + "','" + txt_staff_id.SelectedItem + "','" + cal_date.SelectionStart.Date.ToShortDateString() + "','" + dtp_inTime.Text + "','" + dtp_outTime.Text + "')");
                  // textBox1.Text = cal_date.SelectionStart.Date.ToShortDateString();
                    MessageBox.Show("Added Sucessfully", "SAVED!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    comboBox1.SelectedIndex = comboBox1.Items.IndexOf("Today");
                    if (comboBox1.SelectedItem.ToString()=="Today")
                    {
                        dbConnect.ShowDataInGridView(dataGridView1, "select staff.first_name,staff_attendance.* from staff inner join staff_attendance on staff.staff_id=staff_attendance.staff_id where staff_attendance.date='"+DateTime.Today+"'");
                    }
                    else if (comboBox1.SelectedItem.ToString()=="Yesterday"){
                        dbConnect.ShowDataInGridView(dataGridView1, "select staff.first_name,staff_attendance.* from staff inner join staff_attendance on staff.staff_id=staff_attendance.staff_id where staff_attendance.date='"+DateTime.Today.AddDays(-1)+"'");
                    }
                    else
                    {

                    }
                        dbConnect.CloseConnection();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void comboBoxLoad()
        {
            
            string str = "select  staff_id from staff ";
            dbConnect.OpenConnection();
            MySqlDataReader reader = dbConnect.DataReader(str);
            while (reader.Read())
            {
                txt_staff_id.Items.Add(reader["staff_id"].ToString());

            }
            
            dbConnect.CloseConnection();
        }

        private void staffAttendance_control_Load(object sender, EventArgs e)
        {
            cal_date.MaxDate = DateTime.Today;
            cal_date.SelectionStart.Date.ToString("D");
            //yyyy-MM-dd
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "D";
            comboBoxLoad();
            //dtp_inTime.Format = DateTimePickerFormat.Custom;
            // dtp_inTime.CustomFormat = "hh : mm tt";
            //  dtp_outTime.Format = DateTimePickerFormat.Custom;
            // dtp_outTime.CustomFormat = "hh : mm tt";
            dbConnect.OpenConnection();
            MySqlDataReader reader = dbConnect.DataReader("SELECT staff_attendance_id FROM  staff_attendance Order BY staff_attendance_id DESC LIMIT 1");
            while (reader.Read())
            {
                int id = Convert.ToInt32(reader.GetString("staff_attendance_id"))+1;
                txt_staffAttend.Text = id.ToString();
            }
            reader.Close();
            comboBox1.SelectedIndex= comboBox1.Items.IndexOf("Today");
            if (comboBox1.SelectedItem.ToString() == "Today")
            {
                dbConnect.ShowDataInGridView(dataGridView1, "select staff.first_name,staff_attendance.* from staff inner join staff_attendance on staff.staff_id=staff_attendance.staff_id where staff_attendance.date='" + DateTime.Today + "'");
            }
            else if (comboBox1.SelectedItem.ToString() == "Yesterday")
            {
                dbConnect.ShowDataInGridView(dataGridView1, "select staff.first_name,staff_attendance.* from staff inner join staff_attendance on staff.staff_id=staff_attendance.staff_id where staff_attendance.date='" + DateTime.Today.AddDays(-1) + "'");
            }
            else
            {

            }
           
            dbConnect.CloseConnection();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {
            /*string query = "select first_name,last_name from staff where staff_id='"+txt_staff_id.SelectedItem+"'";
            dbConnect.OpenConnection();
            MySqlDataReader reader=dbConnect.DataReader(query);
            while(reader.Read()){
               txt_name.Text= reader.GetString("first_name")+ " "+ reader.GetString("last_name");
            }*/
        }

        private void txt_staff_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "select first_name,last_name from staff where staff_id='" + txt_staff_id.SelectedItem + "'";
            dbConnect.OpenConnection();
            MySqlDataReader reader = dbConnect.DataReader(query);
            while (reader.Read())
            {
                txt_name.Text = reader.GetString("first_name") + " " + reader.GetString("last_name");
            }
            dbConnect.CloseConnection();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dbConnect.OpenConnection();
            string query = $"SELECT  `staff_Id`, `name`, `date`,`in_time`,`out_time` WHERE `date` LIKE \"%{dateTimePicker1.Text}%\" ";
            dbConnect.ShowDataInGridView(dataGridView1, query);
            dbConnect.CloseConnection();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

           /* dbConnect.OpenConnection();
            string query = $"SELECT  `staff_Id`, `name`, `date`,`in_time`,`out_time` WHERE `date` LIKE \"%{comboBox1.Text}%\" ";
            dbConnect.ShowDataInGridView(dataGridView1, query);
            dbConnect.CloseConnection();*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dbConnect.OpenConnection();
            dbConnect.ShowDataInGridView(dataGridView1, "select staff.first_name,staff_attendance.* from staff inner join staff_attendance on staff.staff_id=staff_attendance.staff_id ");
            dbConnect.CloseConnection();
        }
    }
}
