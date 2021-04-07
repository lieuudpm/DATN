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
            this.btnThemmoi = new System.Windows.Forms.Button();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMactbh = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvDsbaohanh = new System.Windows.Forms.DataGridView();
            this.clMabh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clManv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTennv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNgaynhanmay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenkh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTensp = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.ucMenu1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucMenu1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucMenu1.Location = new System.Drawing.Point(0, 0);
            this.ucMenu1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucMenu1.Name = "ucMenu1";
            this.ucMenu1.Size = new System.Drawing.Size(1284, 46);
            this.ucMenu1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnThemmoi);
            this.groupBox2.Controls.Add(this.btnTimkiem);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtMactbh);
            this.groupBox2.Location = new System.Drawing.Point(2, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1058, 104);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nhập thông tin ";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnThemmoi
            // 
            this.btnThemmoi.Location = new System.Drawing.Point(912, 42);
            this.btnThemmoi.Name = "btnThemmoi";
            this.btnThemmoi.Size = new System.Drawing.Size(118, 34);
            this.btnThemmoi.TabIndex = 2;
            this.btnThemmoi.Text = "Thêm mới ";
            this.btnThemmoi.UseVisualStyleBackColor = true;
            this.btnThemmoi.Click += new System.EventHandler(this.btnThemmoi_Click);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Location = new System.Drawing.Point(773, 42);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(118, 33);
            this.btnTimkiem.TabIndex = 2;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(530, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = " Họ tên khách hàng ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(534, 65);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(172, 33);
            this.textBox2.TabIndex = 0;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số điện thoại ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(269, 65);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(172, 33);
            this.textBox1.TabIndex = 0;
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
            this.txtMactbh.Location = new System.Drawing.Point(21, 65);
            this.txtMactbh.Multiline = true;
            this.txtMactbh.Name = "txtMactbh";
            this.txtMactbh.Size = new System.Drawing.Size(194, 33);
            this.txtMactbh.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvDsbaohanh);
            this.groupBox3.Location = new System.Drawing.Point(2, 219);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1282, 412);
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
            this.clTensp,
            this.clSdtKH,
            this.clGhichu});
            this.dgvDsbaohanh.Location = new System.Drawing.Point(0, 36);
            this.dgvDsbaohanh.Name = "dgvDsbaohanh";
            this.dgvDsbaohanh.Size = new System.Drawing.Size(1282, 370);
            this.dgvDsbaohanh.TabIndex = 0;
            this.dgvDsbaohanh.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDsbaohanh_CellDoubleClick);
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
            // clTensp
            // 
            this.clTensp.HeaderText = "Tên sản phẩm ";
            this.clTensp.Name = "clTensp";
            this.clTensp.Width = 180;
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
            this.ClientSize = new System.Drawing.Size(1284, 691);
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBaohanh_FormClosing);
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
        private System.Windows.Forms.Button btnThemmoi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMabh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clManv;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTennv;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNgaynhanmay;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenkh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTensp;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSdtKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGhichu;
    }
}