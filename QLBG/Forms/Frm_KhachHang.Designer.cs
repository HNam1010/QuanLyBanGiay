namespace QLBG.Forms
{
    partial class Frm_KhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_KhachHang));
            groupBox1 = new GroupBox();
            cboGioiTinh = new ComboBox();
            txtTimKiem = new TextBox();
            btnXuatExcel = new Button();
            btnThem = new Button();
            btnLuu = new Button();
            btnTimKiem = new Button();
            btnSua = new Button();
            btnHuyBo = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            txtDiaChi = new TextBox();
            txtEmail = new TextBox();
            txtTuoi = new TextBox();
            lblDiaChi = new Label();
            lblGioiTinh = new Label();
            txtHoVaTen = new TextBox();
            lblTuoi = new Label();
            lblEmail = new Label();
            lblHoTenCanTim = new Label();
            lblHoTen = new Label();
            groupBox2 = new GroupBox();
            dataGridView = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            HoTenKhachHang = new DataGridViewTextBoxColumn();
            Tuoi = new DataGridViewTextBoxColumn();
            GioiTinh = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackgroundImage = (Image)resources.GetObject("groupBox1.BackgroundImage");
            groupBox1.Controls.Add(cboGioiTinh);
            groupBox1.Controls.Add(txtTimKiem);
            groupBox1.Controls.Add(btnXuatExcel);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnTimKiem);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtTuoi);
            groupBox1.Controls.Add(lblDiaChi);
            groupBox1.Controls.Add(lblGioiTinh);
            groupBox1.Controls.Add(txtHoVaTen);
            groupBox1.Controls.Add(lblTuoi);
            groupBox1.Controls.Add(lblEmail);
            groupBox1.Controls.Add(lblHoTenCanTim);
            groupBox1.Controls.Add(lblHoTen);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(861, 223);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin Khách Hàng";
            // 
            // cboGioiTinh
            // 
            cboGioiTinh.FormattingEnabled = true;
            cboGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" });
            cboGioiTinh.Location = new Point(101, 90);
            cboGioiTinh.Name = "cboGioiTinh";
            cboGioiTinh.Size = new Size(134, 23);
            cboGioiTinh.TabIndex = 1;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTimKiem.Location = new Point(570, 44);
            txtTimKiem.Multiline = true;
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(171, 27);
            txtTimKiem.TabIndex = 5;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // btnXuatExcel
            // 
            btnXuatExcel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnXuatExcel.Image = Properties.Resources.XuatExcel16;
            btnXuatExcel.Location = new Point(698, 85);
            btnXuatExcel.Name = "btnXuatExcel";
            btnXuatExcel.Size = new Size(116, 30);
            btnXuatExcel.TabIndex = 7;
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
            btnTimKiem.TabIndex = 6;
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
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(101, 140);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(397, 23);
            txtDiaChi.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(101, 182);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(397, 23);
            txtEmail.TabIndex = 4;
            // 
            // txtTuoi
            // 
            txtTuoi.Location = new Point(340, 91);
            txtTuoi.Name = "txtTuoi";
            txtTuoi.Size = new Size(158, 23);
            txtTuoi.TabIndex = 2;
            // 
            // lblDiaChi
            // 
            lblDiaChi.AutoSize = true;
            lblDiaChi.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblDiaChi.ForeColor = Color.Blue;
            lblDiaChi.Location = new Point(12, 141);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(73, 17);
            lblDiaChi.TabIndex = 3;
            lblDiaChi.Text = "Địa Chỉ(*):";
            // 
            // lblGioiTinh
            // 
            lblGioiTinh.AutoSize = true;
            lblGioiTinh.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblGioiTinh.ForeColor = Color.Blue;
            lblGioiTinh.Location = new Point(6, 91);
            lblGioiTinh.Name = "lblGioiTinh";
            lblGioiTinh.Size = new Size(89, 17);
            lblGioiTinh.TabIndex = 4;
            lblGioiTinh.Text = "Giới Tính (*):";
            // 
            // txtHoVaTen
            // 
            txtHoVaTen.Location = new Point(101, 44);
            txtHoVaTen.Name = "txtHoVaTen";
            txtHoVaTen.Size = new Size(397, 23);
            txtHoVaTen.TabIndex = 0;
            // 
            // lblTuoi
            // 
            lblTuoi.AutoSize = true;
            lblTuoi.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblTuoi.ForeColor = Color.Blue;
            lblTuoi.Location = new Point(279, 91);
            lblTuoi.Name = "lblTuoi";
            lblTuoi.Size = new Size(55, 17);
            lblTuoi.TabIndex = 4;
            lblTuoi.Text = "Tuổi(*):";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblEmail.ForeColor = Color.Blue;
            lblEmail.Location = new Point(19, 182);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(66, 17);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email (*):";
            // 
            // lblHoTenCanTim
            // 
            lblHoTenCanTim.AutoSize = true;
            lblHoTenCanTim.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblHoTenCanTim.ForeColor = Color.Blue;
            lblHoTenCanTim.Location = new Point(542, 24);
            lblHoTenCanTim.Name = "lblHoTenCanTim";
            lblHoTenCanTim.Size = new Size(148, 17);
            lblHoTenCanTim.TabIndex = 4;
            lblHoTenCanTim.Text = "Nhập Họ Tên Cần Tìm:";
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblHoTen.ForeColor = Color.Blue;
            lblHoTen.Location = new Point(4, 45);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(91, 17);
            lblHoTen.TabIndex = 5;
            lblHoTen.Text = "Họ Và Tên(*):";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 223);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(861, 234);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh Sách Khách Hàng";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ID, HoTenKhachHang, Tuoi, GioiTinh, DiaChi, Email });
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
            // HoTenKhachHang
            // 
            HoTenKhachHang.DataPropertyName = "HoTenKhachHang";
            HoTenKhachHang.HeaderText = "Họ Và Tên";
            HoTenKhachHang.Name = "HoTenKhachHang";
            HoTenKhachHang.ReadOnly = true;
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
            // Frm_KhachHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(861, 457);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Frm_KhachHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Khách Hàng";
            Load += Frm_KhachHang_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnThem;
        private Button btnLuu;
        private Button btnTimKiem;
        private Button btnSua;
        private Button btnHuyBo;
        private Button btnXoa;
        private Button btnThoat;
        private Button btnXuatExcel;
        private TextBox txtEmail;
        private TextBox txtHoVaTen;
        private Label lblEmail;
        private Label lblHoTen;
        private TextBox txtDiaChi;
        private Label lblDiaChi;
        private TextBox txtTuoi;
        private Label lblGioiTinh;
        private Label lblTuoi;
        private TextBox txtTimKiem;
        private Label lblHoTenCanTim;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn HoTenKhachHang;
        private DataGridViewTextBoxColumn Tuoi;
        private DataGridViewTextBoxColumn GioiTinh;
        private DataGridViewTextBoxColumn DiaChi;
        private DataGridViewTextBoxColumn Email;
        private ComboBox cboGioiTinh;
    }
}