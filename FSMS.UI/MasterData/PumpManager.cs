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
    public partial class PumpManager : Form
    {

        private RepositoryBase<Pump> repopump;
        private RepositoryBase<Nozzle> repoNozzle;

        #region Loading one instance

        private static PumpManager objSingleObject = null;

        /// <summary>
        /// Singleton object creation method
        /// </summary>
        /// <returns>object of a frmM_Supplier</returns>
        public static PumpManager getSingleton()
        {
            if (objSingleObject == null || objSingleObject.IsDisposed)
            {
                objSingleObject = new PumpManager();

            }
            return objSingleObject;

        }

        #endregion

        public PumpManager()
        {
            InitializeComponent();
        }

        private void PumpManager_Load(object sender, EventArgs e)
        {

            try
            {
                LoadFuels();
                LoadTanks();
                repopump = new RepositoryBase<Pump>("Pumps");
                repoNozzle = new RepositoryBase<Nozzle>("Nozzles");
                //LoadCustomers();
                lbl_id.Text = "-1";
                pnl_header.BackColor = commonFunctions.PanelHeaderBackGroundColor;
                pnl_header.ForeColor = commonFunctions.PanelHeaderForColor;
                pnl_footer.BackColor = commonFunctions.PanelHeaderBackGroundColor;
                pnl_footer.ForeColor = Color.Black;

                lbl_headerpaneltext.Text = "PumpsManager".ToUpper();

                this.WindowState = FormWindowState.Maximized;
                this.Text = "PumpsManager";
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
                lst_pumps.Items.Clear();
                RepositoryBase<Pump> prepo = new RepositoryBase<Pump>("Pumps");
                List<Pump> Pumps = prepo.GetAll().ToList();
                if (Pumps != null && Pumps.Count > 0)
                {
                    foreach (var item in Pumps)
                    {
                        ListViewItem itm = new ListViewItem(item.PumpName, 0);
                        itm.Tag = item.Id;
                        lst_pumps.Items.Add(itm);
                        lst_pumps.Items[0].Selected = true;
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Has found when loading data. Please forword following details to technical" + Environment.NewLine + "[" + ex.Message + Environment.NewLine + ex.Source + "]", Messaging.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void GetNozzels(int id)
        {
            try
            {
                lst_nozzels.Items.Clear();
                RepositoryBase<Nozzle> nrepo = new RepositoryBase<Nozzle>("Nozzles");

                List<Nozzle> Pumps = nrepo.GetAll("PumpId", id.ToString(), true).ToList();
                if (Pumps != null && Pumps.Count > 0)
                {
                    foreach (var item in Pumps)
                    {
                        ListViewItem itm = new ListViewItem(item.NozzelName, 1);
                        itm.Tag = item.Id;

                        lst_nozzels.Items.Add(itm);
                        lst_nozzels.Items[0].Selected = true;
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Has found when loading data. Please forword following details to technical" + Environment.NewLine + "[" + ex.Message + Environment.NewLine + ex.Source + "]", Messaging.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }


        private void LoadFuels()
        {
            List<KeyValue> listoffuels = KeyValueRepository.GetFuelTypes().ToList();
            if (listoffuels.Count > 0)
            {
                cmb_fueltypes.DataSource = listoffuels;
                cmb_fueltypes.DisplayMember = "Name";
                cmb_fueltypes.ValueMember = "Id";
                cmb_fueltypes.SelectedIndex = 0;
            }

        }

        private void LoadTanks()
        {
            List<KeyValue> listoffuels = KeyValueRepository.GetTanks().ToList();
            if (listoffuels.Count > 0)
            {
                cmb_tanks.DataSource = listoffuels;
                cmb_tanks.DisplayMember = "Name";
                cmb_tanks.ValueMember = "Id";
                cmb_tanks.SelectedIndex = 0;
            }

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lst_pumps_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lst_pumps.SelectedItems.Count > 0)
                {
                    GetNozzels(commonFunctions.ToInt(lst_pumps.SelectedItems[0].Tag.ToString()));
                    RepositoryBase<Pump> prepo = new RepositoryBase<Pump>("Pumps");
                    Pump Pump = prepo.Get(commonFunctions.ToInt(lst_pumps.SelectedItems[0].Tag.ToString()));
                    if (Pump != null)
                    {
                        lbl_id.Text = Pump.Id.ToString();
                        
                        txt_pumpname.Text = Pump.PumpName;
                        txt_pumporder.Value = Pump.PumpOrderNo;
                        txt_noofnozzels.Value = Pump.NoofNozzels;
                        lbl_selectedPump.Text = Pump.PumpName;
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btn_savepump_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInput())
                {
                    return;
                }
                Pump type = new Pump();
                type.Id = int.Parse(lbl_id.Text.Trim());
                type.PumpName = txt_pumpname.Text;
                type.NoofNozzels = commonFunctions.ToInt(txt_noofnozzels.Value.ToString());
                type.PumpOrderNo = commonFunctions.ToInt(txt_pumporder.Value.ToString());
                type.GroupOfCompanyID = 1;
                type.ModifiedUser = commonFunctions.LoginuserID;
                type.ModifiedDate = DateTime.Now;
                type.CreatedUser = commonFunctions.LoginuserID;
                type.CreatedDate = DateTime.Now;
                type.DataTransfer = 1;

                if (MessageBox.Show("Do you want to insert this record?", Messaging.MessageCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    repopump.Save(type);
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
            if (string.IsNullOrEmpty(txt_pumpname.Text.Trim()))
            {
                string error = "Pmup Name Cannot be a empty value";
                MessageBox.Show(error, Messaging.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider1.SetError(txt_pumpname, error);
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
                Pump type = new Pump();
                type.Id = int.Parse(lbl_id.Text.Trim());
                type.PumpName = txt_pumpname.Text;
                type.NoofNozzels = commonFunctions.ToInt(txt_noofnozzels.Value.ToString());
                type.PumpOrderNo = commonFunctions.ToInt(txt_pumporder.Value.ToString());
                type.GroupOfCompanyID = 1;
                type.ModifiedUser = commonFunctions.LoginuserID;
                type.ModifiedDate = DateTime.Now;
                type.CreatedUser = commonFunctions.LoginuserID;
                type.CreatedDate = DateTime.Now;
                type.DataTransfer = 1;

                if (MessageBox.Show("Do you want to update this record?", Messaging.MessageCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    repopump.Update(type);
                    GetData();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Has found when Saving data. Please forword following details to technical" + Environment.NewLine + "[" + ex.Message + Environment.NewLine + ex.Source + "]", Messaging.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void lst_nozzels_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lst_nozzels.SelectedItems.Count > 0)
                {
                   
                    Nozzle nozz = repoNozzle.Get(commonFunctions.ToInt(lst_nozzels.SelectedItems[0].Tag.ToString()));
                    if (nozz != null)
                    {

                        lbl_nozzel.Text = nozz.Id.ToString();
                        txt_nozzelName.Text = nozz.NozzelName;
                        cmb_fueltypes.SelectedValue = nozz.FuelTypeId;
                        cmb_tanks.SelectedValue = nozz.TankId;
                        txt_unitPrice.Value = nozz.UnitPrice;
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btn_savenozz_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInputNozzel())
                {
                    return;
                }
                Nozzle type = new Nozzle();
                type.Id = -1;
                type.PumpId = int.Parse(lbl_id.Text.Trim());
                type.FuelTypeId = commonFunctions.ToInt(cmb_fueltypes.SelectedValue.ToString());
                type.TankId = commonFunctions.ToInt(cmb_tanks.SelectedValue.ToString());
                type.UnitPrice = txt_unitPrice.Value;
                type.NozzelName = txt_nozzelName.Text.Trim();
                type.LastTotalizerReading = 0;
                type.GroupOfCompanyID = 1;
                type.ModifiedUser = commonFunctions.LoginuserID;
                type.ModifiedDate = DateTime.Now;
                type.CreatedUser = commonFunctions.LoginuserID;
                type.CreatedDate = DateTime.Now;
                type.DataTransfer = 1;

                if (MessageBox.Show("Do you want to insert this record?", Messaging.MessageCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    repoNozzle.Save(type);
                    GetData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Has found when Saving data. Please forword following details to technical" + Environment.NewLine + "[" + ex.Message + Environment.NewLine + ex.Source + "]", Messaging.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private bool ValidateInputNozzel()
        {

            bool ok = true;
            errorProvider1.Clear();

            if (string.IsNullOrEmpty(txt_nozzelName.Text.Trim()))
            {
                string error = "Nozzel Name Cannot be a empty value";
                MessageBox.Show(error, Messaging.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider1.SetError(txt_nozzelName, error);
                ok = false;
            }

            if (commonFunctions.ToInt(cmb_tanks.SelectedValue.ToString()) <= 0) {
                string error = "PLease select a Tank to update it";
                MessageBox.Show(error, Messaging.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider1.SetError(lst_nozzels, error);
                ok = false;
            }
            if (commonFunctions.ToInt(cmb_fueltypes.SelectedValue.ToString()) <= 0)
            {
                string error = "PLease select a Fuel type to update it";
                MessageBox.Show(error, Messaging.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider1.SetError(lst_nozzels, error);
                ok = false;
            }

            return ok;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInputNozzel())
                {
                    return;
                }
                Nozzle type = new Nozzle();
                type.Id = commonFunctions.ToInt(lbl_nozzel.Text.Trim()); 
                type.PumpId = commonFunctions.ToInt(lbl_id.Text.Trim());
                type.FuelTypeId = commonFunctions.ToInt(cmb_fueltypes.SelectedValue.ToString());
                type.TankId = commonFunctions.ToInt(cmb_tanks.SelectedValue.ToString());
                type.UnitPrice = txt_unitPrice.Value;
                type.NozzelName = txt_nozzelName.Text.Trim();
                type.LastTotalizerReading = 0;
                type.GroupOfCompanyID = 1;
                type.ModifiedUser = commonFunctions.LoginuserID;
                type.ModifiedDate = DateTime.Now;
                type.CreatedUser = commonFunctions.LoginuserID;
                type.CreatedDate = DateTime.Now;
                type.DataTransfer = 1;

                if (MessageBox.Show("Do you want to insert this record?", Messaging.MessageCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    repoNozzle.Update(type);
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
