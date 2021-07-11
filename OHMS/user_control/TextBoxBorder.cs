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
    public partial class TextBoxBorder : TextBox
    {
        public TextBoxBorder()
        {
                BorderStyle = BorderStyle.None;
                AutoSize = false; //Allows you to change height to have bottom padding
                Controls.Add(new Label()
                { Height = 1,Width=250, Dock = DockStyle.Bottom, BackColor = Color.Black });
            
            InitializeComponent();
        }

        private void TextBoxBorder_Load(object sender, EventArgs e)
        {

        }
    }
}
