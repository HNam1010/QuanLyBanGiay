using ClosedXML.Excel;
using Microsoft.Data.SqlClient;
using QLBG.Data;
using System.Data;


namespace QLBG.Forms
{
    public partial class Frm_NhanVien : Form
    {
        QLBGDbContext context = new QLBGDbContext(); // Khởi tạo biến ngữ cảnh CSDL
        bool xuLyThem = false; // Kiểm tra có nhấn vào nút Thêm hay không?
        int id; // Lấy mã khách hàng (dùng cho Sửa và Xóa)  

        public Frm_NhanVien()
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
            txtTenDangNhap.Enabled = giaTri;
            txtMatKhau.Enabled = giaTri;
            cboQuyenHan.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
            btnTimKiem.Enabled = !giaTri;
        }

        private void Frm_NhanVien_Load(object sender, EventArgs e)
        {
            //ẩn cột không gọi tới
            dataGridView.AutoGenerateColumns = false;

            BatTatChucNang(false);
            List<NhanVien> nv = new List<NhanVien>();
            nv = context.NhanVien.ToList();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = nv;

            txtHoVaTen.DataBindings.Clear();
            txtHoVaTen.DataBindings.Add("Text", bindingSource, "HoTenNhanVien", false, DataSourceUpdateMode.Never);

            txtTuoi.DataBindings.Clear();
            txtTuoi.DataBindings.Add("Text", bindingSource, "Tuoi", false, DataSourceUpdateMode.Never);

            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", bindingSource, "DiaChi", false, DataSourceUpdateMode.Never);

            txtEmail.DataBindings.Clear();
            txtEmail.DataBindings.Add("Text", bindingSource, "Email", false, DataSourceUpdateMode.Never);

            txtTenDangNhap.DataBindings.Clear();
            txtTenDangNhap.DataBindings.Add("Text", bindingSource, "TenDangNhap", false, DataSourceUpdateMode.Never);

            cboGioiTinh.DataBindings.Clear();
            cboGioiTinh.DataBindings.Add("SelectedIndex", bindingSource, "GioiTinh", false, DataSourceUpdateMode.Never);

            cboQuyenHan.DataBindings.Clear();
            cboQuyenHan.DataBindings.Add("SelectedIndex", bindingSource, "QuyenHan", false, DataSourceUpdateMode.Never);


            dataGridView.DataSource = bindingSource;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            txtHoVaTen.Clear();
            txtTuoi.Clear();
            txtDiaChi.Clear();
            txtEmail.Clear();
            txtTenDangNhap.Clear();
            txtMatKhau.Clear();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xuLyThem = false;
            BatTatChucNang(true);
            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa nhân viên " + txtHoVaTen.Text + "?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
                NhanVien nv = context.NhanVien.Find(id);
                if (nv != null)
                {
                    context.NhanVien.Remove(nv);
                }
                context.SaveChanges();
                Frm_NhanVien_Load(sender, e);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoVaTen.Text))
                MessageBox.Show("Vui lòng nhập họ và tên nhân viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(txtTuoi.Text))
                MessageBox.Show("Vui lòng nhập tuổi!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(txtDiaChi.Text))
                MessageBox.Show("Vui lòng nhập địa chỉ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(txtEmail.Text))
                MessageBox.Show("Vui lòng nhập Email!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(txtTenDangNhap.Text))
                MessageBox.Show("Vui lòng nhập tên đăng nhập!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(txtMatKhau.Text))
                MessageBox.Show("Vui lòng nhập mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(cboGioiTinh.Text))
                MessageBox.Show("Vui lòng chọn giới tính cho nhân viên?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(cboQuyenHan.Text))
                MessageBox.Show("Vui lòng chọn quyền hạn cho nhân viên?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (xuLyThem)
                {
                    NhanVien nv = new NhanVien();
                    nv.HoTenNhanVien = txtHoVaTen.Text;
                    nv.Tuoi = Convert.ToInt32(txtTuoi.Text);
                    nv.GioiTinh = cboGioiTinh.Text == "Nam" ? 0 : 1;
                    nv.DiaChi = txtDiaChi.Text;
                    nv.Email = txtEmail.Text;
                    nv.TenDangNhap = txtTenDangNhap.Text;
                    nv.MatKhau = txtMatKhau.Text;
                    nv.QuyenHan = cboQuyenHan.SelectedIndex == 0 ? true : false;
                    context.NhanVien.Add(nv);
                    context.SaveChanges();
                }
                else
                {
                    NhanVien nv = context.NhanVien.Find(id);
                    if (nv != null)
                    {
                        nv.HoTenNhanVien = txtHoVaTen.Text;
                        nv.Tuoi = Convert.ToInt32(txtTuoi.Text);
                        nv.GioiTinh = cboGioiTinh.Text == "Nam" ? 0 : 1;
                        nv.DiaChi = txtDiaChi.Text;
                        nv.Email = txtEmail.Text;
                        nv.TenDangNhap = txtTenDangNhap.Text;
                        nv.MatKhau = txtMatKhau.Text;
                        nv.QuyenHan = cboQuyenHan.SelectedIndex == 0 ? true : false;
                        context.NhanVien.Update(nv);
                        context.SaveChanges();
                    }
                }
                Frm_NhanVien_Load(sender, e);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            Frm_NhanVien_Load(sender, e);
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

        //thay đổi thông tin từ cơ sở dữ liệu cột gioitinh nếu giá trị 1 -> Nữ và ngược lại + quyền hạn 
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

            //lấy cột có tên là quyền hạn trong dgv 
            if (this.dataGridView.Columns[e.ColumnIndex].Name == "QuyenHan")
            {
                if (Convert.ToBoolean(e.Value) == true)
                {
                    e.Value = "ADMIN";
                }
                else if (Convert.ToBoolean(e.Value) == false)
                {
                    e.Value = "USER";
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTimKiem.Text))
                MessageBox.Show("Tên nhân viên không được để trống!", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else {
                try
                {
                    using (SqlConnection con = new SqlConnection("Server =.\\SQLEXPRESS; Database=QLBG; Integrated Security=True;MultipleActiveResultSets=True; TrustServerCertificate=True"))
                    {
                        con.Open();
                        string sql = "SELECT * FROM NhanVien WHERE HoTenNhanVien LIKE N'%" + txtTimKiem.Text + "' ";
                        SqlCommand cmd = new SqlCommand(sql, con);

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        dataGridView.DataSource = table;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không tìm thấy " + txtTimKiem.Text + " trong danh sách nhân viên",
                        "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Xuất dữ liệu ra tập tin Excel";
            saveFileDialog.Filter = "Tập tin Excel|*.xls;*.xlsx";
            saveFileDialog.FileName = "NhanVien_" + DateTime.Now.ToShortDateString().Replace("/", "_") + ".xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();
                    table.Columns.AddRange(new DataColumn[9] {
                        new DataColumn("ID", typeof(int)),
                        new DataColumn("HoTenNhanVien", typeof(string)),
                        new DataColumn("Tuoi", typeof(string)),
                        new DataColumn("GioiTinh", typeof(string)),
                        new DataColumn("DiaChi", typeof(string)),
                        new DataColumn("Email", typeof(string)),
                        new DataColumn("TenDangNhap", typeof(string)),
                        new DataColumn("MatKhau", typeof(string)),
                        new DataColumn("QuyenHan", typeof(string))
                    });
                    var NhanVien = context.NhanVien.ToList();
                    if (NhanVien != null)
                    {
                        foreach (var p in NhanVien)
                            table.Rows.Add(p.ID, p.HoTenNhanVien, p.Tuoi, p.GioiTinh, p.DiaChi, p.Email, p.TenDangNhap, p.MatKhau, p.QuyenHan);
                    }
                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var sheet = wb.Worksheets.Add(table, "NhanVien");
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
