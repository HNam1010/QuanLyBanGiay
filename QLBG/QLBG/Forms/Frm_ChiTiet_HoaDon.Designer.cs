namespace QLBG.Forms
{
    partial class Frm_ChiTiet_HoaDon
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            txtGhiChuHoaDon = new TextBox();
            cboKhachHang = new ComboBox();
            cboNhanVien = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            btnXoa = new Button();
            btnXacNhanBan = new Button();
            numDonGiaBan = new NumericUpDown();
            numSoLuongBan = new NumericUpDown();
            cboGiay = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            groupBox2 = new GroupBox();
            dataGridView = new DataGridView();
            GiayID = new DataGridViewTextBoxColumn();
            TenGiay = new DataGridViewTextBoxColumn();
            DonGiaBan = new DataGridViewTextBoxColumn();
            SoLuongBan = new DataGridViewTextBoxColumn();
            ThanhTien = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            lblTongTien = new Label();
            label8 = new Label();
            label7 = new Label();
            btnThoat = new Button();
            btnLuuHoaDon = new Button();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numDonGiaBan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuongBan).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(txtGhiChuHoaDon);
            groupBox1.Controls.Add(cboKhachHang);
            groupBox1.Controls.Add(cboNhanVien);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(784, 131);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin Hóa Đơn";
            // 
            // txtGhiChuHoaDon
            // 
            txtGhiChuHoaDon.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtGhiChuHoaDon.Location = new Point(158, 80);
            txtGhiChuHoaDon.Name = "txtGhiChuHoaDon";
            txtGhiChuHoaDon.Size = new Size(589, 25);
            txtGhiChuHoaDon.TabIndex = 3;
            // 
            // cboKhachHang
            // 
            cboKhachHang.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            cboKhachHang.FormattingEnabled = true;
            cboKhachHang.Location = new Point(499, 34);
            cboKhachHang.Name = "cboKhachHang";
            cboKhachHang.Size = new Size(248, 25);
            cboKhachHang.TabIndex = 2;
            // 
            // cboNhanVien
            // 
            cboNhanVien.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            cboNhanVien.FormattingEnabled = true;
            cboNhanVien.Location = new Point(158, 32);
            cboNhanVien.Name = "cboNhanVien";
            cboNhanVien.Size = new Size(225, 25);
            cboNhanVien.TabIndex = 1;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label3.Location = new Point(12, 86);
            label3.Name = "label3";
            label3.Size = new Size(140, 17);
            label3.TabIndex = 0;
            label3.Text = "Ghi Chú Hóa Đơn (*):";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label2.Location = new Point(392, 38);
            label2.Name = "label2";
            label2.Size = new Size(106, 17);
            label2.TabIndex = 0;
            label2.Text = "Khách Hàng (*):";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label1.Location = new Point(55, 40);
            label1.Name = "label1";
            label1.Size = new Size(97, 17);
            label1.TabIndex = 0;
            label1.Text = "Nhân Viên (*):";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnXacNhanBan);
            panel1.Controls.Add(numDonGiaBan);
            panel1.Controls.Add(numSoLuongBan);
            panel1.Controls.Add(cboGiay);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 21);
            panel1.Name = "panel1";
            panel1.Size = new Size(778, 85);
            panel1.TabIndex = 0;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnXoa.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnXoa.Image = Properties.Resources.delete16;
            btnXoa.Location = new Point(699, 32);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(70, 34);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xóa";
            btnXoa.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnXacNhanBan
            // 
            btnXacNhanBan.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXacNhanBan.Image = Properties.Resources.Sell16;
            btnXacNhanBan.Location = new Point(559, 32);
            btnXacNhanBan.Name = "btnXacNhanBan";
            btnXacNhanBan.Size = new Size(121, 34);
            btnXacNhanBan.TabIndex = 3;
            btnXacNhanBan.Text = "Xác Nhận Bán";
            btnXacNhanBan.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnXacNhanBan.UseVisualStyleBackColor = true;
            btnXacNhanBan.Click += btnXacNhanBan_Click;
            // 
            // numDonGiaBan
            // 
            numDonGiaBan.Location = new Point(418, 41);
            numDonGiaBan.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numDonGiaBan.Name = "numDonGiaBan";
            numDonGiaBan.Size = new Size(120, 25);
            numDonGiaBan.TabIndex = 2;
            numDonGiaBan.TextAlign = HorizontalAlignment.Right;
            // 
            // numSoLuongBan
            // 
            numSoLuongBan.Location = new Point(277, 40);
            numSoLuongBan.Name = "numSoLuongBan";
            numSoLuongBan.Size = new Size(103, 25);
            numSoLuongBan.TabIndex = 1;
            numSoLuongBan.TextAlign = HorizontalAlignment.Right;
            // 
            // cboGiay
            // 
            cboGiay.FormattingEnabled = true;
            cboGiay.Location = new Point(36, 40);
            cboGiay.Name = "cboGiay";
            cboGiay.Size = new Size(211, 25);
            cboGiay.TabIndex = 0;
            cboGiay.SelectionChangeCommitted += cboGiay_SelectionChangeCommitted;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label6.Location = new Point(398, 14);
            label6.Name = "label6";
            label6.Size = new Size(109, 17);
            label6.TabIndex = 0;
            label6.Text = "Đơn Giá Bán (*):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label5.Location = new Point(256, 14);
            label5.Name = "label5";
            label5.Size = new Size(118, 17);
            label5.TabIndex = 0;
            label5.Text = "Số Lượng Bán (*):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label4.Location = new Point(9, 13);
            label4.Name = "label4";
            label4.Size = new Size(59, 17);
            label4.TabIndex = 0;
            label4.Text = "Giầy (*):";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Controls.Add(panel2);
            groupBox2.Controls.Add(panel1);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(0, 131);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(784, 432);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông Tin Chi Tiết Hóa Đơn";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { GiayID, TenGiay, DonGiaBan, SoLuongBan, ThanhTien });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 106);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.Size = new Size(778, 247);
            dataGridView.TabIndex = 2;
            // 
            // GiayID
            // 
            GiayID.DataPropertyName = "GiayID";
            GiayID.HeaderText = "ID";
            GiayID.Name = "GiayID";
            GiayID.ReadOnly = true;
            // 
            // TenGiay
            // 
            TenGiay.DataPropertyName = "TenGiay";
            TenGiay.HeaderText = "Tên Sản Phẩm";
            TenGiay.Name = "TenGiay";
            TenGiay.ReadOnly = true;
            // 
            // DonGiaBan
            // 
            DonGiaBan.DataPropertyName = "DonGiaBan";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N0";
            DonGiaBan.DefaultCellStyle = dataGridViewCellStyle1;
            DonGiaBan.HeaderText = "Đơn Giá Bán";
            DonGiaBan.Name = "DonGiaBan";
            DonGiaBan.ReadOnly = true;
            // 
            // SoLuongBan
            // 
            SoLuongBan.DataPropertyName = "SoLuongBan";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N0";
            SoLuongBan.DefaultCellStyle = dataGridViewCellStyle2;
            SoLuongBan.HeaderText = "Số Lượng Bán";
            SoLuongBan.Name = "SoLuongBan";
            SoLuongBan.ReadOnly = true;
            // 
            // ThanhTien
            // 
            ThanhTien.DataPropertyName = "ThanhTien";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Blue;
            dataGridViewCellStyle3.Format = "N0";
            ThanhTien.DefaultCellStyle = dataGridViewCellStyle3;
            ThanhTien.HeaderText = "Thành Tiền";
            ThanhTien.Name = "ThanhTien";
            ThanhTien.ReadOnly = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblTongTien);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(btnThoat);
            panel2.Controls.Add(btnLuuHoaDon);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(3, 353);
            panel2.Name = "panel2";
            panel2.Size = new Size(778, 76);
            panel2.TabIndex = 0;
            // 
            // lblTongTien
            // 
            lblTongTien.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblTongTien.AutoSize = true;
            lblTongTien.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            lblTongTien.Location = new Point(622, 36);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(15, 16);
            lblTongTien.TabIndex = 0;
            lblTongTien.Text = "0";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label8.Location = new Point(718, 36);
            label8.Name = "label8";
            label8.Size = new Size(39, 16);
            label8.TabIndex = 0;
            label8.Text = "VND";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label7.Location = new Point(530, 36);
            label7.Name = "label7";
            label7.Size = new Size(86, 16);
            label7.TabIndex = 0;
            label7.Text = "Tổng Tiền: ";
            // 
            // btnThoat
            // 
            btnThoat.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnThoat.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnThoat.Image = Properties.Resources.exit16;
            btnThoat.Location = new Point(371, 21);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(86, 36);
            btnThoat.TabIndex = 2;
            btnThoat.Text = "Thoát";
            btnThoat.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnLuuHoaDon
            // 
            btnLuuHoaDon.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnLuuHoaDon.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnLuuHoaDon.Image = Properties.Resources.save16;
            btnLuuHoaDon.Location = new Point(165, 21);
            btnLuuHoaDon.Name = "btnLuuHoaDon";
            btnLuuHoaDon.Size = new Size(155, 36);
            btnLuuHoaDon.TabIndex = 0;
            btnLuuHoaDon.Text = "Lưu Hóa Đơn";
            btnLuuHoaDon.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLuuHoaDon.UseVisualStyleBackColor = true;
            btnLuuHoaDon.Click += btnLuuHoaDon_Click;
            // 
            // Frm_ChiTiet_HoaDon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 563);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Frm_ChiTiet_HoaDon";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chi Tiết Hóa Đơn";
            Load += Frm_ChiTiet_HoaDon_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numDonGiaBan).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuongBan).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private ComboBox cboKhachHang;
        private ComboBox cboNhanVien;
        private TextBox txtGhiChuHoaDon;
        private Label label3;
        private ComboBox cboGiay;
        private Label label4;
        private NumericUpDown numDonGiaBan;
        private NumericUpDown numSoLuongBan;
        private Button btnXacNhanBan;
        private Label label6;
        private Label label5;
        private Button btnXoa;
        private GroupBox groupBox2;
        private Panel panel2;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn GiayID;
        private DataGridViewTextBoxColumn TenGiay;
        private DataGridViewTextBoxColumn DonGiaBan;
        private DataGridViewTextBoxColumn SoLuongBan;
        private DataGridViewTextBoxColumn ThanhTien;
        private Button btnLuuHoaDon;
        private Button btnThoat;
        private Label lblTongTien;
        private Label label7;
        private Label label8;
    }
}