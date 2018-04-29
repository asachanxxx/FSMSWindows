namespace FSMS.UI
{
    partial class PumpManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PumpManager));
            this.pnl_header = new System.Windows.Forms.Panel();
            this.lbl_headerpaneltext = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lbl_id = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_footer = new System.Windows.Forms.Panel();
            this.btn_print = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.txt_pumporder = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_pumpname = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_savepump = new System.Windows.Forms.Button();
            this.txt_noofnozzels = new System.Windows.Forms.NumericUpDown();
            this.btn_deletepump = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lst_pumps = new System.Windows.Forms.ListView();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_unitPrice = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_savenozz = new System.Windows.Forms.Button();
            this.btn_deletenozz = new System.Windows.Forms.Button();
            this.cmb_tanks = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmb_fueltypes = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_nozzel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_nozzelName = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lst_nozzels = new System.Windows.Forms.ListView();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_selectedPump = new System.Windows.Forms.Label();
            this.pnl_header.SuspendLayout();
            this.pnl_footer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_pumporder)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_noofnozzels)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_unitPrice)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_header
            // 
            this.pnl_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(108)))), ((int)(((byte)(139)))));
            this.pnl_header.Controls.Add(this.lbl_headerpaneltext);
            this.pnl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_header.Location = new System.Drawing.Point(0, 0);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Size = new System.Drawing.Size(1138, 40);
            this.pnl_header.TabIndex = 85;
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
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(3, 3);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(19, 14);
            this.lbl_id.TabIndex = 4;
            this.lbl_id.Text = "<>";
            this.lbl_id.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(296, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "No OF Nozzels";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pump Name";
            // 
            // pnl_footer
            // 
            this.pnl_footer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(53)))), ((int)(((byte)(68)))));
            this.pnl_footer.Controls.Add(this.btn_print);
            this.pnl_footer.Controls.Add(this.btn_exit);
            this.pnl_footer.Location = new System.Drawing.Point(0, 520);
            this.pnl_footer.Name = "pnl_footer";
            this.pnl_footer.Size = new System.Drawing.Size(1126, 48);
            this.pnl_footer.TabIndex = 86;
            // 
            // btn_print
            // 
            this.btn_print.BackColor = System.Drawing.Color.White;
            this.btn_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_print.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_print.ImageIndex = 5;
            this.btn_print.ImageList = this.imageList1;
            this.btn_print.Location = new System.Drawing.Point(927, 4);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(91, 38);
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
            this.btn_exit.Location = new System.Drawing.Point(1024, 4);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(96, 38);
            this.btn_exit.TabIndex = 63;
            this.btn_exit.Text = "       Exit";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // txt_pumporder
            // 
            this.txt_pumporder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_pumporder.Location = new System.Drawing.Point(105, 40);
            this.txt_pumporder.Name = "txt_pumporder";
            this.txt_pumporder.Size = new System.Drawing.Size(172, 22);
            this.txt_pumporder.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 14);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pump Order";
            // 
            // txt_pumpname
            // 
            this.txt_pumpname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(233)))), ((int)(((byte)(246)))));
            this.txt_pumpname.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pumpname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(107)))), ((int)(((byte)(192)))));
            this.txt_pumpname.Location = new System.Drawing.Point(105, 10);
            this.txt_pumpname.Name = "txt_pumpname";
            this.txt_pumpname.Size = new System.Drawing.Size(452, 22);
            this.txt_pumpname.TabIndex = 0;
            this.txt_pumpname.Text = "AA";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btn_savepump);
            this.panel2.Controls.Add(this.txt_noofnozzels);
            this.panel2.Controls.Add(this.txt_pumporder);
            this.panel2.Controls.Add(this.btn_deletepump);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lbl_id);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txt_pumpname);
            this.panel2.Location = new System.Drawing.Point(8, 379);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(564, 138);
            this.panel2.TabIndex = 88;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageIndex = 8;
            this.button1.ImageList = this.imageList1;
            this.button1.Location = new System.Drawing.Point(369, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 38);
            this.button1.TabIndex = 65;
            this.button1.Text = "       Update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_savepump
            // 
            this.btn_savepump.BackColor = System.Drawing.Color.White;
            this.btn_savepump.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_savepump.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_savepump.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_savepump.ImageIndex = 6;
            this.btn_savepump.ImageList = this.imageList1;
            this.btn_savepump.Location = new System.Drawing.Point(272, 94);
            this.btn_savepump.Name = "btn_savepump";
            this.btn_savepump.Size = new System.Drawing.Size(91, 38);
            this.btn_savepump.TabIndex = 59;
            this.btn_savepump.Text = "     Insert";
            this.btn_savepump.UseVisualStyleBackColor = false;
            this.btn_savepump.Click += new System.EventHandler(this.btn_savepump_Click);
            // 
            // txt_noofnozzels
            // 
            this.txt_noofnozzels.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_noofnozzels.Location = new System.Drawing.Point(385, 40);
            this.txt_noofnozzels.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.txt_noofnozzels.Name = "txt_noofnozzels";
            this.txt_noofnozzels.Size = new System.Drawing.Size(172, 22);
            this.txt_noofnozzels.TabIndex = 8;
            // 
            // btn_deletepump
            // 
            this.btn_deletepump.BackColor = System.Drawing.Color.White;
            this.btn_deletepump.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deletepump.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deletepump.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_deletepump.ImageIndex = 1;
            this.btn_deletepump.ImageList = this.imageList1;
            this.btn_deletepump.Location = new System.Drawing.Point(466, 94);
            this.btn_deletepump.Name = "btn_deletepump";
            this.btn_deletepump.Size = new System.Drawing.Size(91, 38);
            this.btn_deletepump.TabIndex = 61;
            this.btn_deletepump.Text = "     Delete";
            this.btn_deletepump.UseVisualStyleBackColor = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lst_pumps);
            this.panel1.Location = new System.Drawing.Point(8, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(564, 326);
            this.panel1.TabIndex = 87;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lst_pumps
            // 
            this.lst_pumps.HideSelection = false;
            this.lst_pumps.LargeImageList = this.imageList2;
            this.lst_pumps.Location = new System.Drawing.Point(6, 5);
            this.lst_pumps.Name = "lst_pumps";
            this.lst_pumps.Size = new System.Drawing.Size(551, 313);
            this.lst_pumps.SmallImageList = this.imageList2;
            this.lst_pumps.TabIndex = 0;
            this.lst_pumps.UseCompatibleStateImageBehavior = false;
            this.lst_pumps.SelectedIndexChanged += new System.EventHandler(this.lst_pumps_SelectedIndexChanged);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "002-gas.png");
            this.imageList2.Images.SetKeyName(1, "001-gasoline-pump.png");
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txt_unitPrice);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.btn_savenozz);
            this.panel3.Controls.Add(this.btn_deletenozz);
            this.panel3.Controls.Add(this.cmb_tanks);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.cmb_fueltypes);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.lbl_nozzel);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txt_nozzelName);
            this.panel3.Location = new System.Drawing.Point(578, 379);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(548, 138);
            this.panel3.TabIndex = 90;
            // 
            // txt_unitPrice
            // 
            this.txt_unitPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_unitPrice.DecimalPlaces = 2;
            this.txt_unitPrice.Location = new System.Drawing.Point(97, 68);
            this.txt_unitPrice.Maximum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.txt_unitPrice.Name = "txt_unitPrice";
            this.txt_unitPrice.Size = new System.Drawing.Size(159, 22);
            this.txt_unitPrice.TabIndex = 66;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.ImageIndex = 8;
            this.button2.ImageList = this.imageList1;
            this.button2.Location = new System.Drawing.Point(354, 94);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 38);
            this.button2.TabIndex = 65;
            this.button2.Text = "       Update";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_savenozz
            // 
            this.btn_savenozz.BackColor = System.Drawing.Color.White;
            this.btn_savenozz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_savenozz.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_savenozz.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_savenozz.ImageIndex = 6;
            this.btn_savenozz.ImageList = this.imageList1;
            this.btn_savenozz.Location = new System.Drawing.Point(257, 94);
            this.btn_savenozz.Name = "btn_savenozz";
            this.btn_savenozz.Size = new System.Drawing.Size(91, 38);
            this.btn_savenozz.TabIndex = 62;
            this.btn_savenozz.Text = "     Save";
            this.btn_savenozz.UseVisualStyleBackColor = false;
            this.btn_savenozz.Click += new System.EventHandler(this.btn_savenozz_Click);
            // 
            // btn_deletenozz
            // 
            this.btn_deletenozz.BackColor = System.Drawing.Color.White;
            this.btn_deletenozz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deletenozz.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deletenozz.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_deletenozz.ImageIndex = 1;
            this.btn_deletenozz.ImageList = this.imageList1;
            this.btn_deletenozz.Location = new System.Drawing.Point(451, 94);
            this.btn_deletenozz.Name = "btn_deletenozz";
            this.btn_deletenozz.Size = new System.Drawing.Size(91, 38);
            this.btn_deletenozz.TabIndex = 63;
            this.btn_deletenozz.Text = "     Delete";
            this.btn_deletenozz.UseVisualStyleBackColor = false;
            // 
            // cmb_tanks
            // 
            this.cmb_tanks.FormattingEnabled = true;
            this.cmb_tanks.Location = new System.Drawing.Point(300, 39);
            this.cmb_tanks.Name = "cmb_tanks";
            this.cmb_tanks.Size = new System.Drawing.Size(174, 22);
            this.cmb_tanks.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(262, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 14);
            this.label8.TabIndex = 9;
            this.label8.Text = "Tank";
            // 
            // cmb_fueltypes
            // 
            this.cmb_fueltypes.FormattingEnabled = true;
            this.cmb_fueltypes.Location = new System.Drawing.Point(97, 39);
            this.cmb_fueltypes.Name = "cmb_fueltypes";
            this.cmb_fueltypes.Size = new System.Drawing.Size(159, 22);
            this.cmb_fueltypes.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 14);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fuel Type";
            // 
            // lbl_nozzel
            // 
            this.lbl_nozzel.AutoSize = true;
            this.lbl_nozzel.Location = new System.Drawing.Point(3, 3);
            this.lbl_nozzel.Name = "lbl_nozzel";
            this.lbl_nozzel.Size = new System.Drawing.Size(19, 14);
            this.lbl_nozzel.TabIndex = 4;
            this.lbl_nozzel.Text = "<>";
            this.lbl_nozzel.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 14);
            this.label6.TabIndex = 3;
            this.label6.Text = "UnitPrice";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 14);
            this.label7.TabIndex = 1;
            this.label7.Text = "Nozzel Name";
            // 
            // txt_nozzelName
            // 
            this.txt_nozzelName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(233)))), ((int)(((byte)(246)))));
            this.txt_nozzelName.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nozzelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(107)))), ((int)(((byte)(192)))));
            this.txt_nozzelName.Location = new System.Drawing.Point(97, 10);
            this.txt_nozzelName.Name = "txt_nozzelName";
            this.txt_nozzelName.Size = new System.Drawing.Size(364, 22);
            this.txt_nozzelName.TabIndex = 0;
            this.txt_nozzelName.Text = "AA";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.lbl_selectedPump);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.lst_nozzels);
            this.panel4.Location = new System.Drawing.Point(578, 46);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(548, 326);
            this.panel4.TabIndex = 89;
            // 
            // lst_nozzels
            // 
            this.lst_nozzels.LargeImageList = this.imageList2;
            this.lst_nozzels.Location = new System.Drawing.Point(7, 26);
            this.lst_nozzels.Name = "lst_nozzels";
            this.lst_nozzels.Size = new System.Drawing.Size(535, 288);
            this.lst_nozzels.SmallImageList = this.imageList2;
            this.lst_nozzels.TabIndex = 0;
            this.lst_nozzels.UseCompatibleStateImageBehavior = false;
            this.lst_nozzels.SelectedIndexChanged += new System.EventHandler(this.lst_nozzels_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Selected Pump:";
            // 
            // lbl_selectedPump
            // 
            this.lbl_selectedPump.AutoSize = true;
            this.lbl_selectedPump.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_selectedPump.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(107)))), ((int)(((byte)(192)))));
            this.lbl_selectedPump.Location = new System.Drawing.Point(106, 4);
            this.lbl_selectedPump.Name = "lbl_selectedPump";
            this.lbl_selectedPump.Size = new System.Drawing.Size(0, 18);
            this.lbl_selectedPump.TabIndex = 5;
            // 
            // PumpManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 569);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pnl_header);
            this.Controls.Add(this.pnl_footer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "PumpManager";
            this.Text = "PumpManager";
            this.Load += new System.EventHandler(this.PumpManager_Load);
            this.pnl_header.ResumeLayout(false);
            this.pnl_header.PerformLayout();
            this.pnl_footer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_pumporder)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_noofnozzels)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_unitPrice)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_header;
        private System.Windows.Forms.Label lbl_headerpaneltext;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl_footer;
        private System.Windows.Forms.Button btn_savepump;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Button btn_deletepump;
        private System.Windows.Forms.NumericUpDown txt_pumporder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_pumpname;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lst_pumps;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_nozzel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_nozzelName;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ListView lst_nozzels;
        private System.Windows.Forms.NumericUpDown txt_noofnozzels;
        private System.Windows.Forms.ComboBox cmb_tanks;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmb_fueltypes;
        private System.Windows.Forms.Button btn_savenozz;
        private System.Windows.Forms.Button btn_deletenozz;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown txt_unitPrice;
        private System.Windows.Forms.Label lbl_selectedPump;
        private System.Windows.Forms.Label label5;
    }
}