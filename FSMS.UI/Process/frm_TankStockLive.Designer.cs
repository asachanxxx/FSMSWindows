namespace FSMS.UI
{
    partial class frm_TankStockLive
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_TankStockLive));
            this.pnl_header = new System.Windows.Forms.Panel();
            this.lbl_headerpaneltext = new System.Windows.Forms.Label();
            this.pnl_footer = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_exit = new System.Windows.Forms.Button();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_capacity = new System.Windows.Forms.Label();
            this.lbl_innerdia = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_len = new System.Windows.Forms.Label();
            this.lst_nos = new System.Windows.Forms.ListView();
            this.imageList3 = new System.Windows.Forms.ImageList(this.components);
            this.lst_nozzels = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgmain = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_stock = new System.Windows.Forms.Label();
            this.pnl_header.SuspendLayout();
            this.pnl_footer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgmain)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_header
            // 
            this.pnl_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(108)))), ((int)(((byte)(139)))));
            this.pnl_header.Controls.Add(this.lbl_headerpaneltext);
            this.pnl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_header.Location = new System.Drawing.Point(0, 0);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Size = new System.Drawing.Size(908, 43);
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
            // pnl_footer
            // 
            this.pnl_footer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(53)))), ((int)(((byte)(68)))));
            this.pnl_footer.Controls.Add(this.button1);
            this.pnl_footer.Controls.Add(this.btn_exit);
            this.pnl_footer.Location = new System.Drawing.Point(-3, 489);
            this.pnl_footer.Name = "pnl_footer";
            this.pnl_footer.Size = new System.Drawing.Size(902, 40);
            this.pnl_footer.TabIndex = 91;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageIndex = 5;
            this.button1.ImageList = this.imageList1;
            this.button1.Location = new System.Drawing.Point(710, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 33);
            this.button1.TabIndex = 64;
            this.button1.Text = "       Print";
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
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.White;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_exit.ImageIndex = 10;
            this.btn_exit.ImageList = this.imageList1;
            this.btn_exit.Location = new System.Drawing.Point(807, 3);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(91, 33);
            this.btn_exit.TabIndex = 63;
            this.btn_exit.Text = "       Exit";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "oil-tanker.png");
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.panel4);
            this.panel6.Controls.Add(this.lst_nos);
            this.panel6.Controls.Add(this.lst_nozzels);
            this.panel6.Location = new System.Drawing.Point(10, 50);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(560, 436);
            this.panel6.TabIndex = 110;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.lbl_capacity);
            this.panel4.Controls.Add(this.lbl_innerdia);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.lbl_len);
            this.panel4.Location = new System.Drawing.Point(5, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(546, 53);
            this.panel4.TabIndex = 111;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Notice..";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 14);
            this.label4.TabIndex = 18;
            this.label4.Text = "Inner Diameter";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(254, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 14);
            this.label5.TabIndex = 22;
            this.label5.Text = "Capacity";
            // 
            // lbl_capacity
            // 
            this.lbl_capacity.AutoSize = true;
            this.lbl_capacity.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_capacity.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_capacity.Location = new System.Drawing.Point(253, 22);
            this.lbl_capacity.Name = "lbl_capacity";
            this.lbl_capacity.Size = new System.Drawing.Size(85, 23);
            this.lbl_capacity.TabIndex = 21;
            this.lbl_capacity.Text = "...............";
            // 
            // lbl_innerdia
            // 
            this.lbl_innerdia.AutoSize = true;
            this.lbl_innerdia.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_innerdia.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_innerdia.Location = new System.Drawing.Point(80, 22);
            this.lbl_innerdia.Name = "lbl_innerdia";
            this.lbl_innerdia.Size = new System.Drawing.Size(85, 23);
            this.lbl_innerdia.TabIndex = 17;
            this.lbl_innerdia.Text = "...............";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 14);
            this.label2.TabIndex = 20;
            this.label2.Text = "Length";
            // 
            // lbl_len
            // 
            this.lbl_len.AutoSize = true;
            this.lbl_len.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_len.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_len.Location = new System.Drawing.Point(171, 22);
            this.lbl_len.Name = "lbl_len";
            this.lbl_len.Size = new System.Drawing.Size(85, 23);
            this.lbl_len.TabIndex = 19;
            this.lbl_len.Text = "...............";
            // 
            // lst_nos
            // 
            this.lst_nos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lst_nos.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_nos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lst_nos.LargeImageList = this.imageList3;
            this.lst_nos.Location = new System.Drawing.Point(399, 62);
            this.lst_nos.Name = "lst_nos";
            this.lst_nos.Size = new System.Drawing.Size(152, 366);
            this.lst_nos.SmallImageList = this.imageList3;
            this.lst_nos.TabIndex = 0;
            this.lst_nos.UseCompatibleStateImageBehavior = false;
            // 
            // imageList3
            // 
            this.imageList3.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList3.ImageStream")));
            this.imageList3.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList3.Images.SetKeyName(0, "icons8-gas-pump-96.png");
            // 
            // lst_nozzels
            // 
            this.lst_nozzels.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lst_nozzels.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_nozzels.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lst_nozzels.LargeImageList = this.imageList2;
            this.lst_nozzels.Location = new System.Drawing.Point(5, 62);
            this.lst_nozzels.Name = "lst_nozzels";
            this.lst_nozzels.Size = new System.Drawing.Size(388, 366);
            this.lst_nozzels.SmallImageList = this.imageList2;
            this.lst_nozzels.TabIndex = 0;
            this.lst_nozzels.UseCompatibleStateImageBehavior = false;
            this.lst_nozzels.SelectedIndexChanged += new System.EventHandler(this.lst_nozzels_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dgmain);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(576, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(323, 332);
            this.panel1.TabIndex = 111;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Indigo;
            this.label6.Location = new System.Drawing.Point(184, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 36);
            this.label6.TabIndex = 26;
            this.label6.Text = "...............";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 18);
            this.label3.TabIndex = 25;
            this.label3.Text = "Total Quntity";
            // 
            // dgmain
            // 
            this.dgmain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgmain.Location = new System.Drawing.Point(9, 31);
            this.dgmain.Name = "dgmain";
            this.dgmain.Size = new System.Drawing.Size(309, 252);
            this.dgmain.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Purple;
            this.label8.Location = new System.Drawing.Point(5, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(181, 23);
            this.label8.TabIndex = 2;
            this.label8.Text = "Enter Totalizer Values";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.lbl_stock);
            this.panel2.Location = new System.Drawing.Point(576, 388);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(323, 98);
            this.panel2.TabIndex = 112;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 18);
            this.label7.TabIndex = 24;
            this.label7.Text = "Current Stock";
            // 
            // lbl_stock
            // 
            this.lbl_stock.AutoSize = true;
            this.lbl_stock.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stock.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_stock.Location = new System.Drawing.Point(140, 4);
            this.lbl_stock.Name = "lbl_stock";
            this.lbl_stock.Size = new System.Drawing.Size(135, 36);
            this.lbl_stock.TabIndex = 23;
            this.lbl_stock.Text = "...............";
            // 
            // frm_TankStockLive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 535);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.pnl_footer);
            this.Controls.Add(this.pnl_header);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frm_TankStockLive";
            this.Text = "frm_TankStockLive";
            this.Load += new System.EventHandler(this.frm_TankStockLive_Load);
            this.pnl_header.ResumeLayout(false);
            this.pnl_header.PerformLayout();
            this.pnl_footer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgmain)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_header;
        private System.Windows.Forms.Label lbl_headerpaneltext;
        private System.Windows.Forms.Panel pnl_footer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ListView lst_nozzels;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListView lst_nos;
        private System.Windows.Forms.ImageList imageList3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_innerdia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_stock;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_capacity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_len;
        private System.Windows.Forms.DataGridView dgmain;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
    }
}