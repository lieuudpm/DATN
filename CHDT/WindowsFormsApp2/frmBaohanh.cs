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
            LoadDgvBaohanh(lstCtBaohanh);
        }
        private void LoadDgvBaohanh( List<ct_baohanh> lst)
        {
            dgvDsbaohanh.Rows.Clear();
            if (lst.Count > 0)
            {
                for (int i = 0; i < lst.Count; i++)
                {
                    dgvDsbaohanh.Rows.Add();
                    dgvDsbaohanh.Rows[i].Cells["clMabh"].Value = lst[i].mactbh;
                    dgvDsbaohanh.Rows[i].Cells["clManv"].Value = lst[i].manv;
                    dgvDsbaohanh.Rows[i].Cells["clTennv"].Value = lst[i].nhanvien.tennv;
                    dgvDsbaohanh.Rows[i].Cells["clNgaynhanmay"].Value = lst[i].ngaynhanmay;
                    dgvDsbaohanh.Rows[i].Cells["clTenkh"].Value = lst[i].ct_dondathang.dondathang.khachhang.tenkh;
                    dgvDsbaohanh.Rows[i].Cells["clTensp"].Value = lst[i].ct_dondathang.tensp;
                    dgvDsbaohanh.Rows[i].Cells["clSdtKh"].Value = lst[i].ct_dondathang.dondathang.khachhang.sdt;
                    dgvDsbaohanh.Rows[i].Cells["clGhichu"].Value = lst[i].ct_dondathang.dondathang.ghichu;
                }
            }

            dgvDsbaohanh.ClearSelection();

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
               string Mabh = dgvDsbaohanh.Rows[e.RowIndex].Cells["clMabh"].Value.ToString();
                frmThemmoichitietbaohanh frm = new frmThemmoichitietbaohanh();
                frm.Tag = Mabh;
                frm.ShowDialog();
                ct_baohanh Bh = new tbl_Baohanh().getLstChitietaohanh().First(c => c.mactbh == int.Parse(Mabh));
                dgvDsbaohanh.Rows[e.RowIndex].Cells["clMabh"].Value = Bh.mactbh;
            
                dgvDsbaohanh.Rows[e.RowIndex].Cells["clManv"].Value = Bh.manv;
                dgvDsbaohanh.Rows[e.RowIndex].Cells["clTennv"].Value = Bh.nhanvien.tennv;
                dgvDsbaohanh.Rows[e.RowIndex].Cells["clNgaynhanmay"].Value = Bh.ngaynhanmay;
                dgvDsbaohanh.Rows[e.RowIndex].Cells["clTenkh"].Value = Bh.ct_dondathang.dondathang.khachhang.tenkh;
                dgvDsbaohanh.Rows[e.RowIndex].Cells["clTensp"].Value =Bh.ct_dondathang.tensp;
                dgvDsbaohanh.Rows[e.RowIndex].Cells["clSdtKh"].Value = Bh.ct_dondathang.dondathang.khachhang.sdt;
                dgvDsbaohanh.Rows[e.RowIndex].Cells["clGhichu"].Value = Bh.ct_dondathang.dondathang.ghichu;

            }
        }
    }
}
