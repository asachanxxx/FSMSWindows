namespace FSMS.UI.Process
{
    partial class ReportViwer
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
            this.RepViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // RepViewer
            // 
            this.RepViewer.ActiveViewIndex = -1;
            this.RepViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RepViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.RepViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RepViewer.Location = new System.Drawing.Point(0, 0);
            this.RepViewer.Name = "RepViewer";
            this.RepViewer.Size = new System.Drawing.Size(1228, 543);
            this.RepViewer.TabIndex = 0;
            // 
            // ReportViwer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 543);
            this.Controls.Add(this.RepViewer);
            this.Name = "ReportViwer";
            this.Text = "ReportViwer";
            this.Load += new System.EventHandler(this.ReportViwer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer RepViewer;
    }
}