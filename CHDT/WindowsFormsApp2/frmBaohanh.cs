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
    public partial class frmBaohanh : Form
    {
        public frmBaohanh()
        {
            InitializeComponent();
        }
        List<ct_baohanh> lstCtBaohanh = null;
        private void frmBaohanh_Load(object sender, EventArgs e)
        {
            lstCtBaohanh = new tbl_Baohanh().getLstChitietaohanh();
          //  LoadDgvBaohanh(lstCtBaohanh);
             LoadData();
        }
        private void LoadDgvBaohanh(List<ct_baohanh> lst)
        {
            db_QLCHEntities2 dl = new db_QLCHEntities2();

            dgvHienThi.Rows.Clear();
            if (lst.Count > 0)
            {
                for (int i = 0; i < lst.Count; i++)
                {
                    dgvHienThi.Rows.Add();
                    dgvHienThi.Rows[i].Cells["clMabh"].Value = lst[i].mactbh;                 
                    dgvHienThi.Rows[i].Cells["clTennv"].Value = lst[i].nhanvien.tennv;
                    dgvHienThi.Rows[i].Cells["clNgaynhanmay"].Value =lst[i].ngaynhanmay;
                    dgvHienThi.Rows[i].Cells["clNgayKetThuc"].Value = lst[i].ngaytrathucte;
                   // dgvHienThi.Rows[i].Cells["clTenkh"].Value = lst[i].ct_dondathang.maddh;
                   // dgvHienThi.Rows[i].Cells["clTensp"].Value = lst[i].ct_dondathang.tensp;
                 //   dgvHienThi.Rows[i].Cells["clSdtKh"].Value =lst[i].ct_dondathang.dondathang.makh;
                }
            }

            dgvHienThi.ClearSelection();

        }
        private void LoadData()
        {
            db_QLCHEntities2 dl = new db_QLCHEntities2();
            var qry = from ct_bh in dl.ct_baohanh
                      from ct_dh in dl.ct_dondathang.Where(x => x.mactddh == ct_bh.mactddh).DefaultIfEmpty()
                      from dh in dl.dondathangs.Where(x => x.maddh == ct_dh.maddh).DefaultIfEmpty()
                      select new
                      {
                          id = ct_bh.mactbh,
                          tensp = ct_dh.tensp,
                          tenkh = dh.khachhang.tenkh,
                          sdt = dh.khachhang.sdt,
                          ghichu = dh.ghichu,
                          tennv = dh.nhanvien.tennv,
                          manv = ct_bh.manv,
                          Ngaynhanmay = ct_bh.ngaynhanmay,
                          ngaytramay = ct_bh.ngaytrathucte
                      };
            var lstData = qry.ToList();
            dgvHienThi.Rows.Clear();
            if (lstData.Count > 0)
            {
                for (int i = 0; i < lstData.Count; i++)
                {
                    dgvHienThi.Rows.Add();
                    dgvHienThi.Rows[i].Cells["clMabh"].Value = lstData[i].id;
                                 dgvHienThi.Rows[i].Cells["clTennv"].Value = lstData[i].tennv;
                    dgvHienThi.Rows[i].Cells["clNgaynhanmay"].Value = lstData[i].Ngaynhanmay;
                    dgvHienThi.Rows[i].Cells["clNgayKetThuc"].Value = lstData[i].ngaytramay;
                    dgvHienThi.Rows[i].Cells["clTenkh"].Value = lstData[i].tenkh;
                    dgvHienThi.Rows[i].Cells["clTensp"].Value = lstData[i].tensp;
                    dgvHienThi.Rows[i].Cells["clSdtKh"].Value = lstData[i].sdt;
                }
            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {

        }

        private void frmBaohanh_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dlChung.thoatCT == true)
            {
                Application.Exit();
            }
            dlChung.thoatCT = true;
        }



        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            frmThemmoichitietbaohanh frm = new frmThemmoichitietbaohanh();
            frm.ShowDialog();
            lstCtBaohanh = new tbl_Baohanh().getLstChitietaohanh();
            LoadDgvBaohanh(lstCtBaohanh);
        }

        private void dgvDsbaohanh_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string Mabh = dgvHienThi.Rows[e.RowIndex].Cells["clMabh"].Value.ToString();
                frmThemmoichitietbaohanh frm = new frmThemmoichitietbaohanh();
                frm.Tag = Mabh;
                frm.ShowDialog();
                ct_baohanh Bh = new tbl_Baohanh().getLstChitietaohanh().First(c => c.mactbh == int.Parse(Mabh));
                dgvHienThi.Rows[e.RowIndex].Cells["clMabh"].Value = Bh.mactbh;

                dgvHienThi.Rows[e.RowIndex].Cells["clManv"].Value = Bh.manv;
                dgvHienThi.Rows[e.RowIndex].Cells["clTennv"].Value = Bh.nhanvien.tennv;
                dgvHienThi.Rows[e.RowIndex].Cells["clNgaynhanmay"].Value = Bh.ngaynhanmay;
                dgvHienThi.Rows[e.RowIndex].Cells["clTenkh"].Value = Bh.ct_dondathang.dondathang.khachhang.tenkh;
                dgvHienThi.Rows[e.RowIndex].Cells["clTensp"].Value = Bh.ct_dondathang.tensp;
                dgvHienThi.Rows[e.RowIndex].Cells["clSdtKh"].Value = Bh.ct_dondathang.dondathang.khachhang.sdt;
                dgvHienThi.Rows[e.RowIndex].Cells["clGhichu"].Value = Bh.ct_dondathang.dondathang.ghichu;

            }
        }
    }
}
