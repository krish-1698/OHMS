using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrphanageSystemManagement.Forms
{
    public partial class Add_Orphan : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-H8CICF1Q;Initial Catalog=orphan;Integrated Security=True;Pooling=False");
        public Add_Orphan()
        {
            InitializeComponent();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (isFormValid())
            {
                insertValues();
            }
        }

        private void insertValues()
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to add this work?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialogResult == DialogResult.OK)
            {
                
            }
        }

        private bool isFormValid()
        {
            if(richhowboarded.Text.Trim()==string.Empty|| radioButton1.Checked != true && radioButton2.Checked != true)
            {
                MessageBox.Show("Please fill all required fields");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
