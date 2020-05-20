namespace Da.controller
{
    partial class them_khachhang
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(them_khachhang));
            this.txt_tenkh = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cbb_quoctich = new System.Windows.Forms.ComboBox();
            this.txt_cmnd = new System.Windows.Forms.TextBox();
            this.btn_thoat = new DevExpress.XtraEditors.SimpleButton();
            this.btn_luuvadong = new DevExpress.XtraEditors.SimpleButton();
            this.btn_luuvathem = new DevExpress.XtraEditors.SimpleButton();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.data_khachhang = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.data_khachhang)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_tenkh
            // 
            this.txt_tenkh.Location = new System.Drawing.Point(229, 83);
            this.txt_tenkh.Name = "txt_tenkh";
            this.txt_tenkh.Size = new System.Drawing.Size(333, 27);
            this.txt_tenkh.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Quốc tịch:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Số điện thoại:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Căn cước/CMND:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Họ và tên khách hàng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 38);
            this.label1.TabIndex = 15;
            this.label1.Text = "Thêm thông tin khách hàng";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // cbb_quoctich
            // 
            this.cbb_quoctich.FormattingEnabled = true;
            this.cbb_quoctich.Items.AddRange(new object[] {
            "",
            "Việt Nam",
            "Trung Quốc",
            "Hồng Kông",
            "Lào",
            "Thái Lan",
            "Campuchia"});
            this.cbb_quoctich.Location = new System.Drawing.Point(229, 236);
            this.cbb_quoctich.Name = "cbb_quoctich";
            this.cbb_quoctich.Size = new System.Drawing.Size(333, 28);
            this.cbb_quoctich.TabIndex = 23;
            // 
            // txt_cmnd
            // 
            this.txt_cmnd.Location = new System.Drawing.Point(229, 133);
            this.txt_cmnd.Name = "txt_cmnd";
            this.txt_cmnd.Size = new System.Drawing.Size(333, 27);
            this.txt_cmnd.TabIndex = 21;
            this.txt_cmnd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cmnd_KeyPress);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.Appearance.Options.UseFont = true;
            this.btn_thoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_thoat.ImageOptions.Image")));
            this.btn_thoat.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btn_thoat.Location = new System.Drawing.Point(418, 303);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(144, 62);
            this.btn_thoat.TabIndex = 26;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_luuvadong
            // 
            this.btn_luuvadong.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_luuvadong.Appearance.Options.UseFont = true;
            this.btn_luuvadong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_luuvadong.ImageOptions.Image")));
            this.btn_luuvadong.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btn_luuvadong.Location = new System.Drawing.Point(229, 303);
            this.btn_luuvadong.Name = "btn_luuvadong";
            this.btn_luuvadong.Size = new System.Drawing.Size(144, 62);
            this.btn_luuvadong.TabIndex = 25;
            this.btn_luuvadong.Text = "Lưu và đóng";
            this.btn_luuvadong.Click += new System.EventHandler(this.btn_luuvadong_Click);
            // 
            // btn_luuvathem
            // 
            this.btn_luuvathem.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_luuvathem.Appearance.Options.UseFont = true;
            this.btn_luuvathem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_luuvathem.ImageOptions.Image")));
            this.btn_luuvathem.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btn_luuvathem.Location = new System.Drawing.Point(40, 303);
            this.btn_luuvathem.Name = "btn_luuvathem";
            this.btn_luuvathem.Size = new System.Drawing.Size(144, 62);
            this.btn_luuvathem.TabIndex = 24;
            this.btn_luuvathem.Text = "Lưu và thêm";
            this.btn_luuvathem.Click += new System.EventHandler(this.btn_luuvathem_Click);
            // 
            // txt_sdt
            // 
            this.txt_sdt.Location = new System.Drawing.Point(229, 183);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(333, 27);
            this.txt_sdt.TabIndex = 27;
            this.txt_sdt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cmnd_KeyPress);
            // 
            // data_khachhang
            // 
            this.data_khachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_khachhang.Location = new System.Drawing.Point(412, 12);
            this.data_khachhang.Name = "data_khachhang";
            this.data_khachhang.RowHeadersWidth = 51;
            this.data_khachhang.RowTemplate.Height = 24;
            this.data_khachhang.Size = new System.Drawing.Size(150, 62);
            this.data_khachhang.TabIndex = 28;
            this.data_khachhang.Visible = false;
            // 
            // them_khachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 393);
            this.Controls.Add(this.data_khachhang);
            this.Controls.Add(this.txt_sdt);
            this.Controls.Add(this.txt_tenkh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_luuvadong);
            this.Controls.Add(this.btn_luuvathem);
            this.Controls.Add(this.cbb_quoctich);
            this.Controls.Add(this.txt_cmnd);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "them_khachhang";
            this.Text = "them_khachhang";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.them_khachhang_FormClosing);
            this.Load += new System.EventHandler(this.them_khachhang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_khachhang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_tenkh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private DevExpress.XtraEditors.SimpleButton btn_thoat;
        private DevExpress.XtraEditors.SimpleButton btn_luuvadong;
        private DevExpress.XtraEditors.SimpleButton btn_luuvathem;
        private System.Windows.Forms.ComboBox cbb_quoctich;
        private System.Windows.Forms.TextBox txt_cmnd;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.DataGridView data_khachhang;
    }
}