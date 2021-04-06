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
    public partial class frmThongke : Form
    {
        public frmThongke()
        {
            InitializeComponent();
        }

        private void frmThongke_Load(object sender, EventArgs e)
        {

        }

        private void frmThongke_GiveFeedback(object sender, GiveFeedbackEventArgs e)
        {

        }

        private void frmThongke_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (dlChung.thoatCT == true)
            {
                Application.Exit();
            }
            dlChung.thoatCT = true;
        }
    }
}
