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
            this.cbxTinhtrang = new System.Windows.Forms.ComboBox();
            this.btnapdungMHD = new System.Windows.Forms.Button();
            this.txtnhapmaHD = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvdondathang = new System.Windows.Forms.DataGridView();
            this.clmahd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clngaydat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cltenkh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cldiachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clsdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clsoluongdat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cltongtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cltinhtrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnxacnhan = new System.Windows.Forms.Button();
            this.btnhuy = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdondathang)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucMenu1
            // 
            this.ucMenu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ucMenu1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucMenu1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucMenu1.Location = new System.Drawing.Point(0, 0);
            this.ucMenu1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucMenu1.Name = "ucMenu1";
            this.ucMenu1.Size = new System.Drawing.Size(1284, 43);
            this.ucMenu1.TabIndex = 0;
            this.ucMenu1.Load += new System.EventHandler(this.ucMenu1_Load);
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
            this.groupBox1.Controls.Add(this.cbxTinhtrang);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnapdungMHD);
            this.groupBox1.Controls.Add(this.txtnhapmaHD);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(0, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(967, 101);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin tìm kiếm ";
            // 
            // cbxTinhtrang
            // 
            this.cbxTinhtrang.FormattingEnabled = true;
            this.cbxTinhtrang.Location = new System.Drawing.Point(16, 56);
            this.cbxTinhtrang.Name = "cbxTinhtrang";
            this.cbxTinhtrang.Size = new System.Drawing.Size(186, 28);
            this.cbxTinhtrang.TabIndex = 3;
            // 
            // btnapdungMHD
            // 
            this.btnapdungMHD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnapdungMHD.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnapdungMHD.Location = new System.Drawing.Point(635, 36);
            this.btnapdungMHD.Name = "btnapdungMHD";
            this.btnapdungMHD.Size = new System.Drawing.Size(109, 37);
            this.btnapdungMHD.TabIndex = 1;
            this.btnapdungMHD.Text = "Áp Dụng";
            this.btnapdungMHD.UseVisualStyleBackColor = false;
            this.btnapdungMHD.Click += new System.EventHandler(this.btnapdungMHD_Click);
            // 
            // txtnhapmaHD
            // 
            this.txtnhapmaHD.Location = new System.Drawing.Point(322, 56);
            this.txtnhapmaHD.Name = "txtnhapmaHD";
            this.txtnhapmaHD.Size = new System.Drawing.Size(232, 26);
            this.txtnhapmaHD.TabIndex = 0;
            this.txtnhapmaHD.TextChanged += new System.EventHandler(this.txtnhapmaHD_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tình trạng đơn hàng ";
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(322, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhập mã hóa đơn:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dgvdondathang
            // 
            this.dgvdondathang.BackgroundColor = System.Drawing.Color.White;
            this.dgvdondathang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdondathang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmahd,
            this.clngaydat,
            this.cltenkh,
            this.cldiachi,
            this.clsdt,
            this.clsoluongdat,
            this.cltongtien,
            this.cltinhtrang});
            this.dgvdondathang.Location = new System.Drawing.Point(0, 34);
            this.dgvdondathang.Name = "dgvdondathang";
            this.dgvdondathang.Size = new System.Drawing.Size(1278, 303);
            this.dgvdondathang.TabIndex = 8;
            this.dgvdondathang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdondathang_CellContentClick);
            // 
            // clmahd
            // 
            this.clmahd.HeaderText = "Mã số hóa đơn ";
            this.clmahd.Name = "clmahd";
            this.clmahd.Width = 170;
            // 
            // clngaydat
            // 
            this.clngaydat.HeaderText = "Ngày đặt hàng ";
            this.clngaydat.Name = "clngaydat";
            this.clngaydat.Width = 170;
            // 
            // cltenkh
            // 
            this.cltenkh.HeaderText = "Tên khách hàng ";
            this.cltenkh.Name = "cltenkh";
            this.cltenkh.Width = 170;
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
            this.btnxacnhan.Location = new System.Drawing.Point(859, 624);
            this.btnxacnhan.Name = "btnxacnhan";
            this.btnxacnhan.Size = new System.Drawing.Size(182, 35);
            this.btnxacnhan.TabIndex = 10;
            this.btnxacnhan.Text = "Xác nhận đơn hàng ";
            this.btnxacnhan.UseVisualStyleBackColor = true;
            // 
            // btnhuy
            // 
            this.btnhuy.Location = new System.Drawing.Point(1059, 624);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(108, 35);
            this.btnhuy.TabIndex = 11;
            this.btnhuy.Text = "Hủy ";
            this.btnhuy.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvdondathang);
            this.groupBox2.Location = new System.Drawing.Point(0, 259);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1284, 343);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(795, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Thêm mới ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnapdungMHD_Click);
            // 
            // frmDondathang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1284, 691);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnhuy);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvdondathang)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvdondathang;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmahd;
        private System.Windows.Forms.DataGridViewTextBoxColumn clngaydat;
        private System.Windows.Forms.DataGridViewTextBoxColumn cltenkh;
        private System.Windows.Forms.DataGridViewTextBoxColumn cldiachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clsdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn clsoluongdat;
        private System.Windows.Forms.DataGridViewTextBoxColumn cltongtien;
        private System.Windows.Forms.DataGridViewTextBoxColumn cltinhtrang;
        private System.Windows.Forms.Button btnxacnhan;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.ComboBox cbxTinhtrang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
    }
}