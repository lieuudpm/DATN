using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Classss;

namespace WindowsFormsApp2
{
    public partial class frmThemmoisanpham : Form
    {
        public frmThemmoisanpham()
        {
            InitializeComponent();
        }

        byte[] img = null;


        private void frmThemmoisanpham_Load(object sender, EventArgs e)
        {
            loadLoaiHang();
        }

        private void loadLoaiHang()
        {
            db_QLCHEntities2 db = new db_QLCHEntities2();
            List<loaihang> lstLoaiHang = db.loaihangs.ToList();
            cbxLoaiSp.ValueMember = "maloai";
            cbxLoaiSp.DisplayMember = "tenloai";
            cbxLoaiSp.DataSource = lstLoaiHang;
        }

        private void loadHang()
        {
            db_QLCHEntities2 db = new db_QLCHEntities2();
            cbxHangSp.Text = "";
            List<hang> lstHang = db.hangs.Where(x => x.maloai == (int)cbxLoaiSp.SelectedValue).ToList();
            cbxHangSp.ValueMember = "mahang";
            cbxHangSp.DisplayMember = "tenhang";
            cbxHangSp.DataSource = lstHang;
        }

        private void btnThemMoiLoaiHang_Click(object sender, EventArgs e)
        {
            frmThemMoiLoaiHang frm = new frmThemMoiLoaiHang();
            frm.ShowDialog();
            if (frm.Tag != null)
            {
                int idLoai = (int)frm.Tag;
                loadLoaiHang();
                cbxLoaiSp.SelectedValue = idLoai;
                loadHang();
            }

        }

        private void btnThemMoiHang_Click(object sender, EventArgs e)
        {
            frmThemMoiHangSanXuat frm = new frmThemMoiHangSanXuat();
            frm.ShowDialog();

            if (frm.Tag != null)
            {
                int id = (int)frm.Tag;
                loadHang();
                cbxHangSp.SelectedValue = id;
            }

        }

        private void cbxLoaiSp_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadHang();
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            db_QLCHEntities2 dl = new db_QLCHEntities2();
            if (txtTenSp.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbxHangSp.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn Hãng sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgvLoaiMay.Rows.Count - 1 <= 0)
            {
                MessageBox.Show("Vui lòng thêm chi thong tin sản phẩm chi tiết", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            sanpham newData = new sanpham();
            newData.tensp = txtTenSp.Text;
            newData.mahang = (int)cbxHangSp.SelectedValue;
            newData.mota = txtMota.Text;
            newData.anh = img;
            dl.sanphams.Add(newData);

            ct_sanpham[] ctsp = new ct_sanpham[dgvLoaiMay.Rows.Count - 1];
            for (int i = 0; i < dgvLoaiMay.Rows.Count - 1; i++)
            {
                string stt = (dgvLoaiMay.Rows[i].Cells["clSttLoaiMay"].Value ?? "").ToString();
                string tinhTrang = (dgvLoaiMay.Rows[i].Cells["clTinhTrang"].Value ?? "").ToString();
                string soLuong = (dgvLoaiMay.Rows[i].Cells["clSoLuong"].Value ?? "").ToString();
                string giaBan = (dgvLoaiMay.Rows[i].Cells["clGiaBan"].Value ?? "").ToString();
                string giaSale = (dgvLoaiMay.Rows[i].Cells["clGiaSale"].Value ?? "").ToString();
                string BaoHanh = (dgvLoaiMay.Rows[i].Cells["clBaoHanh"].Value ?? "").ToString();
                if (tinhTrang == "")
                {
                    MessageBox.Show("Tình trạng của sản phẩm thứ " + stt + " không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (soLuong == "")
                {
                    MessageBox.Show("Số lượng của sản phẩm thứ " + stt + " không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (giaBan == "")
                {
                    MessageBox.Show("Gia bán của sản phẩm thứ " + stt + " không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (giaSale == "")
                {
                    MessageBox.Show("Giá sale của sản phẩm thứ " + stt + " không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (BaoHanh == "")
                {
                    MessageBox.Show("Bảo hành của sản phẩm thứ " + stt + " không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                ctsp[i] = new ct_sanpham();
                ctsp[i].tinhtrang = Int32.Parse(tinhTrang);
                ctsp[i].soluong = Int32.Parse(tinhTrang);
                ctsp[i].giaban = Int64.Parse(tinhTrang);
                ctsp[i].giasale = Int64.Parse(tinhTrang);
                ctsp[i].thoigianbh = Int32.Parse(tinhTrang);
                ctsp[i].masp = newData.masp;
                dl.ct_sanpham.Add(ctsp[i]);
            }
            dl.SaveChanges();
        }

        private void btnQuanLyThongSo_Click(object sender, EventArgs e)
        {
            frmThongSoSanPham frm = new frmThongSoSanPham();
            string[] arr = new string[2];
            arr[0] = txtTenSp.Text;
            frm.Tag = arr;
            frm.ShowDialog();
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Pictures files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png)|*.jpg; *.jpeg; *.jpe; *.jfif; *.png|All files (*.*)|*.*";
            openFile.FilterIndex = 1;
            openFile.RestoreDirectory = true;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                img = LoadIMG.converImgToByte(openFile.FileName);
                picImg.Image = LoadIMG.ByteToImg(img);
            }
        }

        private void dgvLoaiMay_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 0; i < dgvLoaiMay.Rows.Count - 1; i++)
            {
                dgvLoaiMay.Rows[i].Cells["clSttLoaiMay"].Value = i + 1;
            }
        }

        private void dgvLoaiMay_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            for (int i = 0; i < dgvLoaiMay.Rows.Count - 1; i++)
            {
                dgvLoaiMay.Rows[i].Cells["clSttLoaiMay"].Value = i + 1;
            }
        }

        private void dgvLoaiMay_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(dgvLoaiMay_KeyPress);
            if (dgvLoaiMay.CurrentCell.ColumnIndex >= 1 && dgvLoaiMay.CurrentCell.ColumnIndex <= 5)
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(dgvLoaiMay_KeyPress);
                }
            }
        }

        private void dgvLoaiMay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Chỉ có thể nhập số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoaLoaiMay_Click(object sender, EventArgs e)
        {
            if (dgvLoaiMay.SelectedRows.Count > 0 && dgvLoaiMay.CurrentRow.Index != (dgvLoaiMay.Rows.Count - 1))
            {
                dgvLoaiMay.Rows.Remove(dgvLoaiMay.Rows[dgvLoaiMay.CurrentRow.Index]);
            }
        }
    }
}
