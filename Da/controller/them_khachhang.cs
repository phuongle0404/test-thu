using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Da.controller
{
    public partial class them_khachhang : Form
    {
        public them_khachhang()
        {
            InitializeComponent();
        }
        connect conn = new connect();

        DataSet ds = new DataSet();
        SqlDataAdapter da;
        DataColumn[] key = new DataColumn[1];

        DM_khachhang dm_kh;

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void loadData_themkh()
        {
            da = new SqlDataAdapter(" select * from KHACHHANG", conn.cnn);
            da.Fill(ds, "KHACHHANG");
            data_khachhang.DataSource = ds.Tables["KHACHHANG"];
            key[0] = ds.Tables["KHACHHANG"].Columns[0];
            ds.Tables["KHACHHANG"].PrimaryKey = key;
        }

        int kiemtra_thongtin()
        {
            if (string.IsNullOrEmpty(txt_tenkh.Text))
            {
                MessageBox.Show("Chưa nhập tên khách hàng");
                txt_tenkh.Focus();
                return 0;
            }
            else if (string.IsNullOrEmpty(txt_cmnd.Text))
            {
                MessageBox.Show("Chưa nhập số chứng minh khách hàng");
                txt_tenkh.Focus();
                return 0;
            }
            else if (string.IsNullOrEmpty(txt_sdt.Text))
            {
                MessageBox.Show("Chưa nhập số điện thoại khách hàng");
                txt_tenkh.Focus();
                return 0;
            }
            else if (cbb_quoctich.SelectedIndex == 0)
            {
                MessageBox.Show("Chưa chọn quốc tịch khách hàng");
                return 0;
            }
            else
                return 1;
        }

        void them_thong_tin_kh()
        {
            int max = 0;
            for (int i = 0; i < data_khachhang.Rows.Count - 1; i++)
            {
                int stt = int.Parse(data_khachhang.Rows[i].Cells[0].Value.ToString().Substring(2));
                if (max < stt)
                {
                    max = stt;
                }
            }
            string makh;
            // tự động tạo mã khách hàng
            if (max < 100)
                makh = "KH0" + (max + 1).ToString();
            else
                makh = "KH" + (max + 1).ToString();
            try
            {
                loadData_themkh();

                DataRow insert_New = ds.Tables["KHACHHANG"].NewRow();
                insert_New["MAKH"] = makh;
                insert_New["HOTEN"] = txt_tenkh.Text;
                insert_New["SOCMND"] = txt_cmnd.Text;
                insert_New["SDT"] = txt_sdt.Text;
                insert_New["QUOCTICH"] = cbb_quoctich.Text;
                ds.Tables["KHACHHANG"].Rows.Add(insert_New);
                SqlCommandBuilder cmb = new SqlCommandBuilder(da);
                da.Update(ds, "KHACHHANG");
                MessageBox.Show(" Thêm Thành công");
                loadData_themkh();
            }
            catch
            {
                MessageBox.Show("Hãy thao tác lại");
            }
        }

        private void btn_luuvathem_Click(object sender, EventArgs e)
        {
            int kq = kiemtra_thongtin();
            if (kq == 1)
            {
                them_thong_tin_kh();
                txt_tenkh.Clear();
                txt_sdt.Clear();
                txt_cmnd.Clear();
                cbb_quoctich.SelectedIndex = 0;
                txt_tenkh.Focus();
            }
        }

        private void btn_luuvadong_Click(object sender, EventArgs e)
        {
            int kq = kiemtra_thongtin();
            if (kq == 1)
            {
                them_thong_tin_kh();
                this.Close();
            }
        }

        private void txt_cmnd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void them_khachhang_Load(object sender, EventArgs e)
        {
            cbb_quoctich.SelectedIndex = 0;
            loadData_themkh();
        }

        private void them_khachhang_FormClosing(object sender, FormClosingEventArgs e)
        {
            dm_kh = new DM_khachhang();
            dm_kh.btn_lammoi_Click(sender, e);
        }
    }
}
