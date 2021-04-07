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
    }
}
