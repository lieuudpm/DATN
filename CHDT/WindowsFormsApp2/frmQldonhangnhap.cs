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
    public partial class frmQldonhangnhap : Form
    {
        public frmQldonhangnhap()
        {
            InitializeComponent();
        }


        private void btntaohoadonnhap_Click(object sender, EventArgs e)
        {
            db_QLCHEntities2 dl = new db_QLCHEntities2();

            //them mơi
            //loaihang tv = new loaihang();
            //tv.tenloai = "test";
            //dl.loaihangs.Add(tv);
            //dl.SaveChanges();

            //update
            //loaihang tv = dl.loaihangs.First();
            //tv.tenloai = "test1";
            //dl.SaveChanges();
            loaihang tv = dl.loaihangs.First();
            dl.loaihangs.Remove(tv);
            dl.SaveChanges();
        }
        private void frmQldonhangnhap_Load(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmttSanpham frm = new frmttSanpham();
            frm.ShowDialog();
        }

        private void frmQldonhangnhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dlChung.thoatCT == true)
            {
                Application.Exit();
            }
            dlChung.thoatCT = true;
        }
    }
}

