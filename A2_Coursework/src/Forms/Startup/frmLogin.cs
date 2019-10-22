using System;
using System.Windows.Forms;
using System.Drawing;
using A2_Coursework.ApplicationManagement;
using A2_Coursework.Data;
using A2_Coursework.Exceptions;

namespace A2_Coursework.Forms
{
    public partial class frmLogin : Form
    {
        Employee emp = null;

        public frmLogin()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.TopMost = true;
            //stops the "ding" sound when the enter key is pressed 
            this.AcceptButton = btnLogin;

            //set the global login form as "this" for future reference
            ApplicationManager.LoginForm = this;
            this.Show();
        }

        private void Login()
        {
            //the login method may be bypassed for testing
            try
            {
                emp = Employee.Login(txtUsername.Text, txtPassword.Text);
                //hence log them in
                if (emp == null)
                    throw new InvalidLoginException();
                //user is logged in at this point

                //hide this form and load the main form
                this.Hide();
                ApplicationManager.LoggedInEmployee = emp;
                ApplicationManager.MainForm = new frmMain();
                ApplicationManager.MainForm.Show();

                //handle form closing
                ApplicationManager.MainForm.FormClosing += delegate { this.Close(); };
            }
            catch(InvalidLoginException)
            {
                lblLoginResponse.Text = "Invalid Login Information, Please try again!";
            }
            
        }
        
        //EVENTS:
        //login button clicked
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        //enter key pressed
        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Enter)
                Login();
        }

        //resets the password and username input boxes
        private void frmLogin_Activated(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            lblLoginResponse.Text = "";
            txtUsername.Focus();
        }

        private void lblCreateAccount_Click(object sender, EventArgs e)
        {
            frmCreateEmployee employeeCreator = new frmCreateEmployee();
            employeeCreator.ShowDialog();
        }
    }
}
