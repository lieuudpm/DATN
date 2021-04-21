namespace WindowsFormsApp2
{
    partial class frmThemMoiDonDatHang
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpNgayDatHang = new System.Windows.Forms.DateTimePicker();
            this.cbxTrangThai = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbnu = new System.Windows.Forms.RadioButton();
            this.rdbnam = new System.Windows.Forms.RadioButton();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSoDt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvHienThi = new System.Windows.Forms.DataGridView();
            this.clId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNgayDatHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cldiachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSoDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTongSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTongsotien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTrangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnquaylai = new System.Windows.Forms.Button();
            this.btnxoaHD = new System.Windows.Forms.Button();
            this.btnsuaHD = new System.Windows.Forms.Button();
            this.btnthemHD = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnTaoHoaDon = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHienThi)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpNgayDatHang);
            this.groupBox1.Controls.Add(this.cbxTrangThai);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(567, 255);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đơn đặt hàng ";
            // 
            // dtpNgayDatHang
            // 
            this.dtpNgayDatHang.CustomFormat = "dd/mm/yyyy HH:mm:ss";
            this.dtpNgayDatHang.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayDatHang.Location = new System.Drawing.Point(198, 45);
            this.dtpNgayDatHang.Name = "dtpNgayDatHang";
            this.dtpNgayDatHang.Size = new System.Drawing.Size(262, 26);
            this.dtpNgayDatHang.TabIndex = 6;
            // 
            // cbxTrangThai
            // 
            this.cbxTrangThai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxTrangThai.FormattingEnabled = true;
            this.cbxTrangThai.Items.AddRange(new object[] {
            "Đã tiếp nhận ",
            "Đã thanh toán ",
            "Đã hủy "});
            this.cbxTrangThai.Location = new System.Drawing.Point(198, 89);
            this.cbxTrangThai.Name = "cbxTrangThai";
            this.cbxTrangThai.Size = new System.Drawing.Size(279, 28);
            this.cbxTrangThai.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(42, 165);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(510, 84);
            this.textBox3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Trạng  thái: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ghi chú:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày đặt hàng:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbnu);
            this.groupBox2.Controls.Add(this.rdbnam);
            this.groupBox2.Controls.Add(this.txtDiaChi);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtSoDt);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtTenKhachHang);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(641, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(557, 255);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin khách hàng ";
            // 
            // rdbnu
            // 
            this.rdbnu.AutoSize = true;
            this.rdbnu.Location = new System.Drawing.Point(298, 99);
            this.rdbnu.Name = "rdbnu";
            this.rdbnu.Size = new System.Drawing.Size(47, 24);
            this.rdbnu.TabIndex = 3;
            this.rdbnu.TabStop = true;
            this.rdbnu.Text = "Nữ";
            this.rdbnu.UseVisualStyleBackColor = true;
            // 
            // rdbnam
            // 
            this.rdbnam.AutoSize = true;
            this.rdbnam.Location = new System.Drawing.Point(197, 99);
            this.rdbnam.Name = "rdbnam";
            this.rdbnam.Size = new System.Drawing.Size(60, 24);
            this.rdbnam.TabIndex = 3;
            this.rdbnam.TabStop = true;
            this.rdbnam.Text = "Nam";
            this.rdbnam.UseVisualStyleBackColor = true;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(197, 134);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(302, 26);
            this.txtDiaChi.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tên khách hàng: ";
            // 
            // txtSoDt
            // 
            this.txtSoDt.Location = new System.Drawing.Point(197, 171);
            this.txtSoDt.Name = "txtSoDt";
            this.txtSoDt.Size = new System.Drawing.Size(302, 26);
            this.txtSoDt.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(46, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Địa chỉ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Giới tính:";
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Location = new System.Drawing.Point(197, 60);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(302, 26);
            this.txtTenKhachHang.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = " Số điện thoại: ";
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
            this.clSoDT,
            this.clTongSoLuong,
            this.clTongsotien,
            this.clTrangthai});
            this.dgvHienThi.Location = new System.Drawing.Point(6, 62);
            this.dgvHienThi.Name = "dgvHienThi";
            this.dgvHienThi.Size = new System.Drawing.Size(1203, 175);
            this.dgvHienThi.TabIndex = 10;
            // 
            // clId
            // 
            this.clId.HeaderText = "ID đơn hàng ";
            this.clId.Name = "clId";
            this.clId.Width = 150;
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
            // clSoDT
            // 
            this.clSoDT.HeaderText = "Số điện thoại ";
            this.clSoDT.Name = "clSoDT";
            this.clSoDT.Width = 170;
            // 
            // clTongSoLuong
            // 
            this.clTongSoLuong.HeaderText = "Số lượng đặt ";
            this.clTongSoLuong.Name = "clTongSoLuong";
            this.clTongSoLuong.Width = 170;
            // 
            // clTongsotien
            // 
            this.clTongsotien.HeaderText = "Tổng tiền ";
            this.clTongsotien.Name = "clTongsotien";
            this.clTongsotien.Width = 170;
            // 
            // clTrangthai
            // 
            this.clTrangthai.HeaderText = "Trạng thái ";
            this.clTrangthai.Name = "clTrangthai";
            this.clTrangthai.Width = 170;
            // 
            // btnquaylai
            // 
            this.btnquaylai.Location = new System.Drawing.Point(1079, 643);
            this.btnquaylai.Name = "btnquaylai";
            this.btnquaylai.Size = new System.Drawing.Size(119, 36);
            this.btnquaylai.TabIndex = 14;
            this.btnquaylai.Text = "Quay lại ";
            this.btnquaylai.UseVisualStyleBackColor = true;
            this.btnquaylai.Click += new System.EventHandler(this.btnquaylai_Click);
            // 
            // btnxoaHD
            // 
            this.btnxoaHD.Location = new System.Drawing.Point(397, 25);
            this.btnxoaHD.Name = "btnxoaHD";
            this.btnxoaHD.Size = new System.Drawing.Size(119, 31);
            this.btnxoaHD.TabIndex = 14;
            this.btnxoaHD.Text = "Xóa";
            this.btnxoaHD.UseVisualStyleBackColor = true;
            // 
            // btnsuaHD
            // 
            this.btnsuaHD.Location = new System.Drawing.Point(258, 25);
            this.btnsuaHD.Name = "btnsuaHD";
            this.btnsuaHD.Size = new System.Drawing.Size(119, 31);
            this.btnsuaHD.TabIndex = 14;
            this.btnsuaHD.Text = "Sửa";
            this.btnsuaHD.UseVisualStyleBackColor = true;
            // 
            // btnthemHD
            // 
            this.btnthemHD.Location = new System.Drawing.Point(29, 25);
            this.btnthemHD.Name = "btnthemHD";
            this.btnthemHD.Size = new System.Drawing.Size(209, 31);
            this.btnthemHD.TabIndex = 14;
            this.btnthemHD.Text = "Thêm thông tin";
            this.btnthemHD.UseVisualStyleBackColor = true;
            this.btnthemHD.Click += new System.EventHandler(this.btnthemHD_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(437, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 31);
            this.label1.TabIndex = 15;
            this.label1.Text = "THÔNG TIN ĐƠN ĐẶT HÀNG ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvHienThi);
            this.groupBox3.Controls.Add(this.btnthemHD);
            this.groupBox3.Controls.Add(this.btnsuaHD);
            this.groupBox3.Controls.Add(this.btnxoaHD);
            this.groupBox3.Location = new System.Drawing.Point(12, 387);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1215, 244);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // btnTaoHoaDon
            // 
            this.btnTaoHoaDon.Location = new System.Drawing.Point(917, 648);
            this.btnTaoHoaDon.Name = "btnTaoHoaDon";
            this.btnTaoHoaDon.Size = new System.Drawing.Size(119, 31);
            this.btnTaoHoaDon.TabIndex = 14;
            this.btnTaoHoaDon.Text = "Tạo hóa đơn ";
            this.btnTaoHoaDon.UseVisualStyleBackColor = true;
            this.btnTaoHoaDon.Click += new System.EventHandler(this.btnTaoHoaDon_Click);
            // 
            // frmThemMoiDonDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1231, 691);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTaoHoaDon);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnquaylai);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmThemMoiDonDatHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmThemMoiDonDatHang";
         //   this.Load += new System.EventHandler(this.trmThemMoiDonDatHang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHienThi)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSoDt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvHienThi;
        private System.Windows.Forms.Button btnquaylai;
        private System.Windows.Forms.Button btnxoaHD;
        private System.Windows.Forms.Button btnsuaHD;
        private System.Windows.Forms.Button btnthemHD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rdbnu;
        private System.Windows.Forms.RadioButton rdbnam;
        private System.Windows.Forms.ComboBox cbxTrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn clId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNgayDatHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn cldiachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSoDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTongSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTongsotien;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTrangthai;
        private System.Windows.Forms.DateTimePicker dtpNgayDatHang;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnTaoHoaDon;
    }
}