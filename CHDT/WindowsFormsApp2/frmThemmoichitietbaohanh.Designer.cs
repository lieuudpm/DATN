namespace WindowsFormsApp2
{
    partial class frmThemmoichitietbaohanh
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
            this.grThongSoKiThuat = new System.Windows.Forms.GroupBox();
            this.dgvDsbaohanh = new System.Windows.Forms.DataGridView();
            this.clMasp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTensp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSoserial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNgaynhanmay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNgaytramaydukien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNgaytrathucte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTinhtrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.grThongSoKiThuat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsbaohanh)).BeginInit();
            this.SuspendLayout();
            // 
            // ucMenu1
            // 
            this.ucMenu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ucMenu1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucMenu1.Location = new System.Drawing.Point(1, 0);
            this.ucMenu1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucMenu1.Name = "ucMenu1";
            this.ucMenu1.Size = new System.Drawing.Size(1197, 43);
            this.ucMenu1.TabIndex = 0;
            // 
            // grThongSoKiThuat
            // 
            this.grThongSoKiThuat.Controls.Add(this.dgvDsbaohanh);
            this.grThongSoKiThuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grThongSoKiThuat.ForeColor = System.Drawing.Color.Yellow;
            this.grThongSoKiThuat.Location = new System.Drawing.Point(1, 303);
            this.grThongSoKiThuat.Name = "grThongSoKiThuat";
            this.grThongSoKiThuat.Size = new System.Drawing.Size(1197, 334);
            this.grThongSoKiThuat.TabIndex = 23;
            this.grThongSoKiThuat.TabStop = false;
            this.grThongSoKiThuat.Text = "Thông tin sản phẩm ";
            // 
            // dgvDsbaohanh
            // 
            this.dgvDsbaohanh.BackgroundColor = System.Drawing.Color.White;
            this.dgvDsbaohanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDsbaohanh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMasp,
            this.clTensp,
            this.clSoserial,
            this.clNgaynhanmay,
            this.clNgaytramaydukien,
            this.clNgaytrathucte,
            this.clTinhtrang});
            this.dgvDsbaohanh.Location = new System.Drawing.Point(0, 36);
            this.dgvDsbaohanh.Name = "dgvDsbaohanh";
            this.dgvDsbaohanh.Size = new System.Drawing.Size(1197, 282);
            this.dgvDsbaohanh.TabIndex = 1;
            this.dgvDsbaohanh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDsbaohanh_CellContentClick);
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
            // clSoserial
            // 
            this.clSoserial.HeaderText = "Số serial";
            this.clSoserial.Name = "clSoserial";
            this.clSoserial.Width = 200;
            // 
            // clNgaynhanmay
            // 
            this.clNgaynhanmay.HeaderText = "Ngày nhận máy ";
            this.clNgaynhanmay.Name = "clNgaynhanmay";
            this.clNgaynhanmay.Width = 200;
            // 
            // clNgaytramaydukien
            // 
            this.clNgaytramaydukien.HeaderText = "Ngày trả máy dự kiến ";
            this.clNgaytramaydukien.Name = "clNgaytramaydukien";
            this.clNgaytramaydukien.Width = 200;
            // 
            // clNgaytrathucte
            // 
            this.clNgaytrathucte.HeaderText = "Ngày trả thực tế";
            this.clNgaytrathucte.Name = "clNgaytrathucte";
            this.clNgaytrathucte.Width = 200;
            // 
            // clTinhtrang
            // 
            this.clTinhtrang.HeaderText = "Tình trạng";
            this.clTinhtrang.Name = "clTinhtrang";
            this.clTinhtrang.Width = 200;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(799, 644);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 36);
            this.button1.TabIndex = 24;
            this.button1.Text = "Thêm bảo hành ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(953, 644);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 36);
            this.button2.TabIndex = 24;
            this.button2.Text = "Quay lại ";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // frmThemmoichitietbaohanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grThongSoKiThuat);
            this.Controls.Add(this.ucMenu1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmThemmoichitietbaohanh";
            this.Text = "frmThemmoichitietbaohanh";
            this.Load += new System.EventHandler(this.frmThemmoichitietbaohanh_Load);
            this.grThongSoKiThuat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsbaohanh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ucMenu ucMenu1;
        private System.Windows.Forms.GroupBox grThongSoKiThuat;
        private System.Windows.Forms.DataGridView dgvDsbaohanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMasp;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTensp;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSoserial;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNgaynhanmay;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNgaytramaydukien;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNgaytrathucte;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTinhtrang;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}