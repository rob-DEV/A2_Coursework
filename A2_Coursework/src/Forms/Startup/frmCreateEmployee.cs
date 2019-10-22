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
    public partial class frmCreateEmployee : Form
    {
        private frmProvideMasterPassword m_MasterPasswordForm;
        public frmCreateEmployee()
        {
            InitializeComponent();
            this.CenterToScreen();
            TopMost = true;
        }

        public void MasterPasswordConfirmed()
        {
            m_MasterPasswordForm.Close();
            bool addResult = Employee.Add(new Employee(-1, txtFirstname.Text, txtLastname.Text, dateBirth.Value, txtAddress.Text, txtAddress2.Text, txtCity.Text, txtPostcode.Text, txtPhone.Text, txtUsername.Text, txtPassword.Text));
            if (addResult)
            {
                //customer added successful
                if (MessageBox.Show("Employee Added!", "Success:", MessageBoxButtons.OK) == DialogResult.OK)
                    this.Close();
            }
            else
            {
                //handle the bad insert
                MessageBox.Show("Check your input!", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            m_MasterPasswordForm = new frmProvideMasterPassword(this);
            m_MasterPasswordForm.ShowDialog();
        }
    }
}
