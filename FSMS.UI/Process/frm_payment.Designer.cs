namespace FSMS.UI.Process
{
    partial class frm_payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_payment));
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.dgmain = new System.Windows.Forms.DataGridView();
            this.Sequence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PayType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaiedAmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CQno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CQDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_memo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_ManualNo = new System.Windows.Forms.TextBox();
            this.txt_RefNo = new System.Windows.Forms.TextBox();
            this.dte_date = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_recivedfrom = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_Remarks = new System.Windows.Forms.TextBox();
            this.txt_recno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.num_totalpay = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.Session = new System.Windows.Forms.Label();
            this.cmb_customer = new System.Windows.Forms.ComboBox();
            this.btn_show = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_balance = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_paied = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_outstandings = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_creditLinit = new System.Windows.Forms.Label();
            this.lbl_rank = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl_other = new System.Windows.Forms.Label();
            this.pnl_header = new System.Windows.Forms.Panel();
            this.lbl_headerpaneltext = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pnl_footer = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btn_cqadd = new System.Windows.Forms.Button();
            this.btn_cqclose = new System.Windows.Forms.Button();
            this.dte_CQDate = new System.Windows.Forms.DateTimePicker();
            this.label28 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.txt_CQNO = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmb_paycode = new System.Windows.Forms.ComboBox();
            this.chk_subtot = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_remaining = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_amt = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbl_limitAlert = new System.Windows.Forms.Label();
            this.lbl_cqbalance = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lbl_expenses = new System.Windows.Forms.Label();
            this.lbl_cqlimit = new System.Windows.Forms.Label();
            this.txt_BANK = new System.Windows.Forms.ComboBox();
            this.txt_branch = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgmain)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_totalpay)).BeginInit();
            this.panel3.SuspendLayout();
            this.pnl_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.pnl_footer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(9, 308);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(84, 17);
            this.checkBox1.TabIndex = 31;
            this.checkBox1.Text = "This is Final ";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(220)))));
            this.label27.Location = new System.Drawing.Point(118, 265);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(23, 14);
            this.label27.TabIndex = 30;
            this.label27.Text = "RS.";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(220)))));
            this.label26.Location = new System.Drawing.Point(118, 233);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(23, 14);
            this.label26.TabIndex = 29;
            this.label26.Text = "RS.";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(220)))));
            this.label25.Location = new System.Drawing.Point(118, 194);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(23, 14);
            this.label25.TabIndex = 28;
            this.label25.Text = "RS.";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(220)))));
            this.label23.Location = new System.Drawing.Point(139, 111);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(23, 14);
            this.label23.TabIndex = 26;
            this.label23.Text = "RS.";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(220)))));
            this.label22.Location = new System.Drawing.Point(139, 80);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(23, 14);
            this.label22.TabIndex = 25;
            this.label22.Text = "RS.";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(220)))));
            this.label21.Location = new System.Drawing.Point(139, 51);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(23, 14);
            this.label21.TabIndex = 24;
            this.label21.Text = "RS.";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(220)))));
            this.label20.Location = new System.Drawing.Point(139, 20);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(23, 14);
            this.label20.TabIndex = 23;
            this.label20.Text = "RS.";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(5, 285);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(281, 19);
            this.label19.TabIndex = 22;
            this.label19.Text = "__________________________________";
            // 
            // dgmain
            // 
            this.dgmain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgmain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sequence,
            this.PayType,
            this.TotalPay,
            this.PaiedAmt,
            this.CQno,
            this.CQDate});
            this.dgmain.Location = new System.Drawing.Point(3, 225);
            this.dgmain.Name = "dgmain";
            this.dgmain.Size = new System.Drawing.Size(673, 190);
            this.dgmain.TabIndex = 0;
            // 
            // Sequence
            // 
            this.Sequence.DataPropertyName = "Sequence";
            this.Sequence.HeaderText = "Sequence";
            this.Sequence.Name = "Sequence";
            // 
            // PayType
            // 
            this.PayType.DataPropertyName = "PaytypeDesc";
            this.PayType.HeaderText = "PayType";
            this.PayType.Name = "PayType";
            // 
            // TotalPay
            // 
            this.TotalPay.DataPropertyName = "HeadAmt ";
            this.TotalPay.HeaderText = "TotalPay";
            this.TotalPay.Name = "TotalPay";
            // 
            // PaiedAmt
            // 
            this.PaiedAmt.DataPropertyName = "PaiedAmt";
            this.PaiedAmt.HeaderText = "PaiedAmt";
            this.PaiedAmt.Name = "PaiedAmt";
            // 
            // CQno
            // 
            this.CQno.DataPropertyName = "CQNo ";
            this.CQno.HeaderText = "CQno";
            this.CQno.Name = "CQno";
            // 
            // CQDate
            // 
            this.CQDate.DataPropertyName = "CQDate";
            this.CQDate.HeaderText = "CQDate";
            this.CQDate.Name = "CQDate";
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
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.txt_memo);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.txt_ManualNo);
            this.panel4.Controls.Add(this.txt_RefNo);
            this.panel4.Controls.Add(this.dte_date);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.txt_recivedfrom);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.txt_Remarks);
            this.panel4.Controls.Add(this.txt_recno);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.num_totalpay);
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(673, 153);
            this.panel4.TabIndex = 107;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(10, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 14);
            this.label6.TabIndex = 122;
            this.label6.Text = "Memo";
            // 
            // txt_memo
            // 
            this.txt_memo.BackColor = System.Drawing.Color.White;
            this.txt_memo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_memo.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_memo.Location = new System.Drawing.Point(89, 93);
            this.txt_memo.Name = "txt_memo";
            this.txt_memo.Size = new System.Drawing.Size(565, 21);
            this.txt_memo.TabIndex = 121;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(438, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 14);
            this.label8.TabIndex = 120;
            this.label8.Text = "Manual No";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(438, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 14);
            this.label11.TabIndex = 119;
            this.label11.Text = "Referance No";
            // 
            // txt_ManualNo
            // 
            this.txt_ManualNo.BackColor = System.Drawing.Color.White;
            this.txt_ManualNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ManualNo.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ManualNo.Location = new System.Drawing.Point(524, 66);
            this.txt_ManualNo.Name = "txt_ManualNo";
            this.txt_ManualNo.Size = new System.Drawing.Size(130, 21);
            this.txt_ManualNo.TabIndex = 118;
            // 
            // txt_RefNo
            // 
            this.txt_RefNo.BackColor = System.Drawing.Color.White;
            this.txt_RefNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_RefNo.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_RefNo.Location = new System.Drawing.Point(524, 39);
            this.txt_RefNo.Name = "txt_RefNo";
            this.txt_RefNo.Size = new System.Drawing.Size(130, 21);
            this.txt_RefNo.TabIndex = 117;
            // 
            // dte_date
            // 
            this.dte_date.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dte_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dte_date.Location = new System.Drawing.Point(524, 9);
            this.dte_date.Name = "dte_date";
            this.dte_date.Size = new System.Drawing.Size(130, 21);
            this.dte_date.TabIndex = 116;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(438, 13);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 14);
            this.label15.TabIndex = 115;
            this.label15.Text = "Creation Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(10, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 14);
            this.label5.TabIndex = 114;
            this.label5.Text = "Remarks";
            // 
            // txt_recivedfrom
            // 
            this.txt_recivedfrom.BackColor = System.Drawing.Color.White;
            this.txt_recivedfrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_recivedfrom.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_recivedfrom.Location = new System.Drawing.Point(89, 120);
            this.txt_recivedfrom.Name = "txt_recivedfrom";
            this.txt_recivedfrom.Size = new System.Drawing.Size(565, 21);
            this.txt_recivedfrom.TabIndex = 113;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(10, 122);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 14);
            this.label13.TabIndex = 112;
            this.label13.Text = "Recived From";
            // 
            // txt_Remarks
            // 
            this.txt_Remarks.BackColor = System.Drawing.Color.White;
            this.txt_Remarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Remarks.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Remarks.Location = new System.Drawing.Point(89, 66);
            this.txt_Remarks.Name = "txt_Remarks";
            this.txt_Remarks.Size = new System.Drawing.Size(291, 21);
            this.txt_Remarks.TabIndex = 111;
            // 
            // txt_recno
            // 
            this.txt_recno.BackColor = System.Drawing.Color.White;
            this.txt_recno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_recno.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_recno.Location = new System.Drawing.Point(89, 11);
            this.txt_recno.Name = "txt_recno";
            this.txt_recno.Size = new System.Drawing.Size(128, 23);
            this.txt_recno.TabIndex = 109;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(10, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 14);
            this.label3.TabIndex = 110;
            this.label3.Text = "Receipt No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 107;
            this.label2.Text = "Amount";
            // 
            // num_totalpay
            // 
            this.num_totalpay.BackColor = System.Drawing.Color.White;
            this.num_totalpay.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.num_totalpay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.num_totalpay.InterceptArrowKeys = false;
            this.num_totalpay.Location = new System.Drawing.Point(89, 37);
            this.num_totalpay.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.num_totalpay.Minimum = new decimal(new int[] {
            1215752192,
            23,
            0,
            -2147483648});
            this.num_totalpay.Name = "num_totalpay";
            this.num_totalpay.Size = new System.Drawing.Size(131, 23);
            this.num_totalpay.TabIndex = 108;
            this.num_totalpay.ThousandsSeparator = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(5, 159);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(281, 19);
            this.label18.TabIndex = 21;
            this.label18.Text = "__________________________________";
            // 
            // Session
            // 
            this.Session.AutoSize = true;
            this.Session.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Session.Location = new System.Drawing.Point(9, 11);
            this.Session.Name = "Session";
            this.Session.Size = new System.Drawing.Size(97, 15);
            this.Session.TabIndex = 111;
            this.Session.Text = "Select Customer";
            // 
            // cmb_customer
            // 
            this.cmb_customer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_customer.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_customer.FormattingEnabled = true;
            this.cmb_customer.Location = new System.Drawing.Point(121, 8);
            this.cmb_customer.Name = "cmb_customer";
            this.cmb_customer.Size = new System.Drawing.Size(196, 23);
            this.cmb_customer.TabIndex = 110;
            // 
            // btn_show
            // 
            this.btn_show.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_show.Location = new System.Drawing.Point(323, 7);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(75, 25);
            this.btn_show.TabIndex = 70;
            this.btn_show.Text = "Show";
            this.btn_show.UseVisualStyleBackColor = true;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.Session);
            this.panel3.Controls.Add(this.cmb_customer);
            this.panel3.Controls.Add(this.btn_show);
            this.panel3.Location = new System.Drawing.Point(10, 51);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(974, 41);
            this.panel3.TabIndex = 108;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(164)))), ((int)(((byte)(174)))));
            this.label10.Location = new System.Drawing.Point(6, 262);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 18);
            this.label10.TabIndex = 19;
            this.label10.Text = "Balance ...........";
            // 
            // lbl_balance
            // 
            this.lbl_balance.AutoSize = true;
            this.lbl_balance.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_balance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.lbl_balance.Location = new System.Drawing.Point(137, 254);
            this.lbl_balance.Name = "lbl_balance";
            this.lbl_balance.Size = new System.Drawing.Size(103, 29);
            this.lbl_balance.TabIndex = 20;
            this.lbl_balance.Text = "...............";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(164)))), ((int)(((byte)(174)))));
            this.label7.Location = new System.Drawing.Point(6, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 18);
            this.label7.TabIndex = 17;
            this.label7.Text = "Paied Amount ......";
            // 
            // lbl_paied
            // 
            this.lbl_paied.AutoSize = true;
            this.lbl_paied.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_paied.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(223)))), ((int)(((byte)(219)))));
            this.lbl_paied.Location = new System.Drawing.Point(137, 222);
            this.lbl_paied.Name = "lbl_paied";
            this.lbl_paied.Size = new System.Drawing.Size(103, 29);
            this.lbl_paied.TabIndex = 18;
            this.lbl_paied.Text = "...............";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(164)))), ((int)(((byte)(174)))));
            this.label1.Location = new System.Drawing.Point(6, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "Outstandings .........";
            // 
            // lbl_outstandings
            // 
            this.lbl_outstandings.AutoSize = true;
            this.lbl_outstandings.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_outstandings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(223)))), ((int)(((byte)(219)))));
            this.lbl_outstandings.Location = new System.Drawing.Point(137, 183);
            this.lbl_outstandings.Name = "lbl_outstandings";
            this.lbl_outstandings.Size = new System.Drawing.Size(103, 29);
            this.lbl_outstandings.TabIndex = 16;
            this.lbl_outstandings.Text = "...............";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(164)))), ((int)(((byte)(174)))));
            this.label9.Location = new System.Drawing.Point(4, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 14);
            this.label9.TabIndex = 5;
            this.label9.Text = "Credit Limit..........................";
            // 
            // lbl_creditLinit
            // 
            this.lbl_creditLinit.AutoSize = true;
            this.lbl_creditLinit.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_creditLinit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(220)))));
            this.lbl_creditLinit.Location = new System.Drawing.Point(158, 15);
            this.lbl_creditLinit.Name = "lbl_creditLinit";
            this.lbl_creditLinit.Size = new System.Drawing.Size(45, 23);
            this.lbl_creditLinit.TabIndex = 6;
            this.lbl_creditLinit.Text = "0.00";
            // 
            // lbl_rank
            // 
            this.lbl_rank.AutoSize = true;
            this.lbl_rank.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rank.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(220)))));
            this.lbl_rank.Location = new System.Drawing.Point(158, 136);
            this.lbl_rank.Name = "lbl_rank";
            this.lbl_rank.Size = new System.Drawing.Size(45, 23);
            this.lbl_rank.TabIndex = 14;
            this.lbl_rank.Text = "0.00";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(164)))), ((int)(((byte)(174)))));
            this.label12.Location = new System.Drawing.Point(4, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(140, 14);
            this.label12.TabIndex = 7;
            this.label12.Text = "Limit Alert ..........................";
            // 
            // lbl_other
            // 
            this.lbl_other.AutoSize = true;
            this.lbl_other.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_other.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(164)))), ((int)(((byte)(174)))));
            this.lbl_other.Location = new System.Drawing.Point(4, 138);
            this.lbl_other.Name = "lbl_other";
            this.lbl_other.Size = new System.Drawing.Size(185, 14);
            this.lbl_other.TabIndex = 13;
            this.lbl_other.Text = "Customer Rating ...............................";
            // 
            // pnl_header
            // 
            this.pnl_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(108)))), ((int)(((byte)(139)))));
            this.pnl_header.Controls.Add(this.lbl_headerpaneltext);
            this.pnl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_header.Location = new System.Drawing.Point(0, 0);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Size = new System.Drawing.Size(1148, 40);
            this.pnl_header.TabIndex = 105;
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
            this.pnl_footer.Controls.Add(this.btn_save);
            this.pnl_footer.Controls.Add(this.btn_exit);
            this.pnl_footer.Location = new System.Drawing.Point(6, 521);
            this.pnl_footer.Name = "pnl_footer";
            this.pnl_footer.Size = new System.Drawing.Size(978, 40);
            this.pnl_footer.TabIndex = 106;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageIndex = 3;
            this.button1.ImageList = this.imageList1;
            this.button1.Location = new System.Drawing.Point(8, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 33);
            this.button1.TabIndex = 66;
            this.button1.Text = "       New";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.White;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.ImageIndex = 5;
            this.btn_save.ImageList = this.imageList1;
            this.btn_save.Location = new System.Drawing.Point(753, 3);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(124, 33);
            this.btn_save.TabIndex = 65;
            this.btn_save.Text = "       Save && Print";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.White;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_exit.ImageIndex = 10;
            this.btn_exit.ImageList = this.imageList1;
            this.btn_exit.Location = new System.Drawing.Point(883, 3);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(91, 33);
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
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.dgmain);
            this.panel1.Location = new System.Drawing.Point(10, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(974, 420);
            this.panel1.TabIndex = 107;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.txt_branch);
            this.panel6.Controls.Add(this.txt_BANK);
            this.panel6.Controls.Add(this.btn_cqadd);
            this.panel6.Controls.Add(this.btn_cqclose);
            this.panel6.Controls.Add(this.dte_CQDate);
            this.panel6.Controls.Add(this.label28);
            this.panel6.Controls.Add(this.label31);
            this.panel6.Controls.Add(this.label29);
            this.panel6.Controls.Add(this.txt_CQNO);
            this.panel6.Controls.Add(this.label32);
            this.panel6.Location = new System.Drawing.Point(3, 222);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(569, 86);
            this.panel6.TabIndex = 153;
            this.panel6.Visible = false;
            // 
            // btn_cqadd
            // 
            this.btn_cqadd.BackColor = System.Drawing.Color.White;
            this.btn_cqadd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cqadd.ForeColor = System.Drawing.Color.Black;
            this.btn_cqadd.Location = new System.Drawing.Point(398, 51);
            this.btn_cqadd.Name = "btn_cqadd";
            this.btn_cqadd.Size = new System.Drawing.Size(75, 23);
            this.btn_cqadd.TabIndex = 78;
            this.btn_cqadd.Text = "Add ";
            this.btn_cqadd.UseVisualStyleBackColor = false;
            this.btn_cqadd.Click += new System.EventHandler(this.btn_cqadd_Click);
            // 
            // btn_cqclose
            // 
            this.btn_cqclose.BackColor = System.Drawing.Color.White;
            this.btn_cqclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cqclose.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cqclose.ForeColor = System.Drawing.Color.Red;
            this.btn_cqclose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cqclose.ImageList = this.imageList1;
            this.btn_cqclose.Location = new System.Drawing.Point(479, 51);
            this.btn_cqclose.Name = "btn_cqclose";
            this.btn_cqclose.Size = new System.Drawing.Size(75, 23);
            this.btn_cqclose.TabIndex = 77;
            this.btn_cqclose.Text = "Exit";
            this.btn_cqclose.UseVisualStyleBackColor = false;
            this.btn_cqclose.Click += new System.EventHandler(this.btn_cqclose_Click);
            // 
            // dte_CQDate
            // 
            this.dte_CQDate.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dte_CQDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dte_CQDate.Location = new System.Drawing.Point(470, 23);
            this.dte_CQDate.Name = "dte_CQDate";
            this.dte_CQDate.Size = new System.Drawing.Size(84, 21);
            this.dte_CQDate.TabIndex = 74;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.White;
            this.label28.Location = new System.Drawing.Point(11, 5);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(32, 14);
            this.label28.TabIndex = 68;
            this.label28.Text = "Bank";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = System.Drawing.Color.White;
            this.label31.Location = new System.Drawing.Point(467, 7);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(74, 14);
            this.label31.TabIndex = 73;
            this.label31.Text = "Banking Date";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.White;
            this.label29.Location = new System.Drawing.Point(214, 5);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(41, 14);
            this.label29.TabIndex = 69;
            this.label29.Text = "Branch";
            // 
            // txt_CQNO
            // 
            this.txt_CQNO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(204)))));
            this.txt_CQNO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_CQNO.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CQNO.Location = new System.Drawing.Point(364, 23);
            this.txt_CQNO.Name = "txt_CQNO";
            this.txt_CQNO.Size = new System.Drawing.Size(100, 21);
            this.txt_CQNO.TabIndex = 70;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.ForeColor = System.Drawing.Color.White;
            this.label32.Location = new System.Drawing.Point(361, 7);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(60, 14);
            this.label32.TabIndex = 72;
            this.label32.Text = "Cheque No";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cmb_paycode);
            this.panel2.Controls.Add(this.chk_subtot);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txt_remaining);
            this.panel2.Controls.Add(this.lbl_name);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.txt_amt);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(3, 157);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(673, 66);
            this.panel2.TabIndex = 152;
            // 
            // cmb_paycode
            // 
            this.cmb_paycode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_paycode.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_paycode.FormattingEnabled = true;
            this.cmb_paycode.Location = new System.Drawing.Point(13, 23);
            this.cmb_paycode.Name = "cmb_paycode";
            this.cmb_paycode.Size = new System.Drawing.Size(196, 23);
            this.cmb_paycode.TabIndex = 154;
            this.cmb_paycode.SelectedIndexChanged += new System.EventHandler(this.cmb_paycode_SelectedIndexChanged);
            this.cmb_paycode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmb_paycode_KeyDown);
            // 
            // chk_subtot
            // 
            this.chk_subtot.AutoSize = true;
            this.chk_subtot.Font = new System.Drawing.Font("Calibri", 9F);
            this.chk_subtot.ForeColor = System.Drawing.Color.White;
            this.chk_subtot.Location = new System.Drawing.Point(215, 47);
            this.chk_subtot.Name = "chk_subtot";
            this.chk_subtot.Size = new System.Drawing.Size(73, 18);
            this.chk_subtot.TabIndex = 13;
            this.chk_subtot.Text = "SubTotal";
            this.chk_subtot.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(348, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 14);
            this.label4.TabIndex = 12;
            this.label4.Text = "Remaining";
            // 
            // txt_remaining
            // 
            this.txt_remaining.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_remaining.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_remaining.BackColor = System.Drawing.Color.White;
            this.txt_remaining.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_remaining.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_remaining.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(60)))), ((int)(((byte)(11)))));
            this.txt_remaining.Location = new System.Drawing.Point(351, 24);
            this.txt_remaining.Name = "txt_remaining";
            this.txt_remaining.ReadOnly = true;
            this.txt_remaining.Size = new System.Drawing.Size(128, 22);
            this.txt_remaining.TabIndex = 11;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.White;
            this.lbl_name.Location = new System.Drawing.Point(12, 46);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(19, 14);
            this.lbl_name.TabIndex = 10;
            this.lbl_name.Text = "....";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(212, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 14);
            this.label16.TabIndex = 7;
            this.label16.Text = "Amount";
            // 
            // txt_amt
            // 
            this.txt_amt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_amt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_amt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(204)))));
            this.txt_amt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_amt.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_amt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(60)))), ((int)(((byte)(11)))));
            this.txt_amt.Location = new System.Drawing.Point(215, 24);
            this.txt_amt.Name = "txt_amt";
            this.txt_amt.Size = new System.Drawing.Size(130, 22);
            this.txt_amt.TabIndex = 6;
            this.txt_amt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_amt_KeyDown);
            this.txt_amt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_amt_KeyPress);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(12, 7);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(80, 14);
            this.label17.TabIndex = 0;
            this.label17.Text = "Payment Type";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.checkBox1);
            this.panel5.Controls.Add(this.label27);
            this.panel5.Controls.Add(this.label26);
            this.panel5.Controls.Add(this.label25);
            this.panel5.Controls.Add(this.label23);
            this.panel5.Controls.Add(this.label22);
            this.panel5.Controls.Add(this.label21);
            this.panel5.Controls.Add(this.label20);
            this.panel5.Controls.Add(this.label19);
            this.panel5.Controls.Add(this.label18);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.lbl_balance);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.lbl_paied);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.lbl_outstandings);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.lbl_creditLinit);
            this.panel5.Controls.Add(this.lbl_rank);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.lbl_other);
            this.panel5.Controls.Add(this.lbl_limitAlert);
            this.panel5.Controls.Add(this.lbl_cqbalance);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Controls.Add(this.lbl_expenses);
            this.panel5.Controls.Add(this.lbl_cqlimit);
            this.panel5.Location = new System.Drawing.Point(682, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(287, 412);
            this.panel5.TabIndex = 106;
            // 
            // lbl_limitAlert
            // 
            this.lbl_limitAlert.AutoSize = true;
            this.lbl_limitAlert.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_limitAlert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(220)))));
            this.lbl_limitAlert.Location = new System.Drawing.Point(158, 45);
            this.lbl_limitAlert.Name = "lbl_limitAlert";
            this.lbl_limitAlert.Size = new System.Drawing.Size(45, 23);
            this.lbl_limitAlert.TabIndex = 8;
            this.lbl_limitAlert.Text = "0.00";
            // 
            // lbl_cqbalance
            // 
            this.lbl_cqbalance.AutoSize = true;
            this.lbl_cqbalance.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cqbalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(220)))));
            this.lbl_cqbalance.Location = new System.Drawing.Point(158, 105);
            this.lbl_cqbalance.Name = "lbl_cqbalance";
            this.lbl_cqbalance.Size = new System.Drawing.Size(45, 23);
            this.lbl_cqbalance.TabIndex = 12;
            this.lbl_cqbalance.Text = "0.00";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(164)))), ((int)(((byte)(174)))));
            this.label14.Location = new System.Drawing.Point(4, 79);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(137, 14);
            this.label14.TabIndex = 9;
            this.label14.Text = "Cheque Limit .....................";
            // 
            // lbl_expenses
            // 
            this.lbl_expenses.AutoSize = true;
            this.lbl_expenses.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_expenses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(164)))), ((int)(((byte)(174)))));
            this.lbl_expenses.Location = new System.Drawing.Point(4, 108);
            this.lbl_expenses.Name = "lbl_expenses";
            this.lbl_expenses.Size = new System.Drawing.Size(169, 14);
            this.lbl_expenses.TabIndex = 11;
            this.lbl_expenses.Text = "Cheque Balance ...........................";
            // 
            // lbl_cqlimit
            // 
            this.lbl_cqlimit.AutoSize = true;
            this.lbl_cqlimit.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cqlimit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(220)))));
            this.lbl_cqlimit.Location = new System.Drawing.Point(158, 75);
            this.lbl_cqlimit.Name = "lbl_cqlimit";
            this.lbl_cqlimit.Size = new System.Drawing.Size(45, 23);
            this.lbl_cqlimit.TabIndex = 10;
            this.lbl_cqlimit.Text = "0.00";
            // 
            // txt_BANK
            // 
            this.txt_BANK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_BANK.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_BANK.FormattingEnabled = true;
            this.txt_BANK.Location = new System.Drawing.Point(13, 22);
            this.txt_BANK.Name = "txt_BANK";
            this.txt_BANK.Size = new System.Drawing.Size(196, 23);
            this.txt_BANK.TabIndex = 155;
            this.txt_BANK.SelectedIndexChanged += new System.EventHandler(this.txt_BANK_SelectedIndexChanged);
            // 
            // txt_branch
            // 
            this.txt_branch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_branch.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_branch.FormattingEnabled = true;
            this.txt_branch.Location = new System.Drawing.Point(215, 22);
            this.txt_branch.Name = "txt_branch";
            this.txt_branch.Size = new System.Drawing.Size(143, 23);
            this.txt_branch.TabIndex = 156;
            // 
            // frm_payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 567);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnl_header);
            this.Controls.Add(this.pnl_footer);
            this.Controls.Add(this.panel1);
            this.Name = "frm_payment";
            this.Text = "frm_payment";
            this.Load += new System.EventHandler(this.frm_payment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgmain)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_totalpay)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnl_header.ResumeLayout(false);
            this.pnl_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.pnl_footer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DataGridView dgmain;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label Session;
        private System.Windows.Forms.ComboBox cmb_customer;
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_balance;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_paied;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_outstandings;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_creditLinit;
        private System.Windows.Forms.Label lbl_rank;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbl_other;
        private System.Windows.Forms.Panel pnl_header;
        private System.Windows.Forms.Label lbl_headerpaneltext;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel pnl_footer;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lbl_limitAlert;
        private System.Windows.Forms.Label lbl_cqbalance;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbl_expenses;
        private System.Windows.Forms.Label lbl_cqlimit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown num_totalpay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_memo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_ManualNo;
        private System.Windows.Forms.TextBox txt_RefNo;
        private System.Windows.Forms.DateTimePicker dte_date;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_recivedfrom;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_Remarks;
        private System.Windows.Forms.TextBox txt_recno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox chk_subtot;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_remaining;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_amt;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btn_cqadd;
        private System.Windows.Forms.Button btn_cqclose;
        private System.Windows.Forms.DateTimePicker dte_CQDate;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox txt_CQNO;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.ComboBox cmb_paycode;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sequence;
        private System.Windows.Forms.DataGridViewTextBoxColumn PayType;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPay;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaiedAmt;
        private System.Windows.Forms.DataGridViewTextBoxColumn CQno;
        private System.Windows.Forms.DataGridViewTextBoxColumn CQDate;
        private System.Windows.Forms.ComboBox txt_branch;
        private System.Windows.Forms.ComboBox txt_BANK;
    }
}