namespace QLBG.Forms
{
    partial class Frm_NhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_NhanVien));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            cboGioiTinh = new ComboBox();
            cboQuyenHan = new ComboBox();
            txtTimKiem = new TextBox();
            btnXuatExcel = new Button();
            btnThem = new Button();
            btnLuu = new Button();
            btnTimKiem = new Button();
            btnSua = new Button();
            btnHuyBo = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            txtMatKhau = new TextBox();
            txtTenDangNhap = new TextBox();
            txtDiaChi = new TextBox();
            label9 = new Label();
            txtEmail = new TextBox();
            label8 = new Label();
            txtTuoi = new TextBox();
            label4 = new Label();
            label6 = new Label();
            txtHoVaTen = new TextBox();
            label3 = new Label();
            label5 = new Label();
            label2 = new Label();
            label7 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dataGridView = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            HoTenNhanVien = new DataGridViewTextBoxColumn();
            Tuoi = new DataGridViewTextBoxColumn();
            GioiTinh = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            TenDangNhap = new DataGridViewTextBoxColumn();
            QuyenHan = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackgroundImage = (Image)resources.GetObject("groupBox1.BackgroundImage");
            groupBox1.Controls.Add(cboGioiTinh);
            groupBox1.Controls.Add(cboQuyenHan);
            groupBox1.Controls.Add(txtTimKiem);
            groupBox1.Controls.Add(btnXuatExcel);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnTimKiem);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(txtMatKhau);
            groupBox1.Controls.Add(txtTenDangNhap);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtTuoi);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtHoVaTen);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(861, 223);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin Nhân Viên";
            // 
            // cboGioiTinh
            // 
            cboGioiTinh.FormattingEnabled = true;
            cboGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" });
            cboGioiTinh.Location = new Point(101, 91);
            cboGioiTinh.Name = "cboGioiTinh";
            cboGioiTinh.Size = new Size(107, 23);
            cboGioiTinh.TabIndex = 1;
            // 
            // cboQuyenHan
            // 
            cboQuyenHan.FormattingEnabled = true;
            cboQuyenHan.Items.AddRange(new object[] { "ADMIN", "USER" });
            cboQuyenHan.Location = new Point(406, 182);
            cboQuyenHan.Name = "cboQuyenHan";
            cboQuyenHan.Size = new Size(115, 23);
            cboQuyenHan.TabIndex = 7;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTimKiem.Location = new Point(570, 44);
            txtTimKiem.Multiline = true;
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(171, 27);
            txtTimKiem.TabIndex = 14;
            // 
            // btnXuatExcel
            // 
            btnXuatExcel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnXuatExcel.Image = Properties.Resources.XuatExcel16;
            btnXuatExcel.Location = new Point(698, 85);
            btnXuatExcel.Name = "btnXuatExcel";
            btnXuatExcel.Size = new Size(116, 30);
            btnXuatExcel.TabIndex = 16;
            btnXuatExcel.Text = "Xuất Excel....";
            btnXuatExcel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnXuatExcel.UseVisualStyleBackColor = true;
            btnXuatExcel.Click += btnXuatExcel_Click;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnThem.Image = Properties.Resources.add16;
            btnThem.Location = new Point(551, 126);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(86, 37);
            btnThem.TabIndex = 8;
            btnThem.Text = "Thêm";
            btnThem.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnLuu
            // 
            btnLuu.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnLuu.Image = Properties.Resources.save16;
            btnLuu.Location = new Point(659, 171);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(82, 34);
            btnLuu.TabIndex = 11;
            btnLuu.Text = "Lưu";
            btnLuu.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnTimKiem.Image = Properties.Resources.search_16;
            btnTimKiem.Location = new Point(761, 36);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(94, 35);
            btnTimKiem.TabIndex = 15;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnSua.Image = Properties.Resources.edit16;
            btnSua.Location = new Point(551, 171);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(86, 34);
            btnSua.TabIndex = 9;
            btnSua.Text = "Sửa";
            btnSua.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnHuyBo.Image = Properties.Resources.refresh16;
            btnHuyBo.Location = new Point(763, 126);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(82, 37);
            btnHuyBo.TabIndex = 12;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnXoa.Image = Properties.Resources.delete16;
            btnXoa.Location = new Point(659, 126);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(82, 37);
            btnXoa.TabIndex = 10;
            btnXoa.Text = "Xóa";
            btnXoa.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnThoat.Image = Properties.Resources.exit16;
            btnThoat.Location = new Point(763, 171);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(82, 34);
            btnThoat.TabIndex = 13;
            btnThoat.Text = "Thoát";
            btnThoat.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(406, 135);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.Size = new Size(115, 23);
            txtMatKhau.TabIndex = 6;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(406, 85);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(115, 23);
            txtTenDangNhap.TabIndex = 5;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(101, 140);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(191, 23);
            txtDiaChi.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label9.Location = new Point(313, 136);
            label9.Name = "label9";
            label9.Size = new Size(87, 17);
            label9.TabIndex = 3;
            label9.Text = "Mật Khẩu(*):";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(101, 182);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(191, 23);
            txtEmail.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label8.Location = new Point(276, 91);
            label8.Name = "label8";
            label8.Size = new Size(124, 17);
            label8.TabIndex = 3;
            label8.Text = "Tên Đăng Nhập(*):";
            // 
            // txtTuoi
            // 
            txtTuoi.Location = new Point(367, 44);
            txtTuoi.Name = "txtTuoi";
            txtTuoi.Size = new Size(154, 23);
            txtTuoi.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label4.Location = new Point(12, 141);
            label4.Name = "label4";
            label4.Size = new Size(73, 17);
            label4.TabIndex = 3;
            label4.Text = "Địa Chỉ(*):";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label6.Location = new Point(6, 91);
            label6.Name = "label6";
            label6.Size = new Size(89, 17);
            label6.TabIndex = 4;
            label6.Text = "Giới Tính (*):";
            // 
            // txtHoVaTen
            // 
            txtHoVaTen.Location = new Point(101, 40);
            txtHoVaTen.Name = "txtHoVaTen";
            txtHoVaTen.Size = new Size(173, 23);
            txtHoVaTen.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label3.Location = new Point(306, 183);
            label3.Name = "label3";
            label3.Size = new Size(97, 17);
            label3.TabIndex = 3;
            label3.Text = "Quyền Hạn(*):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label5.Location = new Point(306, 43);
            label5.Name = "label5";
            label5.Size = new Size(55, 17);
            label5.TabIndex = 4;
            label5.Text = "Tuổi(*):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label2.Location = new Point(19, 182);
            label2.Name = "label2";
            label2.Size = new Size(66, 17);
            label2.TabIndex = 3;
            label2.Text = "Email (*):";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label7.Location = new Point(542, 24);
            label7.Name = "label7";
            label7.Size = new Size(148, 17);
            label7.TabIndex = 4;
            label7.Text = "Nhập Họ Tên Cần Tìm:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label1.Location = new Point(4, 41);
            label1.Name = "label1";
            label1.Size = new Size(91, 17);
            label1.TabIndex = 5;
            label1.Text = "Họ Và Tên(*):";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 223);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(861, 234);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh Sách Nhân Viên ";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ID, HoTenNhanVien, Tuoi, GioiTinh, DiaChi, Email, TenDangNhap, QuyenHan });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 19);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.Size = new Size(855, 212);
            dataGridView.TabIndex = 1;
            dataGridView.CellFormatting += dataGridView_CellFormatting;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // HoTenNhanVien
            // 
            HoTenNhanVien.DataPropertyName = "HoTenNhanVien";
            HoTenNhanVien.HeaderText = "Họ Và Tên";
            HoTenNhanVien.Name = "HoTenNhanVien";
            HoTenNhanVien.ReadOnly = true;
            // 
            // Tuoi
            // 
            Tuoi.DataPropertyName = "Tuoi";
            Tuoi.HeaderText = "Tuổi";
            Tuoi.Name = "Tuoi";
            Tuoi.ReadOnly = true;
            // 
            // GioiTinh
            // 
            GioiTinh.DataPropertyName = "GioiTinh";
            GioiTinh.HeaderText = "Giới Tính";
            GioiTinh.Name = "GioiTinh";
            GioiTinh.ReadOnly = true;
            // 
            // DiaChi
            // 
            DiaChi.DataPropertyName = "DiaChi";
            DiaChi.HeaderText = "Địa Chỉ";
            DiaChi.Name = "DiaChi";
            DiaChi.ReadOnly = true;
            // 
            // Email
            // 
            Email.DataPropertyName = "Email";
            Email.HeaderText = "Email";
            Email.Name = "Email";
            Email.ReadOnly = true;
            // 
            // TenDangNhap
            // 
            TenDangNhap.DataPropertyName = "TenDangNhap";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            TenDangNhap.DefaultCellStyle = dataGridViewCellStyle1;
            TenDangNhap.HeaderText = "Tên Đăng Nhập";
            TenDangNhap.Name = "TenDangNhap";
            TenDangNhap.ReadOnly = true;
            // 
            // QuyenHan
            // 
            QuyenHan.DataPropertyName = "QuyenHan";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            QuyenHan.DefaultCellStyle = dataGridViewCellStyle2;
            QuyenHan.HeaderText = "Quyền Hạn";
            QuyenHan.Name = "QuyenHan";
            QuyenHan.ReadOnly = true;
            // 
            // Frm_NhanVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(861, 457);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Frm_NhanVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nhân Viên";
            Load += Frm_NhanVien_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox cboQuyenHan;
        private TextBox txtTimKiem;
        private Button btnXuatExcel;
        private Button btnThem;
        private Button btnLuu;
        private Button btnTimKiem;
        private Button btnSua;
        private Button btnHuyBo;
        private Button btnXoa;
        private Button btnThoat;
        private TextBox txtDiaChi;
        private TextBox txtEmail;
        private TextBox txtTuoi;
        private Label label4;
        private Label label6;
        private TextBox txtHoVaTen;
        private Label label5;
        private Label label2;
        private Label label7;
        private Label label1;
        private GroupBox groupBox2;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn HoTenNhanVien;
        private DataGridViewTextBoxColumn Tuoi;
        private DataGridViewTextBoxColumn GioiTinh;
        private DataGridViewTextBoxColumn DiaChi;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn TenDangNhap;
        private DataGridViewTextBoxColumn QuyenHan;
        private TextBox txtTenDangNhap;
        private Label label8;
        private Label label3;
        private ComboBox cboGioiTinh;
        private TextBox txtMatKhau;
        private Label label9;
    }
}