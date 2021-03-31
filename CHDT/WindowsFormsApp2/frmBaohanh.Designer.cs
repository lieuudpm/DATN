namespace WindowsFormsApp2
{
    partial class frmBaohanh
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
            this.txtMactbh = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvDsbaohanh = new System.Windows.Forms.DataGridView();
            this.clMabh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clManv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTennv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNgaynhanmay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenkh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSdtKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGhichu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsbaohanh)).BeginInit();
            this.SuspendLayout();
            // 
            // ucMenu1
            // 
            this.ucMenu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ucMenu1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucMenu1.Location = new System.Drawing.Point(2, 0);
            this.ucMenu1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucMenu1.Name = "ucMenu1";
            this.ucMenu1.Size = new System.Drawing.Size(1153, 46);
            this.ucMenu1.TabIndex = 0;
            this.ucMenu1.Load += new System.EventHandler(this.ucMenu1_Load);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTimkiem);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtMactbh);
            this.groupBox2.Location = new System.Drawing.Point(2, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(621, 81);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nhập thông tin ";
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Location = new System.Drawing.Point(466, 28);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(118, 33);
            this.btnTimkiem.TabIndex = 2;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập mã chi tiết bảo hành ";
            // 
            // txtMactbh
            // 
            this.txtMactbh.Location = new System.Drawing.Point(247, 28);
            this.txtMactbh.Multiline = true;
            this.txtMactbh.Name = "txtMactbh";
            this.txtMactbh.Size = new System.Drawing.Size(172, 33);
            this.txtMactbh.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvDsbaohanh);
            this.groupBox3.Location = new System.Drawing.Point(2, 176);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1153, 235);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách ";
            // 
            // dgvDsbaohanh
            // 
            this.dgvDsbaohanh.BackgroundColor = System.Drawing.Color.White;
            this.dgvDsbaohanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDsbaohanh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMabh,
            this.clManv,
            this.clTennv,
            this.clNgaynhanmay,
            this.clTenkh,
            this.dataGridViewTextBoxColumn1,
            this.clSdtKH,
            this.clGhichu});
            this.dgvDsbaohanh.Location = new System.Drawing.Point(0, 36);
            this.dgvDsbaohanh.Name = "dgvDsbaohanh";
            this.dgvDsbaohanh.Size = new System.Drawing.Size(1153, 161);
            this.dgvDsbaohanh.TabIndex = 0;
            // 
            // clMabh
            // 
            this.clMabh.HeaderText = "Mã chi tiết bảo hành ";
            this.clMabh.Name = "clMabh";
            this.clMabh.Width = 180;
            // 
            // clManv
            // 
            this.clManv.HeaderText = "Mã nhân viên ";
            this.clManv.Name = "clManv";
            this.clManv.Width = 180;
            // 
            // clTennv
            // 
            this.clTennv.HeaderText = "Tên nhân viên lập";
            this.clTennv.Name = "clTennv";
            this.clTennv.Width = 180;
            // 
            // clNgaynhanmay
            // 
            this.clNgaynhanmay.HeaderText = "Ngày nhận máy ";
            this.clNgaynhanmay.Name = "clNgaynhanmay";
            this.clNgaynhanmay.Width = 180;
            // 
            // clTenkh
            // 
            this.clTenkh.HeaderText = "Tên khách hàng";
            this.clTenkh.Name = "clTenkh";
            this.clTenkh.Width = 180;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Tên sản phẩm ";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 180;
            // 
            // clSdtKH
            // 
            this.clSdtKH.HeaderText = "Số điện thoại ";
            this.clSdtKH.Name = "clSdtKH";
            this.clSdtKH.Width = 180;
            // 
            // clGhichu
            // 
            this.clGhichu.HeaderText = "Ghi chú";
            this.clGhichu.Name = "clGhichu";
            this.clGhichu.Width = 180;
            // 
            // frmBaohanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1156, 692);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ucMenu1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBaohanh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBaohanh";
            this.Load += new System.EventHandler(this.frmBaohanh_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsbaohanh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ucMenu ucMenu1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMactbh;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvDsbaohanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMabh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clManv;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTennv;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNgaynhanmay;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenkh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSdtKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGhichu;
    }
}