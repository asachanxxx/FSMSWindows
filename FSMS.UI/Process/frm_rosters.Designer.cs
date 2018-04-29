namespace FSMS.UI
{
    partial class frm_rosters
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_rosters));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgmain = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShiftName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DayStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Shift = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nozzel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pumper = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalNoOfWorkigH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pnl_footer = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_print = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.lbl_id = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.cmb_endsM = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmb_endsH = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_startm = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_starth = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmb_pumper = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_Nozzels = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_Shifts = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_days = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbl_headerpaneltext = new System.Windows.Forms.Label();
            this.pnl_header = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgmain)).BeginInit();
            this.pnl_footer.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.pnl_header.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dgmain);
            this.panel1.Location = new System.Drawing.Point(7, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(647, 361);
            this.panel1.TabIndex = 95;
            // 
            // dgmain
            // 
            this.dgmain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgmain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ShiftName,
            this.DayStart,
            this.Shift,
            this.Nozzel,
            this.Pumper,
            this.TotalNoOfWorkigH});
            this.dgmain.Location = new System.Drawing.Point(7, 3);
            this.dgmain.Name = "dgmain";
            this.dgmain.Size = new System.Drawing.Size(635, 350);
            this.dgmain.TabIndex = 0;
            this.dgmain.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgmain_RowEnter);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "id";
            this.Id.HeaderText = "#";
            this.Id.Name = "Id";
            // 
            // ShiftName
            // 
            this.ShiftName.DataPropertyName = "ShiftName";
            this.ShiftName.HeaderText = "Roster Name";
            this.ShiftName.Name = "ShiftName";
            // 
            // DayStart
            // 
            this.DayStart.DataPropertyName = "DayStart";
            this.DayStart.HeaderText = "Day Start";
            this.DayStart.Name = "DayStart";
            // 
            // Shift
            // 
            this.Shift.DataPropertyName = "Shift";
            this.Shift.HeaderText = "Shift";
            this.Shift.Name = "Shift";
            // 
            // Nozzel
            // 
            this.Nozzel.DataPropertyName = "Nozzel";
            this.Nozzel.HeaderText = "Nozzel";
            this.Nozzel.Name = "Nozzel";
            // 
            // Pumper
            // 
            this.Pumper.DataPropertyName = "Pumper";
            this.Pumper.HeaderText = "Pumper";
            this.Pumper.Name = "Pumper";
            // 
            // TotalNoOfWorkigH
            // 
            this.TotalNoOfWorkigH.DataPropertyName = "TotalNoOfWorkigH";
            this.TotalNoOfWorkigH.HeaderText = "Workig Hours";
            this.TotalNoOfWorkigH.Name = "TotalNoOfWorkigH";
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
            this.pnl_footer.Controls.Add(this.btn_print);
            this.pnl_footer.Controls.Add(this.btn_delete);
            this.pnl_footer.Controls.Add(this.btn_exit);
            this.pnl_footer.Location = new System.Drawing.Point(6, 462);
            this.pnl_footer.Name = "pnl_footer";
            this.pnl_footer.Size = new System.Drawing.Size(932, 45);
            this.pnl_footer.TabIndex = 94;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageIndex = 8;
            this.button1.ImageList = this.imageList1;
            this.button1.Location = new System.Drawing.Point(544, 4);
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
            this.btn_save.Location = new System.Drawing.Point(447, 4);
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
            this.btn_print.Location = new System.Drawing.Point(738, 4);
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
            this.btn_delete.Location = new System.Drawing.Point(641, 4);
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
            this.btn_exit.Location = new System.Drawing.Point(835, 4);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(94, 20);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(172, 20);
            this.txt_name.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.cmb_endsM);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.cmb_endsH);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.cmb_startm);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.cmb_starth);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.cmb_pumper);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.cmb_Nozzels);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.cmb_Shifts);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lbl_id);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txt_name);
            this.panel2.Location = new System.Drawing.Point(660, 98);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(278, 361);
            this.panel2.TabIndex = 96;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(180, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 13);
            this.label8.TabIndex = 32;
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
            this.cmb_endsM.Location = new System.Drawing.Point(201, 154);
            this.cmb_endsM.Name = "cmb_endsM";
            this.cmb_endsM.Size = new System.Drawing.Size(65, 21);
            this.cmb_endsM.TabIndex = 31;
            this.cmb_endsM.SelectedIndexChanged += new System.EventHandler(this.cmb_endsM_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(91, 157);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 13);
            this.label9.TabIndex = 30;
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
            this.cmb_endsH.Location = new System.Drawing.Point(116, 154);
            this.cmb_endsH.Name = "cmb_endsH";
            this.cmb_endsH.Size = new System.Drawing.Size(58, 21);
            this.cmb_endsH.TabIndex = 29;
            this.cmb_endsH.SelectedIndexChanged += new System.EventHandler(this.cmb_endsH_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 157);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Actual Ends";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(180, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 13);
            this.label7.TabIndex = 27;
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
            this.cmb_startm.Location = new System.Drawing.Point(201, 127);
            this.cmb_startm.Name = "cmb_startm";
            this.cmb_startm.Size = new System.Drawing.Size(65, 21);
            this.cmb_startm.TabIndex = 26;
            this.cmb_startm.SelectedIndexChanged += new System.EventHandler(this.cmb_startm_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(91, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "H";
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
            this.cmb_starth.Location = new System.Drawing.Point(116, 127);
            this.cmb_starth.Name = "cmb_starth";
            this.cmb_starth.Size = new System.Drawing.Size(58, 21);
            this.cmb_starth.TabIndex = 24;
            this.cmb_starth.SelectedIndexChanged += new System.EventHandler(this.cmb_starth_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 130);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Plan Starts";
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
            this.cmb_pumper.Location = new System.Drawing.Point(94, 100);
            this.cmb_pumper.Name = "cmb_pumper";
            this.cmb_pumper.Size = new System.Drawing.Size(172, 21);
            this.cmb_pumper.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Pumper";
            // 
            // cmb_Nozzels
            // 
            this.cmb_Nozzels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Nozzels.FormattingEnabled = true;
            this.cmb_Nozzels.Items.AddRange(new object[] {
            "Unoccupied ",
            "Assigned ",
            "Cancel ",
            "Damage"});
            this.cmb_Nozzels.Location = new System.Drawing.Point(94, 73);
            this.cmb_Nozzels.Name = "cmb_Nozzels";
            this.cmb_Nozzels.Size = new System.Drawing.Size(172, 21);
            this.cmb_Nozzels.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Nozzel";
            // 
            // cmb_Shifts
            // 
            this.cmb_Shifts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Shifts.FormattingEnabled = true;
            this.cmb_Shifts.Items.AddRange(new object[] {
            "Unoccupied ",
            "Assigned ",
            "Cancel ",
            "Damage"});
            this.cmb_Shifts.Location = new System.Drawing.Point(94, 46);
            this.cmb_Shifts.Name = "cmb_Shifts";
            this.cmb_Shifts.Size = new System.Drawing.Size(172, 21);
            this.cmb_Shifts.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Shift";
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
            this.cmb_days.Location = new System.Drawing.Point(98, 11);
            this.cmb_days.Name = "cmb_days";
            this.cmb_days.Size = new System.Drawing.Size(196, 21);
            this.cmb_days.TabIndex = 14;
            this.cmb_days.SelectedIndexChanged += new System.EventHandler(this.cmb_days_SelectedIndexChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
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
            this.pnl_header.Size = new System.Drawing.Size(945, 37);
            this.pnl_header.TabIndex = 93;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.cmb_days);
            this.panel3.Location = new System.Drawing.Point(6, 47);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(932, 45);
            this.panel3.TabIndex = 105;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 14);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "Select Day Start";
            // 
            // frm_rosters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 511);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_footer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnl_header);
            this.Name = "frm_rosters";
            this.Text = "frm_rosters";
            this.Load += new System.EventHandler(this.frm_rosters_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgmain)).EndInit();
            this.pnl_footer.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.pnl_header.ResumeLayout(false);
            this.pnl_header.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgmain;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Panel pnl_footer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmb_days;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel pnl_header;
        private System.Windows.Forms.Label lbl_headerpaneltext;
        private System.Windows.Forms.ComboBox cmb_pumper;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_Nozzels;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_Shifts;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmb_endsM;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmb_endsH;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_startm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_starth;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShiftName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DayStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn Shift;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nozzel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pumper;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalNoOfWorkigH;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label12;
    }
}