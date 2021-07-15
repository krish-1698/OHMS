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
    public partial class donation_form : Form
    {
        public donation_form()
        {
            InitializeComponent();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
                    }

        private void textBoxBorder1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxBorder1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxBorder1_MouseHover(object sender, EventArgs e)
        {
            textBoxBorder1.Text= sender.GetType().ToString() + ": MouseHover";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            
            panel5.Visible = true;
            panel3.Visible = false;
            panel2.Visible = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel5.Visible = false;
            panel3.Visible = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            panel3.Visible = true;
            panel2.Visible = false;
            panel5.Visible = false;
        }
    }
}
