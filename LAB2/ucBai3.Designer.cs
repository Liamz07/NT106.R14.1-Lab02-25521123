namespace LAB2
{
    partial class ucBai3
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
            rtbContent = new RichTextBox();
            btnThoat = new Button();
            btnTinhToan = new Button();
            btnDocFile = new Button();
            btnGhiFile = new Button();
            SuspendLayout();
            // 
            // rtbContent
            // 
            rtbContent.Location = new Point(269, 21);
            rtbContent.Name = "rtbContent";
            rtbContent.Size = new Size(410, 447);
            rtbContent.TabIndex = 7;
            rtbContent.Text = "";
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThoat.Location = new Point(37, 412);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(209, 56);
            btnThoat.TabIndex = 6;
            btnThoat.Text = "THOÁT";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnTinhToan
            // 
            btnTinhToan.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTinhToan.Location = new Point(37, 108);
            btnTinhToan.Name = "btnTinhToan";
            btnTinhToan.Size = new Size(209, 56);
            btnTinhToan.TabIndex = 5;
            btnTinhToan.Text = "TÍNH TOÁN";
            btnTinhToan.UseVisualStyleBackColor = true;
            btnTinhToan.Click += btnTinhToan_Click;
            // 
            // btnDocFile
            // 
            btnDocFile.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDocFile.Location = new Point(37, 21);
            btnDocFile.Name = "btnDocFile";
            btnDocFile.Size = new Size(209, 56);
            btnDocFile.TabIndex = 4;
            btnDocFile.Text = "ĐỌC FILE";
            btnDocFile.UseVisualStyleBackColor = true;
            btnDocFile.Click += btnDocFile_Click;
            // 
            // btnGhiFile
            // 
            btnGhiFile.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGhiFile.Location = new Point(37, 195);
            btnGhiFile.Name = "btnGhiFile";
            btnGhiFile.Size = new Size(209, 56);
            btnGhiFile.TabIndex = 8;
            btnGhiFile.Text = "GHI FILE";
            btnGhiFile.UseVisualStyleBackColor = true;
            btnGhiFile.Click += btnGhiFile_Click;
            // 
            // ucBai3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnGhiFile);
            Controls.Add(rtbContent);
            Controls.Add(btnThoat);
            Controls.Add(btnTinhToan);
            Controls.Add(btnDocFile);
            Name = "ucBai3";
            Size = new Size(717, 488);
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox rtbContent;
        private Button btnThoat;
        private Button btnTinhToan;
        private Button btnDocFile;
        private Button btnGhiFile;
    }
}
