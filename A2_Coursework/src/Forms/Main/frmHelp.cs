using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using A2_Coursework.ApplicationManagement;

namespace A2_Coursework.Forms
{
    public partial class frmHelp : Form
    {
        public frmHelp()
        {
            InitializeComponent();
            //display in screen centre
            this.CenterToScreen();

            //load about game information (instructions) from a text file
            using(StreamReader streamReader = new StreamReader(ApplicationManager.ABOUT_TEXT))
            {
                txtAboutBox.Text = streamReader.ReadToEnd();
            }
        }

        /// <summary>
        /// Closes form, returning to frmMainMenu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCloseHelp_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
