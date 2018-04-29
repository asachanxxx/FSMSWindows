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

        private void cmb_days_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            try
            {
                lbl_card.Text = "0.00";
                lbl_cash.Text = "0.00";
                lbl_Voucher.Text = "0.00";
                lbl_expense.Text = "0.00";
                lbl_totalValss.Text = "0.00";

                GetNozzelsForPumperOnGivenDay();
                List<DailyPumperTotal> tovals = CustomeRepository.GetDailyPumperTotal(commonFunctions.ToInt(cmb_days.SelectedValue.ToString()), commonFunctions.ToInt(cmb_pumper.SelectedValue.ToString())).ToList();
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

                TwoKeyNumer SystemTotal = CustomeRepository.GetSystemTotalForPumperForDay(commonFunctions.ToInt(cmb_days.SelectedValue.ToString()), commonFunctions.ToInt(cmb_pumper.SelectedValue.ToString()));
                if (SystemTotal != null) {
                    lbl_systemtotal.Text = SystemTotal.Value.ToString();
                }

                var dets = CustomeRepository.GetGetCollectionFOrDay_Pumper_SaleType(commonFunctions.ToInt(cmb_days.SelectedValue.ToString()), commonFunctions.ToInt(cmb_pumper.SelectedValue.ToString()), 1);
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
                    string name =  item.Name;
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
                string name =  item.SaleType + Environment.NewLine + item.Total;
                ListViewItem itm = new ListViewItem(name);
                itm.Tag = item;
                switch (item.SaleId) {
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
            try { 
            if (lst_dailydet.SelectedItems.Count > 0) {

                DailyPumperTotal tot = (DailyPumperTotal)lst_dailydet.SelectedItems[0].Tag;
                    if (tot != null)
                    {
                        lbl_totalValss.Text = tot.Total.ToString();
                        lbl_name.Text = tot.EmployeeName;
                        lbl_saletype.Text = tot.SaleType;

                        var dets = CustomeRepository.GetGetCollectionFOrDay_Pumper_SaleType(tot.DayID, tot.PumperId, tot.SaleId);
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
    }
}
