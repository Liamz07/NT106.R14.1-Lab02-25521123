namespace LAB2
{
    partial class ucBai7
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
            treeView = new TreeView();
            gbContent = new GroupBox();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // treeView
            // 
            treeView.Location = new Point(26, 24);
            treeView.Name = "treeView";
            treeView.Size = new Size(216, 412);
            treeView.TabIndex = 0;
            treeView.NodeMouseClick += treeView_NodeMouseClick;
            // 
            // gbContent
            // 
            gbContent.Location = new Point(268, 24);
            gbContent.Name = "gbContent";
            gbContent.Size = new Size(414, 412);
            gbContent.TabIndex = 1;
            gbContent.TabStop = false;
            gbContent.Text = "File Content";
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThoat.Location = new Point(68, 442);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(123, 43);
            btnThoat.TabIndex = 2;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // ucBai7
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnThoat);
            Controls.Add(gbContent);
            Controls.Add(treeView);
            Name = "ucBai7";
            Size = new Size(717, 488);
            Load += ucBai7_Load;
            ResumeLayout(false);
        }

        #endregion

        private TreeView treeView;
        private GroupBox gbContent;
        private Button btnThoat;
    }
}
