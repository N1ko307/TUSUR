
namespace Bank
{
    partial class ReportCredit
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
            this.Активные_кредитыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BankDBDataSet = new Bank.BankDBDataSet1();
            this.Активные_кредитыTableAdapter = new Bank.BankDBDataSet1TableAdapters.Активные_кредитыTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.Активные_кредитыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BankDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Активные_кредитыBindingSource
            // 
            this.Активные_кредитыBindingSource.DataMember = "Активные кредиты";
            this.Активные_кредитыBindingSource.DataSource = this.BankDBDataSet;
            // 
            // BankDBDataSet
            // 
            this.BankDBDataSet.DataSetName = "BankDBDataSet";
            this.BankDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Активные_кредитыTableAdapter
            // 
            this.Активные_кредитыTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Активные_кредитыBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Bank.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1145, 309);
            this.reportViewer1.TabIndex = 1;
            // 
            // ReportCredit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 309);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ReportCredit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отчет по должникам";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Активные_кредитыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BankDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource Активные_кредитыBindingSource;
        private BankDBDataSet1 BankDBDataSet;
        private BankDBDataSet1TableAdapters.Активные_кредитыTableAdapter Активные_кредитыTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}