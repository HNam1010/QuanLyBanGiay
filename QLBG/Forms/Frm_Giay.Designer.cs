namespace QLBG.Forms
{
    partial class Frm_Giay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Giay));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            txtTimKiem = new TextBox();
            btnXuatExcel = new Button();
            btnThem = new Button();
            btnLuu = new Button();
            btnTimKiem = new Button();
            btnSua = new Button();
            btnHuyBo = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            label4 = new Label();
            numDonGia = new NumericUpDown();
            numSize = new NumericUpDown();
            numSoLuong = new NumericUpDown();
            txtTenGiay = new TextBox();
            cboNCC = new ComboBox();
            cboLoaiGiay = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dataGridView = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Ten_LoaiGiay = new DataGridViewTextBoxColumn();
            Ten_NhaCungCap = new DataGridViewTextBoxColumn();
            TenGiay = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            DonGia = new DataGridViewTextBoxColumn();
            Size = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numDonGia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackgroundImage = (Image)resources.GetObject("groupBox1.BackgroundImage");
            groupBox1.Controls.Add(txtTimKiem);
            groupBox1.Controls.Add(btnXuatExcel);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnTimKiem);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(numDonGia);
            groupBox1.Controls.Add(numSize);
            groupBox1.Controls.Add(numSoLuong);
            groupBox1.Controls.Add(txtTenGiay);
            groupBox1.Controls.Add(cboNCC);
            groupBox1.Controls.Add(cboLoaiGiay);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(861, 217);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin Giầy";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTimKiem.Location = new Point(557, 37);
            txtTimKiem.Multiline = true;
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(198, 27);
            txtTimKiem.TabIndex = 13;
            // 
            // btnXuatExcel
            // 
            btnXuatExcel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnXuatExcel.Image = Properties.Resources.XuatExcel16;
            btnXuatExcel.Location = new Point(701, 79);
            btnXuatExcel.Name = "btnXuatExcel";
            btnXuatExcel.Size = new Size(116, 30);
            btnXuatExcel.TabIndex = 15;
            btnXuatExcel.Text = "Xuất Excel....";
            btnXuatExcel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnXuatExcel.UseVisualStyleBackColor = true;
            btnXuatExcel.Click += btnXuatExcel_Click;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnThem.Image = Properties.Resources.add16;
            btnThem.Location = new Point(554, 120);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(86, 37);
            btnThem.TabIndex = 7;
            btnThem.Text = "Thêm";
            btnThem.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnLuu
            // 
            btnLuu.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnLuu.Image = Properties.Resources.save16;
            btnLuu.Location = new Point(662, 165);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(82, 34);
            btnLuu.TabIndex = 10;
            btnLuu.Text = "Lưu";
            btnLuu.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnTimKiem.Image = Properties.Resources.search_16;
            btnTimKiem.Location = new Point(761, 31);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(94, 35);
            btnTimKiem.TabIndex = 14;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnSua.Image = Properties.Resources.edit16;
            btnSua.Location = new Point(554, 165);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(86, 34);
            btnSua.TabIndex = 8;
            btnSua.Text = "Sửa";
            btnSua.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnHuyBo.Image = Properties.Resources.refresh16;
            btnHuyBo.Location = new Point(766, 120);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(82, 37);
            btnHuyBo.TabIndex = 11;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnXoa.Image = Properties.Resources.delete16;
            btnXoa.Location = new Point(662, 120);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(82, 37);
            btnXoa.TabIndex = 9;
            btnXoa.Text = "Xóa";
            btnXoa.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnThoat.Image = Properties.Resources.exit16;
            btnThoat.Location = new Point(766, 165);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(82, 34);
            btnThoat.TabIndex = 12;
            btnThoat.Text = "Thoát";
            btnThoat.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label4.Location = new Point(504, 17);
            label4.Name = "label4";
            label4.Size = new Size(157, 17);
            label4.TabIndex = 20;
            label4.Text = "Nhập Tên Giầy Cần Tìm:";
            // 
            // numDonGia
            // 
            numDonGia.Location = new Point(149, 130);
            numDonGia.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numDonGia.Name = "numDonGia";
            numDonGia.Size = new Size(161, 23);
            numDonGia.TabIndex = 3;
            numDonGia.TextAlign = HorizontalAlignment.Right;
            // 
            // numSize
            // 
            numSize.Location = new Point(411, 134);
            numSize.Minimum = new decimal(new int[] { 15, 0, 0, 0 });
            numSize.Name = "numSize";
            numSize.Size = new Size(100, 23);
            numSize.TabIndex = 6;
            numSize.TextAlign = HorizontalAlignment.Right;
            numSize.Value = new decimal(new int[] { 20, 0, 0, 0 });
            // 
            // numSoLuong
            // 
            numSoLuong.Location = new Point(411, 85);
            numSoLuong.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numSoLuong.Name = "numSoLuong";
            numSoLuong.Size = new Size(100, 23);
            numSoLuong.TabIndex = 5;
            numSoLuong.TextAlign = HorizontalAlignment.Right;
            // 
            // txtTenGiay
            // 
            txtTenGiay.Location = new Point(149, 176);
            txtTenGiay.Name = "txtTenGiay";
            txtTenGiay.Size = new Size(362, 23);
            txtTenGiay.TabIndex = 4;
            // 
            // cboNCC
            // 
            cboNCC.FormattingEnabled = true;
            cboNCC.Location = new Point(149, 85);
            cboNCC.Name = "cboNCC";
            cboNCC.Size = new Size(161, 23);
            cboNCC.TabIndex = 2;
            // 
            // cboLoaiGiay
            // 
            cboLoaiGiay.FormattingEnabled = true;
            cboLoaiGiay.Location = new Point(149, 31);
            cboLoaiGiay.Name = "cboLoaiGiay";
            cboLoaiGiay.Size = new Size(161, 23);
            cboLoaiGiay.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label7.Location = new Point(349, 134);
            label7.Name = "label7";
            label7.Size = new Size(56, 17);
            label7.TabIndex = 0;
            label7.Text = "Size (*):";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label6.Location = new Point(319, 91);
            label6.Name = "label6";
            label6.Size = new Size(91, 17);
            label6.TabIndex = 0;
            label6.Text = "Số Lượng (*):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label5.Location = new Point(52, 130);
            label5.Name = "label5";
            label5.Size = new Size(78, 17);
            label5.TabIndex = 0;
            label5.Text = "Đơn Giá(*):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label3.Location = new Point(59, 177);
            label3.Name = "label3";
            label3.Size = new Size(81, 17);
            label3.TabIndex = 0;
            label3.Text = "Tên Giầy(*):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label2.Location = new Point(5, 88);
            label2.Name = "label2";
            label2.Size = new Size(147, 17);
            label2.TabIndex = 0;
            label2.Text = "Nhà Cung Cấp Giầy(*):";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label1.Location = new Point(45, 37);
            label1.Name = "label1";
            label1.Size = new Size(85, 17);
            label1.TabIndex = 0;
            label1.Text = "Loại Giầy(*):";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 217);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(861, 233);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh Sách Giầy";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ID, Ten_LoaiGiay, Ten_NhaCungCap, TenGiay, SoLuong, DonGia, Size });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 19);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.Size = new Size(855, 211);
            dataGridView.TabIndex = 2;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // Ten_LoaiGiay
            // 
            Ten_LoaiGiay.DataPropertyName = "Ten_LoaiGiay";
            Ten_LoaiGiay.HeaderText = "Tên Loại Giầy";
            Ten_LoaiGiay.Name = "Ten_LoaiGiay";
            Ten_LoaiGiay.ReadOnly = true;
            // 
            // Ten_NhaCungCap
            // 
            Ten_NhaCungCap.DataPropertyName = "Ten_NhaCungCap";
            Ten_NhaCungCap.HeaderText = "Tên Nhà Cung ";
            Ten_NhaCungCap.Name = "Ten_NhaCungCap";
            Ten_NhaCungCap.ReadOnly = true;
            // 
            // TenGiay
            // 
            TenGiay.DataPropertyName = "TenGiay";
            TenGiay.HeaderText = "Tên Giầy ";
            TenGiay.Name = "TenGiay";
            TenGiay.ReadOnly = true;
            // 
            // SoLuong
            // 
            SoLuong.DataPropertyName = "SoLuong";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle1.Format = "N0";
            SoLuong.DefaultCellStyle = dataGridViewCellStyle1;
            SoLuong.HeaderText = "Số Lượng";
            SoLuong.Name = "SoLuong";
            SoLuong.ReadOnly = true;
            // 
            // DonGia
            // 
            DonGia.DataPropertyName = "DonGia";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle2.Format = "N0";
            DonGia.DefaultCellStyle = dataGridViewCellStyle2;
            DonGia.HeaderText = "Đơn Giá";
            DonGia.Name = "DonGia";
            DonGia.ReadOnly = true;
            // 
            // Size
            // 
            Size.DataPropertyName = "Size";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Size.DefaultCellStyle = dataGridViewCellStyle3;
            Size.HeaderText = "Size";
            Size.Name = "Size";
            Size.ReadOnly = true;
            // 
            // Frm_Giay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(861, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Frm_Giay";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Giầy";
            Load += Frm_Giay_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numDonGia).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSize).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private NumericUpDown numDonGia;
        private NumericUpDown numSize;
        private NumericUpDown numSoLuong;
        private TextBox txtTenGiay;
        private ComboBox cboNCC;
        private ComboBox cboLoaiGiay;
        private Label label7;
        private Label label6;
        private TextBox txtTimKiem;
        private Button btnXuatExcel;
        private Button btnThem;
        private Button btnLuu;
        private Button btnTimKiem;
        private Button btnSua;
        private Button btnHuyBo;
        private Button btnXoa;
        private Button btnThoat;
        private Label label4;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Ten_LoaiGiay;
        private DataGridViewTextBoxColumn Ten_NhaCungCap;
        private DataGridViewTextBoxColumn TenGiay;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn DonGia;
        private DataGridViewTextBoxColumn Size;
    }
}