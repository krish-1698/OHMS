
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
            this.labelEmployeeName.Location = new System.Drawing.Point(70, 76);
            this.labelEmployeeName.Name = "labelEmployeeName";
            this.labelEmployeeName.Size = new System.Drawing.Size(84, 13);
            this.labelEmployeeName.TabIndex = 3;
            this.labelEmployeeName.Text = "Employee Name";
            // 
            // textBoxEmployeeName
            // 
            this.textBoxEmployeeName.Location = new System.Drawing.Point(229, 76);
            this.textBoxEmployeeName.MaxLength = 200;
            this.textBoxEmployeeName.Multiline = true;
            this.textBoxEmployeeName.Name = "textBoxEmployeeName";
            this.textBoxEmployeeName.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBoxEmployeeName.Size = new System.Drawing.Size(276, 45);
            this.textBoxEmployeeName.TabIndex = 4;
            // 
            // TextBoxEmployeeID
            // 
            this.TextBoxEmployeeID.Location = new System.Drawing.Point(229, 29);
            this.TextBoxEmployeeID.Mask = "ID00000";
            this.TextBoxEmployeeID.Name = "TextBoxEmployeeID";
            this.TextBoxEmployeeID.Size = new System.Drawing.Size(53, 20);
            this.TextBoxEmployeeID.TabIndex = 2;
            // 
            // labelEmployeeID
            // 
            this.labelEmployeeID.AutoSize = true;
            this.labelEmployeeID.Location = new System.Drawing.Point(73, 32);
            this.labelEmployeeID.Name = "labelEmployeeID";
            this.labelEmployeeID.Size = new System.Drawing.Size(67, 13);
            this.labelEmployeeID.TabIndex = 1;
            this.labelEmployeeID.Text = "Employee ID";
            // 
            // labelPrefferedName
            // 
            this.labelPrefferedName.AutoSize = true;
            this.labelPrefferedName.Location = new System.Drawing.Point(70, 179);
            this.labelPrefferedName.Name = "labelPrefferedName";
            this.labelPrefferedName.Size = new System.Drawing.Size(81, 13);
            this.labelPrefferedName.TabIndex = 7;
            this.labelPrefferedName.Text = "Preffered Name";
            // 
            // labelNIC
            // 
            this.labelNIC.AutoSize = true;
            this.labelNIC.Location = new System.Drawing.Point(70, 141);
            this.labelNIC.Name = "labelNIC";
            this.labelNIC.Size = new System.Drawing.Size(65, 13);
            this.labelNIC.TabIndex = 5;
            this.labelNIC.Text = "NIC Number";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(73, 224);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(45, 13);
            this.labelAddress.TabIndex = 9;
            this.labelAddress.Text = "Address";
            // 
            // labelContact
            // 
            this.labelContact.AutoSize = true;
            this.labelContact.Location = new System.Drawing.Point(74, 269);
            this.labelContact.Name = "labelContact";
            this.labelContact.Size = new System.Drawing.Size(44, 13);
            this.labelContact.TabIndex = 11;
            this.labelContact.Text = "Contact";
            // 
            // labelDOB
            // 
            this.labelDOB.AutoSize = true;
            this.labelDOB.Location = new System.Drawing.Point(74, 318);
            this.labelDOB.Name = "labelDOB";
            this.labelDOB.Size = new System.Drawing.Size(66, 13);
            this.labelDOB.TabIndex = 13;
            this.labelDOB.Text = "Date of Birth";
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(229, 141);
            this.maskedTextBox2.Mask = "999999999CCC";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(78, 20);
            this.maskedTextBox2.TabIndex = 6;
            // 
            // textBoxPrefferedName
            // 
            this.textBoxPrefferedName.Location = new System.Drawing.Point(229, 176);
            this.textBoxPrefferedName.MaxLength = 15;
            this.textBoxPrefferedName.Name = "textBoxPrefferedName";
            this.textBoxPrefferedName.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrefferedName.TabIndex = 8;
            // 
            // TextBoxContact
            // 
            this.TextBoxContact.Location = new System.Drawing.Point(229, 269);
            this.TextBoxContact.Mask = "00000000";
            this.TextBoxContact.Name = "TextBoxContact";
            this.TextBoxContact.Size = new System.Drawing.Size(53, 20);
            this.TextBoxContact.TabIndex = 12;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(229, 217);
            this.textBox3.MaxLength = 250;
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 10;
            // 
            // checkBoxMartialStatus
            // 
            this.checkBoxMartialStatus.AutoSize = true;
            this.checkBoxMartialStatus.Location = new System.Drawing.Point(76, 357);
            this.checkBoxMartialStatus.Name = "checkBoxMartialStatus";
            this.checkBoxMartialStatus.Size = new System.Drawing.Size(61, 17);
            this.checkBoxMartialStatus.TabIndex = 15;
            this.checkBoxMartialStatus.Text = "Married";
            this.checkBoxMartialStatus.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(77, 412);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(149, 50);
            this.buttonAdd.TabIndex = 16;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerDOB
            // 
            this.dateTimePickerDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDOB.Location = new System.Drawing.Point(229, 311);
            this.dateTimePickerDOB.Name = "dateTimePickerDOB";
            this.dateTimePickerDOB.Size = new System.Drawing.Size(100, 20);
            this.dateTimePickerDOB.TabIndex = 14;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(301, 412);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(149, 50);
            this.buttonUpdate.TabIndex = 16;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // UserControlAddStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
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
