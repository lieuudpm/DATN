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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnThemMoiDonHang = new System.Windows.Forms.Button();
            this.btnapdungMHD = new System.Windows.Forms.Button();
            this.txtnhapmaHD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvHienThi = new System.Windows.Forms.DataGridView();
            this.clId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNgayDatHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cldiachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clsdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clsoluongdat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cltongtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cltinhtrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnxacnhan = new System.Windows.Forms.Button();
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
            this.ucMenu1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnThemMoiDonHang);
            this.groupBox1.Controls.Add(this.btnapdungMHD);
            this.groupBox1.Controls.Add(this.txtnhapmaHD);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(0, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(811, 133);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin tìm kiếm ";
            // 
            // comboBox1
            // 
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Chưa tiếp nhận ",
            "Đã tiếp nhận ",
            "Đã thanh toán ",
            "Đã hủy "});
            this.comboBox1.Location = new System.Drawing.Point(176, 45);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(279, 28);
            this.comboBox1.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "Trạng thái ";
            // 
            // btnThemMoiDonHang
            // 
            this.btnThemMoiDonHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnThemMoiDonHang.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnThemMoiDonHang.Location = new System.Drawing.Point(635, 89);
            this.btnThemMoiDonHang.Name = "btnThemMoiDonHang";
            this.btnThemMoiDonHang.Size = new System.Drawing.Size(109, 32);
            this.btnThemMoiDonHang.TabIndex = 1;
            this.btnThemMoiDonHang.Text = "Thêm mới ";
            this.btnThemMoiDonHang.UseVisualStyleBackColor = false;
            this.btnThemMoiDonHang.Click += new System.EventHandler(this.btnThemMoiDonHang_Click);
            // 
            // btnapdungMHD
            // 
            this.btnapdungMHD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnapdungMHD.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnapdungMHD.Location = new System.Drawing.Point(635, 41);
            this.btnapdungMHD.Name = "btnapdungMHD";
            this.btnapdungMHD.Size = new System.Drawing.Size(109, 32);
            this.btnapdungMHD.TabIndex = 1;
            this.btnapdungMHD.Text = "Áp Dụng";
            this.btnapdungMHD.UseVisualStyleBackColor = false;
            this.btnapdungMHD.Click += new System.EventHandler(this.btnapdungMHD_Click);
            // 
            // txtnhapmaHD
            // 
            this.txtnhapmaHD.Location = new System.Drawing.Point(176, 89);
            this.txtnhapmaHD.Name = "txtnhapmaHD";
            this.txtnhapmaHD.Size = new System.Drawing.Size(369, 26);
            this.txtnhapmaHD.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhập mã hóa đơn:";
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
            this.cltongtien,
            this.cltinhtrang});
            this.dgvHienThi.Location = new System.Drawing.Point(0, 34);
            this.dgvHienThi.Name = "dgvHienThi";
            this.dgvHienThi.Size = new System.Drawing.Size(1278, 303);
            this.dgvHienThi.TabIndex = 8;
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
            // cltongtien
            // 
            this.cltongtien.HeaderText = "Tổng tiền ";
            this.cltongtien.Name = "cltongtien";
            this.cltongtien.Width = 170;
            // 
            // cltinhtrang
            // 
            this.cltinhtrang.HeaderText = "Trạng thái ";
            this.cltinhtrang.Name = "cltinhtrang";
            this.cltinhtrang.Width = 170;
            // 
            // btnxacnhan
            // 
            this.btnxacnhan.Location = new System.Drawing.Point(964, 624);
            this.btnxacnhan.Name = "btnxacnhan";
            this.btnxacnhan.Size = new System.Drawing.Size(174, 35);
            this.btnxacnhan.TabIndex = 10;
            this.btnxacnhan.Text = "Xác nhận đơn hàng ";
            this.btnxacnhan.UseVisualStyleBackColor = true;
            // 
            // btnhuy
            // 
            this.btnhuy.Location = new System.Drawing.Point(1164, 624);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(108, 35);
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
            this.btnThemBaoHanh.Location = new System.Drawing.Point(749, 624);
            this.btnThemBaoHanh.Name = "btnThemBaoHanh";
            this.btnThemBaoHanh.Size = new System.Drawing.Size(183, 35);
            this.btnThemBaoHanh.TabIndex = 10;
            this.btnThemBaoHanh.Text = "Thêm bảo hành ";
            this.btnThemBaoHanh.UseVisualStyleBackColor = true;
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
            this.Controls.Add(this.btnxacnhan);
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
        private System.Windows.Forms.Button btnapdungMHD;
        private System.Windows.Forms.TextBox txtnhapmaHD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvHienThi;
        private System.Windows.Forms.Button btnxacnhan;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThemMoiDonHang;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnThemBaoHanh;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNgayDatHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn cldiachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clsdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn clsoluongdat;
        private System.Windows.Forms.DataGridViewTextBoxColumn cltongtien;
        private System.Windows.Forms.DataGridViewTextBoxColumn cltinhtrang;
    }
}