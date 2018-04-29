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

    public partial class frm_tanks : Form
    {


        private RepositoryBase<Tank> repo;

        #region Loading one instance

        private static frm_tanks objSingleObject = null;

        /// <summary>
        /// Singleton object creation method
        /// </summary>
        /// <returns>object of a frmM_Supplier</returns>
        public static frm_tanks getSingleton()
        {
            if (objSingleObject == null || objSingleObject.IsDisposed)
            {
                objSingleObject = new frm_tanks();

            }
            return objSingleObject;

        }

        #endregion

        public frm_tanks()
        {
            InitializeComponent();
        }

        private void frm_tanks_Load(object sender, EventArgs e)
        {
            try
            {
                repo = new RepositoryBase<Tank>("Tanks");
                LoadFuels();
                lbl_id.Text = "-1";
                pnl_header.BackColor = commonFunctions.PanelHeaderBackGroundColor;
                pnl_header.ForeColor = commonFunctions.PanelHeaderForColor;
                pnl_footer.BackColor = commonFunctions.PanelHeaderBackGroundColor;
                pnl_footer.ForeColor = Color.Black;

                lbl_headerpaneltext.Text = "Tanks".ToUpper();

                this.WindowState = FormWindowState.Maximized;
                this.Text = "Tanks";
                commonFunctions.FormatDataGrid(dgmain);
                commonFunctions.FormatDataGrid(dgmain);

                GetData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Has found in program. Please forword following details to technical" + Environment.NewLine + "[" + ex.Message + Environment.NewLine + ex.Source + "]", Messaging.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void LoadFuels()
        {
            try { 
            List<KeyValue> listoffuels = KeyValueRepository.GetFuelTypes().ToList();
            if (listoffuels.Count > 0)
            {
                cmb_fueltypes.DataSource = listoffuels;
                cmb_fueltypes.DisplayMember = "Name";
                cmb_fueltypes.ValueMember = "Id";
                cmb_fueltypes.SelectedIndex = 0;
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Has found when loading data. Please forword following details to technical" + Environment.NewLine + "[" + ex.Message + Environment.NewLine + ex.Source + "]", Messaging.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void GetData()
        {
            try
            {
                dgmain.AutoGenerateColumns = false;
                List<Tank> stl = repo.GetAll().ToList();
                if (stl != null)
                {
                    dgmain.DataSource = stl;
                    dgmain.Columns[0].HeaderText = "#";
                    dgmain.Columns[1].HeaderText = "Fuel";
                    dgmain.Columns[2].HeaderText = "Tank Name";
                    dgmain.Columns[3].HeaderText = "SIH";
                    
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
                ValidateInput();
                Tank type = new Tank();
                type.Id = int.Parse(lbl_id.Text.Trim());
                type.TankName = txt_name.Text.Trim().ToUpper();
                type.InnerDiameter = txt_innerd.Value;
                type.Length = txt_len.Value;
                type.Capacity = txt_cap.Value;
                type.FuelTypeID = commonFunctions.ToInt(cmb_fueltypes.SelectedValue.ToString());
                type.GroupOfCompanyID = 1;
                type.ModifiedUser = commonFunctions.LoginuserID;
                type.ModifiedDate = DateTime.Now;
                type.CreatedUser = commonFunctions.LoginuserID;
                type.CreatedDate = DateTime.Now;
                type.DataTransfer = 1;

                if (MessageBox.Show("Do you want to insert this record?", Messaging.MessageCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    type.CurrentSIH = 0;
                    repo.Save(type);
                    GetData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Has found when Saving data. Please forword following details to technical" + Environment.NewLine + "[" + ex.Message + Environment.NewLine + ex.Source + "]", Messaging.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateInput();
                Tank type = new Tank();
                type.Id = int.Parse(lbl_id.Text.Trim());
                type.TankName = txt_name.Text.Trim().ToUpper();
                type.InnerDiameter = txt_innerd.Value;
                type.FuelTypeID = commonFunctions.ToInt(cmb_fueltypes.SelectedValue.ToString());
                type.Length = txt_len.Value;
                type.Capacity = txt_cap.Value;
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
                MessageBox.Show("Error Has found when modifying data. Please forword following details to technical" + Environment.NewLine + "[" + ex.Message + Environment.NewLine + ex.Source + "]", Messaging.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
}

        private void ValidateInput()
        {
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(txt_name.Text.Trim()))
            {
                string error = "Tank Code Cannot be a empty value";
                MessageBox.Show(error, Messaging.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider1.SetError(txt_name, error);
                return;
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
                
                Tank type = repo.Get(int.Parse(v.Trim()));
                if (type != null)
                {

                    lbl_id.Text = type.Id.ToString();
                    txt_name.Text = type.TankName;
                    txt_cap.Value = type.Capacity;
                    txt_innerd.Value = type.InnerDiameter;
                    txt_len.Value = type.Length;
                    txt_SiH.Text = type.CurrentSIH.ToString();
                    cmb_fueltypes.SelectedValue = type.FuelTypeID;

                }
            }
            catch (Exception ex)
            {
            }
        }

       
    }
}
