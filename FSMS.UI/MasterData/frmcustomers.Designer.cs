namespace FSMS.UI
{
    partial class frmcustomers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmcustomers));
            this.pnl_header = new System.Windows.Forms.Panel();
            this.lbl_headerpaneltext = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txt_ratings = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_outstnd = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_add3 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_add2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_add1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_tp = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_conper = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_cuscode = new System.Windows.Forms.TextBox();
            this.txt_crelimit = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgmain = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreditLimit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Outstanding = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_delete = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pnl_footer = new System.Windows.Forms.Panel();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_print = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_remarks = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmb_fueltypes = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_outstndingalert = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.pnl_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ratings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_outstnd)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_crelimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgmain)).BeginInit();
            this.pnl_footer.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_outstndingalert)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_header
            // 
            this.pnl_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(108)))), ((int)(((byte)(139)))));
            this.pnl_header.Controls.Add(this.lbl_headerpaneltext);
            this.pnl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_header.Location = new System.Drawing.Point(0, 0);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Size = new System.Drawing.Size(1198, 37);
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
            // txt_ratings
            // 
            this.txt_ratings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ratings.Location = new System.Drawing.Point(90, 176);
            this.txt_ratings.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txt_ratings.Name = "txt_ratings";
            this.txt_ratings.Size = new System.Drawing.Size(111, 20);
            this.txt_ratings.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Rating";
            // 
            // txt_outstnd
            // 
            this.txt_outstnd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_outstnd.DecimalPlaces = 2;
            this.txt_outstnd.Location = new System.Drawing.Point(348, 150);
            this.txt_outstnd.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txt_outstnd.Name = "txt_outstnd";
            this.txt_outstnd.Size = new System.Drawing.Size(111, 20);
            this.txt_outstnd.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(245, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Outstanding";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txt_outstndingalert);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.cmb_fueltypes);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.txt_remarks);
            this.panel2.Controls.Add(this.txt_add3);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txt_add2);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txt_add1);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txt_email);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txt_tp);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txt_conper);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txt_cuscode);
            this.panel2.Controls.Add(this.txt_ratings);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txt_outstnd);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txt_crelimit);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lbl_id);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txt_name);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(669, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(517, 329);
            this.panel2.TabIndex = 92;
            // 
            // txt_add3
            // 
            this.txt_add3.Location = new System.Drawing.Point(349, 126);
            this.txt_add3.Name = "txt_add3";
            this.txt_add3.Size = new System.Drawing.Size(150, 20);
            this.txt_add3.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(245, 129);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "City";
            // 
            // txt_add2
            // 
            this.txt_add2.Location = new System.Drawing.Point(348, 101);
            this.txt_add2.Name = "txt_add2";
            this.txt_add2.Size = new System.Drawing.Size(150, 20);
            this.txt_add2.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(245, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Town";
            // 
            // txt_add1
            // 
            this.txt_add1.Location = new System.Drawing.Point(348, 76);
            this.txt_add1.Name = "txt_add1";
            this.txt_add1.Size = new System.Drawing.Size(150, 20);
            this.txt_add1.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(245, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Street No";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(90, 126);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(150, 20);
            this.txt_email.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Email";
            // 
            // txt_tp
            // 
            this.txt_tp.Location = new System.Drawing.Point(90, 101);
            this.txt_tp.Name = "txt_tp";
            this.txt_tp.Size = new System.Drawing.Size(150, 20);
            this.txt_tp.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Telephone";
            // 
            // txt_conper
            // 
            this.txt_conper.Location = new System.Drawing.Point(90, 76);
            this.txt_conper.Name = "txt_conper";
            this.txt_conper.Size = new System.Drawing.Size(150, 20);
            this.txt_conper.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Contact Person";
            // 
            // txt_cuscode
            // 
            this.txt_cuscode.Location = new System.Drawing.Point(90, 26);
            this.txt_cuscode.Name = "txt_cuscode";
            this.txt_cuscode.Size = new System.Drawing.Size(84, 20);
            this.txt_cuscode.TabIndex = 15;
            // 
            // txt_crelimit
            // 
            this.txt_crelimit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_crelimit.DecimalPlaces = 2;
            this.txt_crelimit.Location = new System.Drawing.Point(90, 151);
            this.txt_crelimit.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txt_crelimit.Name = "txt_crelimit";
            this.txt_crelimit.Size = new System.Drawing.Size(111, 20);
            this.txt_crelimit.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Credit Limit";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Customer Name";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(90, 51);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(408, 20);
            this.txt_name.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer Code";
            // 
            // dgmain
            // 
            this.dgmain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgmain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.CustomerCode,
            this.CustomerName,
            this.CreditLimit,
            this.Outstanding,
            this.Rating});
            this.dgmain.Location = new System.Drawing.Point(5, 4);
            this.dgmain.Name = "dgmain";
            this.dgmain.Size = new System.Drawing.Size(644, 318);
            this.dgmain.TabIndex = 0;
            this.dgmain.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgmain_RowEnter);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "id";
            this.Id.HeaderText = "#";
            this.Id.Name = "Id";
            // 
            // CustomerCode
            // 
            this.CustomerCode.DataPropertyName = "CustomerCode";
            this.CustomerCode.HeaderText = "CustomerCode";
            this.CustomerCode.Name = "CustomerCode";
            // 
            // CustomerName
            // 
            this.CustomerName.DataPropertyName = "CustomerName";
            this.CustomerName.HeaderText = "CustomerName";
            this.CustomerName.Name = "CustomerName";
            // 
            // CreditLimit
            // 
            this.CreditLimit.DataPropertyName = "CreditLimit";
            this.CreditLimit.HeaderText = "CreditLimit";
            this.CreditLimit.Name = "CreditLimit";
            // 
            // Outstanding
            // 
            this.Outstanding.DataPropertyName = "Outstanding";
            this.Outstanding.HeaderText = "Outstanding";
            this.Outstanding.Name = "Outstanding";
            // 
            // Rating
            // 
            this.Rating.DataPropertyName = "Rating";
            this.Rating.HeaderText = "Rating";
            this.Rating.Name = "Rating";
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.White;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete.ImageIndex = 1;
            this.btn_delete.ImageList = this.imageList1;
            this.btn_delete.Location = new System.Drawing.Point(881, 5);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(91, 35);
            this.btn_delete.TabIndex = 61;
            this.btn_delete.Text = "     Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
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
            this.pnl_footer.Controls.Add(this.btn_update);
            this.pnl_footer.Controls.Add(this.btn_save);
            this.pnl_footer.Controls.Add(this.btn_print);
            this.pnl_footer.Controls.Add(this.btn_delete);
            this.pnl_footer.Controls.Add(this.btn_exit);
            this.pnl_footer.Location = new System.Drawing.Point(3, 378);
            this.pnl_footer.Name = "pnl_footer";
            this.pnl_footer.Size = new System.Drawing.Size(1183, 45);
            this.pnl_footer.TabIndex = 90;
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.White;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_update.ImageIndex = 8;
            this.btn_update.ImageList = this.imageList1;
            this.btn_update.Location = new System.Drawing.Point(784, 5);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(91, 35);
            this.btn_update.TabIndex = 64;
            this.btn_update.Text = "       Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.White;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.ImageIndex = 6;
            this.btn_save.ImageList = this.imageList1;
            this.btn_save.Location = new System.Drawing.Point(687, 5);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(91, 35);
            this.btn_save.TabIndex = 59;
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
            this.btn_print.Location = new System.Drawing.Point(978, 5);
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
            this.btn_exit.Location = new System.Drawing.Point(1075, 5);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(91, 35);
            this.btn_exit.TabIndex = 63;
            this.btn_exit.Text = "       Exit";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dgmain);
            this.panel1.Location = new System.Drawing.Point(4, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(659, 329);
            this.panel1.TabIndex = 91;
            // 
            // txt_remarks
            // 
            this.txt_remarks.Location = new System.Drawing.Point(90, 201);
            this.txt_remarks.Multiline = true;
            this.txt_remarks.Name = "txt_remarks";
            this.txt_remarks.Size = new System.Drawing.Size(408, 42);
            this.txt_remarks.TabIndex = 29;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 209);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "Remarks";
            // 
            // cmb_fueltypes
            // 
            this.cmb_fueltypes.FormattingEnabled = true;
            this.cmb_fueltypes.Location = new System.Drawing.Point(90, 249);
            this.cmb_fueltypes.Name = "cmb_fueltypes";
            this.cmb_fueltypes.Size = new System.Drawing.Size(150, 21);
            this.cmb_fueltypes.TabIndex = 31;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 252);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "Customer Status";
            // 
            // txt_outstndingalert
            // 
            this.txt_outstndingalert.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_outstndingalert.DecimalPlaces = 2;
            this.txt_outstndingalert.Location = new System.Drawing.Point(348, 176);
            this.txt_outstndingalert.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txt_outstndingalert.Name = "txt_outstndingalert";
            this.txt_outstndingalert.Size = new System.Drawing.Size(111, 20);
            this.txt_outstndingalert.TabIndex = 33;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(245, 177);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(104, 13);
            this.label14.TabIndex = 32;
            this.label14.Text = "Out:Stnding Alert On";
            // 
            // frmcustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 428);
            this.Controls.Add(this.pnl_header);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnl_footer);
            this.Controls.Add(this.panel1);
            this.Name = "frmcustomers";
            this.Text = "frmcustomers";
            this.Load += new System.EventHandler(this.frmcustomers_Load);
            this.pnl_header.ResumeLayout(false);
            this.pnl_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ratings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_outstnd)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_crelimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgmain)).EndInit();
            this.pnl_footer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_outstndingalert)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_header;
        private System.Windows.Forms.Label lbl_headerpaneltext;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown txt_ratings;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown txt_outstnd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown txt_crelimit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl_footer;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgmain;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreditLimit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Outstanding;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rating;
        private System.Windows.Forms.TextBox txt_add3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_add2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_add1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_tp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_conper;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_cuscode;
        private System.Windows.Forms.TextBox txt_remarks;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmb_fueltypes;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown txt_outstndingalert;
        private System.Windows.Forms.Label label14;
    }
}