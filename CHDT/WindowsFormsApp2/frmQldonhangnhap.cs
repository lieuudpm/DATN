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
    public partial class frmQldonhangnhap : Form
    {
        public frmQldonhangnhap()
        {
            InitializeComponent();
        }

        db_QLCHEntities2 dl = new db_QLCHEntities2();
        List<donhangnhap> lstDonNhapHang = null;

        private void frmQldonhangnhap_Load(object sender, EventArgs e)
        {
            dtpNgayBatDau.Value = DateTime.Now.AddDays(-30);
            loadData();
        }


        private void btnHuytao_Click(object sender, EventArgs e)
        {
            if (dgvHienThi.SelectedRows.Count >= 1)
            {
                DialogResult result = MessageBox.Show("Bạn thực sự muốn thay đổi trạng thái không?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    int madh = Int32.Parse(dgvHienThi.SelectedRows[0].Cells["clId"].Value.ToString());
                    donhangnhap editData = dl.donhangnhaps.FirstOrDefault(x => x.madhn == madh);
                    editData.trangthai = editData.trangthai == 0 ? 1 : 2;
                    dl.SaveChanges();
                    dl = new db_QLCHEntities2();
                    loadData();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một đơn hàng để tiếp tục.");
            }
        }
        private void LoadTimKiem()
        {
            string name = this.txtTimKiemNhaCungCap.Text;
            using (db_QLCHEntities2 context = new db_QLCHEntities2())
            {
                var results = context.nhacungcaps.Where(ncc => ncc.tenncc.Contains(name)).ToList();
                this.dgvHienThi.DataSource = results;

            }
        }
        private void loadData()
        {
            db_QLCHEntities2 dl = new db_QLCHEntities2();
            var qry = from dh in dl.donhangnhaps
                      from ct_dh in dl.ct_donhangnhap.Where(c => c.madhn == dh.madhn).DefaultIfEmpty()
                      from ct_sp in dl.ct_sanpham.Where(x => x.mactsp == ct_dh.mactsp).DefaultIfEmpty()
                      from sp in dl.sanphams.Where(c => c.masp == ct_sp.masp).DefaultIfEmpty()
                      select new
                      {
                          id = dh.madhn,
                          tinhtrang = dh.trangthai,
                          ngaynhaphang = dh.ngaynhaphang,
                          tenncc = dh.nhacungcap.tenncc,
                          tensp = sp.tensp,
                          soluong = ct_dh.soluongmua,
                          tongtien = ct_dh.tongtien,

                      };
            var lstData = qry.ToList();
            dgvHienThi.Rows.Clear();
            if (lstData.Count > 0)
            {
                if (cbxTrangThai.SelectedIndex >= 0)
                {
                    lstData = lstData.Where(c => c.tinhtrang == cbxTrangThai.SelectedIndex).ToList();
                }
                if (txtTimKiemNhaCungCap.Text != "")
                {
                    lstData = lstData.Where(x => x.tenncc.ToLower().Contains(txtTimKiemNhaCungCap.Text.ToLower())).ToList();
                }

                if (dtpNgayBatDau.Value.Date <= dtpNgayKetThuc.Value.Date)
                {
                    lstData = lstData.Where(x => x.ngaynhaphang.Value.Date >= dtpNgayBatDau.Value.Date && x.ngaynhaphang.Value.Date <= dtpNgayKetThuc.Value.Date).ToList();
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
                    dgvHienThi.Rows[i].Cells["clTinhtrang"].Value = dlChung.TrangThaiLabel(lstData[i].tinhtrang);
                    dgvHienThi.Rows[i].Cells["clNgayNhap"].Value = lstData[i].ngaynhaphang;
                    dgvHienThi.Rows[i].Cells["clTenNcc"].Value = lstData[i].tenncc;
                    dgvHienThi.Rows[i].Cells["clTenSp"].Value = lstData[i].tensp;
                    dgvHienThi.Rows[i].Cells["clSoLuong"].Value = lstData[i].soluong;
                    dgvHienThi.Rows[i].Cells["clTongTien"].Value = lstData[i].tongtien;
                }
                dgvHienThi.ClearSelection();
            }

        }


        private void btnTimKiemDonHang_Click(object sender, EventArgs e)
        {
            loadData();

        }
        private void frmQldonhangnhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dlChung.thoatCT == true)
            {
                Application.Exit();
            }
            dlChung.thoatCT = true;
        }

        private void btntaohoadonnhap_Click(object sender, EventArgs e)
        {
            frmThemMoiDonHangNhap frm = new frmThemMoiDonHangNhap();
            frm.ShowDialog();
            if (frm.Tag != null)
            {
                loadData();
            }
        }

        private void txtTimKiemNhaCungCap_TextChanged(object sender, EventArgs e)
        {
            LoadTimKiem();
        }

        private void dgvHienThi_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string maDh = dgvHienThi.Rows[e.RowIndex].Cells["clId"].Value.ToString();
               frmThemMoiDonHangNhap frm = new frmThemMoiDonHangNhap();
                frm.Tag = maDh;
                frm.ShowDialog();
                if (frm.Tag != null && frm.Tag.ToString() == "ok")
                {
                    dl = new db_QLCHEntities2();
                    loadData();
                }
            }
        }
    }
}


