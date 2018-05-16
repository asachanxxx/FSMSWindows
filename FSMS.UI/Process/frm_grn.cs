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
    public partial class frm_grn : Form
    {

        #region Loading one instance

        private static frm_grn objSingleObject = null;

        /// <summary>
        /// Singleton object creation method
        /// </summary>
        /// <returns>object of a frmM_Supplier</returns>
        public static frm_grn getSingleton()
        {
            if (objSingleObject == null || objSingleObject.IsDisposed)
            {
                objSingleObject = new frm_grn();

            }
            return objSingleObject;

        }

        #endregion

        
        string documentno;
        List<UnloadingDipReadings> tanks;
        bool tankswitch = false;
        bool nozzelswitch = false;
        List<UnloadingFuel> repo = new List<UnloadingFuel>();
        public frm_grn()
        {
            InitializeComponent();
        }

        //private DataTable GetDatatable() {
        //    DataTable dt = new DataTable();
        //    dt.Columns.Add("Id");
        //    dt.Columns.Add("FuelType");
        //    dt.Columns.Add("Quntity");
        //    dt.Columns.Add("Price");
        //    dt.Columns.Add("Total");
        //    dt.Columns.Add("Additions");
        //    dt.Columns.Add("Deductions");
        //    dt.Columns.Add("Net");
        //    return dt;
        //}

        private void frm_grn_Load(object sender, EventArgs e)
        {
            try
            {

                documentno = CustomeRepository.GetSetDocumentNumber("SC001", 0, "FRN", 1);
                txt_DocNo.Text = documentno;
                if (txt_DocNo.Text.Trim() != "")
                {
                    LoadTanks(txt_DocNo.Text);
                }
                LoadFuels();
                //pnl_header.BackColor = commonFunctions.PanelHeaderBackGroundColor;
                pnl_header.ForeColor = commonFunctions.PanelHeaderForColor;
                pnl_footer.BackColor = commonFunctions.PanelHeaderBackGroundColor;
                pnl_footer.ForeColor = Color.Black;

                lbl_headerpaneltext.Text = "Fuel Unloading".ToUpper();

                this.WindowState = FormWindowState.Maximized;
                this.Text = "Fuel Unloading";
                commonFunctions.FormatDataGrid(dgmain);
                dgmain.AutoGenerateColumns = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Has found in program. Please forword following details to technical" + Environment.NewLine + "[" + ex.Message + Environment.NewLine + ex.Source + "]", Messaging.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void LoadFuels()
        {
            try
            {
                List<KeyValue> listoffuels = KeyValueRepository.GetFuelTypes().ToList();
                if (listoffuels.Count > 0)
                {
                    cmb_fueltypes.DataSource = listoffuels;
                    cmb_fueltypes.DisplayMember = "Name";
                    cmb_fueltypes.ValueMember = "Id";
                    cmb_fueltypes.SelectedIndex = 0;

                    if (commonFunctions.ToInt(cmb_fueltypes.SelectedValue.ToString()) > 0)
                    {
                        FuelType ft = CustomeRepository.GetFuelRecord(commonFunctions.ToInt(cmb_fueltypes.SelectedValue.ToString()));
                        txt_price.Text = ft.UnitPrice.ToString();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Has found when loading data. Please forword following details to technical" + Environment.NewLine + "[" + ex.Message + Environment.NewLine + ex.Source + "]", Messaging.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        private void LoadTanks(string docno)
        {
            try
            {
                lst_tanks.Items.Clear();
                tanks = CustomeRepository.GetAllTanksForUnloading(docno).ToList();
                foreach (var item in tanks)
                {
                    string name = item.TankName + "-[" + item.BeforeTankQty + "L]";
                    ListViewItem itm = new ListViewItem(name);
                    itm.Tag = item;
                    itm.ImageIndex = 1;
                    lst_tanks.Items.Add(itm);
                }

            }
            catch (Exception ex) { }
        }

        private void LoadNozzels(string docno, int tankid)
        {
            try
            {
                lst_nozzels.Items.Clear();
                var Nozzels = CustomeRepository.GetAllNozzelssByTankForUnloading(docno, tankid);
                foreach (var item in Nozzels)
                {
                    string name = item.NozzelName + " - " + item.Reading.ToString();
                    ListViewItem itm = new ListViewItem(name);
                    itm.Tag = item;
                    itm.ImageIndex = 0;
                    lst_nozzels.Items.Add(itm);
                }

            }
            catch (Exception ex) { }
        }



        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lst_tanks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lst_tanks.SelectedItems.Count > 0)
            {
                panel4.BackColor = Color.LightGray;
                tankswitch = true;
                nozzelswitch = false;
                timer1.Start();
                UnloadingDipReadings tank = (UnloadingDipReadings)lst_tanks.SelectedItems[0].Tag;
                LoadNozzels(txt_DocNo.Text.Trim(), tank.TankD);
                GetValues(txt_DocNo.Text,1);
            }
        }

        private void GetValues(string docno, int bORa)
        {
            if (lst_tanks.SelectedItems.Count > 0)
            {
                decimal brefore = decimal.Zero;
                decimal After = decimal.Zero;
                UnloadingDipReadings read = (UnloadingDipReadings)lst_tanks.SelectedItems[0].Tag;
                brefore= CustomeRepository.GetNozzelTotalizerReadings(txt_DocNo.Text, read.TankD, 1);
                After = CustomeRepository.GetNozzelTotalizerReadings(txt_DocNo.Text, read.TankD, 2);
                num_beforedipreading.Value = brefore;
                num_afterReading.Value = After;

                lbl_totbfore.Text = read.BeforeTankQty.ToString();
                lbl_Totafter.Text = read.AfterTankQty.ToString();
                lbl_systemUnloaded.Text = (read.AfterTankQty - read.BeforeTankQty).ToString();
                decimal unloadedqty = commonFunctions.ToDecimal(lbl_unloadedqty.Text.Trim());
                decimal variance =unloadedqty - (read.AfterTankQty - read.BeforeTankQty);
                lbl_Variance.Text = variance.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //if (CustomeRepository.CheckForDocumentNo(txt_DocNo.Text) >= 0) {
                //    MessageBox.Show("Record Already Exists..", Messaging.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    return;
                //}
                if (MessageBox.Show("Do you want to Save this record?", Messaging.MessageCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    CustomeRepository.InitializeUnloading(txt_DocNo.Text, commonFunctions.LoginuserID);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting the record..", Messaging.MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to Save this record?", Messaging.MessageCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (lst_tanks.SelectedItems.Count > 0) {
                    UnloadingNozzelReading reading = (UnloadingNozzelReading)lst_nozzels.SelectedItems[0].Tag;
                    CustomeRepository.SaveTotalizerForUnloading(txt_DocNo.Text.Trim(), reading.NozzelId, num_TotalizerReadings.Value);
                    LoadNozzels(txt_DocNo.Text.Trim(), reading.TankId);
                }
            }
        }

        private void lst_nozzels_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lst_nozzels.SelectedItems.Count > 0) {
                tankswitch = false;
                nozzelswitch = true;
                panel1.BackColor = Color.LightGray;
                timer1.Start();
                UnloadingNozzelReading reading = (UnloadingNozzelReading)lst_nozzels.SelectedItems[0].Tag;
                num_TotalizerReadings.Value = reading.Reading;
                GetNozzelTotalizerReadings();


            }
        }

        private void GetNozzelTotalizerReadings()
        {
            if (lst_nozzels.SelectedItems.Count > 0)
            {
                UnloadingNozzelReading read = (UnloadingNozzelReading)lst_nozzels.SelectedItems[0].Tag;
                num_TotalizerReadings.Value = CustomeRepository.GetNozzelTotalizerReadings(txt_DocNo.Text, read.NozzelId);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (nozzelswitch)
            {
                panel1.BackColor = Color.FromArgb(38, 50, 56);
            }

            if (tankswitch)
            {
                panel4.BackColor = Color.FromArgb(38, 50, 56);
            }

            timer1.Stop();
            tankswitch = false;
            nozzelswitch = false;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (lst_tanks.SelectedItems.Count > 0) {
                UnloadingDipReadings read = (UnloadingDipReadings)lst_tanks.SelectedItems[0].Tag;
                CustomeRepository.UpdateDipValues(txt_DocNo.Text.Trim(), read.TankD, num_beforedipreading.Value,1);
                if (txt_DocNo.Text.Trim() != "")
                {
                    LoadTanks(txt_DocNo.Text);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (lst_tanks.SelectedItems.Count > 0)
            {
                UnloadingDipReadings read = (UnloadingDipReadings)lst_tanks.SelectedItems[0].Tag;
                CustomeRepository.UpdateDipValues(txt_DocNo.Text.Trim(), read.TankD, num_afterReading.Value, 2);
                if (txt_DocNo.Text.Trim() != "")
                {
                    LoadTanks(txt_DocNo.Text);
                }
            }
        }

        private void cmb_fueltypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //KeyValue value = (KeyValue)cmb_fueltypes.SelectedValue;
            if (commonFunctions.ToInt(cmb_fueltypes.SelectedValue.ToString()) > 0) {
                FuelType ft =  CustomeRepository.GetFuelRecord(commonFunctions.ToInt(cmb_fueltypes.SelectedValue.ToString()));
                txt_price.Text = ft.UnitPrice.ToString();
                CalculateBalance();
            }
            
        }


        private void CalculateBalance() {
            decimal fuelprice = txt_price.Value;
            decimal qty = txt_qty.Value;
            decimal amount = fuelprice * qty;
            num_total.Value = amount;
            decimal deduct = num_deductions.Value;
            decimal additions = num_additions.Value;

            decimal finalbalance = (amount + additions) - deduct;
            lbl_nettotal.Text = finalbalance.ToString();
        }

        private void txt_qty_ValueChanged(object sender, EventArgs e)
        {
            CalculateBalance();
        }

        private void num_additions_ValueChanged(object sender, EventArgs e)
        {
            CalculateBalance();
        }

        private void num_deductions_ValueChanged(object sender, EventArgs e)
        {
            CalculateBalance();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to Save this record?", Messaging.MessageCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FuelType ft = CustomeRepository.GetFuelRecord(commonFunctions.ToInt(cmb_fueltypes.SelectedValue.ToString()));
                UnloadingFuel model = new UnloadingFuel();
                model.Id = ft.Id;
                model.Price = ft.UnitPrice;
                model.Quntity = txt_qty.Value;
                model.Total = num_total.Value;
                model.Net = commonFunctions.ToDecimal(lbl_nettotal.Text.Trim());
                model.FuelType = cmb_fueltypes.Text;
                model.Additions = num_additions.Value;
                model.Deductions = num_deductions.Value;
                repo.Add(model);
                dgmain.DataSource = repo;
                Calculate();
            }

        }

        void Calculate()
        {
            decimal total = decimal.Zero;

            foreach (var item in repo)
            {
                total += item.Quntity;
            }
            num_unloadedQty.Value = total;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {

        }
    }
}
