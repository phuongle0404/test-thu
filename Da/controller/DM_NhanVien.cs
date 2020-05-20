using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace Da.controller
{
    public partial class DM_NhanVien : DevExpress.XtraEditors.XtraUserControl
    {

        connect conn = new connect();

        DataSet ds;

        SqlDataAdapter da;
        DataColumn[] key = new DataColumn[1];
        public DM_NhanVien()
        {
            InitializeComponent();
        }

        public void loadNhanVien()
        {
            DataSet ds = new DataSet();
            da = new SqlDataAdapter(" select * from NHANVIEN", conn.cnn);
            da.Fill(ds, "NHANVIEN");
            datadanhsachnhanvien.DataSource = ds.Tables["NHANVIEN"];
            key[0] = ds.Tables["NHANVIEN"].Columns[0];
            ds.Tables["NHANVIEN"].PrimaryKey = key;

        }
        public void loadNV()
        {
            da = new SqlDataAdapter(" select * from NHANVIEN", conn.cnn);
            ds = new DataSet();
            da.Fill(ds, "NHANVIEN");

            key[0] = ds.Tables["NHANVIEN"].Columns[0];
            ds.Tables["NHANVIEN"].PrimaryKey = key;
        }
        public void loadTKNhanVien()
        {
            ds = new DataSet();
            da = new SqlDataAdapter(" select * from TAIKHOAN ", conn.cnn);
            da.Fill(ds, "TAIKHOAN");
            datatk.DataSource = ds.Tables["TAIKHOAN"];
            key[0] = ds.Tables["TAIKHOAN"].Columns[0];
            ds.Tables["TAIKHOAN"].PrimaryKey = key;

        }

        public void loadTK()
        {
            ds = new DataSet();
            da = new SqlDataAdapter(" select * from TAIKHOAN ", conn.cnn);
            da.Fill(ds, "TAIKHOAN");
            //datatk.DataSource = ds.Tables["TAIKHOAN"];
            key[0] = ds.Tables["TAIKHOAN"].Columns[0];
            ds.Tables["TAIKHOAN"].PrimaryKey = key;

        }

        void clear_row()
        {
            for (int i = 0; i < datatk.Rows.Count - 1; i++)
            {
                datatk.Rows[i].Selected = false;
            }
        }

        private void datadanhsachnhanvien_SelectionChanged(object sender, EventArgs e)
        {
            txtma.Text = datadanhsachnhanvien.CurrentRow.Cells[0].Value.ToString();
            txthoten.Text = datadanhsachnhanvien.CurrentRow.Cells[1].Value.ToString();
            txtcmnd.Text = datadanhsachnhanvien.CurrentRow.Cells[2].Value.ToString();
            txtdiachi.Text = datadanhsachnhanvien.CurrentRow.Cells[4].Value.ToString();
            txtsdt.Text = datadanhsachnhanvien.CurrentRow.Cells[3].Value.ToString();
            txtemail.Text = datadanhsachnhanvien.CurrentRow.Cells[7].Value.ToString();
            if (datadanhsachnhanvien.CurrentRow.Cells[6].Value.ToString() == "Nam")
                rdb_nam.Checked = true;
            else
                rdb_nu.Checked = true;
            dateEditngayvaolam.Text = datadanhsachnhanvien.CurrentRow.Cells[5].Value.ToString();

            clear_row();

            for (int i = 0; i < datatk.Rows.Count - 1; i++)
            {
                if (datadanhsachnhanvien.CurrentRow.Cells[0].Value.ToString() == datatk.Rows[i].Cells[1].Value.ToString())
                    datatk.Rows[i].Selected = true;
            }           
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_Xoa.PerformClick();
        }

        public void xoatk()
        {
            loadTK();
            DataRow dr_xoa = ds.Tables["TAIKHOAN"].Rows.Find(txtma.Text);

            if (dr_xoa != null)
            {
                dr_xoa.Delete();
                SqlCommandBuilder db = new SqlCommandBuilder(da);
                da.Update(ds, "TAIKHOAN");
            }
        }

        private void sửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_Sua.PerformClick();
        }

        private void txtcmnd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            //btn_lammoi_Click(sender, e);
            //txtcmnd.Text = txtdiachi.Text = txthoten.Text = txtma.Text = txtsdt.Text = null;
            //txthoten.Focus();
            them_nhanvien _them_nhanvien = new them_nhanvien();
            _them_nhanvien.Show();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            ds = new DataSet();
            try
            {
                DialogResult r;
                r = MessageBox.Show("Bạn có chắc muốn xóa không?", "Thông báo xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (r == DialogResult.Yes)
                {
                    xoatk();
                    loadNV();
                    DataRow dr_xoa = ds.Tables["NHANVIEN"].Rows.Find(txtma.Text);

                    if (dr_xoa != null)
                    {

                        dr_xoa.Delete();
                        SqlCommandBuilder db = new SqlCommandBuilder(da);
                        da.Update(ds, "NHANVIEN");

                        ds.Tables["NHANVIEN"].Clear();
                        loadNhanVien();
                        MessageBox.Show("Xóa thành công !");
                        loadTK();
                        ds.Tables["TAIKHOAN"].Clear();
                        loadTKNhanVien();
                        txtma.Clear();
                        txthoten.Clear();
                        txtcmnd.Clear();
                        txtdiachi.Clear();
                        txtsdt.Clear();
                        dateEditngayvaolam.Text = "";

                        btn_Sua.Enabled = btn_Xoa.Enabled = false;

                    }
                    else
                        MessageBox.Show("Vui lòng chọn mã  nhân viên ");
                }
            }
            catch
            {
                MessageBox.Show("Hãy thao tác lại ");
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            ds = new DataSet();
            try
            {
                loadNV();
                DataRow update_New = ds.Tables["NHANVIEN"].Rows.Find(txtma.Text);
                if (update_New != null)
                {
                    update_New["MANV"] = txtma.Text;
                    update_New["HOTEN"] = txthoten.Text;
                    update_New["SOCMND"] = txtcmnd.Text;
                    update_New["SDT"] = txtsdt.Text;
                    update_New["DIACHI"] = txtdiachi.Text;
                    update_New["NGAYVAOLAM"] = dateEditngayvaolam.Text;
                    SqlCommandBuilder cmb = new SqlCommandBuilder(da);
                    da.Update(ds, "NHANVIEN");
                    MessageBox.Show(" Cập nhật thành công");
                    loadNhanVien();

                    btn_Sua.Enabled = btn_Xoa.Enabled = false;
                }
            }
            catch
            {
                MessageBox.Show("Hãy thao tác lại");
            }
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            loadNhanVien();
            loadTKNhanVien();
            btn_Sua.Enabled = btn_Xoa.Enabled = false;
        }

        private void datadanhsachnhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_Sua.Enabled = btn_Xoa.Enabled = true;
        }

        private void DM_NhanVien_Load(object sender, EventArgs e)
        {
            loadNhanVien();
            loadTKNhanVien();
            rdb_nam.Checked = true;
        }
    }
}
