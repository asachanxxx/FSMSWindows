namespace FSMS.UI
{
    partial class frm_grn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_grn));
            this.pnl_footer = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_save = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.pnl_header = new System.Windows.Forms.Panel();
            this.lbl_headerpaneltext = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dgmain = new System.Windows.Forms.DataGridView();
            this.FuelType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quntity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.num_total = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_fueltypes = new System.Windows.Forms.ComboBox();
            this.txt_price = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_qty = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_DocNo = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.num_deducts = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.num_additions = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_net = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbl_deduct = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbl_additions = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_subtotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pnl_footer.SuspendLayout();
            this.pnl_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgmain)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_total)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_qty)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_deducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_additions)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_footer
            // 
            this.pnl_footer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(53)))), ((int)(((byte)(68)))));
            this.pnl_footer.Controls.Add(this.button2);
            this.pnl_footer.Controls.Add(this.btn_save);
            this.pnl_footer.Controls.Add(this.button1);
            this.pnl_footer.Controls.Add(this.btn_exit);
            this.pnl_footer.Location = new System.Drawing.Point(-2, 460);
            this.pnl_footer.Name = "pnl_footer";
            this.pnl_footer.Size = new System.Drawing.Size(615, 52);
            this.pnl_footer.TabIndex = 93;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.ImageIndex = 8;
            this.button2.ImageList = this.imageList1;
            this.button2.Location = new System.Drawing.Point(324, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 38);
            this.button2.TabIndex = 66;
            this.button2.Text = "       Update";
            this.button2.UseVisualStyleBackColor = false;
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
            this.btn_save.Location = new System.Drawing.Point(227, 7);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(91, 38);
            this.btn_save.TabIndex = 65;
            this.btn_save.Text = "     Insert";
            this.btn_save.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageIndex = 5;
            this.button1.ImageList = this.imageList1;
            this.button1.Location = new System.Drawing.Point(421, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 41);
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
            this.btn_exit.Location = new System.Drawing.Point(518, 5);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(91, 41);
            this.btn_exit.TabIndex = 63;
            this.btn_exit.Text = "       Exit";
            this.btn_exit.UseVisualStyleBackColor = false;
            // 
            // pnl_header
            // 
            this.pnl_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(108)))), ((int)(((byte)(139)))));
            this.pnl_header.Controls.Add(this.lbl_headerpaneltext);
            this.pnl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_header.Location = new System.Drawing.Point(0, 0);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Size = new System.Drawing.Size(1004, 43);
            this.pnl_header.TabIndex = 92;
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
            // dgmain
            // 
            this.dgmain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgmain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FuelType,
            this.Quntity,
            this.Price,
            this.Total});
            this.dgmain.Location = new System.Drawing.Point(10, 164);
            this.dgmain.Name = "dgmain";
            this.dgmain.Size = new System.Drawing.Size(603, 178);
            this.dgmain.TabIndex = 94;
            // 
            // FuelType
            // 
            this.FuelType.DataPropertyName = "FuelType";
            this.FuelType.HeaderText = "FuelType";
            this.FuelType.Name = "FuelType";
            // 
            // Quntity
            // 
            this.Quntity.DataPropertyName = "Quntity";
            this.Quntity.HeaderText = "Quntity";
            this.Quntity.Name = "Quntity";
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Total";
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.num_total);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cmb_fueltypes);
            this.panel2.Controls.Add(this.txt_price);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txt_qty);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(10, 88);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(603, 70);
            this.panel2.TabIndex = 95;
            // 
            // num_total
            // 
            this.num_total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.num_total.DecimalPlaces = 2;
            this.num_total.Location = new System.Drawing.Point(453, 21);
            this.num_total.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.num_total.Name = "num_total";
            this.num_total.Size = new System.Drawing.Size(143, 23);
            this.num_total.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(450, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Total";
            // 
            // cmb_fueltypes
            // 
            this.cmb_fueltypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_fueltypes.FormattingEnabled = true;
            this.cmb_fueltypes.Location = new System.Drawing.Point(6, 20);
            this.cmb_fueltypes.Name = "cmb_fueltypes";
            this.cmb_fueltypes.Size = new System.Drawing.Size(192, 23);
            this.cmb_fueltypes.TabIndex = 14;
            // 
            // txt_price
            // 
            this.txt_price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_price.DecimalPlaces = 2;
            this.txt_price.Location = new System.Drawing.Point(322, 21);
            this.txt_price.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(125, 23);
            this.txt_price.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(319, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Price";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txt_qty
            // 
            this.txt_qty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_qty.DecimalPlaces = 2;
            this.txt_qty.Location = new System.Drawing.Point(204, 21);
            this.txt_qty.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txt_qty.Name = "txt_qty";
            this.txt_qty.Size = new System.Drawing.Size(112, 23);
            this.txt_qty.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(201, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Qty";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Current Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fuel Code";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txt_DocNo);
            this.panel1.Location = new System.Drawing.Point(10, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(603, 33);
            this.panel1.TabIndex = 96;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 14);
            this.label10.TabIndex = 3;
            this.label10.Text = "Document No";
            // 
            // txt_DocNo
            // 
            this.txt_DocNo.Location = new System.Drawing.Point(101, 3);
            this.txt_DocNo.Name = "txt_DocNo";
            this.txt_DocNo.Size = new System.Drawing.Size(172, 22);
            this.txt_DocNo.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.num_deducts);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.num_additions);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.lbl_net);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.lbl_deduct);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.lbl_additions);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.lbl_subtotal);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(10, 348);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(603, 106);
            this.panel3.TabIndex = 97;
            // 
            // num_deducts
            // 
            this.num_deducts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.num_deducts.DecimalPlaces = 2;
            this.num_deducts.Location = new System.Drawing.Point(138, 26);
            this.num_deducts.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.num_deducts.Name = "num_deducts";
            this.num_deducts.Size = new System.Drawing.Size(125, 23);
            this.num_deducts.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(135, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 15);
            this.label7.TabIndex = 25;
            this.label7.Text = "Deductions";
            // 
            // num_additions
            // 
            this.num_additions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.num_additions.DecimalPlaces = 2;
            this.num_additions.Location = new System.Drawing.Point(20, 26);
            this.num_additions.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.num_additions.Name = "num_additions";
            this.num_additions.Size = new System.Drawing.Size(112, 23);
            this.num_additions.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 15);
            this.label9.TabIndex = 23;
            this.label9.Text = "Additions";
            // 
            // lbl_net
            // 
            this.lbl_net.AutoSize = true;
            this.lbl_net.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_net.Location = new System.Drawing.Point(519, 68);
            this.lbl_net.Name = "lbl_net";
            this.lbl_net.Size = new System.Drawing.Size(62, 29);
            this.lbl_net.TabIndex = 22;
            this.lbl_net.Text = "Total";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(391, 76);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 15);
            this.label13.TabIndex = 21;
            this.label13.Text = " Net Total";
            // 
            // lbl_deduct
            // 
            this.lbl_deduct.AutoSize = true;
            this.lbl_deduct.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_deduct.Location = new System.Drawing.Point(538, 49);
            this.lbl_deduct.Name = "lbl_deduct";
            this.lbl_deduct.Size = new System.Drawing.Size(43, 19);
            this.lbl_deduct.TabIndex = 20;
            this.lbl_deduct.Text = "Total";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(391, 53);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 15);
            this.label11.TabIndex = 19;
            this.label11.Text = "Deductions";
            // 
            // lbl_additions
            // 
            this.lbl_additions.AutoSize = true;
            this.lbl_additions.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_additions.Location = new System.Drawing.Point(538, 30);
            this.lbl_additions.Name = "lbl_additions";
            this.lbl_additions.Size = new System.Drawing.Size(43, 19);
            this.lbl_additions.TabIndex = 18;
            this.lbl_additions.Text = "Total";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(391, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 15);
            this.label8.TabIndex = 17;
            this.label8.Text = "Additions";
            // 
            // lbl_subtotal
            // 
            this.lbl_subtotal.AutoSize = true;
            this.lbl_subtotal.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_subtotal.Location = new System.Drawing.Point(538, 11);
            this.lbl_subtotal.Name = "lbl_subtotal";
            this.lbl_subtotal.Size = new System.Drawing.Size(43, 19);
            this.lbl_subtotal.TabIndex = 16;
            this.lbl_subtotal.Text = "Total";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(391, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Sub Total";
            // 
            // frm_grn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 512);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgmain);
            this.Controls.Add(this.pnl_footer);
            this.Controls.Add(this.pnl_header);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frm_grn";
            this.Text = "frm_grn";
            this.Load += new System.EventHandler(this.frm_grn_Load);
            this.pnl_footer.ResumeLayout(false);
            this.pnl_header.ResumeLayout(false);
            this.pnl_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgmain)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_total)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_qty)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_deducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_additions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_footer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Panel pnl_header;
        private System.Windows.Forms.Label lbl_headerpaneltext;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView dgmain;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmb_fueltypes;
        private System.Windows.Forms.NumericUpDown txt_price;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown txt_qty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown num_total;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.NumericUpDown num_deducts;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown num_additions;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_net;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbl_deduct;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbl_additions;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_subtotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_DocNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FuelType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quntity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}