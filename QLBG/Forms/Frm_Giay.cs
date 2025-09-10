using ClosedXML.Excel;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using QLBG.Data;
using SlugGenerator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBG.Forms
{
    public partial class Frm_Giay : Form
    {
        QLBGDbContext context = new QLBGDbContext(); // Khởi tạo biến ngữ cảnh CSDL
        bool xuLyThem = false; // Kiểm tra có nhấn vào nút Thêm hay không?
        int id; // Lấy mã sản phẩm (dùng cho Sửa và Xóa)

        public Frm_Giay()
        {
            InitializeComponent();
        }

        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;
            cboNCC.Enabled = giaTri;
            cboLoaiGiay.Enabled = giaTri;
            txtTenGiay.Enabled = giaTri;
            numSoLuong.Enabled = giaTri;
            numDonGia.Enabled = giaTri;
            numSize.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
            btnTimKiem.Enabled = !giaTri;
            btnXuatExcel.Enabled = !giaTri;
        }

        public void LayDuLieuLoaiGiayVaoComboBox()
        {
            cboLoaiGiay.DataSource = context.LoaiGiay.ToList();
            cboLoaiGiay.ValueMember = "ID";
            cboLoaiGiay.DisplayMember = "Ten_LoaiGiay";
        }
        public void LayDuLieuNCCVaoComboBox()
        {
            cboNCC.DataSource = context.NhaCungCap.ToList();
            cboNCC.ValueMember = "ID";
            cboNCC.DisplayMember = "Ten_NhaCungCap";
        }

        private void Frm_Giay_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            LayDuLieuLoaiGiayVaoComboBox();
            LayDuLieuNCCVaoComboBox();

            //khong tu tao them cot 
            dataGridView.AutoGenerateColumns = false;

            List<DanhSachGiay> sp = new List<DanhSachGiay>();
            sp = context.Giay.Include(r => r.LoaiGiay).Include(r => r.NhaCungCap).Select(r => new DanhSachGiay
            {
                ID = r.ID,
                LoaiGiayID = r.LoaiGiayID,
                Ten_LoaiGiay = r.LoaiGiay.Ten_LoaiGiay,
                NhaCungCapID = r.NhaCungCapID,
                Ten_NhaCungCap = r.NhaCungCap.Ten_NhaCungCap,
                TenGiay = r.TenGiay,
                SoLuong = r.SoLuong,
                DonGia = r.DonGia,
                Size = r.Size
            }).ToList();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = sp;

            cboLoaiGiay.DataBindings.Clear();
            cboLoaiGiay.DataBindings.Add("SelectedValue", bindingSource, "LoaiGiayID", false, DataSourceUpdateMode.Never);

            cboNCC.DataBindings.Clear();
            cboNCC.DataBindings.Add("SelectedValue", bindingSource, "NhaCungCapID", false, DataSourceUpdateMode.Never);

            txtTenGiay.DataBindings.Clear();
            txtTenGiay.DataBindings.Add("Text", bindingSource, "TenGiay", false, DataSourceUpdateMode.Never);

            numSoLuong.DataBindings.Clear();
            numSoLuong.DataBindings.Add("Value", bindingSource, "SoLuong", false, DataSourceUpdateMode.Never);

            numDonGia.DataBindings.Clear();
            numDonGia.DataBindings.Add("Value", bindingSource, "DonGia", false, DataSourceUpdateMode.Never);

            numSize.DataBindings.Clear();
            numSize.DataBindings.Add("Value", bindingSource, "Size", false, DataSourceUpdateMode.Never);

            dataGridView.DataSource = bindingSource;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            cboLoaiGiay.Text = "";
            cboNCC.Text = "";
            txtTenGiay.Clear();
            numSoLuong.Value = 0;
            numDonGia.Value = 0;
            numSize.Value = 16;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xuLyThem = false;
            BatTatChucNang(true);
            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa giầy " + txtTenGiay.Text + "?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                DialogResult.Yes)
            {
                id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
                Giay sp = context.Giay.Find(id);
                if (sp != null)
                {
                    context.Giay.Remove(sp);
                }
                context.SaveChanges();
                Frm_Giay_Load(sender, e);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboLoaiGiay.Text))
                MessageBox.Show("Vui lòng chọn loại giầy.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(cboNCC.Text))
                MessageBox.Show("Vui lòng chọn nhà cung cấp.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(txtTenGiay.Text))
                MessageBox.Show("Vui lòng nhập tên giầy.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (numSoLuong.Value <= 0)
                MessageBox.Show("Số lượng giầy phải lớn hơn 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (numDonGia.Value <= 0)
                MessageBox.Show("Đơn giá giầy phải lớn hơn 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (numSize.Value <= 15 || numSize.Value > 100)
                MessageBox.Show("Size giầy phải nhỏ hơn 100 và phải lớn hơn 15.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (xuLyThem)
                {
                    Giay sp = new Giay();
                    sp.LoaiGiayID = Convert.ToInt32(cboLoaiGiay.SelectedValue.ToString());
                    sp.NhaCungCapID = Convert.ToInt32(cboNCC.SelectedValue.ToString());
                    sp.TenGiay = txtTenGiay.Text;
                    sp.DonGia = Convert.ToInt32(numDonGia.Value);
                    sp.SoLuong = Convert.ToInt32(numSoLuong.Value);
                    sp.Size = Convert.ToInt32(numSize.Value);

                    context.Giay.Add(sp);

                    context.SaveChanges();
                }
                else
                {
                    Giay sp = context.Giay.Find(id);
                    if (sp != null)
                    {
                        sp.LoaiGiayID = Convert.ToInt32(cboLoaiGiay.SelectedValue.ToString());
                        sp.NhaCungCapID = Convert.ToInt32(cboNCC.SelectedValue.ToString());
                        sp.TenGiay = txtTenGiay.Text;
                        sp.DonGia = Convert.ToInt32(numDonGia.Value);
                        sp.SoLuong = Convert.ToInt32(numSoLuong.Value);
                        sp.Size = Convert.ToInt32(numSize.Value);

                        context.Giay.Add(sp);
                        context.Giay.Update(sp);

                        context.SaveChanges();
                    }
                }
                Frm_Giay_Load(sender, e);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            Frm_Giay_Load(sender, e);
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

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTimKiem.Text))
                MessageBox.Show("Tên giầy không được để trống!", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                try
                {
                    using (SqlConnection con = new SqlConnection("Server =.\\SQLEXPRESS; Database=QLBG; Integrated Security=True;MultipleActiveResultSets=True; TrustServerCertificate=True"))
                    {
                        con.Open();
                        string sql = "SELECT * FROM Giay WHERE TenGiay LIKE N'%" + txtTimKiem.Text + "' ";
                        SqlCommand cmd = new SqlCommand(sql, con);

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        dataGridView.DataSource = table;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không tìm thấy " + txtTimKiem.Text + " trong danh sách giầy",
                        "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Xuất dữ liệu ra tập tin Excel";
            saveFileDialog.Filter = "Tập tin Excel|*.xls;*.xlsx";
            saveFileDialog.FileName = "Giay_" + DateTime.Now.ToShortDateString().Replace("/", "_") + ".xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();
                    table.Columns.AddRange(new DataColumn[7] {
                        new DataColumn("ID", typeof(int)),
                        new DataColumn("Ten_LoaiGiay", typeof(string)),
                        new DataColumn("Ten_NhaCungCap", typeof(string)),
                        new DataColumn("TenGiay", typeof(string)),
                        new DataColumn("SoLuong", typeof(string)),
                        new DataColumn("DonGia", typeof(string)),
                        new DataColumn("Size", typeof(string))
                    });
                    var Giay = context.Giay.ToList();
                    if (Giay != null)
                    {
                        foreach (var p in Giay)
                            table.Rows.Add(p.ID, GetTenLoaiGiayByID(p.LoaiGiayID), GetTenNCCByID(p.NhaCungCapID), 
                                p.TenGiay, p.SoLuong, p.DonGia, p.Size);
                    }
                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var sheet = wb.Worksheets.Add(table, "Giay");
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

        //lấy thông tin tên loại giầy từ bảng loại giầy 
        private string GetTenLoaiGiayByID(int loaiGiayID)
        {
            try
            {
                // Thực hiện truy vấn để lấy tên loại giấy từ ID
                var loaiGiay = context.LoaiGiay.FirstOrDefault(lg => lg.ID == loaiGiayID);
                if (loaiGiay != null)
                {
                    return loaiGiay.Ten_LoaiGiay;
                }
                else
                {
                    // Trả về một giá trị mặc định nếu không tìm thấy loại giấy
                    return "Loại giầy không tồn tại";
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu có
                return "Lỗi khi truy vấn dữ liệu: " + ex.Message;
            }
        }

        //lấy thông tin tên nhà cung cấp từ bảng nhà cung cấp
        private string GetTenNCCByID(int NhaCungCapID)
        {
            try
            {
                // Thực hiện truy vấn để lấy tên loại giấy từ ID
                var ncc = context.NhaCungCap.FirstOrDefault(lg => lg.ID == NhaCungCapID);
                if (ncc != null)
                {
                    return ncc.Ten_NhaCungCap;
                }
                else
                {
                    // Trả về một giá trị mặc định nếu không tìm thấy loại giấy
                    return "Nhà cung cấp không tồn tại";
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu có
                return "Lỗi khi truy vấn dữ liệu: " + ex.Message;
            }
        }
    }
}
