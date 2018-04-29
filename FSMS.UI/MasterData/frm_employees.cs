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
    public partial class frm_employees : Form
    {

        private string _formHeadertext;
        private DataTable dtx;
        private RepositoryBase<Employee> repo;

        #region Loading one instance

        private static frm_employees objSingleObject = null;

        /// <summary>
        /// Singleton object creation method
        /// </summary>
        /// <returns>object of a frmM_Supplier</returns>
        public static frm_employees getSingleton()
        {
            if (objSingleObject == null || objSingleObject.IsDisposed)
            {
                objSingleObject = new frm_employees();

            }
            return objSingleObject;

        }

        #endregion


        public frm_employees()
        {
            InitializeComponent();
        }

        private void frm_employees_Load(object sender, EventArgs e)
        {
            try
            {
                repo = new RepositoryBase<Employee>("Employees");
                lbl_id.Text = "-1";
                pnl_header.BackColor = commonFunctions.PanelHeaderBackGroundColor;
                pnl_header.ForeColor = commonFunctions.PanelHeaderForColor;
                pnl_footer.BackColor = commonFunctions.PanelHeaderBackGroundColor;
                pnl_footer.ForeColor = Color.Black;

                lbl_headerpaneltext.Text = "Employees".ToUpper();

                this.WindowState = FormWindowState.Maximized;
                this.Text = "Employees";
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
            dgmain.AutoGenerateColumns = false;
            List<Employee> stl = repo.GetAll().ToList();
            if (stl != null && stl.Count>0)
            {
                dgmain.DataSource = stl;
                dgmain.Columns[0].Width = 20;
            }
        }
        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(txt_code.Text.Trim()))
            {
                string error = "Employee Code Cannot be a empty value";
                MessageBox.Show(error, Messaging.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider1.SetError(txt_code, error);
                return;
            }

            if (string.IsNullOrEmpty(txt_name.Text.Trim()))
            {
                string error = "Employee Name Cannot be a empty value";
                MessageBox.Show(error, Messaging.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider1.SetError(txt_name, error);
                return;
            }
            Employee type = new Employee();
            type.Id = int.Parse(lbl_id.Text.Trim());
            type.OtRate = txt_otrate.Value;
            type.CreditLimit = txt_creditlimit.Value;
            type.HorlyRate = txt_hrate.Value;
            type.CashInHand = txt_cih.Value;
            type.SpecialHorlyRate = txt_shr.Value;
            type.OutStanding = txt_outst.Value;
            type.Settlement = txt_settle.Value;
            type.SpecialOtRate = txt_sotrate.Value;
            type.EmployeeCode = txt_code.Text.Trim();
            type.EmployeeName = txt_name.Text.Trim();
            type.Passcode = txt_passcode.Text;
            type.Telephone = txt_homepn.Text;
            type.GroupOfCompanyID = 1;
            type.ModifiedUser = commonFunctions.LoginuserID;
            type.ModifiedDate = DateTime.Now;
            type.CreatedUser = commonFunctions.LoginuserID;
            type.CreatedDate = DateTime.Now;
            type.DataTransfer = 1;
            type.Mobile = txt_mobile.Text;
            type.IsPumper = chk_ispumper.Checked;
            if (MessageBox.Show("Do you want to insert this record?", Messaging.MessageCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                repo.Save(type);
                GetData();
            }
        }



        private void btn_delete_Click(object sender, EventArgs e)
        {

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(txt_code.Text.Trim()))
            {
                string error = "Employee Code Cannot be a empty value";
                MessageBox.Show(error, Messaging.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider1.SetError(txt_code, error);
                return;
            }

            if (string.IsNullOrEmpty(txt_name.Text.Trim()))
            {
                string error = "Employee Name Cannot be a empty value";
                MessageBox.Show(error, Messaging.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider1.SetError(txt_name, error);
                return;
            }
            Employee type = new Employee();
            type.Id = int.Parse(lbl_id.Text.Trim());
            type.OtRate = txt_otrate.Value;
            type.CreditLimit = txt_creditlimit.Value;
            type.HorlyRate = txt_hrate.Value;
            type.CashInHand = txt_cih.Value;
            type.SpecialHorlyRate = txt_shr.Value;
            type.OutStanding = txt_outst.Value;
            type.Settlement = txt_settle.Value;
            type.SpecialOtRate = txt_sotrate.Value;
            type.EmployeeCode = txt_code.Text.Trim();
            type.EmployeeName = txt_name.Text.Trim();
            type.Passcode = txt_passcode.Text;
            type.Telephone = txt_homepn.Text;
            type.GroupOfCompanyID = 1;
            type.ModifiedUser = commonFunctions.LoginuserID;
            type.ModifiedDate = DateTime.Now;
            type.CreatedUser = commonFunctions.LoginuserID;
            type.CreatedDate = DateTime.Now;
            type.DataTransfer = 1;
            type.Mobile = txt_mobile.Text;
            type.IsPumper = chk_ispumper.Checked;
            if (MessageBox.Show("Do you want to update this record?", Messaging.MessageCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                repo.Update(type);
                GetData();
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
            try
            {
                Employee type = repo.Get(int.Parse(v.Trim()));
                if (type != null)
                {

                    lbl_id.Text = type.Id.ToString();
                    txt_name.Text = type.EmployeeName;
                    txt_code.Text = type.EmployeeCode;
                    txt_passcode.Text = type.Passcode;
                    txt_homepn.Text = type.Telephone;
                    txt_mobile.Text = type.Mobile;

                    txt_cih.Value = type.CashInHand;
                    txt_creditlimit.Value = type.CreditLimit;
                    txt_outst.Value = type.OutStanding;
                    txt_settle.Value = type.Settlement;
                    txt_hrate.Value = type.HorlyRate;
                    txt_shr.Value = type.SpecialHorlyRate;
                    txt_otrate.Value = type.OtRate;
                    txt_sotrate.Value = type.SpecialOtRate;
                    chk_ispumper.Checked = type.IsPumper;

                }
            }
            catch (Exception ex)
            {
            }
        }
    }
}
