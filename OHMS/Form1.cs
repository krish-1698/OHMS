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
    public partial class Form1 : Form
    {

        int panelWidth;
        bool col;
        public Form1()
        {
            InitializeComponent();
            panelWidth = pnl_left.Width;
            col = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

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

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }

}