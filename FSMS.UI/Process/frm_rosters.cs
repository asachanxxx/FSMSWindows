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
    public partial class frm_rosters : Form
    {
        private RepositoryBase<Roster> repo;

        #region Loading one instance

        private static frm_rosters objSingleObject = null;

        /// <summary>
        /// Singleton object creation method
        /// </summary>
        /// <returns>object of a frmM_Supplier</returns>
        public static frm_rosters getSingleton()
        {
            if (objSingleObject == null || objSingleObject.IsDisposed)
            {
                objSingleObject = new frm_rosters();

            }
            return objSingleObject;

        }

        #endregion


        public frm_rosters()
        {
            InitializeComponent();
        }

        private void frm_rosters_Load(object sender, EventArgs e)
        {
            try
            {
                cmb_starth.SelectedIndex = 0;
                cmb_startm.SelectedIndex = 0;
                cmb_endsH.SelectedIndex = 1;
                cmb_endsM.SelectedIndex = 1;


                repo = new RepositoryBase<Roster>("Rosters");

                LoadDays();
                LoadNozzels();
                LoadShifts();
                LoadPumper();
                lbl_id.Text = "-1";
                pnl_header.BackColor = commonFunctions.PanelHeaderBackGroundColor;
                pnl_header.ForeColor = commonFunctions.PanelHeaderForColor;
                pnl_footer.BackColor = commonFunctions.PanelHeaderBackGroundColor;
                pnl_footer.ForeColor = Color.Black;

                lbl_headerpaneltext.Text = "Rosters".ToUpper();

                this.WindowState = FormWindowState.Maximized;
                this.Text = "Rosters";
                commonFunctions.FormatDataGrid(dgmain);
                commonFunctions.FormatDataGrid(dgmain);

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Has found in program. Please forword following details to technical" + Environment.NewLine + "[" + ex.Message + Environment.NewLine + ex.Source + "]", Messaging.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);

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

        private void LoadPumper()
        {
            List<KeyValue> listoffuels = KeyValueRepository.GetPumpers().ToList();
            if (listoffuels.Count > 0)
            {
                cmb_pumper.DataSource = listoffuels;
                cmb_pumper.DisplayMember = "Name";
                cmb_pumper.ValueMember = "Id";
                cmb_pumper.SelectedIndex = 0;
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

        private void GetData()
        {
            try
            {
                if (cmb_days.Text.Trim() != "")
                {
                    int did = commonFunctions.ToInt(cmb_days.SelectedValue.ToString().Trim());
                    dgmain.AutoGenerateColumns = false;
                    List<RosterViewModel> stl = CustomeRepository.GetFuelTypes(did).ToList();
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

        private void cmb_starth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_endsM.SelectedIndex > -1)
            {
                CheckValidateDates(cmb_starth.Text.Trim(), cmb_startm.Text.Trim(), cmb_endsH.Text.Trim(), cmb_endsM.Text.Trim());
            }
        }

        private void cmb_startm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_endsM.SelectedIndex > -1)
            {
                CheckValidateDates(cmb_starth.Text.Trim(), cmb_startm.Text.Trim(), cmb_endsH.Text.Trim(), cmb_endsM.Text.Trim());
            }
        }

        private void cmb_endsH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_endsM.SelectedIndex > -1)
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

        private bool CheckValidateDates(string SH, string SM, string EH, string EM)
        {
            if (string.IsNullOrEmpty(SH) || string.IsNullOrEmpty(SM) || string.IsNullOrEmpty(EH) || string.IsNullOrEmpty(EM))
            {
                return false;
            }

            bool pass = false;
            if (int.Parse(SH) < int.Parse(EH))
            {
                pass = true;
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(cmb_starth, "Shift end value must be grater than shift start value");
                errorProvider1.SetError(cmb_startm, "Shift end value must be grater than shift start value");
            }
            return pass;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {

                if (!CustomeRepository.CheckExistancePumperForNozzel(commonFunctions.ToInt(cmb_days.SelectedValue.ToString()), commonFunctions.ToInt(cmb_Nozzels.SelectedValue.ToString()), commonFunctions.ToInt(cmb_pumper.SelectedValue.ToString())))
                {
                    MessageBox.Show("Pumper is already assigned for this nozzel in this day.", Messaging.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                if (!ValidateInput())
                {
                    return;
                }
                Roster type = new Roster();
                type.Id = int.Parse(lbl_id.Text.Trim());
                type.NozzelID = commonFunctions.ToInt(cmb_Nozzels.SelectedValue.ToString());
                type.PumperID = commonFunctions.ToInt(cmb_pumper.SelectedValue.ToString());
                type.ShiftID = commonFunctions.ToInt(cmb_Shifts.SelectedValue.ToString());
                type.DayStartID = commonFunctions.ToInt(cmb_days.SelectedValue.ToString());
                type.ActualEndH = commonFunctions.ToInt(cmb_starth.Text.Trim());
                type.AcutalEndM = commonFunctions.ToInt(cmb_startm.Text.Trim());
                type.PlanStartH = commonFunctions.ToInt(cmb_endsH.Text.Trim());
                type.PlanStartM = commonFunctions.ToInt(cmb_endsM.Text.Trim());
                type.ShiftName = txt_name.Text.Trim();

                type.TotalNoOfWorkigH = 0;

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
                string error = "Roster Name Cannot be a empty value";
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
                Roster type = new Roster();
                type.Id = int.Parse(lbl_id.Text.Trim());
                type.NozzelID = commonFunctions.ToInt(cmb_Nozzels.SelectedValue.ToString());
                type.PumperID = commonFunctions.ToInt(cmb_pumper.SelectedValue.ToString());
                type.ShiftID = commonFunctions.ToInt(cmb_Shifts.SelectedValue.ToString());
                type.DayStartID = commonFunctions.ToInt(cmb_days.SelectedValue.ToString());
                type.ActualEndH = commonFunctions.ToInt(cmb_starth.Text.Trim());
                type.AcutalEndM = commonFunctions.ToInt(cmb_startm.Text.Trim());
                type.PlanStartH = commonFunctions.ToInt(cmb_endsH.Text.Trim());
                type.PlanStartM = commonFunctions.ToInt(cmb_endsM.Text.Trim());
                type.ShiftName = txt_name.Text.Trim();
                type.TotalNoOfWorkigH = 0;

                if (MessageBox.Show("Do you want to update this record?", Messaging.MessageCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    repo.Update(type);
                    GetData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Has found when updating data. Please forword following details to technical" + Environment.NewLine + "[" + ex.Message + Environment.NewLine + ex.Source + "]", Messaging.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);

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
                Roster type = repo.Get(int.Parse(v.Trim()));
                if (type != null)
                {

                    lbl_id.Text = type.Id.ToString();
                    txt_name.Text = type.ShiftName;
                    cmb_Nozzels.SelectedValue = type.NozzelID;
                    cmb_pumper.SelectedValue = type.PumperID;
                    cmb_Shifts.SelectedValue = type.ShiftID;
                    cmb_days.SelectedValue = type.DayStartID;

                }
            }
            catch (Exception ex)
            {
            }
        }

        private void cmb_days_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetData();
            
        }
    }
}
