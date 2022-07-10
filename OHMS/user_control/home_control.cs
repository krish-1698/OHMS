using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using MySql.Data.MySqlClient;

namespace OHMS.user_control
{
    
    public partial class home_control : UserControl
    {
        dbConnection dbConnect = new dbConnection();
        private void countStaff()
        {
            dbConnect.OpenConnection();
            MySqlDataReader dr = dbConnect.DataReader("Select count(staff_id) as num from staff");
            while (dr.Read())
            {
                label4.Text = dr.GetString("num");
            }
            dbConnect.CloseConnection();
        }

        private void countOrphan()
        {
            dbConnect.OpenConnection();
            MySqlDataReader dr = dbConnect.DataReader("Select count(orphan_id) as num from orphan");
            while (dr.Read())
            {
                label5.Text = dr.GetString("num");
            }
            dbConnect.CloseConnection();
        }
        public home_control()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void home_control_Load(object sender, EventArgs e)
        {
            //  this.Controls.Add(this.chart1);
            countStaff();
            countOrphan();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
