namespace CNPM_DoAn_Nhom2
{
    partial class RankForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RankForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtSearchRank = new System.Windows.Forms.TextBox();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.ptcReport = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.dgvRank = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Doi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XepHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDeleteRow = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbXep = new Guna.UI2.WinForms.Guna2ComboBox();
            this.pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptcReport)).BeginInit();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRank)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearchRank
            // 
            this.txtSearchRank.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchRank.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchRank.ForeColor = System.Drawing.Color.Black;
            this.txtSearchRank.Location = new System.Drawing.Point(155, 18);
            this.txtSearchRank.Name = "txtSearchRank";
            this.txtSearchRank.Size = new System.Drawing.Size(406, 30);
            this.txtSearchRank.TabIndex = 8;
            this.txtSearchRank.TextChanged += new System.EventHandler(this.txtSearchRank_TextChanged);
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlBottom.Controls.Add(this.ptcReport);
            this.pnlBottom.Controls.Add(this.txtSearchRank);
            this.pnlBottom.Controls.Add(this.label2);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 518);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1203, 69);
            this.pnlBottom.TabIndex = 1;
            // 
            // ptcReport
            // 
            this.ptcReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptcReport.Image = ((System.Drawing.Image)(resources.GetObject("ptcReport.Image")));
            this.ptcReport.Location = new System.Drawing.Point(1130, 9);
            this.ptcReport.Name = "ptcReport";
            this.ptcReport.Size = new System.Drawing.Size(53, 50);
            this.ptcReport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptcReport.TabIndex = 9;
            this.ptcReport.TabStop = false;
            this.ptcReport.Click += new System.EventHandler(this.ptcReport_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tìm kiếm";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.dgvRank);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 69);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1203, 518);
            this.pnlMain.TabIndex = 2;
            // 
            // dgvRank
            // 
            this.dgvRank.BackgroundColor = System.Drawing.Color.White;
            this.dgvRank.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRank.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRank.ColumnHeadersHeight = 35;
            this.dgvRank.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.ID,
            this.Doi,
            this.Thang,
            this.Hoa,
            this.Thua,
            this.DiemSo,
            this.Hang,
            this.XepHang,
            this.btnDeleteRow});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRank.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRank.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRank.EnableHeadersVisualStyles = false;
            this.dgvRank.GridColor = System.Drawing.Color.Silver;
            this.dgvRank.Location = new System.Drawing.Point(0, 0);
            this.dgvRank.MultiSelect = false;
            this.dgvRank.Name = "dgvRank";
            this.dgvRank.RowHeadersWidth = 51;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvRank.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRank.RowTemplate.Height = 24;
            this.dgvRank.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRank.Size = new System.Drawing.Size(1203, 518);
            this.dgvRank.TabIndex = 1;
            this.dgvRank.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRank_CellClick);
            // 
            // stt
            // 
            this.stt.DataPropertyName = "index";
            this.stt.HeaderText = "STT";
            this.stt.MinimumWidth = 6;
            this.stt.Name = "stt";
            this.stt.Width = 50;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Visible = false;
            this.ID.Width = 125;
            // 
            // Doi
            // 
            this.Doi.DataPropertyName = "TenDoi";
            this.Doi.HeaderText = "Đội";
            this.Doi.MinimumWidth = 6;
            this.Doi.Name = "Doi";
            this.Doi.Width = 125;
            // 
            // Thang
            // 
            this.Thang.DataPropertyName = "Thang";
            this.Thang.HeaderText = "Thắng";
            this.Thang.MinimumWidth = 6;
            this.Thang.Name = "Thang";
            this.Thang.Width = 125;
            // 
            // Hoa
            // 
            this.Hoa.DataPropertyName = "Hoa";
            this.Hoa.HeaderText = "Hòa";
            this.Hoa.MinimumWidth = 6;
            this.Hoa.Name = "Hoa";
            this.Hoa.Width = 125;
            // 
            // Thua
            // 
            this.Thua.DataPropertyName = "Thua";
            this.Thua.HeaderText = "Thua";
            this.Thua.MinimumWidth = 6;
            this.Thua.Name = "Thua";
            this.Thua.Width = 125;
            // 
            // DiemSo
            // 
            this.DiemSo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DiemSo.DataPropertyName = "DiemSo";
            this.DiemSo.HeaderText = "Điểm Số";
            this.DiemSo.MinimumWidth = 6;
            this.DiemSo.Name = "DiemSo";
            // 
            // Hang
            // 
            this.Hang.HeaderText = "Hạng";
            this.Hang.MinimumWidth = 6;
            this.Hang.Name = "Hang";
            this.Hang.Width = 125;
            // 
            // XepHang
            // 
            this.XepHang.DataPropertyName = "XepHang";
            this.XepHang.HeaderText = "XepHang";
            this.XepHang.MinimumWidth = 6;
            this.XepHang.Name = "XepHang";
            this.XepHang.Visible = false;
            this.XepHang.Width = 125;
            // 
            // btnDeleteRow
            // 
            this.btnDeleteRow.HeaderText = "";
            this.btnDeleteRow.MinimumWidth = 6;
            this.btnDeleteRow.Name = "btnDeleteRow";
            this.btnDeleteRow.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnDeleteRow.Text = "Xóa ";
            this.btnDeleteRow.UseColumnTextForButtonValue = true;
            this.btnDeleteRow.Width = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(22, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "XẾP HẠNG";
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.White;
            this.pnlTop.Controls.Add(this.label3);
            this.pnlTop.Controls.Add(this.cbbXep);
            this.pnlTop.Controls.Add(this.label1);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1203, 69);
            this.pnlTop.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(732, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Xếp theo";
            // 
            // cbbXep
            // 
            this.cbbXep.BackColor = System.Drawing.Color.Transparent;
            this.cbbXep.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbXep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbXep.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbXep.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbXep.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbXep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbXep.ItemHeight = 30;
            this.cbbXep.Items.AddRange(new object[] {
            "Điểm số",
            "Bàn thắng"});
            this.cbbXep.Location = new System.Drawing.Point(876, 16);
            this.cbbXep.Name = "cbbXep";
            this.cbbXep.Size = new System.Drawing.Size(229, 36);
            this.cbbXep.TabIndex = 1;
            this.cbbXep.SelectedIndexChanged += new System.EventHandler(this.cbbXep_SelectedIndexChanged);
            // 
            // RankForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 587);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RankForm";
            this.Text = "RankForm";
            this.Load += new System.EventHandler(this.RankForm_Load);
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptcReport)).EndInit();
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRank)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearchRank;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.PictureBox ptcReport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.DataGridView dgvRank;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox cbbXep;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Doi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thua;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hang;
        private System.Windows.Forms.DataGridViewTextBoxColumn XepHang;
        private System.Windows.Forms.DataGridViewButtonColumn btnDeleteRow;
    }
}