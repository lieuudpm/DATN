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
    public partial class frmThongSoParentList : Form
    {
        public frmThongSoParentList()
        {
            InitializeComponent();
        }

        private void frmThemmoisanpham_Load(object sender, EventArgs e)
        {

            loadData();

        }

        private void loadData()
        {
            db_QLCHEntities2 db = new db_QLCHEntities2();
            List<thongsokythuat> lstData = db.thongsokythuats.Where(x => x.idparent == 0 && x.isdefault == 1).OrderBy(x => x.sothutu).ToList();
            dgvHienThi.Rows.Clear();
            if (lstData.Count() > 0)
            {
                for (int i = 0; i < lstData.Count(); i++)
                {
                    dgvHienThi.Rows.Add();
                    dgvHienThi.Rows[i].Cells["clId"].Value = lstData[i].matskt;
                    dgvHienThi.Rows[i].Cells["clGroup"].Value = lstData[i].ten;
                    dgvHienThi.Rows[i].Cells["clStt"].Value = lstData[i].sothutu;
                }
            }
            dgvHienThi.ClearSelection();

        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            if (txtGroup.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên nhóm.");
            }
            else
            {
                db_QLCHEntities2 db = new db_QLCHEntities2();
                thongsokythuat data = db.thongsokythuats.FirstOrDefault(x => x.ten == txtGroup.Text && x.isdefault == 1);
                if (data != null)
                {
                    MessageBox.Show("Tên này đã được tạo.");
                }
                else
                {
                    int? stt = db.thongsokythuats.Where(x => x.idparent == 0 && x.isdefault == 1).Max(x => x.sothutu);
                    thongsokythuat newData = new thongsokythuat();
                    newData.ten = txtGroup.Text;
                    newData.idparent = 0;
                    newData.sothutu = stt == null ? 1 : stt + 1;
                    newData.isdefault = 1;
                    db.thongsokythuats.Add(newData);
                    db.SaveChanges();
                    loadData();
                    txtGroup.Text = "";
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void btnArrowTop_Click(object sender, EventArgs e)
        {
            if (dgvHienThi.SelectedRows.Count == 1)
            {
                db_QLCHEntities2 db = new db_QLCHEntities2();
                int sttMinChange = Int32.Parse(dgvHienThi.SelectedRows[0].Cells["clStt"].Value.ToString());
                thongsokythuat thongsokythuatChange = db.thongsokythuats.Where(x => x.sothutu < sttMinChange && x.isdefault == 1 && x.idparent == 0).OrderByDescending(x => x.sothutu).FirstOrDefault();

                if (thongsokythuatChange == null)
                {
                    return;
                }
                int rowIndex = dgvHienThi.SelectedRows[0].Index;
                int? sttTam = thongsokythuatChange.sothutu;
                int id = Int32.Parse(dgvHienThi.SelectedRows[0].Cells["clId"].Value.ToString());
                thongsokythuat editData = db.thongsokythuats.First(x => x.matskt == id);
                thongsokythuatChange.sothutu = editData.sothutu;
                editData.sothutu = sttTam;
                db.SaveChanges();
                loadData();
                dgvHienThi.Rows[rowIndex - 1].Selected = true;
            }
            else
            {
                MessageBox.Show("Chọn một dòng cần di chuyển");
            }
        }

        private void btnArrowDown_Click(object sender, EventArgs e)
        {
            if (dgvHienThi.SelectedRows.Count == 1)
            {
                db_QLCHEntities2 db = new db_QLCHEntities2();
                int sttMinChange = Int32.Parse(dgvHienThi.SelectedRows[0].Cells["clStt"].Value.ToString());
                thongsokythuat thongsokythuatChange = db.thongsokythuats.Where(x => x.sothutu > sttMinChange && x.isdefault == 1 && x.idparent == 0).OrderBy(x => x.sothutu).FirstOrDefault();

                if (thongsokythuatChange == null)
                {
                    return;
                }
                int rowIndex = dgvHienThi.SelectedRows[0].Index;
                int? sttTam = thongsokythuatChange.sothutu;
                int id = Int32.Parse(dgvHienThi.SelectedRows[0].Cells["clId"].Value.ToString());
                thongsokythuat editData = db.thongsokythuats.First(x => x.matskt == id);
                thongsokythuatChange.sothutu = editData.sothutu;
                editData.sothutu = sttTam;
                db.SaveChanges();
                loadData();
                dgvHienThi.Rows[rowIndex + 1].Selected = true;
            }
            else
            {
                MessageBox.Show("Chọn một dòng cần di chuyển");
            }
        }

        private void btnThemTitleTs_Click(object sender, EventArgs e)
        {
            if (txtTitleTs.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên thông số.");
                return;
            }

            if (dgvHienThi.SelectedRows.Count != 1)
            {
                MessageBox.Show("Vui lòng chọn một nhóm.");
                return;
            }
            int idNhom = Int32.Parse(dgvHienThi.SelectedRows[0].Cells["clId"].Value.ToString());
            db_QLCHEntities2 db = new db_QLCHEntities2();
            thongsokythuat data = db.thongsokythuats.FirstOrDefault(x => x.ten == txtTitleTs.Text && x.isdefault == 1 && x.idparent == idNhom);
            if (data != null)
            {
                MessageBox.Show("Tên này đã được tạo.");
            }
            else
            {
                int? stt = db.thongsokythuats.Where(x => x.idparent == idNhom && x.isdefault == 1).Max(x => x.sothutu);
                thongsokythuat newData = new thongsokythuat();
                newData.ten = txtTitleTs.Text;
                newData.idparent = idNhom;
                newData.sothutu = stt == null ? 1 : stt + 1;
                newData.isdefault = 1;
                db.thongsokythuats.Add(newData);
                db.SaveChanges();
                loadDataTs();
                txtTitleTs.Text = "";
            }
        }

        private void loadDataTs()
        {
            if (dgvHienThi.SelectedRows.Count != 1)
            {
                return;
            }
            int idNhom = Int32.Parse(dgvHienThi.SelectedRows[0].Cells["clId"].Value.ToString());
            db_QLCHEntities2 db = new db_QLCHEntities2();
            List<thongsokythuat> lstData = db.thongsokythuats.Where(x => x.idparent == idNhom && x.isdefault == 1).OrderBy(x => x.sothutu).ToList();
            dgvThongSo.Rows.Clear();
            if (lstData.Count() > 0)
            {
                for (int i = 0; i < lstData.Count(); i++)
                {
                    dgvThongSo.Rows.Add();
                    dgvThongSo.Rows[i].Cells["clIdTs"].Value = lstData[i].matskt;
                    dgvThongSo.Rows[i].Cells["clTitle"].Value = lstData[i].ten;
                    dgvThongSo.Rows[i].Cells["clSttTs"].Value = lstData[i].sothutu;
                }
            }
            dgvThongSo.ClearSelection();
        }

        private void dgvHienThi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            loadDataTs();
        }

        private void btnArrowTopTs_Click(object sender, EventArgs e)
        {

            if (dgvThongSo.SelectedRows.Count == 1)
            {
                db_QLCHEntities2 db = new db_QLCHEntities2();
                int idNhom = Int32.Parse(dgvHienThi.SelectedRows[0].Cells["clId"].Value.ToString());
                int sttMinChange = Int32.Parse(dgvThongSo.SelectedRows[0].Cells["clSttTs"].Value.ToString());
                thongsokythuat thongsokythuatChange = db.thongsokythuats.Where(x => x.sothutu < sttMinChange && x.isdefault == 1 && x.idparent == idNhom).OrderByDescending(x => x.sothutu).FirstOrDefault();

                if (thongsokythuatChange == null)
                {
                    return;
                }
                int rowIndex = dgvThongSo.SelectedRows[0].Index;
                int? sttTam = thongsokythuatChange.sothutu;
                int id = Int32.Parse(dgvThongSo.SelectedRows[0].Cells["clIdTs"].Value.ToString());
                thongsokythuat editData = db.thongsokythuats.First(x => x.matskt == id);
                thongsokythuatChange.sothutu = editData.sothutu;
                editData.sothutu = sttTam;
                db.SaveChanges();
                loadDataTs();
                dgvThongSo.Rows[rowIndex - 1].Selected = true;
            }
            else
            {
                MessageBox.Show("Chọn một dòng cần di chuyển");
            }
        }

        private void btnArrowDownTs_Click(object sender, EventArgs e)
        {
            if (dgvThongSo.SelectedRows.Count == 1)
            {
                db_QLCHEntities2 db = new db_QLCHEntities2();
                int idNhom = Int32.Parse(dgvHienThi.SelectedRows[0].Cells["clId"].Value.ToString());
                int sttMinChange = Int32.Parse(dgvThongSo.SelectedRows[0].Cells["clSttTs"].Value.ToString());
                thongsokythuat thongsokythuatChange = db.thongsokythuats.Where(x => x.sothutu > sttMinChange && x.isdefault == 1 && x.idparent == idNhom).OrderBy(x => x.sothutu).FirstOrDefault();

                if (thongsokythuatChange == null)
                {
                    return;
                }
                int rowIndex = dgvThongSo.SelectedRows[0].Index;
                int? sttTam = thongsokythuatChange.sothutu;
                int id = Int32.Parse(dgvThongSo.SelectedRows[0].Cells["clIdTs"].Value.ToString());
                thongsokythuat editData = db.thongsokythuats.First(x => x.matskt == id);
                thongsokythuatChange.sothutu = editData.sothutu;
                editData.sothutu = sttTam;
                db.SaveChanges();
                loadDataTs();
                dgvThongSo.Rows[rowIndex + 1].Selected = true;
            }
            else
            {
                MessageBox.Show("Chọn một dòng cần di chuyển");
            }
        }
    }
}
