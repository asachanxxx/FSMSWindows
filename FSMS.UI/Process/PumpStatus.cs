using FSMS.Common;
using FSMS.Domain;
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
    public partial class PumpStatus : Form
    {

        #region Loading one instance

        private static PumpStatus objSingleObject = null;

        /// <summary>
        /// Singleton object creation method
        /// </summary>
        /// <returns>object of a frmM_Supplier</returns>
        public static PumpStatus getSingleton()
        {
            if (objSingleObject == null || objSingleObject.IsDisposed)
            {
                objSingleObject = new PumpStatus();

            }
            return objSingleObject;

        }

        #endregion

        List<DailyAssignWorkerDetails> DailyAssignWorkerDetailList;

        public PumpStatus()
        {
            InitializeComponent();
        }

        private void PumpStatus_Load(object sender, EventArgs e)
        {
            try
            {

                DailyAssignWorkerDetailList = new List<DailyAssignWorkerDetails>();
                pnl_collection.Hide();
                pnl_collection.Size = new Size(764, 378);
                LoadVehicles();
                LoadDays();
                LoadPumper();
                LoadPumper1();
                LoadBanks();
                //lbl_id.Text = "-1";
                pnl_header.BackColor = commonFunctions.PanelHeaderBackGroundColor;
                pnl_header.ForeColor = commonFunctions.PanelHeaderForColor;
                pnl_footer.BackColor = commonFunctions.PanelHeaderBackGroundColor;
                pnl_footer.ForeColor = Color.Black;

                lbl_headerpaneltext.Text = "Daily Sales".ToUpper();
                commonFunctions.FormatDataGrid(dgmain);
                this.WindowState = FormWindowState.Maximized;
                this.Text = "Daily Sales";
                UpdateReleventBoxes();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Has found in program. Please forword following details to technical" + Environment.NewLine + "[" + ex.Message + Environment.NewLine + ex.Source + "]", Messaging.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void RefreshDailyAssignWorkerDetailList(int did)
        {
            lst_nozzels.Clear();
            DailyAssignWorkerDetailList.Clear();
            DailyAssignWorkerDetailList = CustomeRepository.GetDailyAssignWorkerDetails(did).ToList();

            foreach (var item in DailyAssignWorkerDetailList)
            {
                string empname = "";
                string activetext = "";
              
                ListViewItem itm = new ListViewItem();
                if (item.IsOpen)
                {
                    activetext = "Open";
                    itm.ImageIndex = 0;
                    if (string.IsNullOrEmpty(item.EmployeeName))
                    {
                        empname = "Not Assigned";
                    }
                    else
                    {
                        empname = item.EmployeeName;
                    }
                }
                else
                {
                    activetext = "Closed";
                    itm.ImageIndex = 1;
                }

                string name = item.NozzelName + Environment.NewLine + empname + Environment.NewLine + activetext;
                itm.Text = name;
                itm.Tag = item;
                lst_nozzels.Items.Add(itm);
            }
        }





        private void LoadVehicles()
        {
            List<KeyValue> listoffuels = KeyValueRepository.GetVehicles().ToList();
            if (listoffuels.Count > 0)
            {
                cmb_Vehicles.DataSource = listoffuels;
                cmb_Vehicles.DisplayMember = "Name";
                cmb_Vehicles.ValueMember = "Id";
                cmb_Vehicles.SelectedIndex = 0;
            }

        }
        private void LoadDays()
        {
            List<KeyValue> listoffuels = KeyValueRepository.GetDays().ToList();
            if (listoffuels.Count > 0)
            {
                cmb_days.DataSource = listoffuels;
                cmb_days.DisplayMember = "Name";
                cmb_days.ValueMember = "Id";
                cmb_days.SelectedIndex = 0;
            }

        }
        private void LoadPumper()
        {
            List<KeyValue> listoffuels = KeyValueRepository.GetPumpers().ToList();
            if (listoffuels.Count > 0)
            {
                cmb_pumper.DataSource = listoffuels;
                cmb_pumper.DisplayMember = "Name";
                cmb_pumper.ValueMember = "Id";
                cmb_pumper.SelectedIndex = 0;
            }

        }
        private void LoadBanks()
        {
            List<KeyValue> listoffuels = KeyValueRepository.GetBanks().ToList();
            if (listoffuels.Count > 0)
            {
                cmb_bank.DataSource = listoffuels;
                cmb_bank.DisplayMember = "Name";
                cmb_bank.ValueMember = "Id";
                cmb_bank.SelectedIndex = 0;
            }

        }



        private void LoadPumper1()
        {
            List<KeyValue> listoffuels = KeyValueRepository.GetPumpers().ToList();
            if (listoffuels.Count > 0)
            {
                cmb_pumperForcashcol.DataSource = listoffuels;
                cmb_pumperForcashcol.DisplayMember = "Name";
                cmb_pumperForcashcol.ValueMember = "Id";
                cmb_pumperForcashcol.SelectedIndex = 0;
            }

        }

        private void cmb_pumper_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cmb_days_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmb_Nozzels.Focus();
        }

        private void lst_nozzels_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lst_nozzels.SelectedItems.Count > 0)
            {
                DoNozzelSelectedThings(lst_nozzels.SelectedItems[0]);
            }
        }

        private void DoNozzelSelectedThings(ListViewItem item)
        {
            try
            {
                num_EndTotalizer.Enabled = true;
                DailyAssignWorkerDetails det = (DailyAssignWorkerDetails)item.Tag;
                PumpClosing close = CustomeRepository.GetPumpClosingDetails(det.DayID, det.PumperID, true, det.NozzelID);

                cmb_pumper.SelectedValue = det.PumperID;
                lbl_selectedPumper.Text = det.EmployeeName;

                if (close != null)
                {
                    if (close.IsProcessed)
                    {
                        num_EndTotalizer.Enabled = false;
                    }
                }

                if (det != null)
                {
                    cmb_Nozzels.Text = det.NozzelName;
                    num_starttotalizer.Value = det.LastTotalizerReading;
                    num_EndTotalizer.Value = det.LastTotalizerReading;
                    num_Price.Value = det.UnitPrice;
                }

                if (item != null)
                {
                    string empname = "";

                    if (string.IsNullOrEmpty(det.EmployeeName))
                    {
                        empname = "Not Assigned";
                    }
                    else
                    {
                        empname = det.EmployeeName;

                        if (close != null)
                        {
                            num_EndTotalizer.Value = close.EndTotalizer;
                        }
                    }

                    if (det.IsOpen)
                    {
                        pnl_indicator.BackColor = Color.Green;
                        lbl_nozzsrtatus.Text = "Assigned";
                        lbl_pumpername.Text = empname;
                    }
                    else
                    {
                        pnl_indicator.BackColor = Color.Red;
                        lbl_nozzsrtatus.Text = "Closed";
                        lbl_pumpername.Text = "";
                    }
                    lbl_totalizer.Text = det.LastTotalizerReading.ToString();
                    lbl_tank.Text = det.TankName;
                    lbl_NozzelName.Text = det.NozzelName;
                    lbl_fueltype.Text = det.FuelFullName;
                    lbl_unitprice.Text = det.UnitPrice.ToString();

                }


                //update pump close status
            }
            catch (Exception ex) {
            }
        }

        private void btn_assignPumper_Click(object sender, EventArgs e)
        {
            if (lst_nozzels.SelectedItems.Count > 0)
            {
                DailyAssignWorkerDetails det = (DailyAssignWorkerDetails)lst_nozzels.SelectedItems[0].Tag;
                if (commonFunctions.ToInt(cmb_pumper.SelectedValue.ToString()) > 0)
                {
                    string message = CustomeRepository.AssignPumperToNozzel(det.DayID, commonFunctions.ToInt(cmb_pumper.SelectedValue.ToString()), det.NozzelID, det.DayWorkerID);
                    if (cmb_days.SelectedValue != null)
                    {
                        try
                        {
                            RefreshDailyAssignWorkerDetailList(commonFunctions.ToInt(cmb_days.SelectedValue.ToString()));
                            MessageBox.Show(message, Messaging.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, Messaging.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }

                    }

                }

            }
        }

        private void cmb_pumperForcashcol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_pumperForcashcol.SelectedValue != null && commonFunctions.ToInt(cmb_pumperForcashcol.SelectedValue.ToString()) > 0)
            {
                UpdateReleventBoxes();
                LoadExistingCollection();
                GetTotalForPumperForGivenDay(1);
            }
        }

        private void LoadExistingCollection()
        {
            // throw new NotImplementedException();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (commonFunctions.ToInt(cmb_pumperForcashcol.SelectedValue.ToString()) >= 0)
                {
                    if (MessageBox.Show("Do you want to Save this record?", Messaging.MessageCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        CustomeRepository.InsertTotalCashCollection(
                            commonFunctions.ToInt(cmb_pumperForcashcol.SelectedValue.ToString()),
                            commonFunctions.ToInt(cmb_pumperForcashcol.SelectedValue.ToString()),
                            num_cashtotal.Value,
                            num_cardtotal.Value,
                            num_VoucherTotal.Value,
                            num_expensetotal.Value
                            );
                        MessageBox.Show("Successfully Saved the record", Messaging.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting the record..", Messaging.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_savecashDet_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to Save this record?", Messaging.MessageCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    CustomeRepository.InsertCollectionBreakdown(
                       num_amount.Value,
                        commonFunctions.ToInt(cmb_days.SelectedValue.ToString()),
                        commonFunctions.ToInt(cmb_pumperForcashcol.SelectedValue.ToString()), 0,
                        commonFunctions.ToInt(cmb_Vehicles.SelectedValue.ToString()),
                        commonFunctions.ToInt(lbl_salesID.Text.ToString()),
                        txt_creditcardNo.Text,
                         txt_voucherNo.Text.Trim(),
                         commonFunctions.ToInt(cmb_bank.SelectedValue.ToString()),
                         1,
                         0
                        );

                   
                    GetTotalForPumperForGivenDay(commonFunctions.ToInt(lbl_salesID.Text.ToString()));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Has found when Saving data. Please forword following details to technical" + Environment.NewLine + "[" + ex.Message + Environment.NewLine + ex.Source + "]", Messaging.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void UpdateReleventBoxes()
        {
            //getCashValueforthis
            int dayid = commonFunctions.ToInt(cmb_days.SelectedValue.ToString());
            int pumperid = commonFunctions.ToInt(cmb_pumperForcashcol.SelectedValue.ToString());

            DayPumperSaleTypeSummry sumary = new DayPumperSaleTypeSummry();
            sumary = CustomeRepository.GetTotalForEachPumperForGivenDay(dayid, pumperid);

            //num_cardtotal.Enabled = true;
            //num_VoucherTotal.Enabled = true;
            //num_expensetotal.Enabled = true;

            num_cardtotal.Value = sumary.Cardtotal;
            num_VoucherTotal.Value = sumary.Vouchertotal;
            num_expensetotal.Value = sumary.Expensetotal;

            //if (sumary.Cardtotal > 0)
            //{
            //    num_cardtotal.Enabled = false;
            //}
            //if (sumary.Vouchertotal > 0)
            //{
            //    num_VoucherTotal.Enabled = false;
            //}
            //if (sumary.Expensetotal > 0)
            //{
            //    num_expensetotal.Enabled = false;
            //}

        }

        private void btn_cashcolupdate_Click(object sender, EventArgs e)
        {

            try
            {
                if (commonFunctions.ToInt(lbl_breakdid.Text.ToString()) <= 0){
                    MessageBox.Show("Please select a record to delete" , Messaging.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (MessageBox.Show("Do you want to Delete this record?", Messaging.MessageCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    CustomeRepository.RemoveCollectionBreakdown(commonFunctions.ToInt(lbl_breakdid.Text.ToString()));
                    GetTotalForPumperForGivenDay(commonFunctions.ToInt(lbl_salesID.Text.ToString()));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Has found when Saving data. Please forword following details to technical" + Environment.NewLine + "[" + ex.Message + Environment.NewLine + ex.Source + "]", Messaging.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            //
        }

     

        private void GetTotalForPumperForGivenDay(int saletypeid)
        {
            try
            {
                //Disable Auto Gen Columns
                dgmain.AutoGenerateColumns = false;
                int dayid = commonFunctions.ToInt(cmb_days.SelectedValue.ToString());
                int pumperid = commonFunctions.ToInt(cmb_pumperForcashcol.SelectedValue.ToString());
                List<PumperForGivenDayCollectionDetails> dets = new List<PumperForGivenDayCollectionDetails>();
                //getting newly inserted values for day to pump and sales type
                dets = CustomeRepository.PumperForGivenDayCollectionDetails(dayid, pumperid, saletypeid).ToList();
                //Show it in dgrid
                dgmain.DataSource = dets;

                //update summary values
                DayPumperSaleTypeSummry sumary = new DayPumperSaleTypeSummry();
                sumary = CustomeRepository.GetTotalForEachPumperForGivenDay(dayid, pumperid);
                //assign total value on main window
                num_cashtotal.Value = sumary.Cashtotal;
                num_cardtotal.Value = sumary.Cardtotal;
                num_VoucherTotal.Value = sumary.Vouchertotal;
                num_expensetotal.Value = sumary.Expensetotal;
                num_testingtotal.Value = sumary.TestingTotal;
                //Initialize Value for breakdown
                num_amount.Value = 0;
                txt_creditcardNo.Text = "";
                txt_rfcardno.Text = "";
                txt_voucherNo.Text = "";

                //assign total value on breakdown screen
                switch (saletypeid)
                {
                    case 2:
                        lbl_total.Text = sumary.Cardtotal.ToString();
                        break;
                    case 3:
                        lbl_total.Text = sumary.Vouchertotal.ToString();
                        break;
                    case 4:
                        lbl_total.Text = sumary.Expensetotal.ToString();
                        break;
                    case 5:
                        lbl_total.Text = sumary.TestingTotal.ToString();
                        break;
                    default:
                        lbl_total.Text = "0.00";
                        break;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Has found when loading data. Please forword following details to technical" + Environment.NewLine + "[" + ex.Message + Environment.NewLine + ex.Source + "]", Messaging.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        /*///////////////////// All breakdowns Handling Area //////////////////////////////////////////*/

        //Cash total
        private void btn_insertCash_Click(object sender, EventArgs e)
        {
            lbl_salesID.Text = 1.ToString();
            try
            {
                if (MessageBox.Show("Do you want to Save this record?", Messaging.MessageCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    CustomeRepository.InsertCollectionBreakdown(
                       num_cashtotal.Value,
                        commonFunctions.ToInt(cmb_days.SelectedValue.ToString()),
                        commonFunctions.ToInt(cmb_pumperForcashcol.SelectedValue.ToString()), 0,
                        commonFunctions.ToInt(cmb_Vehicles.SelectedValue.ToString()),
                        1, //sales type,
                        txt_creditcardNo.Text,
                         txt_voucherNo.Text.Trim(),
                         commonFunctions.ToInt(cmb_bank.SelectedValue.ToString()),
                         1,
                         0
                        );


                    GetTotalForPumperForGivenDay(commonFunctions.ToInt(lbl_salesID.Text.ToString()));

                    LogRepository.Log("Cash Collection Manual Change To : " + num_cashtotal.Value.ToString(), LogType.Log,commonFunctions.LoginuserID);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Has found when Saving data. Please forword following details to technical" + Environment.NewLine + "[" + ex.Message + Environment.NewLine + ex.Source + "]", Messaging.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        //Card total
        private void btn_hasbreakCardTotal_Click(object sender, EventArgs e)
        {
            GetTotalForPumperForGivenDay(2);

            lbl_colelctiontypes.Text = "Credit/Debit Cards";
            lbl_salesID.Text = 2.ToString();
            pnl_collection.Show();

            txt_creditcardNo.Enabled = true;
            txt_voucherNo.Text = "N/A";
            txt_voucherNo.Enabled = false;
            txt_rfcardno.Text = "N/A";
            txt_rfcardno.Enabled = false;
            cmb_Vehicles.Enabled = false;

        }
        //Voucher total
        private void btn_hasbreakvouche_Click(object sender, EventArgs e)
        {
            GetTotalForPumperForGivenDay(3);
            lbl_colelctiontypes.Text = "Credit Vouchers";
            lbl_salesID.Text = 3.ToString();
            pnl_collection.Show();

            txt_voucherNo.Enabled = true;
            txt_creditcardNo.Text = "N/A";
            txt_creditcardNo.Enabled = false;
            cmb_bank.Enabled = false;
            cmb_Vehicles.Enabled = true;
        }
        //Expense total
        private void btn_hasbreakExpense_Click(object sender, EventArgs e)
        {
            GetTotalForPumperForGivenDay(4);
            lbl_colelctiontypes.Text = "Expenses";
            lbl_salesID.Text = 4.ToString();

            pnl_collection.Show();
            txt_voucherNo.Text = "N/A";
            txt_voucherNo.Enabled = false;
            txt_rfcardno.Text = "N/A";
            txt_rfcardno.Enabled = false;
            txt_creditcardNo.Text = "N/A";
            txt_creditcardNo.Enabled = false;
            cmb_bank.Enabled = false;
            cmb_Vehicles.Enabled = false;
        }

        //Testing total
        private void btn_hasbreakTesting_Click(object sender, EventArgs e)
        {
            GetTotalForPumperForGivenDay(5);

            lbl_colelctiontypes.Text = "Testing";
            lbl_salesID.Text = 5.ToString();
            pnl_collection.Show();
            txt_voucherNo.Text = "N/A";
            txt_voucherNo.Enabled = false;
            txt_rfcardno.Text = "N/A";
            txt_rfcardno.Enabled = false;
            txt_creditcardNo.Text = "N/A";
            txt_creditcardNo.Enabled = false;
            cmb_bank.Enabled = false;
            cmb_Vehicles.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pnl_collection.Hide();
        }

        private void lbl_close_Click(object sender, EventArgs e)
        {
            pnl_collection.Hide();
        }

        private void num_EndTotalizer_ValueChanged(object sender, EventArgs e)
        {
            CalculatePumpClosing();
        }

        private void CalculatePumpClosing()
        {
            if (lst_nozzels.SelectedItems.Count > 0)
            {
                DailyAssignWorkerDetails det = (DailyAssignWorkerDetails)lst_nozzels.SelectedItems[0].Tag;
                if (det != null)
                {
                    cmb_Nozzels.Text = det.NozzelName;
                    num_starttotalizer.Value = det.LastTotalizerReading;
                    num_Price.Value = det.UnitPrice;

                    decimal fuelqty = num_EndTotalizer.Value - det.LastTotalizerReading;
                    decimal totalfuelvalue = fuelqty * det.UnitPrice;

                    num_Vriance.Value = fuelqty;
                    num_totalFUelval.Value = totalfuelvalue;

                }
            }
            else
            {
                MessageBox.Show("Please Select a nozzel To close", Messaging.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int dayid = commonFunctions.ToInt(cmb_days.SelectedValue.ToString());
                int pumperid = commonFunctions.ToInt(cmb_pumperForcashcol.SelectedValue.ToString());
                DailyAssignWorkerDetails det = (DailyAssignWorkerDetails)lst_nozzels.SelectedItems[0].Tag;
                if (det != null) {
                    CustomeRepository.InsetPumpClosing(
                        dayid,
                        pumperid,
                        det.NozzelID,
                        num_workedHours.Value,
                        num_starttotalizer.Value,
                        num_EndTotalizer.Value,
                        num_EndTotalizer.Value - num_starttotalizer.Value,
                        num_Price.Value,
                        (num_EndTotalizer.Value - num_starttotalizer.Value) * num_Price.Value,
                        det.SeqNo
                     );

                    if (cmb_days.SelectedValue != null)
                    {

                        RefreshDailyAssignWorkerDetailList(commonFunctions.ToInt(cmb_days.SelectedValue.ToString()));
                    }

                    lbl_pumpername.Text = "(....)";
                    lbl_pumpername.Text = "(....)";
                    pnl_indicator.BackColor = Color.Red;
                    lbl_nozzsrtatus.Text = "Closed";
                } else {
                    MessageBox.Show("Please select a one nozzel from the list for closing" , Messaging.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Has found when loading data. Please forword following details to technical" + Environment.NewLine + "[" + ex.Message + Environment.NewLine + ex.Source + "]", Messaging.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            if (cmb_days.SelectedValue != null)
            {

                RefreshDailyAssignWorkerDetailList(commonFunctions.ToInt(cmb_days.SelectedValue.ToString()));
            }
        }

        private void dgmain_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgmain.Rows[e.RowIndex].IsNewRow == false)
            {
                lbl_breakdid.Text = dgmain.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
              var values =   LogRepository.GetSystenLog(LogType.Log, commonFunctions.LoginuserID);


            }
            catch (Exception ex) {
            }
        }
    }
}
