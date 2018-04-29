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
    public partial class frm_shifts : Form
    {


        private RepositoryBase<Shift> repo;

        #region Loading one instance

        private static frm_shifts objSingleObject = null;

        /// <summary>
        /// Singleton object creation method
        /// </summary>
        /// <returns>object of a frmM_Supplier</returns>
        public static frm_shifts getSingleton()
        {
            if (objSingleObject == null || objSingleObject.IsDisposed)
            {
                objSingleObject = new frm_shifts();

            }
            return objSingleObject;

        }

        #endregion


        public frm_shifts()
        {
            InitializeComponent();
        }

        private void frm_shifts_Load(object sender, EventArgs e)
        {
            try
            {
                cmb_starth.SelectedIndex = 0;
                cmb_startm.SelectedIndex = 0;
                cmb_endsH.SelectedIndex = 1;
                cmb_endsM.SelectedIndex = 1;


                repo = new RepositoryBase<Shift>("Shifts");

                //LoadFuels();
                lbl_id.Text = "-1";
                pnl_header.BackColor = commonFunctions.PanelHeaderBackGroundColor;
                pnl_header.ForeColor = commonFunctions.PanelHeaderForColor;
                pnl_footer.BackColor = commonFunctions.PanelHeaderBackGroundColor;
                pnl_footer.ForeColor = Color.Black;

                lbl_headerpaneltext.Text = "Shifts".ToUpper();

                this.WindowState = FormWindowState.Maximized;
                this.Text = "Shifts";
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
                List<Shift> stl = repo.GetAll().ToList();
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

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {


                errorProvider1.Clear();
                if (string.IsNullOrEmpty(txt_name.Text.Trim()))
                {
                    string error = "Shift Name Cannot be a empty value";
                    MessageBox.Show(error, Messaging.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    errorProvider1.SetError(txt_name, error);
                    return;
                }
                Shift type = new Shift();
                type.Id = int.Parse(lbl_id.Text.Trim());
                type.StartH = commonFunctions.ToInt(cmb_starth.Text.Trim());
                type.StartM = commonFunctions.ToInt(cmb_startm.Text.Trim());
                type.EndH = commonFunctions.ToInt(cmb_endsH.Text.Trim());
                type.EndM = commonFunctions.ToInt(cmb_endsM.Text.Trim());
                type.ShifName = txt_name.Text.Trim();
                type.ShiftLength = cmb_shiftlen.Value;
                type.BreakLength = cmb_breaklen.Value;
                type.GroupOfCompanyID = 1;
                type.ModifiedUser = commonFunctions.LoginuserID;
                type.ModifiedDate = DateTime.Now;
                type.CreatedUser = commonFunctions.LoginuserID;
                type.CreatedDate = DateTime.Now;
                type.DataTransfer = 1;

                GetDiff(cmb_starth.Text.Trim(), cmb_startm.Text.Trim(), cmb_endsH.Text.Trim(), cmb_endsM.Text.Trim());

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

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(txt_name.Text.Trim()))
            {
                string error = "Shift Name Cannot be a empty value";
                MessageBox.Show(error, Messaging.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider1.SetError(txt_name, error);
                return;
            }

            Shift type = new Shift();
            type.Id = int.Parse(lbl_id.Text.Trim());
            type.StartH = commonFunctions.ToInt(cmb_starth.Text.Trim());
            type.StartM = commonFunctions.ToInt(cmb_startm.Text.Trim());
            type.EndH = commonFunctions.ToInt(cmb_endsH.Text.Trim());
            type.EndM = commonFunctions.ToInt(cmb_endsM.Text.Trim());
            type.ShifName = txt_name.Text.Trim();
            type.ShiftLength = cmb_shiftlen.Value;
            type.BreakLength = cmb_breaklen.Value;
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

        private void cmb_endsH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_endsH.SelectedIndex > -1)
            {
                CheckValidateDates(cmb_starth.Text.Trim(), cmb_startm.Text.Trim(), cmb_endsH.Text.Trim(), cmb_endsM.Text.Trim());
            }
        }

        private void cmb_endsM_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_endsM.SelectedIndex > -1)
            {
                CheckValidateDates(cmb_starth.Text.Trim(), cmb_startm.Text.Trim(), cmb_endsH.Text.Trim(), cmb_endsM.Text.Trim());
            }
        }

        private decimal GetDiff (string SH, string SM, string EH, string EM)
        {
            int h= (int.Parse(EH) - int.Parse(SH));
            int m = (int.Parse(EM) - int.Parse(SM));
            decimal dec = decimal.Parse(h.ToString() + "." + Math.Abs(m).ToString());
            cmb_shiftlen.Value = dec;
            return dec;
        }


        private bool CheckValidateDates(string SH, string SM, string EH, string EM)
        {
            if (string.IsNullOrEmpty(SH) || string.IsNullOrEmpty(SM) || string.IsNullOrEmpty(EH) || string.IsNullOrEmpty(EM)) {
                return false;
            }

            bool pass = false;
            if (int.Parse(SH) < int.Parse(EH))
            {
                GetDiff(SH, SM, EH, EM);
                pass = true;
                errorProvider1.Clear();
            }
            else {
                errorProvider1.SetError(cmb_starth,"Shift end value must be grater than shift start value");
                errorProvider1.SetError(cmb_startm, "Shift end value must be grater than shift start value");
            }
            return pass;
        }

        private void cmb_starth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_starth.SelectedIndex > -1)
            {
                CheckValidateDates(cmb_starth.Text.Trim(), cmb_startm.Text.Trim(), cmb_endsH.Text.Trim(), cmb_endsM.Text.Trim());
            }
        }

        private void cmb_startm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_startm.SelectedIndex > -1)
            {
                CheckValidateDates(cmb_starth.Text.Trim(), cmb_startm.Text.Trim(), cmb_endsH.Text.Trim(), cmb_endsM.Text.Trim());

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
                Shift type = repo.Get(int.Parse(v.Trim()));
                if (type != null)
                {

                    lbl_id.Text = type.Id.ToString();
                    txt_name.Text = type.ShifName;
                    cmb_starth.Text = type.StartH.ToString();
                    cmb_startm.Text = type.StartM.ToString();
                    cmb_endsH.Text = type.EndH.ToString();
                    cmb_endsM.Text = type.EndM.ToString();
                    cmb_shiftlen.Value = type.ShiftLength;
                    cmb_breaklen.Value = type.BreakLength;

                }
            }
            catch (Exception ex)
            {
            }
        }
    }
}
