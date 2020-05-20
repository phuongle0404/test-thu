using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Da.controller
{
    public partial class frm_phong2 : UserControl
    {
        public frm_phong2()
        {
            InitializeComponent();
        }
        public frm_phong2(string pSoPhong)
        {

            InitializeComponent();
            labelmaphong.Text = pSoPhong;
        }

        private void labelmaphong_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.value2 = labelmaphong.Text;
        }
    }
}
