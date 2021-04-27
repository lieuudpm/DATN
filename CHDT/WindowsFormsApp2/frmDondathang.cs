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
  

        private void frmDondathang_Load(object sender, EventArgs e)
        {

            dtpNgayBatDau.Value = DateTime.Now.AddDays(-30);
            loadData();

        }

        private void loadData()
        {
            db_QLCHEntities2 dl = new db_QLCHEntities2();
            var qry = from dh in dl.dondathangs
                      from ct_dh in dl.ct_dondathang.Where(x => x.maddh == dh.maddh).DefaultIfEmpty()                     
                      from ct_sp in dl.ct_sanpham.Where(c => c.mactsp == ct_dh.mactsp).DefaultIfEmpty()
                      from sp in dl.sanphams.Where(c => c.masp == ct_sp.masp).DefaultIfEmpty()
                      select new
                      {
                          id= dh.maddh,
                          trangthai= dh.trangthai,
                          ngaydathang = dh.ngaydathang,
                          tenkh = dh.khachhang.tenkh,
                          diachi = dh.khachhang.diachi,
                          sdt = dh.khachhang.sdt,                      
                          soluong = ct_dh.soluong,
                          soserial = ct_dh.soserial
                      };
            var lstData = qry.ToList();
            dgvHienThi.Rows.Clear();
            if (lstData.Count > 0)
            {
                if (cbxTrangThai.SelectedIndex >= 0 )
                {
                    lstData = lstData.Where(c => c.trangthai== cbxTrangThai.SelectedIndex).ToList();
                }
                if (txtTenKh.Text != "")
                {
                    lstData = lstData.Where(x => x.tenkh.ToLower().Contains(txtTenKh.Text.ToLower())).ToList();
                }
                if (dtpNgayBatDau.Value.Date <= dtpNgayKetThuc.Value.Date)
                {
                    lstData = lstData.Where(x => x.ngaydathang.Value.Date >= dtpNgayBatDau.Value.Date && x.ngaydathang.Value.Date <= dtpNgayKetThuc.Value.Date).ToList();
                }
                else
                {
                    MessageBox.Show(" Ngày bắt đầu phải trước ngày kết thúc");
                    return;
                }
                for (int i = 0; i < lstData.Count; i++)
                {
                    dgvHienThi.Rows.Add();
                    dgvHienThi.Rows[i].Cells["clId"].Value = lstData[i].id;
                    dgvHienThi.Rows[i].Cells["clNgayDatHang"].Value = lstData[i].ngaydathang;
                    dgvHienThi.Rows[i].Cells["clTenKhachHang"].Value = lstData[i].tenkh;
                    dgvHienThi.Rows[i].Cells["cldiachi"].Value = lstData[i].diachi;
                    dgvHienThi.Rows[i].Cells["clsdt"].Value = lstData[i].sdt;
                    dgvHienThi.Rows[i].Cells["clsoluongdat"].Value = lstData[i].soluong;
                    dgvHienThi.Rows[i].Cells["clSoSerial"].Value = lstData[i].soserial;
                    dgvHienThi.Rows[i].Cells["cltinhtrang"].Value =dlChung.TrangThaiLabel(lstData[i].trangthai);
                 
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
               loadData();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnThemBaoHanh_Click(object sender, EventArgs e)
        {
            if (dgvHienThi.SelectedRows.Count == 1)
            {
                int maCtDh = int.Parse(dgvHienThi.SelectedRows[0].Cells["clId"].Value.ToString());
                frmThemmoichitietbaohanh frm = new frmThemmoichitietbaohanh();
                frm.Tag = maCtDh;
                frm.ShowDialog();           
            }
            else
            {
              MessageBox.Show("Chọn một đơn hàng để tiếp tục");
            }

           
        }
        private void frmDondathang_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dlChung.thoatCT == true)
            {
                Application.Exit();
            }
            dlChung.thoatCT = true;
        }

        private void dgvHienThi_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {            
                string maCtDh = dgvHienThi.Rows[e.RowIndex].Cells["clId"].Value.ToString();
               frmThemmoichitietbaohanh frm = new frmThemmoichitietbaohanh();
                frm.Tag = maCtDh;
                frm.ShowDialog();
                if (frm.Tag != null && frm.Tag.ToString() == "ok")
                {
                  db_QLCHEntities2  dl= new db_QLCHEntities2();
                    loadData();
                }
            }
        }
    }
}
