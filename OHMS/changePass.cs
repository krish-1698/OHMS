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
    public partial class changePass : Form
    {
        dbConnection dbConnect = new dbConnection();
        string username;
        public changePass(String uname)
        {
            InitializeComponent();
            username= uname;
        }

        private void textBoxBorder2_TextChanged(object sender, EventArgs e)
        {

        }

        private void changePass_Load(object sender, EventArgs e)
        {
            /*   MySqlConnection con = new MySqlConnection("datasource=localhost; username=root; password=; database=OHMS");
               MySqlCommand cmd;
               con.Open();
               cmd = new MySqlCommand("Select * from ", con);
               cmd.ExecuteNonQuery();*/
            dbConnect.OpenConnection();
            MySqlDataReader reader =dbConnect.DataReader("Select staff.first_name,staff.last_name,user.* from staff inner join user on staff.staff_id=user.staff_id where username='"+username+"'");
            while (reader.Read())
            {
                textBoxBorder2.Text = reader.GetString("first_name")+ " "+ reader.GetString("last_name");
                textBoxBorder1.Text = reader.GetString("role");
            }
            dbConnect.CloseConnection();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form formbg = new Form();
            using (staff_attendance p1 = new staff_attendance(username))
            {
                formbg.FormBorderStyle = FormBorderStyle.None;
                formbg.Opacity = .50d;
                formbg.BackColor = Color.Black;
                formbg.Size = new Size(1386, 748);
                formbg.StartPosition = FormStartPosition.CenterScreen;
                //formbg.WindowState = FormWindowState.Normal;
                //formbg.TopMost = true;
                //formbg.Location = this.Location;
                // formbg.ShowInTaskbar = false;
                formbg.Show();
                p1.Owner = formbg;
                p1.ShowDialog();
                formbg.Dispose();
                // this.Hide();
                // f1.ShowDialog();

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
