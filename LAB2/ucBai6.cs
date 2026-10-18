using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LAB2
{
    public partial class ucBai6 : UserControl
    {
        private string connectionString = $@"Data Source={Path.Combine(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName, "QuanLyMonAn.db")};Version=3;";
        public ucBai6()
        {
            InitializeComponent();
            LoadDataToListView();
        }

        #region Tải dữ liệu lên ListView
        private void LoadDataToListView()
        {
            listView1.Items.Clear();
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                        SELECT MonAn.IDMA, MonAn.TenMonAn, MonAn.HinhAnh, NguoiDung.HoVaTen 
                        FROM MonAn 
                        LEFT JOIN NguoiDung ON MonAn.IDNCC = NguoiDung.IDNCC";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader["IDMA"].ToString());
                            item.SubItems.Add(reader["TenMonAn"].ToString());
                            item.SubItems.Add(reader["HinhAnh"].ToString());
                            item.SubItems.Add(reader["HoVaTen"] != DBNull.Value ? reader["HoVaTen"].ToString() : "Chưa rõ");
                            listView1.Items.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối CSDL: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Sự kiện Nút bấm
        private void btnChon_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Hình ảnh|*.jpg;*.jpeg;*.png;*.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    tbHinhAnh.Text = ofd.FileName;
                }
            }
        }

        private void btnThemMonAn_Click(object sender, EventArgs e)
        {
            string tenMon = tbTenMon.Text.Trim();
            string hinhAnh = tbHinhAnh.Text.Trim();
            string nguoiGop = tbNguoiGop.Text.Trim();
            if (string.IsNullOrEmpty(tenMon) || string.IsNullOrEmpty(nguoiGop))
            {
                MessageBox.Show("Vui lòng nhập tên món ăn và tên người đóng góp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    long idNcc = GetOrAddUser(conn, nguoiGop);
                    string insertMonAn = "INSERT INTO MonAn (TenMonAn, HinhAnh, IDNCC) VALUES (@TenMon, @HinhAnh, @IDNCC)";
                    using (SQLiteCommand cmd = new SQLiteCommand(insertMonAn, conn))
                    {
                        cmd.Parameters.AddWithValue("@TenMon", tenMon);
                        cmd.Parameters.AddWithValue("@HinhAnh", hinhAnh);
                        cmd.Parameters.AddWithValue("@IDNCC", idNcc);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Thêm món ăn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbTenMon.Clear();
                tbHinhAnh.Clear();
                tbNguoiGop.Clear();
                LoadDataToListView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm món ăn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private long GetOrAddUser(SQLiteConnection conn, string hoVaTen)
        {
            string selectQuery = "SELECT IDNCC FROM NguoiDung WHERE HoVaTen = @HoVaTen";
            using (SQLiteCommand cmd = new SQLiteCommand(selectQuery, conn))
            {
                cmd.Parameters.AddWithValue("@HoVaTen", hoVaTen);
                object result = cmd.ExecuteScalar();
                if (result != null) return Convert.ToInt64(result);
            }
            string insertQuery = "INSERT INTO NguoiDung (HoVaTen, QuyenHan) VALUES (@HoVaTen, 'User'); SELECT last_insert_rowid();";
            using (SQLiteCommand cmd = new SQLiteCommand(insertQuery, conn))
            {
                cmd.Parameters.AddWithValue("@HoVaTen", hoVaTen);
                return Convert.ToInt64(cmd.ExecuteScalar());
            }
        }

        private void TimMonAn_Click(object sender, EventArgs e)
        {
            var dsMonAn = new List<(string TenMon, string HinhAnh, string NguoiGop)>();
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                        SELECT MonAn.TenMonAn, MonAn.HinhAnh, NguoiDung.HoVaTen 
                        FROM MonAn 
                        LEFT JOIN NguoiDung ON MonAn.IDNCC = NguoiDung.IDNCC";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dsMonAn.Add((
                                reader["TenMonAn"].ToString(),
                                reader["HinhAnh"].ToString(),
                                reader["HoVaTen"] != DBNull.Value ? reader["HoVaTen"].ToString() : "Chưa rõ"
                            ));
                        }
                    }
                }
                if (dsMonAn.Count == 0)
                {
                    MessageBox.Show("Chưa có món ăn nào trong cơ sở dữ liệu! Hãy thêm món ăn trước.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Random rand = new Random();
                var monChon = dsMonAn[rand.Next(dsMonAn.Count)];
                tbMonAn.Text = monChon.TenMon;
                tbDongGopBoi.Text = monChon.NguoiGop;
                if (!string.IsNullOrEmpty(monChon.HinhAnh) && File.Exists(monChon.HinhAnh))
                {
                    pictureBox1.Image = Image.FromFile(monChon.HinhAnh);
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                }
                else
                {
                    pictureBox1.Image = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm món ăn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            Control parent = this.Parent;
            if (parent != null)
            {
                parent.Controls.Remove(this);
                this.Dispose();
            }
        }
        #endregion
    }
}
