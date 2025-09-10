namespace QLBG.Forms
{
    partial class Frm_LoaiGiay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_LoaiGiay));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            btnThoat = new Button();
            btnHuyBo = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            txtTenLoaiGiay = new TextBox();
            lblTenLoaiGiay = new Label();
            groupBox2 = new GroupBox();
            dataGridView = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Ten_LoaiGiay = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackgroundImage = (Image)resources.GetObject("groupBox1.BackgroundImage");
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(txtTenLoaiGiay);
            groupBox1.Controls.Add(lblTenLoaiGiay);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(728, 129);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin Loại Giầy";
            // 
            // btnThoat
            // 
            btnThoat.Image = Properties.Resources.exit16;
            btnThoat.Location = new Point(593, 73);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(79, 36);
            btnThoat.TabIndex = 6;
            btnThoat.Text = "Thoát";
            btnThoat.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Image = Properties.Resources.refresh16;
            btnHuyBo.Location = new Point(499, 73);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(79, 36);
            btnHuyBo.TabIndex = 5;
            btnHuyBo.Text = "Hủy Bỏ";
            btnHuyBo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnLuu
            // 
            btnLuu.Image = Properties.Resources.save16;
            btnLuu.Location = new Point(402, 73);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(79, 36);
            btnLuu.TabIndex = 4;
            btnLuu.Text = "Lưu";
            btnLuu.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.Image = Properties.Resources.delete16;
            btnXoa.Location = new Point(308, 73);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(79, 36);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xóa";
            btnXoa.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Image = Properties.Resources.edit16;
            btnSua.Location = new Point(209, 73);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(79, 36);
            btnSua.TabIndex = 2;
            btnSua.Text = "Sửa";
            btnSua.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Image = Properties.Resources.add16;
            btnThem.Location = new Point(113, 73);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(79, 36);
            btnThem.TabIndex = 1;
            btnThem.Text = "Thêm";
            btnThem.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txtTenLoaiGiay
            // 
            txtTenLoaiGiay.Location = new Point(151, 34);
            txtTenLoaiGiay.Name = "txtTenLoaiGiay";
            txtTenLoaiGiay.Size = new Size(537, 23);
            txtTenLoaiGiay.TabIndex = 0;
            // 
            // lblTenLoaiGiay
            // 
            lblTenLoaiGiay.AutoSize = true;
            lblTenLoaiGiay.BackColor = SystemColors.ControlDark;
            lblTenLoaiGiay.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTenLoaiGiay.ForeColor = Color.Red;
            lblTenLoaiGiay.Location = new Point(12, 34);
            lblTenLoaiGiay.Name = "lblTenLoaiGiay";
            lblTenLoaiGiay.Size = new Size(134, 21);
            lblTenLoaiGiay.TabIndex = 0;
            lblTenLoaiGiay.Text = "Tên Loại Giầy(*):";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 129);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(728, 255);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh Sách Loại Giầy";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ID, Ten_LoaiGiay });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 19);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.Size = new Size(722, 233);
            dataGridView.TabIndex = 0;
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
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Blue;
            Ten_LoaiGiay.DefaultCellStyle = dataGridViewCellStyle1;
            Ten_LoaiGiay.HeaderText = "TÊN LOẠI GIẦY";
            Ten_LoaiGiay.Name = "Ten_LoaiGiay";
            Ten_LoaiGiay.ReadOnly = true;
            // 
            // Frm_LoaiGiay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(728, 384);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Frm_LoaiGiay";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Loại Giầy";
            Load += Frm_LoaiGiay_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label lblTenLoaiGiay;
        private Button btnThoat;
        private Button btnHuyBo;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private TextBox txtTenLoaiGiay;
        private GroupBox groupBox2;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Ten_LoaiGiay;
    }
}