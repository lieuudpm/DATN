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
    public partial class frmThemMoiDonDatHang : Form
    {
        public frmThemMoiDonDatHang()
        {
            InitializeComponent();
        }
        db_QLCHEntities2 dl = new db_QLCHEntities2();
        List<dondathang> LstDonDatHang = null;
        List<khachhang> LstKhachHang = null;
        private void btnquaylai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void trmThemMoiDonDatHang_Load(object sender, EventArgs e)
        {
            Load();
        }
        private void Load()
        {
            db_QLCHEntities2 dl = new db_QLCHEntities2();
            var qry = from dh in dl.dondathangs
                      from ct_dh in dl.ct_dondathang.Where(x => x.maddh == dh.maddh).DefaultIfEmpty()
                      from kh in dl.khachhangs.Where(x => x.makh == dh.makh).DefaultIfEmpty()
                      select new
                      {
                          id = dh.maddh,
                          ngaydathang = dh.ngaydathang,
                          tenkh = kh.tenkh,
                          diachi = kh.diachi,
                          sdt = kh.sdt,
                          soluong = ct_dh.soluong,
                          trangthai = dh.trangthai,

                      };
            var lstData = qry.ToList();
            dgvHienThi.Rows.Clear();
            if (lstData.Count() > 0)
            {
                for (int i = 0; i < lstData.Count(); i++)
                {
                    dgvHienThi.Rows.Add();
                    dgvHienThi.Rows[i].Cells["clId"].Value = lstData[i].id;
                    dgvHienThi.Rows[i].Cells["clNgayDatHang"].Value = dtpNgayDatHang.Value;
                    dgvHienThi.Rows[i].Cells["clTenKhachHang"].Value = txtTenKhachHang.Text;
                    dgvHienThi.Rows[i].Cells["cldiachi"].Value = txtDiaChi.Text;
                    dgvHienThi.Rows[i].Cells["clSoDT"].Value = txtSoDt.Text;
                    dgvHienThi.Rows[i].Cells["clTrangthai"].Value = dlChung.TrangThaiLabel(cbxTrangThai.SelectedIndex);
                    //int sum = 0;
                    //for (int y = 0; y < dgvHienThi.Rows.Count; ++y)
                    //{
                    //    sum += Convert.ToInt32(dgvHienThi.Rows[i].Cells[1].Value);
                    //}
                    //label1.Text = sum.ToString();
                }

                dgvHienThi.ClearSelection();
            }
        }
        private void btnthemHD_Click(object sender, EventArgs e)
        {
            db_QLCHEntities2 dl = new db_QLCHEntities2();
            var qry = from dh in dl.dondathangs
                      from ct_dh in dl.ct_dondathang.Where(x => x.maddh == dh.maddh).DefaultIfEmpty()
                      from kh in dl.khachhangs.Where(x => x.makh == dh.makh).DefaultIfEmpty()
                      select new
                      {
                          id = dh.maddh,
                          ngaydathang = dh.ngaydathang,
                          tenkh = kh.tenkh,
                          diachi = kh.diachi,
                          sdt = kh.sdt,
                          soluong = ct_dh.soluong,
                          trangthai = dh.trangthai,

                      };
            var lstData = qry.ToList();
            dgvHienThi.Rows.Clear();
            if (lstData.Count() > 0)
            {
                for (int i = 0; i < lstData.Count(); i++)
                {
                    dgvHienThi.Rows.Add();
                    dgvHienThi.Rows[i].Cells["clId"].Value = lstData[i].id;
                    dgvHienThi.Rows[i].Cells["clNgayDatHang"].Value = dtpNgayDatHang.Value;
                    dgvHienThi.Rows[i].Cells["clTenKhachHang"].Value = txtTenKhachHang.Text;
                    dgvHienThi.Rows[i].Cells["cldiachi"].Value = txtDiaChi.Text;
                    dgvHienThi.Rows[i].Cells["clSoDT"].Value = txtSoDt.Text;
                    dgvHienThi.Rows[i].Cells["clTrangthai"].Value = dlChung.TrangThaiLabel(cbxTrangThai.SelectedIndex);
                    //int sum = 0;
                    //for (int y = 0; y < dgvHienThi.Rows.Count; ++y)
                    //{
                    //    sum += Convert.ToInt32(dgvHienThi.Rows[i].Cells[1].Value);
                    //}
                    //label1.Text = sum.ToString();
                }

                dgvHienThi.ClearSelection();
            }
        }
        private void btnTaoHoaDon_Click(object sender, EventArgs e)
        {

            this.Tag = dgvHienThi;
            MessageBox.Show(" Thêm đơn hàng thành công");
            this.Close();
        }
    }
}
