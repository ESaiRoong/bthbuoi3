namespace BTTKForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void b�i1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmBai1();
            form.ShowDialog();
        }
        private void b�i2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmBai2();
            form.ShowDialog();
        }
    }
}
