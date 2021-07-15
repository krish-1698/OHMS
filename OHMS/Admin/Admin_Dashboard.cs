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
    public partial class Admin_Dashboard : Form
    {

        int panelWidth;
        bool col;
        dbConnection dbo = new dbConnection();
        public Admin_Dashboard()
        {
            InitializeComponent();
            panelWidth = pnl_left.Width;
            col = false;
            timer2.Start();
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panel1.ClientRectangle, Color.FromArgb(53, 53, 255), ButtonBorderStyle.Solid);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button4.Height;
            SidePanel.Top = button4.Top;
            user_control.report_control report = new user_control.report_control();
            addcontrols(report);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbldate.Text = DateTime.Now.ToString("ddd,dd MMM yyyy");
            user_control.home_control home = new user_control.home_control();
            panelControls.Controls.Clear();
            panelControls.Controls.Add(home);
            home.Dock = DockStyle.Fill;
            home.BringToFront();

        }


        private void addcontrols(UserControl uc)
        {

            panelControls.Controls.Clear();
            panelControls.Controls.Add(uc);
            uc.Dock=DockStyle.Fill;
            uc.BringToFront();

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

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            //(sender as Button).BackColor = Color.FromArgb(100, 151, 178);
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            user_control.home_control home = new user_control.home_control();
            panelControls.Controls.Clear();
            panelControls.Controls.Add(home);
            home.Dock = DockStyle.Fill;
            home.BringToFront();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button6.Height;
            SidePanel.Top = button6.Top;
            user_control.Expense_control exp = new user_control.Expense_control();
            addcontrols(exp);
           
         }

        private void button2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;
            user_control.staff_control staff = new user_control.staff_control();
            addcontrols(staff);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button5.Height;
            SidePanel.Top = button5.Top;
            user_control.donation_control donation = new user_control.donation_control();
            addcontrols(donation);
        }

        private void panelControls_Paint(object sender, PaintEventArgs e)
        {
            user_control.home_control home = new user_control.home_control();
            panelControls.Controls.Clear();
            panelControls.Controls.Add(home);
            home.Dock = DockStyle.Fill;
            home.BringToFront();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            lbltime.Text = dt.ToString("hh:mm:ss tt");
        }

        private void lbldate_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            //dbo.ExecuteQueries("insert into expense(expense_id,amount,date_paid,purpose)Values('" + textBox1.Text + "','" + textBoxBorder3.Text + "','" + dateTimePicker1.Text + "','" + textBoxBorder1.Text + "') ");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //dateTimePicker1.CustomFormat = "dd-MMM-yyyy";
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

       

        private void panel1_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void SidePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button7.Height;
            SidePanel.Top = button7.Top;
            user_control.staffAttendance_control attendance = new user_control.staffAttendance_control();
            addcontrols(attendance);
        }
    

        private void button3_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button3.Height;
            SidePanel.Top = button3.Top;
            user_control.orphan_control orphan = new user_control.orphan_control();
            addcontrols(orphan);
        }

        private void button9_Click(object sender, EventArgs e)
        {
           DialogResult result= MessageBox.Show("Are you sure you want to Log Out ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                login l1 = new login();
                l1.Show();
                this.Close();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }
    }

}