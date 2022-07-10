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
    public partial class DailyActivities_control : UserControl
    {
        public DailyActivities_control()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form formbg = new Form();
            using (orphan_dailyActivity p1 = new orphan_dailyActivity())
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

        private void button2_Click(object sender, EventArgs e)
        {

            Form formbg = new Form();
            using (visitorActivity_form p1 = new visitorActivity_form())
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
    }
}
