using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.IO;
using A2_Coursework.ApplicationManagement;
using A2_Coursework.Data;

namespace A2_Coursework.Forms
{
    public partial class frmMain : Form
    {
        private void LoadLowStock()
        {
            dataGridLowStock.DataSource = Raw_Stock.RetrieveLowStock();
        }

        public frmMain()
        {
            InitializeComponent();
            this.CenterToScreen();
            LoadLowStock();
            lblUserHeader.Text = string.Format("Hello, {0} {1}", ApplicationManager.LoggedInEmployee.Firstname, ApplicationManager.LoggedInEmployee.Lastname);

        }

        ///EVENTS
        private void btnCustomers_Click(object sender, EventArgs e)
        {
            frmCustomers frmCustomers = new frmCustomers();
            frmCustomers.ShowDialog();
        }

        private void btnBookings_Click(object sender, EventArgs e)
        {
            frmBookings frmBookings = new frmBookings();
            frmBookings.ShowDialog();
        }

        private void btnEditFoodMenus_Click(object sender, EventArgs e)
        {
            frmFoodMenus frmFoodMenus = new frmFoodMenus();
            frmFoodMenus.ShowDialog();
        }

        private void btnEditStock_Click(object sender, EventArgs e)
        {
            frmStock stockForm = new frmStock();
            stockForm.ShowDialog();
        }


        private void btnEditSuppliers_Click(object sender, EventArgs e)
        {
            frmSuppliers frmSuppliers = new frmSuppliers();
            frmSuppliers.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to log out?", "Are You Sure?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ApplicationManager.LoginForm.Show();
                ApplicationManager.LoggedInEmployee = null;
                this.Hide();
            }
        }

        /// MENUSTRIP EVENTS
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplicationManager.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHelp helpForm = new frmHelp();
            helpForm.ShowDialog();
        }

    }
}
