
namespace Quan_LyBan_Quan_Ao
{
    partial class ManagementPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtCamera = new Guna.UI2.WinForms.Guna2Button();
            this.txtKhachHang = new Guna.UI2.WinForms.Guna2Button();
            this.txtDonHang = new Guna.UI2.WinForms.Guna2Button();
            this.txtNhanVien = new Guna.UI2.WinForms.Guna2Button();
            this.txtQuanao = new Guna.UI2.WinForms.Guna2Button();
            this.ShowForm = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DangXuat = new Guna.UI2.WinForms.Guna2Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(147)))), ((int)(((byte)(251)))));
            this.panel1.Controls.Add(this.DangXuat);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 696);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtKhachHang);
            this.panel2.Controls.Add(this.txtQuanao);
            this.panel2.Controls.Add(this.txtNhanVien);
            this.panel2.Controls.Add(this.txtDonHang);
            this.panel2.Controls.Add(this.txtCamera);
            this.panel2.Controls.Add(this.iconButton1);
            this.panel2.Location = new System.Drawing.Point(0, 119);
            this.panel2.MaximumSize = new System.Drawing.Size(194, 300);
            this.panel2.MinimumSize = new System.Drawing.Size(194, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(194, 300);
            this.panel2.TabIndex = 0;
            // 
            // txtCamera
            // 
            this.txtCamera.BorderThickness = 1;
            this.txtCamera.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.txtCamera.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.txtCamera.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.txtCamera.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.txtCamera.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtCamera.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(89)))), ((int)(((byte)(249)))));
            this.txtCamera.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCamera.ForeColor = System.Drawing.Color.White;
            this.txtCamera.Location = new System.Drawing.Point(0, 62);
            this.txtCamera.Name = "txtCamera";
            this.txtCamera.Size = new System.Drawing.Size(194, 45);
            this.txtCamera.TabIndex = 3;
            this.txtCamera.Text = "Camera";
            this.txtCamera.Click += new System.EventHandler(this.txtCamera_Click);
            // 
            // txtKhachHang
            // 
            this.txtKhachHang.BorderThickness = 1;
            this.txtKhachHang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.txtKhachHang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.txtKhachHang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.txtKhachHang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.txtKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtKhachHang.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(89)))), ((int)(((byte)(249)))));
            this.txtKhachHang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtKhachHang.ForeColor = System.Drawing.Color.White;
            this.txtKhachHang.Location = new System.Drawing.Point(0, 242);
            this.txtKhachHang.Name = "txtKhachHang";
            this.txtKhachHang.Size = new System.Drawing.Size(194, 46);
            this.txtKhachHang.TabIndex = 2;
            this.txtKhachHang.Text = "Khách Hàng";
            this.txtKhachHang.Click += new System.EventHandler(this.txtKhachHang_Click);
            // 
            // txtDonHang
            // 
            this.txtDonHang.BorderThickness = 1;
            this.txtDonHang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.txtDonHang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.txtDonHang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.txtDonHang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.txtDonHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtDonHang.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(89)))), ((int)(((byte)(249)))));
            this.txtDonHang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDonHang.ForeColor = System.Drawing.Color.White;
            this.txtDonHang.Location = new System.Drawing.Point(0, 107);
            this.txtDonHang.Name = "txtDonHang";
            this.txtDonHang.Size = new System.Drawing.Size(194, 45);
            this.txtDonHang.TabIndex = 0;
            this.txtDonHang.Text = "Đơn Hàng";
            this.txtDonHang.Click += new System.EventHandler(this.txtDonHang_Click);
            // 
            // txtNhanVien
            // 
            this.txtNhanVien.BorderThickness = 1;
            this.txtNhanVien.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.txtNhanVien.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.txtNhanVien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.txtNhanVien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.txtNhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtNhanVien.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(89)))), ((int)(((byte)(249)))));
            this.txtNhanVien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNhanVien.ForeColor = System.Drawing.Color.White;
            this.txtNhanVien.Location = new System.Drawing.Point(0, 152);
            this.txtNhanVien.Name = "txtNhanVien";
            this.txtNhanVien.Size = new System.Drawing.Size(194, 45);
            this.txtNhanVien.TabIndex = 1;
            this.txtNhanVien.Text = "Nhân Viên";
            this.txtNhanVien.Click += new System.EventHandler(this.txtNhanVien_Click);
            // 
            // txtQuanao
            // 
            this.txtQuanao.BorderThickness = 1;
            this.txtQuanao.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.txtQuanao.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.txtQuanao.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.txtQuanao.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.txtQuanao.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtQuanao.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(89)))), ((int)(((byte)(249)))));
            this.txtQuanao.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtQuanao.ForeColor = System.Drawing.Color.White;
            this.txtQuanao.Location = new System.Drawing.Point(0, 197);
            this.txtQuanao.Name = "txtQuanao";
            this.txtQuanao.Size = new System.Drawing.Size(194, 45);
            this.txtQuanao.TabIndex = 0;
            this.txtQuanao.Text = "Nhân Viên";
            this.txtQuanao.Click += new System.EventHandler(this.txtQuanao_Click);
            // 
            // ShowForm
            // 
            this.ShowForm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ShowForm.Location = new System.Drawing.Point(194, 29);
            this.ShowForm.Name = "ShowForm";
            this.ShowForm.Size = new System.Drawing.Size(1090, 667);
            this.ShowForm.TabIndex = 1;
            this.ShowForm.Paint += new System.Windows.Forms.PaintEventHandler(this.ShowForm_Paint);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(194, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1090, 33);
            this.panel3.TabIndex = 0;
            // 
            // DangXuat
            // 
            this.DangXuat.AutoRoundedCorners = true;
            this.DangXuat.BorderRadius = 16;
            this.DangXuat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DangXuat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DangXuat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DangXuat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DangXuat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DangXuat.ForeColor = System.Drawing.Color.White;
            this.DangXuat.Location = new System.Drawing.Point(3, 659);
            this.DangXuat.Name = "DangXuat";
            this.DangXuat.Size = new System.Drawing.Size(101, 34);
            this.DangXuat.TabIndex = 0;
            this.DangXuat.Text = "Đăng xuất";
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(89)))), ((int)(((byte)(249)))));
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.House;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(0, 0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(194, 62);
            this.iconButton1.TabIndex = 0;
            this.iconButton1.Text = "Trang Chủ";
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // ManagementPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 696);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.ShowForm);
            this.Controls.Add(this.panel1);
            this.Name = "ManagementPage";
            this.Text = "ManagementPage";
            this.Load += new System.EventHandler(this.ManagementPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button txtQuanao;
        private Guna.UI2.WinForms.Guna2Button txtKhachHang;
        private Guna.UI2.WinForms.Guna2Button txtDonHang;
        private System.Windows.Forms.Panel ShowForm;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button txtCamera;
        private Guna.UI2.WinForms.Guna2Button txtNhanVien;
        private Guna.UI2.WinForms.Guna2Button DangXuat;
        private System.Windows.Forms.Timer timer1;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}