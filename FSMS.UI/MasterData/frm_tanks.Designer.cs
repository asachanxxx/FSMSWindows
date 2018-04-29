namespace FSMS.UI
{
    partial class frm_tanks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_tanks));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lbl_id = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_innerd = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_headerpaneltext = new System.Windows.Forms.Label();
            this.pnl_footer = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_print = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.dgmain = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FuelTypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TankName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentSIH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmb_fueltypes = new System.Windows.Forms.ComboBox();
            this.txt_SiH = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_cap = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_len = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_header = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.txt_innerd)).BeginInit();
            this.pnl_footer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgmain)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_len)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnl_header.SuspendLayout();
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
            this.label2.Location = new System.Drawing.Point(21, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tank Name";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(105, 53);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(172, 20);
            this.txt_name.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fuel Code";
            // 
            // txt_innerd
            // 
            this.txt_innerd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_innerd.DecimalPlaces = 2;
            this.txt_innerd.Location = new System.Drawing.Point(105, 79);
            this.txt_innerd.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txt_innerd.Name = "txt_innerd";
            this.txt_innerd.Size = new System.Drawing.Size(172, 20);
            this.txt_innerd.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Inner Diameter";
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
            this.pnl_footer.Controls.Add(this.button1);
            this.pnl_footer.Controls.Add(this.btn_save);
            this.pnl_footer.Controls.Add(this.btn_print);
            this.pnl_footer.Controls.Add(this.btn_delete);
            this.pnl_footer.Controls.Add(this.btn_exit);
            this.pnl_footer.Location = new System.Drawing.Point(6, 346);
            this.pnl_footer.Name = "pnl_footer";
            this.pnl_footer.Size = new System.Drawing.Size(879, 45);
            this.pnl_footer.TabIndex = 86;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageIndex = 8;
            this.button1.ImageList = this.imageList1;
            this.button1.Location = new System.Drawing.Point(494, 4);
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
            this.btn_save.Location = new System.Drawing.Point(397, 4);
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
            this.btn_print.Location = new System.Drawing.Point(688, 4);
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
            this.btn_delete.Location = new System.Drawing.Point(591, 4);
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
            this.btn_exit.Location = new System.Drawing.Point(785, 4);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(91, 35);
            this.btn_exit.TabIndex = 63;
            this.btn_exit.Text = "       Exit";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // dgmain
            // 
            this.dgmain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgmain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.FuelTypeID,
            this.TankName,
            this.CurrentSIH});
            this.dgmain.Location = new System.Drawing.Point(7, 5);
            this.dgmain.Name = "dgmain";
            this.dgmain.Size = new System.Drawing.Size(528, 283);
            this.dgmain.TabIndex = 0;
            this.dgmain.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgmain_RowEnter);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "id";
            this.Id.HeaderText = "#";
            this.Id.Name = "Id";
            // 
            // FuelTypeID
            // 
            this.FuelTypeID.DataPropertyName = "FuelTypeID";
            this.FuelTypeID.HeaderText = "FuelTypeID";
            this.FuelTypeID.Name = "FuelTypeID";
            // 
            // TankName
            // 
            this.TankName.DataPropertyName = "TankName";
            this.TankName.HeaderText = "Tank Name";
            this.TankName.Name = "TankName";
            // 
            // CurrentSIH
            // 
            this.CurrentSIH.DataPropertyName = "CurrentSIH";
            this.CurrentSIH.HeaderText = "Current SIH";
            this.CurrentSIH.Name = "CurrentSIH";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cmb_fueltypes);
            this.panel2.Controls.Add(this.txt_SiH);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txt_cap);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txt_len);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txt_innerd);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lbl_id);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txt_name);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(558, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(324, 297);
            this.panel2.TabIndex = 88;
            // 
            // cmb_fueltypes
            // 
            this.cmb_fueltypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_fueltypes.FormattingEnabled = true;
            this.cmb_fueltypes.Location = new System.Drawing.Point(105, 25);
            this.cmb_fueltypes.Name = "cmb_fueltypes";
            this.cmb_fueltypes.Size = new System.Drawing.Size(172, 21);
            this.cmb_fueltypes.TabIndex = 14;
            // 
            // txt_SiH
            // 
            this.txt_SiH.AutoSize = true;
            this.txt_SiH.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SiH.Location = new System.Drawing.Point(21, 193);
            this.txt_SiH.Name = "txt_SiH";
            this.txt_SiH.Size = new System.Drawing.Size(68, 36);
            this.txt_SiH.TabIndex = 13;
            this.txt_SiH.Text = "0.00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Current Fuel Stock";
            // 
            // txt_cap
            // 
            this.txt_cap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_cap.DecimalPlaces = 2;
            this.txt_cap.Location = new System.Drawing.Point(105, 131);
            this.txt_cap.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txt_cap.Name = "txt_cap";
            this.txt_cap.Size = new System.Drawing.Size(172, 20);
            this.txt_cap.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Capacity";
            // 
            // txt_len
            // 
            this.txt_len.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_len.DecimalPlaces = 2;
            this.txt_len.Location = new System.Drawing.Point(105, 105);
            this.txt_len.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txt_len.Name = "txt_len";
            this.txt_len.Size = new System.Drawing.Size(172, 20);
            this.txt_len.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Length";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dgmain);
            this.panel1.Location = new System.Drawing.Point(7, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(545, 297);
            this.panel1.TabIndex = 87;
            // 
            // pnl_header
            // 
            this.pnl_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(108)))), ((int)(((byte)(139)))));
            this.pnl_header.Controls.Add(this.lbl_headerpaneltext);
            this.pnl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_header.Location = new System.Drawing.Point(0, 0);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Size = new System.Drawing.Size(895, 37);
            this.pnl_header.TabIndex = 85;
            // 
            // frm_tanks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 395);
            this.Controls.Add(this.pnl_footer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_header);
            this.Name = "frm_tanks";
            this.Text = "frm_tanks";
            this.Load += new System.EventHandler(this.frm_tanks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_innerd)).EndInit();
            this.pnl_footer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgmain)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_len)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pnl_header.ResumeLayout(false);
            this.pnl_header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.NumericUpDown txt_innerd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_headerpaneltext;
        private System.Windows.Forms.Panel pnl_footer;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.DataGridView dgmain;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnl_header;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown txt_cap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown txt_len;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txt_SiH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FuelTypeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TankName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrentSIH;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmb_fueltypes;
    }
}