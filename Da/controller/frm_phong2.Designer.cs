namespace Da.controller
{
    partial class frm_phong2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_phong2));
            this.labelmaphong = new System.Windows.Forms.Label();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelmaphong
            // 
            this.labelmaphong.AutoSize = true;
            this.labelmaphong.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmaphong.Location = new System.Drawing.Point(28, 113);
            this.labelmaphong.Name = "labelmaphong";
            this.labelmaphong.Size = new System.Drawing.Size(80, 36);
            this.labelmaphong.TabIndex = 4;
            this.labelmaphong.Text = "P101";
            this.labelmaphong.Click += new System.EventHandler(this.labelmaphong_Click);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(21, 28);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(101, 82);
            this.pictureEdit1.TabIndex = 3;
            this.pictureEdit1.Click += new System.EventHandler(this.labelmaphong_Click);
            // 
            // frm_phong2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelmaphong);
            this.Controls.Add(this.pictureEdit1);
            this.Name = "frm_phong2";
            this.Size = new System.Drawing.Size(140, 151);
            this.Click += new System.EventHandler(this.labelmaphong_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelmaphong;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
    }
}
