
namespace Quan_LyBan_Quan_Ao.Forms
{
    partial class SanPhamUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelSanPham = new System.Windows.Forms.Panel();
            this.GiaSanPham = new System.Windows.Forms.Label();
            this.TenSanPham = new System.Windows.Forms.Label();
            this.pictureBoxSanPham = new System.Windows.Forms.PictureBox();
            this.panelSanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSanPham
            // 
            this.panelSanPham.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSanPham.Controls.Add(this.GiaSanPham);
            this.panelSanPham.Controls.Add(this.TenSanPham);
            this.panelSanPham.Controls.Add(this.pictureBoxSanPham);
            this.panelSanPham.Location = new System.Drawing.Point(16, 17);
            this.panelSanPham.Name = "panelSanPham";
            this.panelSanPham.Size = new System.Drawing.Size(167, 268);
            this.panelSanPham.TabIndex = 0;
            // 
            // GiaSanPham
            // 
            this.GiaSanPham.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GiaSanPham.AutoSize = true;
            this.GiaSanPham.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GiaSanPham.Location = new System.Drawing.Point(3, 219);
            this.GiaSanPham.Name = "GiaSanPham";
            this.GiaSanPham.Size = new System.Drawing.Size(55, 17);
            this.GiaSanPham.TabIndex = 1;
            this.GiaSanPham.Text = "Giá Tiền";
            // 
            // TenSanPham
            // 
            this.TenSanPham.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TenSanPham.AutoSize = true;
            this.TenSanPham.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenSanPham.Location = new System.Drawing.Point(3, 166);
            this.TenSanPham.Name = "TenSanPham";
            this.TenSanPham.Size = new System.Drawing.Size(89, 17);
            this.TenSanPham.TabIndex = 1;
            this.TenSanPham.Text = "Tên Sản Phẩm";
            // 
            // pictureBoxSanPham
            // 
            this.pictureBoxSanPham.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxSanPham.Image = global::Quan_LyBan_Quan_Ao.Properties.Resources._0ee1c665_8d5c_4fb3_b0e3_85ba3a7e50d0;
            this.pictureBoxSanPham.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxSanPham.Name = "pictureBoxSanPham";
            this.pictureBoxSanPham.Size = new System.Drawing.Size(161, 115);
            this.pictureBoxSanPham.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSanPham.TabIndex = 0;
            this.pictureBoxSanPham.TabStop = false;
            // 
            // SanPhamUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelSanPham);
            this.Name = "SanPhamUserControl";
            this.Size = new System.Drawing.Size(200, 303);
            this.panelSanPham.ResumeLayout(false);
            this.panelSanPham.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSanPham)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSanPham;
        private System.Windows.Forms.PictureBox pictureBoxSanPham;
        private System.Windows.Forms.Label GiaSanPham;
        private System.Windows.Forms.Label TenSanPham;
    }
}
