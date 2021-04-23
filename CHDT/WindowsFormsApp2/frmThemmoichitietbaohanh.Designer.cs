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
            this.grThongSoKiThuat = new System.Windows.Forms.GroupBox();
            this.dgvDsbaohanh = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMactbh = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.clMasp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTensp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSoserial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grThongSoKiThuat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsbaohanh)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grThongSoKiThuat
            // 
            this.grThongSoKiThuat.Controls.Add(this.dgvDsbaohanh);
            this.grThongSoKiThuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grThongSoKiThuat.ForeColor = System.Drawing.Color.Yellow;
            this.grThongSoKiThuat.Location = new System.Drawing.Point(1, 306);
            this.grThongSoKiThuat.Name = "grThongSoKiThuat";
            this.grThongSoKiThuat.Size = new System.Drawing.Size(1283, 293);
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
            this.clSoserial});
            this.dgvDsbaohanh.Location = new System.Drawing.Point(6, 34);
            this.dgvDsbaohanh.Name = "dgvDsbaohanh";
            this.dgvDsbaohanh.Size = new System.Drawing.Size(1277, 238);
            this.dgvDsbaohanh.TabIndex = 1;
            this.dgvDsbaohanh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDsbaohanh_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(964, 620);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 36);
            this.button1.TabIndex = 24;
            this.button1.Text = "Thêm bảo hành ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1140, 620);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 36);
            this.button2.TabIndex = 24;
            this.button2.Text = "Quay lại ";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtMactbh);
            this.groupBox2.Location = new System.Drawing.Point(12, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1260, 178);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nhập thông tin ";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên khách hàng:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(153, 37);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(398, 33);
            this.textBox2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(595, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số điện thoại ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(711, 37);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(351, 33);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ghi chú";
            // 
            // txtMactbh
            // 
            this.txtMactbh.Location = new System.Drawing.Point(153, 94);
            this.txtMactbh.Multiline = true;
            this.txtMactbh.Name = "txtMactbh";
            this.txtMactbh.Size = new System.Drawing.Size(398, 66);
            this.txtMactbh.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(504, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(277, 31);
            this.label4.TabIndex = 26;
            this.label4.Text = "Thêm mới bảo hành ";
            // 
            // clMasp
            // 
            this.clMasp.HeaderText = "ID Sản phẩm ";
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
            // frmThemmoichitietbaohanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1284, 691);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.grThongSoKiThuat);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmThemmoichitietbaohanh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmThemmoichitietbaohanh";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmThemmoichitietbaohanh_FormClosing);
            this.Load += new System.EventHandler(this.frmThemmoichitietbaohanh_Load);
            this.grThongSoKiThuat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsbaohanh)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grThongSoKiThuat;
        private System.Windows.Forms.DataGridView dgvDsbaohanh;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMactbh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMasp;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTensp;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSoserial;
    }
}