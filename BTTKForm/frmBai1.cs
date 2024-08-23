using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTTKForm
{
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            txtDonGia.Enabled = true;
            txtDonGia.Text = "220000";
        }

        private void rdRed_CheckedChanged(object sender, EventArgs e)
        {
            txtDonGia.Enabled = true;
            txtDonGia.Text = "210000";
        }

        private void rdWhite_CheckedChanged(object sender, EventArgs e)
        {
            txtDonGia.Enabled = true;
            txtDonGia.Text = "200000";
        }

        private void btTinhTien_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtDonGia.Text);
            int tongtien = int.Parse(txtSoLuong.Text) * a;

            lbTongTien.Text = tongtien.ToString();
        }

        private void frmBai1_Load(object sender, EventArgs e)
        {

        }

    }
}
