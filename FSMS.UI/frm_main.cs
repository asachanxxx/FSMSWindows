#region MEnu Item names
/*
 A1000- Company
A1001 - Customers
A1002 - Fuel Types
A1003 - RF ID
A1004 - Employee
A1005 - Sales Types
A1007 - Tanks
A1008 - Pump Manager
A1009 - Vehicles

A2000 - Day Start
A2001 - Pump Status
A2002 - Totalizer Readings
A2003 - Daily Sales
A2004 - Payment
A2005 - DailySales summry
A2007 - Pumper salary


A3000 - Live stock
A3001 - Unloading
A3002 - Stock in out note


A4000 - System Users
A4001 - Security Center
A4002 - Change password



 */
#endregion

using FSMS.Common;
using FSMS.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FSMS.UI
{
    public partial class frm_main : Form
    {

        #region Loading one instance

        private static frm_main objSingleObject = null;

        /// <summary>
        /// Singleton object creation method
        /// </summary>
        /// <returns>object of a frmM_Supplier</returns>
        public static frm_main getSingleton()
        {
            if (objSingleObject == null || objSingleObject.IsDisposed)
            {
                objSingleObject = new frm_main();
                //objSingleObject.WindowState = FormWindowState.Maximized;
                //objSingleObject.Text = commonFunctions.Softwarename.Trim();

            }
            return objSingleObject;

        }

        #endregion

        public frm_main()
        {
            InitializeComponent();
        }

        private void frm_main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to Exit", Messaging.MessageCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (Application.OpenForms.Count > 0)
                {
                    if (Application.OpenForms["frm_login"] !=null)
                    Application.OpenForms["frm_login"].Close();
                }
                e.Cancel = false;
            }
        }

        private void frm_main_FormClosed(object sender, FormClosedEventArgs e)
        {
          
        }

        private void frm_main_Load(object sender, EventArgs e)
        {
            try
            {
                

                //MessageBox.Show(this.tbl_status.Text.Length.ToString());
                MenuStripItemsVisible();
                this.WindowState = FormWindowState.Maximized;
                this.Text = commonFunctions.Softwarename.Trim();

                //txt_loginuser.Text = "Login User: ".ToUpper() + commonFunctions.Loginuser.Trim();
                //txt_date.Text = "SYstem Date: ".ToUpper() + DateTime.Now.Date.ToShortDateString().ToString();

                tbl_loginuser.Text = LoggedDetails.Loginuser.Trim().ToUpper();
                tbl_date.Text = DateTime.Now.Date.ToShortDateString().ToString();
                tbl_Time.Text = DateTime.Now.Date.ToShortTimeString().ToString();
                //FormatMenuItems();
                //timer1.Enabled = true;



                //tbl_status.Text = "Cannot login the system".ToUpper();
                commonFunctions.SetMDIStatusMessage("Ready", 2);

            }
            catch (Exception ex)
            {
                //LogFile.WriteErrorLog(System.Reflection.MethodBase.GetCurrentMethod().Name, this.Name, ex.Message.ToString(), "Exception");

            }
        }

        private void MenuStripItemsVisible()
        {
            SecurityRepository repo = new SecurityRepository();
            DataTable dtAllMenuItems = repo.CreateDataTable(repo.GetUserRights(LoggedDetails.LoggedUserId));




            if (LoggedDetails.Loginuser.Trim().ToUpper() != "ADMIN")
            {

                if (dtAllMenuItems.Rows.Count != 0)
                {
                    for (int i = 0; i < dtAllMenuItems.Rows.Count; i++)
                    {
                        if (Convert.ToBoolean(dtAllMenuItems.Rows[i]["dtAccess"].ToString()) == false)
                        {
                            string strEditUIName = (dtAllMenuItems.Rows[i]["Code"].ToString()).Replace(" ", "");
                            string strtlStrpMenuItemName = strEditUIName;
                            List<ToolStripMenuItem> myItems = GetItems(this.menuStrip);
                            foreach (var item in myItems)
                            {
                                item.ForeColor = Color.RoyalBlue;
                                item.Text = item.Text.ToUpper();
                                if (item.Name == strtlStrpMenuItemName)
                                {
                                    item.Enabled = false;

                                }

                            }
                            //List<ToolStripMenuItem> tootlstrips = GetItems(this.toolStrip);
                            foreach (ToolStripItem ctrl in this.toolStrip.Items)
                            {
                                //listBox1.Items.Add(ctrl.Name);
                                ctrl.Text = ctrl.Text.ToUpper();
                                if (ctrl.Name.Trim().ToUpper() == "T" + strtlStrpMenuItemName.Trim().ToUpper())
                                {
                                    ctrl.Enabled = false;

                                }
                            }

                            //foreach (ToolStripItem ctrl in this.contextMenuStrip1.Items)
                            //{
                            //    //listBox1.Items.Add(ctrl.Name);
                            //    ctrl.Text = ctrl.Text.ToUpper();
                            //    ctrl.ForeColor = Color.RoyalBlue;
                            //    if (ctrl.Name.Trim().ToUpper() == "C" + strtlStrpMenuItemName.Trim().ToUpper())
                            //    {
                            //        ctrl.Enabled = false;

                            //    }
                            //}
                        }


                        else
                        {
                            string strEditUIName = (dtAllMenuItems.Rows[i]["Code"].ToString()).Replace(" ", "");
                            string strtlStrpMenuItemName = strEditUIName;
                            List<ToolStripMenuItem> myItems = GetItems(this.menuStrip);
                            foreach (var item in myItems)
                            {
                                item.ForeColor = Color.RoyalBlue;
                                item.Text = item.Text.ToUpper();
                                if (item.Name == strtlStrpMenuItemName)
                                {
                                    item.Enabled = true;

                                }

                            }
                            //List<ToolStripMenuItem> tootlstrips = GetItems(this.toolStrip);
                            foreach (ToolStripItem ctrl in this.toolStrip.Items)
                            {
                                //listBox1.Items.Add(ctrl.Name);
                                ctrl.ForeColor = Color.RoyalBlue;
                                ctrl.Text = ctrl.Text.ToUpper();
                                if (ctrl.Name.Trim().ToUpper() == "T" + strtlStrpMenuItemName.Trim().ToUpper())
                                {
                                    ctrl.Enabled = true;

                                }
                            }

                            //foreach (ToolStripItem ctrl in this.contextMenuStrip1.Items)
                            //{
                            //    //listBox1.Items.Add(ctrl.Name);
                            //    ctrl.Text = ctrl.Text.ToUpper();
                            //    ctrl.ForeColor = Color.RoyalBlue;
                            //    if (ctrl.Name.Trim().ToUpper() == "C" + strtlStrpMenuItemName.Trim().ToUpper())
                            //    {
                            //        ctrl.Enabled = true;

                            //    }
                            //}
                        }
                    }
                }
                else
                {
                    //implement locking system

                }

            }
            else
            {

                // if login user is administrator

            }
        }//end

        public static List<ToolStripMenuItem> GetItems(MenuStrip menuStrip)
        {
            List<ToolStripMenuItem> myItems = new List<ToolStripMenuItem>();
            foreach (ToolStripMenuItem i in menuStrip.Items)
            {
                i.ForeColor = Color.RoyalBlue;
                GetMenuItems(i, myItems);
            }
            return myItems;
        }
        private static void GetMenuItems(ToolStripMenuItem item, List<ToolStripMenuItem> items)
        {
            items.Add(item);
            foreach (ToolStripItem i in item.DropDownItems)
            {
                if (i is ToolStripMenuItem)
                {
                    GetMenuItems((ToolStripMenuItem)i, items);

                }
            }
        }

        private void A0001_Click(object sender, EventArgs e)
        {
            frm_salestypes objSupp = frm_salestypes.getSingleton();
            objSupp.MdiParent = this;
            objSupp.Activate();
            objSupp.Show();
        }

        private void A0011_Click(object sender, EventArgs e)
        {
            frm_employees objSupp = frm_employees.getSingleton();
            objSupp.MdiParent = this;
            objSupp.Activate();
            objSupp.Show();
        }

        private void A0009_Click(object sender, EventArgs e)
        {
            frm_fueltypes objSupp = frm_fueltypes.getSingleton();
            objSupp.MdiParent = this;
            objSupp.Activate();
            objSupp.Show();
        }

        private void A0013_Click(object sender, EventArgs e)
        {
            PumpManager objSupp = PumpManager.getSingleton();
            objSupp.MdiParent = this;
            objSupp.Activate();
            objSupp.Show();
        }

        private void tanksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_tanks objSupp = frm_tanks.getSingleton();
            objSupp.MdiParent = this;
            objSupp.Activate();
            objSupp.Show();
        }

        private void A0007_Click(object sender, EventArgs e)
        {
            frmcustomers objSupp = frmcustomers.getSingleton();
            objSupp.MdiParent = this;
            objSupp.Activate();
            objSupp.Show();
            
            
        }

        private void A0012_Click(object sender, EventArgs e)
        {
            frm_rfcards objSupp = frm_rfcards.getSingleton();
            objSupp.MdiParent = this;
            objSupp.Activate();
            objSupp.Show();
        }

        private void A0003_Click(object sender, EventArgs e)
        {
            frm_shifts objSupp = frm_shifts.getSingleton();
            objSupp.MdiParent = this;
            objSupp.Activate();
            objSupp.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void receiptToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frm_totalizerReadings objSupp = frm_totalizerReadings.getSingleton();
            objSupp.MdiParent = this;
            objSupp.Activate();
            objSupp.Show();
        }

        private void TA0007_Click(object sender, EventArgs e)
        {
            A0007_Click(sender, e);
        }

        private void TA1009_Click(object sender, EventArgs e)
        {
            A0007_Click(sender, e);
        }

        private void A1009_Click(object sender, EventArgs e)
        {

        }

        private void TA1003_Click(object sender, EventArgs e)
        {
            A0012_Click(sender, e);
        }

        private void TA1008_Click(object sender, EventArgs e)
        {
            A0013_Click(sender, e);
        }

        private void TA1004_Click(object sender, EventArgs e)
        {
            A0011_Click(sender, e);
        }

        private void TA2000_Click(object sender, EventArgs e)
        {
            A2000_Click(sender, e);
        }

        private void A2000_Click(object sender, EventArgs e)
        {
            frm_daystart objSupp = frm_daystart.getSingleton();
            objSupp.MdiParent = this;
            objSupp.Activate();
            objSupp.Show();
        }

        private void A2001_Click(object sender, EventArgs e)
        {
            PumpStatus objSupp = PumpStatus.getSingleton();
            objSupp.MdiParent = this;
            objSupp.Activate();
            objSupp.Show();
        }

        private void TA2001_Click(object sender, EventArgs e)
        {
            A2001_Click(sender, e);
        }

        private void A2003_Click(object sender, EventArgs e)
        {
            frm_dailySalesMain objSupp = frm_dailySalesMain.getSingleton();
            objSupp.MdiParent = this;
            objSupp.Activate();
            objSupp.Show();
        }

        private void TA2003_Click(object sender, EventArgs e)
        {
            A2003_Click(sender, e);
        }

        private void A2004_Click(object sender, EventArgs e)
        {

        }

        private void TA2004_Click(object sender, EventArgs e)
        {
            A2004_Click(sender, e);
        }

        private void A3001_Click(object sender, EventArgs e)
        {
            frm_grn objSupp = frm_grn.getSingleton();
            objSupp.MdiParent = this;
            objSupp.Activate();
            objSupp.Show();
        }

        private void TA3001_Click(object sender, EventArgs e)
        {
            A3001_Click(sender, e);
        }

        private void A3000_Click(object sender, EventArgs e)
        {
            frm_TankStockLive objSupp = frm_TankStockLive.getSingleton();
            objSupp.MdiParent = this;
            objSupp.Activate();
            objSupp.Show();
        }

        private void TA3000_Click(object sender, EventArgs e)
        {
            A3000_Click(sender, e);
        }

        private void A2007_Click(object sender, EventArgs e)
        {

        }

        private void TA2007_Click(object sender, EventArgs e)
        {
            A2007_Click(sender, e);
        }

        private void A4003_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void A4004_Click(object sender, EventArgs e)
        {

        }
    }
}
