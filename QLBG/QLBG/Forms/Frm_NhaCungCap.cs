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
    public partial class Frm_NhaCungCap : Form
    {
        QLBGDbContext context = new QLBGDbContext(); // Khởi tạo biến ngữ cảnh CSDL
        bool xuLyThem = false; // Kiểm tra có nhấn vào nút Thêm hay không?
        int id; // Lấy mã loại sản phẩm (dùng cho Sửa và Xóa)

        public Frm_NhaCungCap()
        {
            InitializeComponent();
        }

        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;
            txtTenNCC.Enabled = giaTri;
            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
        }

        private void Frm_NhaCungCap_Load(object sender, EventArgs e)
        {
            //nền label Tên Nhà cung cấp trong suốt
            lblNCC.BackColor = System.Drawing.Color.Transparent;

            BatTatChucNang(false);
            List<NhaCungCap> lsp = new List<NhaCungCap>();
            lsp = context.NhaCungCap.ToList();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = lsp;

            txtTenNCC.DataBindings.Clear();
            txtTenNCC.DataBindings.Add("Text", bindingSource, "Ten_NhaCungCap", false, DataSourceUpdateMode.Never);
            dataGridView.DataSource = bindingSource;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            txtTenNCC.Clear();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xuLyThem = false;
            BatTatChucNang(true);
            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa loại sản phẩm?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
                NhaCungCap lsp = context.NhaCungCap.Find(id);
                if (lsp != null)
                {
                    context.NhaCungCap.Remove(lsp);
                }
                context.SaveChanges();
                Frm_NhaCungCap_Load(sender, e);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenNCC.Text))
                MessageBox.Show("Vui lòng nhập tên loại sản phẩm?", "Xóa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (xuLyThem)
                {
                    NhaCungCap lsp = new NhaCungCap();
                    lsp.Ten_NhaCungCap = txtTenNCC.Text;
                    context.NhaCungCap.Add(lsp);
                    context.SaveChanges();
                }
                else
                {
                    NhaCungCap lsp = context.NhaCungCap.Find(id);
                    if (lsp != null)
                    {
                        lsp.Ten_NhaCungCap = txtTenNCC.Text;
                        context.NhaCungCap.Update(lsp);
                        context.SaveChanges();
                    }
                }
                Frm_NhaCungCap_Load(sender, e);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            Frm_NhaCungCap_Load(sender, e);
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
    }
}
