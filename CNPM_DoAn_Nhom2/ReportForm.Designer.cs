namespace CNPM_DoAn_Nhom2
{
    partial class ReportForm
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
            this.ReportRank = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // ReportRank
            // 
            this.ReportRank.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReportRank.LocalReport.ReportEmbeddedResource = "CNPM_DoAn_Nhom2.BangXepHang.rdlc";
            this.ReportRank.Location = new System.Drawing.Point(0, 0);
            this.ReportRank.Name = "ReportRank";
            this.ReportRank.ServerReport.BearerToken = null;
            this.ReportRank.Size = new System.Drawing.Size(1022, 733);
            this.ReportRank.TabIndex = 0;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 733);
            this.Controls.Add(this.ReportRank);
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer ReportRank;
    }
}