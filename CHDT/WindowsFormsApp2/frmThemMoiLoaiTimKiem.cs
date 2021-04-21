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
    public partial class frmThemMoiLoaiTimKiem : Form
    {
        public frmThemMoiLoaiTimKiem()
        {
            InitializeComponent();
        }

        private void frmThemmoisanpham_Load(object sender, EventArgs e)
        {

            loadCbxGroup();
      
        }

        private void loadCbxGroup()
        {
            db_QLCHEntities2 db = new db_QLCHEntities2();
            List<loaithongso> lst = db.loaithongsoes.Where(x=>x.id_parent == 0).OrderBy(x=>x.stt).ToList();
            cbxGroup.ValueMember = "malts";
            cbxGroup.DisplayMember = "title";
            cbxGroup.DataSource = lst;
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            if (txtTenLoai.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin trên form.");
            }
            else
            {
                db_QLCHEntities2 db = new db_QLCHEntities2();
                loaithongso dlLoaiHang = db.loaithongsoes.FirstOrDefault(x => x.title == txtTenLoai.Text && x.id_parent == (int)cbxGroup.SelectedValue);
                if (dlLoaiHang != null)
                {
                    MessageBox.Show("Loại hàng này đã được tạo.");
                }
                else
                {
                    int? stt = db.loaithongsoes.Where(x => x.id_parent == (int)cbxGroup.SelectedValue).Max(x => x.stt);
                    loaithongso newData = new loaithongso();
                    newData.title = txtTenLoai.Text;
                    newData.id_parent = (int)cbxGroup.SelectedValue;
                    newData.stt = stt == null ? 1 : stt + 1;
                    db.loaithongsoes.Add(newData);
                    db.SaveChanges();
                    this.Tag = newData.malts;
                    this.Close();
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThemGroup_Click(object sender, EventArgs e)
        {
            frmThemMoiLoaiTimKiemGroup frm = new frmThemMoiLoaiTimKiemGroup();
            frm.ShowDialog();
            if (frm.Tag != null)
            {
                loadCbxGroup();
                cbxGroup.SelectedValue = frm.Tag;
            }
        }
    }
}
