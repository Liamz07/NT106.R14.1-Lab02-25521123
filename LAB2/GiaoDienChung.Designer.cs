namespace LAB2
{
    partial class GiaoDienChung
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelLogo = new Panel();
            TieuDe = new Label();
            panelSidebar = new Panel();
            btnBai7 = new Button();
            btnBai6 = new Button();
            btnBai5 = new Button();
            btnBai4 = new Button();
            btnBai3 = new Button();
            btnBai2 = new Button();
            btnBai1 = new Button();
            panelContent = new Panel();
            gbContent = new GroupBox();
            panelLogo.SuspendLayout();
            panelSidebar.SuspendLayout();
            panelContent.SuspendLayout();
            SuspendLayout();
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(TieuDe);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(977, 48);
            panelLogo.TabIndex = 0;
            // 
            // TieuDe
            // 
            TieuDe.AutoSize = true;
            TieuDe.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TieuDe.Location = new Point(317, 8);
            TieuDe.Name = "TieuDe";
            TieuDe.Size = new Size(343, 38);
            TieuDe.TabIndex = 0;
            TieuDe.Text = "BÁO CÁO BÀI TẬP LAB 2";
            TieuDe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelSidebar
            // 
            panelSidebar.Controls.Add(btnBai7);
            panelSidebar.Controls.Add(btnBai6);
            panelSidebar.Controls.Add(btnBai5);
            panelSidebar.Controls.Add(btnBai4);
            panelSidebar.Controls.Add(btnBai3);
            panelSidebar.Controls.Add(btnBai2);
            panelSidebar.Controls.Add(btnBai1);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 48);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(203, 539);
            panelSidebar.TabIndex = 1;
            // 
            // btnBai7
            // 
            btnBai7.Location = new Point(28, 453);
            btnBai7.Name = "btnBai7";
            btnBai7.Size = new Size(146, 50);
            btnBai7.TabIndex = 6;
            btnBai7.Text = "Bài 7";
            btnBai7.UseVisualStyleBackColor = true;
            btnBai7.Click += btnBai7_Click;
            // 
            // btnBai6
            // 
            btnBai6.Location = new Point(28, 380);
            btnBai6.Name = "btnBai6";
            btnBai6.Size = new Size(146, 50);
            btnBai6.TabIndex = 5;
            btnBai6.Text = "Bài 6";
            btnBai6.UseVisualStyleBackColor = true;
            btnBai6.Click += btnBai6_Click;
            // 
            // btnBai5
            // 
            btnBai5.Location = new Point(28, 307);
            btnBai5.Name = "btnBai5";
            btnBai5.Size = new Size(146, 50);
            btnBai5.TabIndex = 4;
            btnBai5.Text = "Bài 5";
            btnBai5.UseVisualStyleBackColor = true;
            btnBai5.Click += btnBai5_Click;
            // 
            // btnBai4
            // 
            btnBai4.Location = new Point(28, 234);
            btnBai4.Name = "btnBai4";
            btnBai4.Size = new Size(146, 50);
            btnBai4.TabIndex = 3;
            btnBai4.Text = "Bài 4";
            btnBai4.UseVisualStyleBackColor = true;
            btnBai4.Click += btnBai4_Click;
            // 
            // btnBai3
            // 
            btnBai3.Location = new Point(28, 161);
            btnBai3.Name = "btnBai3";
            btnBai3.Size = new Size(146, 50);
            btnBai3.TabIndex = 2;
            btnBai3.Text = "Bài 3";
            btnBai3.UseVisualStyleBackColor = true;
            btnBai3.Click += btnBai3_Click;
            // 
            // btnBai2
            // 
            btnBai2.Location = new Point(28, 88);
            btnBai2.Name = "btnBai2";
            btnBai2.Size = new Size(146, 50);
            btnBai2.TabIndex = 1;
            btnBai2.Text = "Bài 2";
            btnBai2.UseVisualStyleBackColor = true;
            btnBai2.Click += btnBai2_Click;
            // 
            // btnBai1
            // 
            btnBai1.Location = new Point(28, 15);
            btnBai1.Name = "btnBai1";
            btnBai1.Size = new Size(146, 50);
            btnBai1.TabIndex = 0;
            btnBai1.Text = "Bài 1";
            btnBai1.UseVisualStyleBackColor = true;
            btnBai1.Click += btnBai1_Click;
            // 
            // panelContent
            // 
            panelContent.Controls.Add(gbContent);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(203, 48);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(774, 539);
            panelContent.TabIndex = 2;
            // 
            // gbContent
            // 
            gbContent.Location = new Point(30, 15);
            gbContent.Margin = new Padding(5);
            gbContent.Name = "gbContent";
            gbContent.Padding = new Padding(5);
            gbContent.Size = new Size(717, 488);
            gbContent.TabIndex = 0;
            gbContent.TabStop = false;
            gbContent.Text = "NỘI DUNG BÀI TẬP";
            // 
            // GiaoDienChung
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(977, 587);
            Controls.Add(panelContent);
            Controls.Add(panelSidebar);
            Controls.Add(panelLogo);
            Name = "GiaoDienChung";
            Text = "Menu";
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            panelSidebar.ResumeLayout(false);
            panelContent.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLogo;
        private Panel panelSidebar;
        private Panel panelContent;
        private Button btnBai1;
        private Button btnBai4;
        private Button btnBai3;
        private Button btnBai2;
        private Button btnBai7;
        private Button btnBai6;
        private Button btnBai5;
        private Label TieuDe;
        private GroupBox gbContent;
    }
}
