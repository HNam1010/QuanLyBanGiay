namespace QLBG.Forms
{
    partial class Frm_DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_DangNhap));
            groupBox1 = new GroupBox();
            btnReset = new Button();
            btnThoat = new Button();
            btnDangNhap = new Button();
            label2 = new Label();
            label1 = new Label();
            txtMatKhau = new TextBox();
            txtDangNhap = new TextBox();
            pictureBox1 = new PictureBox();
            helpProvider = new HelpProvider();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.WhiteSmoke;
            groupBox1.Controls.Add(btnReset);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnDangNhap);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtMatKhau);
            groupBox1.Controls.Add(txtDangNhap);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Location = new Point(62, 34);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(427, 437);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = " ";
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.FromArgb(192, 192, 255);
            btnReset.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnReset.Image = (Image)resources.GetObject("btnReset.Image");
            btnReset.Location = new Point(286, 356);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(97, 40);
            btnReset.TabIndex = 5;
            btnReset.Text = "Làm lại";
            btnReset.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.FromArgb(192, 192, 255);
            btnThoat.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnThoat.Image = (Image)resources.GetObject("btnThoat.Image");
            btnThoat.Location = new Point(176, 356);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(85, 40);
            btnThoat.TabIndex = 4;
            btnThoat.Text = "Thoát";
            btnThoat.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = Color.FromArgb(192, 192, 255);
            btnDangNhap.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnDangNhap.Image = (Image)resources.GetObject("btnDangNhap.Image");
            btnDangNhap.Location = new Point(24, 356);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(128, 40);
            btnDangNhap.TabIndex = 3;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(36, 269);
            label2.Name = "label2";
            label2.Size = new Size(102, 25);
            label2.TabIndex = 0;
            label2.Text = "Mật Khẩu:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(36, 198);
            label1.Name = "label1";
            label1.Size = new Size(149, 25);
            label1.TabIndex = 0;
            label1.Text = "Tên đăng nhập:";
            // 
            // txtMatKhau
            // 
            txtMatKhau.BackColor = SystemColors.ButtonFace;
            txtMatKhau.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMatKhau.Location = new Point(62, 297);
            txtMatKhau.Multiline = true;
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.Size = new Size(321, 31);
            txtMatKhau.TabIndex = 2;
            txtMatKhau.KeyDown += txtMatKhau_KeyDown;
            // 
            // txtDangNhap
            // 
            txtDangNhap.BackColor = SystemColors.ButtonFace;
            txtDangNhap.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDangNhap.Location = new Point(62, 226);
            txtDangNhap.Multiline = true;
            txtDangNhap.Name = "txtDangNhap";
            txtDangNhap.Size = new Size(321, 31);
            txtDangNhap.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(54, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(300, 153);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Frm_DangNhap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(534, 511);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Frm_DangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng Nhập";
            Load += Frm_DangNhap_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private Button btnThoat;
        private Button btnDangNhap;
        private Button btnReset;
        public TextBox txtMatKhau;
        public TextBox txtDangNhap;
        private HelpProvider helpProvider;
    }
}