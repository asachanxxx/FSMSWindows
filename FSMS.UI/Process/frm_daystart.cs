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
    public partial class frm_daystart : Form
    {

        private RepositoryBase<DayMaster> repo;

        #region Loading one instance

        private static frm_daystart objSingleObject = null;

        /// <summary>
        /// Singleton object creation method
        /// </summary>
        /// <returns>object of a frmM_Supplier</returns>
        public static frm_daystart getSingleton()
        {
            if (objSingleObject == null || objSingleObject.IsDisposed)
            {
                objSingleObject = new frm_daystart();

            }
            return objSingleObject;

        }

        #endregion


        public frm_daystart()
        {
            InitializeComponent();
        }

        private void frm_daystart_Load(object sender, EventArgs e)
        {
            try
            {
                txt_daystamp.Text = GetDateStamp();
                repo = new RepositoryBase<DayMaster>("DayMasters");
                lbl_id.Text = "-1";
                pnl_header.BackColor = commonFunctions.PanelHeaderBackGroundColor;
                pnl_header.ForeColor = commonFunctions.PanelHeaderForColor;
                pnl_footer.BackColor = commonFunctions.PanelHeaderBackGroundColor;
                pnl_footer.ForeColor = Color.Black;

                lbl_headerpaneltext.Text = "Start Day".ToUpper();

                this.WindowState = FormWindowState.Maximized;
                this.Text = "Start Day";
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
                List<DayMaster> stl = repo.GetAll().ToList();
                if (stl != null)
                {
                    dgmain.DataSource = stl;
                    dgmain.Columns[0].Width = 50;
                    dgmain.Columns[1].Width = 150;
                    dgmain.Columns[2].Width = 100;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Has found when loading data. Please forword following details to technical" + Environment.NewLine + "[" + ex.Message + Environment.NewLine + ex.Source + "]", Messaging.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private string GetDateStamp() {
            return DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + DateTime.Now.Millisecond.ToString();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInput())
                {
                    return;
                }

                if (CheckForUnclosedDays()) {
                    MessageBox.Show("There is uncompleted day . Please Complete the day and retry again!.", 
                        Messaging.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //DayMaster type = new DayMaster();
                //type.Id = int.Parse(lbl_id.Text.Trim());
                //type.CancelledUserId = commonFunctions.LoginuserID;
                //type.CancelReason = txt_cancelr.Text.Trim();
                //type.CencelledDate = DateTime.Now;
                //type.DateStamp = GetDateStamp();
                //type.Day = txt_day.Text.ToString();
                //type.Iscancel = chk_cancelday.Checked;
                //type.IsCompleted = false;
                //type.IsShiftCreated = false;

                if (MessageBox.Show("Do you want to insert this record?", Messaging.MessageCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    CustomeRepository.InitializeDailyPumperAssign(GetDateStamp(), txt_day.Text.ToString());
                    
                    GetData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Has found when Saving data. Please forword following details to technical" + Environment.NewLine + "[" + ex.Message + Environment.NewLine + ex.Source + "]", Messaging.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private bool CheckForUnclosedDays()
        {
            if (CustomeRepository.CheckForUnclosedDays() > 1)
            {
                return true;
            }
            else {
                return false;
            }
        }

        private bool ValidateInput()
        {

            bool ok = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(txt_day.Text.Trim()))
            {
                string error = "Day Cannot be a empty value";
                MessageBox.Show(error, Messaging.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider1.SetError(txt_day, error);
                ok = false;
            }

            return ok;

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dte_date_ValueChanged(object sender, EventArgs e)
        {
            txt_day.Text = dte_date.Value.Year.ToString() + dte_date.Value.Month.ToString() + dte_date.Value.Day.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInput())
                {
                    return;
                }
                DayMaster type = new DayMaster();
                type.Id = int.Parse(lbl_id.Text.Trim());
                type.CancelledUserId = commonFunctions.LoginuserID;
                type.CancelReason = txt_cancelr.Text.Trim();
                type.CencelledDate = DateTime.Now;
                type.DateStamp = GetDateStamp();
                type.Day = txt_day.Text.ToString();
                type.Iscancel = chk_cancelday.Checked;
               
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
    }
}
