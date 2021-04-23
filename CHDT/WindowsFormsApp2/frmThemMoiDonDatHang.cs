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
        string Makh = "";
        private void btnquaylai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void trmThemMoiDonDatHang_Load(object sender, EventArgs e)
        {

        }
        public void LoadKhachhang()
        {
            if (txtSoDt.Text != "" && txtTenKhachHang.Text != "")
            {
                db_QLCHEntities2 dl = new db_QLCHEntities2();

                khachhang dlkhachhang = dl.khachhangs.FirstOrDefault(c => c.tenkh == txtTenKhachHang.Text);
                if (dlkhachhang != null)
                {
                    MessageBox.Show(" Khách hàng đã tồn tại");
                }
                else
                {
                    khachhang newData = new khachhang();
                    newData.tenkh = txtTenKhachHang.Text;
                    newData.diachi = txtDiaChi.Text;
                    newData.sdt = txtSoDt.Text;
                    dl.khachhangs.Add(newData);
                    dl.SaveChanges();
                    this.Tag = newData.makh;
                }
            }
            else
            {
                MessageBox.Show(" Bạn cần nhập đủ thông tin để tiếp tục ");
            }
        }

        private void btnTaoHoaDon_Click(object sender, EventArgs e)
        {
            db_QLCHEntities2 dl = new db_QLCHEntities2();
            tblKhachHang tblkhachhang = new tblKhachHang();
            khachhang kh = new khachhang();
            kh.tenkh = txtTenKhachHang.Text;
            kh.diachi = txtDiaChi.Text;
            kh.gioitinh = rdbnam.Checked ? "Na" : "Nu";
            kh.sdt = txtSoDt.Text;
            tblkhachhang.add(kh);

            dondathang newData = new dondathang();       
            newData.ngaydathang = dtpNgayDatHang.Value;
            newData.makh = kh.makh;
            newData.trangthai = cbxTrangThai.SelectedIndex;
            dl.dondathangs.Add(newData);

            ct_dondathang[] ctdh = new ct_dondathang[dgvHienThi.Rows.Count];
            //for (int i = 0; i < dgvHienThi.Rows.Count; i++)
            //{
            //    string idSanPham = (dgvHienThi.Rows[i].Cells["clId"].Value ?? "").ToString();
            //    string tenSanPham = (dgvHienThi.Rows[i].Cells["clTen"].Value ?? "").ToString();
            //    string soLuongBan = (dgvHienThi.Rows[i].Cells["clSoLuong"].Value ?? "").ToString();
            //    string giaban = (dgvHienThi.Rows[i].Cells["clGiaBan"].Value ?? "").ToString();
            //    ctdh[i] = new ct_dondathang();
            //    ctdh[i].soluong = Int32.Parse(soLuongBan);
            //    ctdh[i].giaban = Int64.Parse(giaban);
            //    ctdh[i].mactsp = Int32.Parse(idSanPham);
            //    ctdh[i].maddh = newData.maddh;
            //    dl.ct_dondathang.Add(ctdh[i]);
            //}
            dl.SaveChanges();
            this.Tag = dgvHienThi;
            MessageBox.Show(" Tạo đơn hàng thành công");
            this.Close();


        }

        private void dgvHienThi_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(dgvHienThi_KeyPress);
            if (dgvHienThi.CurrentCell.ColumnIndex == 2 || dgvHienThi.CurrentCell.ColumnIndex == 3)
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(dgvHienThi_KeyPress);
                }
            }
        }

        private void dgvHienThi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Chỉ có thể nhập số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnTimKiemSanPham_Click(object sender, EventArgs e)
        {
            frmTimKiemSanPham frm = new frmTimKiemSanPham();
            frm.ShowDialog();
            if (frm.Tag != null)
            {
                DataGridView dgv = (DataGridView)frm.Tag;
                int index = dgvHienThi.Rows.Count;
                for (int i = 0; i < dgv.SelectedRows.Count; i++)
                {
                    int checkExits = 0;
                    for (int j = 0; j < index; j++)
                    {
                        if (dgvHienThi.Rows[j].Cells["clId"].Value.ToString() == dgv.SelectedRows[i].Cells["clId"].Value.ToString())
                        {
                            int soluong = dgvHienThi.Rows[j].Cells[3].Value != null ? (int)dgvHienThi.Rows[j].Cells[3].Value : 0;
                            dgvHienThi.Rows[j].Cells[3].Value = soluong + 1;
                            Int64 giaban = dgvHienThi.Rows[j].Cells[2].Value == null ? 0 : Int64.Parse(dgvHienThi.Rows[j].Cells[2].Value.ToString());
                            tinhtien(soluong + 1, giaban, j);
                            checkExits++;
                            break;
                        }
                    }
                    if (checkExits > 0)
                    {
                        continue;
                    }
                    dgvHienThi.Rows.Add();
                    dgvHienThi.Rows[index].Cells["clId"].Value = dgv.SelectedRows[i].Cells["clId"].Value;
                    dgvHienThi.Rows[index].Cells["clTen"].Value = dgv.SelectedRows[i].Cells["clTen"].Value;
                    dgvHienThi.Rows[index].Cells["clGiaBan"].Value = dgv.SelectedRows[i].Cells["clGiaBan"].Value;
                    dgvHienThi.Rows[index].Cells[3].Value = 1;
                    index++;
                }
            }

        }

        private void tinhtien(int soluong, long giaban, int rowIndex)
        {
            dgvHienThi.Rows[rowIndex].Cells[4].Value = soluong * giaban;
            Int64 TongGiaTriHD = 0;
            for (int i = 0; i < dgvHienThi.RowCount; i++)
            {
                if (dgvHienThi.Rows[i].Cells[4].Value != null)
                {
                    TongGiaTriHD += Int64.Parse(dgvHienThi.Rows[i].Cells[4].Value.ToString());
                    lblTongTienHoaDon.Text = TongGiaTriHD.ToString();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvHienThi.SelectedRows.Count >= 1)
            {
                DialogResult result = MessageBox.Show("Bạn thực sự muốn xóa không?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    for (int i = 0; i < dgvHienThi.SelectedRows.Count; i++)
                    {
                        dgvHienThi.Rows.Remove(dgvHienThi.SelectedRows[i]);
                    }
                }
            }
            else
            {
                MessageBox.Show("Bạn cần chọn một sản phẩm để xóa");
            }
        }

        private void dgvHienThi_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = dgvHienThi.CurrentRow.Index;
            if ((e.ColumnIndex == 2 || e.ColumnIndex == 3) && dgvHienThi.Rows[rowIndex].Cells[3].Value != null && dgvHienThi.Rows[rowIndex].Cells[2].Value != null)
            {
                int soluong = (int)dgvHienThi.Rows[rowIndex].Cells[3].Value;
                Int64 giaban = Int64.Parse(dgvHienThi.Rows[rowIndex].Cells[2].Value.ToString());
                tinhtien(soluong, giaban, rowIndex);
            }
        }

        private void txtSoDt_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
