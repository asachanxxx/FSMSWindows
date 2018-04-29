namespace FSMS.UI
{
    partial class frm_totalizerReadings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_totalizerReadings));
            this.button1 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_print = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnl_footer = new System.Windows.Forms.Panel();
            this.btn_delete = new System.Windows.Forms.Button();
            this.cmb_Nozzels = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.txt_creading = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_exreading = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_qty = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgmain = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DayStartCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nozzel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExReading = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NewReading = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SIH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_headerpaneltext = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_header = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmb_days = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmb_Shifts = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_show = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.pnl_footer.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_creading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_exreading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgmain)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnl_header.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageIndex = 8;
            this.button1.ImageList = this.imageList1;
            this.button1.Location = new System.Drawing.Point(463, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 35);
            this.button1.TabIndex = 64;
            this.button1.Text = "       Update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.btn_save.Location = new System.Drawing.Point(366, 5);
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
            this.btn_print.Location = new System.Drawing.Point(657, 5);
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
            this.btn_exit.Location = new System.Drawing.Point(754, 5);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(91, 35);
            this.btn_exit.TabIndex = 63;
            this.btn_exit.Text = "       Exit";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pnl_footer
            // 
            this.pnl_footer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(53)))), ((int)(((byte)(68)))));
            this.pnl_footer.Controls.Add(this.button1);
            this.pnl_footer.Controls.Add(this.btn_save);
            this.pnl_footer.Controls.Add(this.btn_print);
            this.pnl_footer.Controls.Add(this.btn_delete);
            this.pnl_footer.Controls.Add(this.btn_exit);
            this.pnl_footer.Location = new System.Drawing.Point(6, 450);
            this.pnl_footer.Name = "pnl_footer";
            this.pnl_footer.Size = new System.Drawing.Size(859, 45);
            this.pnl_footer.TabIndex = 90;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.White;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete.ImageIndex = 1;
            this.btn_delete.ImageList = this.imageList1;
            this.btn_delete.Location = new System.Drawing.Point(560, 5);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(91, 35);
            this.btn_delete.TabIndex = 61;
            this.btn_delete.Text = "     Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            // 
            // cmb_Nozzels
            // 
            this.cmb_Nozzels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Nozzels.FormattingEnabled = true;
            this.cmb_Nozzels.Location = new System.Drawing.Point(66, 11);
            this.cmb_Nozzels.Name = "cmb_Nozzels";
            this.cmb_Nozzels.Size = new System.Drawing.Size(172, 21);
            this.cmb_Nozzels.TabIndex = 14;
            this.cmb_Nozzels.SelectedIndexChanged += new System.EventHandler(this.cmb_Nozzels_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txt_total);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txt_price);
            this.panel2.Controls.Add(this.txt_creading);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.cmb_Nozzels);
            this.panel2.Controls.Add(this.txt_exreading);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lbl_id);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txt_qty);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(6, 384);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(859, 64);
            this.panel2.TabIndex = 92;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(685, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "Total";
            // 
            // txt_total
            // 
            this.txt_total.BackColor = System.Drawing.Color.White;
            this.txt_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total.Location = new System.Drawing.Point(729, 38);
            this.txt_total.Name = "txt_total";
            this.txt_total.ReadOnly = true;
            this.txt_total.Size = new System.Drawing.Size(124, 21);
            this.txt_total.TabIndex = 19;
            this.txt_total.Text = "0.00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(685, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "Price";
            // 
            // txt_price
            // 
            this.txt_price.BackColor = System.Drawing.Color.White;
            this.txt_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_price.Location = new System.Drawing.Point(729, 13);
            this.txt_price.Name = "txt_price";
            this.txt_price.ReadOnly = true;
            this.txt_price.Size = new System.Drawing.Size(124, 21);
            this.txt_price.TabIndex = 17;
            this.txt_price.Text = "0.00";
            // 
            // txt_creading
            // 
            this.txt_creading.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_creading.DecimalPlaces = 2;
            this.txt_creading.Location = new System.Drawing.Point(314, 13);
            this.txt_creading.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.txt_creading.Name = "txt_creading";
            this.txt_creading.Size = new System.Drawing.Size(160, 20);
            this.txt_creading.TabIndex = 16;
            this.txt_creading.ValueChanged += new System.EventHandler(this.txt_creading_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(251, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Cu:reading";
            // 
            // txt_exreading
            // 
            this.txt_exreading.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_exreading.DecimalPlaces = 2;
            this.txt_exreading.Location = new System.Drawing.Point(66, 35);
            this.txt_exreading.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.txt_exreading.Name = "txt_exreading";
            this.txt_exreading.ReadOnly = true;
            this.txt_exreading.Size = new System.Drawing.Size(172, 20);
            this.txt_exreading.TabIndex = 7;
            this.txt_exreading.ValueChanged += new System.EventHandler(this.txt_exreading_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ex:reading";
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
            this.label2.Location = new System.Drawing.Point(251, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Qty";
            // 
            // txt_qty
            // 
            this.txt_qty.BackColor = System.Drawing.Color.White;
            this.txt_qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_qty.Location = new System.Drawing.Point(314, 35);
            this.txt_qty.Name = "txt_qty";
            this.txt_qty.ReadOnly = true;
            this.txt_qty.Size = new System.Drawing.Size(160, 21);
            this.txt_qty.TabIndex = 2;
            this.txt_qty.Text = "0.00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nozzel";
            // 
            // dgmain
            // 
            this.dgmain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgmain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.DayStartCode,
            this.Nozzel,
            this.ExReading,
            this.NewReading,
            this.SIH,
            this.UPrice,
            this.Value});
            this.dgmain.Location = new System.Drawing.Point(7, 5);
            this.dgmain.Name = "dgmain";
            this.dgmain.Size = new System.Drawing.Size(845, 283);
            this.dgmain.TabIndex = 0;
            this.dgmain.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgmain_RowEnter);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "id";
            this.Id.HeaderText = "#";
            this.Id.Name = "Id";
            // 
            // DayStartCode
            // 
            this.DayStartCode.DataPropertyName = "Day";
            this.DayStartCode.HeaderText = "DayStartCode";
            this.DayStartCode.Name = "DayStartCode";
            // 
            // Nozzel
            // 
            this.Nozzel.DataPropertyName = "Nozzel";
            this.Nozzel.HeaderText = "Nozzel";
            this.Nozzel.Name = "Nozzel";
            // 
            // ExReading
            // 
            this.ExReading.DataPropertyName = "CussreentReading";
            this.ExReading.HeaderText = "Ex:Reading";
            this.ExReading.Name = "ExReading";
            // 
            // NewReading
            // 
            this.NewReading.DataPropertyName = "NewReading";
            this.NewReading.HeaderText = "NewReading";
            this.NewReading.Name = "NewReading";
            // 
            // SIH
            // 
            this.SIH.DataPropertyName = "SIH";
            this.SIH.HeaderText = "SIH";
            this.SIH.Name = "SIH";
            // 
            // UPrice
            // 
            this.UPrice.DataPropertyName = "UPrice";
            this.UPrice.HeaderText = "UPrice";
            this.UPrice.Name = "UPrice";
            // 
            // Value
            // 
            this.Value.DataPropertyName = "Value";
            this.Value.HeaderText = "Value";
            this.Value.Name = "Value";
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
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dgmain);
            this.panel1.Location = new System.Drawing.Point(7, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(858, 297);
            this.panel1.TabIndex = 91;
            // 
            // pnl_header
            // 
            this.pnl_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(108)))), ((int)(((byte)(139)))));
            this.pnl_header.Controls.Add(this.lbl_headerpaneltext);
            this.pnl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_header.Location = new System.Drawing.Point(0, 0);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Size = new System.Drawing.Size(872, 37);
            this.pnl_header.TabIndex = 89;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btn_show);
            this.panel3.Controls.Add(this.cmb_Shifts);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.cmb_days);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Location = new System.Drawing.Point(6, 41);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(859, 34);
            this.panel3.TabIndex = 93;
            // 
            // cmb_days
            // 
            this.cmb_days.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_days.FormattingEnabled = true;
            this.cmb_days.Location = new System.Drawing.Point(93, 6);
            this.cmb_days.Name = "cmb_days";
            this.cmb_days.Size = new System.Drawing.Size(172, 21);
            this.cmb_days.TabIndex = 14;
            this.cmb_days.SelectedIndexChanged += new System.EventHandler(this.cmb_days_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Select Day Start";
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
            this.cmb_Shifts.Location = new System.Drawing.Point(315, 6);
            this.cmb_Shifts.Name = "cmb_Shifts";
            this.cmb_Shifts.Size = new System.Drawing.Size(172, 21);
            this.cmb_Shifts.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(281, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Shift";
            // 
            // btn_show
            // 
            this.btn_show.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_show.Location = new System.Drawing.Point(494, 4);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(75, 23);
            this.btn_show.TabIndex = 19;
            this.btn_show.Text = "Show";
            this.btn_show.UseVisualStyleBackColor = true;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // frm_totalizerReadings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 498);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnl_footer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_header);
            this.Name = "frm_totalizerReadings";
            this.Text = "frm_totalizerReadings";
            this.Load += new System.EventHandler(this.frm_totalizerReadings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.pnl_footer.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_creading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_exreading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgmain)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pnl_header.ResumeLayout(false);
            this.pnl_header.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel pnl_footer;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmb_Nozzels;
        private System.Windows.Forms.NumericUpDown txt_exreading;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_qty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgmain;
        private System.Windows.Forms.Panel pnl_header;
        private System.Windows.Forms.Label lbl_headerpaneltext;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.NumericUpDown txt_creading;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn DayStartCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nozzel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExReading;
        private System.Windows.Forms.DataGridViewTextBoxColumn NewReading;
        private System.Windows.Forms.DataGridViewTextBoxColumn SIH;
        private System.Windows.Forms.DataGridViewTextBoxColumn UPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cmb_days;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmb_Shifts;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_show;
    }
}