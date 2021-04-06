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
    public partial class frmttNhanvien : Form
    {
        public frmttNhanvien()
        {
            InitializeComponent();
        }
        string Manv = " ";
        private void frmttNhanvien_Load(object sender, EventArgs e)
        {
            cbxquyenhan.SelectedIndex = 0;
            if (ttTaiKhoan.get().quyenhan == 1)
            {
                cbxquyenhan.Items.RemoveAt(1);

            }
            else if (ttTaiKhoan.get().quyenhan == 2)
            {
                cbxquyenhan.Items.RemoveAt(2);
            }
            if (this.Tag != null)
            {           
               Manv = this.Tag.ToString();
               nhanvien Nhanvien = new tbl_NhanVien().getLstNhanVien().FirstOrDefault();
                string maNhanvien = Convert.ToString(Nhanvien.manv);
                txtdiachi.Text = Nhanvien.diachi;
                txtemail.Text = Nhanvien.email;
                txtTennv.Text = Nhanvien.tennv;
                txtmanv.Text = maNhanvien;
                txtsdt.Text = Nhanvien.sdt;
                      
                txtsoCMNN.Text = Nhanvien.cmnd;
                if (Nhanvien.giottinh == " ")
                {
                    rdbNvnam.Checked = true;
                }
                else
                {
                    rdbNvnu.Checked = true;
                }
                if (Nhanvien.quyenhan == 1)
                {
                    cbxquyenhan.Text = "Admin";              
                }
                else if (Nhanvien.quyenhan ==2)
                {
                    cbxquyenhan.Text = "Nhân Viên ";
                }
                txtmanv.ReadOnly = true;
             
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnthemNV_Click(object sender, EventArgs e)
        {
            if (Manv != "")
            {
                txtmanv.ReadOnly = false;
                cbxquyenhan.Enabled = true;
                txtmanv.Text = "";
                txtdiachi.Text = "";
                txtTennv.Text = "";
                txtsoCMNN.Text = "";
                txtsdt.Text = "";
            //    txtmatkhau.Text = "";
                Manv = "";
                return;
            }
            if (txtdiachi.Text != ""  && txtTennv.Text != "" && txtsoCMNN.Text != "" && txtemail.Text != "")
            {
                if (cbxquyenhan.SelectedIndex <0)
                {
                    MessageBox.Show("Chọn quyền hạn không hợp lệ ");
                }
                tbl_NhanVien tblTaikhoan = new tbl_NhanVien();
                nhanvien taikhoan = tblTaikhoan.getLstNhanVien().FirstOrDefault();
                string mkMD5 = tblTaikhoan.getMd5(txtmanv.Text);
                taikhoan.passwword = mkMD5;
                taikhoan.trangthai = 1;
                int Quyenhan = 2;//Nhân viên 
                if (cbxquyenhan.SelectedIndex == 2)
                {
                    Quyenhan = 1;//Admin
                }
                else if (cbxquyenhan.SelectedIndex == 1)
                {
                    Quyenhan = 2;// Nhân viên 
                }
                taikhoan.quyenhan = Quyenhan;
                if (tblTaikhoan.add(taikhoan) == true)
                {
                    nhanvien Tnhanvien = new nhanvien();
                    tbl_NhanVien tblNhavien = new tbl_NhanVien();
                    Tnhanvien.diachi = txtdiachi.Text;
                    Tnhanvien.email = txtemail.Text;
                    Tnhanvien.sdt = txtsdt.Text;
                    Tnhanvien.tennv = txtTennv.Text;
                    Tnhanvien.cmnd = txtsoCMNN.Text;
                    Tnhanvien.manv =Convert.ToInt32(txtmanv.Text);
                    if (tblNhavien.add(Tnhanvien)== true)
                    {
                        MessageBox.Show("Thêm tài khoản thành công");
                    }
                    else
                    {
                        MessageBox.Show(" Thêm tài khoản không thành công");
                    }
                }
                else
                {
                    MessageBox.Show(" Thêm tài khoản không thành công");
                }
            }
            else
            {
                MessageBox.Show("Bạn cần nhập đủ thông tin");
            }
        }

        private void btnsuaNV_Click(object sender, EventArgs e)
        {
            if (Manv == "")
            {
                return;
            }
            if (txtdiachi.Text != "" && txtTennv.Text != "" && txtsoCMNN.Text != "" && txtemail.Text != "")
            {
                tbl_NhanVien tblNhanvien = new tbl_NhanVien();
                nhanvien Nhanvien = tblNhanvien.getLstNhanVien().FirstOrDefault();
                ttTaiKhoan tbl = new ttTaiKhoan();
          
                if (cbxquyenhan.SelectedIndex == 2)
                {
                    Nhanvien.quyenhan = 1;
                }
                else if (cbxquyenhan.SelectedIndex ==1)
                {
                    Nhanvien.quyenhan = 2;
                }
                Nhanvien.diachi = txtdiachi.Text;
                Nhanvien.email = txtemail.Text;
                Nhanvien.sdt = txtsdt.Text;
                Nhanvien.cmnd = txtsoCMNN.Text;
                Nhanvien.tennv = txtTennv.Text;
                // Nhanvien.giottinh = (rdbNvnam.Checked == "") ? true : false;
                if (Nhanvien.giottinh != " ")
                {
                    rdbNvnam.Checked = true;
                }
                else
                {
                    rdbNvnu.Checked = true;
                }

                if (tblNhanvien.update() == true)
                {
                    MessageBox.Show(" Thay đổi thông tin thành công ");
                }else
                {
                    MessageBox.Show(" Thay đổi thông tin không thành công ");
                }
            }
        }

        private void btnXoanv_Click(object sender, EventArgs e)
        {
            
        }

    }
}
