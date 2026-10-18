namespace LAB2
{
    public partial class GiaoDienChung : Form
    {
        public GiaoDienChung()
        {
            InitializeComponent();
        }

        private void btnBai1_Click(object sender, EventArgs e)
        {
            gbContent.Controls.Clear();
            ucBai1 uc1 = new ucBai1();
            gbContent.Controls.Add(uc1);
        }

        private void btnBai2_Click(object sender, EventArgs e)
        {
            gbContent.Controls.Clear();
            ucBai2 uc2 = new ucBai2();
            gbContent.Controls.Add(uc2);
        }

        private void btnBai3_Click(object sender, EventArgs e)
        {
            gbContent.Controls.Clear();
            ucBai3 uc3 = new ucBai3();
            gbContent.Controls.Add(uc3);
        }

        private void btnBai4_Click(object sender, EventArgs e)
        {
            gbContent.Controls.Clear();
            ucBai4 uc4 = new ucBai4();
            gbContent.Controls.Add(uc4);
        }

        private void btnBai7_Click(object sender, EventArgs e)
        {
            gbContent.Controls.Clear();
            ucBai7 uc7 = new ucBai7();
            gbContent.Controls.Add(uc7);
        }

        private void btnBai6_Click(object sender, EventArgs e)
        {
            gbContent.Controls.Clear();
            ucBai6 uc6 = new ucBai6();
            gbContent.Controls.Add(uc6);
        }

        private void btnBai5_Click(object sender, EventArgs e)
        {
            gbContent.Controls.Clear();
            ucBai5 uc5 = new ucBai5();
            gbContent.Controls.Add(uc5);
        }
    }
}
