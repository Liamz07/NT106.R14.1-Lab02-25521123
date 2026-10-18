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
    public partial class ucBai1 : UserControl
    {
        public ucBai1()
        {
            InitializeComponent();
        }

        private void btnDocFile_Click(object sender, EventArgs e)
        {
            string filePath = "input1.txt";
            if (File.Exists(filePath))
            {
                try
                {
                    string content = File.ReadAllText(filePath);
                    rtbContent.Text = content;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi đọc file: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Không tim thấy file 'input1.txt'!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGhiFile_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(rtbContent.Text))
            {
                MessageBox.Show("Chưa có nội dung để ghi file! Vui lòng bấm 'ĐỌC FILE' hoặc nhập văn bản trước.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                string contentUpper = rtbContent.Text.ToUpper();
                string fileName = "output1.txt";
                File.WriteAllText(fileName, contentUpper);
                MessageBox.Show("Đã chuyển thành chữ IN HOA và ghi thành công vào 'output1.txt'!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi ghi file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
