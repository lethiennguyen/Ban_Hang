using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_LyBan_Quan_Ao
{
    public partial class ManagementPage : Form
    {
        public ManagementPage()
        {
            InitializeComponent();
        }
        private Form currentChilFoms;
        private void OpenChilForm(Form ChilFoms)
        {
            if(currentChilFoms != null)//kiểm tra khơi tạo rồi đóng
            {
                currentChilFoms.Close();
            }
            currentChilFoms = ChilFoms;
            ChilFoms.TopLevel = false;
            ChilFoms.FormBorderStyle = FormBorderStyle.None;
            ChilFoms.Dock = DockStyle.Fill;
            ShowForm.Controls.Add(ChilFoms);
            ShowForm.Tag = ChilFoms;
            ChilFoms.BringToFront();
            ChilFoms.Show();

        }
        private void txtQuanao_Click(object sender, EventArgs e)
        {
            OpenChilForm(new Forms.ChucNang());
        }

        private void txtDonHang_Click(object sender, EventArgs e)
        {
            OpenChilForm(new Forms.DonHang());
        }

        private void txtNhanVien_Click(object sender, EventArgs e)
        {
            OpenChilForm(new Forms.NhanVien());
        }

        private void txtKhachHang_Click(object sender, EventArgs e)
        {
            OpenChilForm(new Forms.KhachHang());
        }

        private void txtCamera_Click(object sender, EventArgs e)
        {
            Camera Cam = new Camera();
            Cam.Show();
        }

        private void ShowForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ManagementPage_Load(object sender, EventArgs e)
        {

        }

    }
}
