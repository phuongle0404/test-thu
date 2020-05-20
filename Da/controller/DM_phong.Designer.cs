namespace Da.controller
{
    partial class DM_phong
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DM_phong));
            this.dgv_loaiph = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_ph = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colum1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLuu_loaiph = new DevExpress.XtraEditors.SimpleButton();
            this.txt_ghichu = new DevExpress.XtraEditors.TextEdit();
            this.txt_gia = new DevExpress.XtraEditors.TextEdit();
            this.txt_tenloai = new DevExpress.XtraEditors.TextEdit();
            this.txt_maloai = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnThem_LoaiPH = new DevExpress.XtraEditors.SimpleButton();
            this.btn_capnhat_loai = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnLuu_PH = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.btn_capnhat_ph = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem_PH = new DevExpress.XtraEditors.SimpleButton();
            this.cbo_maloai = new System.Windows.Forms.ComboBox();
            this.txt_tinhtrang = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txt_maph = new DevExpress.XtraEditors.TextEdit();
            this.txt_vitri = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.qL_KHACHSANDataSet = new Da.QL_KHACHSANDataSet();
            this.pHONGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pHONGTableAdapter = new Da.QL_KHACHSANDataSetTableAdapters.PHONGTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_loaiph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ph)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ghichu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_gia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tenloai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_maloai.Properties)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tinhtrang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_maph.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_vitri.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_KHACHSANDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHONGBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_loaiph
            // 
            this.dgv_loaiph.BackgroundColor = System.Drawing.Color.White;
            this.dgv_loaiph.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_loaiph.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgv_loaiph.Location = new System.Drawing.Point(6, 324);
            this.dgv_loaiph.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_loaiph.Name = "dgv_loaiph";
            this.dgv_loaiph.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_loaiph.Size = new System.Drawing.Size(851, 377);
            this.dgv_loaiph.TabIndex = 0;
            this.dgv_loaiph.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_loaiph_CellContentClick);
            this.dgv_loaiph.Click += new System.EventHandler(this.dgv_loaiph_Click);
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "MALOAI";
            this.Column2.HeaderText = "Mã loại phòng";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "TENLOAI";
            this.Column3.HeaderText = "Tên loại phòng";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "GIAPH";
            this.Column4.HeaderText = "Giá";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "GHICHU";
            this.Column5.HeaderText = "Ghi chú";
            this.Column5.Name = "Column5";
            // 
            // dgv_ph
            // 
            this.dgv_ph.BackgroundColor = System.Drawing.Color.White;
            this.dgv_ph.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ph.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column7,
            this.Column8,
            this.colum1,
            this.Column1});
            this.dgv_ph.Location = new System.Drawing.Point(6, 325);
            this.dgv_ph.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_ph.Name = "dgv_ph";
            this.dgv_ph.Size = new System.Drawing.Size(840, 377);
            this.dgv_ph.TabIndex = 5;
            this.dgv_ph.EditModeChanged += new System.EventHandler(this.DM_phong_Load);
            this.dgv_ph.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ph_CellContentClick);
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.DataPropertyName = "MAPH";
            this.Column6.HeaderText = "Mã phòng";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.DataPropertyName = "VTPHONG";
            this.Column7.HeaderText = "Vị trí";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column8.DataPropertyName = "TINHTRANG";
            this.Column8.HeaderText = "Tình trạng";
            this.Column8.Name = "Column8";
            // 
            // colum1
            // 
            this.colum1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colum1.DataPropertyName = "GIAPHONG";
            this.colum1.HeaderText = "Giá theo tầng";
            this.colum1.Name = "colum1";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MALOAI";
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.btnLuu_loaiph);
            this.groupBox1.Controls.Add(this.txt_ghichu);
            this.groupBox1.Controls.Add(this.txt_gia);
            this.groupBox1.Controls.Add(this.dgv_loaiph);
            this.groupBox1.Controls.Add(this.txt_tenloai);
            this.groupBox1.Controls.Add(this.txt_maloai);
            this.groupBox1.Controls.Add(this.labelControl4);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Controls.Add(this.btnThem_LoaiPH);
            this.groupBox1.Controls.Add(this.btn_capnhat_loai);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.groupBox1.Location = new System.Drawing.Point(880, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(863, 717);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin loại phòng";
            // 
            // btnLuu_loaiph
            // 
            this.btnLuu_loaiph.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu_loaiph.Appearance.Options.UseFont = true;
            this.btnLuu_loaiph.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu_loaiph.ImageOptions.Image")));
            this.btnLuu_loaiph.Location = new System.Drawing.Point(739, 249);
            this.btnLuu_loaiph.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnLuu_loaiph.Name = "btnLuu_loaiph";
            this.btnLuu_loaiph.Size = new System.Drawing.Size(99, 49);
            this.btnLuu_loaiph.TabIndex = 42;
            this.btnLuu_loaiph.Text = "Lưu";
            this.btnLuu_loaiph.Click += new System.EventHandler(this.btnLuu_loaiph_Click_1);
            // 
            // txt_ghichu
            // 
            this.txt_ghichu.Location = new System.Drawing.Point(202, 198);
            this.txt_ghichu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_ghichu.Name = "txt_ghichu";
            this.txt_ghichu.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txt_ghichu.Properties.Appearance.Options.UseFont = true;
            this.txt_ghichu.Size = new System.Drawing.Size(546, 28);
            this.txt_ghichu.TabIndex = 15;
            // 
            // txt_gia
            // 
            this.txt_gia.Location = new System.Drawing.Point(202, 141);
            this.txt_gia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_gia.Name = "txt_gia";
            this.txt_gia.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txt_gia.Properties.Appearance.Options.UseFont = true;
            this.txt_gia.Size = new System.Drawing.Size(546, 28);
            this.txt_gia.TabIndex = 14;
            // 
            // txt_tenloai
            // 
            this.txt_tenloai.Location = new System.Drawing.Point(202, 85);
            this.txt_tenloai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_tenloai.Name = "txt_tenloai";
            this.txt_tenloai.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txt_tenloai.Properties.Appearance.Options.UseFont = true;
            this.txt_tenloai.Size = new System.Drawing.Size(546, 28);
            this.txt_tenloai.TabIndex = 13;
            // 
            // txt_maloai
            // 
            this.txt_maloai.Location = new System.Drawing.Point(202, 37);
            this.txt_maloai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_maloai.Name = "txt_maloai";
            this.txt_maloai.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txt_maloai.Properties.Appearance.Options.UseFont = true;
            this.txt_maloai.Size = new System.Drawing.Size(546, 28);
            this.txt_maloai.TabIndex = 12;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(81, 204);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(66, 22);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Ghi Chú";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(85, 137);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(30, 22);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Giá";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(81, 88);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(72, 22);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Tên loại:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(85, 40);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(68, 22);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Mã loại:";
            // 
            // btnThem_LoaiPH
            // 
            this.btnThem_LoaiPH.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThem_LoaiPH.ImageOptions.SvgImage")));
            this.btnThem_LoaiPH.Location = new System.Drawing.Point(438, 248);
            this.btnThem_LoaiPH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThem_LoaiPH.Name = "btnThem_LoaiPH";
            this.btnThem_LoaiPH.Size = new System.Drawing.Size(107, 50);
            this.btnThem_LoaiPH.TabIndex = 3;
            this.btnThem_LoaiPH.Text = "Thêm";
            this.btnThem_LoaiPH.Click += new System.EventHandler(this.btnThem_LoaiPH_Click_1);
            // 
            // btn_capnhat_loai
            // 
            this.btn_capnhat_loai.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_capnhat_loai.ImageOptions.SvgImage")));
            this.btn_capnhat_loai.Location = new System.Drawing.Point(588, 248);
            this.btn_capnhat_loai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_capnhat_loai.Name = "btn_capnhat_loai";
            this.btn_capnhat_loai.Size = new System.Drawing.Size(107, 50);
            this.btn_capnhat_loai.TabIndex = 2;
            this.btn_capnhat_loai.Text = "Cập nhật";
            this.btn_capnhat_loai.Click += new System.EventHandler(this.btn_capnhat_loai_Click_1);
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSize = true;
            this.groupBox3.Controls.Add(this.dgv_ph);
            this.groupBox3.Controls.Add(this.btnLuu_PH);
            this.groupBox3.Controls.Add(this.labelControl8);
            this.groupBox3.Controls.Add(this.btn_capnhat_ph);
            this.groupBox3.Controls.Add(this.btnThem_PH);
            this.groupBox3.Controls.Add(this.cbo_maloai);
            this.groupBox3.Controls.Add(this.txt_tinhtrang);
            this.groupBox3.Controls.Add(this.labelControl5);
            this.groupBox3.Controls.Add(this.txt_maph);
            this.groupBox3.Controls.Add(this.txt_vitri);
            this.groupBox3.Controls.Add(this.labelControl7);
            this.groupBox3.Controls.Add(this.labelControl6);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(852, 717);
            this.groupBox3.TabIndex = 43;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin phòng";
            // 
            // btnLuu_PH
            // 
            this.btnLuu_PH.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu_PH.Appearance.Options.UseFont = true;
            this.btnLuu_PH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu_PH.ImageOptions.Image")));
            this.btnLuu_PH.Location = new System.Drawing.Point(722, 247);
            this.btnLuu_PH.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnLuu_PH.Name = "btnLuu_PH";
            this.btnLuu_PH.Size = new System.Drawing.Size(99, 49);
            this.btnLuu_PH.TabIndex = 43;
            this.btnLuu_PH.Text = "Lưu";
            this.btnLuu_PH.Click += new System.EventHandler(this.btnLuu_PH_Click_1);
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(92, 44);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(85, 22);
            this.labelControl8.TabIndex = 4;
            this.labelControl8.Text = "Mã Phòng:";
            // 
            // btn_capnhat_ph
            // 
            this.btn_capnhat_ph.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_capnhat_ph.ImageOptions.SvgImage")));
            this.btn_capnhat_ph.Location = new System.Drawing.Point(573, 246);
            this.btn_capnhat_ph.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_capnhat_ph.Name = "btn_capnhat_ph";
            this.btn_capnhat_ph.Size = new System.Drawing.Size(107, 50);
            this.btn_capnhat_ph.TabIndex = 2;
            this.btn_capnhat_ph.Text = "Cập nhật";
            this.btn_capnhat_ph.Click += new System.EventHandler(this.btn_capnhat_ph_Click_1);
            // 
            // btnThem_PH
            // 
            this.btnThem_PH.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThem_PH.ImageOptions.SvgImage")));
            this.btnThem_PH.Location = new System.Drawing.Point(426, 247);
            this.btnThem_PH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThem_PH.Name = "btnThem_PH";
            this.btnThem_PH.Size = new System.Drawing.Size(107, 50);
            this.btnThem_PH.TabIndex = 3;
            this.btnThem_PH.Text = "Thêm";
            this.btnThem_PH.Click += new System.EventHandler(this.btnThem_PH_Click_1);
            // 
            // cbo_maloai
            // 
            this.cbo_maloai.FormattingEnabled = true;
            this.cbo_maloai.Location = new System.Drawing.Point(219, 183);
            this.cbo_maloai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbo_maloai.Name = "cbo_maloai";
            this.cbo_maloai.Size = new System.Drawing.Size(534, 30);
            this.cbo_maloai.TabIndex = 11;
            // 
            // txt_tinhtrang
            // 
            this.txt_tinhtrang.Location = new System.Drawing.Point(219, 135);
            this.txt_tinhtrang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_tinhtrang.Name = "txt_tinhtrang";
            this.txt_tinhtrang.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txt_tinhtrang.Properties.Appearance.Options.UseFont = true;
            this.txt_tinhtrang.Size = new System.Drawing.Size(534, 28);
            this.txt_tinhtrang.TabIndex = 18;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(92, 191);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(62, 22);
            this.labelControl5.TabIndex = 7;
            this.labelControl5.Text = "Mã loại";
            // 
            // txt_maph
            // 
            this.txt_maph.Location = new System.Drawing.Point(219, 38);
            this.txt_maph.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_maph.Name = "txt_maph";
            this.txt_maph.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txt_maph.Properties.Appearance.Options.UseFont = true;
            this.txt_maph.Size = new System.Drawing.Size(534, 28);
            this.txt_maph.TabIndex = 16;
            // 
            // txt_vitri
            // 
            this.txt_vitri.Location = new System.Drawing.Point(219, 83);
            this.txt_vitri.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_vitri.Name = "txt_vitri";
            this.txt_vitri.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txt_vitri.Properties.Appearance.Options.UseFont = true;
            this.txt_vitri.Size = new System.Drawing.Size(534, 28);
            this.txt_vitri.TabIndex = 17;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(92, 91);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(42, 22);
            this.labelControl7.TabIndex = 5;
            this.labelControl7.Text = "Vị trí";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(92, 141);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(80, 22);
            this.labelControl6.TabIndex = 6;
            this.labelControl6.Text = "Tình trạng";
            // 
            // qL_KHACHSANDataSet
            // 
            this.qL_KHACHSANDataSet.DataSetName = "QL_KHACHSANDataSet";
            this.qL_KHACHSANDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pHONGBindingSource
            // 
            this.pHONGBindingSource.DataMember = "PHONG";
            this.pHONGBindingSource.DataSource = this.qL_KHACHSANDataSet;
            // 
            // pHONGTableAdapter
            // 
            this.pHONGTableAdapter.ClearBeforeFill = true;
            // 
            // DM_phong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "DM_phong";
            this.Size = new System.Drawing.Size(1743, 717);
            this.Load += new System.EventHandler(this.DM_phong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_loaiph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ph)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ghichu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_gia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tenloai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_maloai.Properties)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tinhtrang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_maph.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_vitri.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_KHACHSANDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHONGBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_loaiph;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridView dgv_ph;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton btnLuu_loaiph;
        private DevExpress.XtraEditors.TextEdit txt_ghichu;
        private DevExpress.XtraEditors.TextEdit txt_gia;
        private DevExpress.XtraEditors.TextEdit txt_tenloai;
        private DevExpress.XtraEditors.TextEdit txt_maloai;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnThem_LoaiPH;
        private DevExpress.XtraEditors.SimpleButton btn_capnhat_loai;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraEditors.SimpleButton btnLuu_PH;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.SimpleButton btn_capnhat_ph;
        private DevExpress.XtraEditors.SimpleButton btnThem_PH;
        private System.Windows.Forms.ComboBox cbo_maloai;
        private DevExpress.XtraEditors.TextEdit txt_tinhtrang;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txt_maph;
        private DevExpress.XtraEditors.TextEdit txt_vitri;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.BindingSource pHONGBindingSource;
        private QL_KHACHSANDataSet qL_KHACHSANDataSet;
        private QL_KHACHSANDataSetTableAdapters.PHONGTableAdapter pHONGTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn colum1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}
