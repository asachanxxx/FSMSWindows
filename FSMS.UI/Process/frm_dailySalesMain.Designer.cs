namespace FSMS.UI
{
    partial class frm_dailySalesMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_dailySalesMain));
            this.pnl_header = new System.Windows.Forms.Panel();
            this.lbl_headerpaneltext = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pnl_footer = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.lst_nozzels = new System.Windows.Forms.ListView();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_asdasdas = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_totalValss = new System.Windows.Forms.Label();
            this.lbl_saletype = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lst_dailydet = new System.Windows.Forms.ListView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_diff = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_systemtotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_totalCollection = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_cash = new System.Windows.Forms.Label();
            this.lbl_othertotal = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl_other = new System.Windows.Forms.Label();
            this.lbl_card = new System.Windows.Forms.Label();
            this.lbl_expense = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lbl_expenses = new System.Windows.Forms.Label();
            this.lbl_Voucher = new System.Windows.Forms.Label();
            this.dgmain = new System.Windows.Forms.DataGridView();
            this.Day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VehicleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CardReferance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VoucherNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_show = new System.Windows.Forms.Button();
            this.cmb_pumper = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_days = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.pnl_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.pnl_footer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgmain)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_header
            // 
            this.pnl_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(108)))), ((int)(((byte)(139)))));
            this.pnl_header.Controls.Add(this.lbl_headerpaneltext);
            this.pnl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_header.Location = new System.Drawing.Point(0, 0);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Size = new System.Drawing.Size(997, 40);
            this.pnl_header.TabIndex = 89;
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
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
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
            // pnl_footer
            // 
            this.pnl_footer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(53)))), ((int)(((byte)(68)))));
            this.pnl_footer.Controls.Add(this.button1);
            this.pnl_footer.Controls.Add(this.btn_exit);
            this.pnl_footer.Location = new System.Drawing.Point(6, 516);
            this.pnl_footer.Name = "pnl_footer";
            this.pnl_footer.Size = new System.Drawing.Size(966, 48);
            this.pnl_footer.TabIndex = 90;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageIndex = 5;
            this.button1.ImageList = this.imageList1;
            this.button1.Location = new System.Drawing.Point(769, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 38);
            this.button1.TabIndex = 64;
            this.button1.Text = "       Print";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.White;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_exit.ImageIndex = 10;
            this.btn_exit.ImageList = this.imageList1;
            this.btn_exit.Location = new System.Drawing.Point(866, 4);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(91, 38);
            this.btn_exit.TabIndex = 63;
            this.btn_exit.Text = "       Exit";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.dgmain);
            this.panel1.Location = new System.Drawing.Point(10, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(962, 409);
            this.panel1.TabIndex = 100;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.lst_nozzels);
            this.panel6.Location = new System.Drawing.Point(3, 5);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(279, 113);
            this.panel6.TabIndex = 109;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Purple;
            this.label8.Location = new System.Drawing.Point(5, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(168, 23);
            this.label8.TabIndex = 2;
            this.label8.Text = "Nozzels For Pumper";
            // 
            // lst_nozzels
            // 
            this.lst_nozzels.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lst_nozzels.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_nozzels.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lst_nozzels.LargeImageList = this.imageList2;
            this.lst_nozzels.Location = new System.Drawing.Point(3, 29);
            this.lst_nozzels.Name = "lst_nozzels";
            this.lst_nozzels.Size = new System.Drawing.Size(271, 76);
            this.lst_nozzels.SmallImageList = this.imageList2;
            this.lst_nozzels.TabIndex = 0;
            this.lst_nozzels.UseCompatibleStateImageBehavior = false;
            this.lst_nozzels.SelectedIndexChanged += new System.EventHandler(this.lst_nozzels_SelectedIndexChanged);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "001-money.png");
            this.imageList2.Images.SetKeyName(1, "004-credit-cards-payment.png");
            this.imageList2.Images.SetKeyName(2, "003-voucher.png");
            this.imageList2.Images.SetKeyName(3, "007-currency.png");
            this.imageList2.Images.SetKeyName(4, "icons8-gas-pump-96.png");
            this.imageList2.Images.SetKeyName(5, "001-check-box-empty.png");
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lbl_asdasdas);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lbl_totalValss);
            this.panel2.Controls.Add(this.lbl_saletype);
            this.panel2.Location = new System.Drawing.Point(7, 362);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(275, 42);
            this.panel2.TabIndex = 108;
            // 
            // lbl_asdasdas
            // 
            this.lbl_asdasdas.AutoSize = true;
            this.lbl_asdasdas.Location = new System.Drawing.Point(154, 6);
            this.lbl_asdasdas.Name = "lbl_asdasdas";
            this.lbl_asdasdas.Size = new System.Drawing.Size(68, 14);
            this.lbl_asdasdas.TabIndex = 17;
            this.lbl_asdasdas.Text = "Total Value";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 14);
            this.label4.TabIndex = 16;
            this.label4.Text = "Sales Type";
            // 
            // lbl_totalValss
            // 
            this.lbl_totalValss.AutoSize = true;
            this.lbl_totalValss.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalValss.ForeColor = System.Drawing.Color.Violet;
            this.lbl_totalValss.Location = new System.Drawing.Point(153, 17);
            this.lbl_totalValss.Name = "lbl_totalValss";
            this.lbl_totalValss.Size = new System.Drawing.Size(85, 23);
            this.lbl_totalValss.TabIndex = 12;
            this.lbl_totalValss.Text = "...............";
            // 
            // lbl_saletype
            // 
            this.lbl_saletype.AutoSize = true;
            this.lbl_saletype.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_saletype.ForeColor = System.Drawing.Color.Violet;
            this.lbl_saletype.Location = new System.Drawing.Point(5, 17);
            this.lbl_saletype.Name = "lbl_saletype";
            this.lbl_saletype.Size = new System.Drawing.Size(85, 23);
            this.lbl_saletype.TabIndex = 10;
            this.lbl_saletype.Text = "...............";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.lst_dailydet);
            this.panel4.Location = new System.Drawing.Point(3, 124);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(279, 236);
            this.panel4.TabIndex = 107;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Purple;
            this.label3.Location = new System.Drawing.Point(3, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Pumper Sale Breakdown";
            // 
            // lst_dailydet
            // 
            this.lst_dailydet.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lst_dailydet.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_dailydet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lst_dailydet.LargeImageList = this.imageList2;
            this.lst_dailydet.Location = new System.Drawing.Point(3, 28);
            this.lst_dailydet.Name = "lst_dailydet";
            this.lst_dailydet.Size = new System.Drawing.Size(271, 203);
            this.lst_dailydet.SmallImageList = this.imageList2;
            this.lst_dailydet.TabIndex = 0;
            this.lst_dailydet.UseCompatibleStateImageBehavior = false;
            this.lst_dailydet.SelectedIndexChanged += new System.EventHandler(this.lst_dailydet_SelectedIndexChanged);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label17);
            this.panel5.Controls.Add(this.label16);
            this.panel5.Controls.Add(this.label15);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.lbl_diff);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.lbl_systemtotal);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.lbl_totalCollection);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.lbl_cash);
            this.panel5.Controls.Add(this.lbl_othertotal);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.lbl_other);
            this.panel5.Controls.Add(this.lbl_card);
            this.panel5.Controls.Add(this.lbl_expense);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Controls.Add(this.lbl_expenses);
            this.panel5.Controls.Add(this.lbl_Voucher);
            this.panel5.Location = new System.Drawing.Point(288, 290);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(669, 114);
            this.panel5.TabIndex = 106;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Gainsboro;
            this.label10.Location = new System.Drawing.Point(559, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 18);
            this.label10.TabIndex = 19;
            this.label10.Text = "DIfferance";
            // 
            // lbl_diff
            // 
            this.lbl_diff.AutoSize = true;
            this.lbl_diff.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_diff.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbl_diff.Location = new System.Drawing.Point(548, 77);
            this.lbl_diff.Name = "lbl_diff";
            this.lbl_diff.Size = new System.Drawing.Size(120, 33);
            this.lbl_diff.TabIndex = 20;
            this.lbl_diff.Text = "...............";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gainsboro;
            this.label7.Location = new System.Drawing.Point(410, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 18);
            this.label7.TabIndex = 17;
            this.label7.Text = "System  Total";
            // 
            // lbl_systemtotal
            // 
            this.lbl_systemtotal.AutoSize = true;
            this.lbl_systemtotal.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_systemtotal.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbl_systemtotal.Location = new System.Drawing.Point(407, 77);
            this.lbl_systemtotal.Name = "lbl_systemtotal";
            this.lbl_systemtotal.Size = new System.Drawing.Size(120, 33);
            this.lbl_systemtotal.TabIndex = 18;
            this.lbl_systemtotal.Text = "...............";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(559, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "Total Collection";
            // 
            // lbl_totalCollection
            // 
            this.lbl_totalCollection.AutoSize = true;
            this.lbl_totalCollection.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalCollection.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbl_totalCollection.Location = new System.Drawing.Point(548, 25);
            this.lbl_totalCollection.Name = "lbl_totalCollection";
            this.lbl_totalCollection.Size = new System.Drawing.Size(120, 33);
            this.lbl_totalCollection.TabIndex = 16;
            this.lbl_totalCollection.Text = "...............";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gainsboro;
            this.label9.Location = new System.Drawing.Point(4, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 14);
            this.label9.TabIndex = 5;
            this.label9.Text = "Cash Total";
            // 
            // lbl_cash
            // 
            this.lbl_cash.AutoSize = true;
            this.lbl_cash.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cash.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lbl_cash.Location = new System.Drawing.Point(4, 35);
            this.lbl_cash.Name = "lbl_cash";
            this.lbl_cash.Size = new System.Drawing.Size(45, 23);
            this.lbl_cash.TabIndex = 6;
            this.lbl_cash.Text = "0.00";
            // 
            // lbl_othertotal
            // 
            this.lbl_othertotal.AutoSize = true;
            this.lbl_othertotal.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_othertotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lbl_othertotal.Location = new System.Drawing.Point(433, 35);
            this.lbl_othertotal.Name = "lbl_othertotal";
            this.lbl_othertotal.Size = new System.Drawing.Size(45, 23);
            this.lbl_othertotal.TabIndex = 14;
            this.lbl_othertotal.Text = "0.00";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Gainsboro;
            this.label12.Location = new System.Drawing.Point(125, 14);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 14);
            this.label12.TabIndex = 7;
            this.label12.Text = "Card Total";
            // 
            // lbl_other
            // 
            this.lbl_other.AutoSize = true;
            this.lbl_other.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_other.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_other.Location = new System.Drawing.Point(438, 14);
            this.lbl_other.Name = "lbl_other";
            this.lbl_other.Size = new System.Drawing.Size(42, 14);
            this.lbl_other.TabIndex = 13;
            this.lbl_other.Text = "Testing";
            // 
            // lbl_card
            // 
            this.lbl_card.AutoSize = true;
            this.lbl_card.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_card.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lbl_card.Location = new System.Drawing.Point(123, 35);
            this.lbl_card.Name = "lbl_card";
            this.lbl_card.Size = new System.Drawing.Size(45, 23);
            this.lbl_card.TabIndex = 8;
            this.lbl_card.Text = "0.00";
            // 
            // lbl_expense
            // 
            this.lbl_expense.AutoSize = true;
            this.lbl_expense.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_expense.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lbl_expense.Location = new System.Drawing.Point(358, 35);
            this.lbl_expense.Name = "lbl_expense";
            this.lbl_expense.Size = new System.Drawing.Size(45, 23);
            this.lbl_expense.TabIndex = 12;
            this.lbl_expense.Text = "0.00";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Gainsboro;
            this.label14.Location = new System.Drawing.Point(240, 14);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 14);
            this.label14.TabIndex = 9;
            this.label14.Text = "Voucher Total";
            // 
            // lbl_expenses
            // 
            this.lbl_expenses.AutoSize = true;
            this.lbl_expenses.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_expenses.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_expenses.Location = new System.Drawing.Point(356, 14);
            this.lbl_expenses.Name = "lbl_expenses";
            this.lbl_expenses.Size = new System.Drawing.Size(53, 14);
            this.lbl_expenses.TabIndex = 11;
            this.lbl_expenses.Text = "Expenses";
            // 
            // lbl_Voucher
            // 
            this.lbl_Voucher.AutoSize = true;
            this.lbl_Voucher.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Voucher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lbl_Voucher.Location = new System.Drawing.Point(237, 35);
            this.lbl_Voucher.Name = "lbl_Voucher";
            this.lbl_Voucher.Size = new System.Drawing.Size(45, 23);
            this.lbl_Voucher.TabIndex = 10;
            this.lbl_Voucher.Text = "0.00";
            // 
            // dgmain
            // 
            this.dgmain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgmain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Day,
            this.EmployeeName,
            this.VehicleName,
            this.Bank,
            this.CardReferance,
            this.VoucherNO,
            this.Value});
            this.dgmain.Location = new System.Drawing.Point(288, 5);
            this.dgmain.Name = "dgmain";
            this.dgmain.Size = new System.Drawing.Size(669, 279);
            this.dgmain.TabIndex = 0;
            // 
            // Day
            // 
            this.Day.DataPropertyName = "Day";
            this.Day.HeaderText = "Day";
            this.Day.Name = "Day";
            // 
            // EmployeeName
            // 
            this.EmployeeName.DataPropertyName = "EmployeeName";
            this.EmployeeName.HeaderText = "Employee";
            this.EmployeeName.Name = "EmployeeName";
            // 
            // VehicleName
            // 
            this.VehicleName.DataPropertyName = "VehicleName";
            this.VehicleName.HeaderText = "Vehicle";
            this.VehicleName.Name = "VehicleName";
            // 
            // Bank
            // 
            this.Bank.DataPropertyName = "Bank";
            this.Bank.HeaderText = "Bank";
            this.Bank.Name = "Bank";
            // 
            // CardReferance
            // 
            this.CardReferance.DataPropertyName = "CardReferance";
            this.CardReferance.HeaderText = "Card No";
            this.CardReferance.Name = "CardReferance";
            // 
            // VoucherNO
            // 
            this.VoucherNO.DataPropertyName = "VoucherNO";
            this.VoucherNO.HeaderText = "Voucher NO";
            this.VoucherNO.Name = "VoucherNO";
            // 
            // Value
            // 
            this.Value.DataPropertyName = "Value";
            this.Value.HeaderText = "Amount";
            this.Value.Name = "Value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(534, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mr.";
            this.label2.Visible = false;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl_name.Location = new System.Drawing.Point(581, 8);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(105, 23);
            this.lbl_name.TabIndex = 8;
            this.lbl_name.Text = "...................";
            this.lbl_name.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btn_show);
            this.panel3.Controls.Add(this.cmb_pumper);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.lbl_name);
            this.panel3.Controls.Add(this.cmb_days);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(12, 46);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(960, 48);
            this.panel3.TabIndex = 104;
            // 
            // btn_show
            // 
            this.btn_show.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_show.Location = new System.Drawing.Point(442, 10);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(75, 25);
            this.btn_show.TabIndex = 70;
            this.btn_show.Text = "Show";
            this.btn_show.UseVisualStyleBackColor = true;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // cmb_pumper
            // 
            this.cmb_pumper.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_pumper.FormattingEnabled = true;
            this.cmb_pumper.Items.AddRange(new object[] {
            "Unoccupied ",
            "Assigned ",
            "Cancel ",
            "Damage"});
            this.cmb_pumper.Location = new System.Drawing.Point(264, 12);
            this.cmb_pumper.Name = "cmb_pumper";
            this.cmb_pumper.Size = new System.Drawing.Size(172, 22);
            this.cmb_pumper.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(216, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 14);
            this.label5.TabIndex = 17;
            this.label5.Text = "Pumper";
            // 
            // cmb_days
            // 
            this.cmb_days.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_days.FormattingEnabled = true;
            this.cmb_days.Items.AddRange(new object[] {
            "Unoccupied ",
            "Assigned ",
            "Cancel ",
            "Damage"});
            this.cmb_days.Location = new System.Drawing.Point(69, 12);
            this.cmb_days.Name = "cmb_days";
            this.cmb_days.Size = new System.Drawing.Size(144, 22);
            this.cmb_days.TabIndex = 16;
            this.cmb_days.SelectedIndexChanged += new System.EventHandler(this.cmb_days_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 14);
            this.label6.TabIndex = 15;
            this.label6.Text = "Day Start";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Gainsboro;
            this.label11.Location = new System.Drawing.Point(85, 1);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 42);
            this.label11.TabIndex = 21;
            this.label11.Text = "+";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Gainsboro;
            this.label13.Location = new System.Drawing.Point(207, 1);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 42);
            this.label13.TabIndex = 22;
            this.label13.Text = "+";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Gainsboro;
            this.label15.Location = new System.Drawing.Point(319, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 42);
            this.label15.TabIndex = 23;
            this.label15.Text = "+";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Gainsboro;
            this.label16.Location = new System.Drawing.Point(406, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 42);
            this.label16.TabIndex = 24;
            this.label16.Text = "+";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Gainsboro;
            this.label17.Location = new System.Drawing.Point(507, 13);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 42);
            this.label17.TabIndex = 25;
            this.label17.Text = "=";
            // 
            // frm_dailySalesMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 564);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_header);
            this.Controls.Add(this.pnl_footer);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frm_dailySalesMain";
            this.Text = "frm_dailySalesMain";
            this.Load += new System.EventHandler(this.frm_dailySalesMain_Load);
            this.pnl_header.ResumeLayout(false);
            this.pnl_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.pnl_footer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgmain)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_header;
        private System.Windows.Forms.Label lbl_headerpaneltext;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel pnl_footer;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgmain;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cmb_days;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_pumper;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_othertotal;
        private System.Windows.Forms.Label lbl_other;
        private System.Windows.Forms.Label lbl_expense;
        private System.Windows.Forms.Label lbl_expenses;
        private System.Windows.Forms.Label lbl_Voucher;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbl_card;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbl_cash;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ListView lst_dailydet;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_totalValss;
        private System.Windows.Forms.Label lbl_saletype;
        private System.Windows.Forms.Label lbl_asdasdas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehicleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bank;
        private System.Windows.Forms.DataGridViewTextBoxColumn CardReferance;
        private System.Windows.Forms.DataGridViewTextBoxColumn VoucherNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ListView lst_nozzels;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_diff;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_systemtotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_totalCollection;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
    }
}