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
    public partial class CustomerBalanceReport : Form
    {

        private RepositoryBase<Customer> repo;

        #region Loading one instance

        private static CustomerBalanceReport objSingleObject = null;

        /// <summary>
        /// Singleton object creation method
        /// </summary>
        /// <returns>object of a frmM_Supplier</returns>
        public static CustomerBalanceReport getSingleton()
        {
            if (objSingleObject == null || objSingleObject.IsDisposed)
            {
                objSingleObject = new CustomerBalanceReport();

            }
            return objSingleObject;

        }

        #endregion

        public CustomerBalanceReport()
        {
            InitializeComponent();
        }

        private void CustomerBalanceReport_Load(object sender, EventArgs e)
        {
            try
            {

                repo = new RepositoryBase<Customer>("DayMasters");
                pnl_header.BackColor = commonFunctions.PanelHeaderBackGroundColor;
                pnl_header.ForeColor = commonFunctions.PanelHeaderForColor;
                pnl_footer.BackColor = commonFunctions.PanelHeaderBackGroundColor;
                pnl_footer.ForeColor = Color.Black;

                lbl_headerpaneltext.Text = "Start Day".ToUpper();

                this.WindowState = FormWindowState.Maximized;
                this.Text = "Start Day";
                LoadCustomers();
                //LoadPumper();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Has found in program. Please forword following details to technical" + Environment.NewLine + "[" + ex.Message + Environment.NewLine + ex.Source + "]", Messaging.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }


        private void LoadCustomers()
        {
            List<KeyValue> listoffuels = KeyValueRepository.GetCustomers().ToList();
            if (listoffuels.Count > 0)
            {
                cmb_customers.DataSource = listoffuels;
                cmb_customers.DisplayMember = "Name";
                cmb_customers.ValueMember = "Id";
                cmb_customers.SelectedIndex = 0;
            }

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PrintDoc()
        {
            if (cmb_customers.SelectedValue == null)
            {
                MessageBox.Show("Please select a customer to continue", Messaging.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string reporttitle = "";
         
            reporttitle = "Customer Balance Report".ToUpper();
          

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

            Rpt_CustomerBalanceReport rptBank = new Rpt_CustomerBalanceReport();
            rptBank.SetDataSource(ReportRepository.GetCustomerBalance(commonFunctions.ToInt(cmb_customers.SelectedValue.ToString())));
            rpt.RepViewer.ParameterFieldInfo = paramFields;
            rpt.RepViewer.ReportSource = rptBank;
            rpt.RepViewer.Refresh();
            rpt.MdiParent = frm_main.ActiveForm;
            rpt.Show();


        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            PrintDoc();
        }

        //CustomerBalance

    }
}
