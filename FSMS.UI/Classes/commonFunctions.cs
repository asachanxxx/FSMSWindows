using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using SmartAnything;
//using SmartAnything_DL;
//using smartOffice_Models;
using System.Configuration;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using Microsoft.VisualBasic;
using System.Globalization;

namespace FSMS.UI
{
    public partial class commonFunctions
    {

        public enum MessageType
        {
            Error = 0,
            Message = 1,
            Exclamation = 2,
        }

        public static int LoginuserID = 1;

        private static string softwarename = "Fuel Station Management System";
        private static string loginuser = "Admin";
        
        private static string globalCompany = "0";
        private static string globalLocation = "0";
        private static string gloDiscountmethod = "ITM";
        private static decimal glodreditperiod = 60;
        private static decimal gloinvoiceDiscrate = decimal.Parse("7.5");
        private static bool maintainstocklot = false;

        public static bool Maintainstocklot
        {
            get { return commonFunctions.maintainstocklot; }
            set { commonFunctions.maintainstocklot = value; }
        }


        public static decimal GloinvoiceDiscrate
        {
            get { return commonFunctions.gloinvoiceDiscrate; }
            set { commonFunctions.gloinvoiceDiscrate = value; }
        }

        public static decimal Glodreditperiod
        {
            get { return commonFunctions.glodreditperiod; }
            set { commonFunctions.glodreditperiod = value; }
        }

        public static string GloDiscountmethod
        {
            get { return commonFunctions.gloDiscountmethod; }
            set { commonFunctions.gloDiscountmethod = value; }
        }

        public static string GlobalLocation
        {
            get { return commonFunctions.globalLocation; }
            set { commonFunctions.globalLocation = value; }
        }

        public static string GlobalCompany
        {
            get { return commonFunctions.globalCompany; }
            set { commonFunctions.globalCompany = value; }
        }

        public static string Loginuser
        {
            get { return commonFunctions.loginuser; }
            set { commonFunctions.loginuser = value; }
        }

        public static string Softwarename
        {
            get { return softwarename; }
            set { softwarename = value; }
        }

        public static Color PanelHeaderForColor = Color.White;

        public static Color PanelHeaderBackGroundColor = Color.FromArgb(76, 108, 139);

        public static void SetMDIStatusMessage(string message , int type) {
            try
            {
                //frm_main mdi = (frm_main)frm_main.ActiveForm;
                //mdi.CountEr = 0;
                //mdi.type = type;
                ////mdi.tbl_status.Text = message;
                //mdi.Errormessagepoper(message);
            }
            catch (Exception ex) {
                //throw ex;
            }
        }



        public static string GetStockCode(string productId, string pricelevelindexstr)
        {
            return productId.Trim() + "-" + pricelevelindexstr.Trim();
        }

      



        //public static u_UserRights_DL GetUserRightObj(string formID, string user)
        //{
        //    u_UserRights objUserRight = new u_UserRights();
        //    objUserRight.User = new u_User();
        //    objUserRight.MenuTag = new u_MenuTag();
        //    objUserRight.User.strUserID = Globals.g_strUser;
        //    objUserRight.MenuTag.strMenuID = formID.Trim();

        //    u_UserRights_DL objURightDL = new u_UserRights_DL();
        //    u_UserRights_DL dtAllMenuItems = objURightDL.GetUserRightsForOneMenu(objUserRight);

        //    return dtAllMenuItems;
        //}



        public static void LoadDefault() {
            try
            {
                Softwarename = ConfigurationManager.AppSettings["softwarename"];
                GlobalCompany = ConfigurationManager.AppSettings["GlobalCompany"];
                GlobalLocation = ConfigurationManager.AppSettings["GlobalLocation"];
                Loginuser = ConfigurationManager.AppSettings["LoginUser"];
            }
            catch (Exception ex) {

                Softwarename = "Smart Distribution System";
                GlobalCompany = "001";
                GlobalLocation = "001";
                Loginuser = "Admin";
            }
        }

      
      

        #region FormatDataGrid

