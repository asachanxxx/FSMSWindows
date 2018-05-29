using FSMS.Common;
using FSMS.Repository;
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

            commonFunctions.Loginuser = "Admin";
            LoggedDetails.LoggedUserId = 1;
            LoggedDetails.GroupOfCompanyID = 1;
            commonFunctions.GlobalCompany = "FSFS Distributors Waththala";
            commonFunctions.LoginuserID = 1;
            commonFunctions.CompanyAddress = "270/A Mullegama Homagama";


            //Application.Run(new frm_login());
            Application.Run(new frm_main());
        }
    }
}
