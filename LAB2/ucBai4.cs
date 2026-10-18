using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace LAB2
{
    public partial class ucBai4 : UserControl
    {
        public class SinhVien
        {
            public string HoTen { get; set; } = string.Empty;
            public int MSSV { get; set; }
            public string DienThoai { get; set; } = string.Empty;
            public float DiemMon1 { get; set; }
            public float DiemMon2 { get; set; }
            public float DiemMon3 { get; set; }
            public float DiemTrungBinh { get; set; }
        }

        private readonly List<SinhVien> dsNhapSV = new List<SinhVien>();
        private List<SinhVien> dsDocSV = new List<SinhVien>();
        private int currentIndex = 0; 

        public ucBai4()
        {
            InitializeComponent();
            DangKySuKien();
        }

        private void DangKySuKien()
        {
            Them.Click += Them_Click;
            btnGhiFile.Click += BtnGhiFile_Click;
            btnDocFile.Click += BtnDocFile_Click;
            QuayLai.Click += QuayLai_Click;
            TiepTheo.Click += TiepTheo_Click;
        }

        private void Them_Click(object? sender, EventArgs e)
        {
            try
            {
                string hoTen = tbTenGhiFile.Text.Trim();
                string sdt = tbSDTGhiFile.Text.Trim();
                if (string.IsNullOrEmpty(hoTen))
                {
                    MessageBox.Show("Vui lòng nhập Họ và tên!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!int.TryParse(tbIDGhiFile.Text.Trim(), out int mssv) || tbIDGhiFile.Text.Trim().Length != 8)
                {
                    MessageBox.Show("Mã số sinh viên (ID) phải là số nguyên có đúng 8 chữ số!", "Lỗi MSSV", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (sdt.Length != 10 || !sdt.StartsWith("0") || !sdt.All(char.IsDigit))
                {
                    MessageBox.Show("Số điện thoại phải có đúng 10 chữ số và bắt đầu bằng số 0!", "Lỗi SĐT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!float.TryParse(tbMon1GhiFile.Text.Trim(), out float d1) || d1 < 0 || d1 > 10 ||
                    !float.TryParse(tbMon2GhiFile.Text.Trim(), out float d2) || d2 < 0 || d2 > 10 ||
                    !float.TryParse(tbMon3GhiFile.Text.Trim(), out float d3) || d3 < 0 || d3 > 10)
                {
                    MessageBox.Show("Điểm các môn học phải từ 0 đến 10!", "Lỗi Điểm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                SinhVien sv = new SinhVien
                {
                    HoTen = hoTen,
                    MSSV = mssv,
                    DienThoai = sdt,
                    DiemMon1 = d1,
                    DiemMon2 = d2,
                    DiemMon3 = d3,
                    DiemTrungBinh = 0 
                };
                dsNhapSV.Add(sv);
                HienThiDanhSachLenRichTextBox();
                XoaFormNhap();
                MessageBox.Show($"Đã thêm sinh viên {hoTen} vào danh sách tạm!", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi nhập liệu: " + ex.Message, "Lỗi");
            }
        }

        private void HienThiDanhSachLenRichTextBox()
        {
            richTextBox1.Clear();
            foreach (var sv in dsNhapSV)
            {
                richTextBox1.AppendText($"{sv.HoTen}\n");
                richTextBox1.AppendText($"{sv.MSSV}\n");
                richTextBox1.AppendText($"{sv.DienThoai}\n");
                richTextBox1.AppendText($"{sv.DiemMon1}\n");
                richTextBox1.AppendText($"{sv.DiemMon2}\n");
                richTextBox1.AppendText($"{sv.DiemMon3}\n\n");
            }
        }

        private void XoaFormNhap()
        {
            tbTenGhiFile.Clear();
            tbIDGhiFile.Clear();
            tbSDTGhiFile.Clear();
            tbMon1GhiFile.Clear();
            tbMon2GhiFile.Clear();
            tbMon3GhiFile.Clear();
            tbTrungBinhGhiFile.Text = "0";
            tbTenGhiFile.Focus();
        }

        private void BtnGhiFile_Click(object? sender, EventArgs e)
        {
            if (dsNhapSV.Count == 0)
            {
                MessageBox.Show("Danh sách sinh viên rỗng, hãy bấm nút 'Thêm' trước!", "Thông báo");
                return;
            }
            try
            {
                List<SinhVien> danhSachHienTai = new List<SinhVien>();
                if (File.Exists("input4.txt"))
                {
                    string oldJson = File.ReadAllText("input4.txt");
                    var oldList = JsonSerializer.Deserialize<List<SinhVien>>(oldJson);
                    if (oldList != null)
                    {
                        danhSachHienTai.AddRange(oldList);
                    }
                }
                danhSachHienTai.AddRange(dsNhapSV);
                string jsonString = JsonSerializer.Serialize(danhSachHienTai, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText("input4.txt", jsonString);
                MessageBox.Show($"Đã ghi nối tiếp thành công! Tổng số sinh viên trong file: {danhSachHienTai.Count}", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dsNhapSV.Clear();
                richTextBox1.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi ghi file: " + ex.Message, "Lỗi");
            }
        }

        private void BtnDocFile_Click(object? sender, EventArgs e)
        {
            if (!File.Exists("input4.txt"))
            {
                MessageBox.Show("Không tìm thấy file 'input4.txt'! Vui lòng ghi file trước.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                string jsonString = File.ReadAllText("input4.txt");
                dsDocSV = JsonSerializer.Deserialize<List<SinhVien>>(jsonString) ?? new List<SinhVien>();
                foreach (var sv in dsDocSV)
                {
                    sv.DiemTrungBinh = (sv.DiemMon1 + sv.DiemMon2 + sv.DiemMon3) / 3.0f;
                }
                string outputJson = JsonSerializer.Serialize(dsDocSV, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText("output4.txt", outputJson);
                if (dsDocSV.Count > 0)
                {
                    currentIndex = 0;
                    HienThiSinhVienDoc(currentIndex);
                    MessageBox.Show($"Đã đọc {dsDocSV.Count} sinh viên từ 'input4.txt', tự động tính ĐTB và xuất ra 'output4.txt'!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đọc/xử lý file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HienThiSinhVienDoc(int index)
        {
            if (dsDocSV == null || dsDocSV.Count == 0 || index < 0 || index >= dsDocSV.Count) return;
            SinhVien sv = dsDocSV[index];
            tbTenDocFile.Text = sv.HoTen;
            tbIDDocFile.Text = sv.MSSV.ToString();
            tbSDTDocFile.Text = sv.DienThoai;
            tbMon1DocFile.Text = sv.DiemMon1.ToString("F2");
            tbMon2DocFile.Text = sv.DiemMon2.ToString("F2");
            tbMon3DocFile.Text = sv.DiemMon3.ToString("F2");
            tbTrungBinhDocFile.Text = sv.DiemTrungBinh.ToString("F2");
            ChiSo.Text = (index + 1).ToString();
        }

        private void QuayLai_Click(object? sender, EventArgs e)
        {
            if (dsDocSV != null && dsDocSV.Count > 0)
            {
                if (currentIndex > 0)
                {
                    currentIndex--;
                    HienThiSinhVienDoc(currentIndex);
                }
                else
                {
                    MessageBox.Show("Đang ở sinh viên đầu tiên!", "Thông báo");
                }
            }
        }

        private void TiepTheo_Click(object? sender, EventArgs e)
        {
            if (dsDocSV != null && dsDocSV.Count > 0)
            {
                if (currentIndex < dsDocSV.Count - 1)
                {
                    currentIndex++;
                    HienThiSinhVienDoc(currentIndex);
                }
                else
                {
                    MessageBox.Show("Đã đến sinh viên cuối cùng!", "Thông báo");
                }
            }
        }
    }
}
