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
    public partial class ucBai5 : UserControl
    {

        private class Phim
        {
            public string TenPhim { get; set; } = string.Empty;
            public int GiaVeChuan { get; set; }
            public List<int> PhongChieu { get; set; } = new List<int>();
            public int SoVeDaBan { get; set; } = 0;
            public long DoanhThu { get; set; } = 0;
        }

        private readonly List<Phim> dsPhim = new List<Phim>();
        private List<Button> dsGheButtons = new List<Button>();
        private readonly List<string> dsGheDangChon = new List<string>();
        private readonly Dictionary<string, bool> dsGheDaBan = new Dictionary<string, bool>();

        public ucBai5()
        {
            InitializeComponent();
            KhoiTaoDanhSachGhe();
            DangKySuKien();
        }

        private void KhoiTaoDanhSachGhe()
        {
            dsGheButtons = new List<Button>
            {
                A1, A2, A3, A4, A5,
                B1, B2, B3, B4, B5,
                C1, C2, C3, C4, C5
            };

            foreach (var btn in dsGheButtons)
            {
                btn.Click += BtnGhe_Click;
                btn.Tag = btn.Text;
            }
        }
        private void DangKySuKien()
        {
            cbChonPhim.SelectedIndexChanged += CbChonPhim_SelectedIndexChanged;
            cbPhongChieu.SelectedIndexChanged += CbPhongChieu_SelectedIndexChanged;
        }

        private void NhapThongTin_Click(object? sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                ofd.Title = "Chọn file input5.txt";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string[] lines = File.ReadAllLines(ofd.FileName);
                        dsPhim.Clear();
                        for (int i = 0; i < lines.Length; i += 3)
                        {
                            if (i + 2 < lines.Length)
                            {
                                Phim p = new Phim
                                {
                                    TenPhim = lines[i].Trim(),
                                    GiaVeChuan = int.Parse(lines[i + 1].Trim()),
                                    PhongChieu = lines[i + 2].Split(',').Select(x => int.Parse(x.Trim())).ToList()
                                };
                                dsPhim.Add(p);
                            }
                        }
                        cbChonPhim.Items.Clear();
                        foreach (var phim in dsPhim)
                        {
                            cbChonPhim.Items.Add(phim.TenPhim);
                        }
                        if (cbChonPhim.Items.Count > 0) cbChonPhim.SelectedIndex = 0;
                        MessageBox.Show("Nạp dữ liệu từ file input5.txt thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi cấu trúc file input5.txt: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void CbChonPhim_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (cbChonPhim.SelectedItem == null) return;
            string? tenPhim = cbChonPhim.SelectedItem.ToString();
            if (string.IsNullOrEmpty(tenPhim)) return;
            Phim? phimChon = dsPhim.FirstOrDefault(p => p.TenPhim == tenPhim);
            if (phimChon != null)
            {
                cbPhongChieu.Items.Clear();
                foreach (int phong in phimChon.PhongChieu)
                {
                    cbPhongChieu.Items.Add(phong.ToString());
                }
                if (cbPhongChieu.Items.Count > 0) cbPhongChieu.SelectedIndex = 0;
            }
        }

        private void CbPhongChieu_SelectedIndexChanged(object? sender, EventArgs e)
        {
            CapNhatTrangThaiGheUI();
        }

        private void CapNhatTrangThaiGheUI()
        {
            if (cbChonPhim.SelectedItem == null || cbPhongChieu.SelectedItem == null) return;
            string phim = cbChonPhim.SelectedItem.ToString() ?? string.Empty;
            string phong = cbPhongChieu.SelectedItem.ToString() ?? string.Empty;
            dsGheDangChon.Clear();
            foreach (var btn in dsGheButtons)
            {
                string ghe = btn.Tag?.ToString() ?? string.Empty;
                string key = $"{phim}_{phong}_{ghe}";
                if (dsGheDaBan.ContainsKey(key) && dsGheDaBan[key])
                {
                    btn.BackColor = Color.Gray;
                    btn.Enabled = false;
                }
                else
                {
                    btn.BackColor = Color.White;
                    btn.ForeColor = Color.Black;
                    btn.Enabled = true;
                }
            }
        }

        private void BtnGhe_Click(object? sender, EventArgs e)
        {
            if (sender is not Button btn) return;
            string ghe = btn.Tag?.ToString() ?? string.Empty;
            if (string.IsNullOrEmpty(ghe)) return;
            if (dsGheDangChon.Contains(ghe))
            {
                dsGheDangChon.Remove(ghe);
                btn.BackColor = Color.White;
                btn.ForeColor = Color.Black;
            }
            else
            {
                if (dsGheDangChon.Count >= 2)
                {
                    MessageBox.Show("Mỗi lần đặt chỉ được chọn tối đa 2 vé!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                dsGheDangChon.Add(ghe);
                btn.BackColor = Color.Orange;
                btn.ForeColor = Color.White;
            }
        }

        private void TinhTienVe_Click(object? sender, EventArgs e)
        {
            string hoTen = maskedTextBox1.Text.Trim();
            if (string.IsNullOrEmpty(hoTen))
            {
                MessageBox.Show("Vui lòng nhập họ và tên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                maskedTextBox1.Focus();
                return;
            }
            if (cbChonPhim.SelectedItem == null || cbPhongChieu.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn phim và phòng chiếu!", "Lỗi");
                return;
            }
            if (dsGheDangChon.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất 1 ghế!", "Lỗi");
                return;
            }
            string tenPhim = cbChonPhim.SelectedItem.ToString() ?? string.Empty;
            string phong = cbPhongChieu.SelectedItem.ToString() ?? string.Empty;
            Phim? phimChon = dsPhim.FirstOrDefault(p => p.TenPhim == tenPhim);
            if (phimChon == null) return;
            double tongTien = 0;
            string chiTietGhe = "";
            foreach (string ghe in dsGheDangChon)
            {
                double heSo = 1.0;
                if (ghe == "A1" || ghe == "A5" || ghe == "C1" || ghe == "C5")
                {
                    heSo = 0.25;
                    chiTietGhe += $"{ghe} (Vé vớt), ";
                }
                else if (ghe == "B2" || ghe == "B3" || ghe == "B4")
                {
                    heSo = 2.0;
                    chiTietGhe += $"{ghe} (VIP), ";
                }
                else
                {
                    heSo = 1.0;
                    chiTietGhe += $"{ghe} (Thường), ";
                }
                double giaVe = phimChon.GiaVeChuan * heSo;
                tongTien += giaVe;
                string key = $"{tenPhim}_{phong}_{ghe}";
                dsGheDaBan[key] = true;
            }
            phimChon.SoVeDaBan += dsGheDangChon.Count;
            phimChon.DoanhThu += (long)tongTien;
            rtbContent.Clear();
            rtbContent.AppendText("=== HÓA ĐƠN ĐẶT VÉ ===\n");
            rtbContent.AppendText($"Họ và tên: {hoTen}\n");
            rtbContent.AppendText($"Phim: {tenPhim}\n");
            rtbContent.AppendText($"Phòng chiếu: {phong}\n");
            rtbContent.AppendText($"Ghế đã chọn: {chiTietGhe.TrimEnd(',', ' ')}\n");
            rtbContent.AppendText($"Tổng tiền thanh toán: {tongTien:N0} VNĐ\n");
            CapNhatTrangThaiGheUI();
        }
        private async void XuatThongTin_Click(object? sender, EventArgs e)
        {
            if (dsPhim.Count == 0)
            {
                MessageBox.Show("Chưa có dữ liệu phim để xuất báo cáo!", "Thông báo");
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Text Files (*.txt)|*.txt";
                sfd.FileName = "output5.txt";
                sfd.Title = "Lưu file thống kê";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    TienTrinh.Value = 0;
                    TienTrinh.Maximum = 100;
                    for (int i = 0; i <= 100; i += 20)
                    {
                        TienTrinh.Value = i;
                        await Task.Delay(80);
                    }
                    var dsXepHang = dsPhim.OrderByDescending(p => p.DoanhThu).ToList();
                    using (StreamWriter sw = new StreamWriter(sfd.FileName))
                    {
                        sw.WriteLine("=== BÁO CÁO THỐNG KÊ DOANH THU PHÒNG VÉ ===");
                        sw.WriteLine($"Ngày xuất báo cáo: {DateTime.Now:dd/MM/yyyy HH:mm:ss}\n");
                        int rank = 1;
                        foreach (var phim in dsXepHang)
                        {
                            int tongGheToanBoPhong = phim.PhongChieu.Count * 15;
                            int veTon = tongGheToanBoPhong - phim.SoVeDaBan;
                            double tiLeBan = tongGheToanBoPhong > 0 ? ((double)phim.SoVeDaBan / tongGheToanBoPhong) * 100 : 0;
                            sw.WriteLine($"Xếp hạng: {rank++}");
                            sw.WriteLine($"Tên phim: {phim.TenPhim}");
                            sw.WriteLine($"Số vé bán ra: {phim.SoVeDaBan}");
                            sw.WriteLine($"Số vé tồn: {veTon}");
                            sw.WriteLine($"Tỉ lệ bán ra: {tiLeBan:F2}%");
                            sw.WriteLine($"Doanh thu: {phim.DoanhThu:N0} VNĐ");
                            sw.WriteLine(new string('-', 40));
                        }
                    }
                    MessageBox.Show("Xuất file output5.txt thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
