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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCkx = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvGroup = new System.Windows.Forms.DataGridView();
            this.clGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clStt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.btnSanCo = new System.Windows.Forms.Button();
            this.btnArrowDown = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.btnArrowTop = new FontAwesome.Sharp.IconButton();
            this.dgvThongSoKyThuat = new System.Windows.Forms.DataGridView();
            this.clTieuDe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clIdTs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSttTs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clThongso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTenSanPham = new System.Windows.Forms.Label();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.cbxGroup = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongSoKyThuat)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.clCkx});
            this.dataGridView1.Location = new System.Drawing.Point(972, 169);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(300, 449);
            this.dataGridView1.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Loại tìm kiếm";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Column1";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Column1";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // clCkx
            // 
            this.clCkx.HeaderText = "";
            this.clCkx.Name = "clCkx";
            this.clCkx.ReadOnly = true;
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
            this.dgvGroup.Location = new System.Drawing.Point(17, 136);
            this.dgvGroup.Name = "dgvGroup";
            this.dgvGroup.ReadOnly = true;
            this.dgvGroup.RowHeadersVisible = false;
            this.dgvGroup.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGroup.Size = new System.Drawing.Size(300, 482);
            this.dgvGroup.TabIndex = 9;
            // 
            // clGroup
            // 
            this.clGroup.HeaderText = "Nhóm Thông Số";
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
            // iconButton2
            // 
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.ArrowDown;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 20;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButton2.Location = new System.Drawing.Point(921, 174);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(32, 32);
            this.iconButton2.TabIndex = 6;
            this.iconButton2.UseVisualStyleBackColor = true;
            // 
            // btnSanCo
            // 
            this.btnSanCo.Location = new System.Drawing.Point(17, 624);
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
            this.btnArrowDown.Location = new System.Drawing.Point(323, 174);
            this.btnArrowDown.Name = "btnArrowDown";
            this.btnArrowDown.Size = new System.Drawing.Size(32, 32);
            this.btnArrowDown.TabIndex = 6;
            this.btnArrowDown.UseVisualStyleBackColor = true;
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.ArrowUp;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 20;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButton1.Location = new System.Drawing.Point(921, 136);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(32, 32);
            this.iconButton1.TabIndex = 6;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // btnArrowTop
            // 
            this.btnArrowTop.IconChar = FontAwesome.Sharp.IconChar.ArrowUp;
            this.btnArrowTop.IconColor = System.Drawing.Color.Black;
            this.btnArrowTop.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnArrowTop.IconSize = 20;
            this.btnArrowTop.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnArrowTop.Location = new System.Drawing.Point(323, 136);
            this.btnArrowTop.Name = "btnArrowTop";
            this.btnArrowTop.Size = new System.Drawing.Size(32, 32);
            this.btnArrowTop.TabIndex = 6;
            this.btnArrowTop.UseVisualStyleBackColor = true;
            // 
            // dgvThongSoKyThuat
            // 
            this.dgvThongSoKyThuat.BackgroundColor = System.Drawing.Color.White;
            this.dgvThongSoKyThuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongSoKyThuat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clTieuDe,
            this.clIdTs,
            this.clSttTs,
            this.clThongso});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThongSoKyThuat.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvThongSoKyThuat.Location = new System.Drawing.Point(381, 135);
            this.dgvThongSoKyThuat.Name = "dgvThongSoKyThuat";
            this.dgvThongSoKyThuat.RowHeadersVisible = false;
            this.dgvThongSoKyThuat.Size = new System.Drawing.Size(534, 522);
            this.dgvThongSoKyThuat.TabIndex = 1;
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
            // btnThemMoi
            // 
            this.btnThemMoi.Location = new System.Drawing.Point(972, 624);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(300, 33);
            this.btnThemMoi.TabIndex = 4;
            this.btnThemMoi.Text = "Thêm mới";
            this.btnThemMoi.UseVisualStyleBackColor = true;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // cbxGroup
            // 
            this.cbxGroup.FormattingEnabled = true;
            this.cbxGroup.Location = new System.Drawing.Point(972, 135);
            this.cbxGroup.Name = "cbxGroup";
            this.cbxGroup.Size = new System.Drawing.Size(300, 28);
            this.cbxGroup.TabIndex = 11;
            // 
            // frmThongSoSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1284, 691);
            this.Controls.Add(this.cbxGroup);
            this.Controls.Add(this.lblTenSanPham);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dgvGroup);
            this.Controls.Add(this.btnArrowDown);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.btnSanCo);
            this.Controls.Add(this.dgvThongSoKyThuat);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.btnArrowTop);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmThongSoSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmThemmoisanpham";
            this.Load += new System.EventHandler(this.frmThongSoSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongSoKyThuat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dgvGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn clId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clStt;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Button btnSanCo;
        private FontAwesome.Sharp.IconButton btnArrowDown;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton btnArrowTop;
        private System.Windows.Forms.DataGridView dgvThongSoKyThuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTieuDe;
        private System.Windows.Forms.DataGridViewTextBoxColumn clIdTs;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSttTs;
        private System.Windows.Forms.DataGridViewTextBoxColumn clThongso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTenSanPham;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clCkx;
        private System.Windows.Forms.ComboBox cbxGroup;
    }
}