using DevExpress.ExpressApp.Win;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace expressAppCore.Win
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var application = new ExpressAppCoreWinApplication();

            application.Setup();
            application.Start();
        }
    }

    public class ExpressAppCoreWinApplication : WinApplication
    {

    }
}
