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
    public partial class frm_phieuchuyen : DevExpress.XtraEditors.XtraUserControl
    {
        connect conn = new connect();
        SqlDataAdapter da;
        DataColumn[] key = new DataColumn[1];
        DataSet ds;
        public frm_phieuchuyen()
        {
            InitializeComponent();
        }

        public void loadcbxMaKH()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from PHIEUDAT", conn.cnn);

            ds = new DataSet();
            da.Fill(ds, "PHIEUDAT");
            comboBox_madatphong.DataSource = ds.Tables["PHIEUDAT"];
            comboBox_madatphong.DisplayMember = "MADP";
            comboBox_madatphong.ValueMember = "MADP";
            comboBox_madatphong.SelectedIndex = -1;


        }
        public void load_dgvPD()
        {
            string ngay = dateEditngaychuyen.Text;

            ds = new DataSet();
            da = new SqlDataAdapter(" select * from PHIEUDAT where NGAYTRA_DUKIEN>='"+ngay+"'", conn.cnn);
            da.Fill(ds, "PHIEUDAT");
            dataGridView_thongtinchitietchuyen.DataSource = ds.Tables["PHIEUDAT"];
            key[0] = ds.Tables["PHIEUDAT"].Columns[0];
            ds.Tables["PHIEUDAT"].PrimaryKey = key;
        }



        private string sinhtudongMaphieuthue()
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


        private void frm_phieuchuyen_Load(object sender, EventArgs e)
        {
            loadcbxMaKH();
            textBox_MANV.Text = Properties.Settings.Default.MaNV;
            dateEditngaychuyen.Text = DateTime.Now.ToString();
            textBoxmkh.Clear();
            textBox_MANV.Enabled = false;
            textBox_MATP.Clear();
            comboBox_madatphong.SelectedText = "";
            dateEditngaytra.SelectedText = "";
            dateEditngaychuyen.Enabled = false;
            textBox_tiencoc.Clear();
            textBoxsl.Clear();
           
        }

        private void comboBox_madatphong_SelectedIndexChanged(object sender, EventArgs e)
        {



        }
        private bool kiemtratrongdatagridview(string v)
        {
            foreach (DataGridViewRow dr in dataGridView_thongtinchitietchuyen.Rows)
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

        private void dataGridView_thongtinchitietchuyen_SelectionChanged(object sender, EventArgs e)
        {
            try
            {


                dateEditngaytra.Text = dataGridView_thongtinchitietchuyen.CurrentRow.Cells[4].Value.ToString();
                textBoxsl.Text = dataGridView_thongtinchitietchuyen.CurrentRow.Cells[5].Value.ToString();
                textBoxmkh.Text = dataGridView_thongtinchitietchuyen.CurrentRow.Cells[2].Value.ToString();
                textBox_tiencoc.Text = dataGridView_thongtinchitietchuyen.CurrentRow.Cells[6].Value.ToString();
                comboBox_madatphong.SelectedValue = dataGridView_thongtinchitietchuyen.CurrentRow.Cells[0].Value.ToString();
                textBox_MATP.Text = sinhtudongMaphieuthue();
            }
            catch(Exception)
            {

            }
        }

        public void themPhieuThue()
        {
            //try { 
            if (KT_MaTP(comboBox_madatphong.SelectedValue.ToString()) == true)
            {


                int sl = int.Parse(textBoxsl.Text);
                string sel = "INSERT INTO PHIEUTHUE VALUES('" + textBox_MATP.Text + "','" + textBox_MANV.Text + "','" + textBoxmkh.Text + "','" + comboBox_madatphong.SelectedValue.ToString() + "','" + dateEditngaychuyen.Text + "','" + dateEditngaytra.Text + "'," + sl + ",'" + textBox_tiencoc.Text + "')";
                SqlCommand cmd = new SqlCommand(sel, conn.cnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm phiếu thuê thành công !");
                textBox_MATP.Clear();
            }
            else
                MessageBox.Show("Mã Phòng Đã Được Thuê  Vui Lòng Chọn Mã Phòng Khác !");
            //}
            //catch
            //{
            //    MessageBox.Show("Vui lòng thực hiện lại thao tác chuyển phòng!");
            //}
        } 
           


        //public void xoaDP()
        //{


        //    DataRow dr_xoa = ds.Tables["PHIEUDAT"].Rows.Find(comboBox_madatphong.SelectedValue.ToString());

        //    if (dr_xoa != null)
        //    {
        //        dr_xoa.Delete();
        //        SqlCommandBuilder db = new SqlCommandBuilder(da);
        //        da.Update(ds, "PHIEUDAT");

        //        ds.Tables["PHIEUDAT"].Clear();
        //        load_dgvPD();




        //    }
        //    else

        //        MessageBox.Show("Vui lòng chọn mã phiếu nhập ");
        //}

        bool KT_MaTP(string ma)
        {
            try
            {
                //mo ket noi
                
                // xay dung chuoi truy van
                string selectstring = "select count(*) from PHIEUTHUE where MADP = '" + ma + "'";
                // khai bao command voi chuoi truy van va bien kn
                SqlCommand cmd = new SqlCommand(selectstring, conn.cnn);
                // goi ham thuc thi truy van
                int count = (int)cmd.ExecuteScalar();
                //dong kn
               
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


        private void button_lapphieu_Click(object sender, EventArgs e)
        {
            themPhieuThue();
            
        }

       
        private void comboBox_madatphong_SelectedValueChanged(object sender, EventArgs e)
        {
            textBox_MATP.Text = sinhtudongMaphieuthue();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            load_dgvPD();
        }
    }
}
