
namespace OHMS
{
    partial class donation_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(donation_form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel_cheque = new System.Windows.Forms.Panel();
            this.richTxt_bankdetail = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel_cash = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel_product = new System.Windows.Forms.Panel();
            this.numeric_qty = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radio_product = new System.Windows.Forms.RadioButton();
            this.radio_cheque = new System.Windows.Forms.RadioButton();
            this.radio_cash = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ud_panel = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.sc_panel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_email = new OHMS.user_control.TextBoxBorder();
            this.txt_contact = new OHMS.user_control.TextBoxBorder();
            this.txt_product = new OHMS.user_control.TextBoxBorder();
            this.txt_cash_amount = new OHMS.user_control.TextBoxBorder();
            this.txt_cheque_no = new OHMS.user_control.TextBoxBorder();
            this.txt_amount = new OHMS.user_control.TextBoxBorder();
            this.txt_nic = new OHMS.user_control.TextBoxBorder();
            this.txt_lname = new OHMS.user_control.TextBoxBorder();
            this.txt_fname = new OHMS.user_control.TextBoxBorder();
            this.txt_donation_Id = new OHMS.user_control.TextBoxBorder();
            this.txt_donor_Id = new OHMS.user_control.TextBoxBorder();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel_cheque.SuspendLayout();
            this.panel_cash.SuspendLayout();
            this.panel_product.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_qty)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.ud_panel.SuspendLayout();
            this.sc_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.ud_panel);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.sc_panel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(8, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 453);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txt_email);
            this.panel4.Controls.Add(this.txt_contact);
            this.panel4.Controls.Add(this.panel_product);
            this.panel4.Controls.Add(this.panel_cash);
            this.panel4.Controls.Add(this.panel_cheque);
            this.panel4.Controls.Add(this.txt_nic);
            this.panel4.Controls.Add(this.txt_lname);
            this.panel4.Controls.Add(this.txt_fname);
            this.panel4.Controls.Add(this.txt_donation_Id);
            this.panel4.Controls.Add(this.txt_donor_Id);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.groupBox2);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.dtp_date);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Location = new System.Drawing.Point(78, 37);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(675, 328);
            this.panel4.TabIndex = 28;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // panel_cheque
            // 
            this.panel_cheque.Controls.Add(this.richTxt_bankdetail);
            this.panel_cheque.Controls.Add(this.txt_cheque_no);
            this.panel_cheque.Controls.Add(this.txt_amount);
            this.panel_cheque.Controls.Add(this.label9);
            this.panel_cheque.Controls.Add(this.label8);
            this.panel_cheque.Controls.Add(this.label7);
            this.panel_cheque.Location = new System.Drawing.Point(70, 174);
            this.panel_cheque.Name = "panel_cheque";
            this.panel_cheque.Size = new System.Drawing.Size(247, 137);
            this.panel_cheque.TabIndex = 21;
            // 
            // richTxt_bankdetail
            // 
            this.richTxt_bankdetail.Location = new System.Drawing.Point(118, 80);
            this.richTxt_bankdetail.Name = "richTxt_bankdetail";
            this.richTxt_bankdetail.Size = new System.Drawing.Size(117, 44);
            this.richTxt_bankdetail.TabIndex = 2;
            this.richTxt_bankdetail.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Bank Details";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Cheque No";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Amount";
            // 
            // panel_cash
            // 
            this.panel_cash.Controls.Add(this.label17);
            this.panel_cash.Controls.Add(this.txt_cash_amount);
            this.panel_cash.Location = new System.Drawing.Point(69, 174);
            this.panel_cash.Name = "panel_cash";
            this.panel_cash.Size = new System.Drawing.Size(248, 137);
            this.panel_cash.TabIndex = 21;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(16, 18);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(59, 16);
            this.label17.TabIndex = 0;
            this.label17.Text = "Amount";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(18, 21);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 16);
            this.label14.TabIndex = 8;
            this.label14.Text = "Donation ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(364, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Donor ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(364, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "First Name";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(24, 72);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 16);
            this.label12.TabIndex = 13;
            this.label12.Text = "Date";
            // 
            // panel_product
            // 
            this.panel_product.Controls.Add(this.numeric_qty);
            this.panel_product.Controls.Add(this.label11);
            this.panel_product.Controls.Add(this.label10);
            this.panel_product.Controls.Add(this.txt_product);
            this.panel_product.Location = new System.Drawing.Point(67, 174);
            this.panel_product.Name = "panel_product";
            this.panel_product.Size = new System.Drawing.Size(247, 140);
            this.panel_product.TabIndex = 22;
            // 
            // numeric_qty
            // 
            this.numeric_qty.Location = new System.Drawing.Point(109, 47);
            this.numeric_qty.Name = "numeric_qty";
            this.numeric_qty.Size = new System.Drawing.Size(43, 20);
            this.numeric_qty.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(27, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "Quantity";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(27, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Type";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radio_product);
            this.groupBox2.Controls.Add(this.radio_cheque);
            this.groupBox2.Controls.Add(this.radio_cash);
            this.groupBox2.Location = new System.Drawing.Point(67, 116);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(274, 33);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            // 
            // radio_product
            // 
            this.radio_product.AutoSize = true;
            this.radio_product.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_product.Location = new System.Drawing.Point(176, 10);
            this.radio_product.Name = "radio_product";
            this.radio_product.Size = new System.Drawing.Size(74, 19);
            this.radio_product.TabIndex = 1;
            this.radio_product.Text = "Product";
            this.radio_product.UseVisualStyleBackColor = true;
            this.radio_product.CheckedChanged += new System.EventHandler(this.radio_product_CheckedChanged);
            // 
            // radio_cheque
            // 
            this.radio_cheque.AutoSize = true;
            this.radio_cheque.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_cheque.Location = new System.Drawing.Point(86, 8);
            this.radio_cheque.Name = "radio_cheque";
            this.radio_cheque.Size = new System.Drawing.Size(74, 19);
            this.radio_cheque.TabIndex = 1;
            this.radio_cheque.Text = "Cheque";
            this.radio_cheque.UseVisualStyleBackColor = true;
            this.radio_cheque.CheckedChanged += new System.EventHandler(this.radio_cheque_CheckedChanged);
            // 
            // radio_cash
            // 
            this.radio_cash.AutoSize = true;
            this.radio_cash.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_cash.Location = new System.Drawing.Point(12, 8);
            this.radio_cash.Name = "radio_cash";
            this.radio_cash.Size = new System.Drawing.Size(57, 19);
            this.radio_cash.TabIndex = 0;
            this.radio_cash.Text = "Cash";
            this.radio_cash.UseVisualStyleBackColor = true;
            this.radio_cash.CheckedChanged += new System.EventHandler(this.radio_cash_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(369, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Contact No";
            // 
            // dtp_date
            // 
            this.dtp_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_date.Location = new System.Drawing.Point(136, 72);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(155, 20);
            this.dtp_date.TabIndex = 3;
            this.dtp_date.Value = new System.DateTime(2021, 6, 23, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(369, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(365, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Last Name";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(369, 164);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 16);
            this.label13.TabIndex = 14;
            this.label13.Text = "NIC No";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button3.Location = new System.Drawing.Point(33, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "S&ave";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button2.Location = new System.Drawing.Point(168, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ud_panel
            // 
            this.ud_panel.Controls.Add(this.button6);
            this.ud_panel.Controls.Add(this.button1);
            this.ud_panel.Controls.Add(this.button7);
            this.ud_panel.Location = new System.Drawing.Point(231, 386);
            this.ud_panel.Name = "ud_panel";
            this.ud_panel.Size = new System.Drawing.Size(412, 47);
            this.ud_panel.TabIndex = 61;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(174, 8);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(106, 34);
            this.button6.TabIndex = 61;
            this.button6.Text = "Delete";
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(46, 8);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(106, 34);
            this.button7.TabIndex = 60;
            this.button7.Text = "Update";
            this.button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // sc_panel
            // 
            this.sc_panel.Controls.Add(this.button3);
            this.sc_panel.Controls.Add(this.button2);
            this.sc_panel.Location = new System.Drawing.Point(481, 371);
            this.sc_panel.Name = "sc_panel";
            this.sc_panel.Size = new System.Drawing.Size(251, 34);
            this.sc_panel.TabIndex = 60;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button1.Location = new System.Drawing.Point(319, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 34);
            this.button1.TabIndex = 7;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_email
            // 
            this.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_email.Location = new System.Drawing.Point(485, 247);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(135, 20);
            this.txt_email.TabIndex = 25;
            // 
            // txt_contact
            // 
            this.txt_contact.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_contact.Location = new System.Drawing.Point(483, 204);
            this.txt_contact.Name = "txt_contact";
            this.txt_contact.Size = new System.Drawing.Size(135, 20);
            this.txt_contact.TabIndex = 25;
            // 
            // txt_product
            // 
            this.txt_product.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_product.Location = new System.Drawing.Point(106, 13);
            this.txt_product.Name = "txt_product";
            this.txt_product.Size = new System.Drawing.Size(120, 20);
            this.txt_product.TabIndex = 25;
            this.txt_product.TextChanged += new System.EventHandler(this.textBoxBorder1_TextChanged_1);
            // 
            // txt_cash_amount
            // 
            this.txt_cash_amount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_cash_amount.Location = new System.Drawing.Point(95, 18);
            this.txt_cash_amount.Name = "txt_cash_amount";
            this.txt_cash_amount.Size = new System.Drawing.Size(120, 20);
            this.txt_cash_amount.TabIndex = 25;
            this.txt_cash_amount.TextChanged += new System.EventHandler(this.textBoxBorder1_TextChanged_1);
            // 
            // txt_cheque_no
            // 
            this.txt_cheque_no.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_cheque_no.Location = new System.Drawing.Point(115, 43);
            this.txt_cheque_no.Name = "txt_cheque_no";
            this.txt_cheque_no.Size = new System.Drawing.Size(120, 20);
            this.txt_cheque_no.TabIndex = 25;
            this.txt_cheque_no.TextChanged += new System.EventHandler(this.textBoxBorder1_TextChanged_1);
            // 
            // txt_amount
            // 
            this.txt_amount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_amount.Location = new System.Drawing.Point(115, 14);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(120, 20);
            this.txt_amount.TabIndex = 25;
            this.txt_amount.TextChanged += new System.EventHandler(this.textBoxBorder1_TextChanged_1);
            // 
            // txt_nic
            // 
            this.txt_nic.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nic.Location = new System.Drawing.Point(483, 157);
            this.txt_nic.Name = "txt_nic";
            this.txt_nic.Size = new System.Drawing.Size(135, 20);
            this.txt_nic.TabIndex = 25;
            // 
            // txt_lname
            // 
            this.txt_lname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_lname.Location = new System.Drawing.Point(485, 110);
            this.txt_lname.Name = "txt_lname";
            this.txt_lname.Size = new System.Drawing.Size(135, 20);
            this.txt_lname.TabIndex = 25;
            // 
            // txt_fname
            // 
            this.txt_fname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_fname.Location = new System.Drawing.Point(483, 63);
            this.txt_fname.Name = "txt_fname";
            this.txt_fname.Size = new System.Drawing.Size(135, 20);
            this.txt_fname.TabIndex = 4;
            // 
            // txt_donation_Id
            // 
            this.txt_donation_Id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_donation_Id.Location = new System.Drawing.Point(136, 23);
            this.txt_donation_Id.Name = "txt_donation_Id";
            this.txt_donation_Id.Size = new System.Drawing.Size(156, 20);
            this.txt_donation_Id.TabIndex = 1;
            this.txt_donation_Id.TextChanged += new System.EventHandler(this.textBoxBorder1_TextChanged_1);
            // 
            // txt_donor_Id
            // 
            this.txt_donor_Id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_donor_Id.Location = new System.Drawing.Point(485, 20);
            this.txt_donor_Id.Name = "txt_donor_Id";
            this.txt_donor_Id.Size = new System.Drawing.Size(135, 20);
            this.txt_donor_Id.TabIndex = 2;
            this.txt_donor_Id.TextChanged += new System.EventHandler(this.textBoxBorder1_TextChanged_1);
            this.txt_donor_Id.MouseHover += new System.EventHandler(this.textBoxBorder1_MouseHover);
            // 
            // donation_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(821, 469);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "donation_form";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "donation_form";
            this.Load += new System.EventHandler(this.donation_form_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel_cheque.ResumeLayout(false);
            this.panel_cheque.PerformLayout();
            this.panel_cash.ResumeLayout(false);
            this.panel_cash.PerformLayout();
            this.panel_product.ResumeLayout(false);
            this.panel_product.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_qty)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ud_panel.ResumeLayout(false);
            this.sc_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel_cheque;
        private System.Windows.Forms.RichTextBox richTxt_bankdetail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel_cash;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel_product;
        private System.Windows.Forms.NumericUpDown numeric_qty;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radio_product;
        private System.Windows.Forms.RadioButton radio_cheque;
        private System.Windows.Forms.RadioButton radio_cash;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtp_date;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private user_control.TextBoxBorder txt_email;
        private user_control.TextBoxBorder txt_contact;
        private user_control.TextBoxBorder txt_nic;
        private user_control.TextBoxBorder txt_lname;
        private user_control.TextBoxBorder txt_fname;
        private user_control.TextBoxBorder txt_donor_Id;
        private user_control.TextBoxBorder txt_donation_Id;
        private user_control.TextBoxBorder txt_cash_amount;
        private user_control.TextBoxBorder txt_product;
        private user_control.TextBoxBorder txt_amount;
        private user_control.TextBoxBorder txt_cheque_no;
        private System.Windows.Forms.Panel ud_panel;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel sc_panel;
    }
}