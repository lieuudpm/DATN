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
            this.ucMenu1 = new WindowsFormsApp2.ucMenu();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtghichu = new System.Windows.Forms.TextBox();
            this.txttrangthai = new System.Windows.Forms.TextBox();
            this.txtngaynhaphang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtsonhacungcap = new System.Windows.Forms.TextBox();
            this.txttennhacungcap = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvQldonhangnhap = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btntaohoadonnhap = new System.Windows.Forms.Button();
            this.btnHuytao = new System.Windows.Forms.Button();
            this.clMasp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTensp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMahang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clHinhanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQldonhangnhap)).BeginInit();
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
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtghichu);
            this.groupBox1.Controls.Add(this.txttrangthai);
            this.groupBox1.Controls.Add(this.txtngaynhaphang);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(28, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 295);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đơn hàng ";
            // 
            // txtghichu
            // 
            this.txtghichu.Location = new System.Drawing.Point(43, 163);
            this.txtghichu.Multiline = true;
            this.txtghichu.Name = "txtghichu";
            this.txtghichu.Size = new System.Drawing.Size(524, 85);
            this.txtghichu.TabIndex = 4;
            // 
            // txttrangthai
            // 
            this.txttrangthai.Location = new System.Drawing.Point(206, 98);
            this.txttrangthai.Name = "txttrangthai";
            this.txttrangthai.Size = new System.Drawing.Size(289, 26);
            this.txttrangthai.TabIndex = 4;
            // 
            // txtngaynhaphang
            // 
            this.txtngaynhaphang.Location = new System.Drawing.Point(206, 54);
            this.txtngaynhaphang.Name = "txtngaynhaphang";
            this.txtngaynhaphang.Size = new System.Drawing.Size(289, 26);
            this.txtngaynhaphang.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ghi chú:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Trạng thái:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ngày nhập hàng: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.txtdiachi);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtsonhacungcap);
            this.groupBox2.Controls.Add(this.txttennhacungcap);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(669, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(591, 295);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin nhà cung cấp ";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(201, 186);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(286, 26);
            this.txtEmail.TabIndex = 4;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(201, 94);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(286, 26);
            this.txtdiachi.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Email:";
            // 
            // txtsonhacungcap
            // 
            this.txtsonhacungcap.Location = new System.Drawing.Point(201, 140);
            this.txtsonhacungcap.Name = "txtsonhacungcap";
            this.txtsonhacungcap.Size = new System.Drawing.Size(286, 26);
            this.txtsonhacungcap.TabIndex = 3;
            // 
            // txttennhacungcap
            // 
            this.txttennhacungcap.Location = new System.Drawing.Point(201, 48);
            this.txttennhacungcap.Name = "txttennhacungcap";
            this.txttennhacungcap.Size = new System.Drawing.Size(286, 26);
            this.txttennhacungcap.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Số điện thoại:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên nhà cung cấp:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Địa chỉ:";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.dgvQldonhangnhap);
            this.groupBox3.Controls.Add(this.btnThem);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(28, 385);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1232, 250);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin sản phẩm ";
            // 
            // dgvQldonhangnhap
            // 
            this.dgvQldonhangnhap.BackgroundColor = System.Drawing.Color.White;
            this.dgvQldonhangnhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQldonhangnhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMasp,
            this.clTensp,
            this.clMahang,
            this.clTenhang,
            this.clHinhanh,
            this.clMota});
            this.dgvQldonhangnhap.Location = new System.Drawing.Point(6, 101);
            this.dgvQldonhangnhap.Name = "dgvQldonhangnhap";
            this.dgvQldonhangnhap.Size = new System.Drawing.Size(1220, 136);
            this.dgvQldonhangnhap.TabIndex = 2;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(17, 34);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(121, 30);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Danh sách: ";
            // 
            // btntaohoadonnhap
            // 
            this.btntaohoadonnhap.Location = new System.Drawing.Point(920, 645);
            this.btntaohoadonnhap.Name = "btntaohoadonnhap";
            this.btntaohoadonnhap.Size = new System.Drawing.Size(146, 34);
            this.btntaohoadonnhap.TabIndex = 4;
            this.btntaohoadonnhap.Text = "Tạo hóa đơn ";
            this.btntaohoadonnhap.UseVisualStyleBackColor = true;
            this.btntaohoadonnhap.Click += new System.EventHandler(this.btntaohoadonnhap_Click);
            // 
            // btnHuytao
            // 
            this.btnHuytao.Location = new System.Drawing.Point(1112, 645);
            this.btnHuytao.Name = "btnHuytao";
            this.btnHuytao.Size = new System.Drawing.Size(97, 34);
            this.btnHuytao.TabIndex = 4;
            this.btnHuytao.Text = "Hủy ";
            this.btnHuytao.UseVisualStyleBackColor = true;
            // 
            // clMasp
            // 
            this.clMasp.HeaderText = "Mã sản phẩm ";
            this.clMasp.Name = "clMasp";
            this.clMasp.Width = 200;
            // 
            // clTensp
            // 
            this.clTensp.HeaderText = "Tên sản phẩm ";
            this.clTensp.Name = "clTensp";
            this.clTensp.Width = 200;
            // 
            // clMahang
            // 
            this.clMahang.HeaderText = "Mã hãng sản xuất ";
            this.clMahang.Name = "clMahang";
            this.clMahang.Width = 200;
            // 
            // clTenhang
            // 
            this.clTenhang.HeaderText = "Tên hãng ";
            this.clTenhang.Name = "clTenhang";
            this.clTenhang.Width = 200;
            // 
            // clHinhanh
            // 
            this.clHinhanh.HeaderText = "Hình ảnh ";
            this.clHinhanh.Name = "clHinhanh";
            this.clHinhanh.Width = 200;
            // 
            // clMota
            // 
            this.clMota.HeaderText = "Mô tả";
            this.clMota.Name = "clMota";
            this.clMota.Width = 200;
            // 
            // frmQldonhangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1284, 691);
            this.Controls.Add(this.btnHuytao);
            this.Controls.Add(this.btntaohoadonnhap);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ucMenu1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmQldonhangnhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmQldonhangnhap";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmQldonhangnhap_FormClosing);
            this.Load += new System.EventHandler(this.frmQldonhangnhap_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQldonhangnhap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ucMenu ucMenu1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txttrangthai;
        private System.Windows.Forms.TextBox txtngaynhaphang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtghichu;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox txtsonhacungcap;
        private System.Windows.Forms.TextBox txttennhacungcap;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvQldonhangnhap;
        private System.Windows.Forms.Button btntaohoadonnhap;
        private System.Windows.Forms.Button btnHuytao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMasp;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTensp;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMahang;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn clHinhanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMota;
    }
}