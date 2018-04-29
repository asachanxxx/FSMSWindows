using FSMS.Common;
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
    public partial class frm_grn : Form
    {

        #region Loading one instance

        private static frm_grn objSingleObject = null;

        /// <summary>
        /// Singleton object creation method
        /// </summary>
        /// <returns>object of a frmM_Supplier</returns>
        public static frm_grn getSingleton()
        {
            if (objSingleObject == null || objSingleObject.IsDisposed)
            {
                objSingleObject = new frm_grn();

            }
            return objSingleObject;

        }

        #endregion



        public frm_grn()
        {
            InitializeComponent();
        }

        private void frm_grn_Load(object sender, EventArgs e)
        {
            try
            {

                //LoadDays();
                //LoadTanks();
                //pnl_header.BackColor = commonFunctions.PanelHeaderBackGroundColor;
                pnl_header.ForeColor = commonFunctions.PanelHeaderForColor;
                pnl_footer.BackColor = commonFunctions.PanelHeaderBackGroundColor;
                pnl_footer.ForeColor = Color.Black;

                lbl_headerpaneltext.Text = "Fuel GRN".ToUpper();

                this.WindowState = FormWindowState.Maximized;
                this.Text = "Fuel GRN";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Has found in program. Please forword following details to technical" + Environment.NewLine + "[" + ex.Message + Environment.NewLine + ex.Source + "]", Messaging.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
