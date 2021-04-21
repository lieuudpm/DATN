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
                List<thongsokythuat> lstSelect = (List<thongsokythuat>) frm.Tag;
                lstThongSoGroup = lstSelect.Where(x => x.idparent == 0).OrderBy(x => x.sothutu).ToList();
                lstThongSo = lstSelect.Where(x => x.idparent != 0).OrderBy(x => x.sothutu).ToList();
                loadDataTsGroup();
            }
        }

        private void loadDataTsGroup()
        {
            if (lstThongSoGroup.Count() > 0)
            {
                lstThongSoGroup = lstThongSoGroup.OrderBy(x => x.sothutu).ToList();
                for (int i = 0; i < lstThongSoGroup.Count(); i++)
                {
                    dgvGroup.Rows.Add();
                    dgvGroup.Rows[i].Cells["clIdTs"].Value = lstThongSoGroup[i].matskt;
                    dgvGroup.Rows[i].Cells["clTieuDe"].Value = lstThongSoGroup[i].ten;
                    dgvGroup.Rows[i].Cells["clSttTs"].Value = lstThongSoGroup[i].sothutu;
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
            db_QLCHEntities2 db = new db_QLCHEntities2();
            List<thongsokythuat> lstData = lstThongSo.Where(x => x.idparent == idNhom && x.isdefault == 1).OrderBy(x => x.sothutu).ToList();

            if (lstData.Count() > 0)
            {
                for (int i = 0; i < lstData.Count(); i++)
                {
                    dgvThongSoKyThuat.Rows.Add();
                    dgvThongSoKyThuat.Rows[i].Cells["clIdTs"].Value = lstData[i].matskt;
                    dgvThongSoKyThuat.Rows[i].Cells["clTieuDe"].Value = lstData[i].ten;
                    dgvThongSoKyThuat.Rows[i].Cells["clSttTs"].Value = lstData[i].sothutu;
                }
            }
            dgvThongSoKyThuat.ClearSelection();
        }

        private void frmThongSoSanPham_Load(object sender, EventArgs e)
        {
            arr = (string[]) this.Tag;
            lblTenSanPham.Text = arr[0];
            loadDataCbxLoaiTimKiem();
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            frmThemMoiLoaiTimKiem frm = new frmThemMoiLoaiTimKiem();
            frm.ShowDialog();
            loadDataLoaiTimKiem();
            loadDataCbxLoaiTimKiem();
        }

        private void loadDataCbxLoaiTimKiem()
        {
            db_QLCHEntities2 db = new db_QLCHEntities2();
            List<loaithongso> lst = db.loaithongsoes.Where(x => x.id_parent == 0).OrderBy(x => x.stt).ToList();
            cbxGroup.Items.Add(new { Text = "Tất cả", Value = -1 });
            for (int i = 0; i < lst.Count; i++)
            {
                cbxGroup.Items.Add(new { Text = lst[i].title, Value = lst[i].malts });
            }

            cbxGroup.ValueMember = "Value";
            cbxGroup.DisplayMember = "Text";
            cbxGroup.SelectedIndex = 0;
        }

        private void loadDataLoaiTimKiem()
        {
            db_QLCHEntities2 db = new db_QLCHEntities2();
            List<loaithongso> lst = db.loaithongsoes.Where(x => x.id_parent == 0).OrderBy(x => x.stt).ToList();
        }
    }
}
