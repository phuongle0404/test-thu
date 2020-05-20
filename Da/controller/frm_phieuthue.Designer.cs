namespace Da.controller
{
    partial class frm_phieuthue
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxmakh = new System.Windows.Forms.ComboBox();
            this.dateEditngaynhan = new DevExpress.XtraEditors.DateEdit();
            this.dateEditngaytra = new DevExpress.XtraEditors.DateEdit();
            this.textBoxsl = new System.Windows.Forms.TextBox();
            this.textBoxtiencoc = new System.Windows.Forms.TextBox();
            this.textBoxmanhanvien = new System.Windows.Forms.TextBox();
            this.textBoxmathuephong = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.MATP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAPH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel_ph = new System.Windows.Forms.Panel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button_xoaphong = new System.Windows.Forms.Button();
            this.button_lapphieu = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditngaynhan.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditngaynhan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditngaytra.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditngaytra.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_xoaphong);
            this.groupBox1.Controls.Add(this.button_lapphieu);
            this.groupBox1.Controls.Add(this.comboBoxmakh);
            this.groupBox1.Controls.Add(this.dateEditngaynhan);
            this.groupBox1.Controls.Add(this.dateEditngaytra);
            this.groupBox1.Controls.Add(this.textBoxsl);
            this.groupBox1.Controls.Add(this.textBoxtiencoc);
            this.groupBox1.Controls.Add(this.textBoxmanhanvien);
            this.groupBox1.Controls.Add(this.textBoxmathuephong);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1632, 214);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phiếu thuê";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // comboBoxmakh
            // 
            this.comboBoxmakh.FormattingEnabled = true;
            this.comboBoxmakh.Location = new System.Drawing.Point(177, 127);
            this.comboBoxmakh.Name = "comboBoxmakh";
            this.comboBoxmakh.Size = new System.Drawing.Size(483, 33);
            this.comboBoxmakh.TabIndex = 23;
            // 
            // dateEditngaynhan
            // 
            this.dateEditngaynhan.EditValue = null;
            this.dateEditngaynhan.Location = new System.Drawing.Point(834, 33);
            this.dateEditngaynhan.Name = "dateEditngaynhan";
            this.dateEditngaynhan.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.dateEditngaynhan.Properties.Appearance.Options.UseFont = true;
            this.dateEditngaynhan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditngaynhan.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditngaynhan.Size = new System.Drawing.Size(426, 32);
            this.dateEditngaynhan.TabIndex = 22;
            this.dateEditngaynhan.EditValueChanged += new System.EventHandler(this.dateEditngaynhan_EditValueChanged);
            // 
            // dateEditngaytra
            // 
            this.dateEditngaytra.EditValue = null;
            this.dateEditngaytra.Location = new System.Drawing.Point(834, 81);
            this.dateEditngaytra.Name = "dateEditngaytra";
            this.dateEditngaytra.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.dateEditngaytra.Properties.Appearance.Options.UseFont = true;
            this.dateEditngaytra.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditngaytra.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditngaytra.Size = new System.Drawing.Size(426, 32);
            this.dateEditngaytra.TabIndex = 21;
            this.dateEditngaytra.EditValueChanged += new System.EventHandler(this.dateEditngaynhan_EditValueChanged);
            // 
            // textBoxsl
            // 
            this.textBoxsl.Enabled = false;
            this.textBoxsl.Location = new System.Drawing.Point(1365, 33);
            this.textBoxsl.Name = "textBoxsl";
            this.textBoxsl.Size = new System.Drawing.Size(246, 34);
            this.textBoxsl.TabIndex = 19;
            // 
            // textBoxtiencoc
            // 
            this.textBoxtiencoc.Location = new System.Drawing.Point(834, 127);
            this.textBoxtiencoc.Name = "textBoxtiencoc";
            this.textBoxtiencoc.Size = new System.Drawing.Size(426, 34);
            this.textBoxtiencoc.TabIndex = 18;
            // 
            // textBoxmanhanvien
            // 
            this.textBoxmanhanvien.Enabled = false;
            this.textBoxmanhanvien.Location = new System.Drawing.Point(177, 78);
            this.textBoxmanhanvien.Name = "textBoxmanhanvien";
            this.textBoxmanhanvien.Size = new System.Drawing.Size(483, 34);
            this.textBoxmanhanvien.TabIndex = 17;
            // 
            // textBoxmathuephong
            // 
            this.textBoxmathuephong.Enabled = false;
            this.textBoxmathuephong.Location = new System.Drawing.Point(177, 33);
            this.textBoxmathuephong.Name = "textBoxmathuephong";
            this.textBoxmathuephong.Size = new System.Drawing.Size(483, 34);
            this.textBoxmathuephong.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label7.Location = new System.Drawing.Point(1275, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 22);
            this.label7.TabIndex = 15;
            this.label7.Text = "Số lượng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label6.Location = new System.Drawing.Point(684, 133);
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
            this.label4.Size = new System.Drawing.Size(144, 22);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ngày nhận phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label3.Location = new System.Drawing.Point(33, 133);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(3, 223);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(518, 540);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết phiếu thuê";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MATP,
            this.MAPH});
            this.dataGridView2.Location = new System.Drawing.Point(6, 33);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(506, 501);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridView2_CellPainting);
            // 
            // MATP
            // 
            this.MATP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MATP.DataPropertyName = "MATP";
            this.MATP.FillWeight = 200F;
            this.MATP.HeaderText = "Mã thuê phòng";
            this.MATP.Name = "MATP";
            // 
            // MAPH
            // 
            this.MAPH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MAPH.DataPropertyName = "MAPH";
            this.MAPH.FillWeight = 200F;
            this.MAPH.HeaderText = "Mã phòng";
            this.MAPH.Name = "MAPH";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panel_ph);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(527, 223);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1111, 540);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách phòng";
            // 
            // panel_ph
            // 
            this.panel_ph.BackColor = System.Drawing.Color.White;
            this.panel_ph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_ph.Location = new System.Drawing.Point(3, 30);
            this.panel_ph.Name = "panel_ph";
            this.panel_ph.Size = new System.Drawing.Size(1105, 507);
            this.panel_ph.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button_xoaphong
            // 
            this.button_xoaphong.Image = global::Da.Properties.Resources.stop2;
            this.button_xoaphong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_xoaphong.Location = new System.Drawing.Point(1364, 152);
            this.button_xoaphong.Name = "button_xoaphong";
            this.button_xoaphong.Size = new System.Drawing.Size(181, 56);
            this.button_xoaphong.TabIndex = 26;
            this.button_xoaphong.Text = "Xóa phòng";
            this.button_xoaphong.UseVisualStyleBackColor = true;
            this.button_xoaphong.Click += new System.EventHandler(this.button_xoaphong_Click);
            // 
            // button_lapphieu
            // 
            this.button_lapphieu.Image = global::Da.Properties.Resources.filequickprint;
            this.button_lapphieu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_lapphieu.Location = new System.Drawing.Point(1365, 78);
            this.button_lapphieu.Name = "button_lapphieu";
            this.button_lapphieu.Size = new System.Drawing.Size(180, 56);
            this.button_lapphieu.TabIndex = 25;
            this.button_lapphieu.Text = "Lập phiếu";
            this.button_lapphieu.UseVisualStyleBackColor = true;
            this.button_lapphieu.Click += new System.EventHandler(this.button_lapphieu_Click);
            // 
            // frm_phieuthue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_phieuthue";
            this.Size = new System.Drawing.Size(1641, 775);
            this.Load += new System.EventHandler(this.frm_phieuthue_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditngaynhan.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditngaynhan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditngaytra.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditngaytra.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxsl;
        private System.Windows.Forms.TextBox textBoxtiencoc;
        private System.Windows.Forms.TextBox textBoxmanhanvien;
        private System.Windows.Forms.TextBox textBoxmathuephong;
        private DevExpress.XtraEditors.DateEdit dateEditngaynhan;
        private DevExpress.XtraEditors.DateEdit dateEditngaytra;
        private System.Windows.Forms.ComboBox comboBoxmakh;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MATP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAPH;
        private System.Windows.Forms.Panel panel_ph;
        private System.Windows.Forms.Button button_xoaphong;
        private System.Windows.Forms.Button button_lapphieu;
        private System.Windows.Forms.Timer timer1;
    }
}
