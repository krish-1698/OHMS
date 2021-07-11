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
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panel1.ClientRectangle, Color.FromArgb(53, 53, 255), ButtonBorderStyle.Solid);
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbldate.Text = DateTime.Now.ToString("ddd,dd MMM yyyy");
        }


        private void addcontrols(UserControl uc)
        {

            panelControls.Controls.Clear();
            uc.Dock=DockStyle.Fill;
            panelControls.Controls.Add(uc);
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
            (sender as Button).BackColor = Color.FromArgb(3, 92, 150);
            user_control.donation_control dc = new user_control.donation_control();
            addcontrols(dc);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            user_control.donation_control donor = new user_control.donation_control();
            addcontrols(donor);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            user_control.staff_control staff = new user_control.staff_control();
            addcontrols(staff);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            user_control.Expense_control ex = new user_control.Expense_control();
            addcontrols(ex);
        }

        private void panelControls_Paint(object sender, PaintEventArgs e)
        {

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

        private void panelControls_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }

}