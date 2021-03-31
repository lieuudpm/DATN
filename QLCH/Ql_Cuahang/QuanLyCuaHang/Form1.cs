using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

   
        private void btnLogin_Click(object sender, EventArgs e)
        {
            db_QLCHEntities dl = new db_QLCHEntities();
           
            string getMd5(string str)
            {
                StringBuilder strMd5 = new StringBuilder();
                System.Security.Cryptography.MD5CryptoServiceProvider md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
                byte[] bytes = md5.ComputeHash(new UTF8Encoding().GetBytes(str));
                for (int i = 0; i < bytes.Length; i++)
                {
                    strMd5.Append(bytes[i].ToString("x2"));
                }

                return strMd5.ToString();
            }

            if (txtPassword.Text == "" || txtUsername.Text == "")
            {
                MessageBox.Show("Bạn cần nhập đủ thông tin");
            }
            else
            {
                nhanvien nv = new nhanvien();
              
                string username = txtUsername.Text;
                string password = getMd5(txtPassword.Text);
                if (nv != null)
                {
                    if (nv.quyenhan != 3)
                    {
                        if (nv.trangthai == null)
                        {
                            MessageBox.Show(" Bạn không thể đăng nhập bằng tài khoản này");
                            return;
                        }
                        Form2 frm = new Form2();
                        frm.Show();
                        this.Hide();

                    }
                    
                }
                else
                {
                    MessageBox.Show("Tài Khoản và mật khẩu không chính xác");
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
