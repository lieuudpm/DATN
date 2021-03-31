namespace WindowsFormsApp2
{
    partial class frmQlNhanvien
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
            this.btnThemnv = new System.Windows.Forms.Button();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtManv = new System.Windows.Forms.TextBox();
            this.dgvttNV = new System.Windows.Forms.DataGridView();
            this.clManv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTennv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDiachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSocmnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMatkhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clQuyenhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTrangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvttNV)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucMenu1
            // 
            this.ucMenu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ucMenu1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucMenu1.Location = new System.Drawing.Point(0, 1);
            this.ucMenu1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucMenu1.Name = "ucMenu1";
            this.ucMenu1.Size = new System.Drawing.Size(1227, 49);
            this.ucMenu1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThemnv);
            this.groupBox1.Controls.Add(this.btnTimkiem);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtManv);
            this.groupBox1.Location = new System.Drawing.Point(13, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(734, 84);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin ";
            // 
            // btnThemnv
            // 
            this.btnThemnv.Location = new System.Drawing.Point(554, 28);
            this.btnThemnv.Name = "btnThemnv";
            this.btnThemnv.Size = new System.Drawing.Size(151, 33);
            this.btnThemnv.TabIndex = 2;
            this.btnThemnv.Text = "Thêm nhân viên";
            this.btnThemnv.UseVisualStyleBackColor = true;
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Location = new System.Drawing.Point(401, 28);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(118, 33);
            this.btnTimkiem.TabIndex = 2;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập mã nhân viên:";
            // 
            // txtManv
            // 
            this.txtManv.Location = new System.Drawing.Point(186, 25);
            this.txtManv.Multiline = true;
            this.txtManv.Name = "txtManv";
            this.txtManv.Size = new System.Drawing.Size(172, 33);
            this.txtManv.TabIndex = 0;
            // 
            // dgvttNV
            // 
            this.dgvttNV.BackgroundColor = System.Drawing.Color.White;
            this.dgvttNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvttNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clManv,
            this.clTennv,
            this.clGioitinh,
            this.clSdt,
            this.clDiachi,
            this.clSocmnd,
            this.clEmail,
            this.clMatkhau,
            this.clQuyenhan,
            this.clTrangthai});
            this.dgvttNV.Location = new System.Drawing.Point(6, 25);
            this.dgvttNV.Name = "dgvttNV";
            this.dgvttNV.Size = new System.Drawing.Size(1204, 368);
            this.dgvttNV.TabIndex = 2;
            // 
            // clManv
            // 
            this.clManv.HeaderText = "Mã nhân viên";
            this.clManv.Name = "clManv";
            this.clManv.Width = 180;
            // 
            // clTennv
            // 
            this.clTennv.HeaderText = "Tên nhân viên";
            this.clTennv.Name = "clTennv";
            this.clTennv.Width = 180;
            // 
            // clGioitinh
            // 
            this.clGioitinh.HeaderText = "Giới tính";
            this.clGioitinh.Name = "clGioitinh";
            this.clGioitinh.Width = 180;
            // 
            // clSdt
            // 
            this.clSdt.HeaderText = "Số điện thoại";
            this.clSdt.Name = "clSdt";
            this.clSdt.Width = 180;
            // 
            // clDiachi
            // 
            this.clDiachi.HeaderText = "Địa chỉ ";
            this.clDiachi.Name = "clDiachi";
            this.clDiachi.Width = 180;
            // 
            // clSocmnd
            // 
            this.clSocmnd.HeaderText = "Số CMND";
            this.clSocmnd.Name = "clSocmnd";
            this.clSocmnd.Width = 180;
            // 
            // clEmail
            // 
            this.clEmail.HeaderText = "Email";
            this.clEmail.Name = "clEmail";
            this.clEmail.Width = 180;
            // 
            // clMatkhau
            // 
            this.clMatkhau.HeaderText = "Mật khẩu ";
            this.clMatkhau.Name = "clMatkhau";
            this.clMatkhau.Width = 180;
            // 
            // clQuyenhan
            // 
            this.clQuyenhan.HeaderText = "Quyền hạn ";
            this.clQuyenhan.Name = "clQuyenhan";
            this.clQuyenhan.Width = 180;
            // 
            // clTrangthai
            // 
            this.clTrangthai.HeaderText = "Trạng thái ";
            this.clTrangthai.Name = "clTrangthai";
            this.clTrangthai.Width = 180;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvttNV);
            this.groupBox2.Location = new System.Drawing.Point(13, 174);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1214, 409);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin nhân viên ";
            // 
            // frmQlNhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1226, 598);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ucMenu1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmQlNhanvien";
            this.Text = "frmQlNhanvien";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvttNV)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ucMenu ucMenu1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThemnv;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtManv;
        private System.Windows.Forms.DataGridView dgvttNV;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clManv;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTennv;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDiachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSocmnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn clEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMatkhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn clQuyenhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTrangthai;
    }
}