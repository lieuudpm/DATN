using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Classss;


namespace WindowsFormsApp2
{
    public partial class ucMenu : UserControl
    {
        public ucMenu()
        {
            InitializeComponent();
            setcolor();
        }


        private void setcolor()
        {
            Form frm = this.ParentForm;
            if (frm is frmhome)
            {
                setcolor(lbltrangchu);
            }
            else if (frm is frmQlNhanvien)
            {
                setcolor(lblQlnhanvien);
            }
            else if (frm is frmQlsanpham)
            {
                setcolor(lblQlsanpham);
            }
            else if (frm is frmQldonhangnhap)
            {
                setcolor(lblQldonhangnhap);
            }
            else if (frm is frmDondathang)
            {
                setcolor(lblQLdondathang);
            }
            else if (frm is frmBaohanh)
            {
                setcolor(lblQlbaohanh);
            }
            else if (frm is frmBaocao)
            {
                setcolor(lblBaocao);

            }
            else if (frm is frmThongke)
            {
                setcolor(lblThongke);
            }
        }


        private void setcolor(Label lbl)
        {
            lbl.ForeColor = Color.Yellow;
            lbl.BackColor = Color.FromArgb(192, 0, 0);
            lbl.Font = new Font(lbl.Font, FontStyle.Underline | FontStyle.Regular);
        }

        private void lbltrangchu_Click(object sender, EventArgs e)
        {
            dlChung.thoatCT = false;
            var lstForm = Application.OpenForms;
            for (int i = 0; i < lstForm.Count; i++)
            {
                if (lstForm[i].Name != "frmdangnhap")
                {
                    lstForm[i].Close();
                    i--;
                }
            }
            Label lbl = (Label)sender;
            if (lbl.Name.ToLower() == "lbltrangchu")
            {
                frmhome frm = new frmhome();
                frm.Show();

            }
            else if (lbl.Name.ToLower() == "lblqlnhanvien")
            {
                frmQlNhanvien frm = new frmQlNhanvien();
                frm.Show();
            }
            else if (lbl.Name.ToLower() == "lblqlsanpham")
            {
                frmQlsanpham frm = new frmQlsanpham();
                frm.Show();
            }
            else if (lbl.Name.ToLower() == "lblqldonhangnhap")
            {
                frmQldonhangnhap frm = new frmQldonhangnhap();
                frm.Show();
            }
            else if (lbl.Name.ToLower() == "lblqldondathang")
            {
                frmDondathang frm = new frmDondathang();
                frm.Show();
            }
            else if (lbl.Name.ToLower() == "lblqlbaohanh")
            {
                frmBaohanh frm = new frmBaohanh();
                frm.Show();
            }
            else if (lbl.Name.ToLower() == "lblbaocao")
            {
                frmBaocao frm = new frmBaocao();
                frm.Show();
            }
            else if (lbl.Name.ToLower() == "lblthongke")
            {
                frmThongke frm = new frmThongke();
                frm.Show();
            }
        }



        private void ucMenu_Load(object sender, EventArgs e)
        {
            db_QLCHEntities2 dl = new db_QLCHEntities2();
            nhanvien nv = ttTaiKhoan.get();

            if (nv.quyenhan == 1)
            {
                lbltrangchu.Visible = false;
                lblQlnhanvien.Visible = false;
                lblQlsanpham.Visible = false;
                lblQLdondathang.Visible = false;
                lblQldonhangnhap.Visible = false;
                lblQlbaohanh.Visible = false;
                lblBaocao.Visible = false;
                lblThongke.Visible = false;

            }
            else if (nv.quyenhan == 2)
            {
                lbltrangchu.Visible = false;
                lblQlsanpham.Visible = false;
                lblQLdondathang.Visible = false;
                lblQldonhangnhap.Visible = false;
                lblQlbaohanh.Visible = false;
                lblBaocao.Visible = false;
                lblThongke.Visible = false;
            }

        }
        private void ucMenu_Paint(object sender, PaintEventArgs e)
        {
            setcolor();
        }

        private void ucMenu_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                Label lbl = (Label)sender;
                if (lbl.BackColor == Color.Yellow)
                {
                    lbl.ForeColor = Color.Yellow;
                    lbl.BackColor = Color.Red;
                    lbl.Font = new Font(lbl.Font, FontStyle.Regular);
                }
            }
            catch (Exception)
            {

            }

        }

        private void ucMenu_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                Label lbl = (Label)sender;
                if (lbl.BackColor == Color.Red)
                {
                    lbl.ForeColor = Color.Maroon;
                    lbl.BackColor = Color.Yellow;
                    lbl.Font = new Font(lbl.Font, FontStyle.Regular);
                }
            }
            catch (Exception)
            {

            }

        }

        private void lblDangxuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốm đăng xuất", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                frmdangnhap frm = new frmdangnhap();
                frm.ShowDialog();

            }

        }
    }
}
