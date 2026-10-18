namespace LAB2
{
    partial class ucBai2
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
            btnLuaChonFile = new Button();
            tenFile = new Label();
            rtbTenFile = new RichTextBox();
            kichCo = new Label();
            URL = new Label();
            soDong = new Label();
            soKyTu = new Label();
            soTu = new Label();
            btnThoat = new Button();
            rtbKichCo = new RichTextBox();
            rtbURL = new RichTextBox();
            rtbSoDong = new RichTextBox();
            rtbSoTu = new RichTextBox();
            rtbSoKyTu = new RichTextBox();
            rtbContent = new RichTextBox();
            SuspendLayout();
            // 
            // btnLuaChonFile
            // 
            btnLuaChonFile.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLuaChonFile.Location = new Point(33, 15);
            btnLuaChonFile.Name = "btnLuaChonFile";
            btnLuaChonFile.Size = new Size(286, 41);
            btnLuaChonFile.TabIndex = 0;
            btnLuaChonFile.Text = "Đọc từ file";
            btnLuaChonFile.UseVisualStyleBackColor = true;
            btnLuaChonFile.Click += btnLuaChonFile_Click;
            // 
            // tenFile
            // 
            tenFile.AutoSize = true;
            tenFile.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tenFile.Location = new Point(33, 89);
            tenFile.Name = "tenFile";
            tenFile.Size = new Size(60, 20);
            tenFile.TabIndex = 1;
            tenFile.Text = "Tên file";
            // 
            // rtbTenFile
            // 
            rtbTenFile.Location = new Point(120, 86);
            rtbTenFile.Name = "rtbTenFile";
            rtbTenFile.Size = new Size(199, 30);
            rtbTenFile.TabIndex = 2;
            rtbTenFile.Text = "";
            // 
            // kichCo
            // 
            kichCo.AutoSize = true;
            kichCo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kichCo.Location = new Point(33, 144);
            kichCo.Name = "kichCo";
            kichCo.Size = new Size(59, 20);
            kichCo.TabIndex = 3;
            kichCo.Text = "Kích cỡ";
            // 
            // URL
            // 
            URL.AutoSize = true;
            URL.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            URL.Location = new Point(33, 199);
            URL.Name = "URL";
            URL.Size = new Size(38, 20);
            URL.TabIndex = 4;
            URL.Text = "URL";
            // 
            // soDong
            // 
            soDong.AutoSize = true;
            soDong.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            soDong.Location = new Point(34, 254);
            soDong.Name = "soDong";
            soDong.Size = new Size(66, 20);
            soDong.TabIndex = 5;
            soDong.Text = "Số dòng";
            // 
            // soKyTu
            // 
            soKyTu.AutoSize = true;
            soKyTu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            soKyTu.Location = new Point(34, 364);
            soKyTu.Name = "soKyTu";
            soKyTu.Size = new Size(66, 20);
            soKyTu.TabIndex = 6;
            soKyTu.Text = "Số ký tự";
            // 
            // soTu
            // 
            soTu.AutoSize = true;
            soTu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            soTu.Location = new Point(34, 309);
            soTu.Name = "soTu";
            soTu.Size = new Size(46, 20);
            soTu.TabIndex = 7;
            soTu.Text = "Số từ";
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThoat.Location = new Point(34, 426);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(286, 41);
            btnThoat.TabIndex = 8;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // rtbKichCo
            // 
            rtbKichCo.Location = new Point(120, 141);
            rtbKichCo.Name = "rtbKichCo";
            rtbKichCo.Size = new Size(199, 30);
            rtbKichCo.TabIndex = 9;
            rtbKichCo.Text = "";
            // 
            // rtbURL
            // 
            rtbURL.Location = new Point(120, 196);
            rtbURL.Name = "rtbURL";
            rtbURL.Size = new Size(199, 30);
            rtbURL.TabIndex = 10;
            rtbURL.Text = "";
            // 
            // rtbSoDong
            // 
            rtbSoDong.Location = new Point(120, 254);
            rtbSoDong.Name = "rtbSoDong";
            rtbSoDong.Size = new Size(199, 30);
            rtbSoDong.TabIndex = 11;
            rtbSoDong.Text = "";
            // 
            // rtbSoTu
            // 
            rtbSoTu.Location = new Point(120, 309);
            rtbSoTu.Name = "rtbSoTu";
            rtbSoTu.Size = new Size(199, 30);
            rtbSoTu.TabIndex = 12;
            rtbSoTu.Text = "";
            // 
            // rtbSoKyTu
            // 
            rtbSoKyTu.Location = new Point(120, 361);
            rtbSoKyTu.Name = "rtbSoKyTu";
            rtbSoKyTu.Size = new Size(199, 30);
            rtbSoKyTu.TabIndex = 13;
            rtbSoKyTu.Text = "";
            // 
            // rtbContent
            // 
            rtbContent.Location = new Point(347, 15);
            rtbContent.Name = "rtbContent";
            rtbContent.Size = new Size(342, 452);
            rtbContent.TabIndex = 14;
            rtbContent.Text = "";
            // 
            // ucBai2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(rtbContent);
            Controls.Add(rtbSoKyTu);
            Controls.Add(rtbSoTu);
            Controls.Add(rtbSoDong);
            Controls.Add(rtbURL);
            Controls.Add(rtbKichCo);
            Controls.Add(btnThoat);
            Controls.Add(soTu);
            Controls.Add(soKyTu);
            Controls.Add(soDong);
            Controls.Add(URL);
            Controls.Add(kichCo);
            Controls.Add(rtbTenFile);
            Controls.Add(tenFile);
            Controls.Add(btnLuaChonFile);
            Name = "ucBai2";
            Size = new Size(717, 488);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLuaChonFile;
        private Label tenFile;
        private RichTextBox rtbTenFile;
        private Label kichCo;
        private Label URL;
        private Label soDong;
        private Label soKyTu;
        private Label soTu;
        private Button btnThoat;
        private RichTextBox rtbKichCo;
        private RichTextBox rtbURL;
        private RichTextBox rtbSoDong;
        private RichTextBox rtbSoTu;
        private RichTextBox rtbSoKyTu;
        private RichTextBox rtbContent;
    }
}
