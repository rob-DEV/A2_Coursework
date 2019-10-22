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
    public partial class frmAddCustomer : Form
    {
        public frmAddCustomer()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            bool addResult = Customer.Add(new Customer(txtFirstname.Text, txtLastname.Text, txtAddress.Text,
                txtAddress2.Text, txtCity.Text, txtPostcode.Text, txtPhone.Text, txtEmail.Text));
            if (addResult)
            {
                //customer added successful
                if (MessageBox.Show("Customer Added!", "Success:", MessageBoxButtons.OK) == DialogResult.OK)
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
