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
    public partial class frmThongTinNhaCungCap : Form
    {
        public frmThongTinNhaCungCap()
        {
            InitializeComponent();
        }
        public string maNhaCungCap = null;
        db_QLCHEntities2 dl = new db_QLCHEntities2();
        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmThongTinNhaCungCap_Load(object sender, EventArgs e)
        {

        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            if (txtSoDienThoai.Text != "" && txtEmail.Text != "")
            {
                db_QLCHEntities2 dl = new db_QLCHEntities2();
          
                nhacungcap dlNhaCungCap = dl.nhacungcaps.FirstOrDefault(c => c.tenncc == txtTenNcc.Text);
                if (dlNhaCungCap != null)
                {
                    MessageBox.Show(" Nhà cung cấp đã được tạo ");
                }
                else
                {
                    nhacungcap newData = new nhacungcap();             
                    newData.tenncc = txtTenNcc.Text;
                    newData.diachi = txtDiaChi.Text;
                    newData.sdt = txtSoDienThoai.Text;
                    newData.email = txtEmail.Text;
                    dl.nhacungcaps.Add(newData);
                    dl.SaveChanges();
                    this.Tag = newData.mancc;
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show(" Bạn cần nhập đủ thông tin để tiếp tục ");
            }
        }
    }
}
