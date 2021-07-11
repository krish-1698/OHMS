using OrphanageSystemManagement.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrphanageSystemManagement.User_Controls
{
    public partial class addorphan_dashboard : UserControl
    {
        public addorphan_dashboard()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        internal void ShowDialog()
        {
            throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(Add_Orphan fa = new Add_Orphan())
            {
                fa.ShowDialog();
                this.OnLoad(e);
            }
        }
    }
}
