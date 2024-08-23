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
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void btbChonHang_Click(object sender, EventArgs e)
        {
            var item = listBox1.SelectedItem;
            listBox2.Items.Add(item);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox2.Items.Remove(listBox2.SelectedItem);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int soTien = 0;

            foreach (string item in listBox2.Items)
            {
                switch (item)
                {
                    case "Chuột":
                        soTien += 100000;
                        break;
                    case "Bàn phím":
                        soTien += 150000;
                        break;
                    case "Máy in":
                        soTien += 200000;
                        break;
                    case "USB Kingmax":
                        soTien += 200000;
                        break;

                    default:
                        break;
                }
                lbTongTien.Text = soTien.ToString();
            }
        }
    }
}
