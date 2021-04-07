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
    public partial class frmThemMoiLoaiHang : Form
    {
        public frmThemMoiLoaiHang()
        {
            InitializeComponent();
        }        

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            if(txtLoai.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin trên form.");
            }
            else
            {
                db_QLCHEntities2 db = new db_QLCHEntities2();
                loaihang dlLoaiHang = db.loaihangs.FirstOrDefault(x => x.tenloai == txtLoai.Text);
                if (dlLoaiHang != null)
                {
                    MessageBox.Show("Loại hàng này đã được tạo.");
                }
                else
                {
                    loaihang newData = new loaihang();
                    newData.tenloai = txtLoai.Text;
                    db.loaihangs.Add(newData);
                    db.SaveChanges();
                    this.Tag = newData.maloai;
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
