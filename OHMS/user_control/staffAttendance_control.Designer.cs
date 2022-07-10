
namespace OHMS.user_control
{
    partial class staffAttendance_control
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(staffAttendance_control));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_staff_id = new System.Windows.Forms.ComboBox();
            this.txt_staffAttend = new OHMS.user_control.TextBoxBorder();
            this.cal_date = new System.Windows.Forms.MonthCalendar();
            this.txt_name = new OHMS.user_control.TextBoxBorder();
            this.dtp_outTime = new System.Windows.Forms.DateTimePicker();
            this.dtp_inTime = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxBorder2 = new OHMS.user_control.TextBoxBorder();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.staff_attendance_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staff_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.in_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.out_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.txt_staff_id);
            this.panel1.Controls.Add(this.txt_staffAttend);
            this.panel1.Controls.Add(this.cal_date);
            this.panel1.Controls.Add(this.txt_name);
            this.panel1.Controls.Add(this.dtp_outTime);
            this.panel1.Controls.Add(this.dtp_inTime);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lbl_Name);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBoxBorder2);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(8, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1167, 720);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txt_staff_id
            // 
            this.txt_staff_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_staff_id.FormattingEnabled = true;
            this.txt_staff_id.Location = new System.Drawing.Point(190, 110);
            this.txt_staff_id.Name = "txt_staff_id";
            this.txt_staff_id.Size = new System.Drawing.Size(121, 23);
            this.txt_staff_id.TabIndex = 32;
            this.txt_staff_id.SelectedIndexChanged += new System.EventHandler(this.txt_staff_id_SelectedIndexChanged);
            // 
            // txt_staffAttend
            // 
            this.txt_staffAttend.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_staffAttend.Location = new System.Drawing.Point(267, 3);
            this.txt_staffAttend.Name = "txt_staffAttend";
            this.txt_staffAttend.Size = new System.Drawing.Size(128, 20);
            this.txt_staffAttend.TabIndex = 30;
            // 
            // cal_date
            // 
            this.cal_date.Location = new System.Drawing.Point(187, 210);
            this.cal_date.MaxSelectionCount = 1;
            this.cal_date.Name = "cal_date";
            this.cal_date.TabIndex = 29;
            // 
            // txt_name
            // 
            this.txt_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_name.Location = new System.Drawing.Point(188, 159);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(263, 20);
            this.txt_name.TabIndex = 28;
            this.txt_name.TextChanged += new System.EventHandler(this.txt_name_TextChanged);
            // 
            // dtp_outTime
            // 
            this.dtp_outTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_outTime.Location = new System.Drawing.Point(190, 458);
            this.dtp_outTime.Name = "dtp_outTime";
            this.dtp_outTime.Size = new System.Drawing.Size(164, 22);
            this.dtp_outTime.TabIndex = 26;
            // 
            // dtp_inTime
            // 
            this.dtp_inTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_inTime.Location = new System.Drawing.Point(190, 407);
            this.dtp_inTime.Name = "dtp_inTime";
            this.dtp_inTime.Size = new System.Drawing.Size(164, 22);
            this.dtp_inTime.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(89, 464);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "Out Time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 413);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "In Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(100, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Date";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(100, 166);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(49, 16);
            this.lbl_Name.TabIndex = 24;
            this.lbl_Name.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(100, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 25;
            this.label5.Text = "Staff ID";
            // 
            // textBoxBorder2
            // 
            this.textBoxBorder2.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxBorder2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBorder2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBorder2.Location = new System.Drawing.Point(103, 49);
            this.textBoxBorder2.Name = "textBoxBorder2";
            this.textBoxBorder2.ReadOnly = true;
            this.textBoxBorder2.Size = new System.Drawing.Size(195, 29);
            this.textBoxBorder2.TabIndex = 16;
            this.textBoxBorder2.Text = "ATTENDANCE DETAILS";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(1044, 526);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 34);
            this.button2.TabIndex = 15;
            this.button2.Text = "View All";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.Image")));
            this.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add.Location = new System.Drawing.Point(199, 526);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(155, 34);
            this.btn_add.TabIndex = 14;
            this.btn_add.Text = "  Add Attendance";
            this.btn_add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(903, 56);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(199, 22);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(151)))), ((int)(((byte)(178)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.staff_attendance_id,
            this.staff_id,
            this.fullname,
            this.Date,
            this.in_time,
            this.out_time});
            this.dataGridView1.Location = new System.Drawing.Point(494, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(649, 408);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // staff_attendance_id
            // 
            this.staff_attendance_id.DataPropertyName = "staff_attendance_id";
            this.staff_attendance_id.HeaderText = "Attendance ID";
            this.staff_attendance_id.Name = "staff_attendance_id";
            this.staff_attendance_id.ReadOnly = true;
            this.staff_attendance_id.Visible = false;
            // 
            // staff_id
            // 
            this.staff_id.DataPropertyName = "staff_id";
            this.staff_id.HeaderText = "Staff ID";
            this.staff_id.Name = "staff_id";
            this.staff_id.ReadOnly = true;
            // 
            // fullname
            // 
            this.fullname.DataPropertyName = "first_name";
            this.fullname.HeaderText = "Name";
            this.fullname.Name = "fullname";
            this.fullname.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "date";
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // in_time
            // 
            this.in_time.DataPropertyName = "in_time";
            this.in_time.HeaderText = "In Time";
            this.in_time.Name = "in_time";
            this.in_time.ReadOnly = true;
            // 
            // out_time
            // 
            this.out_time.DataPropertyName = "Out_time";
            this.out_time.HeaderText = "Out Time";
            this.out_time.Name = "out_time";
            this.out_time.ReadOnly = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Today",
            "Yesterday"});
            this.comboBox1.Location = new System.Drawing.Point(494, 60);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(146, 23);
            this.comboBox1.TabIndex = 32;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1108, 49);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 33;
            this.pictureBox2.TabStop = false;
            // 
            // staffAttendance_control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Name = "staffAttendance_control";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.Size = new System.Drawing.Size(1183, 736);
            this.Load += new System.EventHandler(this.staffAttendance_control_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button button2;
        private TextBoxBorder textBoxBorder2;
        private System.Windows.Forms.MonthCalendar cal_date;
        private TextBoxBorder txt_name;
        private System.Windows.Forms.DateTimePicker dtp_outTime;
        private System.Windows.Forms.DateTimePicker dtp_inTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label label5;
        private TextBoxBorder txt_staffAttend;
        private System.Windows.Forms.DataGridViewTextBoxColumn staff_attendance_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn staff_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn in_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn out_time;
        private System.Windows.Forms.ComboBox txt_staff_id;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
