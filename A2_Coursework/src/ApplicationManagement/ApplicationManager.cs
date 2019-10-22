using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using A2_Coursework.Data;
using A2_Coursework.Forms;

namespace A2_Coursework.ApplicationManagement
{
    /// <summary>
    /// Acts as a global navigation management class
    /// holding form references and the details of the currently logged in Employee.
    /// </summary>
    public static class ApplicationManager
    {
        //a handle for the Loign form
        public static frmLogin LoginForm = null;
        //a handle for the Main form
        public static frmMain MainForm = null;
        //a handle for the Employee currently logged in to manage 
        //their details and used when inserting bookings
        //in their name
        public static Employee LoggedInEmployee;
   
        public const string ABOUT_TEXT = @"resources/ABOUT.TXT";

        public static void Exit()
        {
            LoginForm.Close();
            Database.CloseConnection();

            Application.ExitThread();
        }
    }
}