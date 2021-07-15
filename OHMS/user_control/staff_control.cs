using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OHMS.user_control
{
    public partial class staff_control : UserControl
    {
        public staff_control()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            using (staff f1 = new staff())
            {
                f1.ShowDialog();

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            using (staff f1 = new staff())
            {
                f1.ShowDialog();

            }
        }
    }
}
