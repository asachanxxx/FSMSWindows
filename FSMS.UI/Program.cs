using FSMS.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FSMS.UI
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

            LoggedDetails.Loginuser = "Admin";
            LoggedDetails.LoggedUserId = 1;
            LoggedDetails.GroupOfCompanyID = 1;

            //Application.Run(new frm_login());
            Application.Run(new frm_main());
        }
    }
}
