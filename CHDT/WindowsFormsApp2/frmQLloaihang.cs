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
    public partial class frmQLloaihang : Form
    {
        public frmQLloaihang()
        {
            InitializeComponent();
        }

        db_QLCHEntities2 dl = new db_QLCHEntities2();

        private void frmQLloaihang_Load(object sender, EventArgs e)
        {
            tblHangsanxuat tblhangsanxuat = new tblHangsanxuat();
            List<hang> lsthangsx = tblhangsanxuat.getLstHang();
            loadHang(lsthangsx);
            cbxTimkiemhang.SelectedIndex = 0;

            tblLoaihang lblLoaihang = new tblLoaihang();
            List<loaihang> lstloaihang = lblLoaihang.getLstLoaihang();
            loadLoaihang(lstloaihang);
           LoadcbxTimkiem(lsthangsx);
        }

        public void loadLoaihang( List<loaihang> lstLoaihang)
        {
            dgvLoaihang.Rows.Clear();
            for (int i = 0; i < lstLoaihang.Count; i++)
            {
                dgvLoaihang.Rows.Add();
                dgvLoaihang.Rows[i].Cells["clMaloaihang"].Value = lstLoaihang[i].maloai;
                dgvLoaihang.Rows[i].Cells["clTenloai"].Value = lstLoaihang[i].tenloai;
            }dgvLoaihang.ClearSelection();
        }
        public void loadHang(List<hang> lstHang)
        {
            dgvHangsanxuat.Rows.Clear();
            for (int i = 0; i < lstHang.Count; i++)
            {
                dgvHangsanxuat.Rows.Add();
                dgvHangsanxuat.Rows[i].Cells["clMahang"].Value = lstHang[i].mahang;
                dgvHangsanxuat.Rows[i].Cells["clTenhang"].Value = lstHang[i].tenhang;
                dgvHangsanxuat.Rows[i].Cells["clSoluong"].Value = lstHang[i].maloai;
            }
            dgvHangsanxuat.ClearSelection();
        }

        public void LoadcbxTimkiem(List<hang> lstHangsx)
        {
            cbxHangsx.ValueMember = "mahang";
            cbxHangsx.DisplayMember = "tenhang";
            cbxHangsx.DataSource = lstHangsx;
        }

        private void btnTimloaihang_Click(object sender, EventArgs e)
        {
            tblLoaihang lblLoaihang = new tblLoaihang();
            List<loaihang> lstLoaihang = lblLoaihang.getLstLoaihang();
            if (txtTimkiemtenloai.Text !="")
            {
                if (cbxTimkiemhang.SelectedIndex == 0)
                {
                    lstLoaihang = lstLoaihang.Where(x => x.maloai.ToString().Contains(txtTimkiemtenloai.Text.ToString())).ToList();
                }
                else
                {
                    lstLoaihang = lstLoaihang.Where(x => x.tenloai.ToLower().Contains(txtTimkiemtenloai.Text.ToLower())).ToList();
                }
            }
          
            loadLoaihang(lstLoaihang);
        }

        private void btnTimkiemhang_Click(object sender, EventArgs e)
        {
            tblHangsanxuat tblhangsanxuat = new tblHangsanxuat();
            List<hang> lstHangsanxuat = tblhangsanxuat.getLstHang();
            if (txtTimkiemhang.Text != "")
            {
                if (cbxHangsx.SelectedIndex == 0)
                {
                    lstHangsanxuat = lstHangsanxuat.Where(c => c.mahang.ToString().Contains(txtTimkiemhang.Text.ToString())).ToList();
                }
                else
                {
                    lstHangsanxuat = lstHangsanxuat.Where(c => c.tenhang.ToLower().Contains(txtTimkiemhang.Text.ToLower())).ToList();
                }
            }loadHang(lstHangsanxuat);
        }

        private void btnThemloai_Click(object sender, EventArgs e)
        {
            frmThemMoiLoaiHang frm = new frmThemMoiLoaiHang();
            frm.ShowDialog();
            if (frm.Tag != null)
            {
                db_QLCHEntities2 dl = new db_QLCHEntities2();
                List<loaihang> lstLoaihang = dl.loaihangs.ToList();
                loadLoaihang(lstLoaihang);
                MessageBox.Show("Thêm mới thành công");
            }
        }

        private void frmQLloaihang_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dlChung.thoatCT == true)
            {
                Application.Exit();
            }
            dlChung.thoatCT = true;
        }

        private void btnXoaloai_Click(object sender, EventArgs e)
        {
            if (dgvLoaihang.SelectedRows.Count >0)
            {
                //  bool trl = MessageBox.Show("Xóa loại hàng","Xác nhận","Đồng ý","thoát");
                tblLoaihang tblLoai = new tblLoaihang();
                for (int i = 0; i < dgvLoaihang.SelectedRows.Count; i++)
                {
                    if (tblLoai.delete(dgvLoaihang.SelectedRows[i].Cells["clMaloaihang"].Value.ToString())== true)
                    {
                        dgvLoaihang.SelectedRows[i].Visible = false;
                    }
                }MessageBox.Show(" Xóa thành công");
            }
            else
            {
                MessageBox.Show(" Chưa chọn hãng");
            }
        }

        private void btnThemhang_Click(object sender, EventArgs e)
        {
           frmThemMoiHangSanXuat frm = new frmThemMoiHangSanXuat();
            frm.ShowDialog();
            if (frm.Tag != null)
            {
                db_QLCHEntities2 dl = new db_QLCHEntities2();
                List<hang> lstHang = dl.hangs.ToList();
                loadHang(lstHang);
                MessageBox.Show("Thêm mới thành công");
            }
        }
        private void dgvLoaihang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            { 
                string Maloaihang = dgvLoaihang.SelectedRows[0].Cells["clMaloaihang"].Value.ToString();
                frmThemMoiLoaiHang frm = new frmThemMoiLoaiHang();
                frm.Tag = Maloaihang;
                frm.ShowDialog();
                
                if (tblLoaihang.Tenloaihang != "")
                {
                    dgvLoaihang.SelectedRows[0].Cells["clTenloaihang"].Value = tblLoaihang.Tenloaihang;
                }
            }
            catch (Exception)
            {

               
            }
        }

        private void dgvHangsanxuat_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string Mahangsx = dgvHangsanxuat.SelectedRows[0].Cells["clMahang"].Value.ToString();
                string Tenhangsx = dgvHangsanxuat.SelectedRows[0].Cells["clTenhang"].Value.ToString();
                frmThemMoiHangSanXuat frm = new frmThemMoiHangSanXuat();
                frm.Tag = Mahangsx;
                frm.ShowDialog();
                if (tblHangsanxuat.Tenhangsx != "")
                {
                    dgvHangsanxuat.SelectedRows[0].Cells["clTenhang"].Value = tblHangsanxuat.Tenhangsx;
                }
            }
            catch (Exception)
            {

            
            }
        }
    }
}
