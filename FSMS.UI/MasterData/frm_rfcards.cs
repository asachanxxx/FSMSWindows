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
    public partial class frm_rfcards : Form
    {
        private RepositoryBase<RfCardMaster> repo;

        #region Loading one instance

        private static frm_rfcards objSingleObject = null;

        /// <summary>
        /// Singleton object creation method
        /// </summary>
        /// <returns>object of a frmM_Supplier</returns>
        public static frm_rfcards getSingleton()
        {
            if (objSingleObject == null || objSingleObject.IsDisposed)
            {
                objSingleObject = new frm_rfcards();

            }
            return objSingleObject;

        }

        #endregion

        public frm_rfcards()
        {
            InitializeComponent();
        }

        private void frm_rfcards_Load(object sender, EventArgs e)
        {
            try
            {
                cmb_fueltypes.SelectedIndex = 0;
                repo = new RepositoryBase<RfCardMaster>("RfCardMasters");
                lbl_id.Text = "-1";
                pnl_header.BackColor = commonFunctions.PanelHeaderBackGroundColor;
                pnl_header.ForeColor = commonFunctions.PanelHeaderForColor;
                pnl_footer.BackColor = commonFunctions.PanelHeaderBackGroundColor;
                pnl_footer.ForeColor = Color.Black;

                lbl_headerpaneltext.Text = "Rf Cards".ToUpper();

                this.WindowState = FormWindowState.Maximized;
                this.Text = "Rf Cards";
                commonFunctions.FormatDataGrid(dgmain);
                commonFunctions.FormatDataGrid(dgmain);

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
                dgmain.AutoGenerateColumns = false;
                List<RfCardMaster> stl = repo.GetAll().ToList();
                if (stl != null)
                {
                    dgmain.DataSource = stl;
                    dgmain.Columns[0].Width = 50;
                    dgmain.Columns[1].Width = 250;
                    dgmain.Columns[2].Width = 100;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Has found when loading data. Please forword following details to technical" + Environment.NewLine + "[" + ex.Message + Environment.NewLine + ex.Source + "]", Messaging.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInput()) {
                    return;
                }
                RfCardMaster type = new RfCardMaster();
                type.Id = int.Parse(lbl_id.Text.Trim());
                type.CardNo = txt_name.Text;
                type.CardStatus = commonFunctions.ToInt(cmb_fueltypes.SelectedIndex.ToString());
                type.IssueDate = DateTime.Now;
                type.IssuedBy = commonFunctions.LoginuserID;
                type.GroupOfCompanyID = 1;
                type.ModifiedUser = commonFunctions.LoginuserID;
                type.ModifiedDate = DateTime.Now;
                type.CreatedUser = commonFunctions.LoginuserID;
                type.CreatedDate = DateTime.Now;
                type.DataTransfer = 1;

                if (MessageBox.Show("Do you want to insert this record?", Messaging.MessageCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    repo.Save(type);
                    GetData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Has found when Saving data. Please forword following details to technical" + Environment.NewLine + "[" + ex.Message + Environment.NewLine + ex.Source + "]", Messaging.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private bool ValidateInput()
        {

            bool ok = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(txt_name.Text.Trim()))
            {
                string error = "Tank Code Cannot be a empty value";
                MessageBox.Show(error, Messaging.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider1.SetError(txt_name, error);
                ok = false;
            }

            return ok;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInput())
                {
                    return;
                }
                RfCardMaster type = new RfCardMaster();
                type.Id = int.Parse(lbl_id.Text.Trim());
                type.CardNo = txt_name.Text;
                type.CardStatus = commonFunctions.ToInt(cmb_fueltypes.SelectedValue.ToString());
                type.IssueDate = DateTime.Now;
                type.IssuedBy = commonFunctions.LoginuserID;
                type.GroupOfCompanyID = 1;
                type.ModifiedUser = commonFunctions.LoginuserID;
                type.ModifiedDate = DateTime.Now;
                type.CreatedUser = commonFunctions.LoginuserID;
                type.CreatedDate = DateTime.Now;
                type.DataTransfer = 1;
                if (MessageBox.Show("Do you want to update this record?", Messaging.MessageCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    repo.Update(type);
                    GetData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Has found when Saving data. Please forword following details to technical" + Environment.NewLine + "[" + ex.Message + Environment.NewLine + ex.Source + "]", Messaging.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
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
            try
            {
                RfCardMaster type = repo.Get(int.Parse(v.Trim()));
                if (type != null)
                {

                    lbl_id.Text = type.Id.ToString();
                    txt_name.Text = type.CardNo;
                    cmb_fueltypes.SelectedIndex = type.CardStatus;

                }
            }
            catch (Exception ex)
            {
            }
        }
    }
}
