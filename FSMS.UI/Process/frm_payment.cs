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

namespace FSMS.UI.Process
{
    public partial class frm_payment : Form
    {

        List<ReceiptDet> Details = new List<ReceiptDet>();
        List<TwoKeyOnject> listoffuels = new List<TwoKeyOnject>();
        string documentno;
        #region Loading one instance

        private static frm_payment objSingleObject = null;

        /// <summary>
        /// Singleton object creation method
        /// </summary>
        /// <returns>object of a frmM_Supplier</returns>
        public static frm_payment getSingleton()
        {
            if (objSingleObject == null || objSingleObject.IsDisposed)
            {
                objSingleObject = new frm_payment();

            }
            return objSingleObject;

        }

        #endregion
        public frm_payment()
        {
            InitializeComponent();
        }

        private void frm_payment_Load(object sender, EventArgs e)
        {
            try
            {


                LoadCustomers();
                LoadPayTypes();
                LoadBanks();
               
                pnl_header.BackColor = commonFunctions.PanelHeaderBackGroundColor;
                pnl_header.ForeColor = commonFunctions.PanelHeaderForColor;
                pnl_footer.BackColor = commonFunctions.PanelHeaderBackGroundColor;
                pnl_footer.ForeColor = Color.Black;

                lbl_headerpaneltext.Text = "Customer Payment".ToUpper();

                this.WindowState = FormWindowState.Maximized;
                this.Text = "Customer Payment";
                commonFunctions.FormatDataGrid(dgmain);

                panel6.Size = new Size(569, 86);
                panel6.Location = new Point(3, 222);
                Details.Clear();
                dgmain.AutoGenerateColumns = false;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Has found in program. Please forword following details to technical" + Environment.NewLine + "[" + ex.Message + Environment.NewLine + ex.Source + "]", Messaging.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void LoadBanks()
        {
            try
            {
                var listoffuels = KeyValueRepository.GetBanks().ToList();
                if (listoffuels.Count > 0)
                {
                    txt_BANK.DataSource = listoffuels;
                    txt_BANK.DisplayMember = "Name";
                    txt_BANK.ValueMember = "Id";
                    txt_BANK.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Has found when loading data. Please forword following details to technical" + Environment.NewLine + "[" + ex.Message + Environment.NewLine + ex.Source + "]", Messaging.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        private void LoadBankBranches()
        {
            try
            {
                var listoffuels = KeyValueRepository.GetBankBranches("001").ToList();
                if (listoffuels.Count > 0)
                {
                    txt_branch.DataSource = listoffuels;
                    txt_branch.DisplayMember = "Name";
                    txt_branch.ValueMember = "Id";
                    txt_branch.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Has found when loading data. Please forword following details to technical" + Environment.NewLine + "[" + ex.Message + Environment.NewLine + ex.Source + "]", Messaging.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void LoadPayTypes()
        {
            try
            {
                listoffuels = KeyValueRepository.GetPayTypes().ToList();
                if (listoffuels.Count > 0)
                {
                    cmb_paycode.DataSource = listoffuels;
                    cmb_paycode.DisplayMember = "Name";
                    cmb_paycode.ValueMember = "Id1";
                    cmb_paycode.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Has found when loading data. Please forword following details to technical" + Environment.NewLine + "[" + ex.Message + Environment.NewLine + ex.Source + "]", Messaging.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void LoadCustomers()
        {
            try
            {
                List<KeyValue> listoffuels = KeyValueRepository.GetCustomers().ToList();
                if (listoffuels.Count > 0)
                {
                    cmb_customer.DataSource = listoffuels;
                    cmb_customer.DisplayMember = "Name";
                    cmb_customer.ValueMember = "Id";
                    cmb_customer.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Has found when loading data. Please forword following details to technical" + Environment.NewLine + "[" + ex.Message + Environment.NewLine + ex.Source + "]", Messaging.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void LoadCustomerDetails()
        {

        }


        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            LoadCustomerOutstandings();
        }

        private void LoadCustomerOutstandings()
        {
            if (cmb_customer.SelectedValue != null)
            {
                Customer cus = new Customer();
                cus = CustomeRepository.GetCustomerDetails(commonFunctions.ToInt(cmb_customer.SelectedValue.ToString()));
                lbl_creditLinit.Text = cus.CreditLimit.ToString();
                lbl_limitAlert.Text = cus.OutstandingAlertLimit.ToString();
                lbl_cqlimit.Text = cus.ChequeLimit.ToString();
                lbl_cqbalance.Text = cus.ChequeBalance.ToString();
                lbl_rank.Text = "RANK-" + cus.Rating.ToString();
                lbl_outstandings.Text = cus.Outstanding.ToString();
            }
        }

        private void cmb_paycode_KeyDown(object sender, KeyEventArgs e)
        {
            if (cmb_paycode.SelectedValue != null)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txt_amt.Focus();
                }
            }

        }

        private void txt_amt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Calculate();

            }

        }

        private void Calculate()
        {
            errorProvider1.Clear();
            if (num_totalpay.Value <= 0)
            {
                // MessageBox.Show("Paied amount must be grater than zero" , Messaging.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider1.SetError(num_totalpay, "Paied amount must be grater than zero");
                return;
            }
            decimal paiedamt = GetTotalGridValue();
            decimal payment = commonFunctions.ToDecimal(txt_amt.Text.Trim());
            decimal total = num_totalpay.Value;

            if ((paiedamt + payment) > total)
            {
                errorProvider1.SetError(txt_amt, "Over payment not suported");
                return;
            }
            MakeRecord(payment, total);

            paiedamt = GetTotalGridValue();
            decimal remain = total - (paiedamt);

            txt_remaining.Text = remain.ToString();
            cmb_paycode.Focus();

        }

        private void MakeRecord(decimal payment, decimal total)
        {
            try
            {
                ReceiptDet det = new ReceiptDet();
                int commingpaycode = commonFunctions.ToInt(cmb_paycode.SelectedValue.ToString());
                dgmain.DataSource = null;
                if (Details.Find(x => x.Paytype == commingpaycode) != null)
                {
                    det = Details.Find(x => x.Paytype == commingpaycode);
                }

                det.cancelledDate = DateTime.Now;
                det.cancelledId = 0;
                det.CQDate = dte_CQDate.Value;
                det.CQNo = txt_CQNO.Text;
                det.CustomerId = commonFunctions.ToInt(cmb_customer.SelectedValue.ToString());
                det.HeadAmt = total;
                det.HedId = 0;
                det.Id = 0;
                det.iscancelled = false;
                det.IsReconsile = false;
                det.IsReturned = false;
                det.PaiedAmt = payment;
                det.Paytype = commonFunctions.ToInt(cmb_paycode.SelectedValue.ToString());
                det.PaytypeDesc = cmb_paycode.Text;
                det.ReasonToReturn = "";
                det.ReconsileDate = DateTime.Now;
                det.ReconsiledUserId = 0;
                det.RecordDate = DateTime.Now;
                det.ReferanceID = 0;
                det.ReturnedDate = DateTime.Now;
                det.ReturneddUserId = 0;
                det.Sequence = Details.Count + 1;



                if (Details.Find(x => x.Paytype == commingpaycode) == null)
                {
                    Details.Add(det);
                }


                dgmain.DataSource = Details;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Has found when loading data. Please forword following details to technical" + Environment.NewLine + "[" + ex.Message + Environment.NewLine + ex.Source + "]", Messaging.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private decimal GetTotalGridValue()
        {
            decimal total = decimal.Zero;
            foreach (var item in Details)
            {
                total += item.PaiedAmt;
            }
            return total;
        }

        private void txt_amt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                 (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            documentno = CustomeRepository.GetSetDocumentNumber("SC002", 0, "RCT", 1);
            txt_recno.Text = documentno;
            LoadCustomerOutstandings();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (txt_recno.Text.Trim() == "")
            {
                errorProvider1.SetError(txt_recno, "Reciept no cannot be a empty value. Press New button.");
                MessageBox.Show("Reciept no cannot be a empty value. Press New button.", Messaging.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (num_totalpay.Value <= 0)
            {
                errorProvider1.SetError(num_totalpay, "Reciept amount must grator than zero.");
                MessageBox.Show("Reciept amount must grator than zero.", Messaging.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Details.Count <= 0)
            {
                errorProvider1.SetError(dgmain, "Reciept breakdown must be entred.");
                MessageBox.Show("Reciept breakdown must be entred.", Messaging.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //if (txt_recivedfrom.Text.Trim() == "")
            //{
            //    MessageBox.Show("Recieved from cannot be a empty value.", Messaging.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            //if (txt_memo.Text.Trim() == "")
            //{
            //    MessageBox.Show("Memo cannot be a empty value.", Messaging.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            if (commonFunctions.ToDecimal(txt_remaining.Text) != 0)
            {
                errorProvider1.SetError(dgmain, "You must break the full amount.");
                MessageBox.Show("You must break the full amount.", Messaging.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Do you want to Save this record?", Messaging.MessageCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    ReceiptHed hed = new ReceiptHed();
                    hed.Amount = num_totalpay.Value;
                    hed.CancelledDate = DateTime.Now;
                    hed.CancelledReason = "";
                    hed.CancelledUser = 0;
                    hed.CustomerId = commonFunctions.ToInt(cmb_customer.SelectedValue.ToString());
                    hed.Docno = txt_recno.Text;
                    hed.Id = 0;
                    hed.iscancelled = false;
                    hed.IsGLUpdate = false;
                    hed.IsProcessed = false;
                    hed.Memo = txt_memo.Text;
                    hed.processDate = DateTime.Now;
                    hed.ProcessUserID = 0;
                    hed.ReceiptDets = Details;
                    hed.Recivedfrom = txt_recivedfrom.Text;
                    hed.RecordDate = DateTime.Now;
                    hed.ReferanceNo =1;
                    hed.Remarks = txt_Remarks.Text;
                    hed.Status = 1;

                    CustomeRepository.InsertReciept(hed);

                    Details = null;
                    dgmain.Rows.Clear();
                    documentno = CustomeRepository.GetSetDocumentNumber("SC002", 0, "RCT", 1);
                    txt_recno.Text = documentno;
                    LoadCustomerOutstandings();
                }
                catch (Exception ex) { }

            }
        }

        private void cmb_paycode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listoffuels.Count > 0) {
                if (cmb_paycode.SelectedValue != null) {
                    var xxx = (TwoKeyOnject)cmb_paycode.SelectedItem;
                    var value = listoffuels.Find(x => x.Id1 == xxx.Id1);//commonFunctions.ToInt(cmb_paycode.SelectedValue.ToString()));
                    if ((bool)value.Value)
                    {
                        panel6.Visible = true;
                    }
                    else {
                        panel6.Visible = false;
                    }
                }
                
            }
        }

        private void btn_cqclose_Click(object sender, EventArgs e)
        {
            panel6.Hide();
        }

        private void btn_cqadd_Click(object sender, EventArgs e)
        {
          
            Calculate();
            txt_CQNO.Text = "";
            panel6.Hide();
          
        }

        private void txt_BANK_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txt_BANK.SelectedValue != null) {
               LoadBankBranches();
            }
        }
    }
}
