namespace WindowsFormsApp2
{
    partial class frmThongSoSanPham
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvGroup = new System.Windows.Forms.DataGridView();
            this.clGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clStt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnArrowDownTs = new FontAwesome.Sharp.IconButton();
            this.btnSanCo = new System.Windows.Forms.Button();
            this.btnArrowDown = new FontAwesome.Sharp.IconButton();
            this.btnArrowTopTs = new FontAwesome.Sharp.IconButton();
            this.btnArrowTop = new FontAwesome.Sharp.IconButton();
            this.dgvThongSoKyThuat = new System.Windows.Forms.DataGridView();
            this.clTieuDe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clIdTs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSttTs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clThongso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clIdparent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTenSanPham = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnAddTsGroup = new FontAwesome.Sharp.IconButton();
            this.btnAddTs = new FontAwesome.Sharp.IconButton();
            this.btnRemove = new FontAwesome.Sharp.IconButton();
            this.btnRemoveTs = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongSoKyThuat)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGroup
            // 
            this.dgvGroup.AllowUserToAddRows = false;
            this.dgvGroup.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGroup.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clGroup,
            this.clId,
            this.clStt});
            this.dgvGroup.Location = new System.Drawing.Point(17, 175);
            this.dgvGroup.Name = "dgvGroup";
            this.dgvGroup.RowHeadersVisible = false;
            this.dgvGroup.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGroup.Size = new System.Drawing.Size(300, 443);
            this.dgvGroup.TabIndex = 9;
            this.dgvGroup.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGroup_CellClick);
            this.dgvGroup.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGroup_CellEndEdit);
            // 
            // clGroup
            // 
            this.clGroup.HeaderText = "Nhóm Thông Số";
            this.clGroup.Name = "clGroup";
            this.clGroup.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clGroup.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clId
            // 
            this.clId.HeaderText = "Column1";
            this.clId.Name = "clId";
            this.clId.Visible = false;
            // 
            // clStt
            // 
            this.clStt.HeaderText = "Column1";
            this.clStt.Name = "clStt";
            this.clStt.Visible = false;
            // 
            // btnArrowDownTs
            // 
            this.btnArrowDownTs.IconChar = FontAwesome.Sharp.IconChar.ArrowDown;
            this.btnArrowDownTs.IconColor = System.Drawing.Color.Black;
            this.btnArrowDownTs.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnArrowDownTs.IconSize = 20;
            this.btnArrowDownTs.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnArrowDownTs.Location = new System.Drawing.Point(1240, 173);
            this.btnArrowDownTs.Name = "btnArrowDownTs";
            this.btnArrowDownTs.Size = new System.Drawing.Size(32, 32);
            this.btnArrowDownTs.TabIndex = 6;
            this.btnArrowDownTs.UseVisualStyleBackColor = true;
            this.btnArrowDownTs.Click += new System.EventHandler(this.btnArrowDownTs_Click);
            // 
            // btnSanCo
            // 
            this.btnSanCo.Location = new System.Drawing.Point(17, 136);
            this.btnSanCo.Name = "btnSanCo";
            this.btnSanCo.Size = new System.Drawing.Size(300, 33);
            this.btnSanCo.TabIndex = 4;
            this.btnSanCo.Text = "Sẵn có";
            this.btnSanCo.UseVisualStyleBackColor = true;
            this.btnSanCo.Click += new System.EventHandler(this.btnSanCo_Click);
            // 
            // btnArrowDown
            // 
            this.btnArrowDown.IconChar = FontAwesome.Sharp.IconChar.ArrowDown;
            this.btnArrowDown.IconColor = System.Drawing.Color.Black;
            this.btnArrowDown.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnArrowDown.IconSize = 20;
            this.btnArrowDown.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnArrowDown.Location = new System.Drawing.Point(323, 213);
            this.btnArrowDown.Name = "btnArrowDown";
            this.btnArrowDown.Size = new System.Drawing.Size(32, 32);
            this.btnArrowDown.TabIndex = 6;
            this.btnArrowDown.UseVisualStyleBackColor = true;
            this.btnArrowDown.Click += new System.EventHandler(this.btnArrowDown_Click);
            // 
            // btnArrowTopTs
            // 
            this.btnArrowTopTs.IconChar = FontAwesome.Sharp.IconChar.ArrowUp;
            this.btnArrowTopTs.IconColor = System.Drawing.Color.Black;
            this.btnArrowTopTs.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnArrowTopTs.IconSize = 20;
            this.btnArrowTopTs.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnArrowTopTs.Location = new System.Drawing.Point(1240, 135);
            this.btnArrowTopTs.Name = "btnArrowTopTs";
            this.btnArrowTopTs.Size = new System.Drawing.Size(32, 32);
            this.btnArrowTopTs.TabIndex = 6;
            this.btnArrowTopTs.UseVisualStyleBackColor = true;
            this.btnArrowTopTs.Click += new System.EventHandler(this.btnArrowTopTs_Click);
            // 
            // btnArrowTop
            // 
            this.btnArrowTop.IconChar = FontAwesome.Sharp.IconChar.ArrowUp;
            this.btnArrowTop.IconColor = System.Drawing.Color.Black;
            this.btnArrowTop.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnArrowTop.IconSize = 20;
            this.btnArrowTop.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnArrowTop.Location = new System.Drawing.Point(323, 175);
            this.btnArrowTop.Name = "btnArrowTop";
            this.btnArrowTop.Size = new System.Drawing.Size(32, 32);
            this.btnArrowTop.TabIndex = 6;
            this.btnArrowTop.UseVisualStyleBackColor = true;
            this.btnArrowTop.Click += new System.EventHandler(this.btnArrowTop_Click);
            // 
            // dgvThongSoKyThuat
            // 
            this.dgvThongSoKyThuat.AllowUserToAddRows = false;
            this.dgvThongSoKyThuat.BackgroundColor = System.Drawing.Color.White;
            this.dgvThongSoKyThuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongSoKyThuat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clTieuDe,
            this.clIdTs,
            this.clSttTs,
            this.clThongso,
            this.clIdparent});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThongSoKyThuat.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvThongSoKyThuat.Location = new System.Drawing.Point(381, 135);
            this.dgvThongSoKyThuat.Name = "dgvThongSoKyThuat";
            this.dgvThongSoKyThuat.Size = new System.Drawing.Size(853, 483);
            this.dgvThongSoKyThuat.TabIndex = 1;
            this.dgvThongSoKyThuat.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThongSoKyThuat_CellEndEdit);
            // 
            // clTieuDe
            // 
            this.clTieuDe.HeaderText = "Tên Thông Số";
            this.clTieuDe.Name = "clTieuDe";
            this.clTieuDe.Width = 150;
            // 
            // clIdTs
            // 
            this.clIdTs.HeaderText = "Column1";
            this.clIdTs.Name = "clIdTs";
            this.clIdTs.Visible = false;
            // 
            // clSttTs
            // 
            this.clSttTs.HeaderText = "Column1";
            this.clSttTs.Name = "clSttTs";
            this.clSttTs.Visible = false;
            // 
            // clThongso
            // 
            this.clThongso.FillWeight = 200F;
            this.clThongso.HeaderText = "Thông Số Kỹ Thuật";
            this.clThongso.Name = "clThongso";
            this.clThongso.Width = 200;
            // 
            // clIdparent
            // 
            this.clIdparent.HeaderText = "Column1";
            this.clIdparent.Name = "clIdparent";
            this.clIdparent.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(472, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "THÊM MỚI SẢN PHẨM ";
            // 
            // lblTenSanPham
            // 
            this.lblTenSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSanPham.Location = new System.Drawing.Point(12, 65);
            this.lblTenSanPham.Name = "lblTenSanPham";
            this.lblTenSanPham.Size = new System.Drawing.Size(1213, 67);
            this.lblTenSanPham.TabIndex = 10;
            this.lblTenSanPham.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(17, 624);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(155, 33);
            this.btnLuu.TabIndex = 11;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(178, 624);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(139, 33);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoat";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnAddTsGroup
            // 
            this.btnAddTsGroup.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAddTsGroup.IconColor = System.Drawing.Color.Black;
            this.btnAddTsGroup.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddTsGroup.IconSize = 20;
            this.btnAddTsGroup.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddTsGroup.Location = new System.Drawing.Point(323, 251);
            this.btnAddTsGroup.Name = "btnAddTsGroup";
            this.btnAddTsGroup.Size = new System.Drawing.Size(32, 32);
            this.btnAddTsGroup.TabIndex = 6;
            this.btnAddTsGroup.UseVisualStyleBackColor = true;
            this.btnAddTsGroup.Click += new System.EventHandler(this.btnAddTsGroup_Click);
            // 
            // btnAddTs
            // 
            this.btnAddTs.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAddTs.IconColor = System.Drawing.Color.Black;
            this.btnAddTs.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddTs.IconSize = 20;
            this.btnAddTs.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddTs.Location = new System.Drawing.Point(1240, 211);
            this.btnAddTs.Name = "btnAddTs";
            this.btnAddTs.Size = new System.Drawing.Size(32, 32);
            this.btnAddTs.TabIndex = 6;
            this.btnAddTs.UseVisualStyleBackColor = true;
            this.btnAddTs.Click += new System.EventHandler(this.btnAddTs_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnRemove.IconColor = System.Drawing.Color.Black;
            this.btnRemove.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRemove.IconSize = 20;
            this.btnRemove.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRemove.Location = new System.Drawing.Point(323, 289);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(32, 32);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnRemoveTs
            // 
            this.btnRemoveTs.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnRemoveTs.IconColor = System.Drawing.Color.Black;
            this.btnRemoveTs.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRemoveTs.IconSize = 20;
            this.btnRemoveTs.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRemoveTs.Location = new System.Drawing.Point(1240, 249);
            this.btnRemoveTs.Name = "btnRemoveTs";
            this.btnRemoveTs.Size = new System.Drawing.Size(32, 32);
            this.btnRemoveTs.TabIndex = 6;
            this.btnRemoveTs.UseVisualStyleBackColor = true;
            this.btnRemoveTs.Click += new System.EventHandler(this.btnRemoveTs_Click);
            // 
            // frmThongSoSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1284, 691);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.lblTenSanPham);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvGroup);
            this.Controls.Add(this.btnAddTs);
            this.Controls.Add(this.btnRemoveTs);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAddTsGroup);
            this.Controls.Add(this.btnArrowDown);
            this.Controls.Add(this.btnArrowDownTs);
            this.Controls.Add(this.btnSanCo);
            this.Controls.Add(this.dgvThongSoKyThuat);
            this.Controls.Add(this.btnArrowTopTs);
            this.Controls.Add(this.btnArrowTop);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmThongSoSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmThemmoisanpham";
            this.Load += new System.EventHandler(this.frmThongSoSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongSoKyThuat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn clId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clStt;
        private FontAwesome.Sharp.IconButton btnArrowDownTs;
        private System.Windows.Forms.Button btnSanCo;
        private FontAwesome.Sharp.IconButton btnArrowDown;
        private FontAwesome.Sharp.IconButton btnArrowTopTs;
        private FontAwesome.Sharp.IconButton btnArrowTop;
        private System.Windows.Forms.DataGridView dgvThongSoKyThuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTieuDe;
        private System.Windows.Forms.DataGridViewTextBoxColumn clIdTs;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSttTs;
        private System.Windows.Forms.DataGridViewTextBoxColumn clThongso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTenSanPham;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn clIdparent;
        private FontAwesome.Sharp.IconButton btnAddTsGroup;
        private FontAwesome.Sharp.IconButton btnAddTs;
        private FontAwesome.Sharp.IconButton btnRemove;
        private FontAwesome.Sharp.IconButton btnRemoveTs;
    }
}