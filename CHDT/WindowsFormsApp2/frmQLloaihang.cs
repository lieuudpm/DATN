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
        

            tblLoaihang lblLoaihang = new tblLoaihang();
            List<loaihang> lstloaihang = lblLoaihang.getLstLoaihang();
            loadLoaihang(lstloaihang);
           
        }

        public void loadLoaihang(List<loaihang> lstLoaihang)
        {
            dgvLoaihang.Rows.Clear();
            for (int i = 0; i < lstLoaihang.Count; i++)
            {
                dgvLoaihang.Rows.Add();
                dgvLoaihang.Rows[i].Cells["clMaloaihang"].Value = lstLoaihang[i].maloai;
                dgvLoaihang.Rows[i].Cells["clTenloai"].Value = lstLoaihang[i].tenloai;
            }
            dgvLoaihang.ClearSelection();
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

        private void btnTimloaihang_Click(object sender, EventArgs e)
        {
            tblLoaihang lblLoaihang = new tblLoaihang();
            List<loaihang> lstLoaihang = lblLoaihang.getLstLoaihang();
            if (txtTimkiemtenloai.Text != "")
            {
                lstLoaihang = lstLoaihang.Where(x => x.tenloai.ToLower().Contains(txtTimkiemtenloai.Text.ToLower())).ToList();
                loadLoaihang(lstLoaihang);
            }
            else
            {
                loadLoaihang(lstLoaihang);
            }         
        }
        
        private void btnTimkiemhang_Click(object sender, EventArgs e)
        {
            dl = new db_QLCHEntities2();
            List<hang> lstHangsanxuat = null;
            lstHangsanxuat = dl.hangs.ToList();
            if (txtTimkiemhang.Text != "")
            {
                lstHangsanxuat = lstHangsanxuat.Where(x => x.tenhang.Contains(txtTimkiemhang.Text)).ToList();
            }

            loadHang(lstHangsanxuat);

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
            if (dgvLoaihang.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn thực sự muốn xóa không?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    int maLoai = Int32.Parse(dgvLoaihang.SelectedRows[0].Cells["clMaloaihang"].Value.ToString());
                 loaihang deleteData = dl.loaihangs.FirstOrDefault(x => x.maloai == maLoai);
                    dl.loaihangs.Remove(deleteData);
                    dl.SaveChanges();
                    dl = new db_QLCHEntities2();
                   loadLoaihang(dl.loaihangs.ToList());

                }
            }
            else
            {
                MessageBox.Show("Chọn Một loại hàng để tiếp tục");
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

        private void btnXoahang_Click(object sender, EventArgs e)
        {
            if (dgvHangsanxuat.SelectedRows.Count >= 1)
            {
                DialogResult result = MessageBox.Show("Bạn thực sự muốn xóa không?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    int maHang = Int32.Parse(dgvHangsanxuat.SelectedRows[0].Cells["clMahang"].Value.ToString());
                    hang deleteData = dl.hangs.FirstOrDefault(x => x.mahang == maHang);
                    dl.hangs.Remove(deleteData);
                    dl.SaveChanges();
                    dl = new db_QLCHEntities2();
                    loadHang(dl.hangs.ToList());

                }

            }
            else
            {
                MessageBox.Show(" Vui lòng chọn một hãng để tiếp tục");
            }

        }
    }

}
