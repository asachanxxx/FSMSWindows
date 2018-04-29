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
    public partial class frm_fueltypes : Form
    {

        private string _formHeadertext;
        private DataTable dtx;
        private RepositoryBase<FuelType> repo;

        #region Loading one instance

        private static frm_fueltypes objSingleObject = null;

        /// <summary>
        /// Singleton object creation method
        /// </summary>
        /// <returns>object of a frmM_Supplier</returns>
        public static frm_fueltypes getSingleton()
        {
            if (objSingleObject == null || objSingleObject.IsDisposed)
            {
                objSingleObject = new frm_fueltypes();

            }
            return objSingleObject;

        }

        #endregion

        public frm_fueltypes()
        {
            InitializeComponent();
        }

        private void frm_fueltypes_Load(object sender, EventArgs e)
        {

            try
            {
                repo = new RepositoryBase<FuelType>("FuelTypes");
                lbl_id.Text = "-1";
                pnl_header.BackColor = commonFunctions.PanelHeaderBackGroundColor;
                pnl_header.ForeColor = commonFunctions.PanelHeaderForColor;
                pnl_footer.BackColor = commonFunctions.PanelHeaderBackGroundColor;
                pnl_footer.ForeColor = Color.Black;

                lbl_headerpaneltext.Text = "Fuel Types".ToUpper();

                this.WindowState = FormWindowState.Maximized;
                this.Text = "Fuel Types";
                commonFunctions.FormatDataGrid(dgmain);
                commonFunctions.FormatDataGrid(dgmain);

                dtx = CreateDatatable();
                dgmain.DataSource = dtx;
                GetData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Has found in program. Please forword following details to technical" + Environment.NewLine + "[" + ex.Message + Environment.NewLine + ex.Source + "]", Messaging.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void GetData()
        {
            try
            {
                List<FuelType> stl = repo.GetAll().ToList();
                if (stl != null)
                {
                    dgmain.DataSource = stl;
                    dgmain.Columns[0].HeaderText = "#";
                    dgmain.Columns[1].HeaderText = "Fuel Code";
                    dgmain.Columns[2].HeaderText = "Fuel Name";
                    dgmain.Columns[3].HeaderText = "Fuel Price";
                    dgmain.Columns[0].Width = 50;
                    dgmain.Columns[1].Width = 250;
                    dgmain.Columns[2].Width = 100;

                    for (int i = 4; i < dgmain.Columns.Count; i++)
                    {
                        dgmain.Columns[i].Visible = false;
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Error Has found when loading data. Please forword following details to technical" + Environment.NewLine + "[" + ex.Message + Environment.NewLine + ex.Source + "]", Messaging.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public static DataTable CreateDatatable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("#");
            dt.Columns.Add("Fuel Code");
            dt.Columns.Add("Fuel Name");
            dt.Columns.Add("Fuel Price");
            return dt;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            ValidateInput();
            FuelType type = new FuelType();
            type.Id = int.Parse(lbl_id.Text.Trim());
            type.FuelShortName = txt_code.Text.Trim().ToUpper();
            type.FuelFullName = txt_name.Text.Trim();
            type.UnitPrice = txt_price.Value;
            type.GroupOfCompanyID = 1;
            type.ModifiedUser = commonFunctions.LoginuserID;
            type.ModifiedDate = DateTime.Now;
            type.CreatedUser = commonFunctions.LoginuserID;
            type.CreatedDate = DateTime.Now;
            type.DataTransfer = 1;

            if (CheckExistingRepository.CheckForExistingFuelType(txt_name.Text.Trim().ToUpper()))
            {
                if (MessageBox.Show("Do you want to update this record?", Messaging.MessageCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    repo.Update(type);
                    GetData();
                }
            }
            else
            {
                if (MessageBox.Show("Do you want to insert this record?", Messaging.MessageCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    repo.Save(type);
                    GetData();
                }
            }
        }

        private void ValidateInput()
        {
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(txt_code.Text.Trim()))
            {
                string error = "Fuel Code Cannot be a empty value";
                MessageBox.Show(error, Messaging.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider1.SetError(txt_name, error);
                return;
            }
            if (string.IsNullOrEmpty(txt_name.Text.Trim()))
            {
                string error = "Fuel description Cannot be a empty value";
                MessageBox.Show(error, Messaging.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider1.SetError(txt_name, error);
                return;
            }

        }

        private void NavigateDataGrid(string v)
        {
            try
            {
                FuelType type = repo.Get(int.Parse(v.Trim()));
                if (type != null)
                {

                    lbl_id.Text = type.Id.ToString();
                    txt_name.Text = type.FuelShortName;
                    txt_name.Text = type.FuelFullName;
                    txt_price.Value = type.UnitPrice;
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void dgmain_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgmain.Rows[e.RowIndex].IsNewRow == false)
            {
                NavigateDataGrid(dgmain.Rows[e.RowIndex].Cells[0].Value.ToString().Trim());
            }
        }
    }
}
