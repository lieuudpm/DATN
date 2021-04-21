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
    public partial class frmTimKiemSanPham : Form
    {
        public frmTimKiemSanPham()
        {
            InitializeComponent();
        }
        
        private void btnThemnv_Click(object sender, EventArgs e)
        {
            frmThemmoisanpham frm = new frmThemmoisanpham();
            frm.ShowDialog();
        }

        private void frmQlsanpham_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            db_QLCHEntities2 dl = new db_QLCHEntities2();
            var qry = from sp in dl.sanphams
                          from ct_sp in dl.ct_sanpham
                          .Where(x => x.masp == sp.masp).DefaultIfEmpty()
                          from hang_sp in dl.hangs
                          .Where(x => x.mahang == sp.mahang).DefaultIfEmpty()
                          select new
                          {
                              id = sp.masp,
                              id_ctsp = ct_sp.mactsp,
                              loai = hang_sp.loaihang.tenloai,
                              hangsp = hang_sp.tenhang,
                              tinhtrang = ct_sp.tinhtrang,
                              tensp = sp.tensp,
                              giaban = ct_sp.giaban,
                              giasale = ct_sp.giasale,
                              soluong = ct_sp.soluong,
                              baohanh = ct_sp.thoigianbh
                          };
            var lstData = qry.ToList();

            dgvHienThi.Rows.Clear();
            if (lstData.Count() > 0)
            {
                for (int i = 0; i < lstData.Count(); i++)
                {
                    dgvHienThi.Rows.Add();
                    dgvHienThi.Rows[i].Cells["clId"].Value = lstData[i].id_ctsp;
                    dgvHienThi.Rows[i].Cells["clTinhTrang"].Value = lstData[i].tinhtrang;
                    dgvHienThi.Rows[i].Cells["clTen"].Value = lstData[i].tensp;
                    dgvHienThi.Rows[i].Cells["clGiaBan"].Value = lstData[i].giaban;
                    dgvHienThi.Rows[i].Cells["clGiaSale"].Value = lstData[i].giasale;
                    dgvHienThi.Rows[i].Cells["clSoLuong"].Value = lstData[i].soluong;
                    dgvHienThi.Rows[i].Cells["clBaoHanh"].Value = lstData[i].baohanh;


                }
                dgvHienThi.ClearSelection();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Tag = dgvHienThi;
            MessageBox.Show(" Thêm sản phẩm thành công");
            this.Close();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
                db_QLCHEntities2 dl = new db_QLCHEntities2();
                List<sanpham> lstSanPham = dl.sanphams.ToList();
                if (txtTimTheoTenSp.Text != "")
                {
                    lstSanPham = lstSanPham.Where(x => x.tensp.Contains(txtTimTheoTenSp.Text)).ToList();
                }
            loadData();
        }
    }
}
