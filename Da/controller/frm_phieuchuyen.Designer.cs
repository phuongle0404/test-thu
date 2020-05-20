namespace Da.controller
{
    partial class frm_phieuchuyen
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
            this.groupBoxCHUYEN = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxmkh = new System.Windows.Forms.TextBox();
            this.button_lapphieu = new System.Windows.Forms.Button();
            this.comboBox_madatphong = new System.Windows.Forms.ComboBox();
            this.dateEditngaychuyen = new DevExpress.XtraEditors.DateEdit();
            this.dateEditngaytra = new DevExpress.XtraEditors.DateEdit();
            this.textBoxsl = new System.Windows.Forms.TextBox();
            this.textBox_tiencoc = new System.Windows.Forms.TextBox();
            this.textBox_MANV = new System.Windows.Forms.TextBox();
            this.textBox_MATP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView_thongtinchitietchuyen = new System.Windows.Forms.DataGridView();
            this.MADP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYTRA_DUKIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SL_PHONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TINHTRANG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.excelDataSource1 = new DevExpress.DataAccess.Excel.ExcelDataSource();
            this.groupBoxCHUYEN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditngaychuyen.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditngaychuyen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditngaytra.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditngaytra.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_thongtinchitietchuyen)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCHUYEN
            // 
            this.groupBoxCHUYEN.BackColor = System.Drawing.Color.White;
            this.groupBoxCHUYEN.Controls.Add(this.button1);
            this.groupBoxCHUYEN.Controls.Add(this.label8);
            this.groupBoxCHUYEN.Controls.Add(this.textBoxmkh);
            this.groupBoxCHUYEN.Controls.Add(this.button_lapphieu);
            this.groupBoxCHUYEN.Controls.Add(this.comboBox_madatphong);
            this.groupBoxCHUYEN.Controls.Add(this.dateEditngaychuyen);
            this.groupBoxCHUYEN.Controls.Add(this.dateEditngaytra);
            this.groupBoxCHUYEN.Controls.Add(this.textBoxsl);
            this.groupBoxCHUYEN.Controls.Add(this.textBox_tiencoc);
            this.groupBoxCHUYEN.Controls.Add(this.textBox_MANV);
            this.groupBoxCHUYEN.Controls.Add(this.textBox_MATP);
            this.groupBoxCHUYEN.Controls.Add(this.label7);
            this.groupBoxCHUYEN.Controls.Add(this.label6);
            this.groupBoxCHUYEN.Controls.Add(this.label5);
            this.groupBoxCHUYEN.Controls.Add(this.label4);
            this.groupBoxCHUYEN.Controls.Add(this.label3);
            this.groupBoxCHUYEN.Controls.Add(this.label2);
            this.groupBoxCHUYEN.Controls.Add(this.label1);
            this.groupBoxCHUYEN.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.groupBoxCHUYEN.Location = new System.Drawing.Point(0, 3);
            this.groupBoxCHUYEN.Name = "groupBoxCHUYEN";
            this.groupBoxCHUYEN.Size = new System.Drawing.Size(1632, 214);
            this.groupBoxCHUYEN.TabIndex = 1;
            this.groupBoxCHUYEN.TabStop = false;
            this.groupBoxCHUYEN.Text = "Thông tin phiếu chuyển";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.Location = new System.Drawing.Point(1263, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 79);
            this.button1.TabIndex = 28;
            this.button1.Text = "Lọc phiếu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label8.Location = new System.Drawing.Point(31, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 22);
            this.label8.TabIndex = 27;
            this.label8.Text = "Mã đặt phòng";
            // 
            // textBoxmkh
            // 
            this.textBoxmkh.Enabled = false;
            this.textBoxmkh.Location = new System.Drawing.Point(843, 123);
            this.textBoxmkh.Name = "textBoxmkh";
            this.textBoxmkh.Size = new System.Drawing.Size(396, 34);
            this.textBoxmkh.TabIndex = 26;
            // 
            // button_lapphieu
            // 
            this.button_lapphieu.BackColor = System.Drawing.Color.DarkGray;
            this.button_lapphieu.Image = global::Da.Properties.Resources.printer;
            this.button_lapphieu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_lapphieu.Location = new System.Drawing.Point(1442, 123);
            this.button_lapphieu.Name = "button_lapphieu";
            this.button_lapphieu.Size = new System.Drawing.Size(179, 79);
            this.button_lapphieu.TabIndex = 25;
            this.button_lapphieu.Text = "Lập phiếu";
            this.button_lapphieu.UseVisualStyleBackColor = false;
            this.button_lapphieu.Click += new System.EventHandler(this.button_lapphieu_Click);
            // 
            // comboBox_madatphong
            // 
            this.comboBox_madatphong.FormattingEnabled = true;
            this.comboBox_madatphong.Location = new System.Drawing.Point(177, 123);
            this.comboBox_madatphong.Name = "comboBox_madatphong";
            this.comboBox_madatphong.Size = new System.Drawing.Size(483, 33);
            this.comboBox_madatphong.TabIndex = 23;
            this.comboBox_madatphong.SelectedIndexChanged += new System.EventHandler(this.comboBox_madatphong_SelectedIndexChanged);
            this.comboBox_madatphong.SelectedValueChanged += new System.EventHandler(this.comboBox_madatphong_SelectedValueChanged);
            // 
            // dateEditngaychuyen
            // 
            this.dateEditngaychuyen.EditValue = null;
            this.dateEditngaychuyen.Location = new System.Drawing.Point(843, 33);
            this.dateEditngaychuyen.Name = "dateEditngaychuyen";
            this.dateEditngaychuyen.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.dateEditngaychuyen.Properties.Appearance.Options.UseFont = true;
            this.dateEditngaychuyen.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditngaychuyen.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditngaychuyen.Size = new System.Drawing.Size(396, 32);
            this.dateEditngaychuyen.TabIndex = 22;
            // 
            // dateEditngaytra
            // 
            this.dateEditngaytra.EditValue = null;
            this.dateEditngaytra.Location = new System.Drawing.Point(843, 81);
            this.dateEditngaytra.Name = "dateEditngaytra";
            this.dateEditngaytra.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.dateEditngaytra.Properties.Appearance.Options.UseFont = true;
            this.dateEditngaytra.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditngaytra.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditngaytra.Size = new System.Drawing.Size(396, 32);
            this.dateEditngaytra.TabIndex = 21;
            // 
            // textBoxsl
            // 
            this.textBoxsl.Enabled = false;
            this.textBoxsl.Location = new System.Drawing.Point(1391, 31);
            this.textBoxsl.Name = "textBoxsl";
            this.textBoxsl.Size = new System.Drawing.Size(230, 34);
            this.textBoxsl.TabIndex = 19;
            // 
            // textBox_tiencoc
            // 
            this.textBox_tiencoc.Enabled = false;
            this.textBox_tiencoc.Location = new System.Drawing.Point(1391, 78);
            this.textBox_tiencoc.Name = "textBox_tiencoc";
            this.textBox_tiencoc.Size = new System.Drawing.Size(230, 34);
            this.textBox_tiencoc.TabIndex = 18;
            // 
            // textBox_MANV
            // 
            this.textBox_MANV.Enabled = false;
            this.textBox_MANV.Location = new System.Drawing.Point(177, 78);
            this.textBox_MANV.Name = "textBox_MANV";
            this.textBox_MANV.Size = new System.Drawing.Size(483, 34);
            this.textBox_MANV.TabIndex = 17;
            // 
            // textBox_MATP
            // 
            this.textBox_MATP.Enabled = false;
            this.textBox_MATP.Location = new System.Drawing.Point(177, 33);
            this.textBox_MATP.Name = "textBox_MATP";
            this.textBox_MATP.Size = new System.Drawing.Size(483, 34);
            this.textBox_MATP.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label7.Location = new System.Drawing.Point(1259, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 22);
            this.label7.TabIndex = 15;
            this.label7.Text = "Số lượng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label6.Location = new System.Drawing.Point(1259, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 22);
            this.label6.TabIndex = 14;
            this.label6.Text = "Tiền cọc trước";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label5.Location = new System.Drawing.Point(684, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 22);
            this.label5.TabIndex = 13;
            this.label5.Text = "Ngày trả phòng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label4.Location = new System.Drawing.Point(684, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 22);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ngày chuyển phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label3.Location = new System.Drawing.Point(686, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 22);
            this.label3.TabIndex = 11;
            this.label3.Text = "Mã khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label2.Location = new System.Drawing.Point(33, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mã nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label1.Location = new System.Drawing.Point(33, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mã thuê phòng";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.dataGridView_thongtinchitietchuyen);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(4, 223);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1632, 549);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phiếu chuyển";
            // 
            // dataGridView_thongtinchitietchuyen
            // 
            this.dataGridView_thongtinchitietchuyen.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_thongtinchitietchuyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_thongtinchitietchuyen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MADP,
            this.Column1,
            this.Column2,
            this.Column3,
            this.NGAYTRA_DUKIEN,
            this.SL_PHONG,
            this.TINHTRANG});
            this.dataGridView_thongtinchitietchuyen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_thongtinchitietchuyen.Location = new System.Drawing.Point(3, 30);
            this.dataGridView_thongtinchitietchuyen.Name = "dataGridView_thongtinchitietchuyen";
            this.dataGridView_thongtinchitietchuyen.RowTemplate.Height = 24;
            this.dataGridView_thongtinchitietchuyen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_thongtinchitietchuyen.Size = new System.Drawing.Size(1626, 516);
            this.dataGridView_thongtinchitietchuyen.TabIndex = 0;
            this.dataGridView_thongtinchitietchuyen.SelectionChanged += new System.EventHandler(this.dataGridView_thongtinchitietchuyen_SelectionChanged);
            // 
            // MADP
            // 
            this.MADP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MADP.DataPropertyName = "MADP";
            this.MADP.HeaderText = "Mã đặt phòng";
            this.MADP.Name = "MADP";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MANV";
            this.Column1.HeaderText = "Mã Nhân Viên";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "MAKH";
            this.Column2.HeaderText = "Mã Khách Hàng";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "NGAYNHAN_DUKIEN";
            this.Column3.HeaderText = "Ngày Nhận";
            this.Column3.Name = "Column3";
            this.Column3.Visible = false;
            // 
            // NGAYTRA_DUKIEN
            // 
            this.NGAYTRA_DUKIEN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NGAYTRA_DUKIEN.DataPropertyName = "NGAYTRA_DUKIEN";
            this.NGAYTRA_DUKIEN.HeaderText = "Ngày trả phòng";
            this.NGAYTRA_DUKIEN.Name = "NGAYTRA_DUKIEN";
            // 
            // SL_PHONG
            // 
            this.SL_PHONG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SL_PHONG.DataPropertyName = "SL_PHONG";
            this.SL_PHONG.HeaderText = "Số lượng phòng";
            this.SL_PHONG.Name = "SL_PHONG";
            // 
            // TINHTRANG
            // 
            this.TINHTRANG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TINHTRANG.DataPropertyName = "TINHTRANG";
            this.TINHTRANG.HeaderText = "Tiền cọc trước";
            this.TINHTRANG.Name = "TINHTRANG";
            // 
            // excelDataSource1
            // 
            this.excelDataSource1.Name = "excelDataSource1";
            // 
            // frm_phieuchuyen
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxCHUYEN);
            this.Name = "frm_phieuchuyen";
            this.Size = new System.Drawing.Size(1641, 775);
            this.Load += new System.EventHandler(this.frm_phieuchuyen_Load);
            this.groupBoxCHUYEN.ResumeLayout(false);
            this.groupBoxCHUYEN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditngaychuyen.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditngaychuyen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditngaytra.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditngaytra.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_thongtinchitietchuyen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCHUYEN;
        private System.Windows.Forms.Button button_lapphieu;
        private System.Windows.Forms.ComboBox comboBox_madatphong;
        private DevExpress.XtraEditors.DateEdit dateEditngaychuyen;
        private DevExpress.XtraEditors.DateEdit dateEditngaytra;
        private System.Windows.Forms.TextBox textBoxsl;
        private System.Windows.Forms.TextBox textBox_tiencoc;
        private System.Windows.Forms.TextBox textBox_MANV;
        private System.Windows.Forms.TextBox textBox_MATP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView_thongtinchitietchuyen;
        private DevExpress.DataAccess.Excel.ExcelDataSource excelDataSource1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxmkh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MADP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYTRA_DUKIEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL_PHONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn TINHTRANG;
        private System.Windows.Forms.Button button1;
    }
}