        public static void FormatDataGrid(DataGridView dataGridView)
        { 
            dataGridView.BackgroundColor = Color.FromArgb(242, 242, 242);
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView.ColumnHeadersHeight = 20;
            dataGridView.GridColor = Color.FromArgb(224, 224, 224);
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.RowHeadersVisible = false;

            dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(242, 242, 242);
            dataGridView.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;


            dataGridView.DefaultCellStyle.Font = new Font("Calibri", 9);

            dataGridView.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(86, 119, 174);

            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 10);
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(68, 68, 68);
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(255,255,255);

            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.AllowUserToAddRows = false;
        }

        #endregion

     

        #region Styling the form Control

        public static void HandleTextBoxes(Panel containerx)
        {

            foreach (var control in containerx.Controls.OfType<TextBox>())
            {
                control.Font = new Font("Calibri", 9);
                control.BorderStyle = BorderStyle.FixedSingle;
                control.BackColor = Color.FromArgb(217, 229, 242);

            }
        }

        public static void HandleTextBoxesInTransactions(Panel containerx)
        {

            foreach (var control in containerx.Controls.OfType<TextBox>())
            {
                control.Font = new Font("Calibri", 8);
                control.BorderStyle = BorderStyle.FixedSingle;
                control.BackColor = Color.FromArgb(255,255,255);

            }
        }

        public static void HandleHeaderPanelColor(Panel containerx)
        {

            //containerx.BackColor = Color.FromArgb(88, 155,225);
            containerx.BackColor = Color.FromArgb(43, 87, 154);
            
        }

        public static void ChangeHeaderTextAndColor(Label containerx,string Headertext)
        {

            //containerx.ForeColor = Color.FromArgb(15, 68, 123);
            containerx.ForeColor = Color.FromArgb(250, 250, 255);
            containerx.Text = Headertext.ToUpper().Trim();

        }

        public static void setFormProperties(Form frm)
        {
            applyTheme(frm);
            frm.BringToFront();
        }

        public static void applyTheme(Form frm)
        {
            frm.Left = 0;
            frm.Top = 0;
            frm.Width = 1024;
            frm.Height = 768;
            frm.BackColor = Color.FromArgb(231, 245, 235);

            foreach (Form form in frm.MdiParent.MdiChildren)
            {
                if (form != frm.MdiParent.ActiveMdiChild)
                {
                    form.Dock = DockStyle.Fill;
                    form.AutoScroll = true;
                }
                else
                {
                    frm.Dock = DockStyle.Fill;
                    frm.AutoScroll = true;
                }
            }
            foreach (Control c in frm.Controls)
            {
                if (c is Panel && c.Name == "hederPanel")
                {
                    c.Left = 0;
                    c.Top = 0;
                    c.Width = frm.MdiParent.Width;
                    c.Height = 76;
                    c.BackColor = Color.FromArgb(39, 174, 96);
                }
            }
        }

        #endregion

        #region ToDecimal

        public static decimal ToDecimal(string str) {
            decimal decGrossAmount = decimal.Zero;

            if (decimal.TryParse(str,out decGrossAmount) == true )
            {
                decGrossAmount = decimal.Parse(str);
            }

            return decimal.Round(decGrossAmount, 4); 
        }

        #endregion

        #region ToInt

        public static int ToInt(string str)
        {
            decimal decGrossAmount = 0;
            if (decimal.TryParse(str, out decGrossAmount) == true)
            {
                decGrossAmount = decimal.Parse(str);
            }
            decGrossAmount = decimal.Round(decGrossAmount, 0);

            int returnx = 0;
            if (int.TryParse(decGrossAmount.ToString(), out returnx) == true)
            {
                returnx = int.Parse(decGrossAmount.ToString());
                
            }
            return returnx;
        }
        #endregion

        //#region Serial Increment and Serial No functions

        ///// <summary>
        ///// Get the 4 method specific serials
        ///// 1.	Entirely system generated only digit serial numbers
        ///// 2.	System generated formatted serial numbers
        ///// 3.	Entirely manual serial numbers 
        ///// 4.	location and prefix specific serial numbers
        ///// </summary>
        ///// <param name="screenname">Screen Name Like A0001</param>
        ///// <returns></returns>
        //public static string GetSerial(string screenname)
        //{
        //    string strserial = string.Empty;

        //    P_AutoNumberDL pal = new P_AutoNumberDL();
        //    P_AutoNumber pauto = new P_AutoNumber();
        //    pauto.Screen = screenname;
        //    pauto = pal.Selectp_AutoNumber(pauto);

