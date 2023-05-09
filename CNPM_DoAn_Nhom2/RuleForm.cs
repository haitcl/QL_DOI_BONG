using System;
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
    public partial class RuleForm : Form
    {
        QLBDDataContext db = new QLBDDataContext();
        public RuleForm()
        {
            InitializeComponent();
        }

        private void RuleForm_Load(object sender, EventArgs e)
        {
            LoadForm();
        }
        private void LoadForm()
        {
            tbl_QuiDinh tbl = db.tbl_QuiDinhs.SingleOrDefault(p=>p.ID==1);
            nupThang.Value = tbl.DiemThang.Value;
            nupThua.Value = tbl.DiemThu.Value;
            nupHoa.Value = tbl.DiemHoa.Value;

            nupNuocNgoai.Value = tbl.SoLuongCauThuNuocNgoai.Value;
            nupSoLuongCauthu.Value= tbl.SoLuongCauThu.Value; 
            
            nupTuoitoithieu.Value = tbl.SoTuoiToiThieu.Value;
            nupTuoitoida.Value = tbl.SoTuoiLonNhat.Value;

            nupTgghiban.Value = tbl.ThoiGianGhiBanToiDa.Value;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            tbl_QuiDinh tbl = db.tbl_QuiDinhs.SingleOrDefault(p => p.ID == 1);
            if (nupThang.Value > nupHoa.Value && nupHoa.Value> nupThua.Value)
            {
                tbl.DiemThang = int.Parse(nupThang.Value.ToString());
                tbl.DiemHoa = int.Parse(nupHoa.Value.ToString());
                tbl.DiemThu = int.Parse(nupThua.Value.ToString());

                tbl.SoLuongCauThuNuocNgoai = int.Parse(nupNuocNgoai.Value.ToString());
                tbl.SoLuongCauThu = int.Parse(nupSoLuongCauthu.Value.ToString());

                tbl.SoTuoiToiThieu = int.Parse(nupTuoitoithieu.Value.ToString());
                tbl.SoTuoiLonNhat = int.Parse(nupTuoitoida.Value.ToString());

                tbl.ThoiGianGhiBanToiDa = int.Parse(nupTgghiban.Value.ToString());
                db.SubmitChanges();
                MessageBox.Show("Thay đổi quy định thành công","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }    
            else
            {
                MessageBox.Show("Điểm thắng thua hòa không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }
    }
}
