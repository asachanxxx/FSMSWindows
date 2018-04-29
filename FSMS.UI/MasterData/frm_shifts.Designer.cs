namespace FSMS.UI
{
    partial class frm_shifts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_shifts));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgmain = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShifName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndsOn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndsM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShiftLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BreakLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_header = new System.Windows.Forms.Panel();
            this.lbl_headerpaneltext = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmb_starth = new System.Windows.Forms.ComboBox();
            this.cmb_shiftlen = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.cmb_breaklen = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmb_endsM = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmb_endsH = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_startm = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_footer = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_print = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgmain)).BeginInit();
            this.pnl_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_shiftlen)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_breaklen)).BeginInit();
            this.pnl_footer.SuspendLayout();
            this.SuspendLayout();
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
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dgmain);
            this.panel1.Location = new System.Drawing.Point(7, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(717, 297);
            this.panel1.TabIndex = 91;
            // 
            // dgmain
            // 
            this.dgmain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgmain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ShifName,
            this.StartH,
            this.EndsOn,
            this.EndH,
            this.EndsM,
            this.ShiftLength,
            this.BreakLength});
            this.dgmain.Location = new System.Drawing.Point(7, 5);
            this.dgmain.Name = "dgmain";
            this.dgmain.Size = new System.Drawing.Size(705, 283);
            this.dgmain.TabIndex = 0;
            this.dgmain.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgmain_RowEnter);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "id";
            this.Id.Frozen = true;
            this.Id.HeaderText = "#";
            this.Id.Name = "Id";
            this.Id.Width = 20;
            // 
            // ShifName
            // 
            this.ShifName.DataPropertyName = "ShifName";
            this.ShifName.Frozen = true;
            this.ShifName.HeaderText = "ShifName";
            this.ShifName.Name = "ShifName";
            // 
            // StartH
            // 
            this.StartH.DataPropertyName = "StartH";
            this.StartH.Frozen = true;
            this.StartH.HeaderText = "Starts Hour";
            this.StartH.Name = "StartH";
            // 
            // EndsOn
            // 
            this.EndsOn.DataPropertyName = "StartM";
            this.EndsOn.Frozen = true;
            this.EndsOn.HeaderText = "Starts Minute";
            this.EndsOn.Name = "EndsOn";
            // 
            // EndH
            // 
            this.EndH.DataPropertyName = "EndH";
            this.EndH.Frozen = true;
            this.EndH.HeaderText = "Ends Hour";
            this.EndH.Name = "EndH";
            // 
            // EndsM
            // 
            this.EndsM.DataPropertyName = "EndM";
            this.EndsM.Frozen = true;
            this.EndsM.HeaderText = "Ends Minute";
            this.EndsM.Name = "EndsM";
            // 
            // ShiftLength
            // 
            this.ShiftLength.DataPropertyName = "ShiftLength";
            this.ShiftLength.Frozen = true;
            this.ShiftLength.HeaderText = "ShiftLength";
            this.ShiftLength.Name = "ShiftLength";
            // 
            // BreakLength
            // 
            this.BreakLength.DataPropertyName = "BreakLength";
            this.BreakLength.Frozen = true;
            this.BreakLength.HeaderText = "BreakLength";
            this.BreakLength.Name = "BreakLength";
            // 
            // pnl_header
            // 
            this.pnl_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(108)))), ((int)(((byte)(139)))));
            this.pnl_header.Controls.Add(this.lbl_headerpaneltext);
            this.pnl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_header.Location = new System.Drawing.Point(0, 0);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Size = new System.Drawing.Size(1044, 37);
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
            // cmb_starth
            // 
            this.cmb_starth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_starth.DropDownWidth = 65;
            this.cmb_starth.FormattingEnabled = true;
            this.cmb_starth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24"});
            this.cmb_starth.Location = new System.Drawing.Point(97, 45);
            this.cmb_starth.Name = "cmb_starth";
            this.cmb_starth.Size = new System.Drawing.Size(58, 21);
            this.cmb_starth.TabIndex = 14;
            this.cmb_starth.SelectedIndexChanged += new System.EventHandler(this.cmb_starth_SelectedIndexChanged);
            // 
            // cmb_shiftlen
            // 
            this.cmb_shiftlen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_shiftlen.DecimalPlaces = 2;
            this.cmb_shiftlen.Location = new System.Drawing.Point(79, 99);
            this.cmb_shiftlen.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.cmb_shiftlen.Name = "cmb_shiftlen";
            this.cmb_shiftlen.Size = new System.Drawing.Size(76, 20);
            this.cmb_shiftlen.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Shift Length";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.cmb_breaklen);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.cmb_endsM);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.cmb_endsH);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.cmb_startm);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.cmb_starth);
            this.panel2.Controls.Add(this.cmb_shiftlen);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lbl_id);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txt_name);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(730, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(288, 297);
            this.panel2.TabIndex = 92;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(79, 151);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(76, 20);
            this.dateTimePicker1.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(162, 128);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(15, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "H";
            // 
            // cmb_breaklen
            // 
            this.cmb_breaklen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_breaklen.DecimalPlaces = 2;
            this.cmb_breaklen.Location = new System.Drawing.Point(79, 125);
            this.cmb_breaklen.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.cmb_breaklen.Name = "cmb_breaklen";
            this.cmb_breaklen.Size = new System.Drawing.Size(76, 20);
            this.cmb_breaklen.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 128);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Break Length";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(162, 102);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "H";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(161, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "M";
            // 
            // cmb_endsM
            // 
            this.cmb_endsM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_endsM.FormattingEnabled = true;
            this.cmb_endsM.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60"});
            this.cmb_endsM.Location = new System.Drawing.Point(182, 72);
            this.cmb_endsM.Name = "cmb_endsM";
            this.cmb_endsM.Size = new System.Drawing.Size(65, 21);
            this.cmb_endsM.TabIndex = 21;
            this.cmb_endsM.SelectedIndexChanged += new System.EventHandler(this.cmb_endsM_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(72, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "H";
            // 
            // cmb_endsH
            // 
            this.cmb_endsH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_endsH.DropDownWidth = 65;
            this.cmb_endsH.FormattingEnabled = true;
            this.cmb_endsH.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24"});
            this.cmb_endsH.Location = new System.Drawing.Point(97, 72);
            this.cmb_endsH.Name = "cmb_endsH";
            this.cmb_endsH.Size = new System.Drawing.Size(58, 21);
            this.cmb_endsH.TabIndex = 19;
            this.cmb_endsH.SelectedIndexChanged += new System.EventHandler(this.cmb_endsH_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Shift Ends";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(161, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "M";
            // 
            // cmb_startm
            // 
            this.cmb_startm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_startm.FormattingEnabled = true;
            this.cmb_startm.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60"});
            this.cmb_startm.Location = new System.Drawing.Point(182, 45);
            this.cmb_startm.Name = "cmb_startm";
            this.cmb_startm.Size = new System.Drawing.Size(65, 21);
            this.cmb_startm.TabIndex = 16;
            this.cmb_startm.SelectedIndexChanged += new System.EventHandler(this.cmb_startm_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "H";
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
            this.label2.Location = new System.Drawing.Point(8, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Shif Name";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(75, 19);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(172, 20);
            this.txt_name.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Shift Starts";
            // 
            // pnl_footer
            // 
            this.pnl_footer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(53)))), ((int)(((byte)(68)))));
            this.pnl_footer.Controls.Add(this.button1);
            this.pnl_footer.Controls.Add(this.btn_save);
            this.pnl_footer.Controls.Add(this.btn_print);
            this.pnl_footer.Controls.Add(this.btn_delete);
            this.pnl_footer.Controls.Add(this.btn_exit);
            this.pnl_footer.Location = new System.Drawing.Point(6, 346);
            this.pnl_footer.Name = "pnl_footer";
            this.pnl_footer.Size = new System.Drawing.Size(1012, 45);
            this.pnl_footer.TabIndex = 90;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageIndex = 8;
            this.button1.ImageList = this.imageList1;
            this.button1.Location = new System.Drawing.Point(623, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 35);
            this.button1.TabIndex = 64;
            this.button1.Text = "       Update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.White;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.ImageIndex = 6;
            this.btn_save.ImageList = this.imageList1;
            this.btn_save.Location = new System.Drawing.Point(526, 4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(91, 35);
            this.btn_save.TabIndex = 59;
            this.btn_save.Text = "     Insert";
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
            this.btn_print.Location = new System.Drawing.Point(817, 4);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(91, 35);
            this.btn_print.TabIndex = 62;
            this.btn_print.Text = "       Print";
            this.btn_print.UseVisualStyleBackColor = false;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.White;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete.ImageIndex = 1;
            this.btn_delete.ImageList = this.imageList1;
            this.btn_delete.Location = new System.Drawing.Point(720, 4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(91, 35);
            this.btn_delete.TabIndex = 61;
            this.btn_delete.Text = "     Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.White;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_exit.ImageIndex = 10;
            this.btn_exit.ImageList = this.imageList1;
            this.btn_exit.Location = new System.Drawing.Point(914, 4);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(91, 35);
            this.btn_exit.TabIndex = 63;
            this.btn_exit.Text = "       Exit";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // frm_shifts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 397);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_header);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnl_footer);
            this.Name = "frm_shifts";
            this.Text = "frm_shifts";
            this.Load += new System.EventHandler(this.frm_shifts_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgmain)).EndInit();
            this.pnl_header.ResumeLayout(false);
            this.pnl_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_shiftlen)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_breaklen)).EndInit();
            this.pnl_footer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgmain;
        private System.Windows.Forms.Panel pnl_header;
        private System.Windows.Forms.Label lbl_headerpaneltext;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmb_starth;
        private System.Windows.Forms.NumericUpDown cmb_shiftlen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl_footer;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown cmb_breaklen;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmb_endsM;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmb_endsH;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_startm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShifName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartH;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndsOn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndH;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndsM;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShiftLength;
        private System.Windows.Forms.DataGridViewTextBoxColumn BreakLength;
    }
}