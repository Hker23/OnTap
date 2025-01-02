using System;
using System.Data;
using System.Data.SqlClient;

namespace OnTap
{
    internal class LopDungChung
    {
        string chuoikn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\On_tap_all\CS464\OnTap\OnTap\Database1.mdf;Integrated Security=True";
        SqlConnection conn;

        public LopDungChung()
        {
            conn = new SqlConnection(chuoikn);
        }

        // Thêm, xóa, sửa
        public int ThemXoaSua(string sql)
        {
            try
            {
                SqlCommand comm = new SqlCommand(sql, conn);
                conn.Open();
                int kq = comm.ExecuteNonQuery();
                return kq;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in ThemXoaSua: {ex.Message}");
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        // Lấy giá trị duy nhất
        public object LayGT(string sql)
        {
            try
            {
                SqlCommand comm = new SqlCommand(sql, conn);
                conn.Open();
                object kq = comm.ExecuteScalar();
                return kq;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in LayGT: {ex.Message}");
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        // Lấy dữ liệu (DataTable)
        public DataTable LoadDL(string sql)
        {
            try
            {
                DataTable dt = new DataTable();
                using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
                {
                    da.Fill(dt);
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in LoadDL: {ex.Message}");
            }
        }
    }
}
