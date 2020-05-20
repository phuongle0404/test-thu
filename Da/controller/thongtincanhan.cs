using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Da.controller
{
    public partial class thongtincanhan : UserControl
    {
        public thongtincanhan()
        {
            InitializeComponent();
        }
        connect conn = new connect();

        DataSet ds = new DataSet();
        SqlDataAdapter da;
        string tk = Properties.Settings.Default.MaNV;

        public Image Base64ToImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            using (var ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
            {
                Image image = Image.FromStream(ms, true);
                return image;
            }
        }

        public void loadNhanVien()
        {
            DataSet ds = new DataSet();
            da = new SqlDataAdapter(" select * from NHANVIEN", conn.cnn);
            da.Fill(ds, "NHANVIEN");
        }

        private void thongtincanhan_Load(object sender, EventArgs e)
        {

            DataSet ds = new DataSet();
            da = new SqlDataAdapter("select * from NHANVIEN where MANV = '" + tk + "'", conn.cnn);
            da.Fill(ds, "NHANVIEN");

            lb_manv.Text += tk;
            lb_tennv.Text += ds.Tables["NHANVIEN"].Rows[0]["HOTEN"].ToString();
            lb_cmnd.Text += ds.Tables["NHANVIEN"].Rows[0]["SOCMND"].ToString();
            lb_sdt.Text += ds.Tables["NHANVIEN"].Rows[0]["SDT"].ToString();
            lb_diachi.Text += ds.Tables["NHANVIEN"].Rows[0]["DIACHI"].ToString();
            lb_gioitinh.Text += ds.Tables["NHANVIEN"].Rows[0]["GIOITINH"].ToString();
            lb_email.Text += ds.Tables["NHANVIEN"].Rows[0]["EMAIL"].ToString();
            lb_ngayvaolam.Text += ds.Tables["NHANVIEN"].Rows[0]["NGAYVAOLAM"].ToString();

            pictureBox_avatar.Image = Base64ToImage(ds.Tables["NHANVIEN"].Rows[0]["HINHANH"].ToString());
        }

        private void btn_doimatkhau_Click(object sender, EventArgs e)
        {
            doimatkhau2 _doimatkhau2 = new doimatkhau2();
            _doimatkhau2.ShowDialog();
        }
    }
}
