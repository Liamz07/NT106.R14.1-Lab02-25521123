namespace LAB2
{
    partial class ucBai1
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
            btnDocFile = new Button();
            btnGhiFile = new Button();
            btnThoat = new Button();
            rtbContent = new RichTextBox();
            SuspendLayout();
            // 
            // btnDocFile
            // 
            btnDocFile.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDocFile.Location = new Point(35, 23);
            btnDocFile.Name = "btnDocFile";
            btnDocFile.Size = new Size(209, 56);
            btnDocFile.TabIndex = 0;
            btnDocFile.Text = "ĐỌC FILE";
            btnDocFile.UseVisualStyleBackColor = true;
            btnDocFile.Click += btnDocFile_Click;
            // 
            // btnGhiFile
            // 
            btnGhiFile.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGhiFile.Location = new Point(35, 107);
            btnGhiFile.Name = "btnGhiFile";
            btnGhiFile.Size = new Size(209, 56);
            btnGhiFile.TabIndex = 1;
            btnGhiFile.Text = "GHI FILE";
            btnGhiFile.UseVisualStyleBackColor = true;
            btnGhiFile.Click += btnGhiFile_Click;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThoat.Location = new Point(35, 407);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(209, 56);
            btnThoat.TabIndex = 2;
            btnThoat.Text = "THOÁT";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // rtbContent
            // 
            rtbContent.Location = new Point(267, 23);
            rtbContent.Name = "rtbContent";
            rtbContent.Size = new Size(410, 440);
            rtbContent.TabIndex = 3;
            rtbContent.Text = "";
            // 
            // ucBai1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(rtbContent);
            Controls.Add(btnThoat);
            Controls.Add(btnGhiFile);
            Controls.Add(btnDocFile);
            Name = "ucBai1";
            Size = new Size(717, 488);
            ResumeLayout(false);
        }

        #endregion

        private Button btnDocFile;
        private Button btnGhiFile;
        private Button btnThoat;
        private RichTextBox rtbContent;
    }
}
