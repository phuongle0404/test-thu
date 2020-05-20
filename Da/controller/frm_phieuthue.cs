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
    public partial class frm_phieuthue : DevExpress.XtraEditors.XtraUserControl
    {
        DataSet ds;
        connect conn = new connect();
        public frm_phieuthue()
        {

            InitializeComponent();
            dataGridView2.Controls.Clear();
        }

        public void loadcbxMaKH()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from KHACHHANG", conn.cnn);

            DataSet ds = new DataSet();
            da.Fill(ds, "KHACHHANG");
            comboBoxmakh.DataSource = ds.Tables["KHACHHANG"];
            comboBoxmakh.DisplayMember = "MAKH";
            comboBoxmakh.ValueMember = "MAKH";
            comboBoxmakh.SelectedIndex = -1;


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frm_phieuthue_Load(object sender, EventArgs e)
        {
          
            dateEditngaynhan.DateTime = DateTime.Now;
            dateEditngaynhan.Enabled = false;
            loadcbxMaKH();
            Loadctroldong();
            dataGridView2.Controls.Clear();
            textBoxmanhanvien.Text = Properties.Settings.Default.MaNV;
        }
        private void Loadctroldong()
        {
            if (dateEditngaynhan.Text.Length > 0 && dateEditngaytra.Text.Length > 0)
            {
                DataSet ds_ph = new DataSet();
                SqlDataAdapter da_ph = new SqlDataAdapter("select MAPH from PHONG", conn.cnn);
                // Ánh xạ dữ liệu từ DB vào dataset, đặt tên Sach
                da_ph.Fill(ds_ph, "PHONG");
                DataTable dtPHONG = ds_ph.Tables["PHONG"];
                //load danh sach
                int x = 0;
                int y = 0;
                int bac = 0;
                foreach (DataRow drPhong in dtPHONG.Rows)
                {
                    bool kq = kiemtra(drPhong);
                    if (kq)
                    {
                        //tạo control động cho các phòng
                        frm_phong2 frm = new frm_phong2(drPhong[0].ToString());

                        frm.Location = new Point(x, y);
                        panel_ph.Controls.Add(frm);
                        x += 183;
                        if (bac >= 5)
                        {
                            y += 183;
                            x = 0;
                            bac = 0;

                        }
                        else
                        {
                            bac++;
                        }
                    }

                }
            }
        }
        private string sinhtudongMaPhieuthue()
        {
            DataSet ds_ph = new DataSet();
            SqlDataAdapter da_phCT = new SqlDataAdapter("select * from PHIEUTHUE", conn.cnn);
            // Ánh xạ dữ liệu từ DB vào dataset, đặt tên Sach
            da_phCT.Fill(ds_ph, "PHIEUTHUE");
            DataTable dt1 = ds_ph.Tables["PHIEUTHUE"];
            int bien1;
            int bien2;
            int bien3 = 1;
            if (dt1 == null)
            {
                bien1 = 1;
                bien2 = bien1;
                bien3 = 1;
            }
            else
            {
                bien1 = dt1.Rows.Count + 2;
                bien2 = bien1;
                bien3 = 1;
            }

            while (bien2 < 999)
            {
                bien2 = bien1 + bien3;
                bien3 *= 10;
            }
            return "TP" + bien2.ToString().Substring(1, 3);
        }
        private bool kiemtra(DataRow drPhong)
        {
            DataSet ds_ph = new DataSet();
            SqlDataAdapter da_phCT = new SqlDataAdapter("select PHONG.MAPH from PHONG,CT_PHIEUDAT,PHIEUDAT WHERE PHONG.MAPH=CT_PHIEUDAT.MAPH AND CT_PHIEUDAT.MADP=PHIEUDAT.MADP AND NGAYNHAN_DUKIEN<='" + dateEditngaytra.DateTime + "' AND NGAYTRA_DUKIEN>='" + dateEditngaynhan.DateTime + "'", conn.cnn);
            // Ánh xạ dữ liệu từ DB vào dataset, đặt tên Sach
            da_phCT.Fill(ds_ph, "PHONG1");
            DataTable dt1 = ds_ph.Tables["PHONG1"];

            foreach (DataRow dr in dt1.Rows)
            {
                if (drPhong["MAPH"].ToString() == dr["MAPH"].ToString())
                {
                    return false;
                }
            }
            SqlDataAdapter da_phCTThue = new SqlDataAdapter("select PHONG.MAPH from PHONG,CT_THUEPHONG,PHIEUTHUE WHERE PHONG.MAPH=CT_THUEPHONG.MAPH AND CT_THUEPHONG.MATP=PHIEUTHUE.MATP AND NGAYNHAN<='" + dateEditngaytra.DateTime + "' AND NGAYTRA>='" + dateEditngaynhan.DateTime + "'", conn.cnn);
            // Ánh xạ dữ liệu từ DB vào dataset, đặt tên Sach
            da_phCTThue.Fill(ds_ph, "PHONG2");
            DataTable dt2 = ds_ph.Tables["PHONG2"];

            foreach (DataRow dr in dt2.Rows)
            {
                if (drPhong["MAPH"].ToString() == dr["MAPH"].ToString())
                {
                    return false;
                }
            }
            return true;
        }
        DataSet ds_phchitiet = new DataSet();
        DataTable dt1chitiet;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.value2 != 0.ToString() && Properties.Settings.Default.value2 != null)
            {
                if (kiemtratrongdatagridview(Properties.Settings.Default.value2.ToString().Trim().ToString()))
                {
                    SqlDataAdapter da_phCT = new SqlDataAdapter("select * from CT_THUEPHONG where MATP ='999999'", conn.cnn);
                    // Ánh xạ dữ liệu từ DB vào dataset
                    da_phCT.Fill(ds_phchitiet, "CHITIET");
                    dt1chitiet = ds_phchitiet.Tables["CHITIET"];

                    DataRow dr = dt1chitiet.NewRow();
                    dr[0] = sinhtudongMaPhieuthue();
                    dr[1] = Properties.Settings.Default.value2.ToString().Trim().ToString();

                    Properties.Settings.Default.value2 = 0.ToString();
                    dt1chitiet.Rows.Add(dr);
                    
                    dataGridView2.DataSource = dt1chitiet;
                }
                else
                {

                    Properties.Settings.Default.value2 = 0.ToString();
                    MessageBox.Show("Phòng này đã chọn! Vui lòng chọn phòng khác!");
                }
            }
        }
        private bool kiemtratrongdatagridview(string v)
        {
            foreach (DataGridViewRow dr in dataGridView2.Rows)
            {
                if (dr.Cells[1].Value != null)
                {
                    if (dr.Cells[1].Value.ToString() == v)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        

        private void dateEditngaynhan_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (dateEditngaytra.DateTime.ToString() != "1/1/0001 12:00:00 AM" && dateEditngaynhan.DateTime.ToString() != "1/1/0001 12:00:00 AM")
                {
                    if (dateEditngaynhan.DateTime <= dateEditngaytra.DateTime)
                    {
                        dt1chitiet = new DataTable();
                        panel_ph.Controls.Clear();
                        Loadctroldong();
                    }
                    else
                    {
                        dt1chitiet = new DataTable();
                        panel_ph.Controls.Clear();
                        MessageBox.Show("Vui lòng chọn lại ngày trả bạn nhé!");
                    }
                }
            }
            catch
            {

            }
        }

        private void dataGridView2_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            loadtextbox();
        }
        private void loadtextbox()
        {
            if (Properties.Settings.Default.MaNV != null && dataGridView2.Rows.Count > 0 && dataGridView2.Rows[0].Cells[0].Value != null)
            {

                textBoxmanhanvien.Text = Properties.Settings.Default.MaNV.ToString();
                textBoxmathuephong.Text = dataGridView2.Rows[0].Cells[0].Value.ToString();
                textBoxsl.Text = (dataGridView2.Rows.Count - 1).ToString();
            }
            else
            {
                textBoxmanhanvien.Text = "";
                textBoxmathuephong.Text = "";
                textBoxsl.Text = "";

                textBoxtiencoc.Text = "";
            }
        }
       

        private void button_lapphieu_Click(object sender, EventArgs e)
        {
            if (textBoxmanhanvien.Text.Length > 0 && comboBoxmakh.SelectedValue != null && textBoxtiencoc.Text.Length > 0 && textBoxmathuephong.Text.Length > 0 && textBoxsl.Text.Length > 0 && dateEditngaynhan.Text.Length > 0 && dateEditngaytra.Text.Length > 0)
            {
                try
                {
                    themPhieuThue();
                    themChiTietPhieuTHUE();

                    MessageBox.Show("Bạn đã thêm thành công !!!!!!");
                    reload();

                }
                catch
                {
                    MessageBox.Show("Bạn đã thêm thất bại !!!!!!");
                }

            }
            else
            {
                MessageBox.Show("Bạn vui lòng nhập đầy đủ dữ liệu !!!!!");
            }

        }
        private void reload()
        {
            textBoxmanhanvien.Text = "";
            textBoxmathuephong.Text = "";
            dateEditngaynhan.Text = "";
            dateEditngaytra.Text = "";
            textBoxsl.Text = "";
            textBoxtiencoc.Text = "";
            try
            {
                try
                {
                    for (int i = dataGridView2.Rows.Count - 2; i >= 0; i--)
                    {
                        dataGridView2.Rows.RemoveAt(i);
                    }

                }
                catch
                {
                    try
                    {
                        dataGridView2.Rows.Clear();
                    }
                    catch
                    {
                        dataGridView2.Controls.Clear();
                    }
                }
            }
            catch
            {
                dataGridView2.DataSource = null;
            }


        }
        private void themChiTietPhieuTHUE()
        {
            // Tạo Adapter
            SqlDataAdapter da = new SqlDataAdapter("select * from CT_THUEPHONG", conn.cnn);


            // Tạo và lấp đầy DataSet
            DataSet ds = new DataSet();
            da.Fill(ds, "CTPhieuThem1");
           
            foreach (DataGridViewRow dr in dataGridView2.Rows)
            {
                if (dr.Cells[0].Value != null && dr.Cells[1].Value != null)
                {
                    DataRow row = ds.Tables["CTPhieuThem1"].NewRow();
                    row[0] = dr.Cells[0].Value.ToString();
                    row[1] = dr.Cells[1].Value.ToString();
                    ds.Tables["CTPhieuThem1"].Rows.Add(row);
                }
            }
            // Tiến hành insert vào database Source
            SqlCommandBuilder builda = new SqlCommandBuilder(da);
            da.Update(ds, "CTPhieuThem1");



        }

        private void themPhieuThue()
        {
            // Tạo Adapter
            SqlDataAdapter da = new SqlDataAdapter("select * from PHIEUTHUE", conn.cnn);


            // Tạo và lấp đầy DataSet
            ds = new DataSet();
            da.Fill(ds, "PhieuThem1");
            // Lấy thông tin Table vào DataTable
            // DataTable dt = ds.Tables["PhieuThem"];

            // Tạo thêm row mới
            DataRow newRow = ds.Tables["PhieuThem1"].NewRow();
            newRow[0] = textBoxmathuephong.Text;
            newRow[1] = textBoxmanhanvien.Text;
            newRow[2] = comboBoxmakh.SelectedValue.ToString();
            newRow[4] = dateEditngaynhan.DateTime;
            newRow[5] = dateEditngaytra.DateTime;
            newRow[6] = int.Parse(textBoxsl.Text);
            newRow[7] = textBoxtiencoc.Text;
            //dt.Rows.Add(newRow);

            ds.Tables["PhieuThem1"].Rows.Add(newRow);
            // Tiến hành insert vào database Source
            SqlCommandBuilder builda = new SqlCommandBuilder(da);
            da.Update(ds, "PhieuThem1");


        }

        private void button_xoaphong_Click(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow != null)
            {
                dataGridView2.Rows.RemoveAt(dataGridView2.CurrentRow.Index);

            }
            else
            {
                MessageBox.Show("Vui lòng chọn chi tiết cần xóa");
            }
        }
    }
}
