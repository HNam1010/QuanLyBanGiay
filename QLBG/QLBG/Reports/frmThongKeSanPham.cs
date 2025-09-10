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
    public partial class frmThongKeSanPham : Form
    {
        QLBGDbContext context = new QLBGDbContext();
        QLBGDataSet.DanhSachGiayDataTable danhSachSanPhamDataTable = new QLBGDataSet.DanhSachGiayDataTable();
        string reportsFolder = Application.StartupPath.Replace("bin\\Debug\\net8.0-windows", "Reports");

        public frmThongKeSanPham()
        {
            InitializeComponent();
        }

        private void frmThongKeSanPham_Load(object sender, EventArgs e)
        {
            var danhSachSanPham = context.Giay.Select(r => new DanhSachGiay
            {
                ID = r.ID,
                NhaCungCapID = r.NhaCungCapID,
                Ten_NhaCungCap = r.NhaCungCap.Ten_NhaCungCap,
                LoaiGiayID = r.LoaiGiayID,
                Ten_LoaiGiay = r.LoaiGiay.Ten_LoaiGiay,
                TenGiay = r.TenGiay,
                DonGia = r.DonGia,
                SoLuong = r.SoLuong,
                Size = r.Size
            }).ToList();

            danhSachSanPhamDataTable.Clear();
            foreach (var row in danhSachSanPham)
            {
                danhSachSanPhamDataTable.AddDanhSachGiayRow(
                row.ID,
                row.NhaCungCapID,
                row.Ten_NhaCungCap,
                row.LoaiGiayID,
                row.Ten_LoaiGiay,
                row.TenGiay,
                row.DonGia,
                row.SoLuong,
                row.Size);
            }

            ReportDataSource reportDataSource = new ReportDataSource();
            reportDataSource.Name = "DanhSachGiay";
            reportDataSource.Value = danhSachSanPhamDataTable;

            reportViewer.LocalReport.DataSources.Clear();
            reportViewer.LocalReport.DataSources.Add(reportDataSource);
            reportViewer.LocalReport.ReportPath = Path.Combine(reportsFolder, "rptThongKeSanPham.rdlc");

            reportViewer.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer.ZoomMode = ZoomMode.Percent;
            reportViewer.ZoomPercent = 100;

            reportViewer.RefreshReport();
        }  
    }
}
