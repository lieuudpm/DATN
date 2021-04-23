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
    public partial class frmThongTinCaNhan : Form
    {
        public frmThongTinCaNhan()
        {
            InitializeComponent();
        }

        private void btnDoimatkhau_Click(object sender, EventArgs e)
        {

            if (txtMatkhaucu.Text != "" && txtMatkhaumoi.Text != "" && txtMatkhaumoi2.Text != "")
            {
                if (txtMatkhaumoi.Text != txtMatkhaumoi2.Text)
                {
                    MessageBox.Show(" Mật khẩu xác nhận phải giống mật khẩu mới");
                }
                else
                {
                    db_QLCHEntities2 dl = new db_QLCHEntities2();
                    tbl_NhanVien tbl = new tbl_NhanVien();
                    nhanvien nvLogined = ttTaiKhoan.get();
                    string mkMd5 = tbl.getMd5(txtMatkhaucu.Text);
                    nhanvien nv = dl.nhanviens.FirstOrDefault(x => x.email == nvLogined.email && x.passwword == mkMd5);
                    if (nv != null)
                    {
                        nv.passwword = tbl.getMd5(txtMatkhaumoi2.Text);
                        dl.SaveChanges();
                        MessageBox.Show(" Đổi mật khẩu thành công");
                    }
                    else
                    {
                        MessageBox.Show(" Mật khẩu hoặc tài khoản không đúng");
                    }
                }

            }
            else
            {
                MessageBox.Show(" Bạn cần nhập đủ thông tin");
            }
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

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            
        }
    }
}
