namespace FSMS.UI
{
    partial class frm_employees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_employees));
            this.btn_save = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_print = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.lbl_id = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txt_passcode = new System.Windows.Forms.TextBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_sotrate = new System.Windows.Forms.NumericUpDown();
            this.txt_otrate = new System.Windows.Forms.NumericUpDown();
            this.txt_settle = new System.Windows.Forms.NumericUpDown();
            this.txt_outst = new System.Windows.Forms.NumericUpDown();
            this.txt_shr = new System.Windows.Forms.NumericUpDown();
            this.txt_cih = new System.Windows.Forms.NumericUpDown();
            this.txt_hrate = new System.Windows.Forms.NumericUpDown();
            this.txt_creditlimit = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_mobile = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_homepn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_code = new System.Windows.Forms.TextBox();
            this.dgmain = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OutStanding = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Settlement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_footer = new System.Windows.Forms.Panel();
            this.btn_update = new System.Windows.Forms.Button();
            this.lbl_headerpaneltext = new System.Windows.Forms.Label();
            this.pnl_header = new System.Windows.Forms.Panel();
            this.chk_ispumper = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_sotrate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_otrate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_settle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_outst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_shr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cih)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_hrate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_creditlimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgmain)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnl_footer.SuspendLayout();
            this.pnl_header.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.White;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.ImageIndex = 6;
            this.btn_save.ImageList = this.imageList1;
            this.btn_save.Location = new System.Drawing.Point(584, 4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(91, 35);
            this.btn_save.TabIndex = 59;
            this.btn_save.Text = "     Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
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
            // btn_print
            // 
            this.btn_print.BackColor = System.Drawing.Color.White;
            this.btn_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_print.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_print.ImageIndex = 5;
            this.btn_print.ImageList = this.imageList1;
            this.btn_print.Location = new System.Drawing.Point(875, 4);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(91, 35);
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
            this.btn_exit.Location = new System.Drawing.Point(972, 4);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(91, 35);
            this.btn_exit.TabIndex = 63;
            this.btn_exit.Text = "       Exit";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(3, 3);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(19, 13);
            this.lbl_id.TabIndex = 4;
            this.lbl_id.Text = "<>";
            this.lbl_id.Visible = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pass Code";
            // 
            // txt_passcode
            // 
            this.txt_passcode.Location = new System.Drawing.Point(97, 46);
            this.txt_passcode.Name = "txt_passcode";
            this.txt_passcode.Size = new System.Drawing.Size(133, 20);
            this.txt_passcode.TabIndex = 2;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.White;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete.ImageIndex = 1;
            this.btn_delete.ImageList = this.imageList1;
            this.btn_delete.Location = new System.Drawing.Point(778, 4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(91, 35);
            this.btn_delete.TabIndex = 61;
            this.btn_delete.Text = "     Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employee Code";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.chk_ispumper);
            this.panel2.Controls.Add(this.txt_sotrate);
            this.panel2.Controls.Add(this.txt_otrate);
            this.panel2.Controls.Add(this.txt_settle);
            this.panel2.Controls.Add(this.txt_outst);
            this.panel2.Controls.Add(this.txt_shr);
            this.panel2.Controls.Add(this.txt_cih);
            this.panel2.Controls.Add(this.txt_hrate);
            this.panel2.Controls.Add(this.txt_creditlimit);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txt_mobile);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txt_homepn);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txt_name);
            this.panel2.Controls.Add(this.lbl_id);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txt_passcode);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txt_code);
            this.panel2.Location = new System.Drawing.Point(579, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(497, 311);
            this.panel2.TabIndex = 84;
            // 
            // txt_sotrate
            // 
            this.txt_sotrate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_sotrate.DecimalPlaces = 2;
            this.txt_sotrate.Location = new System.Drawing.Point(354, 189);
            this.txt_sotrate.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txt_sotrate.Name = "txt_sotrate";
            this.txt_sotrate.Size = new System.Drawing.Size(133, 20);
            this.txt_sotrate.TabIndex = 35;
            // 
            // txt_otrate
            // 
            this.txt_otrate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_otrate.DecimalPlaces = 2;
            this.txt_otrate.Location = new System.Drawing.Point(354, 163);
            this.txt_otrate.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txt_otrate.Name = "txt_otrate";
            this.txt_otrate.Size = new System.Drawing.Size(133, 20);
            this.txt_otrate.TabIndex = 34;
            // 
            // txt_settle
            // 
            this.txt_settle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_settle.DecimalPlaces = 2;
            this.txt_settle.Location = new System.Drawing.Point(97, 189);
            this.txt_settle.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txt_settle.Name = "txt_settle";
            this.txt_settle.Size = new System.Drawing.Size(133, 20);
            this.txt_settle.TabIndex = 33;
            // 
            // txt_outst
            // 
            this.txt_outst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_outst.DecimalPlaces = 2;
            this.txt_outst.Location = new System.Drawing.Point(98, 163);
            this.txt_outst.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txt_outst.Name = "txt_outst";
            this.txt_outst.Size = new System.Drawing.Size(133, 20);
            this.txt_outst.TabIndex = 32;
            // 
            // txt_shr
            // 
            this.txt_shr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_shr.DecimalPlaces = 2;
            this.txt_shr.Location = new System.Drawing.Point(354, 137);
            this.txt_shr.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txt_shr.Name = "txt_shr";
            this.txt_shr.Size = new System.Drawing.Size(133, 20);
            this.txt_shr.TabIndex = 31;
            // 
            // txt_cih
            // 
            this.txt_cih.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_cih.DecimalPlaces = 2;
            this.txt_cih.Location = new System.Drawing.Point(97, 137);
            this.txt_cih.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txt_cih.Name = "txt_cih";
            this.txt_cih.Size = new System.Drawing.Size(133, 20);
            this.txt_cih.TabIndex = 30;
            // 
            // txt_hrate
            // 
            this.txt_hrate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_hrate.DecimalPlaces = 2;
            this.txt_hrate.Location = new System.Drawing.Point(354, 111);
            this.txt_hrate.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txt_hrate.Name = "txt_hrate";
            this.txt_hrate.Size = new System.Drawing.Size(133, 20);
            this.txt_hrate.TabIndex = 29;
            // 
            // txt_creditlimit
            // 
            this.txt_creditlimit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_creditlimit.DecimalPlaces = 2;
            this.txt_creditlimit.Location = new System.Drawing.Point(97, 111);
            this.txt_creditlimit.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txt_creditlimit.Name = "txt_creditlimit";
            this.txt_creditlimit.Size = new System.Drawing.Size(133, 20);
            this.txt_creditlimit.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(247, 191);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "Special OT Rate";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(247, 139);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Special Hourly Rate";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(247, 165);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "OT Rate";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 191);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Settlements";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "OutStandings";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(247, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Hourly Rate";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Cash In Hand";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Credit Limit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(247, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Mobile";
            // 
            // txt_mobile
            // 
            this.txt_mobile.Location = new System.Drawing.Point(355, 44);
            this.txt_mobile.Name = "txt_mobile";
            this.txt_mobile.Size = new System.Drawing.Size(133, 20);
            this.txt_mobile.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(247, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Home Phone";
            // 
            // txt_homepn
            // 
            this.txt_homepn.Location = new System.Drawing.Point(355, 18);
            this.txt_homepn.Name = "txt_homepn";
            this.txt_homepn.Size = new System.Drawing.Size(133, 20);
            this.txt_homepn.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Name";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(97, 72);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(391, 20);
            this.txt_name.TabIndex = 5;
            // 
            // txt_code
            // 
            this.txt_code.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(233)))), ((int)(((byte)(246)))));
            this.txt_code.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_code.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(107)))), ((int)(((byte)(192)))));
            this.txt_code.Location = new System.Drawing.Point(97, 18);
            this.txt_code.Name = "txt_code";
            this.txt_code.Size = new System.Drawing.Size(133, 22);
            this.txt_code.TabIndex = 0;
            this.txt_code.Text = "AA";
            // 
            // dgmain
            // 
            this.dgmain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgmain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.EmployeeCode,
            this.EmployeeName,
            this.Mobile,
            this.OutStanding,
            this.Settlement});
            this.dgmain.Location = new System.Drawing.Point(6, 3);
            this.dgmain.Name = "dgmain";
            this.dgmain.Size = new System.Drawing.Size(549, 301);
            this.dgmain.TabIndex = 0;
            this.dgmain.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgmain_RowEnter);
            // 
            // id
            // 
            this.id.DataPropertyName = "Id";
            this.id.HeaderText = "#";
            this.id.Name = "id";
            this.id.Width = 50;
            // 
            // EmployeeCode
            // 
            this.EmployeeCode.DataPropertyName = "EmployeeCode";
            this.EmployeeCode.HeaderText = "EmployeeCode";
            this.EmployeeCode.Name = "EmployeeCode";
            // 
            // EmployeeName
            // 
            this.EmployeeName.DataPropertyName = "EmployeeName";
            this.EmployeeName.HeaderText = "EmployeeName";
            this.EmployeeName.Name = "EmployeeName";
            // 
            // Mobile
            // 
            this.Mobile.DataPropertyName = "Mobile";
            this.Mobile.HeaderText = "Mobile";
            this.Mobile.Name = "Mobile";
            // 
            // OutStanding
            // 
            this.OutStanding.DataPropertyName = "OutStanding";
            this.OutStanding.HeaderText = "OutStanding";
            this.OutStanding.Name = "OutStanding";
            // 
            // Settlement
            // 
            this.Settlement.DataPropertyName = "Settlement";
            this.Settlement.HeaderText = "Settlement";
            this.Settlement.Name = "Settlement";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dgmain);
            this.panel1.Location = new System.Drawing.Point(13, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 311);
            this.panel1.TabIndex = 83;
            // 
            // pnl_footer
            // 
            this.pnl_footer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(53)))), ((int)(((byte)(68)))));
            this.pnl_footer.Controls.Add(this.btn_update);
            this.pnl_footer.Controls.Add(this.btn_save);
            this.pnl_footer.Controls.Add(this.btn_print);
            this.pnl_footer.Controls.Add(this.btn_delete);
            this.pnl_footer.Controls.Add(this.btn_exit);
            this.pnl_footer.Location = new System.Drawing.Point(0, 360);
            this.pnl_footer.Name = "pnl_footer";
            this.pnl_footer.Size = new System.Drawing.Size(1076, 45);
            this.pnl_footer.TabIndex = 82;
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.White;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_update.ImageIndex = 8;
            this.btn_update.ImageList = this.imageList1;
            this.btn_update.Location = new System.Drawing.Point(681, 4);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(91, 35);
            this.btn_update.TabIndex = 65;
            this.btn_update.Text = "       Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
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
            // pnl_header
            // 
            this.pnl_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(108)))), ((int)(((byte)(139)))));
            this.pnl_header.Controls.Add(this.lbl_headerpaneltext);
            this.pnl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_header.Location = new System.Drawing.Point(0, 0);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Size = new System.Drawing.Size(1088, 37);
            this.pnl_header.TabIndex = 81;
            // 
            // chk_ispumper
            // 
            this.chk_ispumper.AutoSize = true;
            this.chk_ispumper.Location = new System.Drawing.Point(97, 216);
            this.chk_ispumper.Name = "chk_ispumper";
            this.chk_ispumper.Size = new System.Drawing.Size(81, 17);
            this.chk_ispumper.TabIndex = 36;
            this.chk_ispumper.Text = "Is a pumper";
            this.chk_ispumper.UseVisualStyleBackColor = true;
            // 
            // frm_employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 412);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_footer);
            this.Controls.Add(this.pnl_header);
            this.Name = "frm_employees";
            this.Text = "frm_employees";
            this.Load += new System.EventHandler(this.frm_employees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_sotrate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_otrate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_settle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_outst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_shr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cih)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_hrate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_creditlimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgmain)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pnl_footer.ResumeLayout(false);
            this.pnl_header.ResumeLayout(false);
            this.pnl_header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_passcode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_code;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgmain;
        private System.Windows.Forms.Panel pnl_footer;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Panel pnl_header;
        private System.Windows.Forms.Label lbl_headerpaneltext;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_mobile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_homepn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.NumericUpDown txt_sotrate;
        private System.Windows.Forms.NumericUpDown txt_otrate;
        private System.Windows.Forms.NumericUpDown txt_settle;
        private System.Windows.Forms.NumericUpDown txt_outst;
        private System.Windows.Forms.NumericUpDown txt_shr;
        private System.Windows.Forms.NumericUpDown txt_cih;
        private System.Windows.Forms.NumericUpDown txt_hrate;
        private System.Windows.Forms.NumericUpDown txt_creditlimit;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn OutStanding;
        private System.Windows.Forms.DataGridViewTextBoxColumn Settlement;
        private System.Windows.Forms.CheckBox chk_ispumper;
    }
}