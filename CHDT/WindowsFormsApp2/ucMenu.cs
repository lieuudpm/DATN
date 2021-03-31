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
        }

        private void lblQlkhachhang_Click(object sender, EventArgs e)
        {

        }

        private void lbltrangchu_Click(object sender, EventArgs e)
        {

        }

        private void lblQlnhanvien_Click(object sender, EventArgs e)
        {

        }

        private void ucMenu_Load(object sender, EventArgs e)
        {
            nhanvien nv = ttTaiKhoan.get();

            if(nv.quyenhan == 1)
            {
                lbltrangchu.Visible = false;
            }

           
        }
    }
}
