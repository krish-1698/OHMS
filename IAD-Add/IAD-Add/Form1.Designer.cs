
namespace IAD_Add
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelAddSubmenu = new System.Windows.Forms.Panel();
            this.btnUpdateAdopter = new System.Windows.Forms.Button();
            this.btnAddAdopter = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panelAddSubmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.panel1.Controls.Add(this.panelAddSubmenu);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 631);
            this.panel1.TabIndex = 0;
            // 
            // panelAddSubmenu
            // 
            this.panelAddSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(115)))), ((int)(((byte)(232)))));
            this.panelAddSubmenu.Controls.Add(this.btnUpdateAdopter);
            this.panelAddSubmenu.Controls.Add(this.btnAddAdopter);
            this.panelAddSubmenu.Location = new System.Drawing.Point(0, 191);
            this.panelAddSubmenu.Name = "panelAddSubmenu";
            this.panelAddSubmenu.Size = new System.Drawing.Size(186, 93);
            this.panelAddSubmenu.TabIndex = 2;
            // 
            // btnUpdateAdopter
            // 
            this.btnUpdateAdopter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(115)))), ((int)(((byte)(232)))));
            this.btnUpdateAdopter.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUpdateAdopter.FlatAppearance.BorderSize = 0;
            this.btnUpdateAdopter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateAdopter.ForeColor = System.Drawing.Color.White;
            this.btnUpdateAdopter.Location = new System.Drawing.Point(0, 42);
            this.btnUpdateAdopter.Name = "btnUpdateAdopter";
            this.btnUpdateAdopter.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnUpdateAdopter.Size = new System.Drawing.Size(186, 40);
            this.btnUpdateAdopter.TabIndex = 1;
            this.btnUpdateAdopter.Text = "Update";
            this.btnUpdateAdopter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateAdopter.UseVisualStyleBackColor = false;
            this.btnUpdateAdopter.Click += new System.EventHandler(this.btnCDtls_Click);
            // 
            // btnAddAdopter
            // 
            this.btnAddAdopter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(115)))), ((int)(((byte)(232)))));
            this.btnAddAdopter.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddAdopter.FlatAppearance.BorderSize = 0;
            this.btnAddAdopter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAdopter.ForeColor = System.Drawing.Color.White;
            this.btnAddAdopter.Location = new System.Drawing.Point(0, 0);
            this.btnAddAdopter.Name = "btnAddAdopter";
            this.btnAddAdopter.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnAddAdopter.Size = new System.Drawing.Size(186, 42);
            this.btnAddAdopter.TabIndex = 0;
            this.btnAddAdopter.Text = "Add";
            this.btnAddAdopter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddAdopter.UseVisualStyleBackColor = false;
            this.btnAddAdopter.Click += new System.EventHandler(this.btnOrDtls_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(0, 130);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAdd.Size = new System.Drawing.Size(186, 61);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Adopter Details";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 124);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelChildForm
            // 
            this.panelChildForm.Location = new System.Drawing.Point(192, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(755, 631);
            this.panelChildForm.TabIndex = 1;
            this.panelChildForm.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(948, 631);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panelAddSubmenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelAddSubmenu;
        private System.Windows.Forms.Button btnUpdateAdopter;
        private System.Windows.Forms.Button btnAddAdopter;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelChildForm;
    }
}

