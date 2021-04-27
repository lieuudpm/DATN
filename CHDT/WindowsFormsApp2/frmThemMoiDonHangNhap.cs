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
    public partial class frmThemMoiDonHangNhap : Form
    {
        public frmThemMoiDonHangNhap()
        {
            InitializeComponent();
        }
        string maNcc = "";
        db_QLCHEntities2 dl = new db_QLCHEntities2();
        List<sanpham> lstSanPham = null;
        List<donhangnhap> lstDonNhapHang = null;
        private void frmQldonhangnhap_Load(object sender, EventArgs e)
        {
            loadNhaCungCap();
            if (this.Tag != null)
            {
                int maDh = int.Parse(this.Tag.ToString());
                donhangnhap dh = dl.donhangnhaps.FirstOrDefault(x => x.madhn == maDh);
                
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemmoisanpham frm = new frmThemmoisanpham();
            frm.Tag = "fromFrmThemMoiDonHangNhap";
            frm.ShowDialog();

            if (frm.Tag != null)
            {
                int index = dgvHienThi.Rows.Count;
                List<ct_sanpham> lstData = (List < ct_sanpham >)frm.Tag;
                for (int i = 0; i < lstData.Count; i++)
                {
                    dl = new db_QLCHEntities2();
                    int checkExits = 0;
                    for (int j = 0; j < index; j++)
                    {
                        if ((int)dgvHienThi.Rows[j].Cells["clId"].Value == lstData[i].mactsp)
                        {
                            int soluong = dgvHienThi.Rows[j].Cells[4].Value != null ? (int)dgvHienThi.Rows[j].Cells[4].Value : 0;
                            dgvHienThi.Rows[j].Cells[4].Value = soluong + 1;
                            Int64 giaban = dgvHienThi.Rows[j].Cells[3].Value == null ? 0 : Int64.Parse(dgvHienThi.Rows[j].Cells[3].Value.ToString());
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
                    dgvHienThi.Rows[index].Cells["clId"].Value = lstData[i].mactsp;
                    dgvHienThi.Rows[index].Cells["clTinhTrang"].Value = lstData[i].tinhtrang;
                    dgvHienThi.Rows[index].Cells["clTen"].Value = lstData[i].sanpham.tensp;
                    dgvHienThi.Rows[index].Cells[4].Value = 1;
                    index++;
                }
            }
        }
        private void btnHuytao_Click(object sender, EventArgs e)
        {
            this.Close();
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
                            int soluong = dgvHienThi.Rows[j].Cells[4].Value != null ? (int)dgvHienThi.Rows[j].Cells[4].Value : 0;
                            dgvHienThi.Rows[j].Cells[4].Value = soluong + 1;
                            Int64 giaban = dgvHienThi.Rows[j].Cells[3].Value == null ? 0 : Int64.Parse(dgvHienThi.Rows[j].Cells[3].Value.ToString());
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
                    dgvHienThi.Rows[index].Cells["clTinhTrang"].Value = dgv.SelectedRows[i].Cells["clTinhTrang"].Value;
                    dgvHienThi.Rows[index].Cells["clTen"].Value = dgv.SelectedRows[i].Cells["clTen"].Value;
                    dgvHienThi.Rows[index].Cells[4].Value = 1;
                    index++;
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
        private void loadNhaCungCap()
        {
            db_QLCHEntities2 db = new db_QLCHEntities2();
            List<nhacungcap> lstNhaCungCap = dl.nhacungcaps.ToList();
            cbxNhaCungCap.ValueMember = "mancc";
            cbxNhaCungCap.DisplayMember = "tenncc";
            cbxNhaCungCap.DataSource = lstNhaCungCap;

        }
        private void cbxNhaCungCap_SelectedIndexChanged(object sender, EventArgs e)
        {
            dl = new db_QLCHEntities2();
            int intMaNCC = Int32.Parse(cbxNhaCungCap.SelectedValue.ToString());
            maNcc = intMaNCC.ToString();
            nhacungcap ncc = dl.nhacungcaps.FirstOrDefault(x => x.mancc == intMaNCC);
            if (ncc != null)
            {
                txtDiaChi.Text = ncc.diachi;
                txtEmail.Text = ncc.email;
                txtSoDienThoai.Text = ncc.sdt;

            }
        }
        private void btnThemMoiNhaCungCap_Click(object sender, EventArgs e)
        {
            frmThongTinNhaCungCap frm = new frmThongTinNhaCungCap();
            frm.ShowDialog();
            if (frm.Tag != null)
            {
                int idNcc = (int)frm.Tag;
                loadNhaCungCap();
                cbxNhaCungCap.SelectedValue = idNcc;
            }
        }

        private void txtSoDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            dl = new db_QLCHEntities2();
            string key = e.KeyChar.ToString();
            if (key == "\r")
            {
                dl = new db_QLCHEntities2();
                nhacungcap ncc = dl.nhacungcaps.FirstOrDefault(x => x.sdt == txtSoDienThoai.Text);
                maNcc = ncc.mancc.ToString();
                if (ncc != null)
                {
                    txtDiaChi.Text = ncc.diachi;
                    txtEmail.Text = ncc.email;
                    cbxNhaCungCap.Text = ncc.tenncc;

                }
            }

        }

        private void btnTaoHoaDon_Click(object sender, EventArgs e)
        {
            if (maNcc == "")
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            db_QLCHEntities2 dl = new db_QLCHEntities2();

            donhangnhap newData = new donhangnhap();
            newData.trangthai = cbxTrangThai.SelectedIndex;
            newData.ghichu = txtghichu.Text;
            newData.ngaynhaphang = dtpNgayNhapHang.Value;
            newData.mancc = Int32.Parse(maNcc);
            dl.donhangnhaps.Add(newData);
            // ct_sp.soluong = "";
           
            sanpham sp = new sanpham();
            ct_donhangnhap[] ctsp = new ct_donhangnhap[dgvHienThi.Rows.Count];
            for (int i = 0; i < dgvHienThi.Rows.Count; i++)
            {
                
                string idSanPham = (dgvHienThi.Rows[i].Cells["clId"].Value ?? "").ToString();
                string tenSanPham = (dgvHienThi.Rows[i].Cells["clTen"].Value ?? "").ToString();
                string giaMua = (dgvHienThi.Rows[i].Cells["clGiaMua"].Value ?? "").ToString();
                string soLuongMua = (dgvHienThi.Rows[i].Cells["clSoLuong"].Value ?? "").ToString();
                string strTongTien = (dgvHienThi.Rows[i].Cells["clTongTien"].Value ?? "").ToString();
                if (giaMua == "")
                {
                    MessageBox.Show("Giá mua của sản phẩm " + tenSanPham + " không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (soLuongMua == "")
                {
                    MessageBox.Show("Số lương nhạp của sản phẩm " + tenSanPham + " không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int newUppdate = 0;
                tblDonhangnhap tbl = new tblDonhangnhap();
                ct_sanpham ct_sp = new ct_sanpham();
                
                ct_sanpham UpdateSl = dl.ct_sanpham.FirstOrDefault(x => x.soluong == ct_sp.soluong);
                if (UpdateSl != null)
                {
                    newUppdate = int.Parse(UpdateSl.ToString()) + int.Parse(soLuongMua.ToString());                
                }
                ctsp[i] = new ct_donhangnhap();
                ctsp[i].tongtien = Int32.Parse(strTongTien);
                ctsp[i].soluongmua = Int32.Parse(soLuongMua);
                ctsp[i].ct_sanpham.soluong = newUppdate;
                ctsp[i].mactsp = Int32.Parse(idSanPham);
                ctsp[i].giamua = Int32.Parse(giaMua);                 
                ctsp[i].madhn = newData.madhn;
               
                dl.ct_donhangnhap.Add(ctsp[i]);
            }
            dl.SaveChanges();
            this.Tag = dgvHienThi;
            MessageBox.Show("Tạo thành công đơn hàng");
            this.Close();
        }

        private void dgvHienThi_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(dgvHienThi_KeyPress);
            if (dgvHienThi.CurrentCell.ColumnIndex == 3 || dgvHienThi.CurrentCell.ColumnIndex == 4)
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvHienThi_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = dgvHienThi.CurrentRow.Index;
            if ((e.ColumnIndex == 3 || e.ColumnIndex == 4) && dgvHienThi.Rows[rowIndex].Cells[4].Value != null && dgvHienThi.Rows[rowIndex].Cells[3].Value != null)
            {
                int soluong = (int)dgvHienThi.Rows[rowIndex].Cells[4].Value;
                Int64 giaban = Int64.Parse(dgvHienThi.Rows[rowIndex].Cells[3].Value.ToString());
                tinhtien(soluong, giaban, rowIndex);
            }


        }

        private void tinhtien(int soluong, long giaban, int rowIndex)
        {
            dgvHienThi.Rows[rowIndex].Cells[5].Value = soluong * giaban;
            Int64 TongGiaTriHD = 0;
            for (int i = 0; i < dgvHienThi.RowCount; i++)
            {
                if (dgvHienThi.Rows[i].Cells[5].Value != null)
                {
                    TongGiaTriHD += Int64.Parse(dgvHienThi.Rows[i].Cells[5].Value.ToString());
                    lblTongTienHoaDon.Text = TongGiaTriHD.ToString();
                }
            }
        }
    }
}


