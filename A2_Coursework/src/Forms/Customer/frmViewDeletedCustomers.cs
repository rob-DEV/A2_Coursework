using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using A2_Coursework.ApplicationManagement;
using A2_Coursework.Data;

namespace A2_Coursework.Forms
{
    public partial class frmViewDeletedCustomers : Form
    {
        //default selected id is -1 i.e. an impossible record
        private int selectedCustomerId = -1;

        public void LoadDeletedCustomers()
        {
            dataGridCustomers.DataSource =  Customer.RetrieveAllDeleted();
        }

        public frmViewDeletedCustomers()
        {
            InitializeComponent();
            this.CenterToScreen();

            //load deleted customers initally
            LoadDeletedCustomers();

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
                }
            }
               
        }

        private void btnUndeleted_Click(object sender, EventArgs e)
        {
            if(Customer.UndeleteByID(selectedCustomerId))
            {
                //update the ui
                LoadDeletedCustomers();
            }
            else
            {
                MessageBox.Show("Unable to undelete Customer!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
