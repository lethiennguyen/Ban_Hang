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
using Quan_LyBan_Quan_Ao.Froms_KhachHang;

namespace Quan_LyBan_Quan_Ao.Forms
{
    public partial class KhachHang : Form
    {
        public KhachHang()
        {
            InitializeComponent();
        }
        private void KhachHang_load(object sender, EventArgs e)
        {
            try
            {
                QuanLy.Modify modify = new QuanLy.Modify();
                BangKhachHang.DataSource = modify.getKhachHang();

            }
            catch
            {
                MessageBox.Show("erro", "loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ThemKhachHang_Click(object sender, EventArgs e)
        {
            ThemKH kH = new ThemKH();
            kH.Show();
        }

        private void XemThongTinKhachHang_Click(object sender, EventArgs e)
        {
            XemThongTinKhachHang xemkh = new XemThongTinKhachHang();
            xemkh.Show();
        }

        private void HienThiKH_Click(object sender, EventArgs e)
        {
            try
            {
                QuanLy.Modify modify = new QuanLy.Modify();
                BangKhachHang.DataSource = modify.getKhachHang();

            }
            catch
            {
                MessageBox.Show("erro", "loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_SuaTTKhachHang_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = BangKhachHang.SelectedRows[0];

            string maKh = selectedRow.Cells[0].Value.ToString();
            string tenKh = selectedRow.Cells[1].Value.ToString();
            string sdt = selectedRow.Cells[2].Value.ToString();
            string diaChiKh = selectedRow.Cells[3].Value.ToString();
            DateTime ngaysinhKH = DateTime.MinValue; // Khởi tạo một giá trị mặc định cho ngaysinhKH
            if (selectedRow.Cells[5].Value != null && selectedRow.Cells[4].Value is DateTime)
            {
                ngaysinhKH = (DateTime)selectedRow.Cells[4].Value;
                // Tiếp tục xử lý
            }
            int soluongmua = int.Parse(selectedRow.Cells[5].Value.ToString());
            int tongTienMua = int.Parse(selectedRow.Cells[6].Value.ToString());
            ThemKH kh = new ThemKH(maKh, tenKh, sdt, diaChiKh, ngaysinhKH, soluongmua, tongTienMua);
            kh.Show();
        }
    }
}
