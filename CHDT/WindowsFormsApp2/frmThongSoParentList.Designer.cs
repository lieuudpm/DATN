﻿namespace WindowsFormsApp2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.btnArrowDown = new FontAwesome.Sharp.IconButton();
            this.btnArrowTop = new FontAwesome.Sharp.IconButton();
            this.dgvThongSo = new System.Windows.Forms.DataGridView();
            this.clTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clIdTs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSttTs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTitleTs = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnThemTitleTs = new System.Windows.Forms.Button();
            this.btnArrowTopTs = new FontAwesome.Sharp.IconButton();
            this.btnArrowDownTs = new FontAwesome.Sharp.IconButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmsNhomHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHienThi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongSo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(504, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản lý thông số mẫu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nhóm";
            // 
            // txtGroup
            // 
            this.txtGroup.Location = new System.Drawing.Point(91, 54);
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
            this.btnThemMoi.Location = new System.Drawing.Point(324, 54);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(100, 33);
            this.btnThemMoi.TabIndex = 4;
            this.btnThemMoi.Text = "Thêm";
            this.btnThemMoi.UseVisualStyleBackColor = true;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(135, 402);
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
            this.btnSuDung.Location = new System.Drawing.Point(29, 402);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHienThi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHienThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHienThi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clGroup,
            this.clId,
            this.clStt});
            this.dgvHienThi.Location = new System.Drawing.Point(25, 93);
            this.dgvHienThi.Name = "dgvHienThi";
            this.dgvHienThi.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHienThi.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
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
            // btnArrowDown
            // 
            this.btnArrowDown.IconChar = FontAwesome.Sharp.IconChar.ArrowDown;
            this.btnArrowDown.IconColor = System.Drawing.Color.Black;
            this.btnArrowDown.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnArrowDown.IconSize = 20;
            this.btnArrowDown.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnArrowDown.Location = new System.Drawing.Point(430, 131);
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
            this.btnArrowTop.Location = new System.Drawing.Point(430, 93);
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThongSo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvThongSo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongSo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clTitle,
            this.clIdTs,
            this.clSttTs});
            this.dgvThongSo.Location = new System.Drawing.Point(24, 93);
            this.dgvThongSo.Name = "dgvThongSo";
            this.dgvThongSo.ReadOnly = true;
            this.dgvThongSo.RowHeadersVisible = false;
            this.dgvThongSo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThongSo.Size = new System.Drawing.Size(639, 303);
            this.dgvThongSo.TabIndex = 12;
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
            // txtTitleTs
            // 
            this.txtTitleTs.Location = new System.Drawing.Point(153, 54);
            this.txtTitleTs.Multiline = true;
            this.txtTitleTs.Name = "txtTitleTs";
            this.txtTitleTs.Size = new System.Drawing.Size(404, 33);
            this.txtTitleTs.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tiêu đề thông số";
            // 
            // btnThemTitleTs
            // 
            this.btnThemTitleTs.Location = new System.Drawing.Point(563, 54);
            this.btnThemTitleTs.Name = "btnThemTitleTs";
            this.btnThemTitleTs.Size = new System.Drawing.Size(100, 33);
            this.btnThemTitleTs.TabIndex = 4;
            this.btnThemTitleTs.Text = "Thêm";
            this.btnThemTitleTs.UseVisualStyleBackColor = true;
            this.btnThemTitleTs.Click += new System.EventHandler(this.btnThemTitleTs_Click);
            // 
            // btnArrowTopTs
            // 
            this.btnArrowTopTs.IconChar = FontAwesome.Sharp.IconChar.ArrowUp;
            this.btnArrowTopTs.IconColor = System.Drawing.Color.Black;
            this.btnArrowTopTs.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnArrowTopTs.IconSize = 20;
            this.btnArrowTopTs.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnArrowTopTs.Location = new System.Drawing.Point(669, 93);
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
            this.btnArrowDownTs.Location = new System.Drawing.Point(669, 131);
            this.btnArrowDownTs.Name = "btnArrowDownTs";
            this.btnArrowDownTs.Size = new System.Drawing.Size(32, 32);
            this.btnArrowDownTs.TabIndex = 10;
            this.btnArrowDownTs.UseVisualStyleBackColor = true;
            this.btnArrowDownTs.Click += new System.EventHandler(this.btnArrowDownTs_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnArrowTop);
            this.groupBox1.Controls.Add(this.btnThemMoi);
            this.groupBox1.Controls.Add(this.btnArrowDown);
            this.groupBox1.Controls.Add(this.txtGroup);
            this.groupBox1.Controls.Add(this.btnSuDung);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.dgvHienThi);
            this.groupBox1.Location = new System.Drawing.Point(26, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(487, 455);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhóm thông số";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTitleTs);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnThemTitleTs);
            this.groupBox2.Controls.Add(this.dgvThongSo);
            this.groupBox2.Controls.Add(this.btnArrowDownTs);
            this.groupBox2.Controls.Add(this.btnArrowTopTs);
            this.groupBox2.Location = new System.Drawing.Point(539, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(720, 455);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông số";
            // 
            // frmThongSoParentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1284, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}