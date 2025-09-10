using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace QLBG.Forms
{
    public partial class Frm_HuongDanSuDung : Form
    {
        public Frm_HuongDanSuDung()
        {
            InitializeComponent();
        }

        private void HuongDanSuDung_Load(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dg;
            dg = MessageBox.Show("Bạn có muốn thoát???", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                this.Close();
            }
        }


        #region các trang web khi click  
        private void llbDangNhap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://hnam1010.github.io/HuongDanSuDung/dangnhap.html",
                UseShellExecute = true
            });
        }


        private void llbLoaiGiay_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://hnam1010.github.io/HuongDanSuDung/loaisanpham.html",
                UseShellExecute = true
            });
        }

        private void llbMain_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://hnam1010.github.io/HuongDanSuDung/home.html",
                UseShellExecute = true
            });
        }

        private void llbNhaCungCap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://hnam1010.github.io/HuongDanSuDung/hangsanxuat.html",
                UseShellExecute = true
            });
        }

        private void llbNhanVien_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://hnam1010.github.io/HuongDanSuDung/nhanvien.html",
                UseShellExecute = true
            });
        }

        private void llbKhachHang_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://hnam1010.github.io/HuongDanSuDung/khachhang.html",
                UseShellExecute = true
            });
        }

        private void llbHoaDonBanHang_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://hnam1010.github.io/HuongDanSuDung/hoadonbanhang.html",
                UseShellExecute = true
            });
        }

        private void llbBaoCaoThongKe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://hnam1010.github.io/HuongDanSuDung/thongkesanpham.html",
                UseShellExecute = true
            });
        }
        #endregion
    }
}
