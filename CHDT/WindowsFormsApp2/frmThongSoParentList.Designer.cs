namespace WindowsFormsApp2
{
    partial class frmThongSoParentList
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtGroup = new System.Windows.Forms.TextBox();
            this.cmsNhomHang = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.cmsLoai = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsHang = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnSuDung = new System.Windows.Forms.Button();
            this.dgvHienThi = new System.Windows.Forms.DataGridView();
            this.clGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clStt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.btnArrowDown = new FontAwesome.Sharp.IconButton();
            this.btnArrowTop = new FontAwesome.Sharp.IconButton();
            this.dgvThongSo = new System.Windows.Forms.DataGridView();
            this.txtTitleTs = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnThemTitleTs = new System.Windows.Forms.Button();
            this.clTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clIdTs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSttTs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnArrowTopTs = new FontAwesome.Sharp.IconButton();
            this.btnArrowDownTs = new FontAwesome.Sharp.IconButton();
            this.cmsNhomHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHienThi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongSo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(454, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản lý thông số mẫu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nhóm";
            // 
            // txtGroup
            // 
            this.txtGroup.Location = new System.Drawing.Point(112, 91);
            this.txtGroup.Multiline = true;
            this.txtGroup.Name = "txtGroup";
            this.txtGroup.Size = new System.Drawing.Size(227, 33);
            this.txtGroup.TabIndex = 2;
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
            // btnThemMoi
            // 
            this.btnThemMoi.Location = new System.Drawing.Point(345, 91);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(100, 33);
            this.btnThemMoi.TabIndex = 4;
            this.btnThemMoi.Text = "Thêm";
            this.btnThemMoi.UseVisualStyleBackColor = true;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(156, 468);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 33);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // cmsLoai
            // 
            this.cmsLoai.Name = "cmsLoai";
            this.cmsLoai.Size = new System.Drawing.Size(61, 4);
            // 
            // cmsHang
            // 
            this.cmsHang.Name = "cmsHang";
            this.cmsHang.Size = new System.Drawing.Size(61, 4);
            // 
            // btnSuDung
            // 
            this.btnSuDung.Location = new System.Drawing.Point(50, 468);
            this.btnSuDung.Name = "btnSuDung";
            this.btnSuDung.Size = new System.Drawing.Size(100, 33);
            this.btnSuDung.TabIndex = 5;
            this.btnSuDung.Text = "Sử dụng";
            this.btnSuDung.UseVisualStyleBackColor = true;
            this.btnSuDung.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dgvHienThi
            // 
            this.dgvHienThi.AllowUserToAddRows = false;
            this.dgvHienThi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHienThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHienThi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clGroup,
            this.clId,
            this.clStt});
            this.dgvHienThi.Location = new System.Drawing.Point(46, 159);
            this.dgvHienThi.Name = "dgvHienThi";
            this.dgvHienThi.ReadOnly = true;
            this.dgvHienThi.RowHeadersVisible = false;
            this.dgvHienThi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHienThi.Size = new System.Drawing.Size(399, 303);
            this.dgvHienThi.TabIndex = 8;
            this.dgvHienThi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHienThi_CellClick);
            // 
            // clGroup
            // 
            this.clGroup.HeaderText = "Nhóm";
            this.clGroup.Name = "clGroup";
            this.clGroup.ReadOnly = true;
            this.clGroup.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clGroup.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clId
            // 
            this.clId.HeaderText = "Column1";
            this.clId.Name = "clId";
            this.clId.ReadOnly = true;
            this.clId.Visible = false;
            // 
            // clStt
            // 
            this.clStt.HeaderText = "Column1";
            this.clStt.Name = "clStt";
            this.clStt.ReadOnly = true;
            this.clStt.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Danh sách nhóm thông số";
            // 
            // btnArrowDown
            // 
            this.btnArrowDown.IconChar = FontAwesome.Sharp.IconChar.ArrowDown;
            this.btnArrowDown.IconColor = System.Drawing.Color.Black;
            this.btnArrowDown.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnArrowDown.IconSize = 20;
            this.btnArrowDown.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnArrowDown.Location = new System.Drawing.Point(451, 197);
            this.btnArrowDown.Name = "btnArrowDown";
            this.btnArrowDown.Size = new System.Drawing.Size(32, 32);
            this.btnArrowDown.TabIndex = 10;
            this.btnArrowDown.UseVisualStyleBackColor = true;
            this.btnArrowDown.Click += new System.EventHandler(this.btnArrowDown_Click);
            // 
            // btnArrowTop
            // 
            this.btnArrowTop.IconChar = FontAwesome.Sharp.IconChar.ArrowUp;
            this.btnArrowTop.IconColor = System.Drawing.Color.Black;
            this.btnArrowTop.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnArrowTop.IconSize = 20;
            this.btnArrowTop.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnArrowTop.Location = new System.Drawing.Point(451, 159);
            this.btnArrowTop.Name = "btnArrowTop";
            this.btnArrowTop.Size = new System.Drawing.Size(32, 32);
            this.btnArrowTop.TabIndex = 11;
            this.btnArrowTop.UseVisualStyleBackColor = true;
            this.btnArrowTop.Click += new System.EventHandler(this.btnArrowTop_Click);
            // 
            // dgvThongSo
            // 
            this.dgvThongSo.AllowUserToAddRows = false;
            this.dgvThongSo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongSo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongSo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clTitle,
            this.clIdTs,
            this.clSttTs});
            this.dgvThongSo.Location = new System.Drawing.Point(489, 159);
            this.dgvThongSo.Name = "dgvThongSo";
            this.dgvThongSo.ReadOnly = true;
            this.dgvThongSo.RowHeadersVisible = false;
            this.dgvThongSo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThongSo.Size = new System.Drawing.Size(639, 303);
            this.dgvThongSo.TabIndex = 12;
            // 
            // txtTitleTs
            // 
            this.txtTitleTs.Location = new System.Drawing.Point(618, 91);
            this.txtTitleTs.Multiline = true;
            this.txtTitleTs.Name = "txtTitleTs";
            this.txtTitleTs.Size = new System.Drawing.Size(404, 33);
            this.txtTitleTs.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(485, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tiêu đề thông số";
            // 
            // btnThemTitleTs
            // 
            this.btnThemTitleTs.Location = new System.Drawing.Point(1028, 91);
            this.btnThemTitleTs.Name = "btnThemTitleTs";
            this.btnThemTitleTs.Size = new System.Drawing.Size(100, 33);
            this.btnThemTitleTs.TabIndex = 4;
            this.btnThemTitleTs.Text = "Thêm";
            this.btnThemTitleTs.UseVisualStyleBackColor = true;
            this.btnThemTitleTs.Click += new System.EventHandler(this.btnThemTitleTs_Click);
            // 
            // clTitle
            // 
            this.clTitle.HeaderText = "Tiêu đề";
            this.clTitle.Name = "clTitle";
            this.clTitle.ReadOnly = true;
            this.clTitle.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clTitle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clIdTs
            // 
            this.clIdTs.HeaderText = "Column1";
            this.clIdTs.Name = "clIdTs";
            this.clIdTs.ReadOnly = true;
            this.clIdTs.Visible = false;
            // 
            // clSttTs
            // 
            this.clSttTs.HeaderText = "Column1";
            this.clSttTs.Name = "clSttTs";
            this.clSttTs.ReadOnly = true;
            this.clSttTs.Visible = false;
            // 
            // btnArrowTopTs
            // 
            this.btnArrowTopTs.IconChar = FontAwesome.Sharp.IconChar.ArrowUp;
            this.btnArrowTopTs.IconColor = System.Drawing.Color.Black;
            this.btnArrowTopTs.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnArrowTopTs.IconSize = 20;
            this.btnArrowTopTs.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnArrowTopTs.Location = new System.Drawing.Point(1134, 159);
            this.btnArrowTopTs.Name = "btnArrowTopTs";
            this.btnArrowTopTs.Size = new System.Drawing.Size(32, 32);
            this.btnArrowTopTs.TabIndex = 11;
            this.btnArrowTopTs.UseVisualStyleBackColor = true;
            this.btnArrowTopTs.Click += new System.EventHandler(this.btnArrowTopTs_Click);
            // 
            // btnArrowDownTs
            // 
            this.btnArrowDownTs.IconChar = FontAwesome.Sharp.IconChar.ArrowDown;
            this.btnArrowDownTs.IconColor = System.Drawing.Color.Black;
            this.btnArrowDownTs.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnArrowDownTs.IconSize = 20;
            this.btnArrowDownTs.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnArrowDownTs.Location = new System.Drawing.Point(1134, 197);
            this.btnArrowDownTs.Name = "btnArrowDownTs";
            this.btnArrowDownTs.Size = new System.Drawing.Size(32, 32);
            this.btnArrowDownTs.TabIndex = 10;
            this.btnArrowDownTs.UseVisualStyleBackColor = true;
            this.btnArrowDownTs.Click += new System.EventHandler(this.btnArrowDownTs_Click);
            // 
            // frmThongSoParentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1213, 533);
            this.Controls.Add(this.dgvThongSo);
            this.Controls.Add(this.btnArrowDownTs);
            this.Controls.Add(this.btnArrowDown);
            this.Controls.Add(this.btnArrowTopTs);
            this.Controls.Add(this.btnArrowTop);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvHienThi);
            this.Controls.Add(this.btnSuDung);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThemTitleTs);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTitleTs);
            this.Controls.Add(this.txtGroup);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmThongSoParentList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmThemmoisanpham";
            this.Load += new System.EventHandler(this.frmThemmoisanpham_Load);
            this.cmsNhomHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHienThi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongSo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGroup;
        private System.Windows.Forms.ContextMenuStrip cmsNhomHang;
        private System.Windows.Forms.ToolStripMenuItem tToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsLoai;
        private System.Windows.Forms.ContextMenuStrip cmsHang;
        private System.Windows.Forms.Button btnSuDung;
        private System.Windows.Forms.DataGridView dgvHienThi;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton btnArrowDown;
        private FontAwesome.Sharp.IconButton btnArrowTop;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn clId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clStt;
        private System.Windows.Forms.DataGridView dgvThongSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn clIdTs;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSttTs;
        private System.Windows.Forms.TextBox txtTitleTs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnThemTitleTs;
        private FontAwesome.Sharp.IconButton btnArrowTopTs;
        private FontAwesome.Sharp.IconButton btnArrowDownTs;
    }
}