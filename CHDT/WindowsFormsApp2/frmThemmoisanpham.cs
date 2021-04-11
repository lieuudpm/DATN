using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class frmThemmoisanpham : Form
    {
        public frmThemmoisanpham()
        {
            InitializeComponent();
        }


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
                MessageBox.Show("Vui lòng nhập tên sản phẩm");
                return;
            }

            if (cbxHangSp.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn Hãng sản phẩm");
                return;
            }

            sanpham newData = new sanpham();
            newData.tensp = txtTenSp.Text;
            newData.mahang = (int)cbxHangSp.SelectedValue;
            newData.mota = txtMota.Text;
            dl.sanphams.Add(newData);           

            ct_sanpham[] ctsp = new ct_sanpham[dgvLoaiMay.Rows.Count - 1]; 
            for (int i = 0; i < dgvLoaiMay.Rows.Count-1; i++)
            {
                //string stt = dgvLoaiMay.Rows[i].Cells["clSttLoaiMay"].Value.ToString();
                string tinhTrang = dgvLoaiMay.Rows[i].Cells["clTinhTrang"].Value.ToString();
                string soLuong = dgvLoaiMay.Rows[i].Cells["clSoLuong"].Value.ToString();
                string giaBan = dgvLoaiMay.Rows[i].Cells["clGiaBan"].Value.ToString();
                string giaSale = dgvLoaiMay.Rows[i].Cells["clGiaSale"].Value.ToString();
                string BaoHanh = dgvLoaiMay.Rows[i].Cells["clBaoHanh"].Value.ToString();
                if(tinhTrang == "" && soLuong == "" && giaBan =="" && giaSale == "" && BaoHanh == "")
                {
                    return;
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

        private void btnSanCo_Click(object sender, EventArgs e)
        {
            frmThongSoParentList frm = new frmThongSoParentList();
            frm.ShowDialog();
        }
    }
}
