namespace quanlykho
{
    partial class formThemnhap
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbmahh = new System.Windows.Forms.ComboBox();
            this.cbmakho = new System.Windows.Forms.ComboBox();
            this.cbnhacc = new System.Windows.Forms.ComboBox();
            this.datenn = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.xxxx = new System.Windows.Forms.Label();
            this.btXoa = new System.Windows.Forms.Button();
            this.btsua = new System.Windows.Forms.Button();
            this.btthem = new System.Windows.Forms.Button();
            this.txtdongia = new System.Windows.Forms.TextBox();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.txtmpn = new System.Windows.Forms.TextBox();
            this.dg1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbmahh);
            this.groupBox1.Controls.Add(this.cbmakho);
            this.groupBox1.Controls.Add(this.cbnhacc);
            this.groupBox1.Controls.Add(this.datenn);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.xxxx);
            this.groupBox1.Controls.Add(this.btXoa);
            this.groupBox1.Controls.Add(this.btsua);
            this.groupBox1.Controls.Add(this.btthem);
            this.groupBox1.Controls.Add(this.txtdongia);
            this.groupBox1.Controls.Add(this.txtsoluong);
            this.groupBox1.Controls.Add(this.txtmpn);
            this.groupBox1.Location = new System.Drawing.Point(0, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(756, 172);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // cbmahh
            // 
            this.cbmahh.FormattingEnabled = true;
            this.cbmahh.Location = new System.Drawing.Point(325, 49);
            this.cbmahh.Name = "cbmahh";
            this.cbmahh.Size = new System.Drawing.Size(121, 21);
            this.cbmahh.TabIndex = 26;
            // 
            // cbmakho
            // 
            this.cbmakho.FormattingEnabled = true;
            this.cbmakho.Location = new System.Drawing.Point(91, 76);
            this.cbmakho.Name = "cbmakho";
            this.cbmakho.Size = new System.Drawing.Size(121, 21);
            this.cbmakho.TabIndex = 25;
            this.cbmakho.SelectedIndexChanged += new System.EventHandler(this.cbmakho_SelectedIndexChanged);
            // 
            // cbnhacc
            // 
            this.cbnhacc.FormattingEnabled = true;
            this.cbnhacc.Location = new System.Drawing.Point(325, 14);
            this.cbnhacc.Name = "cbnhacc";
            this.cbnhacc.Size = new System.Drawing.Size(121, 21);
            this.cbnhacc.TabIndex = 24;
            // 
            // datenn
            // 
            this.datenn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datenn.Location = new System.Drawing.Point(91, 42);
            this.datenn.Name = "datenn";
            this.datenn.Size = new System.Drawing.Size(120, 20);
            this.datenn.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(475, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Đơn giá";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(475, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Số Lượng ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(226, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Mã hàng hóa";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Mã kho";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Mã phiếu";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Mã Nhà cung câp";
            // 
            // xxxx
            // 
            this.xxxx.AutoSize = true;
            this.xxxx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xxxx.Location = new System.Drawing.Point(6, 47);
            this.xxxx.Name = "xxxx";
            this.xxxx.Size = new System.Drawing.Size(66, 15);
            this.xxxx.TabIndex = 13;
            this.xxxx.Text = "Ngày nhập";
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(444, 143);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 23);
            this.btXoa.TabIndex = 12;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btsua
            // 
            this.btsua.Location = new System.Drawing.Point(312, 143);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(75, 23);
            this.btsua.TabIndex = 11;
            this.btsua.Text = "Sửa";
            this.btsua.UseVisualStyleBackColor = true;
            this.btsua.Click += new System.EventHandler(this.btsua_Click);
            // 
            // btthem
            // 
            this.btthem.Location = new System.Drawing.Point(156, 143);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(75, 23);
            this.btthem.TabIndex = 10;
            this.btthem.Text = "Thêm ";
            this.btthem.UseVisualStyleBackColor = true;
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
            // 
            // txtdongia
            // 
            this.txtdongia.Location = new System.Drawing.Point(551, 41);
            this.txtdongia.Name = "txtdongia";
            this.txtdongia.Size = new System.Drawing.Size(121, 20);
            this.txtdongia.TabIndex = 9;
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(551, 12);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(121, 20);
            this.txtsoluong.TabIndex = 8;
            // 
            // txtmpn
            // 
            this.txtmpn.Location = new System.Drawing.Point(91, 16);
            this.txtmpn.Name = "txtmpn";
            this.txtmpn.Size = new System.Drawing.Size(120, 20);
            this.txtmpn.TabIndex = 4;
            // 
            // dg1
            // 
            this.dg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg1.Location = new System.Drawing.Point(0, 209);
            this.dg1.Name = "dg1";
            this.dg1.Size = new System.Drawing.Size(756, 160);
            this.dg1.TabIndex = 1;
            this.dg1.Click += new System.EventHandler(this.dg1_Click);
            // 
            // formThemnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 367);
            this.Controls.Add(this.dg1);
            this.Controls.Add(this.groupBox1);
            this.Name = "formThemnhap";
            this.Text = "formThemnhap";
            this.Load += new System.EventHandler(this.formThemnhap_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker datenn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label xxxx;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.TextBox txtdongia;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.TextBox txtmpn;
        private System.Windows.Forms.ComboBox cbmakho;
        private System.Windows.Forms.ComboBox cbnhacc;
        private System.Windows.Forms.DataGridView dg1;
        private System.Windows.Forms.ComboBox cbmahh;
    }
}