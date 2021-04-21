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
    public partial class frmDondathang : Form
    {
        public frmDondathang()
        {
            InitializeComponent();
        }
        private void btnapdungMHD_Click(object sender, EventArgs e)
        {
            db_QLCHEntities2 dl = new db_QLCHEntities2();
            List<ct_dondathang> lstDonDatHang = dl.ct_dondathang.ToList();
            if (txtnhapmaHD.Text != "")
            {
                lstDonDatHang = lstDonDatHang.Where(x => x.tensp.Contains(txtnhapmaHD.Text)).ToList();
            }
            loadDgvHienThi();

        }

        private void frmDondathang_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dlChung.thoatCT == true)
            {
                Application.Exit();
            }
            dlChung.thoatCT = true;
        }

        private void frmDondathang_Load(object sender, EventArgs e)
        {
   
        }

        private void loadDgvHienThi()
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
            if (lstData.Count()> 0)
            {
                for (int i = 0; i < lstData.Count(); i++)
                {
                    dgvHienThi.Rows.Add();
                    dgvHienThi.Rows[i].Cells["clId"].Value = lstData[i].id;
                    dgvHienThi.Rows[i].Cells["clNgayDatHang"].Value = lstData[i].ngaydathang;
                    dgvHienThi.Rows[i].Cells["clTenKhachHang"].Value = lstData[i].tenkh;
                    dgvHienThi.Rows[i].Cells["clDiaChi"].Value = lstData[i].diachi;
                    dgvHienThi.Rows[i].Cells["clsdt"].Value = lstData[i].sdt;
                    dgvHienThi.Rows[i].Cells["cltinhtrang"].Value = dlChung.TrangThaiLabel( lstData[i].trangthai);             
                }
                dgvHienThi.ClearSelection();
            }
        }

        private void btnThemMoiDonHang_Click(object sender, EventArgs e)
        {
            frmThemMoiDonDatHang frm = new frmThemMoiDonDatHang();
            frm.ShowDialog();
            if (frm.Tag != null)
            {
                DataGridView dgv = (DataGridView)frm.Tag;
                int index = dgvHienThi.Rows.Count;
                for (int i = 0; i < dgv.SelectedRows.Count; i++)
                {
                    dgvHienThi.Rows.Add();
                    dgvHienThi.Rows[i].Cells["clId"].Value = dgv.SelectedRows[i].Cells["clId"].Value;
                    dgvHienThi.Rows[i].Cells["clNgayDatHang"].Value = dgv.SelectedRows[i].Cells["clNgayDatHang"].Value;
                    dgvHienThi.Rows[i].Cells["clTenKhachHang"].Value = dgv.SelectedRows[i].Cells["clTenKhachHang"].Value;
                    dgvHienThi.Rows[i].Cells["clDiaChi"].Value = dgv.SelectedRows[i].Cells["cldiachi"].Value;
                    dgvHienThi.Rows[i].Cells["clsdt"].Value = dgv.SelectedRows[i].Cells["clSoDT"].Value;
                    dgvHienThi.Rows[i].Cells["cltinhtrang"].Value = dgv.SelectedRows[i].Cells["clTrangthai"].Value;
                    //dgvHienThi.Rows.Add();
                    //dgvHienThi.Rows[index].Cells["clId"].Value = dgv.SelectedRows[i].Cells["clId"].Value;
                    //dgvHienThi.Rows[index].Cells["clTinhTrang"].Value = dgv.SelectedRows[i].Cells["clTinhTrang"].Value;
                    //dgvHienThi.Rows[index].Cells["clTen"].Value = dgv.SelectedRows[i].Cells["clTen"].Value;
                    index++;
                }
            }
        }
    }
}
