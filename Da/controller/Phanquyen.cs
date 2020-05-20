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
    public partial class Phanquyen : DevExpress.XtraEditors.XtraUserControl
    {
        connect conn = new connect();
        DataSet ds = new DataSet();
        SqlDataAdapter da;
        DataColumn[] key = new DataColumn[1];
        string s;
        public Phanquyen()
        {
            InitializeComponent();
            //Load_tk();
            //loaddata();
        }
        private void Load_tk()
        {
            da = new SqlDataAdapter(" select * from TAIKHOAN WHERE QUYEN='' ", conn.cnn);
            da.Fill(ds, "TAIKHOAN");
            dgv_taikhoan.DataSource = ds.Tables["TAIKHOAN"];
            key[0] = ds.Tables["TAIKHOAN"].Columns[0];
            ds.Tables["TAIKHOAN"].PrimaryKey = key;
        }




        private void rdo_admin_Click(object sender, EventArgs e)
        {
            s = "admin";
        }

        private void rdo_nhanvien_Click(object sender, EventArgs e)
        {
            s = "NVIEN";
        }

        private void btn_pq_Click(object sender, EventArgs e)
        {
            try
            {

                DataRow update_New = ds.Tables["TAIKHOAN"].Rows.Find(dgv_taikhoan.CurrentRow.Cells[0].Value.ToString());
                if (update_New != null)
                {
                    update_New["QUYEN"] = s.ToString();
                    SqlCommandBuilder cmb = new SqlCommandBuilder(da);
                    da.Update(ds, "TAIKHOAN");
                    MessageBox.Show(" Cập nhật thành công Thành công");
                    //Load_tk();
                    loaddata();
                }
            }
            catch 
            {
                MessageBox.Show("Thao tác không thành công");
            }
        }

        

        private void dgv_taikhoan_Click(object sender, EventArgs e)
        {
           
            //loaddata();

        }

        private void btn_load_Click(object sender, EventArgs e)
        {

            //  loaddata();
            Load_tk();
        }
        private void loaddata()
        {

            SqlCommand cmd = new SqlCommand("select * from TAIKHOAN WHERE QUYEN=''", conn.cnn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);
            //Tải dữ liệu lên dataGridView
            dgv_taikhoan.DataSource = dt;

            //Tải dữ liệu lên listView
            //int i = 0;
            //foreach (DataRow dr in dt.Rows)
            //{
            //    listView1.Items.Add(dr["TENTK"].ToString());
            //    listView1.Items[i].SubItems.Add(dr["MANV"].ToString());
            //    i++;
            //}

        }

        private void Phanquyen_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void dgv_taikhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }
