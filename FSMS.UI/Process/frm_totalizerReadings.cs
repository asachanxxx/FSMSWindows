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
    public partial class frm_totalizerReadings : Form
    {

        private RepositoryBase<TotalizeReading> repo;

        #region Loading one instance

        private static frm_totalizerReadings objSingleObject = null;

        /// <summary>
        /// Singleton object creation method
        /// </summary>
        /// <returns>object of a frmM_Supplier</returns>
        public static frm_totalizerReadings getSingleton()
        {
            if (objSingleObject == null || objSingleObject.IsDisposed)
            {
                objSingleObject = new frm_totalizerReadings();

            }
            return objSingleObject;

        }

        #endregion

        public frm_totalizerReadings()
        {
            InitializeComponent();
        }

        private void frm_totalizerReadings_Load(object sender, EventArgs e)
        {
            try
            {
              

                repo = new RepositoryBase<TotalizeReading>("TotalizeReadings");

                LoadDays();
                LoadNozzels();
                LoadShifts();
                lbl_id.Text = "-1";
                pnl_header.BackColor = commonFunctions.PanelHeaderBackGroundColor;
                pnl_header.ForeColor = commonFunctions.PanelHeaderForColor;
                pnl_footer.BackColor = commonFunctions.PanelHeaderBackGroundColor;
                pnl_footer.ForeColor = Color.Black;

                lbl_headerpaneltext.Text = "Totalize Readings".ToUpper();

                this.WindowState = FormWindowState.Maximized;
                this.Text = "Totalize Readings";
                commonFunctions.FormatDataGrid(dgmain);
                commonFunctions.FormatDataGrid(dgmain);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Has found in program. Please forword following details to technical" + Environment.NewLine + "[" + ex.Message + Environment.NewLine + ex.Source + "]", Messaging.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }


        private void LoadShifts()
        {
            List<KeyValue> listoffuels = KeyValueRepository.GetShifts().ToList();
            if (listoffuels.Count > 0)
            {
                cmb_Shifts.DataSource = listoffuels;
                cmb_Shifts.DisplayMember = "Name";
                cmb_Shifts.ValueMember = "Id";
                cmb_Shifts.SelectedIndex = 0;
            }

        }

        private void LoadDays()
        {
            List<KeyValue> listoffuels = KeyValueRepository.GetDays().ToList();
            if (listoffuels.Count > 0)
            {
                cmb_days.DataSource = listoffuels;
                cmb_days.DisplayMember = "Name";
                cmb_days.ValueMember = "Id";
                cmb_days.SelectedIndex = 0;
            }

        }

        private void LoadNozzels()
        {
            List<KeyValue> listoffuels = KeyValueRepository.GetNozzels().ToList();
            if (listoffuels.Count > 0)
            {
                cmb_Nozzels.DataSource = listoffuels;
                cmb_Nozzels.DisplayMember = "Name";
                cmb_Nozzels.ValueMember = "Id";
                cmb_Nozzels.SelectedIndex = 0;
            }

        }

        private void cmb_days_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void GetData()
        {
            try
            {
                if (cmb_days.Text.Trim() != "")
                {
                    int did = commonFunctions.ToInt(cmb_days.SelectedValue.ToString().Trim());
                    int Sid = commonFunctions.ToInt(cmb_Shifts.SelectedValue.ToString().Trim());
                    dgmain.AutoGenerateColumns = false;
                    List<TotalizeReadingViewModel> stl = CustomeRepository.GetAllTotalizerForDay(did,Sid).ToList();
                    if (stl != null)
                    {
                        dgmain.DataSource = stl;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Has found when loading data. Please forword following details to technical" + Environment.NewLine + "[" + ex.Message + Environment.NewLine + ex.Source + "]", Messaging.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (Calculate()) {
                MessageBox.Show("New totalizer reaing must grater than existing reading.", Messaging.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                if (CustomeRepository.CheckExistanceOFNozzelForDayInTotalizer(commonFunctions.ToInt(cmb_days.SelectedValue.ToString()), commonFunctions.ToInt(cmb_Nozzels.SelectedValue.ToString())))
                {
                    MessageBox.Show("Record already Exist for this nozzel .", Messaging.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!ValidateInput())
                {
                    return;
                }
                TotalizeReading type = new TotalizeReading();
                type.Id = int.Parse(lbl_id.Text.Trim());
                type.NozzelID = commonFunctions.ToInt(cmb_Nozzels.SelectedValue.ToString());
                type.DayID = commonFunctions.ToInt(cmb_days.SelectedValue.ToString());
                type.CussreentReading = txt_exreading.Value;
                type.NewReading = txt_creading.Value;
                type.SIH = commonFunctions.ToDecimal(txt_qty.Text.Trim());
                type.UPrice = commonFunctions.ToDecimal(txt_price.Text.Trim());
                type.Value = commonFunctions.ToDecimal(txt_total.Text.Trim());
                type.ShiftID = commonFunctions.ToInt(cmb_Shifts.SelectedValue.ToString());
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
            if (commonFunctions.ToInt(txt_creading.Text.Trim()) < commonFunctions.ToInt(txt_exreading.Text.Trim()))
            {
                string error = "Current Reading Value cannot lower than Existing Reading value";
                MessageBox.Show(error, Messaging.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider1.SetError(txt_creading, error);
                ok = false;
            }

            return ok;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Calculate())
            {
                MessageBox.Show("New totalizer reaing must grater than existing reading.", Messaging.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                if (!ValidateInput())
                {
                    return;
                }
                TotalizeReading type = new TotalizeReading();
                type.Id = int.Parse(lbl_id.Text.Trim());
                type.NozzelID = commonFunctions.ToInt(cmb_Nozzels.SelectedValue.ToString());
                type.DayID = commonFunctions.ToInt(cmb_days.SelectedValue.ToString());
                type.CussreentReading = txt_exreading.Value;
                type.NewReading = txt_creading.Value;
                type.SIH = commonFunctions.ToDecimal(txt_qty.Text.Trim());
                type.UPrice = commonFunctions.ToDecimal(txt_price.Text.Trim());
                type.Value = commonFunctions.ToDecimal(txt_total.Text.Trim());
                type.ShiftID = commonFunctions.ToInt(cmb_Shifts.SelectedValue.ToString());
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

        private void cmb_Nozzels_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (commonFunctions.ToInt(cmb_Nozzels.SelectedValue.ToString().Trim()) > -1)
            {
                decimal val = CustomeRepository.GetNozzelFuelPrice(commonFunctions.ToInt(cmb_Nozzels.SelectedValue.ToString().Trim()));
                txt_price.Text = val.ToString();

                decimal val2 = CustomeRepository.GetNozzelTotalizerReading(commonFunctions.ToInt(cmb_Nozzels.SelectedValue.ToString().Trim()));
                txt_creading.Text = val2.ToString();

            }
        }

        private bool Calculate()
        {
            try
            {
                decimal exist = txt_exreading.Value;
                decimal newt = txt_creading.Value;
                decimal price = commonFunctions.ToDecimal(txt_price.Text);
                decimal qty = newt - exist;
                if (qty < 0 || newt <= 0)
                {
                    return true;
                   

                }
                else {
                    txt_qty.Text = qty.ToString();
                    decimal total = qty * price;
                    txt_total.Text = total.ToString();
                    return false;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void txt_exreading_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_creading_ValueChanged(object sender, EventArgs e)
        {

            Calculate();
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
                TotalizeReading type = repo.Get(int.Parse(v.Trim()));
                if (type != null)
                {

                    lbl_id.Text = type.Id.ToString();
                    cmb_Nozzels.SelectedValue = type.NozzelID;
                    txt_creading.Value = type.NewReading; 
                    txt_exreading.Value = type.CussreentReading;
                    txt_qty.Text = type.SIH.ToString();
                    txt_price.Text = type.UPrice.ToString();
                    txt_total.Text = type.Value.ToString();
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            GetData();
        }
    }
}
