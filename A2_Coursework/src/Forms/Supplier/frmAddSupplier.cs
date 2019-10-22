using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using A2_Coursework.ApplicationManagement;
using A2_Coursework.Data;

namespace A2_Coursework.Forms
{
    public partial class frmAddSupplier : Form
    {
        public frmAddSupplier()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            bool addResult = Supplier.Add(new Supplier(txtName.Text, txtAddress.Text,
                txtAddress2.Text, txtCity.Text, txtPostcode.Text, txtPhone.Text, txtEmail.Text));
            if (addResult)
            {
                //customer added successful
                if (MessageBox.Show("Supplier Added!", "Success:", MessageBoxButtons.OK) == DialogResult.OK)
                    this.Close();
            }
            else
            {
                //handle the bad insert
                MessageBox.Show("Check your input!", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
