using Microsoft.Data.SqlClient;
using QLBG.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;

namespace QLBG.Forms
{
    public partial class Frm_KhachHang : Form
    {
        QLBGDbContext context = new QLBGDbContext(); // Khởi tạo biến ngữ cảnh CSDL
        bool xuLyThem = false; // Kiểm tra có nhấn vào nút Thêm hay không?
        int id; // Lấy mã khách hàng (dùng cho Sửa và Xóa)       

        public Frm_KhachHang()
        {
            InitializeComponent();
        }

        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;
            txtHoVaTen.Enabled = giaTri;
            txtTuoi.Enabled = giaTri;
            txtDiaChi.Enabled = giaTri;
            txtEmail.Enabled = giaTri;
            cboGioiTinh.Enabled = giaTri;
            //btnXuatExcel.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
            btnTimKiem.Enabled = !giaTri;
        }

        private void Frm_KhachHang_Load(object sender, EventArgs e)
        {
            

            BatTatChucNang(false);
            List<KhachHang> kh = new List<KhachHang>();
            kh = context.KhachHang.ToList();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = kh;

            txtHoVaTen.DataBindings.Clear();
            txtHoVaTen.DataBindings.Add("Text", bindingSource, "HoTenKhachHang", false, DataSourceUpdateMode.Never);

            txtTuoi.DataBindings.Clear();
            txtTuoi.DataBindings.Add("Text", bindingSource, "Tuoi", false, DataSourceUpdateMode.Never);

            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", bindingSource, "DiaChi", false, DataSourceUpdateMode.Never);

            txtEmail.DataBindings.Clear();
            txtEmail.DataBindings.Add("Text", bindingSource, "Email", false, DataSourceUpdateMode.Never);

            cboGioiTinh.DataBindings.Clear();
            cboGioiTinh.DataBindings.Add("SelectedIndex", bindingSource, "GioiTinh", false, DataSourceUpdateMode.Never);

            dataGridView.DataSource = bindingSource;
        }

        //nếu dữ liệu từ cơ sở dữ liệu cột gioitinh nếu giá trị 1 -> Nữ và ngược lại
        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //lấy cột có tên là giới tính trong dgv 
            if (this.dataGridView.Columns[e.ColumnIndex].Name == "GioiTinh")
            {
                if (Convert.ToInt16(e.Value) == 0)
                {
                    e.Value = "Nam";
                }
                else if (Convert.ToInt16(e.Value) == 1)
                {
                    e.Value = "Nữ";
                }
            }
        }

        #region chức năng thêm sửa xóa lưu hủy bỏ thoát         
        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            txtHoVaTen.Clear();
            txtTuoi.Clear();
            txtDiaChi.Clear();
            txtEmail.Clear();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xuLyThem = false;
            BatTatChucNang(true);
            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa khách hàng " + txtHoVaTen.Text + "?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
                KhachHang kh = context.KhachHang.Find(id);
                if (kh != null)
                {
                    context.KhachHang.Remove(kh);
                }
                context.SaveChanges();
                Frm_KhachHang_Load(sender, e);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoVaTen.Text))
                MessageBox.Show("Vui lòng nhập họ và tên khách hàng?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(txtTuoi.Text))
                MessageBox.Show("Vui lòng nhập tuổi?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(txtDiaChi.Text))
                MessageBox.Show("Vui lòng nhập địa chỉ?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(txtEmail.Text))
                MessageBox.Show("Vui lòng nhập Email?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(cboGioiTinh.Text))
                MessageBox.Show("Vui lòng chọn giới tính cho khách hàng?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (xuLyThem)
                {
                    KhachHang kh = new KhachHang();
                    kh.HoTenKhachHang = txtHoVaTen.Text;
                    kh.Tuoi = Convert.ToInt32(txtTuoi.Text);
                    kh.GioiTinh = cboGioiTinh.Text == "Nam" ? 0 : 1;
                    kh.DiaChi = txtDiaChi.Text;
                    kh.Email = txtEmail.Text;
                    context.KhachHang.Add(kh);
                    context.SaveChanges();
                }
                else
                {
                    KhachHang kh = context.KhachHang.Find(id);
                    if (kh != null)
                    {
                        kh.HoTenKhachHang = txtHoVaTen.Text;
                        kh.Tuoi = Convert.ToInt32(txtTuoi.Text);
                        kh.GioiTinh = cboGioiTinh.Text == "Nam" ? 0 : 1;
                        kh.DiaChi = txtDiaChi.Text;
                        kh.Email = txtEmail.Text;
                        context.KhachHang.Update(kh);
                        context.SaveChanges();
                    }
                }
                Frm_KhachHang_Load(sender, e);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            Frm_KhachHang_Load(sender, e);
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
        #endregion

        //update sau
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
        }

        //tìm kiếm theo tên
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTimKiem.Text))
                MessageBox.Show("Tên khách hàng không được để trống!", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else { 
                try
                {
                    using (SqlConnection con = new SqlConnection("Server =.\\SQLEXPRESS; Database=QLBG; Integrated Security=True;MultipleActiveResultSets=True; TrustServerCertificate=True"))
                    {
                        con.Open();
                        string sql = "SELECT * FROM KhachHang WHERE HoTenKhachHang LIKE N'%" + txtTimKiem.Text + "' ";
                        SqlCommand cmd = new SqlCommand(sql, con);

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        dataGridView.DataSource = table;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không tìm thấy " + txtTimKiem.Text + " trong danh sách khách hàng",
                        "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Xuất dữ liệu ra tập tin Excel";
            saveFileDialog.Filter = "Tập tin Excel|*.xls;*.xlsx";
            saveFileDialog.FileName = "KhachHang_" + DateTime.Now.ToShortDateString().Replace("/", "_") + ".xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();
                    table.Columns.AddRange(new DataColumn[6] {
                        new DataColumn("ID", typeof(int)),
                        new DataColumn("HoTenKhachHang", typeof(string)),
                        new DataColumn("Tuoi", typeof(string)),
                        new DataColumn("GioiTinh", typeof(string)),
                        new DataColumn("DiaChi", typeof(string)),                       
                        new DataColumn("Email", typeof(string))
                    });
                    var KhachHang = context.KhachHang.ToList();
                    if (KhachHang != null)
                    {
                        foreach (var p in KhachHang)
                            table.Rows.Add(p.ID, p.HoTenKhachHang, p.Tuoi, p.GioiTinh, p.DiaChi, p.Email);
                    }
                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var sheet = wb.Worksheets.Add(table, "KhachHang");
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
    }
}
