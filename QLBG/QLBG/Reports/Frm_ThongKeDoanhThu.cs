using System;
using System.ComponentModel.Design;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using QLBG.Data;
using DisplayMode = Microsoft.Reporting.WinForms.DisplayMode;

namespace QLBG.Reports
{
    public partial class Frm_ThongKeDoanhThu : Form
    {
        QLBGDbContext context = new QLBGDbContext();
        QLHDDataSet.DanhSachDoanhThuDataTable danhSachSanPhamDataTable = new QLHDDataSet.DanhSachDoanhThuDataTable();
        string reportsFolder = Application.StartupPath.Replace("bin\\Debug\\net8.0-windows", "Reports");

        public Frm_ThongKeDoanhThu()
        {
            InitializeComponent();
        }

        private void Frm_ThongKeHoaDon_Load(object sender, EventArgs e)
        {
            var danhSachSanPham = context.ChiTiet_HoaDon.Select(r => new DanhSachHoaDon_ChiTiet
            {
                ID = r.ID,
                HoaDonID = r.HoaDonID,
                GiayID = r.GiayID,
                TenGiay = r.Giay.TenGiay,                
                DonGiaBan = r.DonGiaBan,
                SoLuongBan = r.SoLuongBan
            }).ToList();

            danhSachSanPhamDataTable.Clear();
            foreach (var row in danhSachSanPham)
            {
                danhSachSanPhamDataTable.AddDanhSachDoanhThuRow(
                row.ID,
                row.HoaDonID,
                row.GiayID,
                row.TenGiay,
                row.SoLuongBan,
                row.DonGiaBan);
            }

            ReportDataSource reportDataSource = new ReportDataSource();
            reportDataSource.Name = "ThongKeDoanhThu";
            reportDataSource.Value = danhSachSanPhamDataTable;

            reportViewer.LocalReport.DataSources.Clear();
            reportViewer.LocalReport.DataSources.Add(reportDataSource);
            reportViewer.LocalReport.ReportPath = Path.Combine(reportsFolder, "rptThongKeDoanhThu.rdlc");

            reportViewer.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer.ZoomMode = ZoomMode.Percent;
            reportViewer.ZoomPercent = 100;

            reportViewer.RefreshReport();
        }
    }
}
