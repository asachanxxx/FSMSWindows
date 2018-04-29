namespace FSMS.UI
{
    partial class frm_DailySales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_DailySales));
            this.pnl_footer = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_print = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.cmb_Shifts = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_days = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_innerd = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_header = new System.Windows.Forms.Panel();
            this.lbl_headerpaneltext = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgtotalizer = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentTotalizer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reading = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LiveSIH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_footer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_innerd)).BeginInit();
            this.pnl_header.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgtotalizer)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_footer
            // 
            this.pnl_footer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(53)))), ((int)(((byte)(68)))));
            this.pnl_footer.Controls.Add(this.button1);
            this.pnl_footer.Controls.Add(this.btn_save);
            this.pnl_footer.Controls.Add(this.btn_print);
            this.pnl_footer.Controls.Add(this.btn_delete);
            this.pnl_footer.Controls.Add(this.btn_exit);
            this.pnl_footer.Location = new System.Drawing.Point(6, 515);
            this.pnl_footer.Name = "pnl_footer";
            this.pnl_footer.Size = new System.Drawing.Size(1118, 45);
            this.pnl_footer.TabIndex = 98;
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
            this.btn_save.Location = new System.Drawing.Point(447, 4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(91, 35);
            this.btn_save.TabIndex = 59;
            this.btn_save.Text = "     Insert";
            this.btn_save.UseVisualStyleBackColor = false;
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
            this.cmb_Shifts.Location = new System.Drawing.Point(94, 73);
            this.cmb_Shifts.Name = "cmb_Shifts";
            this.cmb_Shifts.Size = new System.Drawing.Size(172, 21);
            this.cmb_Shifts.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Sales Type";
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
            this.cmb_days.Location = new System.Drawing.Point(94, 46);
            this.cmb_days.Name = "cmb_days";
            this.cmb_days.Size = new System.Drawing.Size(172, 21);
            this.cmb_days.TabIndex = 14;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txt_innerd);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.cmb_Shifts);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cmb_days);
            this.panel2.Controls.Add(this.lbl_id);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txt_name);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 312);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(289, 137);
            this.panel2.TabIndex = 100;
            // 
            // txt_innerd
            // 
            this.txt_innerd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_innerd.DecimalPlaces = 2;
            this.txt_innerd.Location = new System.Drawing.Point(94, 100);
            this.txt_innerd.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txt_innerd.Name = "txt_innerd";
            this.txt_innerd.Size = new System.Drawing.Size(172, 20);
            this.txt_innerd.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Pumper Total";
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
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Document No";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(94, 20);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(172, 20);
            this.txt_name.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pumper";
            // 
            // pnl_header
            // 
            this.pnl_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(108)))), ((int)(((byte)(139)))));
            this.pnl_header.Controls.Add(this.lbl_headerpaneltext);
            this.pnl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_header.Location = new System.Drawing.Point(0, 0);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Size = new System.Drawing.Size(1124, 37);
            this.pnl_header.TabIndex = 97;
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
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.numericUpDown1);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(12, 39);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1100, 34);
            this.panel3.TabIndex = 101;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.Location = new System.Drawing.Point(90, 5);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(172, 20);
            this.numericUpDown1.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Pumper Total";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.dgtotalizer);
            this.panel4.Location = new System.Drawing.Point(12, 77);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(386, 229);
            this.panel4.TabIndex = 102;
            // 
            // dgtotalizer
            // 
            this.dgtotalizer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtotalizer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.CurrentTotalizer,
            this.Reading,
            this.LiveSIH});
            this.dgtotalizer.Location = new System.Drawing.Point(4, 5);
            this.dgtotalizer.Name = "dgtotalizer";
            this.dgtotalizer.Size = new System.Drawing.Size(374, 213);
            this.dgtotalizer.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "#";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nozzel";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nozzel";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // CurrentTotalizer
            // 
            this.CurrentTotalizer.DataPropertyName = "Current";
            this.CurrentTotalizer.HeaderText = "Current ";
            this.CurrentTotalizer.Name = "CurrentTotalizer";
            // 
            // Reading
            // 
            this.Reading.HeaderText = "Reading";
            this.Reading.Name = "Reading";
            // 
            // LiveSIH
            // 
            this.LiveSIH.HeaderText = "LiveSIH";
            this.LiveSIH.Name = "LiveSIH";
            // 
            // frm_DailySales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 559);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnl_footer);
            this.Controls.Add(this.pnl_header);
            this.Name = "frm_DailySales";
            this.Text = "frm_DailySales";
            this.Load += new System.EventHandler(this.frm_DailySales_Load);
            this.pnl_footer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_innerd)).EndInit();
            this.pnl_header.ResumeLayout(false);
            this.pnl_header.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgtotalizer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnl_footer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.ComboBox cmb_Shifts;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_days;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl_header;
        private System.Windows.Forms.Label lbl_headerpaneltext;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgtotalizer;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown txt_innerd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrentTotalizer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reading;
        private System.Windows.Forms.DataGridViewTextBoxColumn LiveSIH;
    }
}