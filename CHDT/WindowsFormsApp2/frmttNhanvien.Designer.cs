namespace WindowsFormsApp2
{
    partial class frmttNhanvien
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnthemNV = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTennv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.txtsoCMNN = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnsuaNV = new System.Windows.Forms.Button();
            this.btnXoanv = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.rdbNvnu = new System.Windows.Forms.RadioButton();
            this.rdbNvnam = new System.Windows.Forms.RadioButton();
            this.ckxTrangthai = new System.Windows.Forms.CheckBox();
            this.cbxquyenhan = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(174, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin nhân viên ";
            // 
            // btnthemNV
            // 
            this.btnthemNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnthemNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnthemNV.Location = new System.Drawing.Point(38, 460);
            this.btnthemNV.Name = "btnthemNV";
            this.btnthemNV.Size = new System.Drawing.Size(108, 33);
            this.btnthemNV.TabIndex = 3;
            this.btnthemNV.Text = "Thêm mới";
            this.btnthemNV.UseVisualStyleBackColor = false;
            this.btnthemNV.Click += new System.EventHandler(this.btnthemNV_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên nhân viên: ";
            // 
            // txtTennv
            // 
            this.txtTennv.Location = new System.Drawing.Point(178, 105);
            this.txtTennv.Name = "txtTennv";
            this.txtTennv.Size = new System.Drawing.Size(339, 26);
            this.txtTennv.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Giới tính:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Địa chỉ:";
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(178, 191);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(339, 26);
            this.txtdiachi.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Số điện thoại: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Số CMND:";
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(178, 235);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(339, 26);
            this.txtsdt.TabIndex = 2;
            // 
            // txtsoCMNN
            // 
            this.txtsoCMNN.Location = new System.Drawing.Point(178, 279);
            this.txtsoCMNN.Name = "txtsoCMNN";
            this.txtsoCMNN.Size = new System.Drawing.Size(339, 26);
            this.txtsoCMNN.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(60, 325);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Email:";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(178, 323);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(339, 26);
            this.txtemail.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(60, 369);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "Quyền hạn:";
            // 
            // btnsuaNV
            // 
            this.btnsuaNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnsuaNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsuaNV.Location = new System.Drawing.Point(165, 460);
            this.btnsuaNV.Name = "btnsuaNV";
            this.btnsuaNV.Size = new System.Drawing.Size(103, 33);
            this.btnsuaNV.TabIndex = 3;
            this.btnsuaNV.Text = "Sửa ";
            this.btnsuaNV.UseVisualStyleBackColor = false;
            this.btnsuaNV.Click += new System.EventHandler(this.btnsuaNV_Click);
            // 
            // btnXoanv
            // 
            this.btnXoanv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnXoanv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoanv.Location = new System.Drawing.Point(290, 460);
            this.btnXoanv.Name = "btnXoanv";
            this.btnXoanv.Size = new System.Drawing.Size(109, 33);
            this.btnXoanv.TabIndex = 3;
            this.btnXoanv.Text = "Xóa ";
            this.btnXoanv.UseVisualStyleBackColor = false;
            this.btnXoanv.Click += new System.EventHandler(this.btnXoanv_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Location = new System.Drawing.Point(431, 460);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(107, 33);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Quay lại ";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(60, 413);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 20);
            this.label11.TabIndex = 1;
            this.label11.Text = "Trạng thái: ";
            // 
            // rdbNvnu
            // 
            this.rdbNvnu.AutoSize = true;
            this.rdbNvnu.Location = new System.Drawing.Point(278, 149);
            this.rdbNvnu.Name = "rdbNvnu";
            this.rdbNvnu.Size = new System.Drawing.Size(47, 24);
            this.rdbNvnu.TabIndex = 4;
            this.rdbNvnu.Text = "Nữ";
            this.rdbNvnu.UseVisualStyleBackColor = true;
            // 
            // rdbNvnam
            // 
            this.rdbNvnam.AutoSize = true;
            this.rdbNvnam.Checked = true;
            this.rdbNvnam.Location = new System.Drawing.Point(178, 149);
            this.rdbNvnam.Name = "rdbNvnam";
            this.rdbNvnam.Size = new System.Drawing.Size(60, 24);
            this.rdbNvnam.TabIndex = 5;
            this.rdbNvnam.TabStop = true;
            this.rdbNvnam.Text = "Nam";
            this.rdbNvnam.UseVisualStyleBackColor = true;
            // 
            // ckxTrangthai
            // 
            this.ckxTrangthai.AutoSize = true;
            this.ckxTrangthai.Checked = true;
            this.ckxTrangthai.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckxTrangthai.Location = new System.Drawing.Point(178, 413);
            this.ckxTrangthai.Name = "ckxTrangthai";
            this.ckxTrangthai.Size = new System.Drawing.Size(110, 24);
            this.ckxTrangthai.TabIndex = 6;
            this.ckxTrangthai.Text = "Hoạt Động ";
            this.ckxTrangthai.UseVisualStyleBackColor = true;
            // 
            // cbxquyenhan
            // 
            this.cbxquyenhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxquyenhan.FormattingEnabled = true;
            this.cbxquyenhan.Items.AddRange(new object[] {
            "Admin",
            "Nhân viên bán hàng ",
            "Nhân viên kế toán",
            "Nhân viên kho "});
            this.cbxquyenhan.Location = new System.Drawing.Point(178, 367);
            this.cbxquyenhan.Name = "cbxquyenhan";
            this.cbxquyenhan.Size = new System.Drawing.Size(339, 28);
            this.cbxquyenhan.TabIndex = 7;
            // 
            // frmttNhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(576, 532);
            this.Controls.Add(this.cbxquyenhan);
            this.Controls.Add(this.ckxTrangthai);
            this.Controls.Add(this.rdbNvnu);
            this.Controls.Add(this.rdbNvnam);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoanv);
            this.Controls.Add(this.btnsuaNV);
            this.Controls.Add(this.btnthemNV);
            this.Controls.Add(this.txtsoCMNN);
            this.Controls.Add(this.txtdiachi);
            this.Controls.Add(this.txtTennv);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtsdt);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmttNhanvien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmttNhanvien";
            this.Load += new System.EventHandler(this.frmttNhanvien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnthemNV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTennv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.TextBox txtsoCMNN;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnsuaNV;
        private System.Windows.Forms.Button btnXoanv;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton rdbNvnu;
        private System.Windows.Forms.RadioButton rdbNvnam;
        private System.Windows.Forms.CheckBox ckxTrangthai;
        private System.Windows.Forms.ComboBox cbxquyenhan;
    }
}