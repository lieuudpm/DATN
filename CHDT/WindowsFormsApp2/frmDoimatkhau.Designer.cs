namespace WindowsFormsApp2
{
    partial class frmDoimatkhau
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
            this.btnDoimatkhau = new System.Windows.Forms.Button();
            this.txtMatkhaucu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMatkhaumoi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMatkhaumoi2 = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.btnQuaylai = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDoimatkhau
            // 
            this.btnDoimatkhau.Location = new System.Drawing.Point(59, 382);
            this.btnDoimatkhau.Name = "btnDoimatkhau";
            this.btnDoimatkhau.Size = new System.Drawing.Size(147, 32);
            this.btnDoimatkhau.TabIndex = 0;
            this.btnDoimatkhau.Text = "Đổi mật khẩu ";
            this.btnDoimatkhau.UseVisualStyleBackColor = true;
            this.btnDoimatkhau.Click += new System.EventHandler(this.btnDoimatkhau_Click);
            // 
            // txtMatkhaucu
            // 
            this.txtMatkhaucu.Location = new System.Drawing.Point(30, 78);
            this.txtMatkhaucu.Name = "txtMatkhaucu";
            this.txtMatkhaucu.Size = new System.Drawing.Size(365, 26);
            this.txtMatkhaucu.TabIndex = 1;
            this.txtMatkhaucu.UseSystemPasswordChar = true;
            this.txtMatkhaucu.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nhập mật khẩu cũ ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.txtMatkhaumoi2);
            this.groupBox1.Controls.Add(this.txtMatkhaumoi);
            this.groupBox1.Controls.Add(this.txtMatkhaucu);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(29, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(411, 329);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đổi mật khẩu ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhập mật khẩu mới ";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtMatkhaumoi
            // 
            this.txtMatkhaumoi.Location = new System.Drawing.Point(30, 166);
            this.txtMatkhaumoi.Name = "txtMatkhaumoi";
            this.txtMatkhaumoi.Size = new System.Drawing.Size(365, 26);
            this.txtMatkhaumoi.TabIndex = 1;
            this.txtMatkhaumoi.UseSystemPasswordChar = true;
            this.txtMatkhaumoi.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Xác nhận mật khẩu mới ";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtMatkhaumoi2
            // 
            this.txtMatkhaumoi2.Location = new System.Drawing.Point(30, 251);
            this.txtMatkhaumoi2.Name = "txtMatkhaumoi2";
            this.txtMatkhaumoi2.Size = new System.Drawing.Size(365, 26);
            this.txtMatkhaumoi2.TabIndex = 1;
            this.txtMatkhaumoi2.UseSystemPasswordChar = true;
            this.txtMatkhaumoi2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(217, 297);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(156, 24);
            this.checkBox2.TabIndex = 4;
            this.checkBox2.Text = "Hiển thị mật khẩu ";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // btnQuaylai
            // 
            this.btnQuaylai.Location = new System.Drawing.Point(255, 382);
            this.btnQuaylai.Name = "btnQuaylai";
            this.btnQuaylai.Size = new System.Drawing.Size(147, 32);
            this.btnQuaylai.TabIndex = 0;
            this.btnQuaylai.Text = "Quay lại ";
            this.btnQuaylai.UseVisualStyleBackColor = true;
            this.btnQuaylai.Click += new System.EventHandler(this.btnQuaylai_Click);
            // 
            // frmDoimatkhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(484, 438);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnQuaylai);
            this.Controls.Add(this.btnDoimatkhau);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmDoimatkhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDoimatkhau";
            this.Load += new System.EventHandler(this.frmDoimatkhau_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDoimatkhau;
        private System.Windows.Forms.TextBox txtMatkhaucu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMatkhaumoi2;
        private System.Windows.Forms.TextBox txtMatkhaumoi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button btnQuaylai;
    }
}