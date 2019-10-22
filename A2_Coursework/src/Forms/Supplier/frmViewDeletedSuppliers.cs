using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using A2_Coursework.ApplicationManagement;
using A2_Coursework.Data;

namespace A2_Coursework.Forms
{
    public partial class frmViewDeletedSuppliers : Form
    {
        //default selected id is -1 i.e. an impossible record
        private int selectedSupplierId = -1;

        public void LoadDeletedSuppliers()
        {
            dataGridSuppliers.DataSource =  Supplier.RetrieveAllDeleted();
        }

        public frmViewDeletedSuppliers()
        {
            InitializeComponent();
            this.CenterToScreen();

            //load deleted customers initally
            LoadDeletedSuppliers();

        }

        private void dataGridSuppliers_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridSuppliers.RowCount > 0)
            {
                try
                {
                    //keeps track of what row is selected for editing their record
                    selectedSupplierId = Convert.ToInt32(dataGridSuppliers.CurrentRow.Cells[0].Value);
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
            if(Supplier.UndeleteByID(selectedSupplierId))
            {
                //update the ui
                LoadDeletedSuppliers();
            }
            else
            {
                MessageBox.Show("Unable to undelete Supplier!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
