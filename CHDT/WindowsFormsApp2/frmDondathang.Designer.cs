namespace WindowsFormsApp2
{
    partial class frmDondathang
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
            this.ucMenu1 = new WindowsFormsApp2.ucMenu();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxTrangThai = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnThemMoiDonHang = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTenKh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvHienThi = new System.Windows.Forms.DataGridView();
            this.clId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNgayDatHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cldiachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clsdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clsoluongdat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cltinhtrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSoSerial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnhuy = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThemBaoHanh = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHienThi)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucMenu1
            // 
            this.ucMenu1.BackColor = System.Drawing.Color.Blue;
            this.ucMenu1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucMenu1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucMenu1.ForeColor = System.Drawing.Color.White;
            this.ucMenu1.Location = new System.Drawing.Point(0, 0);
            this.ucMenu1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucMenu1.Name = "ucMenu1";
            this.ucMenu1.Size = new System.Drawing.Size(1284, 43);
            this.ucMenu1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(434, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "QUẢN LÝ ĐƠN ĐẶT HÀNG ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpNgayKetThuc);
            this.groupBox1.Controls.Add(this.dtpNgayBatDau);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbxTrangThai);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnThemMoiDonHang);
            this.groupBox1.Controls.Add(this.btnTimKiem);
            this.groupBox1.Controls.Add(this.txtTenKh);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(0, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1057, 133);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin tìm kiếm ";
            // 
            // dtpNgayKetThuc
            // 
            this.dtpNgayKetThuc.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayKetThuc.Location = new System.Drawing.Point(514, 87);
            this.dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            this.dtpNgayKetThuc.Size = new System.Drawing.Size(207, 26);
            this.dtpNgayKetThuc.TabIndex = 15;
            // 
            // dtpNgayBatDau
            // 
            this.dtpNgayBatDau.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayBatDau.Location = new System.Drawing.Point(134, 87);
            this.dtpNgayBatDau.Name = "dtpNgayBatDau";
            this.dtpNgayBatDau.Size = new System.Drawing.Size(201, 26);
            this.dtpNgayBatDau.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(363, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Ngày kết thúc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Ngày bắt đầu ";
            // 
            // cbxTrangThai
            // 
            this.cbxTrangThai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxTrangThai.FormattingEnabled = true;
            this.cbxTrangThai.Items.AddRange(new object[] {
            "Đã tiếp nhận ",
            "Đã thanh toán ",
            "Đã hủy "});
            this.cbxTrangThai.Location = new System.Drawing.Point(134, 32);
            this.cbxTrangThai.Name = "cbxTrangThai";
            this.cbxTrangThai.Size = new System.Drawing.Size(201, 28);
            this.cbxTrangThai.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "Trạng thái ";
            // 
            // btnThemMoiDonHang
            // 
            this.btnThemMoiDonHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnThemMoiDonHang.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnThemMoiDonHang.Location = new System.Drawing.Point(923, 57);
            this.btnThemMoiDonHang.Name = "btnThemMoiDonHang";
            this.btnThemMoiDonHang.Size = new System.Drawing.Size(109, 32);
            this.btnThemMoiDonHang.TabIndex = 1;
            this.btnThemMoiDonHang.Text = "Tạo hóa đơn ";
            this.btnThemMoiDonHang.UseVisualStyleBackColor = false;
            this.btnThemMoiDonHang.Click += new System.EventHandler(this.btnThemMoiDonHang_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnTimKiem.Location = new System.Drawing.Point(775, 57);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(109, 32);
            this.btnTimKiem.TabIndex = 1;
            this.btnTimKiem.Text = "Tìm Kiếm ";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTenKh
            // 
            this.txtTenKh.Location = new System.Drawing.Point(514, 34);
            this.txtTenKh.Name = "txtTenKh";
            this.txtTenKh.Size = new System.Drawing.Size(207, 26);
            this.txtTenKh.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(363, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Khách hàng";
            // 
            // dgvHienThi
            // 
            this.dgvHienThi.BackgroundColor = System.Drawing.Color.White;
            this.dgvHienThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHienThi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clId,
            this.clNgayDatHang,
            this.clTenKhachHang,
            this.cldiachi,
            this.clsdt,
            this.clsoluongdat,
            this.cltinhtrang,
            this.clSoSerial});
            this.dgvHienThi.Location = new System.Drawing.Point(0, 34);
            this.dgvHienThi.Name = "dgvHienThi";
            this.dgvHienThi.Size = new System.Drawing.Size(1278, 303);
            this.dgvHienThi.TabIndex = 8;
            this.dgvHienThi.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHienThi_CellDoubleClick);
            // 
            // clId
            // 
            this.clId.HeaderText = "ID hóa đơn ";
            this.clId.Name = "clId";
            this.clId.Width = 170;
            // 
            // clNgayDatHang
            // 
            this.clNgayDatHang.HeaderText = "Ngày đặt hàng ";
            this.clNgayDatHang.Name = "clNgayDatHang";
            this.clNgayDatHang.Width = 170;
            // 
            // clTenKhachHang
            // 
            this.clTenKhachHang.HeaderText = "Tên khách hàng ";
            this.clTenKhachHang.Name = "clTenKhachHang";
            this.clTenKhachHang.Width = 170;
            // 
            // cldiachi
            // 
            this.cldiachi.HeaderText = "Địa chỉ ";
            this.cldiachi.Name = "cldiachi";
            this.cldiachi.Width = 170;
            // 
            // clsdt
            // 
            this.clsdt.HeaderText = "Số điện thoại ";
            this.clsdt.Name = "clsdt";
            this.clsdt.Width = 170;
            // 
            // clsoluongdat
            // 
            this.clsoluongdat.HeaderText = "Số lượng đặt ";
            this.clsoluongdat.Name = "clsoluongdat";
            this.clsoluongdat.Width = 170;
            // 
            // cltinhtrang
            // 
            this.cltinhtrang.HeaderText = "Trạng thái ";
            this.cltinhtrang.Name = "cltinhtrang";
            this.cltinhtrang.Width = 170;
            // 
            // clSoSerial
            // 
            this.clSoSerial.HeaderText = "Số serial";
            this.clSoSerial.Name = "clSoSerial";
            // 
            // btnhuy
            // 
            this.btnhuy.Location = new System.Drawing.Point(1164, 625);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(108, 34);
            this.btnhuy.TabIndex = 11;
            this.btnhuy.Text = "Hủy ";
            this.btnhuy.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvHienThi);
            this.groupBox2.Location = new System.Drawing.Point(0, 259);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1284, 343);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách ";
            // 
            // btnThemBaoHanh
            // 
            this.btnThemBaoHanh.Location = new System.Drawing.Point(942, 625);
            this.btnThemBaoHanh.Name = "btnThemBaoHanh";
            this.btnThemBaoHanh.Size = new System.Drawing.Size(183, 34);
            this.btnThemBaoHanh.TabIndex = 10;
            this.btnThemBaoHanh.Text = "Tạo bảo hành ";
            this.btnThemBaoHanh.UseVisualStyleBackColor = true;
            this.btnThemBaoHanh.Click += new System.EventHandler(this.btnThemBaoHanh_Click);
            // 
            // frmDondathang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1284, 691);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.btnThemBaoHanh);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ucMenu1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmDondathang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDondathang";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDondathang_FormClosing);
            this.Load += new System.EventHandler(this.frmDondathang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHienThi)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ucMenu ucMenu1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTenKh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvHienThi;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThemMoiDonHang;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnThemBaoHanh;
        private System.Windows.Forms.ComboBox cbxTrangThai;
        private System.Windows.Forms.DateTimePicker dtpNgayKetThuc;
        private System.Windows.Forms.DateTimePicker dtpNgayBatDau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn clId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNgayDatHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn cldiachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clsdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn clsoluongdat;
        private System.Windows.Forms.DataGridViewTextBoxColumn cltinhtrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSoSerial;
    }
}