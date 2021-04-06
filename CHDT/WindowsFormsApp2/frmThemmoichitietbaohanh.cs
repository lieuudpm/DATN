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
    public partial class frmThemmoichitietbaohanh : Form
    {
        public frmThemmoichitietbaohanh()
        {
            InitializeComponent();
        }

        private void frmThemmoichitietbaohanh_Load(object sender, EventArgs e)
        {

        }

        private void dgvHienThi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDsbaohanh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmThemmoichitietbaohanh_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dlChung.thoatCT == true)
            {
                Application.Exit();
            }
            dlChung.thoatCT = true;
        }
    }
}
