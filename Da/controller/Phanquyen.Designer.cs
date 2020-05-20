namespace Da.controller
{
    partial class Phanquyen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Phanquyen));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btn_load = new DevExpress.XtraEditors.SimpleButton();
            this.btn_pq = new DevExpress.XtraEditors.SimpleButton();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.rdo_nhanvien = new System.Windows.Forms.RadioButton();
            this.rdo_admin = new System.Windows.Forms.RadioButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dgv_taikhoan = new System.Windows.Forms.DataGridView();
            this.TENTK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MANV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUYEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_taikhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.groupControl2);
            this.panel1.Controls.Add(this.groupControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1661, 775);
            this.panel1.TabIndex = 0;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btn_load);
            this.groupControl2.Controls.Add(this.btn_pq);
            this.groupControl2.Controls.Add(this.listBox2);
            this.groupControl2.Controls.Add(this.listBox1);
            this.groupControl2.Controls.Add(this.rdo_nhanvien);
            this.groupControl2.Controls.Add(this.rdo_admin);
            this.groupControl2.Location = new System.Drawing.Point(614, 31);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1077, 740);
            this.groupControl2.TabIndex = 5;
            this.groupControl2.Text = "Bản quyền";
            // 
            // btn_load
            // 
            this.btn_load.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btn_load.Appearance.Options.UseFont = true;
            this.btn_load.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_load.ImageOptions.SvgImage")));
            this.btn_load.Location = new System.Drawing.Point(481, 650);
            this.btn_load.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(136, 49);
            this.btn_load.TabIndex = 7;
            this.btn_load.Text = "Load";
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // btn_pq
            // 
            this.btn_pq.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btn_pq.Appearance.Options.UseFont = true;
            this.btn_pq.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_pq.ImageOptions.SvgImage")));
            this.btn_pq.Location = new System.Drawing.Point(286, 650);
            this.btn_pq.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_pq.Name = "btn_pq";
            this.btn_pq.Size = new System.Drawing.Size(170, 49);
            this.btn_pq.TabIndex = 6;
            this.btn_pq.Text = "Phân quyền";
            this.btn_pq.Click += new System.EventHandler(this.btn_pq_Click);
            // 
            // listBox2
            // 
            this.listBox2.Enabled = false;
            this.listBox2.Font = new System.Drawing.Font("Tahoma", 14F);
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 28;
            this.listBox2.Items.AddRange(new object[] {
            "Thêm, xóa, sửa bảng KHACHHANG",
            "Thêm, xóa, sửa bảng PHIEUDAT",
            "Thêm, xóa, sửa bảng PHIEUTHUE",
            "Thêm, xóa, sửa bảng HOADON",
            "Thêm, xóa, sửa bảng HD_DICHVU"});
            this.listBox2.Location = new System.Drawing.Point(26, 386);
            this.listBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(1018, 256);
            this.listBox2.TabIndex = 3;
            // 
            // listBox1
            // 
            this.listBox1.Enabled = false;
            this.listBox1.Font = new System.Drawing.Font("Tahoma", 14F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 28;
            this.listBox1.Items.AddRange(new object[] {
            "Thêm, xóa, sửa bảng TAIKHOAN",
            "Thêm, xóa, sửa bảng NHANVIEN",
            "Thêm, xóa, sửa bảng LOAIPHONG",
            "Thêm, xóa, sửa bảng DANHMUC_TB",
            "Thêm, xóa, sửa bảngDICHVU, THANHTOAN",
            "Thêm, xóa, sửa bảng PHONG"});
            this.listBox1.Location = new System.Drawing.Point(26, 94);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1018, 228);
            this.listBox1.TabIndex = 2;
            // 
            // rdo_nhanvien
            // 
            this.rdo_nhanvien.AutoSize = true;
            this.rdo_nhanvien.Font = new System.Drawing.Font("Tahoma", 16F);
            this.rdo_nhanvien.Location = new System.Drawing.Point(15, 341);
            this.rdo_nhanvien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdo_nhanvien.Name = "rdo_nhanvien";
            this.rdo_nhanvien.Size = new System.Drawing.Size(235, 37);
            this.rdo_nhanvien.TabIndex = 1;
            this.rdo_nhanvien.TabStop = true;
            this.rdo_nhanvien.Text = "Quyền nhân viên";
            this.rdo_nhanvien.UseVisualStyleBackColor = true;
            this.rdo_nhanvien.Click += new System.EventHandler(this.rdo_nhanvien_Click);
            // 
            // rdo_admin
            // 
            this.rdo_admin.AutoSize = true;
            this.rdo_admin.Font = new System.Drawing.Font("Tahoma", 16F);
            this.rdo_admin.Location = new System.Drawing.Point(15, 36);
            this.rdo_admin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdo_admin.Name = "rdo_admin";
            this.rdo_admin.Size = new System.Drawing.Size(193, 37);
            this.rdo_admin.TabIndex = 0;
            this.rdo_admin.TabStop = true;
            this.rdo_admin.Text = "Quyền admin";
            this.rdo_admin.UseVisualStyleBackColor = true;
            this.rdo_admin.Click += new System.EventHandler(this.rdo_admin_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.dgv_taikhoan);
            this.groupControl1.Location = new System.Drawing.Point(3, 31);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(605, 740);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Danh mục tài khoản";
            // 
            // dgv_taikhoan
            // 
            this.dgv_taikhoan.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_taikhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_taikhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TENTK,
            this.MANV,
            this.MK,
            this.QUYEN});
            this.dgv_taikhoan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_taikhoan.Location = new System.Drawing.Point(2, 28);
            this.dgv_taikhoan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_taikhoan.Name = "dgv_taikhoan";
            this.dgv_taikhoan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_taikhoan.Size = new System.Drawing.Size(601, 710);
            this.dgv_taikhoan.TabIndex = 0;
            this.dgv_taikhoan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_taikhoan_CellContentClick);
            this.dgv_taikhoan.Click += new System.EventHandler(this.dgv_taikhoan_Click);
            // 
            // TENTK
            // 
            this.TENTK.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TENTK.DataPropertyName = "TENTK";
            this.TENTK.HeaderText = "Tên tài khoản";
            this.TENTK.Name = "TENTK";
            // 
            // MANV
            // 
            this.MANV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MANV.DataPropertyName = "MANV";
            this.MANV.HeaderText = "Mã nhân viên";
            this.MANV.Name = "MANV";
            // 
            // MK
            // 
            this.MK.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MK.DataPropertyName = "MK";
            this.MK.HeaderText = "Mật khẩu";
            this.MK.Name = "MK";
            // 
            // QUYEN
            // 
            this.QUYEN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.QUYEN.DataPropertyName = "QUYEN";
            this.QUYEN.HeaderText = "Quyền";
            this.QUYEN.Name = "QUYEN";
            // 
            // Phanquyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "Phanquyen";
            this.Size = new System.Drawing.Size(1661, 775);
            this.Load += new System.EventHandler(this.Phanquyen_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_taikhoan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btn_pq;
        private DevExpress.XtraEditors.SimpleButton btn_load;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RadioButton rdo_nhanvien;
        private System.Windows.Forms.RadioButton rdo_admin;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.DataGridView dgv_taikhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MK;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUYEN;
    }
}
