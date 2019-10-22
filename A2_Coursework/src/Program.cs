using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using A2_Coursework.Forms;

namespace A2_Coursework
{
    static class Program
    {
        private static void SplashScreen()
        {
            Application.Run(new frmLoadingSplashScreen());
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
#if (!DEBUG)
                //splash screen load and DB setup
                //create thread for splash screen
                Thread splashScreenThread = new Thread(new ThreadStart(SplashScreen));
                splashScreenThread.Start();
                //wait until progress bar is loaded to 100% 
                Thread.Sleep(3000);
                //abort the splashscreen thread
                splashScreenThread.Abort();
#endif



            Application.Run(new frmLogin());
        }
    }
}
