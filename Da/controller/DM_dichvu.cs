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
    public partial class DM_dichvu : DevExpress.XtraEditors.XtraUserControl
    {
        connect conn = new connect();

        DataSet ds_loaiph = new DataSet();
        SqlDataAdapter da;
        DataSet ds = new DataSet();
       
        DataColumn[] key = new DataColumn[1];
        public DM_dichvu()
        {
            InitializeComponent();
            Load_DGV_Dichvu();
        }
        private void Load_DGV_Dichvu()
        {
            da = new SqlDataAdapter(" select * from DICHVU", conn.cnn);
            da.Fill(ds, "DICHVU");
            dgv_dichvu.DataSource = ds.Tables["DICHVU"];
            key[0] = ds.Tables["DICHVU"].Columns[0];
            ds.Tables["DICHVU"].PrimaryKey = key;

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txt_madv.Enabled = false;
            txt_tendv.Enabled = true;
            txt_giadv.Enabled = true;
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
        }
        bool KT_Ma(string ma)
        {
            try
            {
                ////mo ket noi
                //if (conn.State == ConnectionState.Closed)
                //    conn.Open();
                // xay dung chuoi truy van
                string selectstring = "select count(*) from DICHVU where MADV = '" + ma + "'";
                // khai bao command voi chuoi truy van va bien kn
                SqlCommand cmd = new SqlCommand(selectstring, conn.cnn);
                // goi ham thuc thi truy van
                int count = (int)cmd.ExecuteScalar();
                //dong kn
                //conn.Close();
                //xu ly ket qua truy van

                if (count >= 1) // da co ma lop
                    return false;
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }

        private void Clear_txt()
        {
            txt_madv.Text = null;
            txt_tendv.Text = null;
            txt_giadv.Text = null;
        }
        private void Load_TrangThai_BanDau()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txt_madv.Enabled = false;
            txt_tendv.Enabled = false;
            txt_giadv.Enabled = false;
            Clear_txt();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try { 
            if (txt_madv.Enabled == true)
            {
                if (KT_Ma(txt_madv.Text) == true) // mã chưa tồn tại
                {

                    Load_DGV_Dichvu();

                    DataRow insert_New = ds.Tables["DICHVU"].NewRow();
                    insert_New["MADV"] = txt_madv.Text;
                    insert_New["TENDV"] = txt_tendv.Text;
                    insert_New["GIADV_HIENTAI"] = txt_giadv.Text;
                    ds.Tables["DICHVU"].Rows.Add(insert_New);
                    SqlCommandBuilder cmb = new SqlCommandBuilder(da);
                    da.Update(ds, "DICHVU");
                    MessageBox.Show(" Thêm Thành công");
                    Load_TrangThai_BanDau();
                    Load_DGV_Dichvu();

                }
                else
                    MessageBox.Show("Thao tác sai!!!!");
            }
            else
            {
                DataRow update_New = ds.Tables["DICHVU"].Rows.Find(txt_madv.Text);
                if (update_New != null)
                {
                    update_New["TENDV"] = txt_tendv.Text;
                    update_New["GIADV_HIENTAI"] = txt_giadv.Text;
                    SqlCommandBuilder cmb = new SqlCommandBuilder(da);
                    da.Update(ds, "DICHVU");
                    MessageBox.Show(" Cập nhật thành công");
                    Load_TrangThai_BanDau();
                    Load_DGV_Dichvu();
                }
            }
            }
            catch
            {
                MessageBox.Show("Hãy thao tác lại");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r;
                r = MessageBox.Show("Bạn có chắc muốn xóa không?", "Thông báo xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (r == DialogResult.Yes)
                {

                    DataRow dr_xoa = ds.Tables["DICHVU"].Rows.Find(txt_madv.Text);

                    if (dr_xoa != null)
                    {
                        dr_xoa.Delete();
                        SqlCommandBuilder db = new SqlCommandBuilder(da);
                        da.Update(ds, "DICHVU");

                        ds.Tables["DICHVU"].Clear();
                        Load_DGV_Dichvu();
                        MessageBox.Show("Xóa thành  công !");

                        txt_madv.Text = null;
                        txt_tendv.Text = null;
                        txt_giadv.Text = null;
                    }
                    else

                        MessageBox.Show("Vui lòng chọn một dịch vụ");
                }
            }
            catch
            {
                MessageBox.Show("Thao tác thực hiện của bạn không thành công! Bạn hãy thao tác lại");

            }
        }

        private void DM_dichvu_Load(object sender, EventArgs e)
        {
            txt_madv.Enabled = false;
            txt_tendv.Enabled = false;
            txt_giadv.Enabled = false;
            btnLuu.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txt_madv.Enabled = true;
            txt_tendv.Enabled = true;
            txt_giadv.Enabled = true;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
        }

        private void dgv_dichvu_Click(object sender, EventArgs e)
        {
            txt_madv.Text = dgv_dichvu.CurrentRow.Cells[0].Value.ToString();
            txt_tendv.Text = dgv_dichvu.CurrentRow.Cells[1].Value.ToString();
            txt_giadv.Text = dgv_dichvu.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
