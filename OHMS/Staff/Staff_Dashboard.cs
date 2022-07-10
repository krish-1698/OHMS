using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OHMS.Staff
{
    public partial class Staff_Dashboard : Form
    {
        string username = "";
        int panelWidth;
        bool col;
        dbConnection dbo = new dbConnection();
        public Staff_Dashboard(string uname)
        {
            username = uname;
            InitializeComponent();
            panelWidth = pnl_left.Width;
            col = false;
            timer2.Start();
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
        }

        public Staff_Dashboard()
        {
            //username = uname;
            InitializeComponent();
            panelWidth = pnl_left.Width;
            col = false;
            timer2.Start();
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;


        }

        private void addcontrols(UserControl uc)
        {
            panelControls.Controls.Clear();
            panelControls.Controls.Clear();
            panelControls.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
            uc.BringToFront();

        }
        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            user_control.home_control home = new user_control.home_control();
            panelControls.Controls.Clear();
            panelControls.Controls.Add(home);
            home.Dock = DockStyle.Fill;
            home.BringToFront();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panel1.ClientRectangle, Color.FromArgb(53, 53, 255), ButtonBorderStyle.Solid);
        }

        private void Staff_Dashboard_Load(object sender, EventArgs e)
        {
            lbldate.Text = DateTime.Now.ToString("ddd,dd MMM yyyy");
            user_control.home_control home = new user_control.home_control();
            panelControls.Controls.Clear();
            panelControls.Controls.Add(home);
            home.Dock = DockStyle.Fill;
            home.BringToFront();
            button10.Text = username;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (col)
            {
                pnl_left.Width = pnl_left.Width + 10;
                if (pnl_left.Width >= panelWidth)
                {
                    timer1.Stop();
                    col = false;
                    this.Refresh();
                }
            }

            else
            {
                pnl_left.Width = pnl_left.Width - 10;
                if (pnl_left.Width <= 59)
                {
                    timer1.Stop();
                    col = true;
                    this.Refresh();
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;
            user_control.adoption_control adoption = new user_control.adoption_control();
            addcontrols(adoption);
        }

        private void button3_Click(object sender, EventArgs e)
        {

            SidePanel.Height = button3.Height;
            SidePanel.Top = button3.Top;
            user_control.orphan_control orphan = new user_control.orphan_control();
            addcontrols(orphan);
        }

        private void button7_Click(object sender, EventArgs e)
        {

            SidePanel.Height = button7.Height;
            SidePanel.Top = button7.Top;
            user_control.DailyActivities_control da = new user_control.DailyActivities_control();
            addcontrols(da);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button5.Height;
            SidePanel.Top = button5.Top;
            user_control.donation_control donation = new user_control.donation_control();
            addcontrols(donation);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button6.Height;
            SidePanel.Top = button6.Top;
            user_control.Expense_control exp = new user_control.Expense_control();
            addcontrols(exp);

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            lbltime.Text = dt.ToString("hh:mm:ss tt");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Log Out ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                login l1 = new login();
                l1.Show();
                this.Close();
            }
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            Form formbg = new Form();
            using (changePass p1 = new changePass(username))
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
