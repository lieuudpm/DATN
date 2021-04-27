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
    public partial class frmThemmoichitietbaohanh : Form
    {
        public frmThemmoichitietbaohanh()
        {
            InitializeComponent();
        }
        string Id = "";
        private void frmThemmoichitietbaohanh_Load(object sender, EventArgs e)
        {
            dtpNgayBatDau.Value = DateTime.Now.AddDays(-30);
            loadData();
        }
        private void loadData()
        {
            db_QLCHEntities2 dl = new db_QLCHEntities2();
            if (this.Tag != null)
            {
                int id = int.Parse(this.Tag.ToString());
                dondathang ct = dl.dondathangs.FirstOrDefault(c => c.maddh == id);
                txtTenKhachHang.Text = ct.khachhang.tenkh;
                txtDiaChi.Text = ct.khachhang.diachi;
                txtSoDt.Text = ct.khachhang.sdt;
                txtGhiChu.Text = ct.ghichu;
                txtIdDonHang.Text = id.ToString();
                dtpNgayBatDau.Value = ct.ngaydathang.Value;              
                int i = 0;
                dgvHienThi.Rows.Clear();
                foreach (var item in ct.ct_dondathang)
                {
                    dgvHienThi.Rows.Add();
                    dgvHienThi.Rows[i].Cells["clMasp"].Value = item.mactsp;
                    dgvHienThi.Rows[i].Cells["clTensp"].Value = item.ct_sanpham.sanpham.tensp;
                    dgvHienThi.Rows[i].Cells["clSoserial"].Value = item.soserial;
                    i++;
                }
            }
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTaoBaoHanh_Click(object sender, EventArgs e)
        {
            Id = txtIdDonHang.Text;
            db_QLCHEntities2 dl = new db_QLCHEntities2();
            int intSoHoaDon;
            if (int.TryParse(Id,out intSoHoaDon) == true)
            {
                if (txtTenKhachHang.Text != null && txtSoDt.Text != null && txtIdDonHang.Text != null)
                {
                    ct_baohanh newData = new ct_baohanh();
                    newData.manv = ttTaiKhoan.get().manv;
                    newData.ngaynhanmay = dtpNgayBatDau.Value;
                    newData.ngaytrathucte = dtpNgayKetThuc.Value;
                    for (int i = 0; i < dgvHienThi.Rows.Count; i++)
                    {
                        string tensp = (dgvHienThi.Rows[i].Cells["clTensp"].Value ?? "").ToString();
                        string soSerial = (dgvHienThi.Rows[i].Cells["clSoserial"].Value ?? "").ToString();

                        newData.soserial = soSerial;
                        dl.ct_baohanh.Add(newData);
                        dl.SaveChanges();
                    }

                   // dl.ct_baohanh.Add(newData);
                  
                    MessageBox.Show("Thêm Bảo hành thành công ");
                }
                else
                {
                    MessageBox.Show("Bạn cần nhập đủ thông tin để tiếp tục");
                }

            }
            else
            {
                MessageBox.Show("Số hóa đơn không hợp lệ ");
            }

        }
    }
}
