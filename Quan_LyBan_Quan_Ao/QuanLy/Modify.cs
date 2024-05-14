using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows;

namespace Quan_LyBan_Quan_Ao.QuanLy
{
    class Modify
    {
        
        SqlDataAdapter dataAdapter;
        SqlCommand Command;
        public Modify()
        {
        }
        public DataTable getNhanVien()
        {
            DataTable dataTable = new DataTable();
            string Sql = "select * from dbo.NhanVien";
            try
            {
                using (SqlConnection sqlConnection = DataLinkSQl.getConnection())
                {
                    sqlConnection.Open();
                    dataAdapter = new SqlDataAdapter(Sql, sqlConnection);
                    dataAdapter.Fill(dataTable);
                    sqlConnection.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return dataTable;
        }
        public bool Insert(NhanVienClass nhanVien)
        {
            SqlConnection sqlConnection = DataLinkSQl.getConnection();
            string query = "INSERT INTO dbo.NhanVien VALUES (@MaNV, @TenNV,@SDT,@DiaChi,@CCCD,@DateTime,@sex)";
            try
            {
                sqlConnection.Open();
                Command = new SqlCommand(query, sqlConnection);
                Command.Parameters.Add("@MaNV", SqlDbType.NVarChar).Value = nhanVien.Id_name;
                Command.Parameters.Add("@TenNV", SqlDbType.NVarChar).Value = nhanVien.Name;
                Command.Parameters.Add("@SDT", SqlDbType.NVarChar).Value = nhanVien.Phone;
                Command.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = nhanVien.Address;
                Command.Parameters.Add("@CCCD", SqlDbType.NVarChar).Value = nhanVien.Cccd;
                Command.Parameters.Add("@DateTime", SqlDbType.DateTime).Value = nhanVien.DateTime1.ToShortDateString();
                Command.Parameters.Add("@sex", SqlDbType.NVarChar).Value = nhanVien.Sex;
                Command.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
            return true;
        }
        public bool UpDate(NhanVienClass nhanVien)
        {
            SqlConnection sqlConnection = DataLinkSQl.getConnection();
            string query = "UPDATE dbo.NhanVien SET TenNV = @TenNV, SDT = @SDT, DiaChi = @DiaChi, CCCD = @CCCD, DateTime = @DateTime, sex = @sex WHERE MaNV = @MaNV";
            try
            {
                sqlConnection.Open();
                Command = new SqlCommand(query, sqlConnection);
                Command.Parameters.Add("@MaNV", SqlDbType.NVarChar).Value = nhanVien.Id_name;
                Command.Parameters.Add("@TenNV", SqlDbType.NVarChar).Value = nhanVien.Name;
                Command.Parameters.Add("@SDT", SqlDbType.NVarChar).Value = nhanVien.Phone;
                Command.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = nhanVien.Address;
                Command.Parameters.Add("@CCCD", SqlDbType.NVarChar).Value = nhanVien.Cccd;
                Command.Parameters.Add("@DateTime", SqlDbType.DateTime).Value = nhanVien.DateTime1.ToShortDateString();
                Command.Parameters.Add("@sex", SqlDbType.NVarChar).Value = nhanVien.Sex;
                Command.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
            return true;
        }
        public bool Delete( string id_name)
        {
            SqlConnection sqlConnection = DataLinkSQl.getConnection();
            string query = "DELETE FROM dbo.NhanVien WHERE MaNV = @MaNV";
            try
            {
                sqlConnection.Open();
                Command = new SqlCommand(query, sqlConnection);
                Command.Parameters.Add("@MaNV", SqlDbType.NVarChar).Value = id_name;

                Command.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
            return true;
        }
        public DataTable Search_NV(string Name)
        {
            DataTable dt = new DataTable();
            SqlConnection sqlConnection = DataLinkSQl.getConnection();
            string query = "SELECT *FROM dbo.NhanVien WHERE TenNV LIKE @TenNV + '%'";
            try
            {
                sqlConnection.Open();
                SqlCommand Command = new SqlCommand(query, sqlConnection);
                Command.Parameters.Add("@TenNV", SqlDbType.NVarChar).Value = Name;
                SqlDataAdapter da = new SqlDataAdapter(Command);
                da.Fill(dt);
               
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                
            }
            finally
            {
                sqlConnection.Close();
            }
            return dt;
        }

        // Quan ly Khách Hàng 
        public DataTable getKhachHang()
        {
            DataTable dataTable = new DataTable();
            string Sql = "select * from dbo.KhachHang";
            try
            {
                using (SqlConnection sqlConnection = DataLinkSQl.getConnection())
                {
                    sqlConnection.Open();
                    dataAdapter = new SqlDataAdapter(Sql, sqlConnection);
                    dataAdapter.Fill(dataTable);
                    sqlConnection.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return dataTable;
        }
        public bool InsertKH(KhacHangClass khachHang)
        {

            SqlConnection sqlConnection = DataLinkSQl.getConnection();
            string query = "INSERT INTO dbo.KhachHang VALUES (@MaKH, @TenKH, @SDT, @DiaChi, @NgaySinh, @SoLuongMua, @TongTienMua)";
          
            try
            {
                sqlConnection.Open();
                Command = new SqlCommand(query, sqlConnection);
                Command.Parameters.Add("@MaKH", SqlDbType.NVarChar).Value = khachHang.MaKh;
                Command.Parameters.Add("@TenKH", SqlDbType.NVarChar).Value = khachHang.TenKh;
                Command.Parameters.Add("@SDT", SqlDbType.NVarChar).Value = khachHang.Sdt;
                Command.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = khachHang.DiaChiKh;
                Command.Parameters.Add("@NgaySinh", SqlDbType.DateTime).Value = khachHang.NgaysinhKH.ToShortDateString();
                Command.Parameters.Add("@SoLuongMua", SqlDbType.Int).Value = khachHang.Soluongmua;
                Command.Parameters.Add("@TongTienMua", SqlDbType.Int).Value = khachHang.TongTienMua;
                Command.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
            return true;
        }
        public bool Delete_KH(string MaKH)
        {
            SqlConnection sqlConnection = DataLinkSQl.getConnection();
            string query = "DELETE FROM dbo.NhanVien WHERE MaNV = @MaNV";
            try
            {
                sqlConnection.Open();
                Command = new SqlCommand(query, sqlConnection);
                Command.Parameters.Add("@MaKH", SqlDbType.NVarChar).Value = MaKH;

                Command.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
            return true;
        }
        public DataTable Search_KH(string TenKH)
        {
            DataTable dt = new DataTable();
            SqlConnection sqlConnection = DataLinkSQl.getConnection();
            string query = "SELECT *FROM dbo.KhachHang WHERE TenNV LIKE @TenKH + '%'";
            try
            {
                sqlConnection.Open();
                SqlCommand Command = new SqlCommand(query, sqlConnection);
                Command.Parameters.Add("@TenKH", SqlDbType.NVarChar).Value = TenKH;
                SqlDataAdapter da = new SqlDataAdapter(Command);
                da.Fill(dt);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);

            }
            finally
            {
                sqlConnection.Close();
            }
            return dt;
        }

        //San Pham
        public DataTable getSanPham()
        {
            DataTable dataTable = new DataTable();
            string Sql = "select * from dbo.SanPham";
            try
            {
                using (SqlConnection sqlConnection = DataLinkSQl.getConnection())
                {
                    sqlConnection.Open();
                    dataAdapter = new SqlDataAdapter(Sql, sqlConnection);
                    dataAdapter.Fill(dataTable);
                    sqlConnection.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return dataTable;
        }
        public bool InsertSanPham(SanPhamClass sanPham)
        {
            SqlConnection sqlConnection = DataLinkSQl.getConnection();
            string query = "INSERT INTO dbo.SanPham VALUES (@MaSP, @TenSP,@LoaiSP,@Size,@SoLuong,@MauSac,@Gia,@AnhSanPham)";
            try
            {
                sqlConnection.Open();
                Command = new SqlCommand(query, sqlConnection);
                Command.Parameters.Add("@MaSP", SqlDbType.NVarChar).Value = sanPham.MaSanPham;
                Command.Parameters.Add("@TenSP", SqlDbType.NVarChar).Value = sanPham.TenSanPham;
                Command.Parameters.Add("@LoaiSP", SqlDbType.NVarChar).Value = sanPham.LoaiSanPham;
                Command.Parameters.Add("@Size", SqlDbType.NVarChar).Value = sanPham.Size;
                Command.Parameters.Add("@SoLuong", SqlDbType.NVarChar).Value = sanPham.SoLuong;
                Command.Parameters.Add("@MauSac", SqlDbType.NVarChar).Value = sanPham.MauSac;
                Command.Parameters.Add("@Gia", SqlDbType.Int).Value = sanPham.Gia;
                Command.Parameters.Add("@AnhSanPham", SqlDbType.Image).Value = sanPham.ImageSanPham;
                Command.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
            return true;
        }
    }
}
