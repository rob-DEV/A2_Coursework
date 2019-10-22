using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A2_Coursework.Forms
{
    public partial class frmProvideMasterPassword : Form
    {
        private frmCreateEmployee empForm;
        
        public frmProvideMasterPassword(frmCreateEmployee empFormCallback)
        {
            InitializeComponent();
            empForm = empFormCallback;
            TopMost = true;
            this.CenterToScreen();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(txtMasterPassword.Text == "MANAGER")
            {
                empForm.MasterPasswordConfirmed();
            }
            else
            {
                MessageBox.Show("Incorrect Master Password! Please try again.", "Warning!");
            }
        }
    }
}
