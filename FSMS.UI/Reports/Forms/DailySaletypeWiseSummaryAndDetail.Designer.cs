namespace FSMS.UI.Reports.Forms
{
    partial class DailySaletypeWiseSummaryAndDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DailySaletypeWiseSummaryAndDetail));
            this.cmb_days = new System.Windows.Forms.ComboBox();
            this.pnl_footer = new System.Windows.Forms.Panel();
            this.btn_print = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_exit = new System.Windows.Forms.Button();
            this.pnl_header = new System.Windows.Forms.Panel();
            this.lbl_headerpaneltext = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.panel6 = new System.Windows.Forms.Panel();
            this.cmb_pumper = new System.Windows.Forms.ComboBox();
            this.chk_details = new System.Windows.Forms.RadioButton();
            this.chk_cummary = new System.Windows.Forms.RadioButton();
            this.chk_filter1 = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chk_credit = new System.Windows.Forms.RadioButton();
            this.chk_cash = new System.Windows.Forms.RadioButton();
            this.chk_voucher = new System.Windows.Forms.RadioButton();
            this.chk_expenses = new System.Windows.Forms.RadioButton();
            this.chk_testing = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_footer.SuspendLayout();
            this.pnl_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_days
            // 
            this.cmb_days.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_days.FormattingEnabled = true;
            this.cmb_days.Location = new System.Drawing.Point(170, 7);
            this.cmb_days.Name = "cmb_days";
            this.cmb_days.Size = new System.Drawing.Size(182, 21);
            this.cmb_days.TabIndex = 98;
            // 
            // pnl_footer
            // 
            this.pnl_footer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(53)))), ((int)(((byte)(68)))));
            this.pnl_footer.Controls.Add(this.btn_print);
            this.pnl_footer.Controls.Add(this.btn_exit);
            this.pnl_footer.Location = new System.Drawing.Point(3, 196);
            this.pnl_footer.Name = "pnl_footer";
            this.pnl_footer.Size = new System.Drawing.Size(448, 42);
            this.pnl_footer.TabIndex = 112;
            // 
            // btn_print
            // 
            this.btn_print.BackColor = System.Drawing.Color.White;
            this.btn_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_print.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_print.ImageIndex = 10;
            this.btn_print.ImageList = this.imageList1;
            this.btn_print.Location = new System.Drawing.Point(254, 4);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(91, 34);
            this.btn_print.TabIndex = 69;
            this.btn_print.Text = "       Print";
            this.btn_print.UseVisualStyleBackColor = false;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
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
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.White;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_exit.ImageIndex = 10;
            this.btn_exit.ImageList = this.imageList1;
            this.btn_exit.Location = new System.Drawing.Point(351, 4);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(91, 34);
            this.btn_exit.TabIndex = 68;
            this.btn_exit.Text = "       Exit";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // pnl_header
            // 
            this.pnl_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(108)))), ((int)(((byte)(139)))));
            this.pnl_header.Controls.Add(this.lbl_headerpaneltext);
            this.pnl_header.Location = new System.Drawing.Point(2, 0);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Size = new System.Drawing.Size(449, 38);
            this.pnl_header.TabIndex = 111;
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
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "Log ogg.png");
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.cmb_pumper);
            this.panel6.Controls.Add(this.chk_details);
            this.panel6.Controls.Add(this.chk_cummary);
            this.panel6.Controls.Add(this.chk_filter1);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.cmb_days);
            this.panel6.Location = new System.Drawing.Point(4, 46);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(447, 92);
            this.panel6.TabIndex = 113;
            // 
            // cmb_pumper
            // 
            this.cmb_pumper.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_pumper.FormattingEnabled = true;
            this.cmb_pumper.Location = new System.Drawing.Point(170, 34);
            this.cmb_pumper.Name = "cmb_pumper";
            this.cmb_pumper.Size = new System.Drawing.Size(182, 21);
            this.cmb_pumper.TabIndex = 104;
            // 
            // chk_details
            // 
            this.chk_details.AutoSize = true;
            this.chk_details.Checked = true;
            this.chk_details.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.chk_details.Location = new System.Drawing.Point(291, 61);
            this.chk_details.Name = "chk_details";
            this.chk_details.Size = new System.Drawing.Size(69, 22);
            this.chk_details.TabIndex = 103;
            this.chk_details.TabStop = true;
            this.chk_details.Text = "Details";
            this.chk_details.UseVisualStyleBackColor = true;
            // 
            // chk_cummary
            // 
            this.chk_cummary.AutoSize = true;
            this.chk_cummary.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.chk_cummary.Location = new System.Drawing.Point(170, 61);
            this.chk_cummary.Name = "chk_cummary";
            this.chk_cummary.Size = new System.Drawing.Size(84, 22);
            this.chk_cummary.TabIndex = 102;
            this.chk_cummary.Text = "Summary";
            this.chk_cummary.UseVisualStyleBackColor = true;
            this.chk_cummary.Visible = false;
            // 
            // chk_filter1
            // 
            this.chk_filter1.AutoSize = true;
            this.chk_filter1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_filter1.Location = new System.Drawing.Point(12, 37);
            this.chk_filter1.Name = "chk_filter1";
            this.chk_filter1.Size = new System.Drawing.Size(130, 22);
            this.chk_filter1.TabIndex = 100;
            this.chk_filter1.Text = "Filter By Pumper";
            this.chk_filter1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.label8.Location = new System.Drawing.Point(9, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 18);
            this.label8.TabIndex = 2;
            this.label8.Text = "Select a Day";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.chk_testing);
            this.panel1.Controls.Add(this.chk_expenses);
            this.panel1.Controls.Add(this.chk_voucher);
            this.panel1.Controls.Add(this.chk_credit);
            this.panel1.Controls.Add(this.chk_cash);
            this.panel1.Location = new System.Drawing.Point(4, 144);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(447, 46);
            this.panel1.TabIndex = 114;
            // 
            // chk_credit
            // 
            this.chk_credit.AutoSize = true;
            this.chk_credit.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.chk_credit.Location = new System.Drawing.Point(256, 12);
            this.chk_credit.Name = "chk_credit";
            this.chk_credit.Size = new System.Drawing.Size(82, 22);
            this.chk_credit.TabIndex = 103;
            this.chk_credit.Text = "By Credit";
            this.chk_credit.UseVisualStyleBackColor = true;
            this.chk_credit.CheckedChanged += new System.EventHandler(this.chk_credit_CheckedChanged);
            // 
            // chk_cash
            // 
            this.chk_cash.AutoSize = true;
            this.chk_cash.Checked = true;
            this.chk_cash.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.chk_cash.Location = new System.Drawing.Point(149, 12);
            this.chk_cash.Name = "chk_cash";
            this.chk_cash.Size = new System.Drawing.Size(73, 22);
            this.chk_cash.TabIndex = 102;
            this.chk_cash.TabStop = true;
            this.chk_cash.Text = "By Cash";
            this.chk_cash.UseVisualStyleBackColor = true;
            this.chk_cash.CheckedChanged += new System.EventHandler(this.chk_cash_CheckedChanged);
            // 
            // chk_voucher
            // 
            this.chk_voucher.AutoSize = true;
            this.chk_voucher.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.chk_voucher.Location = new System.Drawing.Point(339, 12);
            this.chk_voucher.Name = "chk_voucher";
            this.chk_voucher.Size = new System.Drawing.Size(95, 22);
            this.chk_voucher.TabIndex = 104;
            this.chk_voucher.Text = "By Voucher";
            this.chk_voucher.UseVisualStyleBackColor = true;
            this.chk_voucher.CheckedChanged += new System.EventHandler(this.chk_voucher_CheckedChanged);
            // 
            // chk_expenses
            // 
            this.chk_expenses.AutoSize = true;
            this.chk_expenses.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.chk_expenses.Location = new System.Drawing.Point(149, 40);
            this.chk_expenses.Name = "chk_expenses";
            this.chk_expenses.Size = new System.Drawing.Size(102, 22);
            this.chk_expenses.TabIndex = 105;
            this.chk_expenses.Text = "By Expenses";
            this.chk_expenses.UseVisualStyleBackColor = true;
            this.chk_expenses.Visible = false;
            // 
            // chk_testing
            // 
            this.chk_testing.AutoSize = true;
            this.chk_testing.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.chk_testing.Location = new System.Drawing.Point(256, 40);
            this.chk_testing.Name = "chk_testing";
            this.chk_testing.Size = new System.Drawing.Size(85, 22);
            this.chk_testing.TabIndex = 106;
            this.chk_testing.Text = "ByTesting";
            this.chk_testing.UseVisualStyleBackColor = true;
            this.chk_testing.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(3, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 18);
            this.label1.TabIndex = 107;
            this.label1.Text = "Filter";
            // 
            // DailySaletypeWiseSummaryAndDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 245);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_footer);
            this.Controls.Add(this.pnl_header);
            this.Controls.Add(this.panel6);
            this.Name = "DailySaletypeWiseSummaryAndDetail";
            this.Text = "DailySaletypeWiseSummaryAndDetail";
            this.Load += new System.EventHandler(this.DailySaletypeWiseSummaryAndDetail_Load);
            this.pnl_footer.ResumeLayout(false);
            this.pnl_header.ResumeLayout(false);
            this.pnl_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_days;
        private System.Windows.Forms.Panel pnl_footer;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Panel pnl_header;
        private System.Windows.Forms.Label lbl_headerpaneltext;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton chk_testing;
        private System.Windows.Forms.RadioButton chk_expenses;
        private System.Windows.Forms.RadioButton chk_voucher;
        private System.Windows.Forms.RadioButton chk_credit;
        private System.Windows.Forms.RadioButton chk_cash;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ComboBox cmb_pumper;
        private System.Windows.Forms.RadioButton chk_details;
        private System.Windows.Forms.RadioButton chk_cummary;
        private System.Windows.Forms.CheckBox chk_filter1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ImageList imageList2;
    }
}