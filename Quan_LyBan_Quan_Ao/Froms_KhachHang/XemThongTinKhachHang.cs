using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Quan_LyBan_Quan_Ao.Froms_KhachHang
{
    public partial class XemThongTinKhachHang : Form
    {
        public XemThongTinKhachHang()
        {
            InitializeComponent();
        }
       
        private void label1_Click(object sender, EventArgs e)
        {

        }
      
        private void CircleProgressBa_ThuongKhacHang_ValueChanged(object sender, EventArgs e)
        {
            cpb.Value = 50;
        }
    }
}
