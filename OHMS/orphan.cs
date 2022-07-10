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
    public partial class orphan : Form
    {
        string filename= @"C:\Users\Hp\Downloads\man-icon.png".Replace(@"\", @"\\");
        string id,btn;
        Auto_increment aid = new Auto_increment();
        dbConnection dbConnect = new dbConnection();
        public orphan(string or_id,string btn_check)
        {
            InitializeComponent();
            id = or_id;
            btn = btn_check;
        }

        private bool checkEmpty()
        {
            if (txt_id.Text == "" || text_fname.Text == "" || txt_lname.Text == ""  || DOB.Text == "" || DOA.Text == "" || richdeficiencies.Text == "" || txt_gname.Text == "" || txt_nic.Text == "" || txtguardiancontact.Text=="" || richhowboarded.Text=="" || rich_address.Text=="")
            {
                return true;

            }
            return false;

        }
        private void btn_upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files (*.jpg;*.jpeg;*.png;.*.gif;)|*.jpg;*.jpeg;*.png;.*.gif";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox_photo.Image = new Bitmap(open.FileName);
                filename = open.FileName.Replace(@"\", @"\\");
                pictureBox_photo.Image = Image.FromFile(open.FileName);
            }
        }

        private void txt_guardianName_TextChanged(object sender, EventArgs e)
        {

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
                    string gender = gender_selection();
                    dbConnect.OpenConnection();
                    dbConnect.ExecuteQueries("update orphan set  first_name='" + text_fname.Text + "', last_Name='" + txt_lname.Text + "', Gender='" + gender + "', DOB='" + DOB.Text + "', Date_of_admission='" + DOA.Text + "', health_deficiencies='" + richdeficiencies.Text + "', guardian_name='" + txt_gname.Text + "', guardian_nic='" + txt_nic.Text + "',contact_no='" + txtguardiancontact.Text + "',address='"+rich_address.Text+"',how_inmate_boarded='" + richhowboarded.Text + "',photo='"+filename+"' where Staff_Id='" + txt_id.Text + "'");
                    MessageBox.Show("UPDATED Sucessfully", "SAVED!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dbConnect.CloseConnection();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void orphan_Load(object sender, EventArgs e)
        {
            dbConnect.OpenConnection();
            DOB.MaxDate = DateTime.Today;
            DOB.Value = DateTime.Today;
            DOA.MaxDate = DateTime.Today;
            DOA.Value = DateTime.Today;
            if (btn.Equals("grid_click"))
            {
                sc_panel.Hide(); MySqlDataReader reader = dbConnect.DataReader("Select * from orphan where orphan_id='" + id + "'");
                while (reader.Read())
                {
                    txt_id.Text = reader.GetString("orphan_id");
                    txt_lname.Text = reader.GetString("last_name");
                    text_fname.Text = reader.GetString("first_name");
                    if (reader.GetString("gender") == "Male")
                    {
                        radioButton2.Checked = true;
                       // radioButton2.Checked = false;
                    }
                    else
                    {
                        radioButton1.Checked = true;
                       //radioButton1.Checked = false;
                    }
                    DOB.Text = reader.GetString("dob");
                    DOA.Text = reader.GetString("Date_of_Admission");
                    richdeficiencies.Text = reader.GetString("health_deficiencies");
                    txt_gname.Text = reader.GetString("guardian_name");
                    txt_nic.Text = reader.GetString("guardian_nic");
                    txtguardiancontact.Text = reader.GetString("contact_no");
                    richhowboarded.Text = reader.GetString("How_Inmate_Boarded");
                    rich_address.Text = reader.GetString("Guardian_address");
                    if (reader.GetString("photo") == "OHMS.Properties.Resources.man_icon")
                    {
                        pictureBox_photo.Image = OHMS.Properties.Resources.man_icon;
                    }
                    else
                    {
                        Image image = Image.FromFile(reader.GetString("photo"));
                        this.pictureBox_photo.Image = image;
                    }
                }
                
            }
            else
            {
                ud_panel.Hide();
                txt_id.Text = aid.getPrimaryKey("OR", "SELECT orphan_id FROM orphan Order BY orphan_id DESC LIMIT 1");
            }
          
           
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            /* user_control.orphan_control or = new user_control.orphan_control();
             panelControls.Controls.Clear();
             panelControls.Controls.Add(or);
             or.Dock = DockStyle.Fill;
             or.BringToFront();*/
          
            Admin_Dashboard admin = new Admin_Dashboard();
            admin.addcontrols1();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            this.Close();
           // user_control.orphan_control or = new user_control.orphan_control();
            Admin_Dashboard admin = new Admin_Dashboard();
            admin.addcontrols1();

        }
        //save
        private void button2_Click(object sender, EventArgs e)
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
                    dbConnect.ExecuteQueries("insert into orphan(orphan_Id,First_Name, Last_Name, Gender, DOB,date_of_admission,Health_deficiencies,Guardian_name,guardian_nic,guardian_address,Contact_no, How_inmate_boarded,photo) Values ('" + txt_id.Text + "','" + text_fname.Text + "','" + txt_lname.Text + "','" + gender + "','" + DOB.Text + "','" + DOA.Text + "','" + richdeficiencies.Text + "','" + txt_gname.Text + "','" + txt_nic.Text + "','" + rich_address.Text + "','" + txtguardiancontact.Text + "','" + richhowboarded.Text + "','" + @filename + "')");
                    MessageBox.Show("Added Sucessfully", "SAVED!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private string gender_selection()
        {
            string gender = null;
            if (radioButton1.Checked == true)
            {
                gender = radioButton1.Text;
            }
            if (radioButton2.Checked == true)
            {
                gender = radioButton2.Text;
            }
            return gender;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            {
                try
                {

                    dbConnect.OpenConnection();
                    dbConnect.ExecuteQueries("delete from orphan where orphan_Id='" + txt_id.Text + "'");
                    DialogResult result = MessageBox.Show("Are you sure you Delete this record ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        MessageBox.Show("DELETED Sucessfully", "MESSAGE!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
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
    }
}
