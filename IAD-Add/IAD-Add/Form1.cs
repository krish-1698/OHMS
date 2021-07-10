using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IAD_Add
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void customizeDesign()
        {
            panelAddSubmenu.Visible = false;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void hideSubMenu()
        {
            if (panelAddSubmenu.Visible == true)
                panelAddSubmenu.Visible = false;
        }

        public void showSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubMenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            showSubmenu(panelAddSubmenu);
            openChildForm(new Form3());
        }

        private Form activeForm = null; 
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddNext_Click(object sender, EventArgs e)
        {
            openChildForm(new Form2());
        }

        private void btnOrDtls_Click(object sender, EventArgs e)
        {
            openChildForm(new Form3());
        }

        private void btnCDtls_Click(object sender, EventArgs e)
        {
            openChildForm(new Form2());
        }
    }
}
