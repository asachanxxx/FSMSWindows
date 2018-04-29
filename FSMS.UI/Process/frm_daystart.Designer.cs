namespace FSMS.UI
{
    partial class frm_daystart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_daystart));
            this.pnl_header = new System.Windows.Forms.Panel();
            this.lbl_headerpaneltext = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_cancelr = new System.Windows.Forms.TextBox();
            this.chk_cancelday = new System.Windows.Forms.CheckBox();
            this.dte_date = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_daystamp = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_day = new System.Windows.Forms.TextBox();
            this.pnl_footer = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_print = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgmain = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateStamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Iscancel = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pnl_header.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnl_footer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgmain)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_header
            // 
            this.pnl_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(108)))), ((int)(((byte)(139)))));
            this.pnl_header.Controls.Add(this.lbl_headerpaneltext);
            this.pnl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_header.Location = new System.Drawing.Point(0, 0);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Size = new System.Drawing.Size(794, 37);
            this.pnl_header.TabIndex = 90;
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
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txt_cancelr);
            this.panel2.Controls.Add(this.chk_cancelday);
            this.panel2.Controls.Add(this.dte_date);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txt_daystamp);
            this.panel2.Controls.Add(this.lbl_id);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txt_day);
            this.panel2.Location = new System.Drawing.Point(12, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(324, 277);
            this.panel2.TabIndex = 93;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Reason";
            // 
            // txt_cancelr
            // 
            this.txt_cancelr.Location = new System.Drawing.Point(100, 121);
            this.txt_cancelr.Multiline = true;
            this.txt_cancelr.Name = "txt_cancelr";
            this.txt_cancelr.Size = new System.Drawing.Size(172, 134);
            this.txt_cancelr.TabIndex = 21;
            // 
            // chk_cancelday
            // 
            this.chk_cancelday.AutoSize = true;
            this.chk_cancelday.Location = new System.Drawing.Point(100, 98);
            this.chk_cancelday.Name = "chk_cancelday";
            this.chk_cancelday.Size = new System.Drawing.Size(81, 17);
            this.chk_cancelday.TabIndex = 20;
            this.chk_cancelday.Text = "Cancel Day";
            this.chk_cancelday.UseVisualStyleBackColor = true;
            // 
            // dte_date
            // 
            this.dte_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dte_date.Location = new System.Drawing.Point(100, 19);
            this.dte_date.Name = "dte_date";
            this.dte_date.Size = new System.Drawing.Size(172, 20);
            this.dte_date.TabIndex = 19;
            this.dte_date.ValueChanged += new System.EventHandler(this.dte_date_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "DateStanp";
            // 
            // txt_daystamp
            // 
            this.txt_daystamp.Location = new System.Drawing.Point(100, 71);
            this.txt_daystamp.Name = "txt_daystamp";
            this.txt_daystamp.Size = new System.Drawing.Size(172, 20);
            this.txt_daystamp.TabIndex = 15;
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
            this.label2.Location = new System.Drawing.Point(16, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Day";
            // 
            // txt_day
            // 
            this.txt_day.Location = new System.Drawing.Point(100, 45);
            this.txt_day.Name = "txt_day";
            this.txt_day.Size = new System.Drawing.Size(172, 20);
            this.txt_day.TabIndex = 2;
            // 
            // pnl_footer
            // 
            this.pnl_footer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(53)))), ((int)(((byte)(68)))));
            this.pnl_footer.Controls.Add(this.button1);
            this.pnl_footer.Controls.Add(this.btn_save);
            this.pnl_footer.Controls.Add(this.btn_print);
            this.pnl_footer.Controls.Add(this.btn_delete);
            this.pnl_footer.Controls.Add(this.btn_exit);
            this.pnl_footer.Location = new System.Drawing.Point(0, 332);
            this.pnl_footer.Name = "pnl_footer";
            this.pnl_footer.Size = new System.Drawing.Size(742, 45);
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
            this.button1.Location = new System.Drawing.Point(345, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 35);
            this.button1.TabIndex = 69;
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
            this.btn_save.Location = new System.Drawing.Point(248, 5);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(91, 35);
            this.btn_save.TabIndex = 65;
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
            this.btn_print.Location = new System.Drawing.Point(539, 5);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(91, 35);
            this.btn_print.TabIndex = 67;
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
            this.btn_delete.Location = new System.Drawing.Point(442, 5);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(91, 35);
            this.btn_delete.TabIndex = 66;
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
            this.btn_exit.Location = new System.Drawing.Point(636, 5);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(91, 35);
            this.btn_exit.TabIndex = 68;
            this.btn_exit.Text = "       Exit";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dgmain);
            this.panel1.Location = new System.Drawing.Point(345, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(397, 277);
            this.panel1.TabIndex = 95;
            // 
            // dgmain
            // 
            this.dgmain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgmain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Day,
            this.DateStamp,
            this.Iscancel});
            this.dgmain.Location = new System.Drawing.Point(7, 5);
            this.dgmain.Name = "dgmain";
            this.dgmain.Size = new System.Drawing.Size(385, 266);
            this.dgmain.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "id";
            this.Id.HeaderText = "#";
            this.Id.Name = "Id";
            // 
            // Day
            // 
            this.Day.DataPropertyName = "Day";
            this.Day.HeaderText = "Day";
            this.Day.Name = "Day";
            // 
            // DateStamp
            // 
            this.DateStamp.DataPropertyName = "DateStamp";
            this.DateStamp.HeaderText = "DateStamp";
            this.DateStamp.Name = "DateStamp";
            // 
            // Iscancel
            // 
            this.Iscancel.DataPropertyName = "Iscancel";
            this.Iscancel.HeaderText = "Iscancel";
            this.Iscancel.Name = "Iscancel";
            // 
            // frm_daystart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 378);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_footer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnl_header);
            this.Name = "frm_daystart";
            this.Text = "frm_daystart";
            this.Load += new System.EventHandler(this.frm_daystart_Load);
            this.pnl_header.ResumeLayout(false);
            this.pnl_header.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnl_footer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgmain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_header;
        private System.Windows.Forms.Label lbl_headerpaneltext;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_day;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_cancelr;
        private System.Windows.Forms.CheckBox chk_cancelday;
        private System.Windows.Forms.DateTimePicker dte_date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_daystamp;
        private System.Windows.Forms.Panel pnl_footer;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgmain;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateStamp;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Iscancel;
    }
}