        //    if (pauto.Mode == 1)
        //    {
        //        decimal dec = (decimal)pauto.Serial;
        //        dec += 1;
        //        strserial = dec.ToString("0000000000");
        //    }
        //    else if (pauto.Mode == 2)
        //    {
        //        decimal dec = (decimal)pauto.Serial;
        //        dec += 1;
        //        strserial = dec.ToString("0000000000");
        //        strserial = pauto.Prefix.Trim() + "-" + strserial;
        //    }
        //    else if (pauto.Mode == 3)
        //    {
        //        strserial = "";
        //    }
        //    else if (pauto.Mode == 4)
        //    {
        //        decimal dec = (decimal)pauto.Serial;
        //        dec += 1;
        //        strserial = dec.ToString("0000000000");
        //        strserial = pauto.Prefix.Trim() + "-" + commonFunctions.GlobalLocation.Trim().ToUpper() +  "-" + strserial;
        //    }
        //    return strserial;

        //}
        //public static string GetSerial(string screenname,string loca , string form)
        //{
        //    string strserial = string.Empty;

        //    P_AutoNumberDL pal = new P_AutoNumberDL();
        //    P_AutoNumber pauto = new P_AutoNumber();
        //    pauto.Screen = screenname;
        //    pauto = pal.Selectp_AutoNumber(pauto);
        //    decimal dec = (decimal)pauto.Serial;
        //    dec += 1;
        //    strserial = dec.ToString("00000000");

        //    strserial = form.Trim().ToUpper() + "-" + loca.Trim() + "-" + strserial;

        //    return strserial;

        //}


        //public static void IncrementSerial(string screenname)
        //{
        //    P_AutoNumberDL pal = new P_AutoNumberDL();
        //    P_AutoNumber pauto = new P_AutoNumber();
        //    pauto.Screen = screenname;
        //    pauto = pal.Selectp_AutoNumber(pauto);
        //    pauto.Serial += 1;
        //    pal.SaveP_AutoNumberSP(pauto, 3);
        //}

        //#endregion

  

        #region FormatDate

        public static DateTime FormatDate(DateTime Value)
        {
            try
            {
                return DateTime.Parse(string.Format("{0:dd/MM/yyyy}", Value));
            }
            catch (Exception ex)
            {
                return DateTime.Now;
            }
        }

        public static DateTime FormatDateTime(DateTime Value)
        {
            try
            {
                return DateTime.Parse(string.Format("{0:dd/MM/yyyy hh:mm:ss}", Value));
            }
            catch (Exception ex)
            {
                return DateTime.Now;
            }
        }

        #endregion

     

        #region validate Machine date time format
        public static bool ValidateMachineDateTimeFromat()
        {
            CultureInfo ci = CultureInfo.CurrentCulture;
            DateTimeFormatInfo dtfi = ci.DateTimeFormat;
            string[] SystemDateTimePatterns = new string[250];
            int i = 0;

            foreach (string name in dtfi.GetAllDateTimePatterns('d'))
            {
                SystemDateTimePatterns[i] = name;
                i++;
            }

            string[] myDateTimeFormat = { "dd/MM/yyyy" };
            if (!myDateTimeFormat[0].Equals(SystemDateTimePatterns[0]))
            {
                MessageBox.Show("Your Machine DateTime Format is: " + SystemDateTimePatterns[0] + ".\n" + "Required DateTime Format is: dd/MM/yyyy. \nPlease Change the Datetime Format.", "System Datetime Format", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
                return false;
            }
            else
            {
                return true;
            }
        }
        #endregion

        public  static List<Control> GetAllControls(Control container)
        {
            List<Control> ControlList = new List<Control>();
            foreach (Control c in container.Controls)
            {
                ControlList.Add(c);
                GetAllControls(c);
                //if (c is TextBox) 
            }
            return ControlList;
        }


        public static  void GetTextBoxnames(Control conx)
        {
            string path = @"D:\Out.txt";
            if (!System.IO.File.Exists(path))
            {
                System.IO.File.Create(path);
            }
            System.IO.StreamWriter sr = new System.IO.StreamWriter(path);
            sr.Flush();
            List<Control> cons = commonFunctions.GetAllControls(conx);

            foreach (Control con in cons)
            {
                if (con is TextBox)
                {
                    sr.WriteLine(con.Name + @".Text = "";");
                }
            }
            sr.Close();
        }
    }
}
