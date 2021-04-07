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
    public partial class frmttSanpham : Form
    {
        public frmttSanpham()
        {
            InitializeComponent();
        }
        db_QLCHEntities2 dl = new db_QLCHEntities2();
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThemsp_Click(object sender, EventArgs e)
        {
          
            if (txtTensp.Text != "" && txtmota.Text != "" && txtTenhang.Text != "")
            {
                tblSanpham tblsanpham = new tblSanpham();
                sanpham Sanpham = tblsanpham.getLstSanpham().FirstOrDefault();
                if (tblsanpham.add(Sanpham) == true)
                {
                    sanpham Sp = new sanpham();
                    tblSanpham Tsp = new tblSanpham();
                    Sp.masp = int.Parse(txtmasp.Text);
                    Sp.tensp = txtTensp.Text;
                    Sp.mahang = int.Parse(txtmahang.Text);
                    Sp.mota = txtmota.Text;
                    if (Tsp.add(Sp) == true)
                    {
                        MessageBox.Show(" Thêm sản phẩm thành công");
                    }
                    else
                    {
                        MessageBox.Show("Thêm sản phẩm không thành công");
                    }
                }
                else
                {
                    MessageBox.Show("Thêm sản phẩm không thành công");
                }
            }
            else
            {
                MessageBox.Show(" Bạn phải nhập đủ thông tin ");
            }
            sanpham sp = new sanpham();
            frmQldonhangnhap frm = new frmQldonhangnhap();
           // frm.tag = sp.masp;
            frm.ShowDialog();

        }

        private void frmttSanpham_Load(object sender, EventArgs e)
        {

        }

        private void btnQuaylai_Click(object sender, EventArgs e)
        {
            frmQldonhangnhap frm = new frmQldonhangnhap();
            frm.ShowDialog();
        }
    }
}
