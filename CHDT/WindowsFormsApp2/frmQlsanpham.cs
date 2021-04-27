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
    public partial class frmQlsanpham : Form
    {
        public frmQlsanpham()
        {
            InitializeComponent();
        }

        private void btnThemnv_Click(object sender, EventArgs e)
        {
            frmThemmoisanpham frm = new frmThemmoisanpham();
            frm.ShowDialog();
            loadData();
        }

        private void frmQlsanpham_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dlChung.thoatCT == true)
            {
                Application.Exit();
            }
            dlChung.thoatCT = true;
        }

        private void frmQlsanpham_Load(object sender, EventArgs e)
        {
            loadData();
            loadHang();
        }

        private void loadHang()
        {
            db_QLCHEntities2 db = new db_QLCHEntities2();
            cbxHang.Text = "";
            List<hang> lstHang = db.hangs.ToList();
            cbxHang.ValueMember = "mahang";
            cbxHang.DisplayMember = "tenhang";
            cbxHang.DataSource = lstHang;
            cbxHang.Text = "";
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
                          id = ct_sp.mactsp,
                          loai = hang_sp.loaihang.tenloai,
                          hangsp = hang_sp.tenhang,
                          tinhtrang = ct_sp.tinhtrang,
                          tensp = sp.tensp,
                          giaban = ct_sp.giaban,
                          giasale = ct_sp.giasale,
                          soluong = ct_sp.soluong,
                          baohanh = ct_sp.thoigianbh,
                          anh = sp.anh
                      };
            var lstData = qry.ToList();

            dgvHienThi.Rows.Clear();
            if (lstData.Count() > 0)
            {

                if (txtSanPham.Text != "")
                {
                    int id = Int32.Parse(txtSanPham.Text);
                    lstData = lstData.Where(x => x.id == id).ToList();
                }

                if (cbxHang.Text != "")
                {
                    lstData = lstData.Where(x => x.hangsp.Contains(cbxHang.Text)).ToList();
                }

                if (txtTen.Text != "")
                {
                    lstData = lstData.Where(x => x.tensp.Contains(txtTen.Text)).ToList();
                }

                for (int i = 0; i < lstData.Count(); i++)
                {
                    dgvHienThi.Rows.Add();
                    dgvHienThi.Rows[i].Cells["clId"].Value = lstData[i].id;
                    dgvHienThi.Rows[i].Cells["clLoai"].Value = lstData[i].loai;
                    dgvHienThi.Rows[i].Cells["clHang"].Value = lstData[i].hangsp;
                    dgvHienThi.Rows[i].Cells["clTinhTrang"].Value = lstData[i].tinhtrang;
                    dgvHienThi.Rows[i].Cells["clTen"].Value = lstData[i].tensp;
                    dgvHienThi.Rows[i].Cells["clGiaBan"].Value = lstData[i].giaban;
                    dgvHienThi.Rows[i].Cells["clGiaSale"].Value = lstData[i].giasale;
                    dgvHienThi.Rows[i].Cells["clSoLuong"].Value = lstData[i].soluong;
                    dgvHienThi.Rows[i].Cells["clBaoHanh"].Value = lstData[i].baohanh;
                    if (lstData[i].anh != null)
                    {
                        dgvHienThi.Rows[i].Cells["clImg"].Value = LoadIMG.ByteToImg(lstData[i].anh);
                    }
                }
                dgvHienThi.ClearSelection();
            }
            if (dgvHienThi.Columns["clImg"] is DataGridViewImageColumn)
            {
                ((DataGridViewImageColumn)dgvHienThi.Columns["clImg"]).ImageLayout = DataGridViewImageCellLayout.Zoom;
            }

        }

        private void dgvHienThi_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvHienThi.SelectedRows.Count > 0)
            {
                frmThemmoisanpham frm = new frmThemmoisanpham();
                frm.Tag = dgvHienThi.Rows[dgvHienThi.CurrentRow.Index].Cells["clId"].Value;
                frm.Show();
                loadData();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm");
            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
