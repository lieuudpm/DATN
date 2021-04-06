using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Classss;

namespace WindowsFormsApp2
{
    public partial class frmDoimatkhau : Form
    {
        public frmDoimatkhau()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmDoimatkhau_Load(object sender, EventArgs e)
        {
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                txtMatkhaucu.UseSystemPasswordChar = false;
                txtMatkhaumoi.UseSystemPasswordChar = false;
                txtMatkhaumoi2.UseSystemPasswordChar = false;
            }
            else
            {
                txtMatkhaucu.UseSystemPasswordChar = true;
                txtMatkhaumoi.UseSystemPasswordChar = true;
                txtMatkhaumoi2.UseSystemPasswordChar = true;
            }
        }

        private void btnDoimatkhau_Click(object sender, EventArgs e)
        {
            if (txtMatkhaucu.Text != "" && txtMatkhaumoi.Text != "" && txtMatkhaumoi2.Text != "")
            {
                tbl_NhanVien tblTaikhoan = new tbl_NhanVien();
                string mkMD5 = tblTaikhoan.getMd5(txtMatkhaucu.Text);
                if (mkMD5 != ttTaiKhoan.get().passwword)
                {
                    MessageBox.Show("Mật khẩu không chính xác");
                }
                else
                {
                    if (txtMatkhaumoi.Text.Trim() != txtMatkhaumoi2.Text.Trim())
                    {
                        MessageBox.Show(" Mật khẩu mới nhập phải giống nhau ");
                    }
                    else
                    {
                        string mkmoiMD5 = tblTaikhoan.getMd5(txtMatkhaumoi.Text) ;
                        nhanvien taikhoan = tblTaikhoan.getLstNhanVien().FirstOrDefault();
                        taikhoan.passwword = mkmoiMD5;
                        if (tblTaikhoan.update() == true)
                        {
                            MessageBox.Show(" Đổi mật khẩu thành công");
                            txtMatkhaumoi.Text = "";
                            txtMatkhaumoi2.Text = "";
                            txtMatkhaucu.Text = "";
                        }
                    }
                }

            }
        }

        private void btnQuaylai_Click(object sender, EventArgs e)
        {
            frmdangnhap frm = new frmdangnhap();
            frm.Show();
            this.Close();
        }
    }
}
