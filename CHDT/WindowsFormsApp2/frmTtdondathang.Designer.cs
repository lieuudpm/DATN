namespace WindowsFormsApp2
{
    partial class frmTtdondathang
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbnu = new System.Windows.Forms.RadioButton();
            this.rdbnam = new System.Windows.Forms.RadioButton();
            this.txtmaKH = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvdondathang = new System.Windows.Forms.DataGridView();
            this.clmahd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clngaydat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cltenkh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cldiachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clsdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clsoluongdat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cltongtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cltinhtrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.btnquaylai = new System.Windows.Forms.Button();
            this.btnxoaHD = new System.Windows.Forms.Button();
            this.btnsuaHD = new System.Windows.Forms.Button();
            this.btnthemHD = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdondathang)).BeginInit();
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
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(567, 255);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đơn đặt hàng ";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(198, 91);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(311, 26);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(42, 165);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(510, 84);
            this.textBox3.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(198, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(311, 26);
            this.textBox1.TabIndex = 2;
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
            this.label3.Location = new System.Drawing.Point(38, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày đặt hàng:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbnu);
            this.groupBox2.Controls.Add(this.rdbnam);
            this.groupBox2.Controls.Add(this.txtmaKH);
            this.groupBox2.Controls.Add(this.textBox7);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBox6);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(708, 119);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(557, 255);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin khách hàng ";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // rdbnu
            // 
            this.rdbnu.AutoSize = true;
            this.rdbnu.Location = new System.Drawing.Point(299, 118);
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
            this.rdbnam.Location = new System.Drawing.Point(198, 118);
            this.rdbnam.Name = "rdbnam";
            this.rdbnam.Size = new System.Drawing.Size(60, 24);
            this.rdbnam.TabIndex = 3;
            this.rdbnam.TabStop = true;
            this.rdbnam.Text = "Nam";
            this.rdbnam.UseVisualStyleBackColor = true;
            // 
            // txtmaKH
            // 
            this.txtmaKH.Location = new System.Drawing.Point(198, 42);
            this.txtmaKH.Name = "txtmaKH";
            this.txtmaKH.Size = new System.Drawing.Size(302, 26);
            this.txtmaKH.TabIndex = 2;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(198, 153);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(302, 26);
            this.textBox7.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tên khách hàng: ";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(198, 190);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(302, 26);
            this.textBox6.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(47, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "Mã khách hàng:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(47, 156);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Địa chỉ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Giới tính:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(198, 79);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(302, 26);
            this.textBox5.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(47, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = " Số điện thoại: ";
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
            this.dgvdondathang.Location = new System.Drawing.Point(3, 452);
            this.dgvdondathang.Name = "dgvdondathang";
            this.dgvdondathang.Size = new System.Drawing.Size(1269, 228);
            this.dgvdondathang.TabIndex = 10;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-1, 429);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Danh sách:";
            // 
            // btnquaylai
            // 
            this.btnquaylai.Location = new System.Drawing.Point(1146, 396);
            this.btnquaylai.Name = "btnquaylai";
            this.btnquaylai.Size = new System.Drawing.Size(119, 36);
            this.btnquaylai.TabIndex = 14;
            this.btnquaylai.Text = "Quay lại ";
            this.btnquaylai.UseVisualStyleBackColor = true;
            // 
            // btnxoaHD
            // 
            this.btnxoaHD.Location = new System.Drawing.Point(1021, 396);
            this.btnxoaHD.Name = "btnxoaHD";
            this.btnxoaHD.Size = new System.Drawing.Size(119, 36);
            this.btnxoaHD.TabIndex = 14;
            this.btnxoaHD.Text = "Xóa";
            this.btnxoaHD.UseVisualStyleBackColor = true;
            // 
            // btnsuaHD
            // 
            this.btnsuaHD.Location = new System.Drawing.Point(891, 396);
            this.btnsuaHD.Name = "btnsuaHD";
            this.btnsuaHD.Size = new System.Drawing.Size(119, 36);
            this.btnsuaHD.TabIndex = 14;
            this.btnsuaHD.Text = "Sửa";
            this.btnsuaHD.UseVisualStyleBackColor = true;
            // 
            // btnthemHD
            // 
            this.btnthemHD.Location = new System.Drawing.Point(766, 396);
            this.btnthemHD.Name = "btnthemHD";
            this.btnthemHD.Size = new System.Drawing.Size(119, 36);
            this.btnthemHD.TabIndex = 14;
            this.btnthemHD.Text = "Thêm ";
            this.btnthemHD.UseVisualStyleBackColor = true;
            this.btnthemHD.Click += new System.EventHandler(this.btnthemHD_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(431, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 31);
            this.label1.TabIndex = 15;
            this.label1.Text = "THÔNG TIN ĐƠN ĐẶT HÀNG ";
            // 
            // frmTtdondathang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1284, 691);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnthemHD);
            this.Controls.Add(this.btnsuaHD);
            this.Controls.Add(this.btnxoaHD);
            this.Controls.Add(this.btnquaylai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvdondathang);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ucMenu1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmTtdondathang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTtdondathang";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTtdondathang_FormClosing);
            this.Load += new System.EventHandler(this.frmTtdondathang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdondathang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ucMenu ucMenu1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvdondathang;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmahd;
        private System.Windows.Forms.DataGridViewTextBoxColumn clngaydat;
        private System.Windows.Forms.DataGridViewTextBoxColumn cltenkh;
        private System.Windows.Forms.DataGridViewTextBoxColumn cldiachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clsdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn clsoluongdat;
        private System.Windows.Forms.DataGridViewTextBoxColumn cltongtien;
        private System.Windows.Forms.DataGridViewTextBoxColumn cltinhtrang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnquaylai;
        private System.Windows.Forms.Button btnxoaHD;
        private System.Windows.Forms.Button btnsuaHD;
        private System.Windows.Forms.Button btnthemHD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmaKH;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rdbnu;
        private System.Windows.Forms.RadioButton rdbnam;
    }
}