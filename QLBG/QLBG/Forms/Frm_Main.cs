using QLBG.Data;
using QLBG.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QLBG.Forms
{
    public partial class Frm_Main : Form
    {
        QLBGDbContext context = new QLBGDbContext(); // Khởi tạo biến ngữ cảnh CSDL

        Frm_LoaiGiay loaiGiay = null;
        Frm_NhaCungCap nhaCungCap = null;
        Frm_Giay giay = null;
        Frm_KhachHang khachHang = null;
        Frm_NhanVien nhanVien = null;
        Frm_HoaDon hoaDon = null;
        Frm_DangNhap dangNhap = null;
        frmThongKeSanPham thongKeGiay = null;
        Frm_ThongKeDoanhThu thongKeDoanhThu = null;
        Frm_HuongDanSuDung hdsd = null;

        string hoVaTenNhanVien = ""; // Lấy tên người dùng hiển thị vào thanh Status

        public Frm_Main()
        {
            InitializeComponent();
        }
        private void Frm_Main_Load(object sender, EventArgs e)
        {
            ChuaDangNhap();
            DangNhap();
        }

        #region Chức Năng Quản Lý

        private void loạiSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loaiGiay == null || loaiGiay.IsDisposed)
            {
                loaiGiay = new Frm_LoaiGiay();
                loaiGiay.MdiParent = this;
                loaiGiay.Show();
            }
            else
                loaiGiay.Activate();
        }

        private void mnuNhaCungCap_Click(object sender, EventArgs e)
        {
            if (nhaCungCap == null || nhaCungCap.IsDisposed)
            {
                nhaCungCap = new Frm_NhaCungCap();
                nhaCungCap.MdiParent = this;
                nhaCungCap.Show();
            }
            else
                nhaCungCap.Activate();
        }

        private void mnuGiay_Click(object sender, EventArgs e)
        {
            if (giay == null || giay.IsDisposed)
            {
                giay = new Frm_Giay();
                giay.MdiParent = this;
                giay.Show();
            }
            else
                giay.Activate();
        }

        private void mnuKhachHang_Click(object sender, EventArgs e)
        {
            if (khachHang == null || khachHang.IsDisposed)
            {
                khachHang = new Frm_KhachHang();
                khachHang.MdiParent = this;
                khachHang.Show();
            }
            else
                khachHang.Activate();
        }

        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
            if (nhanVien == null || nhanVien.IsDisposed)
            {
                nhanVien = new Frm_NhanVien();
                nhanVien.MdiParent = this;
                nhanVien.Show();
            }
            else
                nhanVien.Activate();
        }

        private void mnuHoaDon_Click(object sender, EventArgs e)
        {
            if (hoaDon == null || hoaDon.IsDisposed)
            {
                hoaDon = new Frm_HoaDon();
                hoaDon.MdiParent = this;
                hoaDon.Show();
            }
            else
                hoaDon.Activate();
        }

        private void lblLienKet_Click(object sender, EventArgs e)
        {
            ProcessStartInfo info = new ProcessStartInfo();
            info.FileName = "explorer.exe";
            info.Arguments = "https://www.nike.com/";
            Process.Start(info);
        }
        #endregion

        #region Chức Năng Đăng Nhập

        public void ChuaDangNhap()
        {
            // Sáng đăng nhập
            mnuDangNhap.Enabled = true;

            // Mờ tất cả
            mnuDangXuat.Enabled = false;
            mnuLoaiGiay.Enabled = false;
            mnuNhaCungCap.Enabled = false;
            mnuGiay.Enabled = false;
            mnuKhachHang.Enabled = false;
            mnuNhanVien.Enabled = false;
            mnuHoaDon.Enabled = false;
            mnuThongKeSanPham.Enabled = false;
            mnuThongKeDoanhThu.Enabled = false;

            // Hiển thị thông tin trên thanh trạng thái
            lblTrangThai.Text = "Chưa đăng nhập.";
        }
        public void QuyenQuanLy()
        {
            // Mờ đăng nhập
            mnuDangNhap.Enabled = false;

            // Mờ các chức năng quản lý không được phép
            // Sáng đăng xuất và các chức năng quản lý được phép
            mnuDangXuat.Enabled = true;
            mnuLoaiGiay.Enabled = true;
            mnuNhaCungCap.Enabled = true;
            mnuGiay.Enabled = true;
            mnuKhachHang.Enabled = true;
            mnuNhanVien.Enabled = true;
            mnuHoaDon.Enabled = true;
            mnuThongKeSanPham.Enabled = true;
            mnuThongKeDoanhThu.Enabled = true;// Hiển thị thông tin trên thanh trạng thái
            lblTrangThai.Text = "Quản lý: " + hoVaTenNhanVien;
        }
        public void QuyenNhanVien()
        {
            // Mờ đăng nhập
            mnuDangNhap.Enabled = false;

            // Mờ các chức năng nhân viên không được phép
            mnuLoaiGiay.Enabled = false;
            mnuNhaCungCap.Enabled = false;
            mnuGiay.Enabled = false;
            mnuNhanVien.Enabled = false;

            // Sáng đăng xuất và các chức năng nhân viên được phép
            mnuDangXuat.Enabled = true;
            mnuKhachHang.Enabled = true;
            mnuHoaDon.Enabled = true;
            mnuThongKeSanPham.Enabled = true;
            mnuThongKeDoanhThu.Enabled = true;

            // Hiển thị thông tin trên thanh trạng thái
            lblTrangThai.Text = "Nhân viên: " + hoVaTenNhanVien;
        }

        private void DangNhap()
        {
        LamLai:
            if (dangNhap == null || dangNhap.IsDisposed)
                dangNhap = new Frm_DangNhap();
            if (dangNhap.ShowDialog() == DialogResult.OK)
            {
                string tenDangNhap = dangNhap.txtDangNhap.Text;
                string matKhau = dangNhap.txtMatKhau.Text;
                if (tenDangNhap.Trim() == "")
                {
                    MessageBox.Show("Tên đăng nhập không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dangNhap.txtDangNhap.Focus();
                    goto LamLai;
                }
                else if (matKhau.Trim() == "")
                {
                    MessageBox.Show("Mật khẩu không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dangNhap.txtMatKhau.Focus();
                    goto LamLai;
                }
                else
                {
                    var nhanVien = context.NhanVien.Where(r => r.TenDangNhap == tenDangNhap).SingleOrDefault();
                    if (nhanVien == null)
                    {
                        MessageBox.Show("Tên đăng nhập không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dangNhap.txtDangNhap.Focus();
                        goto LamLai;
                    }
                    else
                    {
                        if (matKhau == nhanVien.MatKhau)
                        {
                            hoVaTenNhanVien = nhanVien.HoTenNhanVien;
                            if (nhanVien.QuyenHan == false)
                                QuyenQuanLy();
                            else if (nhanVien.QuyenHan == true)
                                QuyenNhanVien();
                            else
                                ChuaDangNhap();
                        }
                        else
                        {
                            MessageBox.Show("Mật khẩu không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            dangNhap.txtMatKhau.Focus();
                            goto LamLai;
                        }
                    }
                }
            }
        }



        private void mnuDangNhap_Click(object sender, EventArgs e)
        {
            DangNhap();
        }

        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            foreach (Form child in MdiChildren)
            {
                child.Close();
            }
            ChuaDangNhap();
        }
        #endregion


        #region Chức Năng Báo Cáo Thống Kê




        private void mnuThongKeSanPham_Click(object sender, EventArgs e)
        {
            if (thongKeGiay == null || thongKeGiay.IsDisposed)
            {
                thongKeGiay = new frmThongKeSanPham();
                thongKeGiay.MdiParent = this;
                thongKeGiay.Show();
            }
            else
                thongKeGiay.Activate();
        }
        #endregion

        private void mnuThongKeDoanhThu_Click(object sender, EventArgs e)
        {
            if (thongKeDoanhThu == null || thongKeDoanhThu.IsDisposed)
            {
                thongKeDoanhThu = new Frm_ThongKeDoanhThu();
                thongKeDoanhThu.MdiParent = this;
                thongKeDoanhThu.Show();
            }
            else
                thongKeDoanhThu.Activate();
        }

        private void mnuHuongDanSuDung_Click(object sender, EventArgs e)
        {
            if (hdsd == null || hdsd.IsDisposed)
            {
                hdsd = new Frm_HuongDanSuDung();
                hdsd.MdiParent = this;
                hdsd.Show();
            }
            else
                hdsd.Activate();
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            DialogResult dg;
            dg = MessageBox.Show("Bạn có muốn thoát???", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
