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
    public partial class report_control : UserControl
    {
        public report_control()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form formbg = new Form();
            using (income_report f1 = new income_report())
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
                f1.Owner = formbg;
                f1.ShowDialog();
                formbg.Dispose();
               //f1.ShowDialog();

            }
        }
    }
}
