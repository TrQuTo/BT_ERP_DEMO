using System;
using System.Data;
using System.Data.SqlClient;

namespace BT_ERP_DEMO.DAL

{
    public class Database : IDisposable
    {
        private SqlConnection connection;

        // Chuỗi kết nối SQL Server
        private string connectionString =
            "Data Source=localhost;Initial Catalog=MyDatabase;Integrated Security=True";

        public Database()
        {
            connection = new SqlConnection(connectionString);
        }

        // Mở kết nối
        public void Open()
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
        }

        // Đóng kết nối
        public void Close()
        {
            if (connection.State == ConnectionState.Open)
                connection.Close();
        }

        // Trả về DataTable (SELECT)
        public DataTable Query(string sql, SqlParameter[] parameters = null)
        {
            using (SqlCommand cmd = new SqlCommand(sql, connection))
            {
                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        // Thực thi (INSERT, UPDATE, DELETE)
        public int Execute(string sql, SqlParameter[] parameters = null)
        {
            using (SqlCommand cmd = new SqlCommand(sql, connection))
            {
                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);
                return cmd.ExecuteNonQuery();
            }
        }

        public void Dispose()
        {
            Close();
        }
    }
}
