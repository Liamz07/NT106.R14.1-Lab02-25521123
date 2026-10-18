namespace LAB2
{
    partial class ucBai6
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TenMonAn = new Label();
            tbTenMon = new TextBox();
            HinhAnh = new Label();
            tbHinhAnh = new TextBox();
            btnChon = new Button();
            NguoiGop = new Label();
            tbNguoiGop = new TextBox();
            btnThemMonAn = new Button();
            listView1 = new ListView();
            colIDMA = new ColumnHeader();
            colTenMon = new ColumnHeader();
            colHinhAnh = new ColumnHeader();
            colNguoiGop = new ColumnHeader();
            TimMonAn = new Button();
            pictureBox1 = new PictureBox();
            MonAn = new Label();
            DongGopBoi = new Label();
            tbMonAn = new TextBox();
            tbDongGopBoi = new TextBox();
            Thoat = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // TenMonAn
            // 
            TenMonAn.AutoSize = true;
            TenMonAn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TenMonAn.Location = new Point(12, 32);
            TenMonAn.Name = "TenMonAn";
            TenMonAn.Size = new Size(70, 20);
            TenMonAn.TabIndex = 0;
            TenMonAn.Text = "Tên món";
            // 
            // tbTenMon
            // 
            tbTenMon.Location = new Point(103, 29);
            tbTenMon.Name = "tbTenMon";
            tbTenMon.Size = new Size(153, 27);
            tbTenMon.TabIndex = 1;
            // 
            // HinhAnh
            // 
            HinhAnh.AutoSize = true;
            HinhAnh.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HinhAnh.Location = new Point(12, 81);
            HinhAnh.Name = "HinhAnh";
            HinhAnh.Size = new Size(72, 20);
            HinhAnh.TabIndex = 2;
            HinhAnh.Text = "Hình ảnh";
            // 
            // tbHinhAnh
            // 
            tbHinhAnh.Location = new Point(103, 81);
            tbHinhAnh.Name = "tbHinhAnh";
            tbHinhAnh.Size = new Size(153, 27);
            tbHinhAnh.TabIndex = 3;
            // 
            // btnChon
            // 
            btnChon.Location = new Point(162, 126);
            btnChon.Name = "btnChon";
            btnChon.Size = new Size(94, 29);
            btnChon.TabIndex = 4;
            btnChon.Text = "Chọn";
            btnChon.UseVisualStyleBackColor = true;
            btnChon.Click += btnChon_Click;
            // 
            // NguoiGop
            // 
            NguoiGop.AutoSize = true;
            NguoiGop.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NguoiGop.Location = new Point(12, 180);
            NguoiGop.Name = "NguoiGop";
            NguoiGop.Size = new Size(84, 20);
            NguoiGop.TabIndex = 5;
            NguoiGop.Text = "Người góp";
            // 
            // tbNguoiGop
            // 
            tbNguoiGop.Location = new Point(103, 177);
            tbNguoiGop.Name = "tbNguoiGop";
            tbNguoiGop.Size = new Size(153, 27);
            tbNguoiGop.TabIndex = 6;
            // 
            // btnThemMonAn
            // 
            btnThemMonAn.Location = new Point(75, 222);
            btnThemMonAn.Name = "btnThemMonAn";
            btnThemMonAn.Size = new Size(126, 45);
            btnThemMonAn.TabIndex = 7;
            btnThemMonAn.Text = "Thêm món ăn";
            btnThemMonAn.UseVisualStyleBackColor = true;
            btnThemMonAn.Click += btnThemMonAn_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { colIDMA, colTenMon, colHinhAnh, colNguoiGop });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(273, 17);
            listView1.Name = "listView1";
            listView1.Size = new Size(425, 250);
            listView1.TabIndex = 8;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // colIDMA
            // 
            colIDMA.Text = "IDMA";
            colIDMA.Width = 50;
            // 
            // colTenMon
            // 
            colTenMon.Text = "Tên món ăn";
            colTenMon.Width = 150;
            // 
            // colHinhAnh
            // 
            colHinhAnh.Text = "Hình ảnh";
            colHinhAnh.Width = 120;
            // 
            // colNguoiGop
            // 
            colNguoiGop.Text = "Người góp";
            colNguoiGop.Width = 130;
            // 
            // TimMonAn
            // 
            TimMonAn.Location = new Point(22, 353);
            TimMonAn.Name = "TimMonAn";
            TimMonAn.Size = new Size(126, 45);
            TimMonAn.TabIndex = 9;
            TimMonAn.Text = "Tìm món ăn";
            TimMonAn.UseVisualStyleBackColor = true;
            TimMonAn.Click += TimMonAn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(195, 286);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(293, 187);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // MonAn
            // 
            MonAn.AutoSize = true;
            MonAn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MonAn.Location = new Point(574, 286);
            MonAn.Name = "MonAn";
            MonAn.Size = new Size(62, 20);
            MonAn.TabIndex = 11;
            MonAn.Text = "Món ăn";
            // 
            // DongGopBoi
            // 
            DongGopBoi.AutoSize = true;
            DongGopBoi.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DongGopBoi.Location = new Point(557, 353);
            DongGopBoi.Name = "DongGopBoi";
            DongGopBoi.Size = new Size(104, 20);
            DongGopBoi.TabIndex = 12;
            DongGopBoi.Text = "Đóng góp bởi";
            // 
            // tbMonAn
            // 
            tbMonAn.Location = new Point(531, 309);
            tbMonAn.Name = "tbMonAn";
            tbMonAn.Size = new Size(153, 27);
            tbMonAn.TabIndex = 13;
            // 
            // tbDongGopBoi
            // 
            tbDongGopBoi.Location = new Point(531, 376);
            tbDongGopBoi.Name = "tbDongGopBoi";
            tbDongGopBoi.Size = new Size(153, 27);
            tbDongGopBoi.TabIndex = 14;
            // 
            // Thoat
            // 
            Thoat.Location = new Point(574, 429);
            Thoat.Name = "Thoat";
            Thoat.Size = new Size(110, 44);
            Thoat.TabIndex = 15;
            Thoat.Text = "Thoát";
            Thoat.UseVisualStyleBackColor = true;
            // 
            // ucBai6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Thoat);
            Controls.Add(tbDongGopBoi);
            Controls.Add(tbMonAn);
            Controls.Add(DongGopBoi);
            Controls.Add(MonAn);
            Controls.Add(pictureBox1);
            Controls.Add(TimMonAn);
            Controls.Add(listView1);
            Controls.Add(btnThemMonAn);
            Controls.Add(tbNguoiGop);
            Controls.Add(NguoiGop);
            Controls.Add(btnChon);
            Controls.Add(tbHinhAnh);
            Controls.Add(HinhAnh);
            Controls.Add(tbTenMon);
            Controls.Add(TenMonAn);
            Name = "ucBai6";
            Size = new Size(717, 488);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TenMonAn;
        private TextBox tbTenMon;
        private Label HinhAnh;
        private TextBox tbHinhAnh;
        private Button btnChon;
        private Label NguoiGop;
        private TextBox tbNguoiGop;
        private Button btnThemMonAn;
        private ListView listView1;
        private ColumnHeader colIDMA;
        private ColumnHeader colTenMon;
        private ColumnHeader colHinhAnh;
        private ColumnHeader colNguoiGop;
        private Button TimMonAn;
        private PictureBox pictureBox1;
        private Label MonAn;
        private Label DongGopBoi;
        private TextBox tbMonAn;
        private TextBox tbDongGopBoi;
        private Button Thoat;
    }
}
