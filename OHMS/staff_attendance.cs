using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OHMS
{
    public partial class staff_attendance : Form
    {
        dbConnection dbConnect = new dbConnection();
        string uname;
        public staff_attendance(String username)
        {
            InitializeComponent();
            uname = username;
        }

        private void txt_current_TextChanged(object sender, EventArgs e)
        {
            dbConnect.OpenConnection();
            dbConnect.ExecuteQueries("Select * from user where password=md5('" + txt_current.Text+"')");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
