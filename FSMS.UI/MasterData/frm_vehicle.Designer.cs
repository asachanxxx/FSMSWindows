namespace FSMS.UI.MasterData
{
    partial class frm_vehicle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_vehicle));
            this.pnl_header = new System.Windows.Forms.Panel();
            this.lbl_headerpaneltext = new System.Windows.Forms.Label();
            this.pnl_footer = new System.Windows.Forms.Panel();
            this.btn_update = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_print = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lst_vehicles = new System.Windows.Forms.ListView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_savepump = new System.Windows.Forms.Button();
            this.cmb_customers = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_rating = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.cmb_fueltype = new System.Windows.Forms.ComboBox();
            this.txt_outstndingalert = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.cmb_fueltypes = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_remarks = new System.Windows.Forms.TextBox();
            this.txt_model = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_chessisno = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_make = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_type = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_engineNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_vehregno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_outstnd = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_crelimit = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.pnl_header.SuspendLayout();
            this.pnl_footer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_outstndingalert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_outstnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_crelimit)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_header
            // 
            this.pnl_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(108)))), ((int)(((byte)(139)))));
            this.pnl_header.Controls.Add(this.lbl_headerpaneltext);
            this.pnl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_header.Location = new System.Drawing.Point(0, 0);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Size = new System.Drawing.Size(1024, 43);
            this.pnl_header.TabIndex = 87;
            // 
            // lbl_headerpaneltext
            // 
            this.lbl_headerpaneltext.AutoSize = true;
            this.lbl_headerpaneltext.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_headerpaneltext.ForeColor = System.Drawing.Color.White;
            this.lbl_headerpaneltext.Location = new System.Drawing.Point(4, 1);
            this.lbl_headerpaneltext.Name = "lbl_headerpaneltext";
            this.lbl_headerpaneltext.Size = new System.Drawing.Size(143, 33);
            this.lbl_headerpaneltext.TabIndex = 0;
            this.lbl_headerpaneltext.Text = "Sales Types";
            // 
            // pnl_footer
            // 
            this.pnl_footer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(53)))), ((int)(((byte)(68)))));
            this.pnl_footer.Controls.Add(this.btn_update);
            this.pnl_footer.Controls.Add(this.btn_save);
            this.pnl_footer.Controls.Add(this.btn_print);
            this.pnl_footer.Controls.Add(this.btn_exit);
            this.pnl_footer.Location = new System.Drawing.Point(-112, 432);
            this.pnl_footer.Name = "pnl_footer";
            this.pnl_footer.Size = new System.Drawing.Size(1130, 46);
            this.pnl_footer.TabIndex = 88;
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.White;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_update.ImageIndex = 8;
            this.btn_update.ImageList = this.imageList1;
            this.btn_update.Location = new System.Drawing.Point(833, 4);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(91, 35);
            this.btn_update.TabIndex = 66;
            this.btn_update.Text = "       Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "001-delete-button.png");
            this.imageList1.Images.SetKeyName(1, "002-rubbish-bin-delete-button.png");
            this.imageList1.Images.SetKeyName(2, "003-reply-all-button.png");
            this.imageList1.Images.SetKeyName(3, "004-return-button.png");
            this.imageList1.Images.SetKeyName(4, "005-print-interface-button-symbol-of-printer-outline.png");
            this.imageList1.Images.SetKeyName(5, "006-printer-filled-tool-for-print-button.png");
            this.imageList1.Images.SetKeyName(6, "007-save-file-button.png");
            this.imageList1.Images.SetKeyName(7, "008-floppy-disk-save-button.png");
            this.imageList1.Images.SetKeyName(8, "009-save-button-interface-symbol-of-outlined-diskette.png");
            this.imageList1.Images.SetKeyName(9, "010-down-arrow-download-button.png");
            this.imageList1.Images.SetKeyName(10, "011-cancel-button.png");
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.White;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.ImageIndex = 6;
            this.btn_save.ImageList = this.imageList1;
            this.btn_save.Location = new System.Drawing.Point(736, 4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(91, 35);
            this.btn_save.TabIndex = 65;
            this.btn_save.Text = "     Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_print
            // 
            this.btn_print.BackColor = System.Drawing.Color.White;
            this.btn_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_print.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_print.ImageIndex = 5;
            this.btn_print.ImageList = this.imageList1;
            this.btn_print.Location = new System.Drawing.Point(930, 4);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(91, 36);
            this.btn_print.TabIndex = 62;
            this.btn_print.Text = "       Print";
            this.btn_print.UseVisualStyleBackColor = false;
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.White;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_exit.ImageIndex = 10;
            this.btn_exit.ImageList = this.imageList1;
            this.btn_exit.Location = new System.Drawing.Point(1027, 4);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(96, 36);
            this.btn_exit.TabIndex = 63;
            this.btn_exit.Text = "       Exit";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "004-cargo-truck.png");
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lst_vehicles);
            this.panel1.Location = new System.Drawing.Point(6, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 322);
            this.panel1.TabIndex = 89;
            // 
            // lst_vehicles
            // 
            this.lst_vehicles.HideSelection = false;
            this.lst_vehicles.LargeImageList = this.imageList2;
            this.lst_vehicles.Location = new System.Drawing.Point(6, 5);
            this.lst_vehicles.Name = "lst_vehicles";
            this.lst_vehicles.Size = new System.Drawing.Size(482, 308);
            this.lst_vehicles.SmallImageList = this.imageList2;
            this.lst_vehicles.TabIndex = 0;
            this.lst_vehicles.UseCompatibleStateImageBehavior = false;
            this.lst_vehicles.SelectedIndexChanged += new System.EventHandler(this.lst_vehicles_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn_savepump);
            this.panel2.Controls.Add(this.cmb_customers);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(6, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1012, 49);
            this.panel2.TabIndex = 90;
            // 
            // btn_savepump
            // 
            this.btn_savepump.BackColor = System.Drawing.Color.White;
            this.btn_savepump.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_savepump.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_savepump.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_savepump.ImageIndex = 3;
            this.btn_savepump.ImageList = this.imageList1;
            this.btn_savepump.Location = new System.Drawing.Point(494, 4);
            this.btn_savepump.Name = "btn_savepump";
            this.btn_savepump.Size = new System.Drawing.Size(125, 36);
            this.btn_savepump.TabIndex = 60;
            this.btn_savepump.Text = "     Load Vehicle";
            this.btn_savepump.UseVisualStyleBackColor = false;
            this.btn_savepump.Click += new System.EventHandler(this.btn_savepump_Click);
            // 
            // cmb_customers
            // 
            this.cmb_customers.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_customers.FormattingEnabled = true;
            this.cmb_customers.Location = new System.Drawing.Point(118, 11);
            this.cmb_customers.Name = "cmb_customers";
            this.cmb_customers.Size = new System.Drawing.Size(370, 23);
            this.cmb_customers.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Credit Customer";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lbl_id);
            this.panel3.Controls.Add(this.lbl_rating);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.trackBar1);
            this.panel3.Controls.Add(this.cmb_fueltype);
            this.panel3.Controls.Add(this.txt_outstndingalert);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.cmb_fueltypes);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.txt_remarks);
            this.panel3.Controls.Add(this.txt_model);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.txt_chessisno);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.txt_make);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.txt_type);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txt_engineNo);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txt_vehregno);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txt_outstnd);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txt_crelimit);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txt_name);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Location = new System.Drawing.Point(510, 105);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(508, 322);
            this.panel3.TabIndex = 91;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(230, 164);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(19, 14);
            this.lbl_id.TabIndex = 67;
            this.lbl_id.Text = "<>";
            this.lbl_id.Visible = false;
            // 
            // lbl_rating
            // 
            this.lbl_rating.AutoSize = true;
            this.lbl_rating.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rating.ForeColor = System.Drawing.Color.Teal;
            this.lbl_rating.Location = new System.Drawing.Point(290, 297);
            this.lbl_rating.Name = "lbl_rating";
            this.lbl_rating.Size = new System.Drawing.Size(15, 18);
            this.lbl_rating.TabIndex = 66;
            this.lbl_rating.Text = "1";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(473, 299);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(19, 14);
            this.label17.TabIndex = 65;
            this.label17.Text = "10";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(96, 299);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(13, 14);
            this.label16.TabIndex = 64;
            this.label16.Text = "1";
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new System.Drawing.Point(93, 263);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(400, 45);
            this.trackBar1.TabIndex = 63;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // cmb_fueltype
            // 
            this.cmb_fueltype.FormattingEnabled = true;
            this.cmb_fueltype.Items.AddRange(new object[] {
            "Petrol",
            "Diesel"});
            this.cmb_fueltype.Location = new System.Drawing.Point(344, 89);
            this.cmb_fueltype.Name = "cmb_fueltype";
            this.cmb_fueltype.Size = new System.Drawing.Size(150, 22);
            this.cmb_fueltype.TabIndex = 62;
            // 
            // txt_outstndingalert
            // 
            this.txt_outstndingalert.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_outstndingalert.DecimalPlaces = 2;
            this.txt_outstndingalert.Location = new System.Drawing.Point(99, 164);
            this.txt_outstndingalert.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.txt_outstndingalert.Name = "txt_outstndingalert";
            this.txt_outstndingalert.Size = new System.Drawing.Size(110, 22);
            this.txt_outstndingalert.TabIndex = 61;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 166);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 14);
            this.label14.TabIndex = 60;
            this.label14.Text = "Out:Stdn: Alert";
            // 
            // cmb_fueltypes
            // 
            this.cmb_fueltypes.FormattingEnabled = true;
            this.cmb_fueltypes.Items.AddRange(new object[] {
            "Very Good",
            "Good",
            "Poor",
            "Week"});
            this.cmb_fueltypes.Location = new System.Drawing.Point(99, 237);
            this.cmb_fueltypes.Name = "cmb_fueltypes";
            this.cmb_fueltypes.Size = new System.Drawing.Size(150, 22);
            this.cmb_fueltypes.TabIndex = 59;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 240);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 14);
            this.label13.TabIndex = 58;
            this.label13.Text = "Customer Status";
            // 
            // txt_remarks
            // 
            this.txt_remarks.Location = new System.Drawing.Point(99, 189);
            this.txt_remarks.Multiline = true;
            this.txt_remarks.Name = "txt_remarks";
            this.txt_remarks.Size = new System.Drawing.Size(394, 42);
            this.txt_remarks.TabIndex = 57;
            // 
            // txt_model
            // 
            this.txt_model.Location = new System.Drawing.Point(345, 114);
            this.txt_model.Name = "txt_model";
            this.txt_model.Size = new System.Drawing.Size(150, 22);
            this.txt_model.TabIndex = 55;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 197);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 14);
            this.label12.TabIndex = 56;
            this.label12.Text = "Remarks";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(253, 117);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 14);
            this.label11.TabIndex = 54;
            this.label11.Text = "Model";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(253, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 14);
            this.label10.TabIndex = 52;
            this.label10.Text = "Fuel Type";
            // 
            // txt_chessisno
            // 
            this.txt_chessisno.Location = new System.Drawing.Point(344, 64);
            this.txt_chessisno.Name = "txt_chessisno";
            this.txt_chessisno.Size = new System.Drawing.Size(150, 22);
            this.txt_chessisno.TabIndex = 51;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(253, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 14);
            this.label9.TabIndex = 50;
            this.label9.Text = "Chassis No";
            // 
            // txt_make
            // 
            this.txt_make.Location = new System.Drawing.Point(99, 114);
            this.txt_make.Name = "txt_make";
            this.txt_make.Size = new System.Drawing.Size(150, 22);
            this.txt_make.TabIndex = 49;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 14);
            this.label8.TabIndex = 48;
            this.label8.Text = "Make ";
            // 
            // txt_type
            // 
            this.txt_type.Location = new System.Drawing.Point(99, 89);
            this.txt_type.Name = "txt_type";
            this.txt_type.Size = new System.Drawing.Size(150, 22);
            this.txt_type.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 14);
            this.label7.TabIndex = 46;
            this.label7.Text = "Vehicle Type";
            // 
            // txt_engineNo
            // 
            this.txt_engineNo.Location = new System.Drawing.Point(99, 64);
            this.txt_engineNo.Name = "txt_engineNo";
            this.txt_engineNo.Size = new System.Drawing.Size(150, 22);
            this.txt_engineNo.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 14);
            this.label6.TabIndex = 44;
            this.label6.Text = "Engine No";
            // 
            // txt_vehregno
            // 
            this.txt_vehregno.Location = new System.Drawing.Point(99, 14);
            this.txt_vehregno.Name = "txt_vehregno";
            this.txt_vehregno.Size = new System.Drawing.Size(180, 22);
            this.txt_vehregno.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 14);
            this.label5.TabIndex = 41;
            this.label5.Text = "Rating";
            // 
            // txt_outstnd
            // 
            this.txt_outstnd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_outstnd.DecimalPlaces = 2;
            this.txt_outstnd.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txt_outstnd.Location = new System.Drawing.Point(344, 138);
            this.txt_outstnd.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.txt_outstnd.Name = "txt_outstnd";
            this.txt_outstnd.ReadOnly = true;
            this.txt_outstnd.Size = new System.Drawing.Size(111, 22);
            this.txt_outstnd.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 14);
            this.label1.TabIndex = 39;
            this.label1.Text = "Outstanding";
            // 
            // txt_crelimit
            // 
            this.txt_crelimit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_crelimit.DecimalPlaces = 2;
            this.txt_crelimit.Location = new System.Drawing.Point(99, 139);
            this.txt_crelimit.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.txt_crelimit.Name = "txt_crelimit";
            this.txt_crelimit.Size = new System.Drawing.Size(111, 22);
            this.txt_crelimit.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 14);
            this.label3.TabIndex = 37;
            this.label3.Text = "Credit Limit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 14);
            this.label2.TabIndex = 36;
            this.label2.Text = "Vehicle Name";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(99, 39);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(394, 22);
            this.txt_name.TabIndex = 35;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 17);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(91, 14);
            this.label15.TabIndex = 34;
            this.label15.Text = "Registration No";
            // 
            // frm_vehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 478);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_header);
            this.Controls.Add(this.pnl_footer);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frm_vehicle";
            this.Text = "frm_vehicle";
            this.Load += new System.EventHandler(this.frm_vehicle_Load);
            this.pnl_header.ResumeLayout(false);
            this.pnl_header.PerformLayout();
            this.pnl_footer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_outstndingalert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_outstnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_crelimit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_header;
        private System.Windows.Forms.Label lbl_headerpaneltext;
        private System.Windows.Forms.Panel pnl_footer;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lst_vehicles;
        private System.Windows.Forms.ComboBox cmb_customers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_savepump;
        private System.Windows.Forms.NumericUpDown txt_outstndingalert;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmb_fueltypes;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_remarks;
        private System.Windows.Forms.TextBox txt_model;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_chessisno;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_make;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_type;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_engineNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_vehregno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown txt_outstnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown txt_crelimit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmb_fueltype;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lbl_rating;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label lbl_id;
    }
}