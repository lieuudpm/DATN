namespace WindowsFormsApp2
{
    partial class frmQldonhangnhap
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvHienThi = new System.Windows.Forms.DataGridView();
            this.clId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTinhtrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenNcc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenSp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnHuytao = new System.Windows.Forms.Button();
            this.btntaohoadonnhap = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTimKiemNhaCungCap = new System.Windows.Forms.TextBox();
            this.btnTimKiemDonHang = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbxTrangThai = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ucMenu1 = new WindowsFormsApp2.ucMenu();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHienThi)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.dgvHienThi);
            this.groupBox3.Controls.Add(this.btnHuytao);
            this.groupBox3.Controls.Add(this.btntaohoadonnhap);
            this.groupBox3.Location = new System.Drawing.Point(12, 271);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1272, 392);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh Sách ";
            // 
            // dgvHienThi
            // 
            this.dgvHienThi.AllowUserToAddRows = false;
            this.dgvHienThi.BackgroundColor = System.Drawing.Color.White;
            this.dgvHienThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHienThi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clId,
            this.clTinhtrang,
            this.clNgayNhap,
            this.clTenNcc,
            this.clTenSp,
            this.clSoLuong,
            this.clTongTien});
            this.dgvHienThi.Location = new System.Drawing.Point(6, 40);
            this.dgvHienThi.Name = "dgvHienThi";
            this.dgvHienThi.Size = new System.Drawing.Size(1260, 283);
            this.dgvHienThi.TabIndex = 6;
            // 
            // clId
            // 
            this.clId.HeaderText = "ID Đơn hàng";
            this.clId.Name = "clId";
            this.clId.Width = 150;
            // 
            // clTinhtrang
            // 
            this.clTinhtrang.HeaderText = "Tình Trạng";
            this.clTinhtrang.Name = "clTinhtrang";
            this.clTinhtrang.Width = 200;
            // 
            // clNgayNhap
            // 
            this.clNgayNhap.HeaderText = "Ngày Nhập Hàng";
            this.clNgayNhap.Name = "clNgayNhap";
            this.clNgayNhap.Width = 200;
            // 
            // clTenNcc
            // 
            this.clTenNcc.HeaderText = "Nhà cung cấp ";
            this.clTenNcc.Name = "clTenNcc";
            this.clTenNcc.Width = 200;
            // 
            // clTenSp
            // 
            this.clTenSp.HeaderText = "Tên sản phẩm ";
            this.clTenSp.Name = "clTenSp";
            this.clTenSp.Width = 200;
            // 
            // clSoLuong
            // 
            this.clSoLuong.HeaderText = "Số lượng";
            this.clSoLuong.Name = "clSoLuong";
            // 
            // clTongTien
            // 
            this.clTongTien.HeaderText = "Tổng Tiền ";
            this.clTongTien.Name = "clTongTien";
            this.clTongTien.Width = 150;
            // 
            // btnHuytao
            // 
            this.btnHuytao.Location = new System.Drawing.Point(1163, 343);
            this.btnHuytao.Name = "btnHuytao";
            this.btnHuytao.Size = new System.Drawing.Size(97, 34);
            this.btnHuytao.TabIndex = 4;
            this.btnHuytao.Text = "Hủy ";
            this.btnHuytao.UseVisualStyleBackColor = true;
            this.btnHuytao.Click += new System.EventHandler(this.btnHuytao_Click);
            // 
            // btntaohoadonnhap
            // 
            this.btntaohoadonnhap.Location = new System.Drawing.Point(986, 343);
            this.btntaohoadonnhap.Name = "btntaohoadonnhap";
            this.btntaohoadonnhap.Size = new System.Drawing.Size(146, 34);
            this.btntaohoadonnhap.TabIndex = 4;
            this.btntaohoadonnhap.Text = "Tạo hóa đơn ";
            this.btntaohoadonnhap.UseVisualStyleBackColor = true;
            this.btntaohoadonnhap.Click += new System.EventHandler(this.btntaohoadonnhap_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "Trạng thái ";
            // 
            // txtTimKiemNhaCungCap
            // 
            this.txtTimKiemNhaCungCap.Location = new System.Drawing.Point(715, 47);
            this.txtTimKiemNhaCungCap.Name = "txtTimKiemNhaCungCap";
            this.txtTimKiemNhaCungCap.Size = new System.Drawing.Size(369, 26);
            this.txtTimKiemNhaCungCap.TabIndex = 3;
            // 
            // btnTimKiemDonHang
            // 
            this.btnTimKiemDonHang.Location = new System.Drawing.Point(1139, 48);
            this.btnTimKiemDonHang.Name = "btnTimKiemDonHang";
            this.btnTimKiemDonHang.Size = new System.Drawing.Size(121, 30);
            this.btnTimKiemDonHang.TabIndex = 1;
            this.btnTimKiemDonHang.Text = "Tìm Kiếm ";
            this.btnTimKiemDonHang.UseVisualStyleBackColor = true;
            this.btnTimKiemDonHang.Click += new System.EventHandler(this.btnTimKiemDonHang_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dtpNgayKetThuc);
            this.groupBox2.Controls.Add(this.dtpNgayBatDau);
            this.groupBox2.Controls.Add(this.cbxTrangThai);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtTimKiemNhaCungCap);
            this.groupBox2.Controls.Add(this.btnTimKiemDonHang);
            this.groupBox2.Location = new System.Drawing.Point(12, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1266, 148);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bộ lọc ";
            // 
            // cbxTrangThai
            // 
            this.cbxTrangThai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxTrangThai.FormattingEnabled = true;
            this.cbxTrangThai.Items.AddRange(new object[] {
            "Đã tiếp nhận ",
            "Đã thanh toán ",
            "Đã hủy "});
            this.cbxTrangThai.Location = new System.Drawing.Point(168, 44);
            this.cbxTrangThai.Name = "cbxTrangThai";
            this.cbxTrangThai.Size = new System.Drawing.Size(369, 28);
            this.cbxTrangThai.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(573, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên nhà cung cấp";
            // 
            // ucMenu1
            // 
            this.ucMenu1.BackColor = System.Drawing.Color.Blue;
            this.ucMenu1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucMenu1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucMenu1.Location = new System.Drawing.Point(0, 0);
            this.ucMenu1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucMenu1.Name = "ucMenu1";
            this.ucMenu1.Size = new System.Drawing.Size(1284, 43);
            this.ucMenu1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ngày bắt đầu ";
            // 
            // dtpNgayBatDau
            // 
            this.dtpNgayBatDau.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayBatDau.Location = new System.Drawing.Point(168, 97);
            this.dtpNgayBatDau.Name = "dtpNgayBatDau";
            this.dtpNgayBatDau.Size = new System.Drawing.Size(128, 26);
            this.dtpNgayBatDau.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(338, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ngày kết thúc";
            // 
            // dtpNgayKetThuc
            // 
            this.dtpNgayKetThuc.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayKetThuc.Location = new System.Drawing.Point(450, 97);
            this.dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            this.dtpNgayKetThuc.Size = new System.Drawing.Size(128, 26);
            this.dtpNgayKetThuc.TabIndex = 6;
            // 
            // frmQldonhangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1284, 675);
            this.Controls.Add(this.ucMenu1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmQldonhangnhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmQldonhangnhap";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmQldonhangnhap_FormClosing);
            this.Load += new System.EventHandler(this.frmQldonhangnhap_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHienThi)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btntaohoadonnhap;
        private System.Windows.Forms.Button btnHuytao;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTimKiemNhaCungCap;
        private System.Windows.Forms.Button btnTimKiemDonHang;
        private ucMenu ucMenu1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvHienThi;
        private System.Windows.Forms.ComboBox cbxTrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn clId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTinhtrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNgayNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenNcc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenSp;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTongTien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpNgayKetThuc;
        private System.Windows.Forms.DateTimePicker dtpNgayBatDau;
        private System.Windows.Forms.Label label3;
    }
}