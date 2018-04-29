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
    public partial class frmcustomers : Form
    {

        private string _formHeadertext;
        private RepositoryBase<Customer> repo;

        #region Loading one instance

        private static frmcustomers objSingleObject = null;

        /// <summary>
        /// Singleton object creation method
        /// </summary>
        /// <returns>object of a frmM_Supplier</returns>
        public static frmcustomers getSingleton()
        {
            if (objSingleObject == null || objSingleObject.IsDisposed)
            {
                objSingleObject = new frmcustomers();

            }
            return objSingleObject;

        }

        #endregion


        public frmcustomers()
        {
            InitializeComponent();
        }

        private void frmcustomers_Load(object sender, EventArgs e)
        {
            try
            {
                repo = new RepositoryBase<Customer>("Customers");
                //LoadCustomers();
                lbl_id.Text = "-1";
                pnl_header.BackColor = commonFunctions.PanelHeaderBackGroundColor;
                pnl_header.ForeColor = commonFunctions.PanelHeaderForColor;
                pnl_footer.BackColor = commonFunctions.PanelHeaderBackGroundColor;
                pnl_footer.ForeColor = Color.Black;

                lbl_headerpaneltext.Text = "Customers".ToUpper();

                this.WindowState = FormWindowState.Maximized;
                this.Text = "Customers";
                commonFunctions.FormatDataGrid(dgmain);
                commonFunctions.FormatDataGrid(dgmain);

                GetData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Has found in program. Please forword following details to technical" + Environment.NewLine + "[" + ex.Message + Environment.NewLine + ex.Source + "]", Messaging.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void GetData()
        {
            try
            {
                dgmain.AutoGenerateColumns = false;
                List<Customer> stl = repo.GetAll().ToList();
                if (stl != null)
                {
                    dgmain.DataSource = stl;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Has found when loading data. Please forword following details to technical" + Environment.NewLine + "[" + ex.Message + Environment.NewLine + ex.Source + "]", Messaging.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void ValidateInput()
        {
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(txt_cuscode.Text.Trim()))
            {
                string error = "Customer Code Cannot be a empty value";
                MessageBox.Show(error, Messaging.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider1.SetError(txt_cuscode, error);
                return;
            }

            if (string.IsNullOrEmpty(txt_name.Text.Trim()))
            {
                string error = "Customer Name Cannot be a empty value";
                MessageBox.Show(error, Messaging.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider1.SetError(txt_name, error);
                return;
            }


        }



        private void btn_save_Click(object sender, EventArgs e)
        {
            ValidateInput();
            Customer type = new Customer();
            type.Id = int.Parse(lbl_id.Text.Trim());
            type.Address1 = txt_add1.Text.Trim();
            type.Address2 = txt_add2.Text.Trim();
            type.Address3 = txt_add3.Text.Trim();
            type.ChequeBalance = 0;
            type.ChequeLimit = 0;
            type.ContactPersonName = txt_conper.Text.Trim();
            type.CreditLimit = txt_crelimit.Value;
            type.CustomerCode = txt_cuscode.Text.Trim().ToUpper();
            type.CustomerImage = "";
            type.CustomerName = txt_name.Text.Trim();
            type.CustomerStatus = 1;
            type.CustomerTitle = 1;
            type.CustomerType = 1;
            type.DataTransfer = 1;
            type.Email = txt_email.Text.Trim();
            type.Gender = 1;
            type.Outstanding = txt_outstnd.Value;
            type.OutstandingAlertLimit = txt_outstndingalert.Value;
            type.Rating = commonFunctions.ToInt(txt_ratings.Value.ToString());
            type.Remark = txt_remarks.Text.Trim();
            type.TPno = txt_tp.Text;
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

        private void btn_update_Click(object sender, EventArgs e)
        {
            ValidateInput();
            Customer type = new Customer();
            type.Id = int.Parse(lbl_id.Text.Trim());
            type.Address1 = txt_add1.Text.Trim();
            type.Address2 = txt_add2.Text.Trim();
            type.Address3 = txt_add3.Text.Trim();
            type.ChequeBalance = 0;
            type.ChequeLimit = 0;
            type.ContactPersonName = txt_conper.Text.Trim();
            type.CreditLimit = txt_crelimit.Value;
            type.CustomerCode = txt_cuscode.Text.Trim().ToUpper();
            type.CustomerImage = "";
            type.CustomerName = txt_name.Text.Trim();
            type.CustomerStatus = 1;
            type.CustomerTitle = 1;
            type.CustomerType = 1;
            type.DataTransfer = 1;
            type.Email = txt_email.Text.Trim();
            type.Gender = 1;
            type.Outstanding = txt_outstnd.Value;
            type.OutstandingAlertLimit = txt_outstndingalert.Value;
            type.Rating = commonFunctions.ToInt(txt_ratings.Value.ToString());
            type.Remark = txt_remarks.Text.Trim();
            type.TPno = txt_tp.Text;
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
                Customer type = repo.Get(int.Parse(v.Trim()));
                if (type != null)
                {

                    lbl_id.Text = type.Id.ToString();
                    txt_name.Text = type.CustomerName;
                    txt_cuscode.Text = type.CustomerCode;
                    txt_add1.Text = type.Address1;
                    txt_add2.Text = type.Address2;
                    txt_add3.Text = type.Address3;
                    txt_tp.Text = type.TPno;
                    txt_email.Text = type.Email;
                    txt_outstnd.Value = type.Outstanding;
                    txt_outstndingalert.Value = type.OutstandingAlertLimit;
                    txt_crelimit.Value = type.CreditLimit;
                    txt_ratings.Value = type.Rating;




                }
            }
            catch (Exception ex)
            {
            }
        }
    }
}
