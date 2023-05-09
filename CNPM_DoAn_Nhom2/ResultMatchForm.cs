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
    public partial class ResultMatchForm : Form
    {
        QLBDDataContext db = new QLBDDataContext();
        tbl_Lichthidau tbl_Lichthidau=null;
        public ResultMatchForm(tbl_Lichthidau tbl=null)
        {
            InitializeComponent();
            tbl_Lichthidau=tbl;
        }

        private void ResultMatchForm_Load(object sender, EventArgs e)
        {
            LoadForm();
        }
        void LoadForm()
        {
            if (tbl_Lichthidau != null)
            {
                int BTDoi1 = db.tbl_KetQuas.Where(p=>p.IDLichThiDau==tbl_Lichthidau.ID).Count(p => p.IDDoi == tbl_Lichthidau.Doi1);
                int BTDoi2 = db.tbl_KetQuas.Where(p => p.IDLichThiDau == tbl_Lichthidau.ID).Count(p => p.IDDoi == tbl_Lichthidau.Doi2);
                lblDoi1.Text = tbl_Lichthidau.tbl_Doi_Bong.Ten_Doi_Bong;
                lblDoi2.Text = tbl_Lichthidau.tbl_Doi_Bong1.Ten_Doi_Bong;
                lblSan.Text = tbl_Lichthidau.TenSan;
                lbltyso.Text = BTDoi1.ToString()+" - "+BTDoi2.ToString();
                lblNgay.Text = tbl_Lichthidau.NgayGio.ToString();

            }
            dgvMatch.DataSource = db.tbl_KetQuas.ToList().Where(p => p.IDLichThiDau == tbl_Lichthidau.ID).Select((p,i) => new {index=i+1, p.ID, p.Thoidiem, p.TenCauThu, p.LoaiBanThang, DoiBong = p.IDDoi }).ToList();
        }

        private void ptcAdd_Click(object sender, EventArgs e)
        {

            AddResultForm frm = new AddResultForm(tbl_Lichthidau);
            frm.btnSua.Enabled = false;
            frm.btnXoa.Enabled = false;
            frm.btnThem.Enabled = true;
            frm.ShowDialog();
            LoadForm();
        }

        private void dgvMatch_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                tbl_KetQua tbl = db.tbl_KetQuas.SingleOrDefault(p => p.ID == int.Parse(dgvMatch["ID", e.RowIndex].Value.ToString()));

                AddResultForm frm = new AddResultForm(tbl_Lichthidau,tbl);
                frm.btnSua.Enabled = true;
                frm.btnXoa.Enabled = true;
                frm.btnThem.Enabled = false;
                frm.ShowDialog();
                LoadForm();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
           /* dgvMatch.DataSource = db.tbl_KetQuas.ToList().Where(p => p.IDLichThiDau == tbl_Lichthidau.ID||p.TenCauThu.Contains(txtSearch.Text)).Select((p, i) => new { index = i + 1, p.ID, p.Thoidiem, p.TenCauThu, p.LoaiBanThang, DoiBong = p.IDDoi }).ToList();*/
        }

        private void ptcSave_Click(object sender, EventArgs e)
        {

            tbl_QuiDinh tblQD = db.tbl_QuiDinhs.SingleOrDefault(P=>P.ID==1);

            int BTDoi1 = db.tbl_KetQuas.Where(p => p.IDLichThiDau == tbl_Lichthidau.ID).Count(p => p.IDDoi == tbl_Lichthidau.Doi1);
            int BTDoi2 = db.tbl_KetQuas.Where(p => p.IDLichThiDau == tbl_Lichthidau.ID).Count(p => p.IDDoi == tbl_Lichthidau.Doi2);

            int IDDoi1 = int.Parse(tbl_Lichthidau.Doi1.ToString());
            int IDDoi2 = int.Parse(tbl_Lichthidau.Doi2.ToString());

            if (BTDoi1 > BTDoi2) //Doi 1 thang
            {
                tbl_XepHang Doi1 = db.tbl_XepHangs.SingleOrDefault(p => p.Doi == IDDoi1);
                tbl_XepHang Doi2 = db.tbl_XepHangs.SingleOrDefault(p => p.Doi == IDDoi2);
                if (Doi1 !=null) //Đã tồn tại trong xếp hạng
                {
                    Doi1.Thang = Doi1.Thang+1;
                    Doi1.DiemSo = tblQD.DiemThang * Doi1.Thang + tblQD.DiemHoa * Doi1.Hoa + tblQD.DiemThu * Doi1.Hoa;
                    db.SubmitChanges();
                }
                else //Chưa có trong bảng xếp hạng
                {
                    tbl_XepHang tmp = new tbl_XepHang();
                    tmp.Doi = IDDoi1;
                    tmp.Thang = 1;
                    tmp.Hoa = 0;
                    tmp.Thua = 0;
                    tmp.DiemSo = tblQD.DiemThang * tmp.Thang + tblQD.DiemHoa * tmp.Hoa + tblQD.DiemThu*tmp.Hoa;
                    tmp.IDLichThiDau = tbl_Lichthidau.ID;
                    db.tbl_XepHangs.InsertOnSubmit(tmp);
                    db.SubmitChanges();
                }


                if (Doi2 != null) //Đã tồn tại trong xếp hạng
                {
                    Doi2.Thua = Doi2.Thua + 1;
                    Doi2.DiemSo = tblQD.DiemThang * Doi2.Thang + tblQD.DiemHoa * Doi2.Hoa + tblQD.DiemThu * Doi2.Hoa;
                    db.SubmitChanges();
                }
                else //Chưa có trong bảng xếp hạng
                {
                    tbl_XepHang tmp = new tbl_XepHang();
                    tmp.Doi = IDDoi2;
                    tmp.Thang = 0;
                    tmp.Hoa = 0;
                    tmp.Thua = 1;
                    tmp.DiemSo = tblQD.DiemThang * tmp.Thang + tblQD.DiemHoa * tmp.Hoa + tblQD.DiemThu * tmp.Hoa;
                    tmp.IDLichThiDau = tbl_Lichthidau.ID;
                    db.tbl_XepHangs.InsertOnSubmit(tmp);
                    db.SubmitChanges();
                }

            }   
            else if(BTDoi1 == BTDoi2) //2 Doi Hoa
            {
                tbl_XepHang Doi1 = db.tbl_XepHangs.SingleOrDefault(p => p.Doi == IDDoi1);
                tbl_XepHang Doi2 = db.tbl_XepHangs.SingleOrDefault(p => p.Doi == IDDoi2);
                if (Doi1 != null) //Đã tồn tại trong xếp hạng
                {
                    Doi1.Hoa = Doi1.Hoa + 1;
                    Doi1.DiemSo = tblQD.DiemThang * Doi1.Thang + tblQD.DiemHoa * Doi1.Hoa + tblQD.DiemThu * Doi1.Hoa;
                    db.SubmitChanges();
                }
                else //Chưa có trong bảng xếp hạng
                {
                    tbl_XepHang tmp = new tbl_XepHang();
                    tmp.Doi = IDDoi1;
                    tmp.Thang = 0;
                    tmp.Hoa = 1;
                    tmp.Thua = 0;
                    tmp.DiemSo = tblQD.DiemThang * tmp.Thang + tblQD.DiemHoa * tmp.Hoa + tblQD.DiemThu * tmp.Hoa;
                    tmp.IDLichThiDau = tbl_Lichthidau.ID;
                    db.tbl_XepHangs.InsertOnSubmit(tmp);
                    db.SubmitChanges();
                }


                if (Doi2 != null) //Đã tồn tại trong xếp hạng
                {
                    Doi2.Hoa = Doi2.Hoa + 1;
                    Doi2.DiemSo = tblQD.DiemThang * Doi2.Thang + tblQD.DiemHoa * Doi2.Hoa + tblQD.DiemThu * Doi2.Hoa;
                    db.SubmitChanges();
                }
                else //Chưa có trong bảng xếp hạng
                {
                    tbl_XepHang tmp = new tbl_XepHang();
                    tmp.Doi = IDDoi2;
                    tmp.Thang = 0;
                    tmp.Hoa = 1;
                    tmp.Thua = 0;
                    tmp.DiemSo = tblQD.DiemThang * tmp.Thang + tblQD.DiemHoa * tmp.Hoa + tblQD.DiemThu * tmp.Hoa;
                    tmp.IDLichThiDau = tbl_Lichthidau.ID;
                    db.tbl_XepHangs.InsertOnSubmit(tmp);
                    db.SubmitChanges();
                }
            }    
            else if(BTDoi1 < BTDoi2) //Doi 2 thang
            {
                tbl_XepHang Doi1 = db.tbl_XepHangs.SingleOrDefault(p => p.Doi == IDDoi1);
                tbl_XepHang Doi2 = db.tbl_XepHangs.SingleOrDefault(p => p.Doi == IDDoi2);
                if (Doi1 != null) //Đã tồn tại trong xếp hạng
                {
                    Doi1.Thua = Doi1.Thua + 1;
                    Doi1.DiemSo = tblQD.DiemThang * Doi1.Thang + tblQD.DiemHoa * Doi1.Hoa + tblQD.DiemThu * Doi1.Hoa;
                    db.SubmitChanges();
                }
                else //Chưa có trong bảng xếp hạng
                {
                    tbl_XepHang tmp = new tbl_XepHang();
                    tmp.Doi = IDDoi1;
                    tmp.Thang = 0;
                    tmp.Hoa = 0;
                    tmp.Thua = 1;
                    tmp.DiemSo = tblQD.DiemThang * tmp.Thang + tblQD.DiemHoa * tmp.Hoa + tblQD.DiemThu * tmp.Hoa;
                    tmp.IDLichThiDau = tbl_Lichthidau.ID;
                    db.tbl_XepHangs.InsertOnSubmit(tmp);
                    db.SubmitChanges();
                }


                if (Doi2 != null) //Đã tồn tại trong xếp hạng
                {
                    Doi2.Thang = Doi2.Thang + 1;
                    Doi2.DiemSo = tblQD.DiemThang * Doi2.Thang + tblQD.DiemHoa * Doi2.Hoa + tblQD.DiemThu * Doi2.Hoa;
                    db.SubmitChanges();
                }
                else //Chưa có trong bảng xếp hạng
                {
                    tbl_XepHang tmp = new tbl_XepHang();
                    tmp.Doi = IDDoi2;
                    tmp.Thang = 1;
                    tmp.Hoa = 0;
                    tmp.Thua = 0;
                    tmp.DiemSo = tblQD.DiemThang * tmp.Thang + tblQD.DiemHoa * tmp.Hoa + tblQD.DiemThu * tmp.Hoa;
                    tmp.IDLichThiDau = tbl_Lichthidau.ID;
                    db.tbl_XepHangs.InsertOnSubmit(tmp);
                    db.SubmitChanges();
                }
            }  
            MessageBox.Show("Lưu kết quả thành công","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
