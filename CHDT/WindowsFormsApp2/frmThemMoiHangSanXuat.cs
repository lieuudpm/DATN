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
    public partial class frmThemMoiHangSanXuat : Form
    {
        public frmThemMoiHangSanXuat()
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

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            if (txtTenLoaiHang.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin trên form.");
            }
            else
            {
                db_QLCHEntities2 db = new db_QLCHEntities2();
                loaihang dlLoaiHang = db.loaihangs.FirstOrDefault(x => x.tenloai == txtTenLoaiHang.Text && x.maloai == (int)cbxLoaiSp.SelectedValue);
                if (dlLoaiHang != null)
                {
                    MessageBox.Show("Loại hàng này đã được tạo.");
                }
                else
                {
                    hang newData = new hang();
                    newData.tenhang = txtTenLoaiHang.Text;
                    newData.maloai = (int) cbxLoaiSp.SelectedValue;
                    db.hangs.Add(newData);
                    db.SaveChanges();
                    this.Tag = newData.mahang;
                    this.Close();
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
