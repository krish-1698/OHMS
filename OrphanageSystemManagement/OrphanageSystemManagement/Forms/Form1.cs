using OrphanageSystemManagement.User_Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrphanageSystemManagement
{
    public partial class panelControl1 : Form
    {
        public panelControl1()
        {
            InitializeComponent();
        }
        private void addControls(UserControl uc)
        {

           content1.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            content1.Controls.Add(uc);
            uc.BringToFront();
        }

        private void panelControl1_Load(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            addorphan_dashboard uw = new addorphan_dashboard();
            addControls(uw);
        }
    }
}
