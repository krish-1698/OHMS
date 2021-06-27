
namespace OHMS
{
    partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.lname_txt = new System.Windows.Forms.TextBox();
            this.fname_txt = new System.Windows.Forms.TextBox();
            this.id_maskedtxt = new System.Windows.Forms.MaskedTextBox();
            this.dob_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.gender_box = new System.Windows.Forms.GroupBox();
            this.female_radio = new System.Windows.Forms.RadioButton();
            this.male_radio = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.email_txt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.phone_maskedtxt = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.district_combo = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.address_richTxt = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.emptype_combo = new System.Windows.Forms.ComboBox();
            this.emp_checkedList = new System.Windows.Forms.CheckedListBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.submit_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.gender_box.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.submit_btn);
            this.panel1.Controls.Add(this.emptype_combo);
            this.panel1.Controls.Add(this.emp_checkedList);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.email_txt);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.phone_maskedtxt);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.district_combo);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.address_richTxt);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.maskedTextBox1);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.lname_txt);
            this.panel1.Controls.Add(this.fname_txt);
            this.panel1.Controls.Add(this.id_maskedtxt);
            this.panel1.Controls.Add(this.dob_dateTimePicker);
            this.panel1.Controls.Add(this.gender_box);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(8, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(744, 464);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(517, 43);
            this.maskedTextBox1.Mask = "000000000aaa";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(124, 20);
            this.maskedTextBox1.TabIndex = 35;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(413, 39);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 20);
            this.label15.TabIndex = 42;
            this.label15.Text = "NIC NO";
            // 
            // lname_txt
            // 
            this.lname_txt.Location = new System.Drawing.Point(187, 121);
            this.lname_txt.MaxLength = 20;
            this.lname_txt.Name = "lname_txt";
            this.lname_txt.Size = new System.Drawing.Size(200, 20);
            this.lname_txt.TabIndex = 33;
            // 
            // fname_txt
            // 
            this.fname_txt.Location = new System.Drawing.Point(187, 82);
            this.fname_txt.MaxLength = 20;
            this.fname_txt.Name = "fname_txt";
            this.fname_txt.Size = new System.Drawing.Size(200, 20);
            this.fname_txt.TabIndex = 31;
            // 
            // id_maskedtxt
            // 
            this.id_maskedtxt.Location = new System.Drawing.Point(187, 41);
            this.id_maskedtxt.Mask = "SN/000";
            this.id_maskedtxt.Name = "id_maskedtxt";
            this.id_maskedtxt.Size = new System.Drawing.Size(76, 20);
            this.id_maskedtxt.TabIndex = 30;
            // 
            // dob_dateTimePicker
            // 
            this.dob_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dob_dateTimePicker.Location = new System.Drawing.Point(187, 166);
            this.dob_dateTimePicker.MaxDate = new System.DateTime(2021, 6, 7, 0, 0, 0, 0);
            this.dob_dateTimePicker.MinDate = new System.DateTime(1948, 1, 1, 0, 0, 0, 0);
            this.dob_dateTimePicker.Name = "dob_dateTimePicker";
            this.dob_dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dob_dateTimePicker.TabIndex = 39;
            this.dob_dateTimePicker.Value = new System.DateTime(2021, 6, 7, 0, 0, 0, 0);
            // 
            // gender_box
            // 
            this.gender_box.Controls.Add(this.female_radio);
            this.gender_box.Controls.Add(this.male_radio);
            this.gender_box.Location = new System.Drawing.Point(517, 69);
            this.gender_box.Name = "gender_box";
            this.gender_box.Size = new System.Drawing.Size(200, 36);
            this.gender_box.TabIndex = 36;
            this.gender_box.TabStop = false;
            // 
            // female_radio
            // 
            this.female_radio.AutoSize = true;
            this.female_radio.Location = new System.Drawing.Point(125, 13);
            this.female_radio.Name = "female_radio";
            this.female_radio.Size = new System.Drawing.Size(59, 17);
            this.female_radio.TabIndex = 4;
            this.female_radio.Text = "Female";
            this.female_radio.UseVisualStyleBackColor = true;
            // 
            // male_radio
            // 
            this.male_radio.AutoSize = true;
            this.male_radio.Checked = true;
            this.male_radio.Location = new System.Drawing.Point(22, 13);
            this.male_radio.Name = "male_radio";
            this.male_radio.Size = new System.Drawing.Size(48, 17);
            this.male_radio.TabIndex = 3;
            this.male_radio.TabStop = true;
            this.male_radio.Text = "Male";
            this.male_radio.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(32, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 20);
            this.label7.TabIndex = 41;
            this.label7.Text = "Date Of Birth";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(413, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 40;
            this.label6.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 38;
            this.label5.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 37;
            this.label4.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "ID";
            // 
            // email_txt
            // 
            this.email_txt.ForeColor = System.Drawing.Color.Gray;
            this.email_txt.Location = new System.Drawing.Point(515, 169);
            this.email_txt.Name = "email_txt";
            this.email_txt.Size = new System.Drawing.Size(213, 20);
            this.email_txt.TabIndex = 46;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(413, 167);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 20);
            this.label11.TabIndex = 50;
            this.label11.Text = "Email";
            // 
            // phone_maskedtxt
            // 
            this.phone_maskedtxt.Location = new System.Drawing.Point(187, 210);
            this.phone_maskedtxt.Mask = "0000000000";
            this.phone_maskedtxt.Name = "phone_maskedtxt";
            this.phone_maskedtxt.Size = new System.Drawing.Size(137, 20);
            this.phone_maskedtxt.TabIndex = 45;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(31, 210);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 20);
            this.label10.TabIndex = 49;
            this.label10.Text = "Phone Number";
            // 
            // district_combo
            // 
            this.district_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.district_combo.FormattingEnabled = true;
            this.district_combo.Items.AddRange(new object[] {
            "Colombo",
            "Jaffna",
            "Kandy",
            "Ratnapura"});
            this.district_combo.Location = new System.Drawing.Point(517, 125);
            this.district_combo.Name = "district_combo";
            this.district_combo.Size = new System.Drawing.Size(152, 21);
            this.district_combo.Sorted = true;
            this.district_combo.TabIndex = 44;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(413, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 20);
            this.label9.TabIndex = 48;
            this.label9.Text = "City";
            // 
            // address_richTxt
            // 
            this.address_richTxt.Location = new System.Drawing.Point(187, 248);
            this.address_richTxt.MaxLength = 50;
            this.address_richTxt.Name = "address_richTxt";
            this.address_richTxt.Size = new System.Drawing.Size(217, 45);
            this.address_richTxt.TabIndex = 43;
            this.address_richTxt.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(31, 246);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 20);
            this.label8.TabIndex = 47;
            this.label8.Text = "Address";
            // 
            // emptype_combo
            // 
            this.emptype_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.emptype_combo.FormattingEnabled = true;
            this.emptype_combo.Items.AddRange(new object[] {
            "Full Time",
            "Part Time",
            "Casual"});
            this.emptype_combo.Location = new System.Drawing.Point(576, 212);
            this.emptype_combo.Name = "emptype_combo";
            this.emptype_combo.Size = new System.Drawing.Size(152, 21);
            this.emptype_combo.TabIndex = 51;
            // 
            // emp_checkedList
            // 
            this.emp_checkedList.CheckOnClick = true;
            this.emp_checkedList.FormattingEnabled = true;
            this.emp_checkedList.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.emp_checkedList.Location = new System.Drawing.Point(568, 292);
            this.emp_checkedList.Name = "emp_checkedList";
            this.emp_checkedList.Size = new System.Drawing.Size(160, 109);
            this.emp_checkedList.TabIndex = 52;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(413, 259);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(224, 20);
            this.label13.TabIndex = 54;
            this.label13.Text = "Usual Days of Employment";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(412, 210);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(150, 20);
            this.label12.TabIndex = 53;
            this.label12.Text = "Employment Type";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(255, 408);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 32);
            this.button1.TabIndex = 55;
            this.button1.Text = "&Close";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // submit_btn
            // 
            this.submit_btn.BackColor = System.Drawing.Color.White;
            this.submit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit_btn.Location = new System.Drawing.Point(392, 408);
            this.submit_btn.Name = "submit_btn";
            this.submit_btn.Size = new System.Drawing.Size(100, 32);
            this.submit_btn.TabIndex = 56;
            this.submit_btn.Text = "&Save";
            this.submit_btn.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(760, 480);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gender_box.ResumeLayout(false);
            this.gender_box.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox emptype_combo;
        private System.Windows.Forms.CheckedListBox emp_checkedList;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox email_txt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox phone_maskedtxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox district_combo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox address_richTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox lname_txt;
        private System.Windows.Forms.TextBox fname_txt;
        private System.Windows.Forms.MaskedTextBox id_maskedtxt;
        private System.Windows.Forms.DateTimePicker dob_dateTimePicker;
        private System.Windows.Forms.GroupBox gender_box;
        private System.Windows.Forms.RadioButton female_radio;
        private System.Windows.Forms.RadioButton male_radio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button submit_btn;
    }
}