
namespace OHMS.user_control
{
    partial class UserControlAddStaff
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
            this.labelEmployeeName = new System.Windows.Forms.Label();
            this.textBoxEmployeeName = new System.Windows.Forms.TextBox();
            this.TextBoxEmployeeID = new System.Windows.Forms.MaskedTextBox();
            this.labelEmployeeID = new System.Windows.Forms.Label();
            this.labelPrefferedName = new System.Windows.Forms.Label();
            this.labelNIC = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelContact = new System.Windows.Forms.Label();
            this.labelDOB = new System.Windows.Forms.Label();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.textBoxPrefferedName = new System.Windows.Forms.TextBox();
            this.TextBoxContact = new System.Windows.Forms.MaskedTextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.checkBoxMartialStatus = new System.Windows.Forms.CheckBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dateTimePickerDOB = new System.Windows.Forms.DateTimePicker();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelEmployeeName
            // 
            this.labelEmployeeName.AutoSize = true;
            this.labelEmployeeName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmployeeName.ForeColor = System.Drawing.Color.White;
            this.labelEmployeeName.Location = new System.Drawing.Point(419, 94);
            this.labelEmployeeName.Name = "labelEmployeeName";
            this.labelEmployeeName.Size = new System.Drawing.Size(129, 20);
            this.labelEmployeeName.TabIndex = 3;
            this.labelEmployeeName.Text = "Employee Name";
            // 
            // textBoxEmployeeName
            // 
            this.textBoxEmployeeName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmployeeName.Location = new System.Drawing.Point(650, 94);
            this.textBoxEmployeeName.MaxLength = 200;
            this.textBoxEmployeeName.Multiline = true;
            this.textBoxEmployeeName.Name = "textBoxEmployeeName";
            this.textBoxEmployeeName.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBoxEmployeeName.Size = new System.Drawing.Size(276, 45);
            this.textBoxEmployeeName.TabIndex = 4;
            // 
            // TextBoxEmployeeID
            // 
            this.TextBoxEmployeeID.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxEmployeeID.Location = new System.Drawing.Point(650, 54);
            this.TextBoxEmployeeID.Mask = "ID00000";
            this.TextBoxEmployeeID.Name = "TextBoxEmployeeID";
            this.TextBoxEmployeeID.Size = new System.Drawing.Size(100, 26);
            this.TextBoxEmployeeID.TabIndex = 2;
            // 
            // labelEmployeeID
            // 
            this.labelEmployeeID.AutoSize = true;
            this.labelEmployeeID.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmployeeID.ForeColor = System.Drawing.Color.White;
            this.labelEmployeeID.Location = new System.Drawing.Point(419, 55);
            this.labelEmployeeID.Name = "labelEmployeeID";
            this.labelEmployeeID.Size = new System.Drawing.Size(101, 20);
            this.labelEmployeeID.TabIndex = 1;
            this.labelEmployeeID.Text = "Employee ID";
            // 
            // labelPrefferedName
            // 
            this.labelPrefferedName.AutoSize = true;
            this.labelPrefferedName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrefferedName.ForeColor = System.Drawing.Color.White;
            this.labelPrefferedName.Location = new System.Drawing.Point(419, 201);
            this.labelPrefferedName.Name = "labelPrefferedName";
            this.labelPrefferedName.Size = new System.Drawing.Size(126, 20);
            this.labelPrefferedName.TabIndex = 7;
            this.labelPrefferedName.Text = "Preffered Name";
            // 
            // labelNIC
            // 
            this.labelNIC.AutoSize = true;
            this.labelNIC.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNIC.ForeColor = System.Drawing.Color.White;
            this.labelNIC.Location = new System.Drawing.Point(419, 159);
            this.labelNIC.Name = "labelNIC";
            this.labelNIC.Size = new System.Drawing.Size(99, 20);
            this.labelNIC.TabIndex = 5;
            this.labelNIC.Text = "NIC Number";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress.ForeColor = System.Drawing.Color.White;
            this.labelAddress.Location = new System.Drawing.Point(422, 242);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(67, 20);
            this.labelAddress.TabIndex = 9;
            this.labelAddress.Text = "Address";
            // 
            // labelContact
            // 
            this.labelContact.AutoSize = true;
            this.labelContact.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContact.ForeColor = System.Drawing.Color.White;
            this.labelContact.Location = new System.Drawing.Point(423, 287);
            this.labelContact.Name = "labelContact";
            this.labelContact.Size = new System.Drawing.Size(70, 20);
            this.labelContact.TabIndex = 11;
            this.labelContact.Text = "Contact";
            // 
            // labelDOB
            // 
            this.labelDOB.AutoSize = true;
            this.labelDOB.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDOB.ForeColor = System.Drawing.Color.White;
            this.labelDOB.Location = new System.Drawing.Point(423, 336);
            this.labelDOB.Name = "labelDOB";
            this.labelDOB.Size = new System.Drawing.Size(99, 20);
            this.labelDOB.TabIndex = 13;
            this.labelDOB.Text = "Date of Birth";
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox2.Location = new System.Drawing.Point(650, 159);
            this.maskedTextBox2.Mask = "999999999CCC";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(100, 26);
            this.maskedTextBox2.TabIndex = 6;
            // 
            // textBoxPrefferedName
            // 
            this.textBoxPrefferedName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrefferedName.Location = new System.Drawing.Point(650, 201);
            this.textBoxPrefferedName.MaxLength = 15;
            this.textBoxPrefferedName.Name = "textBoxPrefferedName";
            this.textBoxPrefferedName.Size = new System.Drawing.Size(100, 26);
            this.textBoxPrefferedName.TabIndex = 8;
            // 
            // TextBoxContact
            // 
            this.TextBoxContact.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxContact.Location = new System.Drawing.Point(650, 284);
            this.TextBoxContact.Mask = "00000000";
            this.TextBoxContact.Name = "TextBoxContact";
            this.TextBoxContact.Size = new System.Drawing.Size(100, 26);
            this.TextBoxContact.TabIndex = 12;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(650, 242);
            this.textBox3.MaxLength = 250;
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 10;
            // 
            // checkBoxMartialStatus
            // 
            this.checkBoxMartialStatus.AutoSize = true;
            this.checkBoxMartialStatus.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxMartialStatus.ForeColor = System.Drawing.Color.White;
            this.checkBoxMartialStatus.Location = new System.Drawing.Point(650, 380);
            this.checkBoxMartialStatus.Name = "checkBoxMartialStatus";
            this.checkBoxMartialStatus.Size = new System.Drawing.Size(86, 24);
            this.checkBoxMartialStatus.TabIndex = 15;
            this.checkBoxMartialStatus.Text = "Married";
            this.checkBoxMartialStatus.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonAdd.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.buttonAdd.FlatAppearance.BorderSize = 20;
            this.buttonAdd.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(426, 430);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(149, 50);
            this.buttonAdd.TabIndex = 16;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            // 
            // dateTimePickerDOB
            // 
            this.dateTimePickerDOB.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDOB.Location = new System.Drawing.Point(650, 331);
            this.dateTimePickerDOB.Name = "dateTimePickerDOB";
            this.dateTimePickerDOB.Size = new System.Drawing.Size(100, 26);
            this.dateTimePickerDOB.TabIndex = 14;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonUpdate.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonUpdate.FlatAppearance.BorderSize = 5;
            this.buttonUpdate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.ForeColor = System.Drawing.Color.White;
            this.buttonUpdate.Location = new System.Drawing.Point(650, 430);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(149, 50);
            this.buttonUpdate.TabIndex = 16;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            // 
            // UserControlAddStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.Controls.Add(this.dateTimePickerDOB);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.checkBoxMartialStatus);
            this.Controls.Add(this.TextBoxContact);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.TextBoxEmployeeID);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBoxPrefferedName);
            this.Controls.Add(this.textBoxEmployeeName);
            this.Controls.Add(this.labelNIC);
            this.Controls.Add(this.labelDOB);
            this.Controls.Add(this.labelContact);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelPrefferedName);
            this.Controls.Add(this.labelEmployeeID);
            this.Controls.Add(this.labelEmployeeName);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "UserControlAddStaff";
            this.Size = new System.Drawing.Size(990, 554);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEmployeeName;
        private System.Windows.Forms.TextBox textBoxEmployeeName;
        private System.Windows.Forms.MaskedTextBox TextBoxEmployeeID;
        private System.Windows.Forms.Label labelEmployeeID;
        private System.Windows.Forms.Label labelPrefferedName;
        private System.Windows.Forms.Label labelNIC;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelContact;
        private System.Windows.Forms.Label labelDOB;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.TextBox textBoxPrefferedName;
        private System.Windows.Forms.MaskedTextBox TextBoxContact;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.CheckBox checkBoxMartialStatus;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DateTimePicker dateTimePickerDOB;
        private System.Windows.Forms.Button buttonUpdate;
    }
}
