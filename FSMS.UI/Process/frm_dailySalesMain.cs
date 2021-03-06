﻿using FSMS.Common;
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
    public partial class frm_dailySalesMain : Form
    {

        private RepositoryBase<DaySaleHed> repo;

        #region Loading one instance

        private static frm_dailySalesMain objSingleObject = null;

        /// <summary>
        /// Singleton object creation method
        /// </summary>
        /// <returns>object of a frmM_Supplier</returns>
        public static frm_dailySalesMain getSingleton()
        {
            if (objSingleObject == null || objSingleObject.IsDisposed)
            {
                objSingleObject = new frm_dailySalesMain();

            }
            return objSingleObject;

        }

        #endregion

        public frm_dailySalesMain()
        {
            InitializeComponent();
        }

        private void frm_dailySalesMain_Load(object sender, EventArgs e)
        {
            try
            {

                repo = new RepositoryBase<DaySaleHed>("DaySaleHeds");
                LoadDays();
                LoadPumper();
                pnl_header.BackColor = commonFunctions.PanelHeaderBackGroundColor;
                pnl_header.ForeColor = commonFunctions.PanelHeaderForColor;
                pnl_footer.BackColor = commonFunctions.PanelHeaderBackGroundColor;
                pnl_footer.ForeColor = Color.Black;

                lbl_headerpaneltext.Text = "Daily Sales".ToUpper();

                this.WindowState = FormWindowState.Maximized;
                this.Text = "Daily Sales";
                commonFunctions.FormatDataGrid(dgmain);
                commonFunctions.FormatDataGrid(dgmain);
                if (cmb_days.SelectedValue != null)
                {
                    LoadSessions(commonFunctions.ToInt(cmb_days.SelectedValue.ToString()));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Has found in program. Please forword following details to technical" + Environment.NewLine + "[" + ex.Message + Environment.NewLine + ex.Source + "]", Messaging.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);

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
        private void LoadSessions(int dayid)
        {
            List<KeyValue> listoffuels = KeyValueRepository.GetSessions(dayid).ToList();
            if (listoffuels.Count > 0)
            {
                cmb_sessions.DataSource = listoffuels;
                cmb_sessions.DisplayMember = "Name";
                cmb_sessions.ValueMember = "Id";
                cmb_sessions.SelectedIndex = 0;
            }

        }
        private void cmb_days_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_days.SelectedValue != null)
            {
                LoadSessions(commonFunctions.ToInt(cmb_days.SelectedValue.ToString()));
            }
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            try
            {

                if (cmb_days.SelectedValue == null)
                {
                    MessageBox.Show("Please select a day to continue", Messaging.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (cmb_pumper.SelectedValue == null)
                {
                    MessageBox.Show("Please select a Pumper to continue", Messaging.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (cmb_sessions.SelectedValue == null)
                {
                    MessageBox.Show("Please select a session to continue", Messaging.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                lbl_card.Text = "0.00";
                lbl_cash.Text = "0.00";
                lbl_Voucher.Text = "0.00";
                lbl_expense.Text = "0.00";
                lbl_totalValss.Text = "0.00";

                GetNozzelsForPumperOnGivenDay();
                List<DailyPumperTotal> tovals = CustomeRepository.GetDailyPumperTotal(
                    commonFunctions.ToInt(cmb_days.SelectedValue.ToString()),
                    commonFunctions.ToInt(cmb_pumper.SelectedValue.ToString()),
                    commonFunctions.ToInt(cmb_sessions.SelectedValue.ToString())).ToList();
                if (tovals != null)
                {
                    LoadListView(tovals);
                }

                decimal totalCollection = 0;
                foreach (var item in tovals)
                {
                    totalCollection += item.Total;
                }
                lbl_totalCollection.Text = totalCollection.ToString();

                TwoKeyNumer SystemTotal = CustomeRepository.GetSystemTotalForPumperForDay(
                    commonFunctions.ToInt(cmb_days.SelectedValue.ToString()),
                    commonFunctions.ToInt(cmb_pumper.SelectedValue.ToString()),
                    commonFunctions.ToInt(cmb_sessions.SelectedValue.ToString())
                    );
                if (SystemTotal != null)
                {
                    lbl_systemtotal.Text = SystemTotal.Value.ToString();
                }
                else {
                    lbl_systemtotal.Text = "0.00";
                }

                var dets = CustomeRepository.GetGetCollectionFOrDay_Pumper_SaleType(
                    commonFunctions.ToInt(cmb_days.SelectedValue.ToString()),
                    commonFunctions.ToInt(cmb_pumper.SelectedValue.ToString()),
                    1,
                     commonFunctions.ToInt(cmb_sessions.SelectedValue.ToString())
                    );
                if (dets != null)
                {
                    lbl_cash.Text = dets.CashTotal.ToString();
                    lbl_card.Text = dets.CardTotal.ToString();
                    lbl_Voucher.Text = dets.VoucherTotal.ToString();
                    lbl_expense.Text = dets.Expenses.ToString();
                    lbl_othertotal.Text = dets.Other.ToString();
                }

                RunGetDiff();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Has found in program. Please forword following details to technical" + Environment.NewLine + "[" + ex.Message + Environment.NewLine + ex.Source + "]", Messaging.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void RunGetDiff()
        {
            decimal decSystemTotal = commonFunctions.ToDecimal(lbl_systemtotal.Text.Trim());
            decimal decTotCollection = commonFunctions.ToDecimal(lbl_totalCollection.Text.Trim());
            decimal diff = decSystemTotal - decTotCollection;
            lbl_diff.Text = diff.ToString();
        }

        private void GetNozzelsForPumperOnGivenDay()
        {
            try
            {
                var details = CustomeRepository.GetNozzelsForPumperOnGivenDay(commonFunctions.ToInt(cmb_days.SelectedValue.ToString()), commonFunctions.ToInt(cmb_pumper.SelectedValue.ToString()));
                lst_nozzels.Items.Clear();
                lst_dailydet.Items.Clear();
                dgmain.DataSource = null;
                foreach (var item in details)
                {
                    string name = item.Name;
                    ListViewItem itm = new ListViewItem(name);
                    itm.Tag = item;
                    itm.ImageIndex = 4;
                    lst_nozzels.Items.Add(itm);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Has found in program. Please forword following details to technical" + Environment.NewLine + "[" + ex.Message + Environment.NewLine + ex.Source + "]", Messaging.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void LoadListView(List<DailyPumperTotal> tovals)
        {
            lst_dailydet.Items.Clear();
            foreach (var item in tovals)
            {
                string name = item.SaleType + Environment.NewLine + item.Total;
                ListViewItem itm = new ListViewItem(name);
                itm.Tag = item;
                switch (item.SaleId)
                {
                    case 1:
                        itm.ImageIndex = 0;
                        break;
                    case 2:
                        itm.ImageIndex = 1;
                        break;
                    case 3:
                        itm.ImageIndex = 2;
                        break;
                    case 4:
                        itm.ImageIndex = 3;
                        break;
                    case 5:
                        itm.ImageIndex = 5;
                        break;
                }
                lst_dailydet.Items.Add(itm);
            }


        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lst_dailydet_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lst_dailydet.SelectedItems.Count > 0)
                {

                    DailyPumperTotal tot = (DailyPumperTotal)lst_dailydet.SelectedItems[0].Tag;
                    if (tot != null)
                    {
                        lbl_totalValss.Text = tot.Total.ToString();
                        lbl_saletype.Text = tot.SaleType;

                        var dets = CustomeRepository.GetGetCollectionFOrDay_Pumper_SaleType(tot.DayID, tot.PumperId, tot.SaleId, commonFunctions.ToInt(cmb_sessions.SelectedValue.ToString()));
                        if (dets != null)
                        {
                            dgmain.AutoGenerateColumns = false;
                            dgmain.DataSource = dets.Breaks;
                        }
                        //lbl_cash.Text = dets.CashTotal.ToString();
                        //lbl_card.Text = dets.CardTotal.ToString();
                        //lbl_Voucher.Text = dets.VoucherTotal.ToString();
                        //lbl_expense.Text = dets.Expenses.ToString();
                        //lbl_othertotal.Text = dets.Other.ToString();
                    }



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Has found in program. Please forword following details to technical" + Environment.NewLine + "[" + ex.Message + Environment.NewLine + ex.Source + "]", Messaging.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void lst_nozzels_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (CustomeRepository.IsExistsDifferentLog(
                    commonFunctions.ToInt(cmb_days.SelectedValue.ToString()),
                    commonFunctions.ToInt(cmb_sessions.SelectedValue.ToString()),
                    commonFunctions.ToInt(cmb_pumper.SelectedValue.ToString())
                    ) > 0)
                {
                    MessageBox.Show("Already Printed for this Day ,Session and pumper ", Messaging.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (MessageBox.Show("Do you want to Save and Print this record?", Messaging.MessageCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    DifferentLog log = new DifferentLog();
                    log.CardTotal = commonFunctions.ToDecimal(lbl_card.Text.Trim());
                    log.CashTotal = commonFunctions.ToDecimal(lbl_cash.Text.Trim());
                    log.VoucherTotal = commonFunctions.ToDecimal(lbl_Voucher.Text.Trim());
                    log.Expenses = commonFunctions.ToDecimal(lbl_expense.Text.Trim());
                    log.Testing = commonFunctions.ToDecimal(lbl_othertotal.Text.Trim());
                    log.DayID = commonFunctions.ToInt(cmb_days.SelectedValue.ToString());
                    log.PumperId = commonFunctions.ToInt(cmb_pumper.SelectedValue.ToString());
                    log.SessionId = commonFunctions.ToInt(cmb_sessions.SelectedValue.ToString());
                    log.SystemTotal = commonFunctions.ToDecimal(lbl_systemtotal.Text.Trim());
                    log.TotalCollection = commonFunctions.ToDecimal(lbl_totalCollection.Text.Trim());
                    log.Differences = commonFunctions.ToDecimal(lbl_diff.Text.Trim());
                    log.DiffCaculated = true;
                    log.IsFinal = true;
                    log.IgnoreDiff = chk_ignorediff.Checked;
                    log.ModifiedDate = DateTime.Now;
                    log.CreatedDate = DateTime.Now;
                    log.CreatedUser = commonFunctions.LoginuserID;
                    log.ModifiedUser = commonFunctions.LoginuserID;
                    log.DataTransfer = 1;


                    CustomeRepository.InsertSalesPrint(log);
                    string filename = PrintRepository.WriteSimpleReciept(log, cmb_pumper.Text, commonFunctions.GlobalCompany);
                    System.Diagnostics.Process.Start(filename);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Has found in program. Please forword following details to technical" + Environment.NewLine + "[" + ex.Message + Environment.NewLine + ex.Source + "]", Messaging.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_days.SelectedValue == null)
                {
                    MessageBox.Show("Please select a day to continue", Messaging.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (MessageBox.Show("Do you want to End this Day?. " +
                    Environment.NewLine +
                    "Bfore you continue please check all the pumpers details are properly entered to system" +
                    Environment.NewLine +
                    "And All the Nozzels are Close Properly."
                    , Messaging.MessageCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {


                    int x = CustomeRepository.ClosePump(commonFunctions.ToInt(cmb_days.SelectedValue.ToString()));
                    if (x > 0)
                    {
                        MessageBox.Show("Successfully End the day", Messaging.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Has found in program. Please forword following details to technical" + Environment.NewLine + "[" + ex.Message + Environment.NewLine + ex.Source + "]", Messaging.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
