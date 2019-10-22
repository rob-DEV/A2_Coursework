using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using A2_Coursework.Data;

namespace A2_Coursework.Forms
{
    public partial class frmSelectCustomer : Form
    {
        private int selectedCustomerId = -1;
        private int m_SearchTime = 0;

        public frmSelectCustomer()
        {
            InitializeComponent();
            this.CenterToScreen();
            dataGridCustomers.DataSource = Customer.RetrieveAll();
        }

        private void dataGridCustomers_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridCustomers.RowCount > 0)
            {
                try
                {
                    //keeps track of what row is selected for editing their record
                    selectedCustomerId = Convert.ToInt32(dataGridCustomers.CurrentRow.Cells[0].Value);
                }
                catch
                {
                    //should never happen
                    Console.WriteLine("ERROR: Cannot convert current row[0] to int32");
                    selectedCustomerId = -1;
                }
            }

        }

        private void btnSelectCustomer_Click(object sender, EventArgs e)
        {
            if(selectedCustomerId != -1)
            {
                //pass the selected customer id as a reference to it
                frmAddBooking addBookingForm = new frmAddBooking(selectedCustomerId);
                addBookingForm.ShowDialog();
                this.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCustomerSearch_TextChanged(object sender, EventArgs e)
        {
            //retrieve stock based on a SQL search
            //a timer is used here to ensure SQL queries are limited to 1/sec
            if (m_SearchTime % 2 == 0)
                dataGridCustomers.DataSource = Customer.Search(txtCustomerSearch.Text);
        }
    }
}
