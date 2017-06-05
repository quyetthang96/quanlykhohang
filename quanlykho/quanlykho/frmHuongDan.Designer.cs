namespace quanlykho
{
    partial class frmHuongDan
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mns_huongdan = new System.Windows.Forms.MenuStrip();
            this.tmns_huongdan = new System.Windows.Forms.ToolStripMenuItem();
            this.tmns_nhaphang = new System.Windows.Forms.ToolStripMenuItem();
            this.tmns_xuathang = new System.Windows.Forms.ToolStripMenuItem();
            this.tmns_timkiem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmns_thongke = new System.Windows.Forms.ToolStripMenuItem();
            this.wbw_huongdan = new System.Windows.Forms.WebBrowser();
            this.mns_huongdan.SuspendLayout();
            this.SuspendLayout();
            // 
            // mns_huongdan
            // 
            this.mns_huongdan.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmns_huongdan,
            this.tmns_nhaphang,
            this.tmns_xuathang,
            this.tmns_timkiem,
            this.tmns_thongke});
            this.mns_huongdan.Location = new System.Drawing.Point(0, 0);
            this.mns_huongdan.Name = "mns_huongdan";
            this.mns_huongdan.Size = new System.Drawing.Size(989, 24);
            this.mns_huongdan.TabIndex = 0;
            this.mns_huongdan.Text = "menuStrip1";
            // 
            // tmns_huongdan
            // 
            this.tmns_huongdan.Name = "tmns_huongdan";
            this.tmns_huongdan.Size = new System.Drawing.Size(79, 20);
            this.tmns_huongdan.Text = "Hướng dẫn";
            this.tmns_huongdan.Click += new System.EventHandler(this.tmns_huongdan_Click);
            // 
            // tmns_nhaphang
            // 
            this.tmns_nhaphang.Name = "tmns_nhaphang";
            this.tmns_nhaphang.Size = new System.Drawing.Size(78, 20);
            this.tmns_nhaphang.Text = "Nhập hàng";
            this.tmns_nhaphang.Click += new System.EventHandler(this.tmns_nhaphang_Click);
            // 
            // tmns_xuathang
            // 
            this.tmns_xuathang.Name = "tmns_xuathang";
            this.tmns_xuathang.Size = new System.Drawing.Size(73, 20);
            this.tmns_xuathang.Text = "Xuất hàng";
            this.tmns_xuathang.Click += new System.EventHandler(this.tmns_xuathang_Click);
            // 
            // tmns_timkiem
            // 
            this.tmns_timkiem.Name = "tmns_timkiem";
            this.tmns_timkiem.Size = new System.Drawing.Size(69, 20);
            this.tmns_timkiem.Text = "Tìm kiếm";
            this.tmns_timkiem.Click += new System.EventHandler(this.tmns_timkiem_Click);
            // 
            // tmns_thongke
            // 
            this.tmns_thongke.Name = "tmns_thongke";
            this.tmns_thongke.Size = new System.Drawing.Size(69, 20);
            this.tmns_thongke.Text = "Thống kê";
            this.tmns_thongke.Click += new System.EventHandler(this.tmns_thongke_Click);
            // 
            // wbw_huongdan
            // 
            this.wbw_huongdan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbw_huongdan.Location = new System.Drawing.Point(0, 24);
            this.wbw_huongdan.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbw_huongdan.Name = "wbw_huongdan";
            this.wbw_huongdan.Size = new System.Drawing.Size(989, 453);
            this.wbw_huongdan.TabIndex = 1;
            this.wbw_huongdan.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.wbw_huongdan_DocumentCompleted);
            // 
            // frmHuongDan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 477);
            this.Controls.Add(this.wbw_huongdan);
            this.Controls.Add(this.mns_huongdan);
            this.MainMenuStrip = this.mns_huongdan;
            this.Name = "frmHuongDan";
            this.Text = "Hướng dẫn sử dụng";
            this.Load += new System.EventHandler(this.frmHuongDan_Load);
            this.mns_huongdan.ResumeLayout(false);
            this.mns_huongdan.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mns_huongdan;
        private System.Windows.Forms.ToolStripMenuItem tmns_huongdan;
        private System.Windows.Forms.ToolStripMenuItem tmns_nhaphang;
        private System.Windows.Forms.ToolStripMenuItem tmns_xuathang;
        private System.Windows.Forms.ToolStripMenuItem tmns_timkiem;
        private System.Windows.Forms.ToolStripMenuItem tmns_thongke;
        private System.Windows.Forms.WebBrowser wbw_huongdan;
    }
}