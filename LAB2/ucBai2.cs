using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace LAB2
{
    public partial class ucBai2 : UserControl
    {
        public ucBai2()
        {
            InitializeComponent();
        }

        private void btnLuaChonFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            ofd.Title = "Chọn file cần đọc thông tin";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string filePath = ofd.FileName;
                    FileInfo fileInfo = new FileInfo(filePath);
                    rtbTenFile.Text = fileInfo.Name;
                    rtbKichCo.Text = fileInfo.Length.ToString() + " bytes";
                    rtbURL.Text = fileInfo.FullName;
                    string content = File.ReadAllText(filePath);
                    rtbContent.Text = content;
                    rtbSoKyTu.Text = content.Length.ToString();
                    string[] lines = File.ReadAllLines(filePath);
                    rtbSoDong.Text = lines.Length.ToString();
                    char[] seperators = { ' ', '\r', '\n', '\t' };
                    string[] words = content.Split(seperators, StringSplitOptions.RemoveEmptyEntries);
                    rtbSoTu.Text = words.Length.ToString();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi đọc file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Control parent = this.Parent;
            if (parent != null)
            {
                parent.Controls.Remove(this);
                this.Dispose();
            }
        }
    }
}
