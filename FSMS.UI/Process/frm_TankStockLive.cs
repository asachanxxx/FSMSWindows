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
    public partial class frm_TankStockLive : Form
    {

        DataTable dt = new DataTable();

        #region Loading one instance

        private static frm_TankStockLive objSingleObject = null;

        /// <summary>
        /// Singleton object creation method
        /// </summary>
        /// <returns>object of a frmM_Supplier</returns>
        public static frm_TankStockLive getSingleton()
        {
            if (objSingleObject == null || objSingleObject.IsDisposed)
            {
                objSingleObject = new frm_TankStockLive();

            }
            return objSingleObject;

        }

        #endregion

        public frm_TankStockLive()
        {
            InitializeComponent();
        }

        private void frm_TankStockLive_Load(object sender, EventArgs e)
        {
            try
            {

                //LoadDays();
                LoadTanks();
                //pnl_header.BackColor = commonFunctions.PanelHeaderBackGroundColor;
                pnl_header.ForeColor = commonFunctions.PanelHeaderForColor;
                pnl_footer.BackColor = commonFunctions.PanelHeaderBackGroundColor;
                pnl_footer.ForeColor = Color.Black;

                lbl_headerpaneltext.Text = "Live Tank Stock".ToUpper();

                this.WindowState = FormWindowState.Maximized;
                this.Text = "Live Tank Stock";

                commonFunctions.FormatDataGrid(dgmain);
                dgmain.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
                dgmain.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;

                dt.Columns.Add(new DataColumn("Id", typeof(int)));
                dt.Columns.Add(new DataColumn("Name", typeof(string)));
                dt.Columns.Add(new DataColumn("Reading", typeof(decimal)));

                dgmain.DataSource = dt;

                dgmain.Columns[0].Width = 50;
                dgmain.Columns[1].Width = 140;
                dgmain.Columns[2].Width = 120;

                dgmain.Columns[0].ReadOnly = true;
                dgmain.Columns[1].ReadOnly = true;
                //dgmain.Columns[2].DefaultCellStyle.BackColor = Color.FromArgb(13, 71, 161);
                //dgmain.Columns[2].DefaultCellStyle.ForeColor = Color.White;

              

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Has found in program. Please forword following details to technical" + Environment.NewLine + "[" + ex.Message + Environment.NewLine + ex.Source + "]", Messaging.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }


      

        private void LoadTanks()
        {
            try
            {
                var tanks = CustomeRepository.GetAllTanks();
                foreach (var item in tanks)
                {
                    string name = item.TankName;
                    ListViewItem itm = new ListViewItem(name);
                    itm.Tag = item;
                    itm.ImageIndex = 0;
                    lst_nozzels.Items.Add(itm);
                }

            }
            catch (Exception ex) { }
        }

        private void lst_nozzels_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lst_nozzels.SelectedItems.Count > 0) {
                dt.Rows.Clear();
                var selectedtank = (Tank)lst_nozzels.SelectedItems[0].Tag;
                lbl_innerdia.Text= selectedtank.InnerDiameter.ToString();
                lbl_len.Text = selectedtank.Length.ToString();
                lbl_capacity.Text = selectedtank.Capacity.ToString();
                lbl_stock.Text = selectedtank.CurrentSIH.ToString();


                lst_nos.Items.Clear();
                var tanks = CustomeRepository.GetNozzelsOFTanks(selectedtank.Id);
                foreach (var item in tanks)
                {
                    DataRow drow = dt.NewRow();
                    drow[0] = item.Id;
                    drow[1] = item.NozzelName;
                    drow[2] = 0.00;
                    string name = item.NozzelName;
                    ListViewItem itm = new ListViewItem(name + Environment.NewLine + item.LastTotalizerReading.ToString());
                    itm.Tag = item;
                    itm.ImageIndex = 0;
                    lst_nos.Items.Add(itm);
                    dt.Rows.Add(drow);
                }
                

            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
