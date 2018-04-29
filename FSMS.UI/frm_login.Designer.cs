namespace FSMS.UI
{
    partial class frm_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lbl_message = new System.Windows.Forms.Label();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.errorx = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.mainpanel.SuspendLayout();
            this.errorx.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(166)))), ((int)(((byte)(242)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 50);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FSMS.UI.Properties.Resources.Change_Password;
            this.pictureBox1.InitialImage = global::FSMS.UI.Properties.Resources.Change_Password;
            this.pictureBox1.Location = new System.Drawing.Point(5, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(299, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "V 1.0.1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(54, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "LOG IN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(56, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "FUEL STATION MANAGEMENT SYSTEM";
            // 
            // txt_username
            // 
            this.txt_username.BackColor = System.Drawing.Color.White;
            this.txt_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_username.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(83)))), ((int)(((byte)(125)))));
            this.txt_username.Location = new System.Drawing.Point(19, 25);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(271, 23);
            this.txt_username.TabIndex = 1;
            // 
            // txt_pass
            // 
            this.txt_pass.BackColor = System.Drawing.Color.White;
            this.txt_pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_pass.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(83)))), ((int)(((byte)(125)))));
            this.txt_pass.Location = new System.Drawing.Point(19, 71);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(271, 23);
            this.txt_pass.TabIndex = 2;
            this.txt_pass.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(199, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 38);
            this.button1.TabIndex = 3;
            this.button1.Text = "Log In";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 14);
            this.label4.TabIndex = 4;
            this.label4.Text = "User Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 14);
            this.label5.TabIndex = 5;
            this.label5.Text = "Password";
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 229);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(374, 12);
            this.progressBar1.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // lbl_message
            // 
            this.lbl_message.AutoSize = true;
            this.lbl_message.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_message.Location = new System.Drawing.Point(2, 213);
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(57, 13);
            this.lbl_message.TabIndex = 7;
            this.lbl_message.Text = "User Name";
            // 
            // mainpanel
            // 
            this.mainpanel.Controls.Add(this.txt_username);
            this.mainpanel.Controls.Add(this.txt_pass);
            this.mainpanel.Controls.Add(this.button1);
            this.mainpanel.Controls.Add(this.label5);
            this.mainpanel.Controls.Add(this.label4);
            this.mainpanel.Location = new System.Drawing.Point(23, 56);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(315, 148);
            this.mainpanel.TabIndex = 8;
            // 
            // errorx
            // 
            this.errorx.BackColor = System.Drawing.Color.Red;
            this.errorx.Controls.Add(this.button2);
            this.errorx.Controls.Add(this.panel4);
            this.errorx.Location = new System.Drawing.Point(78, 62);
            this.errorx.Name = "errorx";
            this.errorx.Size = new System.Drawing.Size(213, 117);
            this.errorx.TabIndex = 9;
            this.errorx.Visible = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(58, 75);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 38);
            this.button2.TabIndex = 4;
            this.button2.Text = "Reconnect";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.label6);
            this.panel4.Location = new System.Drawing.Point(24, 15);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(162, 56);
            this.panel4.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(29, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 29);
            this.label6.TabIndex = 0;
            this.label6.Text = "ERROR !!!";
            // 
            // frm_login
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(374, 241);
            this.Controls.Add(this.errorx);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.lbl_message);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "System Login";
            this.Load += new System.EventHandler(this.frm_login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.mainpanel.ResumeLayout(false);
            this.mainpanel.PerformLayout();
            this.errorx.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lbl_message;
        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.Panel errorx;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
    }
}