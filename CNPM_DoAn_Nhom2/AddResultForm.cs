using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNPM_DoAn_Nhom2
{
    public partial class AddResultForm : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        QLBDDataContext db = new QLBDDataContext();
        tbl_Lichthidau tbl_thidau = null;
        tbl_KetQua tbl_KetQua = null;
        public AddResultForm(tbl_Lichthidau tbl=null,tbl_KetQua tblkq=null)
        {
            tbl_thidau = tbl;
            tbl_KetQua = tblkq;
            InitializeComponent();
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbbDoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbDoi.SelectedValue != null)
            {
                cbbTenCauthu.DataSource = db.tbl_Cauthus.Where(p => p.Doi == int.Parse(cbbDoi.SelectedValue.ToString()));
                cbbTenCauthu.DisplayMember = "TenCauthu";
                //cbbTenCauthu.ValueMember = "ID";
            }

        }
        void LoadForm()
        {
            if(tbl_KetQua==null)
            {
                cbbDoi.DataSource = db.tbl_Doi_Bongs.Where(p => p.ID == tbl_thidau.Doi1 || p.ID == tbl_thidau.Doi2);
                cbbDoi.ValueMember = "ID";
                cbbDoi.DisplayMember = "Ten_Doi_Bong";

                cbbTenCauthu.DataSource = db.tbl_Cauthus.Where(p => p.Doi == int.Parse(cbbDoi.SelectedValue.ToString()));
                cbbTenCauthu.DisplayMember = "TenCauthu";
                cbbTenCauthu.ValueMember = "ID";
            }    
            else
            {
                cbbDoi.DataSource = db.tbl_Doi_Bongs.Where(p => p.ID == tbl_thidau.Doi1 || p.ID == tbl_thidau.Doi2);
                cbbDoi.ValueMember = "ID";
                cbbDoi.DisplayMember = "Ten_Doi_Bong";

                cbbTenCauthu.DataSource = db.tbl_Cauthus.Where(p => p.Doi == int.Parse(cbbDoi.SelectedValue.ToString()));
                cbbTenCauthu.DisplayMember = "TenCauthu";
                cbbTenCauthu.ValueMember = "ID";


                tbl_Doi_Bong tmp = db.tbl_Doi_Bongs.SingleOrDefault(p => p.ID == int.Parse(tbl_KetQua.IDDoi.ToString()));
                cbbDoi.Text = tmp.Ten_Doi_Bong;
                cbbDoi.SelectedValue = tmp.ID;
                cbbTenCauthu.Text = tbl_KetQua.TenCauThu;
                cbbLoaiBanThang.Text = tbl_KetQua.LoaiBanThang;
                txtThoiDiem.Text = tbl_KetQua.Thoidiem;
            }    
            
        }

        private void AddResultForm_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            
            if(string.IsNullOrEmpty(cbbDoi.Text)||string.IsNullOrEmpty(cbbTenCauthu.Text)||string.IsNullOrEmpty(cbbLoaiBanThang.Text)||string.IsNullOrEmpty(txtThoiDiem.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }    
            else
            {
                tbl_KetQua tbl = new tbl_KetQua();
                tbl.TenCauThu = cbbTenCauthu.Text;
                tbl_Cauthu tbl_Cauthu = db.tbl_Cauthus.SingleOrDefault(p => p.TenCauthu.Contains(cbbTenCauthu.Text));
                tbl_Cauthu.TongSoBanThang = tbl_Cauthu.TongSoBanThang + 1;
                tbl.IDDoi = int.Parse(cbbDoi.SelectedValue.ToString());
                tbl.LoaiBanThang = cbbLoaiBanThang.Text;
                tbl.Thoidiem = txtThoiDiem.Text;
                tbl.IDLichThiDau = tbl_thidau.ID;
                db.tbl_KetQuas.InsertOnSubmit(tbl);
                db.SubmitChanges();
                MessageBox.Show("Thêm thành công cầu thủ ghi bàn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }    
        }

        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            tbl_KetQua tmp = db.tbl_KetQuas.SingleOrDefault(p => p.ID == tbl_KetQua.ID);
            if(tmp !=null)
            {
                db.tbl_KetQuas.DeleteOnSubmit(tmp);
                db.SubmitChanges();
                MessageBox.Show("Bạn đã xóa thành công kết quả này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }    
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            tbl_KetQua tmp = db.tbl_KetQuas.SingleOrDefault(p => p.ID == tbl_KetQua.ID);
            if(tmp!=null)
            {
                tmp.IDDoi = int.Parse(cbbDoi.SelectedValue.ToString());
                tmp.TenCauThu = cbbTenCauthu.Text;
                tmp.LoaiBanThang =cbbLoaiBanThang.Text;
                tmp.Thoidiem = txtThoiDiem.Text;
                db.SubmitChanges();
                MessageBox.Show("Bạn thay đổi thành công kết quả này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }    
        }
    }
}
