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
    public partial class frmdangnhap : Form
    {
        public frmdangnhap()
        {
            InitializeComponent();
        }
        int seconds = 30, counts = 1;

        private void timer_Tick(object sender, EventArgs e)
        {
            if (seconds >= 0)
            {
                string strSeconds = (seconds < 10) ? "0" + seconds.ToString() : seconds.ToString();
                label4.Text = strSeconds;
                seconds--;
            }
            else
            {
                timer.Stop();
                label4.Text = "";
                counts = 1;
            }
        }
        private void btndangnhap_Click(object sender, EventArgs e)
        {

            if (txtten.Text == "" || txtmatkhau.Text == "")
            {
                MessageBox.Show("Cần nhập đủ thông tin.");
            }
            else
            {
                if (counts <= 3)
                {
                    tbl_NhanVien tblnhanvien = new tbl_NhanVien();
                    string username = txtten.Text;
                    string password = tblnhanvien.getMd5(txtmatkhau.Text);
                    nhanvien nv = tblnhanvien.getLstNhanVien().FirstOrDefault(c=> c.email == username && c.passwword == password);
                    if (nv != null)
                    {
                        //trường hợp đăng nhập thành công

                        if (nv.trangthai == 0)
                        {
                            //trường hợp tài khoản bị disable
                            MessageBox.Show("Không thể đăng nhập vào tài khoản");
                            return;
                        }

                        ttTaiKhoan.set(nv);

                        //if (nv.quyenhan == 1)
                        //{
                        //    //trường hợp tài khoản là admin form home admin
                        //    frmHomeAdmin frm = new frmHomeAdmin();
                        //    frm.Show();
                        //}
                        //else
                        //{
                        //    frmHomeUser frm = new frmHomeUser();
                        //    frm.Show();
                        //    //trường hợp tài khoản là user sẽ dẫn tời form home user
                        //}
                        //trường hợp tài khoản là admin form home admin
                        frmQldonhangnhap frm = new frmQldonhangnhap();
                        frm.Show();

                    }
                    else
                    {
                        //trường hợp đăng nhập không thành công
                        MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác");
                        counts++;
                    }
                }
                else
                {
                    timer.Start();
                    label4.Text = (label4.Text == "") ? "30" : label4.Text;
                    MessageBox.Show("Vui lòng đăng nhập lại sau " + label4.Text + " giây");

                }
            }
        
    }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void frmdangnhap_Load(object sender, EventArgs e)
        {
        }

        
    }
}
