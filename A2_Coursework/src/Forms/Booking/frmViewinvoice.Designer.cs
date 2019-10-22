namespace A2_Coursework.Forms
{
    partial class frmViewInvoice
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
            this.invoiceDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoiceDetails = new A2_Coursework.reports.invoice.invoiceDetails();
            this.invoiceMenusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportInvoice = new Microsoft.Reporting.WinForms.ReportViewer();
            this.invoiceDetailsTableAdapter = new A2_Coursework.reports.invoice.invoiceDetailsTableAdapters.InvoiceDetailsTableAdapter();
            this.invoiceMenusTableAdapter = new A2_Coursework.reports.invoice.invoiceDetailsTableAdapters.InvoiceMenusTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceMenusBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // invoiceDetailsBindingSource
            // 
            this.invoiceDetailsBindingSource.DataMember = "InvoiceDetails";
            this.invoiceDetailsBindingSource.DataSource = this.invoiceDetails;
            // 
            // invoiceDetails
            // 
            this.invoiceDetails.DataSetName = "invoiceDetails";
            this.invoiceDetails.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // invoiceMenusBindingSource
            // 
            this.invoiceMenusBindingSource.DataMember = "InvoiceMenus";
            this.invoiceMenusBindingSource.DataSource = this.invoiceDetails;
            // 
            // reportInvoice
            // 
            this.reportInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "invoiceData";
            reportDataSource1.Value = this.invoiceDetailsBindingSource;
            reportDataSource2.Name = "invoiceMenuData";
            reportDataSource2.Value = this.invoiceMenusBindingSource;
            this.reportInvoice.LocalReport.DataSources.Add(reportDataSource1);
            this.reportInvoice.LocalReport.DataSources.Add(reportDataSource2);
            this.reportInvoice.LocalReport.ReportEmbeddedResource = "A2_Coursework.reports.invoice.invoice.rdlc";
            this.reportInvoice.Location = new System.Drawing.Point(0, 0);
            this.reportInvoice.Name = "reportInvoice";
            this.reportInvoice.Size = new System.Drawing.Size(842, 571);
            this.reportInvoice.TabIndex = 0;
            // 
            // invoiceDetailsTableAdapter
            // 
            this.invoiceDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // invoiceMenusTableAdapter
            // 
            this.invoiceMenusTableAdapter.ClearBeforeFill = true;
            // 
            // frmViewInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 571);
            this.Controls.Add(this.reportInvoice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmViewInvoice";
            this.Text = "frmViewinvoice";
            this.Load += new System.EventHandler(this.frmViewinvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceMenusBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportInvoice;
        private reports.invoice.invoiceDetails invoiceDetails;
        private System.Windows.Forms.BindingSource invoiceDetailsBindingSource;
        private reports.invoice.invoiceDetailsTableAdapters.InvoiceDetailsTableAdapter invoiceDetailsTableAdapter;
        private System.Windows.Forms.BindingSource invoiceMenusBindingSource;
        private reports.invoice.invoiceDetailsTableAdapters.InvoiceMenusTableAdapter invoiceMenusTableAdapter;
    }
}