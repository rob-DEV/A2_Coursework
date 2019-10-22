using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using A2_Coursework.ApplicationManagement;
using A2_Coursework.Data;

namespace A2_Coursework.Forms
{

    public partial class frmBookings : Form
    {
        //default selected id is -1 i.e. an impossible record
        private int selectedBookingId = -1;
        private int selectedCustomerId = -1;
        //retreive all customers that are not deleted
        public void LoadBookings()
        {
            dataGridBookings.DataSource =  Booking.RetrieveAll();
        }

        public frmBookings()
        {
            InitializeComponent();
            this.CenterToScreen();

            //load customers initally
            LoadBookings();

        }

        private void dataGridBookings_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridBookings.RowCount > 0)
            {
                try
                {
                    //keeps track of what row is selected for editing their record
                    selectedBookingId = Convert.ToInt32(dataGridBookings.CurrentRow.Cells[0].Value);
                    selectedCustomerId = Booking.RetrieveById(selectedBookingId).Customer.ID;
                    //get the booking be the currently selected cell and from that get the customer
                    
                    Booking booking = Booking.RetrieveById(selectedBookingId);
                    //add booking UI
                    numPeopleUpDown.Value = booking.NoPeople;
                    datePickerPlaced.Value = booking.DatePlaced;
                    datePickerEvent.Value = booking.DateEvent;

                    //change UI depending on boolean
                    if (booking.Confirmed)
                        comboConfirmed.Text = "True";
                    else
                        comboConfirmed.Text = "False";

                    if (booking.Paid)
                        comboPaid.Text = "True";
                    else
                        comboPaid.Text = "False";


                    Customer custToEdit = booking.Customer;
                    txtFname.Text = custToEdit.Firstname;
                    txtLname.Text = custToEdit.Lastname;
                    txtAdd.Text = custToEdit.Address;
                    txtAdd2.Text = custToEdit.Address2;
                    txtCity.Text = custToEdit.City;
                    txtPostcode.Text = custToEdit.Postcode;
                    txtPhone.Text = custToEdit.Phone;
                    txtEmail.Text = custToEdit.Email;
                }
                catch 
                {
                    //should never happen
                    Console.WriteLine("ERROR: Cannot convert current row[0] to int32");
                }
            }
               
        }
        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            if (selectedCustomerId == -1)
                return;
            bool updateResult = Customer.Update(new Customer(selectedCustomerId, txtFname.Text, txtLname.Text, txtAdd.Text,
                    txtAdd2.Text, txtCity.Text, txtPostcode.Text, txtPhone.Text, txtEmail.Text));
            if (updateResult)
            {
                //customer added successful
                MessageBox.Show("Customer Updated!", "Success:", MessageBoxButtons.OK);
                this.LoadBookings();
            }
            else
            {
                //handle the bad insert
                MessageBox.Show("Check your input!", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }
        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (selectedBookingId != -1 && MessageBox.Show("Are you sure you want to delete (Hide) this customer and all of their booking?", "Warning!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                if (Customer.DeleteByID(selectedCustomerId))
                {
                    Console.WriteLine("Customer Hidden!");
                    LoadBookings();
                }

            }
        }
        private void btnAddBooking_Click(object sender, EventArgs e)
        {
            //loads the selector form and allows the user to progress to the add booking form
            frmSelectCustomer selectCustomerForBooking = new frmSelectCustomer();
            selectCustomerForBooking.ShowDialog();
            //update booking UI
            LoadBookings();
        }
        private void btnUpdateBooking_Click(object sender, EventArgs e)
        {
            //get the selected booking and repass the info from the ui to update it
            if(selectedBookingId != -1 && Booking.Update(
                new Booking(selectedBookingId, (int)numPeopleUpDown.Value, datePickerPlaced.Value,
                datePickerEvent.Value,
                bool.Parse(comboConfirmed.SelectedItem.ToString()),
                bool.Parse(comboPaid.SelectedItem.ToString()),
                selectedCustomerId, null)))
            {
                MessageBox.Show("Booking Updated!", "Success:", MessageBoxButtons.OK);
            }

            LoadBookings();
        }
        private void btnViewMeals_Click(object sender, EventArgs e)
        {
            if(selectedBookingId != -1)
            {
                frmViewBookingMeals frmMeals = new frmViewBookingMeals(selectedBookingId);
                frmMeals.ShowDialog();
            }
        }
        private void btnDeleteBooking_Click(object sender, EventArgs e)
        {
            if (selectedBookingId != -1 && MessageBox.Show("Are you sure you want to delete (Hide) this booking?", "Warning!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                if (Booking.DeleteById(selectedBookingId))
                {
                    Console.WriteLine("Booking Hidden!");
                    LoadBookings();
                }

            }
        }
        private void btnOpenInvoice_Click(object sender, EventArgs e)
        {
            frmViewInvoice invoiceReportViewer = new frmViewInvoice(selectedBookingId);
            invoiceReportViewer.ShowDialog();
        }

        private void btnMarkPaid_Click(object sender, EventArgs e)
        {
            if (selectedBookingId != -1 && MessageBox.Show("Are you sure you want to mark this booking as paid? This cannot be undone!", "Are you sure?", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                if (Booking.Update(
                new Booking(selectedBookingId, (int)numPeopleUpDown.Value, datePickerPlaced.Value,
                datePickerEvent.Value,
                bool.Parse(comboConfirmed.SelectedItem.ToString()),
                true,
                selectedCustomerId, null)))
                {
                    MessageBox.Show("Booking Updated!", "Success:", MessageBoxButtons.OK);
                }

                LoadBookings();
            }
        }


    }
}
