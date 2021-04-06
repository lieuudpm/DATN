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
        tbl_NhanVien tblNhanVien = null;
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
            cbxQuyenhan.SelectedIndex = 0;
            tblNhanVien = new tbl_NhanVien();
            lstNhanvien = tblNhanVien.getLstNhanVien();
            loadDgvHienthi(lstNhanvien);
        }
        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            lstNhanvien = new tbl_NhanVien().getLstNhanVien();
            if (cbxQuyenhan.SelectedIndex == 1)
            {
                lstNhanvien = lstNhanvien.Where(c => c.quyenhan == 2).ToList();
            }
            else if (cbxQuyenhan.SelectedIndex ==2)
            {
                lstNhanvien = lstNhanvien.Where(c => c.quyenhan == 1).ToList();
            }
            if (txtManv.Text != "")
            {
                lstNhanvien = lstNhanvien.Where(c => c.manv.ToString() == txtManv.Text.ToString()).ToList();
            }
            loadDgvHienthi(lstNhanvien);
        }

        private void btnThemnv_Click(object sender, EventArgs e)
        {
            
            frmttNhanvien frm = new frmttNhanvien();
            frm.ShowDialog();
            lstNhanvien = new tbl_NhanVien().getLstNhanVien();
            if (lstNhanvien.Count() != dgvttNV.RowCount)
            {
                loadDgvHienthi(lstNhanvien);
            }
        }

        private void loadDgvHienthi(List<nhanvien> lst)
        {
            dgvttNV.Rows.Clear();
           // lst = lst.Where(c => c.email != "maithulieu@gmail.com" && c.email != ttTaiKhoan.get().email).ToList();
            if (lst.Count > 0)
            {
                for (int i = 0; i < lst.Count; i++)
                {
                    dgvttNV.Rows.Add();
//dgvttNV.Rows[i].Cells["clSTT"].Value = i + 1;
                  //  dgvttNV.Rows[i].Cells["clManv"].Value = i + 1;
                    dgvttNV.Rows[i].Cells["clTennv"].Value = lst[i].tennv;
                    if (lst[i].quyenhan == 1)
                    {
                        dgvttNV.Rows[i].Cells["clQuyenhan"].Value = "Admin";

                    }
                    else if (lst[i].quyenhan == 2)
                    {
                        dgvttNV.Rows[i].Cells["clQuyenhan"].Value = "Nhân viên ";
                    }
                    if (lst[i].trangthai == 0)
                    {
                        dgvttNV.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                        dgvttNV.Rows[i].DefaultCellStyle.ForeColor = Color.Gold;
                    }
                    dgvttNV.Rows[i].Cells["clManv"].Value = lst[i].manv;
                    dgvttNV.Rows[i].Cells["clTennv"].Value = lst[i].tennv;
                    dgvttNV.Rows[i].Cells["clGioitinh"].Value = (lst[i].giottinh == null) ? "Nam" : "Nữ";
                    dgvttNV.Rows[i].Cells["clSdt"].Value = lst[i].sdt;
                    dgvttNV.Rows[i].Cells["clDiachi"].Value = lst[i].diachi;
                    dgvttNV.Rows[i].Cells["clSocmnd"].Value = lst[i].cmnd;
                    dgvttNV.Rows[i].Cells["clEmail"].Value = lst[i].email;
                 //   dgvttNV.Rows[i].Cells["clMatkhau"].Value = lst[i].passwword;
                    dgvttNV.Rows[i].Cells["clTrangthai"].Value = lst[i].trangthai;
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
                nhanvien nv = new tbl_NhanVien().getLstNhanVien().FirstOrDefault();
                if (nv != null)
                {
                    if (nv.quyenhan == 1)
                    {
                        dgvttNV.Rows[e.RowIndex].Cells["clQuyenhan"].Value = "Admin";
                    }
                    else if (nv.quyenhan == 2)
                    {
                        dgvttNV.Rows[e.RowIndex].Cells["clQuyenhan"].Value = "Nhân viên";
                    }
                    if (nv.trangthai == 0)
                    {
                        dgvttNV.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
                        dgvttNV.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Gold;
                    }
                    dgvttNV.Rows[e.RowIndex].Cells["clTennv"].Value = nv.tennv;
                    dgvttNV.Rows[e.RowIndex].Cells["clGioitinh"].Value = (nv.giottinh == null) ? "Nam" : "Nữ";
                    dgvttNV.Rows[e.RowIndex].Cells["clSdt"].Value = nv.sdt;
                    dgvttNV.Rows[e.RowIndex].Cells["clDiachi"].Value = nv.diachi;
                    dgvttNV.Rows[e.RowIndex].Cells["clSocmnd"].Value = nv.cmnd;
                    dgvttNV.Rows[e.RowIndex].Cells["clEmail"].Value = nv.email;
                 //   dgvttNV.Rows[e.RowIndex].Cells["clMatkhau"].Value = nv.passwword;
                   // dgvttNV.Rows[e.RowIndex].Cells["clTrangthai"].Value = nv.trangthai;
                }
                else
                {
                    dgvttNV.Rows.Remove(dgvttNV.Rows[e.RowIndex]);
                }
            }     
        }

        private void dgvttNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEnableDisable_Click(object sender, EventArgs e)
        {
            tbl_NhanVien tbltaikhoan = new tbl_NhanVien();
            if (dgvttNV.SelectedRows.Count >0)
            {
                foreach (DataGridViewRow row in dgvttNV.SelectedRows )
                {
                    string maNhanvien = row.Cells["clManv"].Value.ToString();
                    nhanvien tk = tbltaikhoan.getLstNhanVien().First(c => c.tennv == maNhanvien);
                    if (tk.trangthai == 0)
                    {
                        tk.trangthai = 1;
                    }
                    else
                    {
                        tk.trangthai = 0;
                    }

                    if (tbltaikhoan.update()== true)
                    {
                        loadDgvHienthi(new tbl_NhanVien().getLstNhanVien());
                    }
                }
            }
        }

        private void ucMenu1_Load(object sender, EventArgs e)
        {

        }
    }
}
