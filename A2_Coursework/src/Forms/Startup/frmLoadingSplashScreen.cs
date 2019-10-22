using System;
using System.Windows.Forms;

namespace A2_Coursework.Forms
{
    public partial class frmLoadingSplashScreen : Form
    {
        public frmLoadingSplashScreen()
        {
            InitializeComponent();
            //start the timer
            timLoading.Start();
            this.CenterToScreen();
        }
        /// <summary>
        /// Increment he progress bar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timLoading_Tick(object sender, EventArgs e)
        {
            prgLoading.Increment(5);
        }
    }
}
