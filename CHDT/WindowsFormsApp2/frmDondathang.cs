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
    public partial class frmDondathang : Form
    {
        public frmDondathang()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtnhapmaHD_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnapdungMHD_Click(object sender, EventArgs e)
        {
            frmTtdondathang frm = new frmTtdondathang();
            frm.ShowDialog();
        }

        private void frmDondathang_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dlChung.thoatCT == true)
            {
                Application.Exit();
            }
            dlChung.thoatCT = true;
        }

        private void frmDondathang_Load(object sender, EventArgs e)
        {

        }

        private void ucMenu1_Load(object sender, EventArgs e)
        {

        }
    }
}
