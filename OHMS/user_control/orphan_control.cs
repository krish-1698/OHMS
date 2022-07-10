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
    public partial class orphan_control : UserControl
    {
        Auto_increment aid = new Auto_increment();
        dbConnection dbConnect = new dbConnection();
        string id;
        string button_check = "grid_click";
        string query = "select `Orphan_Id`, `First_name`, `last_name`, `Gender`, `DOB`,`Date_of_Admission`, `Health_Deficiencies`, `Guardian_name`, `Guardian_nic`,`contact_no`,`Guardian_Address`,`How_Inmate_Boarded`,`photo` from orphan ";
        public orphan_control()
        {
            InitializeComponent();
        }

       
        private void countOrphan()
        {
            dbConnect.OpenConnection();
            MySqlDataReader dr = dbConnect.DataReader("Select count(orphan_id) as num from orphan");
            while (dr.Read())
            {
                label2.Text = dr.GetString("num");
            }
            dbConnect.CloseConnection();
        }
        private void displayOrphanFOrm()
        {
            Form formbg = new Form();
            using (orphan or = new orphan(id,button_check))
            {
                formbg.FormBorderStyle = FormBorderStyle.None;
                formbg.Opacity = .50d;
                formbg.BackColor = Color.Black;
                formbg.Size = new Size(1386, 748);
                formbg.StartPosition = FormStartPosition.CenterScreen;
                formbg.Show();
                or.Owner = formbg;
                or.ShowDialog();
                formbg.Dispose();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            button_check = "btn_add";
            displayOrphanFOrm();
            dbConnect.ShowDataInGridView(dataGridView1, "select * from orphan");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void orphan_control_Load(object sender, EventArgs e)
        {
            dbConnect.OpenConnection();
            dbConnect.ShowDataInGridView(dataGridView1, query);
            countOrphan();
            dbConnect.CloseConnection();
        }

        private void button7_Click(object sender, EventArgs e)
        {
           // displayOrphanFOrm();
           // id= Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Orphan_Id"].Value);
            //orphan or = new orphan(id);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //displayOrphanFOrm();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Orphan_Id"].Value);
            button_check = "grid_click";
            displayOrphanFOrm();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           // orphan_control_Load(sender, e);
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            dbConnect.OpenConnection();
            string query = $"SELECT  `Orphan_Id`, `First_name`, `last_name`, `Gender`, `DOB`,`Date_of_Admission`, `Health_Deficiencies`, `Guardian_name`, `Guardian_nic`,`contact_no`,`Guardian_Address`,`How_Inmate_Boarded`  FROM `orphan` WHERE `orphan_id` LIKE \"%{txt_search.Text}%\" OR `first_name` LIKE \"%{txt_search.Text}%\" OR `last_name` LIKE \"%{txt_search.Text}%\"  OR `gender` LIKE \"%{txt_search.Text}%\" OR `DOB` LIKE \"%{txt_search.Text}%\" OR `Date_of_Admission` LIKE \"%{txt_search.Text}%\" OR `Health_Deficiencies` LIKE \"%{txt_search.Text}%\"  OR `Guardian_name` LIKE \"%{txt_search.Text}%\" OR `Guardian_nic` LIKE \"%{txt_search.Text}%\"  OR `contact_no` LIKE \"%{txt_search.Text}%\"  OR `guardian_address` LIKE \"%{txt_search.Text}%\"  OR `how_inmate_boarded` LIKE \"%{txt_search.Text}%\"";
            dbConnect.ShowDataInGridView(dataGridView1, query);
            dbConnect.CloseConnection();
        }
    }
}
