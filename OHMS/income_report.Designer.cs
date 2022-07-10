
namespace OHMS
{
    partial class income_report
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.expenseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ohmsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ohmsDataSet = new OHMS.ohmsDataSet();
            this.donationBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.donationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.expenseTableAdapter = new OHMS.ohmsDataSetTableAdapters.expenseTableAdapter();
            this.donationTableAdapter = new OHMS.ohmsDataSetTableAdapters.donationTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.expenseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ohmsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ohmsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donationBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // expenseBindingSource
            // 
            this.expenseBindingSource.DataMember = "expense";
            this.expenseBindingSource.DataSource = this.ohmsDataSetBindingSource;
            // 
            // ohmsDataSetBindingSource
            // 
            this.ohmsDataSetBindingSource.DataSource = this.ohmsDataSet;
            this.ohmsDataSetBindingSource.Position = 0;
            // 
            // ohmsDataSet
            // 
            this.ohmsDataSet.DataSetName = "ohmsDataSet";
            this.ohmsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // donationBindingSource1
            // 
            this.donationBindingSource1.DataMember = "donation";
            this.donationBindingSource1.DataSource = this.ohmsDataSetBindingSource;
            // 
            // donationBindingSource
            // 
            this.donationBindingSource.DataMember = "donation";
            this.donationBindingSource.DataSource = this.ohmsDataSetBindingSource;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.expenseBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.donationBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "OHMS.ExpenseReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(984, 461);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load_1);
            // 
            // expenseTableAdapter
            // 
            this.expenseTableAdapter.ClearBeforeFill = true;
            // 
            // donationTableAdapter
            // 
            this.donationTableAdapter.ClearBeforeFill = true;
            // 
            // income_report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "income_report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Income Report";
            this.Load += new System.EventHandler(this.income_report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.expenseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ohmsDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ohmsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donationBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donationBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private ohmsDataSet ohmsDataSet;
        private System.Windows.Forms.BindingSource ohmsDataSetBindingSource;
        private System.Windows.Forms.BindingSource expenseBindingSource;
        private ohmsDataSetTableAdapters.expenseTableAdapter expenseTableAdapter;
        private System.Windows.Forms.BindingSource donationBindingSource;
        private ohmsDataSetTableAdapters.donationTableAdapter donationTableAdapter;
        private System.Windows.Forms.BindingSource donationBindingSource1;
    }
}