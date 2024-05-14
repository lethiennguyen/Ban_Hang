using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace Quan_LyBan_Quan_Ao.Froms_SanPham
{
    public partial class ThemSanPhamQuanAo : Form
    {
        public ThemSanPhamQuanAo()
        {
            InitializeComponent();
        }
        QuanLy.SanPhamClass sanPham;
        private void SanPham_Load(object sender, EventArgs e)
        {
            try
            {
                QuanLy.Modify modify = new QuanLy.Modify();
                BangSanPham.DataSource = modify.getSanPham();
            }
            catch
            {
                MessageBox.Show("error", "loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // lấy anh chuyển sang byte lưu vào sql
        private byte[] ImgaeToByte(PictureBox pictureBox)
        {
            MemoryStream memoryStream = new MemoryStream();
            pictureBox.Image.Save(memoryStream, pictureBox.Image.RawFormat);
            return memoryStream.ToArray();
        }
        private void ThemSanPham_Click(object sender, EventArgs e)
        {
            string maSanPham = this.MaSanPham.Text;
            string tenSanPham = this.TenSanPham.Text;
            string loaiSanPham = this.LoaiSanPham.Text;
            string size =this.SizeSanPham.Text;
            string soLuong =this.SoLuong.Text;
            string mauSac = this.MauSac.Text;
            int gia = int.Parse(this.GiaSanPham.Text);
            byte[] imageSanPham = ImgaeToByte(AnhSanPham);
            // Khởi tạo đối tượng SanPham với các thông tin đã lấy được
            sanPham = new QuanLy.SanPhamClass(maSanPham, tenSanPham, loaiSanPham, size, soLuong, mauSac, gia, imageSanPham);

            try
            {
                QuanLy.Modify modify = new QuanLy.Modify();
                if (modify.InsertSanPham(sanPham))
                {
                    BangSanPham.DataSource = modify.getSanPham();
                }
                else
               {
                    MessageBox.Show("Error", "Không thêm được", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AnhSanPham_Click(object sender, EventArgs e)
        {

        }

        private void ThemAnhSanPham_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png, *.gif,*.jfif)|*.jpg; *.jpeg; *.png; *.gif;*.jfif";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                AnhSanPham.Image = new Bitmap(openFileDialog.FileName);
            }
        }
    }
}
