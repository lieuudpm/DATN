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
    public partial class frmTtdondathang : Form
    {
        public frmTtdondathang()
        {
            InitializeComponent();
        }

        private void frmTtdondathang_Load(object sender, EventArgs e)
        {

        }

        private void btnthemHD_Click(object sender, EventArgs e)
        {

        }

        private void frmTtdondathang_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dlChung.thoatCT == true)
            {
                Application.Exit();
            }
            dlChung.thoatCT = true;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
