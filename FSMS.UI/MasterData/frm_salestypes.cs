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
    public partial class frm_salestypes : Form
    {
        private string _formHeadertext;
        private DataTable dtx;
        private RepositoryBase<SalesType> repo;

        #region Loading one instance

        private static frm_salestypes objSingleObject = null;

        /// <summary>
        /// Singleton object creation method
        /// </summary>
        /// <returns>object of a frmM_Supplier</returns>
        public static frm_salestypes getSingleton()
        {
            if (objSingleObject == null || objSingleObject.IsDisposed)
            {
                objSingleObject = new frm_salestypes();

            }
            return objSingleObject;

        }

        #endregion


        public frm_salestypes()
        {
            InitializeComponent();
            
        }

        private void frm_salestypes_Load(object sender, EventArgs e)
        {
            try
            {
                repo = new RepositoryBase<SalesType>("SalesTypes");
                lbl_id.Text = "-1";
                pnl_header.BackColor = commonFunctions.PanelHeaderBackGroundColor;
                pnl_header.ForeColor = commonFunctions.PanelHeaderForColor;
                pnl_footer.BackColor = commonFunctions.PanelHeaderBackGroundColor;
                pnl_footer.ForeColor = Color.Black;

                lbl_headerpaneltext.Text = "Sales Types".ToUpper();

                this.WindowState = FormWindowState.Maximized;
                this.Text = "Sales Types";
                commonFunctions.FormatDataGrid(dgmain);
                commonFunctions.FormatDataGrid(dgmain);

                dtx = CreateDatatable();
                dgmain.DataSource = dtx;
                GetData();
            }
            catch (Exception ex) {
                MessageBox.Show("Error Has found in program. Please forword following details to technical" + Environment.NewLine + "["+ ex.Message + Environment.NewLine + ex.Source + "]", Messaging.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }

        }

        private void GetData()
        {
            List<SalesType> stl = repo.GetAll().ToList();
            if (stl != null)
            {
                dgmain.DataSource = stl;
                dgmain.Columns[0].HeaderText = "#";
                dgmain.Columns[1].HeaderText = "Sales Type Code";
                dgmain.Columns[2].HeaderText = "Sales Type Name";
                dgmain.Columns[0].Width = 50;
                dgmain.Columns[1].Width = 150;
                dgmain.Columns[2].Width = 300;
            }
        }

        public static DataTable CreateDatatable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("#");
            dt.Columns.Add("Sales Type Code");
            dt.Columns.Add("Sales Type Name");
            return dt;
        }


        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            ValidateInput();
            SalesType type = new SalesType();
            type.Id = int.Parse(lbl_id.Text.Trim());
            type.Code = txt_code.Text.Trim().ToUpper();
            type.Name = txt_des.Text.Trim();

            if (CheckExistingRepository.CheckForExistingSalesType(txt_code.Text.Trim().ToUpper()))
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
                string error = "Sales type Code Cannot be a empty value";
                MessageBox.Show(error, Messaging.MessageCaption,MessageBoxButtons.OK,MessageBoxIcon.Error);
                errorProvider1.SetError(txt_code, error);
                return;
            }
            if (string.IsNullOrEmpty(txt_des.Text.Trim()))
            {
                string error = "Sales type description Cannot be a empty value";
                MessageBox.Show(error, Messaging.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider1.SetError(txt_des, error);
                return;
            }

        }

        private void dgmain_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgmain.Rows[e.RowIndex].IsNewRow == false)
            {
                NavigateDataGrid(dgmain.Rows[e.RowIndex].Cells[0].Value.ToString().Trim());
            }
        }

        private void NavigateDataGrid(string v)
        {
            SalesType type = repo.Get(int.Parse(v.Trim()));
            if (type != null) {

                lbl_id.Text = type.Id.ToString();
                txt_code.Text = type.Code;
                txt_des.Text = type.Name;
            }
        }
    }
}
