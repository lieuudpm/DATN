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
        db_QLCHEntities2 dl = new db_QLCHEntities2();
        private void frmttNhanvien_Load(object sender, EventArgs e)
        {
            cbxquyenhan.SelectedIndex = 0;
            if (this.Tag != null)
            {
                int manv = Int32.Parse(this.Tag.ToString());
                nhanvien nv = dl.nhanviens.FirstOrDefault(x => x.manv == manv);
                txtTennv.Text = nv.tennv;
                txtdiachi.Text = nv.diachi;
                txtemail.Text = nv.email;
                txtsdt.Text = nv.sdt;
                txtsoCMNN.Text = nv.cmnd;
                if (nv.quyenhan != null)
                {
                    cbxquyenhan.SelectedIndex = (int)nv.quyenhan;
                }
                rdbNvnam.Checked = dlChung.isGoiTinhNam(nv.giottinh);
                rdbNvnu.Checked = dlChung.isGoiTinhNu(nv.giottinh);
                ckxTrangthai.Checked = dlChung.isHoatDong(nv.trangthai);
                txtemail.ReadOnly = true;
            }
            else
            {
                btnsuaNV.Enabled = false;
                btnXoanv.Enabled = false;
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnthemNV_Click(object sender, EventArgs e)
        {
            if (txtTennv.Text != "" && txtemail.Text != "")
            {
                nhanvien nv = dl.nhanviens.FirstOrDefault(x => x.email == txtemail.Text);
                if (nv != null)
                {
                    MessageBox.Show("Email đã tồn tại");
                    return;
                }
                nhanvien newData = new nhanvien();
                tbl_NhanVien tblnhanvien = new tbl_NhanVien();
                newData.tennv = txtTennv.Text;
                newData.email = txtemail.Text;
                newData.diachi = txtdiachi.Text;
                newData.cmnd = txtsoCMNN.Text;
                newData.sdt = txtsdt.Text;
                newData.quyenhan = cbxquyenhan.SelectedIndex;
                newData.trangthai = ckxTrangthai.Checked ? 1 : 0;// 0: k hoạt đông ; 1: hoạt động 
                newData.giottinh = rdbNvnam.Checked ? "Na" : "Nu";
                newData.passwword = tblnhanvien.getMd5("12345678");
                dl.nhanviens.Add(newData);
                dl.SaveChanges();
                this.Tag = "ok";
                this.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ tên nhân viên và email của nhân viên.");
            }
        }

        private void btnsuaNV_Click(object sender, EventArgs e)
        {
            if (this.Tag != null)
            {
                int manv = Int32.Parse(this.Tag.ToString());

                if (txtTennv.Text != "")
                {
                    nhanvien editData = dl.nhanviens.FirstOrDefault(x => x.manv == manv);
                    editData.tennv = txtTennv.Text;
                    editData.diachi = txtdiachi.Text;
                    editData.cmnd = txtsoCMNN.Text;
                    editData.sdt = txtsdt.Text;
                    editData.quyenhan = cbxquyenhan.SelectedIndex;
                    editData.trangthai = ckxTrangthai.Checked ? 1 : 0;// 0: k hoạt đông ; 1: hoạt động 
                    editData.giottinh = rdbNvnam.Checked ? "Na" : "Nu";
                    dl.SaveChanges();
                    this.Tag = "ok";
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập tên nhân viên.");
                }
            }

        }

        private void btnXoanv_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn thực sự muốn xóa không?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                int manv = Int32.Parse(this.Tag.ToString());
                nhanvien deleteData = dl.nhanviens.FirstOrDefault(x => x.manv == manv);
                dl.nhanviens.Remove(deleteData);
                dl.SaveChanges();
                this.Tag = "ok";
                this.Close();
            }
        }

    }
}
