namespace WindowsFormsApp2
{
    partial class frmQlsanpham
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMasp = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDssanpham = new System.Windows.Forms.DataGridView();
            this.clMasp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTensp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGiasp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSoluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMaloai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenloai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMancc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenncc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDssanpham)).BeginInit();
            this.SuspendLayout();
            // 
            // ucMenu1
            // 
            this.ucMenu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ucMenu1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucMenu1.Location = new System.Drawing.Point(2, 0);
            this.ucMenu1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucMenu1.Name = "ucMenu1";
            this.ucMenu1.Size = new System.Drawing.Size(1226, 47);
            this.ucMenu1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTimkiem);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtMasp);
            this.groupBox2.Location = new System.Drawing.Point(2, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(557, 84);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nhập thông tin ";
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Location = new System.Drawing.Point(404, 28);
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
            this.label1.Size = new System.Drawing.Size(151, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập mã sản phẩm ";
            // 
            // txtMasp
            // 
            this.txtMasp.Location = new System.Drawing.Point(186, 28);
            this.txtMasp.Multiline = true;
            this.txtMasp.Name = "txtMasp";
            this.txtMasp.Size = new System.Drawing.Size(172, 33);
            this.txtMasp.TabIndex = 0;
            this.txtMasp.TextChanged += new System.EventHandler(this.txtMactbh_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDssanpham);
            this.groupBox1.Location = new System.Drawing.Point(2, 173);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1226, 494);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách ";
            // 
            // dgvDssanpham
            // 
            this.dgvDssanpham.BackgroundColor = System.Drawing.Color.White;
            this.dgvDssanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDssanpham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMasp,
            this.clTensp,
            this.clGiasp,
            this.clSoluong,
            this.clMaloai,
            this.clTenloai,
            this.clMancc,
            this.clTenncc});
            this.dgvDssanpham.Location = new System.Drawing.Point(6, 36);
            this.dgvDssanpham.Name = "dgvDssanpham";
            this.dgvDssanpham.Size = new System.Drawing.Size(1220, 452);
            this.dgvDssanpham.TabIndex = 0;
            this.dgvDssanpham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDssanpham_CellContentClick_1);
            // 
            // clMasp
            // 
            this.clMasp.HeaderText = "Mã sản phẩm ";
            this.clMasp.Name = "clMasp";
            this.clMasp.Width = 150;
            // 
            // clTensp
            // 
            this.clTensp.HeaderText = "Tên sản phẩm";
            this.clTensp.Name = "clTensp";
            this.clTensp.Width = 150;
            // 
            // clGiasp
            // 
            this.clGiasp.HeaderText = "Giá sản phẩm ";
            this.clGiasp.Name = "clGiasp";
            this.clGiasp.Width = 150;
            // 
            // clSoluong
            // 
            this.clSoluong.HeaderText = "Số lượng ";
            this.clSoluong.Name = "clSoluong";
            this.clSoluong.Width = 150;
            // 
            // clMaloai
            // 
            this.clMaloai.HeaderText = "Mã loại hàng ";
            this.clMaloai.Name = "clMaloai";
            this.clMaloai.Width = 150;
            // 
            // clTenloai
            // 
            this.clTenloai.HeaderText = "Tên loại hàng ";
            this.clTenloai.Name = "clTenloai";
            this.clTenloai.Width = 150;
            // 
            // clMancc
            // 
            this.clMancc.HeaderText = "Mã nhà cung cấp ";
            this.clMancc.Name = "clMancc";
            this.clMancc.Width = 150;
            // 
            // clTenncc
            // 
            this.clTenncc.HeaderText = "Tên nhà cung cấp ";
            this.clTenncc.Name = "clTenncc";
            this.clTenncc.Width = 150;
            // 
            // frmQlsanpham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1229, 692);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ucMenu1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmQlsanpham";
            this.Text = "frmQlsanpham";
            this.Load += new System.EventHandler(this.frmQlsanpham_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDssanpham)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ucMenu ucMenu1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMasp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDssanpham;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMasp;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTensp;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGiasp;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSoluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaloai;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenloai;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMancc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenncc;
    }
}