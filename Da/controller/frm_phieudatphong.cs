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
using DevExpress.XtraTab;
using System.Data.SqlClient;

namespace Da.controller
{
    public partial class frm_phieudatphong : DevExpress.XtraEditors.XtraUserControl
    {

        DataSet ds;
        connect conn = new connect();
        public frm_phieudatphong()
        {
            InitializeComponent();
        }

        private void frm_phieudatphong_Load(object sender, EventArgs e)
        {
            Loadctroldong();
            //////sinhtudongMaPhieuDat();
            loadcbxMaKH();

        }

        private void Loadctroldong()
        {
            if (dateEditngaydat.Text.Length > 0 && dateEditngaytra.Text.Length > 0)
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
                        frm_phong frm = new frm_phong(drPhong[0].ToString());

                        frm.Location = new Point(x, y);
                        panelphong.Controls.Add(frm);
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

        private bool kiemtra(DataRow drPhong)
        {
            DataSet ds_ph = new DataSet();
            SqlDataAdapter da_phCT = new SqlDataAdapter("select PHONG.MAPH from PHONG,CT_PHIEUDAT,PHIEUDAT WHERE PHONG.MAPH=CT_PHIEUDAT.MAPH AND CT_PHIEUDAT.MADP=PHIEUDAT.MADP AND NGAYNHAN_DUKIEN<='" + dateEditngaytra.DateTime + "' AND NGAYTRA_DUKIEN>='" + dateEditngaydat.DateTime + "'", conn.cnn);
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
            SqlDataAdapter da_phCTThue = new SqlDataAdapter("select PHONG.MAPH from PHONG,CT_THUEPHONG,PHIEUTHUE WHERE PHONG.MAPH=CT_THUEPHONG.MAPH AND CT_THUEPHONG.MATP=PHIEUTHUE.MATP AND NGAYNHAN<='" + dateEditngaytra.DateTime + "' AND NGAYTRA>='" + dateEditngaydat.DateTime + "'", conn.cnn);
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

        private void dateEditngaydat_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (dateEditngaytra.DateTime.ToString() != "1/1/0001 12:00:00 AM" && dateEditngaydat.DateTime.ToString() != "1/1/0001 12:00:00 AM")
                {
                    if (dateEditngaydat.DateTime <= dateEditngaytra.DateTime)
                    {
                        panelphong.Controls.Clear();
                        Loadctroldong();
                    }
                    else
                    {
                        panelphong.Controls.Clear();
                        MessageBox.Show("Vui lòng chọn lại ngày trả bạn nhé!");
                    }
                }
            }
            catch
            {

            }

        }
        DataSet ds_phchitiet = new DataSet();
        DataTable dt1chitiet;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.value != 0.ToString() && Properties.Settings.Default.value != null)
            {
                if (kiemtratrongdatagridview(Properties.Settings.Default.value.ToString().Trim().ToString()))
                {
                    SqlDataAdapter da_phCT = new SqlDataAdapter("select * from CT_PHIEUDAT where MADP ='999999'", conn.cnn);
                    // Ánh xạ dữ liệu từ DB vào dataset
                    da_phCT.Fill(ds_phchitiet, "CHITIET");
                    dt1chitiet = ds_phchitiet.Tables["CHITIET"];

                    DataRow dr = dt1chitiet.NewRow();
                    dr[0] = sinhtudongMaPhieuDat();
                    dr[1] = Properties.Settings.Default.value.ToString().Trim().ToString();

                    Properties.Settings.Default.value = 0.ToString();
                    dt1chitiet.Rows.Add(dr);
                    dataGridViewchitiet.DataSource = dt1chitiet;
                }
                else
                {

                    Properties.Settings.Default.value = 0.ToString();
                    MessageBox.Show("Phòng này đã chọn! Vui lòng chọn phòng khác!");
                }
            }
        }

        private bool kiemtratrongdatagridview(string v)
        {
            foreach (DataGridViewRow dr in dataGridViewchitiet.Rows)
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

        private string sinhtudongMaPhieuDat()
        {
            DataSet ds_ph = new DataSet();
            SqlDataAdapter da_phCT = new SqlDataAdapter("select * from PHIEUDAT", conn.cnn);
            // Ánh xạ dữ liệu từ DB vào dataset, đặt tên Sach
            da_phCT.Fill(ds_ph, "PHIEUDAT");
            DataTable dt1 = ds_ph.Tables["PHIEUDAT"];
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
            return "DP" + bien2.ToString().Substring(1, 3);
        }

        private void button_luu_Click(object sender, EventArgs e)
        {    
            //them dk cho if
            ////
            if (textBoxmanhanvien.Text.Length > 0 && comboBoxkhachhang.SelectedValue != null &&  textBoxtiencoc.Text.Length > 0 && textBoxmaphieudat.Text.Length > 0 && textBoxsoluong.Text.Length > 0 && dateEditngaydat.Text.Length > 0 && dateEditngaytra.Text.Length > 0)
            {
                try
                {
                    themPhieuDAt();
                    themChiTietPhieuDat();
                    
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
            textBoxmaphieudat.Text = "";
            dateEditngaydat.Text = "";
            dateEditngaytra.Text = "";
            textBoxsoluong.Text = "";
            textBoxtiencoc.Text = "";
            try
            {
                try
                {
                    for (int i = dataGridViewchitiet.Rows.Count - 2; i >= 0; i--)
                    {
                        dataGridViewchitiet.Rows.RemoveAt(i);
                    }

                }
                catch
                {
                    try
                    {
                        dataGridViewchitiet.Rows.Clear();
                    }
                    catch
                    {
                        dataGridViewchitiet.Controls.Clear();
                    }
                }
            }
            catch
            {
                dataGridViewchitiet.DataSource = null;
            }


        }
        public void loadcbxMaKH()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from KHACHHANG", conn.cnn);

            DataSet ds = new DataSet();
            da.Fill(ds, "KHACHHANG");
            comboBoxkhachhang.DataSource = ds.Tables["KHACHHANG"];
            comboBoxkhachhang.DisplayMember = "MAKH";
            comboBoxkhachhang.ValueMember = "MAKH";
            comboBoxkhachhang.SelectedIndex = -1;


        }

        private void themChiTietPhieuDat()
        {
            // Tạo Adapter
            SqlDataAdapter da = new SqlDataAdapter("select * from CT_PHIEUDAT", conn.cnn);


            // Tạo và lấp đầy DataSet
            DataSet ds = new DataSet();
            da.Fill(ds, "CTPhieuThem");
            // Lấy thông tin Table vào DataTable
            //DataTable dt = ds.Tables["CTPhieuThem"];

            // Tạo thêm row mới
            //DataRow newRow = dt.NewRow();
            //newRow[0] = textBoxmaphieudat.Text;
            //newRow[1] = textBoxmanhanvien.Text;
            //newRow[2] = dateEditngaydat.DateTime;
            //newRow[3] = dateEditngaytra.DateTime;
            //newRow[4] = int.Parse(textBoxsoluong.Text);
            //dt.Rows.Add(newRow);
            foreach (DataGridViewRow dr in dataGridViewchitiet.Rows)
            {
                if (dr.Cells[0].Value != null && dr.Cells[1].Value != null)
                {
                    DataRow row = ds.Tables["CTPhieuThem"].NewRow();
                    row[0] = dr.Cells[0].Value.ToString();
                    row[1] = dr.Cells[1].Value.ToString();
                    ds.Tables["CTPhieuThem"].Rows.Add(row);
                }
            }
            // Tiến hành insert vào database Source
            SqlCommandBuilder builda = new SqlCommandBuilder(da);
            da.Update(ds, "CTPhieuThem");



        }

        private void themPhieuDAt()
        {
            // Tạo Adapter
            SqlDataAdapter da = new SqlDataAdapter("select * from PHIEUDAT", conn.cnn);


            // Tạo và lấp đầy DataSet
             ds = new DataSet();
            da.Fill(ds, "PhieuThem");
            // Lấy thông tin Table vào DataTable
            // DataTable dt = ds.Tables["PhieuThem"];

            // Tạo thêm row mới
            DataRow newRow = ds.Tables["PhieuThem"].NewRow();
            newRow[0] = textBoxmaphieudat.Text;
            newRow[1] = textBoxmanhanvien.Text;
            newRow[2] = comboBoxkhachhang.SelectedValue.ToString();
            newRow[3] = dateEditngaydat.DateTime;
            newRow[4] = dateEditngaytra.DateTime;
            newRow[5] = int.Parse(textBoxsoluong.Text);
            newRow[6] = textBoxtiencoc.Text;
            //dt.Rows.Add(newRow);

            ds.Tables["PhieuThem"].Rows.Add(newRow);
            // Tiến hành insert vào database Source
            SqlCommandBuilder builda = new SqlCommandBuilder(da);
            da.Update(ds, "PhieuThem");


        }

        private void button_xoa_Click(object sender, EventArgs e)
        {
            if (dataGridViewchitiet.CurrentRow != null)
            {
                dataGridViewchitiet.Rows.RemoveAt(dataGridViewchitiet.CurrentRow.Index);

            }
            else
            {
                MessageBox.Show("Vui lòng chọn chi tiết cần xóa");
            }
        }

        private void loadtextbox()
        {
            if (Properties.Settings.Default.MaNV != null && dataGridViewchitiet.Rows.Count > 0 && dataGridViewchitiet.Rows[0].Cells[0].Value != null)
            {

                textBoxmanhanvien.Text = Properties.Settings.Default.MaNV.ToString();
                textBoxmaphieudat.Text = dataGridViewchitiet.Rows[0].Cells[0].Value.ToString();
                textBoxsoluong.Text = (dataGridViewchitiet.Rows.Count - 1).ToString();
            }
            else
            {
                textBoxmanhanvien.Text = "";
                textBoxmaphieudat.Text = "";
                textBoxsoluong.Text = "";
    
                textBoxtiencoc.Text = "";
            }
        }



        

        private void dataGridViewchitiet_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            loadtextbox();
        }

       
    }
}
