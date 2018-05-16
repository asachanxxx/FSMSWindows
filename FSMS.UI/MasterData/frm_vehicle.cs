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

namespace FSMS.UI.MasterData
{
    public partial class frm_vehicle : Form
    {

        private RepositoryBase<Vehicle> repo;

        #region Loading one instance

        private static frm_vehicle objSingleObject = null;

        /// <summary>
        /// Singleton object creation method
        /// </summary>
        /// <returns>object of a frmM_Supplier</returns>
        public static frm_vehicle getSingleton()
        {
            if (objSingleObject == null || objSingleObject.IsDisposed)
            {
                objSingleObject = new frm_vehicle();

            }
            return objSingleObject;

        }

        #endregion

        public frm_vehicle()
        {
            InitializeComponent();
            repo = new RepositoryBase<Vehicle>("Vehicles");
        }

        private void frm_vehicle_Load(object sender, EventArgs e)
        {
            LoadCustomer();
            lbl_headerpaneltext.Text = "Credit Vehicles".ToUpper();

            this.WindowState = FormWindowState.Maximized;
            this.Text = "Credit Vehicles";
        }
        private void LoadCustomer()
        {
            List<KeyValue> listoffuels = KeyValueRepository.GetCustomers().ToList();
            if (listoffuels.Count > 0)
            {
                cmb_customers.DataSource = listoffuels;
                cmb_customers.DisplayMember = "Name";
                cmb_customers.ValueMember = "Id";
                cmb_customers.SelectedIndex = 0;
            }

        }

        private void btn_savepump_Click(object sender, EventArgs e)
        {
            LoadVehicles(commonFunctions.ToInt(cmb_customers.SelectedValue.ToString()));
        }

        private void LoadVehicles(int cusid)
        {
            lst_vehicles.Items.Clear();
            List<Vehicle> vehis =  CustomeRepository.GetVehicleForCustomers(cusid).ToList();
            if (vehis != null && vehis.Count > 0)
            {
                foreach (var item in vehis)
                {
                    ListViewItem itm = new ListViewItem(item.VehicleName, 0);
                    itm.Tag = item;
                    lst_vehicles.Items.Add(itm);
                    lst_vehicles.Items[0].Selected = true;
                }
            }

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            lbl_rating.Text = trackBar1.Value.ToString();
        }

        private void lst_vehicles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lst_vehicles.SelectedItems.Count > 0) {
                Vehicle vehi = (Vehicle)lst_vehicles.SelectedItems[0].Tag;
                lbl_id.Text = vehi.Id.ToString();
                txt_chessisno.Text = vehi.ChassesNo;
                txt_crelimit.Value = vehi.CreditLimit;
                txt_engineNo.Text = vehi.EngineNo;
                txt_make.Text = vehi.Make;
                txt_model.Text = vehi.Model;
                txt_name.Text = vehi.VehicleName;
                txt_outstnd.Value= vehi.Outstanding;
                txt_outstndingalert.Value= vehi.CreditAlertLimit;
                txt_remarks.Text = vehi.Remark;
                txt_type.Text = vehi.VehicleType;
                txt_vehregno.Text = vehi.RegistrationNo;
                lbl_rating.Text = vehi.Ratings.ToString();
                trackBar1.Value = vehi.Ratings;
                cmb_fueltype.SelectedItem = vehi.FuelType;

            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            ValidateInput();
            Vehicle type = new Vehicle();
            type.Id = 0;
            type.ChassesNo = txt_chessisno.Text;
            type.ChequeLimit = txt_crelimit.Value;
            type.CreditAlertLimit = txt_outstndingalert.Value;
            type.CreditCusId = commonFunctions.ToInt(cmb_customers.SelectedValue.ToString());
            type.CreditLimit= txt_crelimit.Value;
            type.EngineCapacity = "";
            type.EngineNo = txt_engineNo.Text;
            type.FuelType = cmb_fueltype.Text;
            type.Make = txt_make.Text;
            type.Model  = txt_model.Text;
            type.Outstanding = txt_outstnd.Value;
            type.Ratings = commonFunctions.ToInt(lbl_rating.Text);
            type.RegistrationNo = txt_vehregno.Text;
            type.Remark = txt_remarks.Text;
            type.RFIDNo = "";
            type.RFID_Id = 0;
            type.VehicleImage = "";
            type.VehicleName = txt_name.Text;
            type.VehicleStatus = 1;
            type.VehicleType = txt_type.Text;
            type.Weight = 10;
            type.GroupOfCompanyID = 1;
            type.ModifiedUser = commonFunctions.LoginuserID;
            type.ModifiedDate = DateTime.Now;
            type.CreatedUser = commonFunctions.LoginuserID;
            type.CreatedDate = DateTime.Now;
            type.DataTransfer = 1;

            if (MessageBox.Show("Do you want to insert this record?", Messaging.MessageCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                repo.Save(type);
                LoadVehicles(commonFunctions.ToInt(cmb_customers.SelectedValue.ToString()));
            }
        }

        private void ValidateInput()
        {
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(txt_vehregno.Text.Trim()))
            {
                string error = "Vehicle Registration No Cannot be a empty value";
                MessageBox.Show(error, Messaging.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider1.SetError(txt_vehregno, error);
                return;
            }

            if (string.IsNullOrEmpty(txt_name.Text.Trim()))
            {
                string error = "Vehicle Name Cannot be a empty value";
                MessageBox.Show(error, Messaging.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider1.SetError(txt_name, error);
                return;
            }


        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            ValidateInput();
            Vehicle type = new Vehicle();
            type.Id = int.Parse(lbl_id.Text.Trim());
            type.ChassesNo = txt_chessisno.Text;
            type.ChequeLimit = txt_crelimit.Value;
            type.CreditAlertLimit = txt_outstndingalert.Value;
            type.CreditCusId = commonFunctions.ToInt(cmb_customers.SelectedValue.ToString());
            type.CreditLimit = txt_crelimit.Value;
            type.EngineCapacity = "";
            type.EngineNo = txt_engineNo.Text;
            type.FuelType = cmb_fueltype.Text;
            type.Make = txt_make.Text;
            type.Model = txt_model.Text;
            type.Outstanding = txt_outstnd.Value;
            type.Ratings = commonFunctions.ToInt(lbl_rating.Text);
            type.RegistrationNo = txt_vehregno.Text;
            type.Remark = txt_remarks.Text;
            type.RFIDNo = "";
            type.RFID_Id = 0;
            type.VehicleImage = "";
            type.VehicleName = txt_name.Text;
            type.VehicleStatus = 1;
            type.VehicleType = txt_type.Text;
            type.Weight = 10;
            type.GroupOfCompanyID = 1;
            type.ModifiedUser = commonFunctions.LoginuserID;
            type.ModifiedDate = DateTime.Now;
            type.CreatedUser = commonFunctions.LoginuserID;
            type.CreatedDate = DateTime.Now;
            type.DataTransfer = 1;

            if (MessageBox.Show("Do you want to insert this record?", Messaging.MessageCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                repo.Update(type);
                LoadVehicles(commonFunctions.ToInt(cmb_customers.SelectedValue.ToString()));
            }
        }
    }
}
