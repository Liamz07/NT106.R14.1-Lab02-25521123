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
    public partial class ucBai7 : UserControl
    {
        public ucBai7()
        {
            InitializeComponent();
        }

        private void ucBai7_Load(object sender, EventArgs e)
        {
            treeView.Nodes.Clear();
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {
                if (drive.IsReady)
                {
                    TreeNode driveNode = new TreeNode(drive.Name);
                    driveNode.Tag = drive.Name;
                    treeView.Nodes.Add(driveNode);
                    NapThuMucCon(driveNode);
                }
            }
        }

        private void NapThuMucCon(TreeNode parentNode)
        {
            try
            {
                string path = parentNode.Tag.ToString();
                DirectoryInfo dir = new DirectoryInfo(path);
                foreach (DirectoryInfo subDir in dir.GetDirectories())
                {
                    TreeNode subNode = new TreeNode(subDir.Name);
                    subNode.Tag = subDir.FullName;
                    parentNode.Nodes.Add(subNode);
                }
            }
            catch
            {
                // Bỏ qua các folder hệ thống không có quyền truy cập
            }
        }

        private void treeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode selectedNode = e.Node;
            if (selectedNode.Tag == null) return;
            string path = selectedNode.Tag.ToString();
            if (Directory.Exists(path))
            {
                try
                {
                    selectedNode.Nodes.Clear();
                    DirectoryInfo dir = new DirectoryInfo(path);
                    foreach (DirectoryInfo subDir in dir.GetDirectories())
                    {
                        TreeNode subNode = new TreeNode(subDir.Name);
                        subNode.Tag = subDir.FullName;
                        selectedNode.Nodes.Add(subNode);
                    }

                    foreach (FileInfo file in dir.GetFiles())
                    {
                        TreeNode fileNode = new TreeNode(file.Name);
                        fileNode.Tag = file.FullName;
                        selectedNode.Nodes.Add(fileNode);
                    }
                    selectedNode.Expand();
                }
                catch (UnauthorizedAccessException)
                {
                    MessageBox.Show("Thư mục hệ thống bị khóa, không có quyền truy cập!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi đọc thư mục: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (File.Exists(path))
            {
                HienThiNoiDungFileVaoGroupBox(path);
            }
        }

        private void HienThiNoiDungFileVaoGroupBox(string filePath)
        {
            try
            {
                gbContent.Text = "File Content - " + Path.GetFileName(filePath);
                RichTextBox rtb = null;
                foreach (Control ctrl in gbContent.Controls)
                {
                    if (ctrl is RichTextBox)
                    {
                        rtb = (RichTextBox)ctrl;
                        break;
                    }
                }
                if (rtb == null)
                {
                    rtb = new RichTextBox();
                    rtb.Dock = DockStyle.Fill;
                    rtb.ReadOnly = true;
                    gbContent.Controls.Add(rtb);
                }
                string ext = Path.GetExtension(filePath).ToLower();
                if (ext == ".txt" || ext == ".log" || ext == ".cs" || ext == ".json" || ext == ".xml" || ext == ".ini")
                {
                    rtb.Text = File.ReadAllText(filePath);
                }
                else
                {
                    rtb.Text = $"[File không thuộc dạng văn bản thuần: {Path.GetFileName(filePath)}]";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể đọc nội dung file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
