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
    public partial class frmQlsanpham : Form
    {
        public frmQlsanpham()
        {
            InitializeComponent();
        }
        
        private void btnThemnv_Click(object sender, EventArgs e)
        {
            frmThemmoisanpham frm = new frmThemmoisanpham();
            frm.ShowDialog();
        }

        private void frmQlsanpham_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dlChung.thoatCT == true)
            {
                Application.Exit();
            }
            dlChung.thoatCT = true;
        }
    }
}
