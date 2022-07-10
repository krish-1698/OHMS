using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;


namespace OHMS.user_control
{
    public partial class staff_control : UserControl
    {
        
        Auto_increment aid = new Auto_increment();
         dbConnection dbConnect = new dbConnection();
        string sid;
        // string filename= "OHMS.Properties.Resources.man_icon";
        string filename = @"C:\Users\Hp\Downloads\man-icon.png";
        string query = "select `Staff_Id`, `Nic_No`, `First_Name`, `Last_Name`, `Gender`, `DOB`, `Contact_no`, `Email`, `Address`, `Employment_Type`,`photo` from staff ";
        public staff_control()
        {
            InitializeComponent();
        }

      
        Byte[] ConvertImageToBinary(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }
        private bool checkEmpty()
        {
            if (txt_SId.Text == "" || txt_nic.Text == "" || txt_fname.Text == "" || txt_lname.Text == "" || richTxt_address.Text == "" || textBox1.Text == "" || txt_email.Text == "" || emptype_combo.SelectedIndex == -1 || dateTimePicker_dob.Text == "")
            {
                return true;
               
            }
            return false;
         
        }
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
                    string gender = gender_selection();
                    dbConnect.OpenConnection();
                    dbConnect.ExecuteQueries("insert into staff(Staff_Id, Nic_No, First_Name, Last_Name, Gender, DOB, Contact_no, Email, Address, Employment_Type,photo) Values ('" + txt_SId.Text + "','" + txt_nic.Text + "','" + txt_fname.Text + "','" + txt_lname.Text + "','" + gender + "','" + dateTimePicker_dob.Text + "','" + textBox1.Text + "','" + txt_email.Text + "','" + richTxt_address.Text + "','" + emptype_combo.Text + "','" + filename + "')");
                    MessageBox.Show("Added Sucessfully", "SAVED!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dbConnect.ShowDataInGridView(dataGridView1, query);
                    dbConnect.CloseConnection();
                    countStaff();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
           
                /*using (staff f1 = new staff())
            {
                f1.ShowDialog();

            }*/
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
            {
                MessageBox.Show("Selct the record to be deleted fro the table", "MESSAGE!", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
            }
            else
            {
                if (checkEmpty() == true)
                {
                    MessageBox.Show("Please fill all the fields", "MESSAGE!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    try
                    {
                        string gender = gender_selection();
                        dbConnect.OpenConnection();
                        dbConnect.ExecuteQueries("update staff set  Nic_No='" + txt_nic.Text + "', First_Name='" + txt_fname.Text + "', Last_Name='" + txt_lname.Text + "', Gender='" + gender + "', DOB='" + dateTimePicker_dob.Text + "', Contact_no='" + textBox1.Text + "', Email='" + txt_email.Text + "', Address='" + richTxt_address.Text + "', Employment_Type='" + emptype_combo.Text + "',photo='" + filename + "' where Staff_Id='" + txt_SId.Text + "'");
                        MessageBox.Show("UPDATED Sucessfully", "SAVED!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dbConnect.ShowDataInGridView(dataGridView1, query);
                        dbConnect.CloseConnection();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                //btn_refresh.PerformClick();
            }  
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dbConnect.OpenConnection();
            string query = $"SELECT  `staff_id`, `nic_no`, `first_name`, `last_name`,`gender`, `dob`,`contact_no`, `email`,`address`, `employment_type`  FROM `staff` WHERE `staff_id` LIKE \"%{txt_search.Text}%\" OR `nic_no` LIKE \"%{txt_search.Text}%\" OR `first_name` LIKE \"%{txt_search.Text}%\"  OR `last_name` LIKE \"%{txt_search.Text}%\" OR `gender` LIKE \"%{txt_search.Text}%\" OR `dob` LIKE \"%{txt_search.Text}%\" OR `contact_no` LIKE \"%{txt_search.Text}%\" OR `email` LIKE \"%{txt_search.Text}%\" OR `address` LIKE \"%{txt_search.Text}%\" OR `employment_type` LIKE \"%{txt_search.Text}%\"";
            dbConnect.ShowDataInGridView(dataGridView1, query);
            dbConnect.CloseConnection();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            label1.Hide();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            label1.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           // label1.Hide();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private string gender_selection()
        {
            string gender = null;
            if (male_radio.Checked == true)
            {
                gender = male_radio.Text;
            }
            if (female_radio.Checked == true)
            {
                gender = female_radio.Text;
            }
            return gender;
        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files (*.jpg;*.jpeg;*.png;.*.gif;)|*.jpg;*.jpeg;*.png;.*.gif";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox_photo.Image = new Bitmap(open.FileName);
               filename= open.FileName.Replace(@"\", @"\\");
                pictureBox_photo.Image = Image.FromFile(open.FileName);
             }
        }

        private void staff_control_Load(object sender, EventArgs e)
        {
            emptype_combo.SelectedIndex = 0;
            dateTimePicker_dob.MaxDate = DateTime.Today;
            dateTimePicker_dob.Value = DateTime.Today;
            dbConnect.OpenConnection();
             dbConnect.ShowDataInGridView(dataGridView1,query);
            countStaff();
            sid = aid.getPrimaryKey("SN", "SELECT staff_id FROM staff Order BY staff_id DESC LIMIT 1");
            txt_SId.Text = sid;
            /* MySqlConnection  con = new MySqlConnection("datasource=localhost; username=root; password=; database=OHMS");
               con.Open();
               MySqlDataAdapter adapt = new MySqlDataAdapter(query, con);
               DataTable dt = new DataTable();
               adapt.Fill(dt);
               dataGridView1.DataSource = dt;*/

            /*dt.Columns.Add("img", Type.GetType("System.Byte[]"));
            foreach (DataRow drow in dt.Rows)
            {
                drow["img"] = File.ReadAllBytes(drow["Photo"].ToString());
            }*/

            dbConnect.CloseConnection();
            
        }

        private void countStaff()
        {
            dbConnect.OpenConnection();
            MySqlDataReader dr = dbConnect.DataReader("Select count(staff_id) as num from staff");
            while (dr.Read())
            {
                label2.Text = dr.GetString("num");
            }
                dbConnect.CloseConnection();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_SId.Text = dataGridView1.CurrentRow.Cells["staff_id"].Value.ToString();
            txt_nic.Text = dataGridView1.CurrentRow.Cells["nic"].Value.ToString();
            txt_fname.Text = dataGridView1.CurrentRow.Cells["fname"].Value.ToString();
            txt_lname.Text = dataGridView1.CurrentRow.Cells["lname"].Value.ToString();
            if (dataGridView1.CurrentRow.Cells["gender"].Value.ToString() == "Male")
            {
                male_radio.Checked = true;
            }
            else
            {
                female_radio.Checked = true;
            }
            
            dateTimePicker_dob.Text = dataGridView1.CurrentRow.Cells["dob"].Value.ToString();
             richTxt_address.Text = dataGridView1.CurrentRow.Cells["address"].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells["contact"].Value.ToString();
            txt_email.Text = dataGridView1.CurrentRow.Cells["email"].Value.ToString();
            emptype_combo.Text = dataGridView1.CurrentRow.Cells["empType"].Value.ToString();
            if (dataGridView1.CurrentRow.Cells["empType"].Value.ToString()=="Full Time")
            {
                emptype_combo.SelectedItem="Full Time";
            }
            else if(dataGridView1.CurrentRow.Cells["empType"].Value.ToString() == "Part Time")
            {
                emptype_combo.SelectedItem="Full Time";
            }
            else
            {
                emptype_combo.SelectedItem = "Casual";
            }
            
            //txt_SId.Text = dataGridView1.Rows[e.RowIndex].Cells["staff_id"].Value.ToString();
            //dbConnect.OpenConnection();

            MySqlConnection con = new MySqlConnection("datasource=localhost; username=root; password=; database=OHMS");
            System.Console.WriteLine(txt_SId.Text);
            if (txt_SId.Text != "")
            {

                con.Open();
                MySqlCommand cmd = new MySqlCommand("select * from staff where staff_id='" + txt_SId.Text + "' ", con);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    txt_filepath.Text = reader.GetString("photo");
                    System.Console.WriteLine(txt_filepath.Text);


                }
            }
            else
            {
                MessageBox.Show("Please fill", "SAVED!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            //System.Console.WriteLine(lbl_filepath.Text);
           if (txt_filepath.Text == "OHMS.Properties.Resources.man_icon")
            {
                pictureBox_photo.Image = OHMS.Properties.Resources.man_icon;
            }
            else
            {
                Image image = Image.FromFile(txt_filepath.Text);
                this.pictureBox_photo.Image = image;
            }
            
            
            //textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            
            con.Close();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            txt_SId.Text = aid.getPrimaryKey("SN", "SELECT staff_id FROM staff Order BY staff_id DESC LIMIT 1");;
            txt_nic.Text = "";
            txt_fname.Text = "";
            txt_lname.Text = "";
            dateTimePicker_dob.Value = DateTime.Today;
            richTxt_address.Text = "";
            textBox1.Text = "";
            txt_email.Text = "";
            emptype_combo.SelectedIndex = 0;
            female_radio.Checked = false;
            male_radio.Checked = true;
            pictureBox_photo.Image = OHMS.Properties.Resources.man_icon;
        }

        private void txt_filepath_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (txt_nic.Text != "")
            {
                try
                {

                    dbConnect.OpenConnection();
                    dbConnect.ExecuteQueries("delete from staff where Staff_Id='" + txt_SId.Text + "'");
                    DialogResult result = MessageBox.Show("Are you sure you Delete this record ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        MessageBox.Show("DELETED Sucessfully", "MESSAGE!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    dbConnect.ShowDataInGridView(dataGridView1, query);
                    dbConnect.CloseConnection();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Selct the record to be deleted from the table", "MESSAGE!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            btn_refresh.PerformClick();
        }

        private void label2_Click(object sender, EventArgs e)
        {
         

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_nic_TextChanged(object sender, EventArgs e)
        {
            if (validation.ValidNewNIC(txt_nic.Text) || validation.ValidOldNIC(txt_nic.Text))
            {

                lb_nic.Visible = false;
            }
            else
            {
                lb_nic.Visible = true;
                //lb_nic.Text = "Invalid!";

            }
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txt_nic_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txt_nic_KeyUp(object sender, KeyEventArgs e)
        {
           /* if (validation.ValidNewNIC(txt_nic.Text) || validation.ValidOldNIC(txt_nic.Text))
            {

                lb_nic.Visible = false;
            }
            else
            {
                lb_nic.Visible = true;
                //lb_nic.Text = "Invalid!";

            }*/
        }

        private void txt_email_KeyUp(object sender, KeyEventArgs e)
        {
            if (validation.ValidEmail(txt_email.Text))
            {

                lbl_email.Visible = false;
            }
            else
            {
                lbl_email.Visible = true;
                //lb_nic.Text = "Invalid!";

            }
            
        }

        private void txt_fname_KeyUp(object sender, KeyEventArgs e)
        {
            if (validation.ValidName(txt_fname.Text))
            {

                lbl_fname.Visible = false;
            }
            else
            {
                lbl_fname.Visible = true;
                lbl_fname.Text = "Invalid!";

            }
        }

        private void txt_lname_KeyUp(object sender, KeyEventArgs e)
        {
            if (validation.ValidName(txt_lname.Text))
            {

                lbl_lname.Visible = false;
            }
            else
            {
                lbl_lname.Visible = true;
                lbl_lname.Text = "Invalid!";

            }
        }
    }
}
