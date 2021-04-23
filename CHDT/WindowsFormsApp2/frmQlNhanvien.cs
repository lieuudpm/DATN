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
    public partial class frmQlNhanvien : Form
    {
        public frmQlNhanvien()
        {
            InitializeComponent();
        }
        db_QLCHEntities2 dl = new db_QLCHEntities2();
        List<nhanvien> lstNhanvien = null;

        private void frmQlNhanvien_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dlChung.thoatCT == true)
            {
                Application.Exit();
            }
            dlChung.thoatCT = true;
        }

        private void frmQlNhanvien_Load(object sender, EventArgs e)
        {
            cbxQuyenhan.SelectedIndex = 4;            
            List<nhanvien> lstNhanvien = dl.nhanviens.ToList();
            loadDgvHienthi(lstNhanvien);
        }
        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            lstNhanvien = dl.nhanviens.ToList();
            if (cbxQuyenhan.SelectedIndex < 4)
            {
                lstNhanvien = lstNhanvien.Where(c => c.quyenhan == cbxQuyenhan.SelectedIndex).ToList();
            }
           
            if (txtSoDienThoai.Text != "")
            {
                lstNhanvien = lstNhanvien.Where(x => x.sdt.Contains(txtSoDienThoai.Text)).ToList();
            }
            if (txtTenNhanVien.Text != "")
            {
                lstNhanvien = lstNhanvien.Where(x => x.tennv.Contains(txtTenNhanVien.Text)).ToList();
            }
            if (txtSoCmnd.Text != "")
            {
                lstNhanvien = lstNhanvien.Where(x => x.cmnd.Contains(txtSoCmnd.Text)).ToList();
            }

            if (rdbNvnam.Checked == true)
            {
                lstNhanvien = lstNhanvien.Where(x =>  dlChung.isGoiTinhNam(x.giottinh)==true).ToList();
            }
            else if (rdbNvnu.Checked == true)
            {
                lstNhanvien = lstNhanvien.Where(x => dlChung.isGoiTinhNu(x.giottinh) == true).ToList();
            }
            loadDgvHienthi(lstNhanvien);
        }

        private void btnThemnv_Click(object sender, EventArgs e)
        {

            frmttNhanvien frm = new frmttNhanvien();
            frm.ShowDialog();
            if(frm.Tag!=null && frm.Tag.ToString() == "ok")
            {
                loadDgvHienthi(dl.nhanviens.ToList());
            }
        }

        private void loadDgvHienthi(List<nhanvien> lst)
        {
            dgvttNV.Rows.Clear();
            if (lst.Count > 0)
            {
                for (int i = 0; i < lst.Count; i++)
                {
                    dgvttNV.Rows.Add();
                    dgvttNV.Rows[i].Cells["clQuyenhan"].Value = dlChung.quyenHanLabel(lst[i].quyenhan);
                    if (lst[i].trangthai == 0)
                    {
                        dgvttNV.Rows[i].DefaultCellStyle.BackColor = Color.Gray;
                        dgvttNV.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                    }
                    dgvttNV.Rows[i].Cells["clManv"].Value = lst[i].manv;
                    dgvttNV.Rows[i].Cells["clTennv"].Value = lst[i].tennv;
                    dgvttNV.Rows[i].Cells["clGioitinh"].Value = dlChung.gioiTinhLabel(lst[i].giottinh);
                    dgvttNV.Rows[i].Cells["clSdt"].Value = lst[i].sdt;
                    dgvttNV.Rows[i].Cells["clDiachi"].Value = lst[i].diachi;
                    dgvttNV.Rows[i].Cells["clSocmnd"].Value = lst[i].cmnd;
                    dgvttNV.Rows[i].Cells["clEmail"].Value = lst[i].email;
                    dgvttNV.Rows[i].Cells["clTrangthai"].Value = lst[i].trangthai == 0 ? "Không hoạt đông" : " Hoạt động";
                }
                dgvttNV.ClearSelection();
            }
        }

        private void dgvttNV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string maNhanvien = dgvttNV.Rows[e.RowIndex].Cells["clManv"].Value.ToString();
                frmttNhanvien frm = new frmttNhanvien();
                frm.Tag = maNhanvien;
                frm.ShowDialog();
                if (frm.Tag != null && frm.Tag.ToString() == "ok")
                {
                    dl = new db_QLCHEntities2();
                    loadDgvHienthi(dl.nhanviens.ToList());
                }
            }
        }

        private void dgvttNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEnableDisable_Click(object sender, EventArgs e)
        {
            if(dgvttNV.SelectedRows.Count >= 1)
            {
                DialogResult result = MessageBox.Show("Bạn thực sự muốn thay đổi trạng thái không?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    int manv = Int32.Parse(dgvttNV.SelectedRows[0].Cells["clManv"].Value.ToString());
                    nhanvien editData = dl.nhanviens.FirstOrDefault(x => x.manv == manv);
                    editData.trangthai = editData.trangthai == 0 ? 1 : 0;
                    dl.SaveChanges();
                    dl = new db_QLCHEntities2();
                    loadDgvHienthi(dl.nhanviens.ToList());
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để tiếp tục.");
            }
            
        }
   
        private void btnHoanTac_Click(object sender, EventArgs e)
        {
            List<nhanvien> lstNhanvien = dl.nhanviens.ToList();
            loadDgvHienthi(lstNhanvien);
        }     
    }
}
