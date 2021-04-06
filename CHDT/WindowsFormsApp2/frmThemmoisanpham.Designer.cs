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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnThemnv = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvHienThi = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clTinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGiaSale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clBaoHanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsNhomHang = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clStt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTieuDe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clThongso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNhom = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cmsLoai = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsHang = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHienThi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.cmsNhomHang.SuspendLayout();
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
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 582);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ảnh sản phẩm ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.numericUpDown1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(342, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(930, 207);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin cơ bản";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(342, 453);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(930, 185);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông số kỹ thuật ";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên sản phẩm";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(141, 25);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(764, 33);
            this.textBox1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(729, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số lượng";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(807, 69);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(98, 26);
            this.numericUpDown1.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(413, 68);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(197, 28);
            this.comboBox1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(359, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Hãng";
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
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(73, 68);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(173, 28);
            this.comboBox2.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(25, 133);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(880, 58);
            this.textBox2.TabIndex = 2;
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
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clStt,
            this.clTieuDe,
            this.clThongso,
            this.clNhom});
            this.dataGridView1.Location = new System.Drawing.Point(25, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(880, 139);
            this.dataGridView1.TabIndex = 1;
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
            // cmsLoai
            // 
            this.cmsLoai.Name = "cmsLoai";
            this.cmsLoai.Size = new System.Drawing.Size(61, 4);
            // 
            // cmsHang
            // 
            this.cmsHang.Name = "cmsHang";
            this.cmsHang.Size = new System.Drawing.Size(181, 26);
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
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHienThi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.cmsNhomHang.ResumeLayout(false);
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
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
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
    }
}