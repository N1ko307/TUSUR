
namespace Bank
{
    partial class AllClients
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
            this.Все_клиентыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BankDBDataSet = new Bank.BankDBDataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Все_клиентыTableAdapter = new Bank.BankDBDataSet1TableAdapters.Все_клиентыTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Все_клиентыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BankDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Все_клиентыBindingSource
            // 
            this.Все_клиентыBindingSource.DataMember = "Все клиенты";
            this.Все_клиентыBindingSource.DataSource = this.BankDBDataSet;
            // 
            // BankDBDataSet
            // 
            this.BankDBDataSet.DataSetName = "BankDBDataSet";
            this.BankDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Все_клиентыBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Bank.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1161, 288);
            this.reportViewer1.TabIndex = 0;
            // 
            // Все_клиентыTableAdapter
            // 
            this.Все_клиентыTableAdapter.ClearBeforeFill = true;
            // 
            // AllClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 288);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AllClients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отчет по клиентам";
            this.Load += new System.EventHandler(this.AllClients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Все_клиентыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BankDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Все_клиентыBindingSource;
        private BankDBDataSet1 BankDBDataSet;
        private BankDBDataSet1TableAdapters.Все_клиентыTableAdapter Все_клиентыTableAdapter;
    }
}