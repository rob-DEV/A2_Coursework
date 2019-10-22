using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.IO;
using A2_Coursework.Data;

namespace A2_Coursework.Forms
{
    public partial class frmViewInvoice : Form
    {
        private Booking m_BookingToInvoice;
        public frmViewInvoice(int selectedBookingId)
        {
            InitializeComponent();
            this.CenterToScreen();
            m_BookingToInvoice = Booking.RetrieveById(selectedBookingId);
            //set report margins
            var pageSetup = reportInvoice.GetPageSettings();
            pageSetup.Margins = new System.Drawing.Printing.Margins(0, 0, 0, 0);
            reportInvoice.SetPageSettings(pageSetup);
        }
        public void SavePDF(ReportViewer viewer, string path)
        {
            byte[] Bytes = viewer.LocalReport.Render(format: "PDF", deviceInfo: "");

            if (!Directory.Exists("invoices"))
                Directory.CreateDirectory("invoices");

            using (FileStream stream = new FileStream(path, FileMode.Create))
            {
                stream.Write(Bytes, 0, Bytes.Length);
            }

        }  

        private void frmViewinvoice_Load(object sender, EventArgs e)
        {

            //invoice path
            int cust_id = m_BookingToInvoice.Customer.ID;
            int book_id = m_BookingToInvoice.ID;
            string path = string.Format("invoices/{0}-{1}.pdf", cust_id, book_id);

            //create the invoice for the first time for this booking and save it
            //invoice details
            this.invoiceDetailsTableAdapter.FillBy
                (this.invoiceDetails.InvoiceDetails,
                m_BookingToInvoice.Customer.ID, m_BookingToInvoice.ID
                );
            //invoice menu
            this.invoiceMenusTableAdapter.FillBy
                (this.invoiceDetails.InvoiceMenus, m_BookingToInvoice.ID
                );
            this.reportInvoice.RefreshReport();

            //save report to PDF
            if(!File.Exists(path))
                SavePDF(reportInvoice, path);

        }
    }
}
