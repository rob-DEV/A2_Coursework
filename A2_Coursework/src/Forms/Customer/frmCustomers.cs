using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using A2_Coursework.ApplicationManagement;
using A2_Coursework.Data;

namespace A2_Coursework.Forms
{
    public partial class frmCustomers : Form
    {
        //default selected id is -1 i.e. an impossible record
        private int selectedCustomerId = -1;

        //retreive all customers that are not deleted
        public void LoadCustomers()
        {
            dataGridCustomers.DataSource =  Customer.RetrieveAll();
        }

        public frmCustomers()
        {
            InitializeComponent();
            this.CenterToScreen();

            //load customers initally
            LoadCustomers();

        }

        private void dataGridCustomers_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridCustomers.RowCount > 0)
            {
                try
                {
                    //keeps track of what row is selected for editing their record
                    selectedCustomerId = Convert.ToInt32(dataGridCustomers.CurrentRow.Cells[0].Value);

                    Customer custToEdit = Customer.RetrieveById(selectedCustomerId);
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

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            frmAddCustomer addCustomer = new frmAddCustomer();
            addCustomer.ShowDialog();
            LoadCustomers();
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to delete (Hide) this Customer?", "Warning!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                if(Customer.DeleteByID(selectedCustomerId))
                {
                    Console.WriteLine("Customer Hidden!");
                    LoadCustomers();
                }

            }
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            bool addResult = Customer.Update(new Customer(selectedCustomerId, txtFname.Text, txtLname.Text, txtAdd.Text,
               txtAdd2.Text, txtCity.Text, txtPostcode.Text, txtPhone.Text, txtEmail.Text));
            if (addResult)
            {
                //customer added successful
                MessageBox.Show("Customer Updated!", "Success:", MessageBoxButtons.OK);
                this.LoadCustomers();
            }
            else
            {
                //handle the bad insert
                MessageBox.Show("Check your input!", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnViewDeleted_Click(object sender, EventArgs e)
        {
            frmViewDeletedCustomers viewDeleted = new frmViewDeletedCustomers();
            viewDeleted.ShowDialog();
            //update the table
            LoadCustomers();
        }
    }
}
