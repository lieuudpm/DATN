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
            this.button2 = new System.Windows.Forms.Button();
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
            this.dgvThongSoKyThuat = new System.Windows.Forms.DataGridView();
            this.clStt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTieuDe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clThongso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNhom = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cmsNhomHang = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnThemnv = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvHienThi = new System.Windows.Forms.DataGridView();
            this.clTinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGiaSale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clBaoHanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsLoai = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsHang = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImg)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongSoKyThuat)).BeginInit();
            this.cmsNhomHang.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHienThi)).BeginInit();
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
            this.groupBox1.Controls.Add(this.button2);
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1, 543);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 33);
            this.button2.TabIndex = 4;
            this.button2.Text = "Chọn ảnh";
            this.button2.UseVisualStyleBackColor = true;
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
            this.cbxLoaiSp.Location = new System.Drawing.Point(73, 68);
            this.cbxLoaiSp.Name = "cbxLoaiSp";
            this.cbxLoaiSp.Size = new System.Drawing.Size(206, 28);
            this.cbxLoaiSp.TabIndex = 6;
            this.cbxLoaiSp.SelectedIndexChanged += new System.EventHandler(this.cbxLoaiSp_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Loại";
            // 
            // cbxHangSp
            // 
            this.cbxHangSp.FormattingEnabled = true;
            this.cbxHangSp.Location = new System.Drawing.Point(601, 68);
            this.cbxHangSp.Name = "cbxHangSp";
            this.cbxHangSp.Size = new System.Drawing.Size(197, 28);
            this.cbxHangSp.TabIndex = 6;
            // 
            // btnThemMoiHang
            // 
            this.btnThemMoiHang.Location = new System.Drawing.Point(805, 66);
            this.btnThemMoiHang.Name = "btnThemMoiHang";
            this.btnThemMoiHang.Size = new System.Drawing.Size(100, 33);
            this.btnThemMoiHang.TabIndex = 5;
            this.btnThemMoiHang.Text = "Thêm mới";
            this.btnThemMoiHang.UseVisualStyleBackColor = true;
            this.btnThemMoiHang.Click += new System.EventHandler(this.btnThemMoiHang_Click);
            // 
            // btnThemMoiLoaiHang
            // 
            this.btnThemMoiLoaiHang.Location = new System.Drawing.Point(285, 66);
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
            this.label4.Location = new System.Drawing.Point(547, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Hãng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Tên sản phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên sản phẩm";
            // 
            // txtMota
            // 
            this.txtMota.Location = new System.Drawing.Point(25, 133);
            this.txtMota.Multiline = true;
            this.txtMota.Name = "txtMota";
            this.txtMota.Size = new System.Drawing.Size(880, 58);
            this.txtMota.TabIndex = 2;
            // 
            // txtTenSp
            // 
            this.txtTenSp.Location = new System.Drawing.Point(141, 25);
            this.txtTenSp.Multiline = true;
            this.txtTenSp.Name = "txtTenSp";
            this.txtTenSp.Size = new System.Drawing.Size(764, 33);
            this.txtTenSp.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvThongSoKyThuat);
            this.groupBox3.Location = new System.Drawing.Point(342, 453);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(930, 185);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông số kỹ thuật ";
            // 
            // dgvThongSoKyThuat
            // 
            this.dgvThongSoKyThuat.BackgroundColor = System.Drawing.Color.White;
            this.dgvThongSoKyThuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongSoKyThuat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clStt,
            this.clTieuDe,
            this.clThongso,
            this.clNhom});
            this.dgvThongSoKyThuat.Location = new System.Drawing.Point(25, 25);
            this.dgvThongSoKyThuat.Name = "dgvThongSoKyThuat";
            this.dgvThongSoKyThuat.Size = new System.Drawing.Size(880, 139);
            this.dgvThongSoKyThuat.TabIndex = 1;
            // 
            // clStt
            // 
            this.clStt.HeaderText = "Số thứ tự";
            this.clStt.Name = "clStt";
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
            this.clNhom.HeaderText = "Nhóm";
            this.clNhom.Name = "clNhom";
            this.clNhom.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clNhom.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            // btnThemnv
            // 
            this.btnThemnv.Location = new System.Drawing.Point(13, 647);
            this.btnThemnv.Name = "btnThemnv";
            this.btnThemnv.Size = new System.Drawing.Size(100, 33);
            this.btnThemnv.TabIndex = 4;
            this.btnThemnv.Text = "Thêm mới";
            this.btnThemnv.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(119, 647);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 33);
            this.button1.TabIndex = 5;
            this.button1.Text = "Thêm mới";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvHienThi);
            this.groupBox4.Location = new System.Drawing.Point(342, 269);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(930, 178);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông tin chi tiết";
            // 
            // dgvHienThi
            // 
            this.dgvHienThi.BackgroundColor = System.Drawing.Color.White;
            this.dgvHienThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHienThi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clTinhTrang,
            this.clSoLuong,
            this.clGiaBan,
            this.clGiaSale,
            this.clBaoHanh});
            this.dgvHienThi.Location = new System.Drawing.Point(25, 25);
            this.dgvHienThi.Name = "dgvHienThi";
            this.dgvHienThi.Size = new System.Drawing.Size(880, 139);
            this.dgvHienThi.TabIndex = 1;
            // 
            // clTinhTrang
            // 
            this.clTinhTrang.HeaderText = "Tình trạng máy (%)";
            this.clTinhTrang.Name = "clTinhTrang";
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
            // frmThemmoisanpham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1284, 691);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnThemnv);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvHienThi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnThemnv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenSp;
        private System.Windows.Forms.ComboBox cbxLoaiSp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxHangSp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMota;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvThongSoKyThuat;
        private System.Windows.Forms.DataGridView dgvHienThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGiaSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn clBaoHanh;
        private System.Windows.Forms.ContextMenuStrip cmsNhomHang;
        private System.Windows.Forms.ToolStripMenuItem tToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn clStt;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTieuDe;
        private System.Windows.Forms.DataGridViewTextBoxColumn clThongso;
        private System.Windows.Forms.DataGridViewComboBoxColumn clNhom;
        private System.Windows.Forms.ContextMenuStrip cmsLoai;
        private System.Windows.Forms.ContextMenuStrip cmsHang;
        private System.Windows.Forms.Button btnThemMoiHang;
        private System.Windows.Forms.Button btnThemMoiLoaiHang;
        private System.Windows.Forms.PictureBox picImg;
        private System.Windows.Forms.Button button2;
    }
}