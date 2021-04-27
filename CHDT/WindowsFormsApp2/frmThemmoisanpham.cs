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
        List<ct_sanpham> lstCtsp = new List<ct_sanpham>();
        List<thongsokythuat> lstThongSoGroup = new List<thongsokythuat>();
        int? idSanPham;


        private void frmThemmoisanpham_Load(object sender, EventArgs e)
        {            
            loadLoaiHang();
            if (this.Tag != null)
            {
                btnThemMoi.Text = "Lưu Lại";
                db_QLCHEntities2 db = new db_QLCHEntities2();
                int idCtSanPham = (int)this.Tag;
                ct_sanpham ctSanPham = db.ct_sanpham.FirstOrDefault(x => x.mactsp == idCtSanPham);
                idSanPham = ctSanPham.masp;
                if (ctSanPham.sanpham.anh != null)
                {
                    picImg.Image = LoadIMG.ByteToImg(ctSanPham.sanpham.anh);
                    img = ctSanPham.sanpham.anh;
                }
                
                txtMota.Text = ctSanPham.sanpham.mota;
                txtTenSp.Text = ctSanPham.sanpham.tensp;
                cbxLoaiSp.SelectedValue = ctSanPham.sanpham.hang.loaihang.maloai;
                cbxHangSp.SelectedValue = ctSanPham.sanpham.mahang;
                List<ct_sanpham> lstData = db.ct_sanpham.Where(x => x.masp == ctSanPham.masp).ToList();
                for (int i = 0; i < lstData.Count(); i++)
                {
                    dgvLoaiMay.Rows.Add();
                    dgvLoaiMay.Rows[i].Cells["clId"].Value = lstData[i].mactsp;
                    dgvLoaiMay.Rows[i].Cells["clTinhTrang"].Value = lstData[i].tinhtrang;
                    dgvLoaiMay.Rows[i].Cells["clSoLuong"].Value = lstData[i].soluong;
                    dgvLoaiMay.Rows[i].Cells["clGiaBan"].Value = lstData[i].giaban;
                    dgvLoaiMay.Rows[i].Cells["clGiaSale"].Value = lstData[i].giasale;
                    dgvLoaiMay.Rows[i].Cells["clBaoHanh"].Value = lstData[i].thoigianbh;
                }
                dgvLoaiMay.ClearSelection();
            }
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
            sanpham newData;
            if (this.Tag != null)
            {
                newData = dl.sanphams.FirstOrDefault(x => x.masp == idSanPham);
            }
            else
            {
                 newData = new sanpham();
            }
            
            newData.tensp = txtTenSp.Text;
            newData.mahang = (int)cbxHangSp.SelectedValue;
            newData.mota = txtMota.Text;
            newData.anh = img;
            if(this.Tag == null)
            {
                dl.sanphams.Add(newData);
            }
            
            dl.SaveChanges();

            for (int i = 0; i < dgvLoaiMay.Rows.Count - 1; i++)
            {
                string idCt = (dgvLoaiMay.Rows[i].Cells["clId"].Value ?? "").ToString();
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
                ct_sanpham ctsp;
                if (idCt != "")
                {
                    int id = Int32.Parse(idCt);
                    ctsp = dl.ct_sanpham.FirstOrDefault(x => x.mactsp == id);
                }
                else
                {
                    ctsp =  new ct_sanpham();
                }                
                ctsp.tinhtrang = Int32.Parse(tinhTrang);
                ctsp.soluong = Int32.Parse(soLuong);
                ctsp.giaban = Int64.Parse(giaBan);
                ctsp.giasale = Int64.Parse(giaSale);
                ctsp.thoigianbh = Int32.Parse(BaoHanh);
                ctsp.masp = newData.masp;
                if(idCt == "")
                {
                    dl.ct_sanpham.Add(ctsp);
                }
                lstCtsp.Add(ctsp);
                dl.SaveChanges();
            }

            List<thongsokythuat> tam = lstThongSoGroup.Where(x => x.idparent == 0).OrderBy(x => x.sothutu).ToList();
            thongsokythuat[] TsParent = new thongsokythuat[tam.Count];
            for (int i = 0; i < tam.Count; i++)
            {
                if (tam[i].matskt > 0)
                {
                    int id = tam[i].matskt;
                    TsParent[i] = dl.thongsokythuats.FirstOrDefault(x => x.matskt == id);
                }
                else
                {
                    TsParent[i] = new thongsokythuat();
                }
                
                TsParent[i].ten = tam[i].ten;
                TsParent[i].idparent = 0;
                TsParent[i].sothutu = tam[i].sothutu;
                TsParent[i].masp = newData.masp;
                TsParent[i].isdefault = 0;
                if (tam[i].matskt <= 0)
                {
                    dl.thongsokythuats.Add(TsParent[i]);
                }else if (tam[i].sothutu == -1)
                {
                    dl.thongsokythuats.Remove(TsParent[i]);
                }
                    
                dl.SaveChanges();
                int idNhom = tam[i].matskt;
                idNhom = idNhom > 0 ? idNhom : (int)tam[i].sothutu;
                List<thongsokythuat> tamTs = lstThongSoGroup.Where(x => x.idparent == idNhom).OrderBy(x => x.sothutu).ToList();
                for (int j = 0; j < tamTs.Count; j++)
                {
                    thongsokythuat newDataTs;
                    if (tamTs[j].matskt > 0)
                    {
                        int id = tamTs[j].matskt;
                        newDataTs = dl.thongsokythuats.FirstOrDefault(x => x.matskt == id);
                    }
                    else
                    {
                        newDataTs = new thongsokythuat();
                    }
                    newDataTs.ten = tamTs[j].ten;
                    newDataTs.idparent = TsParent[i].matskt;
                    newDataTs.sothutu = tamTs[j].sothutu;
                    newDataTs.thongsokythuat1 = tamTs[j].thongsokythuat1;
                    newDataTs.masp = newData.masp;
                    newDataTs.isdefault = 0;
                    if (tamTs[j].matskt <= 0)
                    {
                        dl.thongsokythuats.Add(newDataTs);
                    }else if(tamTs[j].sothutu == -1)
                    {
                        dl.thongsokythuats.Remove(newDataTs);
                    }
                    dl.SaveChanges();
                }
            }

            this.Tag = lstCtsp;
            this.Close();
        }

        private void btnQuanLyThongSo_Click(object sender, EventArgs e)
        {
            frmThongSoSanPham frm = new frmThongSoSanPham();
            string[] arr = new string[2];
            arr[0] = txtTenSp.Text;
            arr[1] = idSanPham.ToString();
            frm.Tag = arr;
            frm.ShowDialog();
            if (frm.Tag != null)
            {
                lstThongSoGroup = (List<thongsokythuat>)frm.Tag;
            }
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
                string idCt = (dgvLoaiMay.Rows[dgvLoaiMay.CurrentRow.Index].Cells["clId"].Value ?? "").ToString();
                if (idCt!="")
                {
                    DialogResult result = MessageBox.Show("Bạn thực sự muốn xóa không?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            int id = Int32.Parse(idCt);
                            db_QLCHEntities2 db = new db_QLCHEntities2();
                            ct_sanpham sp = db.ct_sanpham.FirstOrDefault(c => c.mactsp == id);
                            int countSp = db.ct_sanpham.Count(x => x.masp == sp.masp);
                            if(countSp == 1)
                            {
                                MessageBox.Show("Cần có một sản phẩm. Không thể xóa sản phẩm này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                            db.ct_sanpham.Remove(sp);
                            db.SaveChanges();
                            dgvLoaiMay.Rows.Remove(dgvLoaiMay.Rows[dgvLoaiMay.CurrentRow.Index]);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Không thể xóa sản phẩm này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
               
            }
        }
    }
}
