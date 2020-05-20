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

namespace Da.controller
{
    public partial class DM_phong : DevExpress.XtraEditors.XtraUserControl
    {
        connect conn = new connect();

        DataSet ds_loaiph = new DataSet();
        SqlDataAdapter da_loaiph;
        DataSet ds_ph = new DataSet();
        SqlDataAdapter da_ph;
        DataColumn[] key = new DataColumn[1];
        public DM_phong()
        {
            InitializeComponent();
        }

        private void DM_phong_Load(object sender, EventArgs e)
        {

            Load_LoaiPH();
            Load_PH();
            Load_combobox_maloai();
            cbo_maloai.Enabled = false;
            txt_maloai.Enabled = false;
            txt_tenloai.Enabled = false;
            txt_gia.Enabled = false;
            txt_ghichu.Enabled = false;
            btnLuu_loaiph.Enabled = false;
            btnLuu_PH.Enabled= false;

        }
        private void Load_LoaiPH()
        {
            connect conn = new connect();
            da_loaiph = new SqlDataAdapter(" select * from LOAIPHONG", conn.cnn);
            da_loaiph.Fill(ds_loaiph, "LOAIPHONG");
            dgv_loaiph.DataSource = ds_loaiph.Tables["LOAIPHONG"];
            key[0] = ds_loaiph.Tables["LOAIPHONG"].Columns[0];
            ds_loaiph.Tables["LOAIPHONG"].PrimaryKey = key;
        }
        private void Load_PH()
        {
            da_ph = new SqlDataAdapter(" select * from PHONG where MALOAI = '" + txt_maloai.Text + "'", conn.cnn);
            da_ph.Fill(ds_ph, "PHONG");
            dgv_ph.DataSource = ds_ph.Tables["PHONG"];
            key[0] = ds_ph.Tables["PHONG"].Columns[0];
            ds_ph.Tables["PHONG"].PrimaryKey = key;
        }
        private void Load_combobox_maloai()
        {
            cbo_maloai.DataSource = ds_loaiph.Tables["LOAIPHONG"];
            cbo_maloai.ValueMember = "MALOAI";
            cbo_maloai.DisplayMember = "TENLOAI";

        }
        private void Load_TrangThai_BanDau_LoaiPH()
        {
            btnThem_LoaiPH.Enabled = true;
            btn_capnhat_loai.Enabled = true;
            btnLuu_loaiph.Enabled = false;
            txt_maloai.Enabled = false;
            txt_tenloai.Enabled = false;
            txt_gia.Enabled = false;
            txt_ghichu.Enabled = false;
        }

