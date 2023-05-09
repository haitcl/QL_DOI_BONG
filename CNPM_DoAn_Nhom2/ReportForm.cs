using CNPM_DoAn_Nhom2.QL_DOI_BONGDataSetTableAdapters;
using Microsoft.Reporting.WinForms;
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
    public partial class ReportForm : Form
    {

        QLBDDataContext db = new QLBDDataContext();
        public ReportForm()
        {
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {

            ReportRank.LocalReport.ReportEmbeddedResource = "CNPM_DoAn_Nhom2.BangXepHang.rdlc";
            ReportDataSource dataSource = new ReportDataSource();
            dataSource.Name = "DataSet1";
            dataSource.Value = db.tbl_XepHangs.Select(p=> new {p.DiemSo,p.Thang,p.Thua,p.Hoa, p.Doi,p.XepHang });
            ReportRank.LocalReport.DataSources.Add(dataSource);
           

            this.ReportRank.RefreshReport();
        }
    }
}
