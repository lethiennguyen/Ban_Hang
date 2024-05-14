using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quan_LyBan_Quan_Ao.Froms_SanPham;

namespace Quan_LyBan_Quan_Ao.Forms
{
    public partial class ChucNang : Form
    {
      
        public ChucNang()
        {
            InitializeComponent();
        }
        
        private void ThemSanPham_Click(object sender, EventArgs e)
        {
            ThemSanPhamQuanAo sanpham = new ThemSanPhamQuanAo();
            sanpham.Show();
        }
        
    }
}
