using BT_ERP_DEMO.DAL;
using BT_ERP_DEMO.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_ERP_DEMO.Repo
{
    public class SoVch03MRepository
    {
        private readonly DbConnectionHelper _db;

        public SoVch03MRepository()
        {
            _db = new DbConnectionHelper();
        }

        public List<SoVch03M> GetAll()
        {
            List<SoVch03M> list = new List<SoVch03M>();
            string query = "SELECT ma_cty, stt_rec, so_ct, ngay_ct, ten_kh_vat, ma_so_thue, dien_giai, t_tt, t_thue, e_InvoiceNo, e_CancelDate FROM dbo.soVch03M";

            using (SqlConnection conn = _db.GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new SoVch03M
                        {
                            ma_cty = reader["ma_cty"].ToString(),
                            stt_rec = reader["stt_rec"].ToString(),
                            so_ct = reader["so_ct"].ToString(),
                            ngay_ct = (DateTime)reader["ngay_ct"],
                            ten_kh_vat = reader["ten_kh_vat"].ToString(),
                            ma_so_thue = reader["ma_so_thue"].ToString(),
                            dien_giai = reader["dien_giai"].ToString(),
                            t_tt = reader.GetDecimal(reader.GetOrdinal("t_tt")),
                            t_thue = reader.GetDecimal(reader.GetOrdinal("t_thue")),
                            e_InvoiceNo = reader["e_InvoiceNo"].ToString(),
                            e_CancelDate = (DateTime)reader["e_CancelDate"]
                        });
                    }
                }
            }

            return list;
        }
    }
}
