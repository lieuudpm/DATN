namespace WindowsFormsApp2
{
    partial class frmttSanpham
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
            this.txtmota = new System.Windows.Forms.TextBox();
            this.txtha = new System.Windows.Forms.TextBox();
            this.txtmahang = new System.Windows.Forms.TextBox();
            this.txtTensp = new System.Windows.Forms.TextBox();
            this.txtmasp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThemsp = new System.Windows.Forms.Button();
            this.btnQuaylai = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTenhang = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtmota);
            this.groupBox1.Controls.Add(this.txtha);
            this.groupBox1.Controls.Add(this.txtTenhang);
            this.groupBox1.Controls.Add(this.txtmahang);
            this.groupBox1.Controls.Add(this.txtTensp);
            this.groupBox1.Controls.Add(this.txtmasp);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(501, 420);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin sản phẩm ";
            // 
            // txtmota
            // 
            this.txtmota.Location = new System.Drawing.Point(29, 315);
            this.txtmota.Multiline = true;
            this.txtmota.Name = "txtmota";
            this.txtmota.Size = new System.Drawing.Size(454, 82);
            this.txtmota.TabIndex = 3;
            // 
            // txtha
            // 
            this.txtha.Location = new System.Drawing.Point(155, 249);
            this.txtha.Name = "txtha";
            this.txtha.Size = new System.Drawing.Size(328, 26);
            this.txtha.TabIndex = 3;
            // 
            // txtmahang
            // 
            this.txtmahang.Location = new System.Drawing.Point(155, 145);
            this.txtmahang.Name = "txtmahang";
            this.txtmahang.Size = new System.Drawing.Size(328, 26);
            this.txtmahang.TabIndex = 2;
            // 
            // txtTensp
            // 
            this.txtTensp.Location = new System.Drawing.Point(155, 96);
            this.txtTensp.Name = "txtTensp";
            this.txtTensp.Size = new System.Drawing.Size(328, 26);
            this.txtTensp.TabIndex = 3;
            this.txtTensp.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtmasp
            // 
            this.txtmasp.Location = new System.Drawing.Point(155, 44);
            this.txtmasp.Name = "txtmasp";
            this.txtmasp.Size = new System.Drawing.Size(328, 26);
            this.txtmasp.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Mô tả:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Hình ảnh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã hãng \r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Sản phẩm ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sản phẩm ";
            // 
            // btnThemsp
            // 
            this.btnThemsp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemsp.Location = new System.Drawing.Point(255, 459);
            this.btnThemsp.Name = "btnThemsp";
            this.btnThemsp.Size = new System.Drawing.Size(125, 32);
            this.btnThemsp.TabIndex = 1;
            this.btnThemsp.Text = "Thêm";
            this.btnThemsp.UseVisualStyleBackColor = true;
            this.btnThemsp.Click += new System.EventHandler(this.btnThemsp_Click);
            // 
            // btnQuaylai
            // 
            this.btnQuaylai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuaylai.Location = new System.Drawing.Point(405, 459);
            this.btnQuaylai.Name = "btnQuaylai";
            this.btnQuaylai.Size = new System.Drawing.Size(125, 32);
            this.btnQuaylai.TabIndex = 1;
            this.btnQuaylai.Text = "Quay lại ";
            this.btnQuaylai.UseVisualStyleBackColor = true;
            this.btnQuaylai.Click += new System.EventHandler(this.btnQuaylai_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tên hãng";
            // 
            // txtTenhang
            // 
            this.txtTenhang.Location = new System.Drawing.Point(155, 196);
            this.txtTenhang.Name = "txtTenhang";
            this.txtTenhang.Size = new System.Drawing.Size(328, 26);
            this.txtTenhang.TabIndex = 2;
            // 
            // frmttSanpham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(542, 503);
            this.Controls.Add(this.btnQuaylai);
            this.Controls.Add(this.btnThemsp);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmttSanpham";
            this.Text = "frmttSanpham";
            this.Load += new System.EventHandler(this.frmttSanpham_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtmota;
        private System.Windows.Forms.TextBox txtha;
        private System.Windows.Forms.TextBox txtmahang;
        private System.Windows.Forms.TextBox txtTensp;
        private System.Windows.Forms.TextBox txtmasp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThemsp;
        private System.Windows.Forms.Button btnQuaylai;
        private System.Windows.Forms.TextBox txtTenhang;
        private System.Windows.Forms.Label label6;
    }
}