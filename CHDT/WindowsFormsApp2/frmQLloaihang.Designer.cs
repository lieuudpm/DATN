namespace WindowsFormsApp2
{
    partial class frmQLloaihang
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtTimkiemhang = new System.Windows.Forms.TextBox();
            this.btnTimkiemhang = new System.Windows.Forms.Button();
            this.btnXoahang = new System.Windows.Forms.Button();
            this.btnThemhang = new System.Windows.Forms.Button();
            this.dgvHangsanxuat = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTimkiemtenloai = new System.Windows.Forms.TextBox();
            this.btnXoaloai = new System.Windows.Forms.Button();
            this.btnTimloaihang = new System.Windows.Forms.Button();
            this.btnThemloai = new System.Windows.Forms.Button();
            this.dgvLoaihang = new System.Windows.Forms.DataGridView();
            this.ucMenu1 = new WindowsFormsApp2.ucMenu();
            this.clMaloaihang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenloai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMahang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSoluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangsanxuat)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaihang)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTimkiemhang);
            this.groupBox1.Controls.Add(this.btnTimkiemhang);
            this.groupBox1.Controls.Add(this.btnXoahang);
            this.groupBox1.Controls.Add(this.btnThemhang);
            this.groupBox1.Controls.Add(this.dgvHangsanxuat);
            this.groupBox1.Location = new System.Drawing.Point(652, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(620, 516);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hãng sản xuất ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên hãng sản xuất:";
            // 
            // txtTimkiemhang
            // 
            this.txtTimkiemhang.Location = new System.Drawing.Point(156, 53);
            this.txtTimkiemhang.Name = "txtTimkiemhang";
            this.txtTimkiemhang.Size = new System.Drawing.Size(270, 26);
            this.txtTimkiemhang.TabIndex = 3;
            // 
            // btnTimkiemhang
            // 
            this.btnTimkiemhang.Location = new System.Drawing.Point(467, 52);
            this.btnTimkiemhang.Name = "btnTimkiemhang";
            this.btnTimkiemhang.Size = new System.Drawing.Size(130, 28);
            this.btnTimkiemhang.TabIndex = 1;
            this.btnTimkiemhang.Text = "Tìm kiếm ";
            this.btnTimkiemhang.UseVisualStyleBackColor = true;
            this.btnTimkiemhang.Click += new System.EventHandler(this.btnTimkiemhang_Click);
            // 
            // btnXoahang
            // 
            this.btnXoahang.Location = new System.Drawing.Point(478, 461);
            this.btnXoahang.Name = "btnXoahang";
            this.btnXoahang.Size = new System.Drawing.Size(130, 30);
            this.btnXoahang.TabIndex = 1;
            this.btnXoahang.Text = "Xóa ";
            this.btnXoahang.UseVisualStyleBackColor = true;
            this.btnXoahang.Click += new System.EventHandler(this.btnXoahang_Click);
            // 
            // btnThemhang
            // 
            this.btnThemhang.Location = new System.Drawing.Point(324, 461);
            this.btnThemhang.Name = "btnThemhang";
            this.btnThemhang.Size = new System.Drawing.Size(130, 30);
            this.btnThemhang.TabIndex = 1;
            this.btnThemhang.Text = "Thêm mới ";
            this.btnThemhang.UseVisualStyleBackColor = true;
            this.btnThemhang.Click += new System.EventHandler(this.btnThemhang_Click);
            // 
            // dgvHangsanxuat
            // 
            this.dgvHangsanxuat.BackgroundColor = System.Drawing.Color.White;
            this.dgvHangsanxuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHangsanxuat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMahang,
            this.clTenhang,
            this.clSoluong});
            this.dgvHangsanxuat.Location = new System.Drawing.Point(-11, 108);
            this.dgvHangsanxuat.MultiSelect = false;
            this.dgvHangsanxuat.Name = "dgvHangsanxuat";
            this.dgvHangsanxuat.Size = new System.Drawing.Size(608, 325);
            this.dgvHangsanxuat.TabIndex = 0;
            this.dgvHangsanxuat.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHangsanxuat_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(424, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(466, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quản lý loại hàng ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtTimkiemtenloai);
            this.groupBox2.Controls.Add(this.btnXoaloai);
            this.groupBox2.Controls.Add(this.btnTimloaihang);
            this.groupBox2.Controls.Add(this.btnThemloai);
            this.groupBox2.Controls.Add(this.dgvLoaihang);
            this.groupBox2.Location = new System.Drawing.Point(12, 116);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(620, 516);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Loại hàng ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên loại hàng: ";
            // 
            // txtTimkiemtenloai
            // 
            this.txtTimkiemtenloai.Location = new System.Drawing.Point(140, 49);
            this.txtTimkiemtenloai.Name = "txtTimkiemtenloai";
            this.txtTimkiemtenloai.Size = new System.Drawing.Size(313, 26);
            this.txtTimkiemtenloai.TabIndex = 3;
            // 
            // btnXoaloai
            // 
            this.btnXoaloai.Location = new System.Drawing.Point(483, 461);
            this.btnXoaloai.Name = "btnXoaloai";
            this.btnXoaloai.Size = new System.Drawing.Size(130, 30);
            this.btnXoaloai.TabIndex = 1;
            this.btnXoaloai.Text = "Xóa ";
            this.btnXoaloai.UseVisualStyleBackColor = true;
            this.btnXoaloai.Click += new System.EventHandler(this.btnXoaloai_Click);
            // 
            // btnTimloaihang
            // 
            this.btnTimloaihang.Location = new System.Drawing.Point(470, 47);
            this.btnTimloaihang.Name = "btnTimloaihang";
            this.btnTimloaihang.Size = new System.Drawing.Size(130, 28);
            this.btnTimloaihang.TabIndex = 1;
            this.btnTimloaihang.Text = "Tìm kiếm ";
            this.btnTimloaihang.UseVisualStyleBackColor = true;
            this.btnTimloaihang.Click += new System.EventHandler(this.btnTimloaihang_Click);
            // 
            // btnThemloai
            // 
            this.btnThemloai.Location = new System.Drawing.Point(340, 461);
            this.btnThemloai.Name = "btnThemloai";
            this.btnThemloai.Size = new System.Drawing.Size(130, 30);
            this.btnThemloai.TabIndex = 1;
            this.btnThemloai.Text = "Thêm mới ";
            this.btnThemloai.UseVisualStyleBackColor = true;
            this.btnThemloai.Click += new System.EventHandler(this.btnThemloai_Click);
            // 
            // dgvLoaihang
            // 
            this.dgvLoaihang.BackgroundColor = System.Drawing.Color.White;
            this.dgvLoaihang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaihang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMaloaihang,
            this.clTenloai});
            this.dgvLoaihang.Location = new System.Drawing.Point(6, 108);
            this.dgvLoaihang.MultiSelect = false;
            this.dgvLoaihang.Name = "dgvLoaihang";
            this.dgvLoaihang.Size = new System.Drawing.Size(608, 325);
            this.dgvLoaihang.TabIndex = 0;
            this.dgvLoaihang.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoaihang_CellDoubleClick);
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
            // clMaloaihang
            // 
            this.clMaloaihang.HeaderText = "ID Loại hàng";
            this.clMaloaihang.Name = "clMaloaihang";
            this.clMaloaihang.Width = 250;
            // 
            // clTenloai
            // 
            this.clTenloai.HeaderText = "Tên loại hàng ";
            this.clTenloai.Name = "clTenloai";
            this.clTenloai.Width = 340;
            // 
            // clMahang
            // 
            this.clMahang.HeaderText = "ID Hãng sản xuất ";
            this.clMahang.Name = "clMahang";
            this.clMahang.Width = 200;
            // 
            // clTenhang
            // 
            this.clTenhang.HeaderText = "Tên hãng sản xuất ";
            this.clTenhang.Name = "clTenhang";
            this.clTenhang.Width = 200;
            // 
            // clSoluong
            // 
            this.clSoluong.HeaderText = "Số lượng ";
            this.clSoluong.Name = "clSoluong";
            this.clSoluong.Width = 200;
            // 
            // frmQLloaihang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1284, 691);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ucMenu1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmQLloaihang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmQLloaihang";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmQLloaihang_FormClosing);
            this.Load += new System.EventHandler(this.frmQLloaihang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangsanxuat)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaihang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ucMenu ucMenu1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnXoahang;
        private System.Windows.Forms.Button btnThemhang;
        private System.Windows.Forms.DataGridView dgvHangsanxuat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTimkiemhang;
        private System.Windows.Forms.Button btnTimkiemhang;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnXoaloai;
        private System.Windows.Forms.Button btnThemloai;
        private System.Windows.Forms.DataGridView dgvLoaihang;
        private System.Windows.Forms.TextBox txtTimkiemtenloai;
        private System.Windows.Forms.Button btnTimloaihang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMahang;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSoluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaloaihang;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenloai;
    }
}