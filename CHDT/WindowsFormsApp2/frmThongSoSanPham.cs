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
    public partial class frmThongSoSanPham : Form
    {
        public frmThongSoSanPham()
        {
            InitializeComponent();
        }

        string[] arr;
        List<thongsokythuat> lstThongSoGroup = new List<thongsokythuat>();
        List<thongsokythuat> lstThongSo = new List<thongsokythuat>();

        private void btnSanCo_Click(object sender, EventArgs e)
        {
            frmThongSoParentList frm = new frmThongSoParentList();
            frm.ShowDialog();
            if (frm.Tag != null)
            {
                List<thongsokythuat> lstSelect = (List<thongsokythuat>)frm.Tag;
                List<thongsokythuat> tam = lstSelect.Where(x => x.idparent == 0).OrderBy(x => x.sothutu).ToList();
                for (int i = 0; i < tam.Count; i++)
                {
                    thongsokythuat checkExits = lstThongSoGroup.FirstOrDefault(x => x.ten == tam[i].ten);
                    if (checkExits == null)
                    {
                        int? stt = lstThongSoGroup.Max(x => x.sothutu);
                        thongsokythuat newData = new thongsokythuat();
                        newData.ten = tam[i].ten;
                        newData.idparent = 0;
                        newData.sothutu = stt == null ? 1 : stt + 1;
                        newData.isdefault = 0;
                        lstThongSoGroup.Add(newData);
                        int idNhom = tam[i].matskt;
                        idNhom = idNhom > 0 ? idNhom : (int)tam[i].sothutu;
                        List<thongsokythuat> tamTs = lstSelect.Where(x => x.idparent == idNhom).OrderBy(x => x.sothutu).ToList();
                        for (int j = 0; j < tamTs.Count; j++)
                        {
                            checkExits = lstThongSo.FirstOrDefault(x => x.ten == tamTs[j].ten && x.idparent == newData.sothutu);
                            if (checkExits == null)
                            {
                                stt = lstThongSo.Max(x => x.sothutu);
                                thongsokythuat newDataTs = new thongsokythuat();
                                newDataTs.ten = tamTs[j].ten;
                                newDataTs.idparent = newData.sothutu;
                                newDataTs.sothutu = stt == null ? 1 : stt + 1;
                                newDataTs.isdefault = 0;
                                lstThongSo.Add(newDataTs);
                            }
                        }
                    }
                }
                loadDataTsGroup();
            }
        }

        private void loadDataTsGroup(bool loadAgain = false)
        {
            if (lstThongSoGroup.Count() > 0)
            {
                if (loadAgain)
                {
                    dgvGroup.Rows.Clear();
                }
                List<thongsokythuat> lstData = lstThongSoGroup.Where(x => x.sothutu > 0).OrderBy(x => x.sothutu).ToList();
                int index = dgvGroup.Rows.Count;
                for (int i = 0; i < lstData.Count(); i++)
                {
                    bool check = false;
                    for (int j = 0; j < dgvGroup.Rows.Count; j++)
                    {
                        string ten = dgvGroup.Rows[j].Cells["clGroup"].Value != null ? dgvGroup.Rows[j].Cells["clGroup"].Value.ToString() : "";
                        if (lstData[i].ten.Trim().ToUpper() == ten.Trim().ToUpper())
                        {
                            check = true;
                            break;
                        }
                    }
                    if (check)
                    {
                        continue;
                    }
                    dgvGroup.Rows.Add();
                    dgvGroup.Rows[index].Cells["clId"].Value = lstData[i].matskt;
                    dgvGroup.Rows[index].Cells["clGroup"].Value = lstData[i].ten;
                    dgvGroup.Rows[index].Cells["clStt"].Value = lstData[i].sothutu;
                    index++;
                }
            }
            dgvGroup.ClearSelection();
        }

        private void loadDataTs()
        {
            dgvThongSoKyThuat.Rows.Clear();
            if (dgvGroup.SelectedRows.Count != 1)
            {
                return;
            }
            int idNhom = Int32.Parse(dgvGroup.SelectedRows[0].Cells["clId"].Value.ToString());
            idNhom = idNhom > 0 ? idNhom : Int32.Parse(dgvGroup.SelectedRows[0].Cells["clStt"].Value.ToString());
            List<thongsokythuat> lstData = lstThongSo.Where(x => x.idparent == idNhom && x.sothutu > 0).OrderBy(x => x.sothutu).ToList();

            if (lstData.Count() > 0)
            {
                for (int i = 0; i < lstData.Count(); i++)
                {
                    dgvThongSoKyThuat.Rows.Add();
                    dgvThongSoKyThuat.Rows[i].Cells["clIdTs"].Value = lstData[i].matskt;
                    dgvThongSoKyThuat.Rows[i].Cells["clTieuDe"].Value = lstData[i].ten;
                    dgvThongSoKyThuat.Rows[i].Cells["clSttTs"].Value = lstData[i].sothutu;
                    dgvThongSoKyThuat.Rows[i].Cells["clIdparent"].Value = lstData[i].idparent;
                    dgvThongSoKyThuat.Rows[i].Cells["clThongso"].Value = lstData[i].thongsokythuat1;
                }
            }
            dgvThongSoKyThuat.ClearSelection();
        }

        private void frmThongSoSanPham_Load(object sender, EventArgs e)
        {

            arr = (string[])this.Tag;
            lblTenSanPham.Text = arr[0];
            if (arr[1] != "")
            {
                db_QLCHEntities2 db = new db_QLCHEntities2();
                int idSanPham = Int32.Parse(arr[1]);
                lstThongSoGroup = db.thongsokythuats.Where(x => x.idparent == 0 && x.masp == idSanPham).ToList();
                lstThongSo = db.thongsokythuats.Where(x => x.idparent != 0 && x.masp == idSanPham).ToList();
                loadDataTsGroup();
            }
            this.Tag = null;
        }

        private void loadDataLoaiTimKiem()
        {
            db_QLCHEntities2 db = new db_QLCHEntities2();
            List<loaithongso> lst = db.loaithongsoes.Where(x => x.id_parent == 0).OrderBy(x => x.stt).ToList();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            this.Tag = null;
            lstThongSoGroup.AddRange(lstThongSo);
            this.Tag = lstThongSoGroup;
            this.Close();
        }

        private void dgvGroup_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            loadDataTs();
        }

        private void dgvThongSoKyThuat_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3 || e.ColumnIndex == 0)
            {
                int stt = (int)dgvThongSoKyThuat.Rows[e.RowIndex].Cells["clSttTs"].Value;
                var index = lstThongSo.FindIndex(x => x.sothutu == stt);
                lstThongSo[index].thongsokythuat1 = (dgvThongSoKyThuat.Rows[e.RowIndex].Cells["clThongSo"].Value ?? "").ToString();
                lstThongSo[index].ten = (dgvThongSoKyThuat.Rows[e.RowIndex].Cells["clTieuDe"].Value ?? "").ToString();
            }
        }

        private void btnArrowTop_Click(object sender, EventArgs e)
        {
            if (dgvGroup.SelectedRows.Count == 1)
            {
                int rowIndex = dgvGroup.CurrentRow.Index;
                if (rowIndex - 1 >= 0)
                {

                    lstThongSoGroup[rowIndex].sothutu = (int)dgvGroup.Rows[rowIndex - 1].Cells["clStt"].Value;
                    lstThongSoGroup[rowIndex - 1].sothutu = (int)dgvGroup.Rows[rowIndex].Cells["clStt"].Value;
                    loadDataTsGroup(true);
                    dgvGroup.Rows[rowIndex - 1].Selected = true;
                }
            }
            else
            {
                MessageBox.Show("Chọn một dòng cần di chuyển");
            }
        }

        private void btnArrowDown_Click(object sender, EventArgs e)
        {
            if (dgvGroup.SelectedRows.Count == 1)
            {
                int rowIndex = dgvGroup.CurrentRow.Index;
                if (rowIndex + 1 < dgvGroup.Rows.Count)
                {

                    lstThongSoGroup[rowIndex].sothutu = (int)dgvGroup.Rows[rowIndex + 1].Cells["clStt"].Value;
                    lstThongSoGroup[rowIndex + 1].sothutu = (int)dgvGroup.Rows[rowIndex].Cells["clStt"].Value;
                    loadDataTsGroup(true);
                    dgvGroup.Rows[rowIndex + 1].Selected = true;
                }
            }
            else
            {
                MessageBox.Show("Chọn một dòng cần di chuyển");
            }
        }


        private void dgvGroup_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                int stt = (int)dgvGroup.Rows[e.RowIndex].Cells["clStt"].Value;
                var index = lstThongSoGroup.FindIndex(x => x.sothutu == stt);
                lstThongSoGroup[index].ten = dgvGroup.Rows[e.RowIndex].Cells["clGroup"].Value.ToString();
            }
        }

        private void btnAddTsGroup_Click(object sender, EventArgs e)
        {
            int? stt = lstThongSoGroup.Max(x => x.sothutu);
            thongsokythuat newData = new thongsokythuat();
            newData.ten = "";
            newData.idparent = 0;
            newData.sothutu = stt == null ? 1 : stt + 1;
            newData.isdefault = 0;
            lstThongSoGroup.Add(newData);
            loadDataTsGroup(true);
        }

        private void btnAddTs_Click(object sender, EventArgs e)
        {
            if (dgvGroup.SelectedRows.Count == 1)
            {
                int idNhom = Int32.Parse(dgvGroup.SelectedRows[0].Cells["clId"].Value.ToString());
                idNhom = idNhom > 0 ? idNhom : Int32.Parse(dgvGroup.SelectedRows[0].Cells["clStt"].Value.ToString());
                int? stt = lstThongSo.Max(x => x.sothutu);
                thongsokythuat newDataTs = new thongsokythuat();
                newDataTs.idparent = idNhom;
                newDataTs.sothutu = stt == null ? 1 : stt + 1;
                newDataTs.isdefault = 0;
                lstThongSo.Add(newDataTs);
                loadDataTs();
            }
            else
            {
                MessageBox.Show("Chọn một dòng thông số group.");
            }
        }

        private void btnArrowDownTs_Click(object sender, EventArgs e)
        {

            if (dgvThongSoKyThuat.SelectedRows.Count == 1)
            {
                int rowIndex = dgvThongSoKyThuat.CurrentRow.Index;
                if (rowIndex + 1 < dgvThongSoKyThuat.Rows.Count)
                {
                    int stt = (int)dgvThongSoKyThuat.Rows[rowIndex].Cells["clSttTs"].Value;
                    int index = lstThongSo.FindIndex(x => x.sothutu == stt);
                    lstThongSo[index].sothutu = (int)dgvThongSoKyThuat.Rows[rowIndex + 1].Cells["clSttTs"].Value;
                    lstThongSo[index + 1].sothutu = (int)dgvThongSoKyThuat.Rows[rowIndex].Cells["clSttTs"].Value;
                    loadDataTs();
                    dgvThongSoKyThuat.Rows[rowIndex + 1].Selected = true;
                    lstThongSo = lstThongSo.OrderBy(x => x.sothutu).ToList();
                }
            }
            else
            {
                MessageBox.Show("Chọn một dòng cần di chuyển");
            }
        }

        private void btnArrowTopTs_Click(object sender, EventArgs e)
        {
            if (dgvThongSoKyThuat.SelectedRows.Count == 1)
            {
                int rowIndex = dgvThongSoKyThuat.CurrentRow.Index;
                if (rowIndex - 1 >= 0)
                {
                    int stt = (int)dgvThongSoKyThuat.Rows[rowIndex].Cells["clSttTs"].Value;
                    int index = lstThongSo.FindIndex(x => x.sothutu == stt);
                    lstThongSo[index].sothutu = (int)dgvThongSoKyThuat.Rows[rowIndex - 1].Cells["clSttTs"].Value;
                    lstThongSo[index - 1].sothutu = (int)dgvThongSoKyThuat.Rows[rowIndex].Cells["clSttTs"].Value;
                    loadDataTs();
                    lstThongSo = lstThongSo.OrderBy(x => x.sothutu).ToList();
                }
            }
            else
            {
                MessageBox.Show("Chọn một dòng cần di chuyển");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvGroup.SelectedRows.Count == 1)
            {
                int rowIndex = dgvGroup.CurrentRow.Index;
                int stt = (int)dgvGroup.Rows[rowIndex].Cells["clStt"].Value;
                int index = lstThongSoGroup.FindIndex(x => x.sothutu == stt);
                lstThongSoGroup[index].sothutu = -1;
                List<thongsokythuat> lstData = lstThongSo.Where(x => x.idparent == lstThongSoGroup[index].matskt && x.sothutu > 0).OrderBy(x => x.sothutu).ToList();
                if (lstData.Count() > 0)
                {
                    for (int i = 0; i < lstData.Count(); i++)
                    {
                        index = lstThongSo.FindIndex(x => x.sothutu == lstData[i].sothutu);
                        lstThongSo[index].sothutu = -1;
                    }
                }
                loadDataTsGroup(true);
                loadDataTs();
            }
            else
            {
                MessageBox.Show("Chọn một dòng cần di chuyển");
            }
        }

        private void btnRemoveTs_Click(object sender, EventArgs e)
        {
            if (dgvThongSoKyThuat.SelectedRows.Count == 1)
            {
                int rowIndex = dgvThongSoKyThuat.CurrentRow.Index;
                int stt = (int)dgvThongSoKyThuat.Rows[rowIndex].Cells["clSttTs"].Value;
                int index = lstThongSo.FindIndex(x => x.sothutu == stt);
                lstThongSo[index].sothutu = -1;
                loadDataTs();
            }
            else
            {
                MessageBox.Show("Chọn một dòng cần di chuyển");
            }
        }
    }
}
