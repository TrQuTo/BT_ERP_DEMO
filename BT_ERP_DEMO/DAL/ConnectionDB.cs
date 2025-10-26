using BT_ERP_DEMO.Common;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace BT_ERP_DEMO.DAL

{
    public class DbConnectionHelper : IDisposable
    {
        private SqlConnection connection;
        string DatabaseName = AppSettings.ErpDatabase;
        public DbConnectionHelper()
        {
            string connectionString = AppSettings.GetConnectionString(DatabaseName);
            connection = new SqlConnection(connectionString);
        }

        //
        public SqlConnection GetConnection()
        {
            return new SqlConnection(AppSettings.GetConnectionString(DatabaseName));
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
