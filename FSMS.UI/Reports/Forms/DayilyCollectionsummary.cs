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
    public partial class DayilyCollectionsummary : Form
    {

        // private RepositoryBase<DayMaster> repo;
        private RepositoryBase<DayMaster> repo;

        #region Loading one instance

        private static DayilyCollectionsummary objSingleObject = null;

        /// <summary>
        /// Singleton object creation method
        /// </summary>
        /// <returns>object of a frmM_Supplier</returns>
        public static DayilyCollectionsummary getSingleton()
        {
            if (objSingleObject == null || objSingleObject.IsDisposed)
            {
                objSingleObject = new DayilyCollectionsummary();

            }
            return objSingleObject;

        }

        #endregion

        public DayilyCollectionsummary()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

     

        private void DayilyCollectionsummary_Load(object sender, EventArgs e)
        {
            try
            {
                
                repo = new RepositoryBase<DayMaster>("DayMasters");
                pnl_header.BackColor = commonFunctions.PanelHeaderBackGroundColor;
                pnl_header.ForeColor = commonFunctions.PanelHeaderForColor;
                pnl_footer.BackColor = commonFunctions.PanelHeaderBackGroundColor;
                pnl_footer.ForeColor = Color.Black;

                lbl_headerpaneltext.Text = "Start Day".ToUpper();

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
            if (chk_details.Checked) {

                PrintDoc(1, chk_filter1.Checked);
            }
            
        }
        private void PrintDoc(int typex,bool filter)
        {
            if (cmb_days.SelectedValue == null)
            {
                MessageBox.Show("Please select a day to continue", Messaging.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string reporttitle = "";
            if (typex == 1)
            {
                reporttitle = "Daily Collection Details".ToUpper();
            }
            else {
                reporttitle = "Daily Collection Summary".ToUpper();
            }
            
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



            if (typex == 1)
            {
                if (!filter)
                {
                    Rpt_dailyCollectionSummary rptBank = new Rpt_dailyCollectionSummary();
                    rptBank.SetDataSource(ReportRepository.GetDailyCollections(commonFunctions.ToInt(cmb_days.SelectedValue.ToString()), 0, 1));
                    rpt.RepViewer.ParameterFieldInfo = paramFields;
                    rpt.RepViewer.ReportSource = rptBank;
                    rpt.RepViewer.Refresh();
                    rpt.MdiParent = frm_main.ActiveForm;
                    rpt.Show();
                }
                else {
                    if (cmb_pumper.SelectedValue == null) {
                        MessageBox.Show("Please select a pumper to continue", Messaging.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    Rpt_dailyCollectionSummary rptBank = new Rpt_dailyCollectionSummary();
                    rptBank.SetDataSource(ReportRepository.GetDailyCollections(commonFunctions.ToInt(cmb_days.SelectedValue.ToString()), commonFunctions.ToInt(cmb_pumper.SelectedValue.ToString()), 2));
                    rpt.RepViewer.ParameterFieldInfo = paramFields;
                    rpt.RepViewer.ReportSource = rptBank;
                    rpt.RepViewer.Refresh();
                    rpt.MdiParent = frm_main.ActiveForm;
                    rpt.Show();
                }

            }
            else {
             
            }

        }
        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
