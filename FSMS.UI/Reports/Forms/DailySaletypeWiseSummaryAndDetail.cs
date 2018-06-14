using CrystalDecisions.Shared;
using FSMS.Common;
using FSMS.Domain;
using FSMS.Repository;
using FSMS.UI.Process;
using FSMS.UI.Reports.RPT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FSMS.UI.Reports.Forms
{
    public partial class DailySaletypeWiseSummaryAndDetail : Form
    {

        private RepositoryBase<DayMaster> repo;
        public int options { get; set; }

        #region Loading one instance

        private static DailySaletypeWiseSummaryAndDetail objSingleObject = null;

        /// <summary>
        /// Singleton object creation method
        /// </summary>
        /// <returns>object of a frmM_Supplier</returns>
        public static DailySaletypeWiseSummaryAndDetail getSingleton()
        {
            if (objSingleObject == null || objSingleObject.IsDisposed)
            {

                objSingleObject = new DailySaletypeWiseSummaryAndDetail();

            }
            return objSingleObject;

        }

        #endregion


        public DailySaletypeWiseSummaryAndDetail()
        {
            InitializeComponent();
        }

        private void DailySaletypeWiseSummaryAndDetail_Load(object sender, EventArgs e)
        {
            try
            {

                repo = new RepositoryBase<DayMaster>("DayMasters");
                pnl_header.BackColor = commonFunctions.PanelHeaderBackGroundColor;
                pnl_header.ForeColor = commonFunctions.PanelHeaderForColor;
                pnl_footer.BackColor = commonFunctions.PanelHeaderBackGroundColor;
                pnl_footer.ForeColor = Color.Black;
                handlePAssEvents();



                this.WindowState = FormWindowState.Maximized;
                this.Text = "Start Day";
                LoadDays();
                LoadPumper();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Has found in program. Please forword following details to technical" + Environment.NewLine + "[" + ex.Message + Environment.NewLine + ex.Source + "]", Messaging.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void handlePAssEvents() {
            switch (options) {
                case 1:
                    lbl_headerpaneltext.Text = "Daily Cash Sales".ToUpper();
                    break;
                case 2:
                    lbl_headerpaneltext.Text = "Daily Card Sales".ToUpper();
                    break;
                case 3:
                    lbl_headerpaneltext.Text = "Daily Voucher Sales".ToUpper();
                    break;
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

        private void btn_print_Click(object sender, EventArgs e)
        {

            if (chk_details.Checked)
            {

                PrintDoc(1, chk_filter1.Checked);
            }
           
        }

        private void PrintDoc(int typex, bool filter)
        {
            if (cmb_days.SelectedValue == null)
            {
                MessageBox.Show("Please select a day to continue", Messaging.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string reporttitle = "";
            ReportViwer rpt = new ReportViwer();
            rpt.MdiParent = frm_main.ActiveForm;
            rpt.FormHeadertext = reporttitle;

            ParameterField paramField = new ParameterField();
            ParameterFields paramFields = new ParameterFields();
            ParameterDiscreteValue paramDiscreteValue = new ParameterDiscreteValue();

            paramFields = ReportRepository.AddCrystalParamsWithLoca(reporttitle, commonFunctions.Loginuser.ToUpper(), commonFunctions.GlobalLocation, "01", commonFunctions.GlobalCompany, commonFunctions.CompanyAddress);

            paramField.Name = "status";
            paramDiscreteValue.Value = "Original".ToUpper();
            paramField.CurrentValues.Add(paramDiscreteValue);
            paramFields.Add(paramField);


            Rpt_SalesTypeWiseSale rptBank = new Rpt_SalesTypeWiseSale();

            switch (options)
            {
                case 1:
                    reporttitle = "Daily Cash Sales".ToUpper();
                    rptBank.SetDataSource(ReportRepository.GetSalesTypeWiseDetails(commonFunctions.ToInt(cmb_days.SelectedValue.ToString()), 0, 1));
                  
                    break;
                case 2:
                    reporttitle = "Daily Card Sales".ToUpper();
                    rptBank.SetDataSource(ReportRepository.GetSalesTypeWiseDetails(commonFunctions.ToInt(cmb_days.SelectedValue.ToString()), 0, 2));

                    break;
                case 3:
                    reporttitle = "Daily Voucher Sales".ToUpper();
                    rptBank.SetDataSource(ReportRepository.GetSalesTypeWiseDetails(commonFunctions.ToInt(cmb_days.SelectedValue.ToString()), 0, 3));

                    break;
            }


            rpt.RepViewer.ParameterFieldInfo = paramFields;
            rpt.RepViewer.ReportSource = rptBank;
            rpt.RepViewer.Refresh();
            rpt.MdiParent = frm_main.ActiveForm;
            rpt.Show();

         


        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chk_cash_CheckedChanged(object sender, EventArgs e)
        {
            options = 1;
        }

        private void chk_credit_CheckedChanged(object sender, EventArgs e)
        {
            options = 2;
        }

        private void chk_voucher_CheckedChanged(object sender, EventArgs e)
        {
            options = 3;
        }
    }

}
