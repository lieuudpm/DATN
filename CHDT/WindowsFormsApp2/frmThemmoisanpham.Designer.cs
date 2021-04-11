namespace WindowsFormsApp2
{
    partial class frmThemmoisanpham
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picImg = new System.Windows.Forms.PictureBox();
            this.btnChonAnh = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbxLoaiSp = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxHangSp = new System.Windows.Forms.ComboBox();
            this.btnThemMoiHang = new System.Windows.Forms.Button();
            this.btnThemMoiLoaiHang = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMota = new System.Windows.Forms.TextBox();
            this.txtTenSp = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnArrowDown = new FontAwesome.Sharp.IconButton();
            this.btnArrowTop = new FontAwesome.Sharp.IconButton();
            this.btnSanCo = new System.Windows.Forms.Button();
            this.dgvThongSoKyThuat = new System.Windows.Forms.DataGridView();
            this.clTieuDe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clThongso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNhom = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cmsNhomHang = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvLoaiMay = new System.Windows.Forms.DataGridView();
            this.cmsLoai = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsHang = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dgvGroup = new System.Windows.Forms.DataGridView();
            this.clGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clStt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.clTinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGiaSale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clBaoHanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSttLoaiMay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImg)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongSoKyThuat)).BeginInit();
            this.cmsNhomHang.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiMay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroup)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(448, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "THÊM MỚI SẢN PHẨM ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picImg);
            this.groupBox1.Controls.Add(this.btnChonAnh);
            this.groupBox1.Location = new System.Drawing.Point(12, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 582);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ảnh sản phẩm ";
            // 
            // picImg
            // 
            this.picImg.Location = new System.Drawing.Point(6, 25);
            this.picImg.Name = "picImg";
            this.picImg.Size = new System.Drawing.Size(290, 512);
            this.picImg.TabIndex = 5;
            this.picImg.TabStop = false;
            // 
            // btnChonAnh
            // 
            this.btnChonAnh.Location = new System.Drawing.Point(1, 543);
            this.btnChonAnh.Name = "btnChonAnh";
            this.btnChonAnh.Size = new System.Drawing.Size(100, 33);
            this.btnChonAnh.TabIndex = 4;
            this.btnChonAnh.Text = "Chọn ảnh";
            this.btnChonAnh.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbxLoaiSp);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cbxHangSp);
            this.groupBox2.Controls.Add(this.btnThemMoiHang);
            this.groupBox2.Controls.Add(this.btnThemMoiLoaiHang);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtMota);
            this.groupBox2.Controls.Add(this.txtTenSp);
            this.groupBox2.Location = new System.Drawing.Point(342, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(930, 207);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin cơ bản";
            // 
            // cbxLoaiSp
            // 
            this.cbxLoaiSp.FormattingEnabled = true;
            this.cbxLoaiSp.Location = new System.Drawing.Point(51, 68);
            this.cbxLoaiSp.Name = "cbxLoaiSp";
            this.cbxLoaiSp.Size = new System.Drawing.Size(206, 28);
            this.cbxLoaiSp.TabIndex = 6;
            this.cbxLoaiSp.SelectedIndexChanged += new System.EventHandler(this.cbxLoaiSp_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Loại";
            // 
            // cbxHangSp
            // 
            this.cbxHangSp.FormattingEnabled = true;
            this.cbxHangSp.Location = new System.Drawing.Point(621, 68);
            this.cbxHangSp.Name = "cbxHangSp";
            this.cbxHangSp.Size = new System.Drawing.Size(197, 28);
            this.cbxHangSp.TabIndex = 6;
            // 
            // btnThemMoiHang
            // 
            this.btnThemMoiHang.Location = new System.Drawing.Point(824, 66);
            this.btnThemMoiHang.Name = "btnThemMoiHang";
            this.btnThemMoiHang.Size = new System.Drawing.Size(100, 33);
            this.btnThemMoiHang.TabIndex = 5;
            this.btnThemMoiHang.Text = "Thêm mới";
            this.btnThemMoiHang.UseVisualStyleBackColor = true;
            this.btnThemMoiHang.Click += new System.EventHandler(this.btnThemMoiHang_Click);
            // 
            // btnThemMoiLoaiHang
            // 
            this.btnThemMoiLoaiHang.Location = new System.Drawing.Point(263, 66);
            this.btnThemMoiLoaiHang.Name = "btnThemMoiLoaiHang";
            this.btnThemMoiLoaiHang.Size = new System.Drawing.Size(100, 33);
            this.btnThemMoiLoaiHang.TabIndex = 5;
            this.btnThemMoiLoaiHang.Text = "Thêm mới";
            this.btnThemMoiLoaiHang.UseVisualStyleBackColor = true;
            this.btnThemMoiLoaiHang.Click += new System.EventHandler(this.btnThemMoiLoaiHang_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(567, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Hãng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Tên sản phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên sản phẩm";
            // 
            // txtMota
            // 
            this.txtMota.Location = new System.Drawing.Point(6, 133);
            this.txtMota.Multiline = true;
            this.txtMota.Name = "txtMota";
            this.txtMota.Size = new System.Drawing.Size(918, 58);
            this.txtMota.TabIndex = 2;
            // 
            // txtTenSp
            // 
            this.txtTenSp.Location = new System.Drawing.Point(122, 25);
            this.txtTenSp.Multiline = true;
            this.txtTenSp.Name = "txtTenSp";
            this.txtTenSp.Size = new System.Drawing.Size(802, 33);
            this.txtTenSp.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvGroup);
            this.groupBox3.Controls.Add(this.iconButton2);
            this.groupBox3.Controls.Add(this.btnArrowDown);
            this.groupBox3.Controls.Add(this.iconButton1);
            this.groupBox3.Controls.Add(this.btnArrowTop);
            this.groupBox3.Controls.Add(this.btnSanCo);
            this.groupBox3.Controls.Add(this.dgvThongSoKyThuat);
            this.groupBox3.Location = new System.Drawing.Point(342, 453);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(930, 226);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông số kỹ thuật ";
            // 
            // btnArrowDown
            // 
            this.btnArrowDown.IconChar = FontAwesome.Sharp.IconChar.ArrowDown;
            this.btnArrowDown.IconColor = System.Drawing.Color.Black;
            this.btnArrowDown.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnArrowDown.IconSize = 20;
            this.btnArrowDown.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnArrowDown.Location = new System.Drawing.Point(298, 102);
            this.btnArrowDown.Name = "btnArrowDown";
            this.btnArrowDown.Size = new System.Drawing.Size(32, 32);
            this.btnArrowDown.TabIndex = 6;
            this.btnArrowDown.UseVisualStyleBackColor = true;
            // 
            // btnArrowTop
            // 
            this.btnArrowTop.IconChar = FontAwesome.Sharp.IconChar.ArrowUp;
            this.btnArrowTop.IconColor = System.Drawing.Color.Black;
            this.btnArrowTop.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnArrowTop.IconSize = 20;
            this.btnArrowTop.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnArrowTop.Location = new System.Drawing.Point(298, 64);
            this.btnArrowTop.Name = "btnArrowTop";
            this.btnArrowTop.Size = new System.Drawing.Size(32, 32);
            this.btnArrowTop.TabIndex = 6;
            this.btnArrowTop.UseVisualStyleBackColor = true;
            // 
            // btnSanCo
            // 
            this.btnSanCo.Location = new System.Drawing.Point(6, 25);
            this.btnSanCo.Name = "btnSanCo";
            this.btnSanCo.Size = new System.Drawing.Size(100, 33);
            this.btnSanCo.TabIndex = 4;
            this.btnSanCo.Text = "Sẵn có";
            this.btnSanCo.UseVisualStyleBackColor = true;
            this.btnSanCo.Click += new System.EventHandler(this.btnSanCo_Click);
            // 
            // dgvThongSoKyThuat
            // 
            this.dgvThongSoKyThuat.BackgroundColor = System.Drawing.Color.White;
            this.dgvThongSoKyThuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongSoKyThuat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clTieuDe,
            this.clThongso,
            this.clNhom});
            this.dgvThongSoKyThuat.Location = new System.Drawing.Point(336, 64);
            this.dgvThongSoKyThuat.Name = "dgvThongSoKyThuat";
            this.dgvThongSoKyThuat.Size = new System.Drawing.Size(550, 144);
            this.dgvThongSoKyThuat.TabIndex = 1;
            // 
            // clTieuDe
            // 
            this.clTieuDe.HeaderText = "Tiêu đề";
            this.clTieuDe.Name = "clTieuDe";
            // 
            // clThongso
            // 
            this.clThongso.HeaderText = "Thông số";
            this.clThongso.Name = "clThongso";
            // 
            // clNhom
            // 
            this.clNhom.ContextMenuStrip = this.cmsNhomHang;
            this.clNhom.HeaderText = "Nhóm lọc tìm kiếm";
            this.clNhom.Name = "clNhom";
            this.clNhom.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clNhom.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clNhom.Width = 200;
            // 
            // cmsNhomHang
            // 
            this.cmsNhomHang.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tToolStripMenuItem});
            this.cmsNhomHang.Name = "cmsNhomHang";
            this.cmsNhomHang.Size = new System.Drawing.Size(79, 26);
            // 
            // tToolStripMenuItem
            // 
            this.tToolStripMenuItem.Name = "tToolStripMenuItem";
            this.tToolStripMenuItem.Size = new System.Drawing.Size(78, 22);
            this.tToolStripMenuItem.Text = "t";
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Location = new System.Drawing.Point(13, 647);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(100, 33);
            this.btnThemMoi.TabIndex = 4;
            this.btnThemMoi.Text = "Thêm mới";
            this.btnThemMoi.UseVisualStyleBackColor = true;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(119, 647);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 33);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvLoaiMay);
            this.groupBox4.Location = new System.Drawing.Point(342, 269);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(930, 178);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Loại máy";
            // 
            // dgvLoaiMay
            // 
            this.dgvLoaiMay.BackgroundColor = System.Drawing.Color.White;
            this.dgvLoaiMay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiMay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clTinhTrang,
            this.clSoLuong,
            this.clGiaBan,
            this.clGiaSale,
            this.clBaoHanh,
            this.clSttLoaiMay});
            this.dgvLoaiMay.Location = new System.Drawing.Point(6, 25);
            this.dgvLoaiMay.Name = "dgvLoaiMay";
            this.dgvLoaiMay.Size = new System.Drawing.Size(918, 139);
            this.dgvLoaiMay.TabIndex = 1;
            // 
            // cmsLoai
            // 
            this.cmsLoai.Name = "cmsLoai";
            this.cmsLoai.Size = new System.Drawing.Size(61, 4);
            // 
            // cmsHang
            // 
            this.cmsHang.Name = "cmsHang";
            this.cmsHang.Size = new System.Drawing.Size(61, 4);
            // 
            // dgvGroup
            // 
            this.dgvGroup.AllowUserToAddRows = false;
            this.dgvGroup.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGroup.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clGroup,
            this.clId,
            this.clStt});
            this.dgvGroup.Location = new System.Drawing.Point(6, 64);
            this.dgvGroup.Name = "dgvGroup";
            this.dgvGroup.ReadOnly = true;
            this.dgvGroup.RowHeadersVisible = false;
            this.dgvGroup.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGroup.Size = new System.Drawing.Size(286, 144);
            this.dgvGroup.TabIndex = 9;
            // 
            // clGroup
            // 
            this.clGroup.HeaderText = "Nhóm";
            this.clGroup.Name = "clGroup";
            this.clGroup.ReadOnly = true;
            this.clGroup.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clGroup.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clId
            // 
            this.clId.HeaderText = "Column1";
            this.clId.Name = "clId";
            this.clId.ReadOnly = true;
            this.clId.Visible = false;
            // 
            // clStt
            // 
            this.clStt.HeaderText = "Column1";
            this.clStt.Name = "clStt";
            this.clStt.ReadOnly = true;
            this.clStt.Visible = false;
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.ArrowUp;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 20;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButton1.Location = new System.Drawing.Point(892, 64);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(32, 32);
            this.iconButton1.TabIndex = 6;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // iconButton2
            // 
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.ArrowDown;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 20;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButton2.Location = new System.Drawing.Point(892, 102);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(32, 32);
            this.iconButton2.TabIndex = 6;
            this.iconButton2.UseVisualStyleBackColor = true;
            // 
            // clTinhTrang
            // 
            this.clTinhTrang.HeaderText = "Tình trạng máy (%)";
            this.clTinhTrang.Name = "clTinhTrang";
            this.clTinhTrang.Width = 200;
            // 
            // clSoLuong
            // 
            this.clSoLuong.HeaderText = "Số lượng";
            this.clSoLuong.Name = "clSoLuong";
            // 
            // clGiaBan
            // 
            this.clGiaBan.HeaderText = "Giá Bán";
            this.clGiaBan.Name = "clGiaBan";
            // 
            // clGiaSale
            // 
            this.clGiaSale.HeaderText = "Giá Sale";
            this.clGiaSale.Name = "clGiaSale";
            // 
            // clBaoHanh
            // 
            this.clBaoHanh.HeaderText = "Bảo Hành";
            this.clBaoHanh.Name = "clBaoHanh";
            this.clBaoHanh.Width = 150;
            // 
            // clSttLoaiMay
            // 
            this.clSttLoaiMay.HeaderText = "Stt";
            this.clSttLoaiMay.Name = "clSttLoaiMay";
            // 
            // frmThemmoisanpham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1284, 691);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmThemmoisanpham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmThemmoisanpham";
            this.Load += new System.EventHandler(this.frmThemmoisanpham_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picImg)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongSoKyThuat)).EndInit();
            this.cmsNhomHang.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiMay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenSp;
        private System.Windows.Forms.ComboBox cbxLoaiSp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxHangSp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMota;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvLoaiMay;
        private System.Windows.Forms.ContextMenuStrip cmsNhomHang;
        private System.Windows.Forms.ToolStripMenuItem tToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsLoai;
        private System.Windows.Forms.ContextMenuStrip cmsHang;
        private System.Windows.Forms.Button btnThemMoiHang;
        private System.Windows.Forms.Button btnThemMoiLoaiHang;
        private System.Windows.Forms.PictureBox picImg;
        private System.Windows.Forms.Button btnChonAnh;
        private System.Windows.Forms.DataGridView dgvThongSoKyThuat;
        private System.Windows.Forms.Button btnSanCo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTieuDe;
        private System.Windows.Forms.DataGridViewTextBoxColumn clThongso;
        private System.Windows.Forms.DataGridViewComboBoxColumn clNhom;
        private FontAwesome.Sharp.IconButton btnArrowTop;
        private FontAwesome.Sharp.IconButton btnArrowDown;
        private System.Windows.Forms.DataGridView dgvGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn clId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clStt;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGiaSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn clBaoHanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSttLoaiMay;
    }
}