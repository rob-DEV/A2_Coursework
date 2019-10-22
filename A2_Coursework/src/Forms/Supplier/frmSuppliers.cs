using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using A2_Coursework.ApplicationManagement;
using A2_Coursework.Data;

namespace A2_Coursework.Forms
{
    public partial class frmSuppliers : Form
    {
        //default selected id is -1 i.e. an impossible record
        private int m_SelectedSupplierId = -1;

        //retreive all supomers that are not deleted
        public void LoadSuppliers()
        {
            dataGridSuppliers.DataSource =  Supplier.RetrieveAll();
        }

        public frmSuppliers()
        {
            InitializeComponent();
            this.CenterToScreen();

            //load supomers initally
            LoadSuppliers();

        }

        private void dataGridSuppliers_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridSuppliers.RowCount > 0)
            {
                try
                {
                    //keeps track of what row is selected for editing their record
                    m_SelectedSupplierId = Convert.ToInt32(dataGridSuppliers.CurrentRow.Cells[0].Value);

                    Supplier supToEdit = Supplier.RetrieveById(m_SelectedSupplierId);
                    txtName.Text = supToEdit.Name;
                    txtAdd.Text = supToEdit.Address;
                    txtAdd2.Text = supToEdit.Address2;
                    txtCity.Text = supToEdit.City;
                    txtPostcode.Text = supToEdit.Postcode;
                    txtPhone.Text = supToEdit.Phone;
                    txtEmail.Text = supToEdit.Email;
                }
                catch 
                {
                    //should never happen
                    Console.WriteLine("ERROR: Cannot convert current row[0] to int32");
                }
            }
               
        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            frmAddSupplier addSupplier = new frmAddSupplier();
            addSupplier.ShowDialog();
            LoadSuppliers();
        }

        private void btnDeleteSupplier_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to delete (Hide) this Supplier?", "Warning!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                if(Supplier.DeleteByID(m_SelectedSupplierId))
                {
                    Console.WriteLine("Supplier Hidden!");
                    LoadSuppliers();
                }

            }
        }

        private void btnUpdateSupplier_Click(object sender, EventArgs e)
        {
            bool addResult = Supplier.Update(new Supplier(m_SelectedSupplierId, txtName.Text, txtAdd.Text,
               txtAdd2.Text, txtCity.Text, txtPostcode.Text, txtPhone.Text, txtEmail.Text));
            if (addResult)
            {
                //supomer added successful
                MessageBox.Show("Supplier Updated!", "Success:", MessageBoxButtons.OK);
                this.LoadSuppliers();
            }
            else
            {
                //handle the bad insert
                MessageBox.Show("Check your input!", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnViewDeleted_Click(object sender, EventArgs e)
        {
            frmViewDeletedSuppliers viewDeleted = new frmViewDeletedSuppliers();
            viewDeleted.ShowDialog();
            //update the table
            LoadSuppliers();
        }

       


    }
}
