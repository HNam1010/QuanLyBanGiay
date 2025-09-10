using ClosedXML.Excel;
using QLBG.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBG.Forms
{
    public partial class Frm_HoaDon : Form
    {
        QLBGDbContext context = new QLBGDbContext(); // Khởi tạo biến ngữ cảnh CSDL
        int id; // Lấy mã hóa đơn (dùng cho Sửa và Xóa)

        public Frm_HoaDon()
        {
            InitializeComponent();
        }

        private void Frm_HoaDon_Load(object sender, EventArgs e)
        {
            dataGridView.AutoGenerateColumns = false;
            List<DanhSachHoaDon> hd = new List<DanhSachHoaDon>();
            hd = context.HoaDon.Select(r => new DanhSachHoaDon
            {
                ID = r.ID,
                NhanVienID = r.NhanVienID,
                HoTenNhanVien = r.NhanVien.HoTenNhanVien,
                KhachHangID = r.KhachHangID,
                HoTenKhachHang = r.KhachHang.HoTenKhachHang,
                NgayLap = r.NgayLap,
                GhiChuHoaDon = r.GhiChuHoaDon,
                TongTienHoaDon = r.ChiTiet_HoaDon.Sum(r => r.SoLuongBan * r.DonGiaBan),
                XemChiTiet = ""
            }).ToList();
            dataGridView.DataSource = hd;
        }

        #region cách button lập, sửa, xóa,...

        private void btnLapHoaDon_Click(object sender, EventArgs e)
        {
            using (Frm_ChiTiet_HoaDon chiTiet = new Frm_ChiTiet_HoaDon())
            {
                chiTiet.ShowDialog();
            }
        }

        //chưa code
        private void btnInHoaDon_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
            using (Frm_ChiTiet_HoaDon chiTiet = new Frm_ChiTiet_HoaDon(id))
            {
                chiTiet.ShowDialog();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa hóa đơn ?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
                HoaDon hd = context.HoaDon.Find(id);
                if (hd != null)
                {
                    context.HoaDon.Remove(hd);
                }
                context.SaveChanges();
                Frm_HoaDon_Load(sender, e);
            }
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

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Xuất dữ liệu ra tập tin Excel";
            saveFileDialog.Filter = "Tập tin Excel|*.xls;*.xlsx";
            saveFileDialog.FileName = "HoaDon_" + DateTime.Now.ToShortDateString().Replace("/", "_") + ".xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();
                    table.Columns.AddRange(new DataColumn[5] {
                        new DataColumn("ID", typeof(int)),
                        new DataColumn("HoTenNhanVien", typeof(string)),
                        new DataColumn("HoTenKhachHang", typeof(string)),
                        new DataColumn("NgayLap", typeof(string)),
                        new DataColumn("GhiChuHoaDon", typeof(string))
                    });
                    var HoaDon = context.HoaDon.ToList();
                    if (HoaDon != null)
                    {
                        foreach (var p in HoaDon)
                            table.Rows.Add(p.ID, GetTenNhanVienByID(p.NhanVienID), GetTenKhachHangByID(p.KhachHangID),
                                p.NgayLap, p.GhiChuHoaDon);
                    }
                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var sheet = wb.Worksheets.Add(table, "HoaDon");
                        sheet.Columns().AdjustToContents();
                        wb.SaveAs(saveFileDialog.FileName);
                        MessageBox.Show("Đã xuất dữ liệu ra tập tin Excel thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        #endregion

        #region lấy họ tên nhân viên khách hàng vào excel
        //lấy thông tin tên nhân viên từ bảng nhân viên
        private string GetTenNhanVienByID(int NhanVienID)
        {
            try
            {
                // Thực hiện truy vấn để lấy tên loại giấy từ ID
                var nhanVien = context.NhanVien.FirstOrDefault(lg => lg.ID == NhanVienID);
                if (nhanVien != null)
                {
                    return nhanVien.HoTenNhanVien;
                }
                else
                {
                    // Trả về một giá trị mặc định nếu không tìm thấy loại giấy
                    return "Tên nhân viên không tồn tại";
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu có
                return "Lỗi khi truy vấn dữ liệu: " + ex.Message;
            }
        }

        //lấy thông tin tên khách hàng từ bảng khách hàng
        private string GetTenKhachHangByID(int KhachHangID)
        {
            try
            {
                // Thực hiện truy vấn để lấy tên loại giấy từ ID
                var khachHang = context.KhachHang.FirstOrDefault(lg => lg.ID == KhachHangID);
                if (khachHang != null)
                {
                    return khachHang.HoTenKhachHang;
                }
                else
                {
                    // Trả về một giá trị mặc định nếu không tìm thấy loại giấy
                    return "Tên khách hàng không tồn tại";
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu có
                return "Lỗi khi truy vấn dữ liệu: " + ex.Message;
            }
        }
        #endregion

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            Frm_HoaDon_Load(sender, e);
        }
    }
}
