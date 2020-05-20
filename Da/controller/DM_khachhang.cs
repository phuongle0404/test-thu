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
    public partial class DM_khachhang : DevExpress.XtraEditors.XtraUserControl
    {
        public DM_khachhang()
        {
            InitializeComponent();
        }
        connect conn = new connect();

        DataSet ds = new DataSet();
        SqlDataAdapter da;
        DataColumn[] key = new DataColumn[1];

        them_khachhang _them_khachhang;

        public void clear_row()
        {
            for (int i = 0; i < datakhachhang.Rows.Count - 1; i++)
            {
                datakhachhang.Rows[i].Selected = false;
            }
        }

        public void loadData()
        {           
            da = new SqlDataAdapter(" select * from KHACHHANG", conn.cnn);
            da.Fill(ds, "KHACHHANG");
            datakhachhang.DataSource = ds.Tables["KHACHHANG"];
            key[0] = ds.Tables["KHACHHANG"].Columns[0];
            ds.Tables["KHACHHANG"].PrimaryKey = key;

            for (int i = 0; i < datakhachhang.Rows.Count - 1; i++)
            {
                txtmkh.AutoCompleteCustomSource.Add(ds.Tables["KHACHHANG"].Rows[i][0].ToString());
                txttenkh.AutoCompleteCustomSource.Add(ds.Tables["KHACHHANG"].Rows[i][1].ToString());
            }

            txttenkh.AutoCompleteMode = AutoCompleteMode.Append;
            txttenkh.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        public void loadData_makh(string ma)
        {
            da = new SqlDataAdapter("select * from KHACHHANG where MAKH ='" + ma +"'", conn.cnn);
            da.Fill(ds, "KHACHHANG_ma");
            datakhachhang.DataSource = ds.Tables["KHACHHANG_ma"];
            key[0] = ds.Tables["KHACHHANG_ma"].Columns[0];
            ds.Tables["KHACHHANG_ma"].PrimaryKey = key;
        }

        public void loadData_tenkh(string ten)
        {
            da = new SqlDataAdapter("select * from KHACHHANG where HOTEN ='" + ten + "'", conn.cnn);
            da.Fill(ds, "KHACHHANG_tenkh");
            datakhachhang.DataSource = ds.Tables["KHACHHANG_tenkh"];
            key[0] = ds.Tables["KHACHHANG_tenkh"].Columns[0];
            ds.Tables["KHACHHANG_tenkh"].PrimaryKey = key;
        }

        public void loadData_cmnd(string cmnd)
        {
            da = new SqlDataAdapter("select * from KHACHHANG where SOCMND = '" + cmnd +"'", conn.cnn);
            da.Fill(ds, "KHACHHANG_cmnd");
            datakhachhang.DataSource = ds.Tables["KHACHHANG_cmnd"];
            key[0] = ds.Tables["KHACHHANG_cmnd"].Columns[0];
            ds.Tables["KHACHHANG_cmnd"].PrimaryKey = key;
        }

        public void loadData_sdt(string sdt)
        {
            da = new SqlDataAdapter("select * from KHACHHANG where SDT ='" + sdt + "'", conn.cnn);
            da.Fill(ds, "KHACHHANG_sdt");
            datakhachhang.DataSource = ds.Tables["KHACHHANG_sdt"];
            key[0] = ds.Tables["KHACHHANG_sdt"].Columns[0];
            ds.Tables["KHACHHANG_sdt"].PrimaryKey = key;
        }

        public void loadData_quoctich(string quoctich)
        {
            da = new SqlDataAdapter("select * from KHACHHANG where QUOCTICH ='" + quoctich + "'", conn.cnn);
            da.Fill(ds, "KHACHHANG_quoctich");
            datakhachhang.DataSource = ds.Tables["KHACHHANG_quoctich"];
            key[0] = ds.Tables["KHACHHANG_quoctich"].Columns[0];
            ds.Tables["KHACHHANG_quoctich"].PrimaryKey = key;
        }

        public void DM_khachhang_Load(object sender, EventArgs e)
        {
            loadData();

            
        }

        bool KT_Ma(string ma)
        {
            try
            {
                //mo ket noi
                //if (conn.State == ConnectionState.Closed)
                //    conn.Open();
                // xay dung chuoi truy van
                string selectstring = "select count(*) from KHACHHANG where MAKH = '" + ma + "'";
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try 
            { 
                DialogResult r;
                r = MessageBox.Show("Bạn có chắc muốn xóa không?", "Thông báo xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (r == DialogResult.Yes)
                {
       
                    DataRow dr_xoa = ds.Tables["KHACHHANG"].Rows.Find(txtmkh.Text);

                    if (dr_xoa != null)
                    {
                        dr_xoa.Delete();
                        SqlCommandBuilder db = new SqlCommandBuilder(da);
                         da.Update(ds, "KHACHHANG");

                        ds.Tables["KHACHHANG"].Clear();
                        MessageBox.Show("Xóa thành công !");

                        txtmkh.Clear();
                        txttenkh.Clear();
                        txtcmnd.Clear();
                        txtsdt.Clear();
                        txtquoctich.Clear();

                        btn_lammoi_Click(sender, e);
                    }
                    else
                        MessageBox.Show("Vui lòng chọn mã khách hàng ");
                }
            }
            catch
            {
                MessageBox.Show("Bạn đã xóa không thành công!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string makh = datakhachhang.CurrentRow.Cells[0].Value.ToString();
            try 
            { 
                DataRow update_New = ds.Tables["KHACHHANG"].Rows.Find(makh);
                if (update_New != null)
                {
                    update_New["HOTEN"] = txttenkh.Text;
                    update_New["SOCMND"] = txtcmnd.Text;
                    update_New["SDT"] = txtsdt.Text;
                    update_New["QUOCTICH"] = txtquoctich.Text;
             
                    SqlCommandBuilder cmb = new SqlCommandBuilder(da);
                    da.Update(ds, "KHACHHANG");
                    MessageBox.Show(" Cập nhật Thành công");
                    btn_lammoi_Click(sender, e);
                }
            }
            catch
            {
                MessageBox.Show(" Cập nhật không thành công");
            }
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            //tìm theo mã khách hàng
            if (string.IsNullOrEmpty(txtmkh.Text) == false)
            {
                datakhachhang.DataSource = null;
                loadData_makh(txtmkh.Text.TrimEnd());
            }
            //tìm theo tên khách hàng
            else if (string.IsNullOrEmpty(txttenkh.Text) == false)
            {
                datakhachhang.DataSource = null;
                loadData_tenkh(txttenkh.Text.TrimEnd());
            }
            //tìm theo số căn cước/cmnd
            else if (string.IsNullOrEmpty(txtcmnd.Text) == false)
            {
                datakhachhang.DataSource = null;
                loadData_cmnd(txtcmnd.Text.TrimEnd());
            }
            //tìm theo số điện thoại
            else if (string.IsNullOrEmpty(txtsdt.Text) == false)
            {
                datakhachhang.DataSource = null;
                loadData_sdt(txtsdt.Text.TrimEnd());
            }
            // tìm theo quốc tịch
            else if (string.IsNullOrEmpty(txtquoctich.Text) == false)
            {
                datakhachhang.DataSource = null;
                loadData_quoctich(txtquoctich.Text.TrimEnd());
            }
            else
                MessageBox.Show("Thông tin khách hàng không chính xác");
        }

        public void btn_lammoi_Click(object sender, EventArgs e)
        {
            txtcmnd.Text = txtmkh.Text = txtquoctich.Text = txtsdt.Text = txttenkh.Text = null;
            loadData();
            clear_row();
            datakhachhang.Rows[0].Selected = true;

            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            _them_khachhang = new them_khachhang();
        }

        private void datakhachhang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmkh.Text = datakhachhang.CurrentRow.Cells[0].Value.ToString();
            txttenkh.Text = datakhachhang.CurrentRow.Cells[1].Value.ToString();
            txtcmnd.Text = datakhachhang.CurrentRow.Cells[2].Value.ToString();
            txtsdt.Text = datakhachhang.CurrentRow.Cells[3].Value.ToString();
            txtquoctich.Text = datakhachhang.CurrentRow.Cells[4].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            them_khachhang _Them_khachhang = new them_khachhang();
            _Them_khachhang.ShowDialog();
        }       

        private void txtsdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}


