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
    public partial class frmThemMoiLoaiTimKiemGroup : Form
    {
        public frmThemMoiLoaiTimKiemGroup()
        {
            InitializeComponent();
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            if (txtGroup.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin trên form.");
            }
            else
            {
                db_QLCHEntities2 db = new db_QLCHEntities2();
                loaithongso dta = db.loaithongsoes.FirstOrDefault(x => x.title == txtGroup.Text);
                if (dta != null)
                {
                    MessageBox.Show("Nhóm này đã được tạo.");
                }
                else
                {
                    int? stt = db.loaithongsoes.Where(x => x.id_parent == 0).Max(x => x.stt);
                    loaithongso newData = new loaithongso();
                    newData.title = txtGroup.Text;
                    newData.id_parent = 0;
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
    }
}