        private void Load_trangthai_bandau_PH()
        {
            btnThem_PH.Enabled = true;
            btn_capnhat_ph.Enabled = true;
            btnLuu_PH.Enabled = true;
            txt_maph.Enabled = false;
            txt_vitri.Enabled = false;
            txt_tinhtrang.Enabled = false;
            cbo_maloai.Enabled = false;
        }

        
        private void dgv_loaiph_Click(object sender, EventArgs e)
        {
            txt_maloai.Text = dgv_loaiph.CurrentRow.Cells[0].Value.ToString();
            txt_tenloai.Text = dgv_loaiph.CurrentRow.Cells[1].Value.ToString();
            txt_gia.Text = dgv_loaiph.CurrentRow.Cells[2].Value.ToString();
            txt_ghichu.Text = dgv_loaiph.CurrentRow.Cells[3].Value.ToString();
            delete_dgv();
            Load_PH();
        }
        private void delete_dgv()
        {
            ds_ph.Tables["PHONG"].Clear();
        }
        bool KT_Ma(string ma)
        {
            try
            {
                //mo ket noi
                //if (conn.State == ConnectionState.Closed)
                //    conn.Open();
                // xay dung chuoi truy van
                string selectstring = "select count(*) from LOAIPHONG where MALOAI = '" + ma + "'";
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
       

        private void dgv_ph_Click(object sender, EventArgs e)
        {
            txt_maph.Text = dgv_ph.CurrentRow.Cells[0].Value.ToString();
            txt_vitri.Text = dgv_ph.CurrentRow.Cells[1].Value.ToString();
            txt_tinhtrang.Text = dgv_ph.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnThem_PH_Click_1(object sender, EventArgs e)
        {
            btn_capnhat_ph.Enabled = false;
            txt_maph.Enabled = true;
            txt_vitri.Enabled = true;
            cbo_maloai.Enabled = true;
            btnLuu_PH.Enabled = true;
        }

        private void btn_capnhat_ph_Click_1(object sender, EventArgs e)
        {

            btnThem_PH.Enabled = false;
            txt_maph.Enabled = false;
            txt_vitri.Enabled = true;
            txt_tinhtrang.Enabled = true;
            btnLuu_PH.Enabled = true;
        }

        private void btnLuu_PH_Click_1(object sender, EventArgs e)
        {
            try { 
            if (txt_maph.Enabled == true)// them phong
            {
                if (KT_Ma(txt_maph.Text) == true) // mã chưa tồn tại
                {

                    Load_PH();

                    DataRow insert_New = ds_ph.Tables["PHONG"].NewRow();
                    insert_New["MAPH"] = txt_maph.Text;
                        insert_New["MALOAI"] = cbo_maloai.SelectedValue.ToString();
                        insert_New["VTPHONG"] = txt_vitri.Text;
                        insert_New["TINHTRANG"] = txt_tinhtrang.Text;
                    ds_ph.Tables["PHONG"].Rows.Add(insert_New);
                    SqlCommandBuilder cmb = new SqlCommandBuilder(da_ph);
                    da_ph.Update(ds_ph, "PHONG");
                    MessageBox.Show(" Thêm phòng đã thành công");
                    Load_PH();

                }
                else
                    MessageBox.Show("Thao tác sai");
            }
            else // cap nhat phong
            {
                DataRow update_New = ds_ph.Tables["PHONG"].Rows.Find(txt_maph.Text);
                if (update_New != null)
                {
                    update_New["VTPHONG"] = txt_vitri.Text;
                    update_New["TINHTRANG"] = txt_tinhtrang.Text;
                    SqlCommandBuilder cmb = new SqlCommandBuilder(da_ph);
                    da_ph.Update(ds_ph, "PHONG");
                    MessageBox.Show("Cập nhật đã thành công");
                    Load_PH();
                }
                }
            }catch
            {
                MessageBox.Show(" Hãy thao tác lại");
            }
        }

        private void btnThem_LoaiPH_Click_1(object sender, EventArgs e)
        {
            btn_capnhat_loai.Enabled = false;
            txt_maloai.Enabled = true;
            txt_tenloai.Enabled = true;
            txt_gia.Enabled = true;
            txt_ghichu.Enabled = true;
            btnLuu_loaiph.Enabled = true;
        }

        private void btn_capnhat_loai_Click_1(object sender, EventArgs e)
        {
            btnThem_LoaiPH.Enabled = false;
            txt_maloai.Enabled = false;
            txt_tenloai.Enabled = true;
            txt_gia.Enabled = true;
            txt_ghichu.Enabled = true;
            btnLuu_loaiph.Enabled = true;
        }

        private void btnLuu_loaiph_Click_1(object sender, EventArgs e)
        {
            try
            { 
            if (txt_maloai.Enabled == true) //them loai phong
            {
                if (KT_Ma(txt_maloai.Text) == true) // mã chưa tồn tại
                {

                    Load_LoaiPH();

                    DataRow insert_New = ds_loaiph.Tables["LOAIPHONG"].NewRow();
                    insert_New["MALOAI"] = txt_maloai.Text;
                    insert_New["TENLOAI"] = txt_tenloai.Text;
                    insert_New["GIAPH"] = txt_gia.Text;
                    insert_New["GHICHU"] = txt_ghichu.Text;
                    ds_loaiph.Tables["LOAIPHONG"].Rows.Add(insert_New);
                    SqlCommandBuilder cmb = new SqlCommandBuilder(da_loaiph);
                    da_loaiph.Update(ds_loaiph, "LOAIPHONG");
                    MessageBox.Show(" Thêm Thành công");
                    Load_LoaiPH();
                    Load_TrangThai_BanDau_LoaiPH();
                }
                else
                    MessageBox.Show("Thao tác sai");
            }
            else  // cap nhat loai phonng      
            {
                DataRow update_New = ds_loaiph.Tables["LOAIPHONG"].Rows.Find(txt_maloai.Text);
                if (update_New != null)
                {
                    update_New["TENLOAI"] = txt_tenloai.Text;
                    update_New["GIAPH"] = txt_gia.Text;
                    update_New["GHICHU"] = txt_ghichu.Text;
                    SqlCommandBuilder cmb = new SqlCommandBuilder(da_loaiph);
                    da_loaiph.Update(ds_loaiph, "LOAIPHONG");
                    MessageBox.Show(" Cập nhật thành công");
                    Load_combobox_maloai();
                    Load_LoaiPH();
                    Load_TrangThai_BanDau_LoaiPH();
                }
            }
            }
            catch
            {
                MessageBox.Show(" Hãy thao tác lại");
            }
        }

        private void dgv_ph_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_loaiph_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}














    

       

        

      

        

       
    
