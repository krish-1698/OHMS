
namespace OHMS.user_control
{
    partial class MarkStaffAttendanceControl
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
            this.buttonIn = new System.Windows.Forms.Button();
            this.textBoxEmployeeID = new System.Windows.Forms.TextBox();
            this.buttonOut = new System.Windows.Forms.Button();
            this.labelEmployeeID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonIn
            // 
            this.buttonIn.Location = new System.Drawing.Point(63, 153);
            this.buttonIn.Name = "buttonIn";
            this.buttonIn.Size = new System.Drawing.Size(129, 82);
            this.buttonIn.TabIndex = 0;
            this.buttonIn.Text = "Mark IN Time";
            this.buttonIn.UseVisualStyleBackColor = true;
            // 
            // textBoxEmployeeID
            // 
            this.textBoxEmployeeID.Location = new System.Drawing.Point(211, 69);
            this.textBoxEmployeeID.MaxLength = 10;
            this.textBoxEmployeeID.Name = "textBoxEmployeeID";
            this.textBoxEmployeeID.Size = new System.Drawing.Size(136, 20);
            this.textBoxEmployeeID.TabIndex = 2;
            // 
            // buttonOut
            // 
            this.buttonOut.Location = new System.Drawing.Point(211, 153);
            this.buttonOut.Name = "buttonOut";
            this.buttonOut.Size = new System.Drawing.Size(136, 82);
            this.buttonOut.TabIndex = 0;
            this.buttonOut.Text = "Mark Out Time";
            this.buttonOut.UseVisualStyleBackColor = true;
            // 
            // labelEmployeeID
            // 
            this.labelEmployeeID.AutoSize = true;
            this.labelEmployeeID.Location = new System.Drawing.Point(88, 76);
            this.labelEmployeeID.Name = "labelEmployeeID";
            this.labelEmployeeID.Size = new System.Drawing.Size(64, 13);
            this.labelEmployeeID.TabIndex = 2;
            this.labelEmployeeID.Text = "EmployeeID";
            // 
            // MarkStaffAttendanceControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.labelEmployeeID);
            this.Controls.Add(this.textBoxEmployeeID);
            this.Controls.Add(this.buttonOut);
            this.Controls.Add(this.buttonIn);
            this.Name = "MarkStaffAttendanceControl";
            this.Size = new System.Drawing.Size(980, 562);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonIn;
        private System.Windows.Forms.TextBox textBoxEmployeeID;
        private System.Windows.Forms.Button buttonOut;
        private System.Windows.Forms.Label labelEmployeeID;
    }
}
