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
    public partial class frm_DailySales : Form
    {


        private RepositoryBase<Tank> repo;

        #region Loading one instance

        private static frm_DailySales objSingleObject = null;

        /// <summary>
        /// Singleton object creation method
        /// </summary>
        /// <returns>object of a frmM_Supplier</returns>
        public static frm_DailySales getSingleton()
        {
            if (objSingleObject == null || objSingleObject.IsDisposed)
            {
                objSingleObject = new frm_DailySales();

            }
            return objSingleObject;

        }

        #endregion

        public frm_DailySales()
        {
            InitializeComponent();
        }

        private void frm_DailySales_Load(object sender, EventArgs e)
        {
            try
            {
                repo = new RepositoryBase<Tank>("Tanks");
                //LoadFuels();
                lbl_id.Text = "-1";
                pnl_header.BackColor = commonFunctions.PanelHeaderBackGroundColor;
                pnl_header.ForeColor = commonFunctions.PanelHeaderForColor;
                pnl_footer.BackColor = commonFunctions.PanelHeaderBackGroundColor;
                pnl_footer.ForeColor = Color.Black;

                lbl_headerpaneltext.Text = "Daily Sales".ToUpper();

                this.WindowState = FormWindowState.Maximized;
                this.Text = "Daily Sales";
                //commonFunctions.FormatDataGrid(dgmain);
                commonFunctions.FormatDataGrid(dgtotalizer);

                //GetData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Has found in program. Please forword following details to technical" + Environment.NewLine + "[" + ex.Message + Environment.NewLine + ex.Source + "]", Messaging.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
