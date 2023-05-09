using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNPM_DoAn_Nhom2
{
    public partial class RankForm : Form
    {
        QLBDDataContext db = new QLBDDataContext();
        public RankForm()
        {
            InitializeComponent();
        }
        private void LoadForm()
        {
            dgvRank.DataSource = db.tbl_XepHangs.ToList().Select(p => new { p.ID, TenDoi = p.tbl_Doi_Bong.Ten_Doi_Bong, p.Thang, p.Hoa, p.Thua, p.XepHang,p.DiemSo }).OrderByDescending(p=>p.DiemSo).ToList();
            for (int i = 0; i < db.tbl_XepHangs.Count(); i++)
            {
                dgvRank.Rows[i].Cells["stt"].Value = i + 1;
                dgvRank.Rows[i].Cells["Hang"].Value = i + 1;
            }
        }

        private void RankForm_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void txtSearchRank_TextChanged(object sender, EventArgs e)
        {
            if(txtSearchRank.Text.Length > 0)
            {
                dgvRank.DataSource = db.tbl_XepHangs.ToList().Select(p => new { p.ID, TenDoi = p.tbl_Doi_Bong.Ten_Doi_Bong, p.Thang, p.Hoa, p.Thua, p.XepHang, p.DiemSo }).Where(p=>p.TenDoi.Contains(txtSearchRank.Text)).OrderByDescending(p => p.DiemSo).ToList();
                for (int i = 0; i < dgvRank.RowCount; i++)
                {
                    dgvRank.Rows[i].Cells["stt"].Value = i + 1;
                    dgvRank.Rows[i].Cells["Hang"].Value = i + 1;
                }
            }
            else
            {
                dgvRank.DataSource = db.tbl_XepHangs.ToList().Select(p => new { p.ID, TenDoi = p.tbl_Doi_Bong.Ten_Doi_Bong, p.Thang, p.Hoa, p.Thua, p.XepHang, p.DiemSo }).OrderByDescending(p => p.DiemSo).ToList();
                for (int i = 0; i < db.tbl_XepHangs.Count(); i++)
                {
                    dgvRank.Rows[i].Cells["stt"].Value = i + 1;
                    dgvRank.Rows[i].Cells["Hang"].Value = i + 1;
                }
            }

           
        }

        private void cbbXep_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(cbbXep.Text) ||  cbbXep.Text =="Điểm số")
            {
                dgvRank.DataSource = db.tbl_XepHangs.ToList().Select(p => new { p.ID, TenDoi = p.tbl_Doi_Bong.Ten_Doi_Bong, p.Thang, p.Hoa, p.Thua, p.XepHang, p.DiemSo }).OrderByDescending(p => p.DiemSo).ToList();
                for (int i = 0; i < db.tbl_XepHangs.Count(); i++)
                {
                    dgvRank.Rows[i].Cells["stt"].Value = i + 1;
                    dgvRank.Rows[i].Cells["Hang"].Value = i + 1;
                }
            }    
            else if(cbbXep.Text == "Bàn thắng")
            {
                dgvRank.DataSource = db.tbl_XepHangs.ToList().Select(p => new { p.ID, TenDoi = p.tbl_Doi_Bong.Ten_Doi_Bong, p.Thang, p.Hoa, p.Thua, p.XepHang, p.DiemSo }).OrderByDescending(p => p.Thang).ToList();
                for (int i = 0; i < db.tbl_XepHangs.Count(); i++)
                {
                    dgvRank.Rows[i].Cells["stt"].Value = i + 1;
                    dgvRank.Rows[i].Cells["Hang"].Value = i + 1;
                }
            }    
        }

        private void dgvRank_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0 && e.ColumnIndex== dgvRank.Columns["btnDeleteRow"].Index)
            {
                if(MessageBox.Show("Bạn có chắc xóa xếp hạng của đội này không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    int IDRank = int.Parse(dgvRank["ID",e.RowIndex].Value.ToString());
                    tbl_XepHang tbl = db.tbl_XepHangs.SingleOrDefault(p => p.ID == IDRank);
                    if(tbl != null) { 
                        db.tbl_XepHangs.DeleteOnSubmit(tbl);
                        db.SubmitChanges();
                        MessageBox.Show("Xóa thành công đội này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadForm();
                    }
                }    
            }    
        }

        private void ptcReport_Click(object sender, EventArgs e)
        {
            ReportForm frm = new ReportForm();
            frm.ShowDialog();
        
        }
    }
}
