using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_ERP_DEMO.Model
{
    public class SoVch03M
    {
        [DisplayName("Mã Công Ty")]
        public string ma_cty { get; set; }

        [DisplayName("Số Thứ Tự")]
        public string stt_rec { get; set; }

        [DisplayName("Số Chứng Từ")]
        public string so_ct { get; set; }

        [DisplayName("Ngày Chứng Từ")]
        public DateTime ngay_ct { get; set; }

        [DisplayName("Tên Khách Hàng (VAT)")]
        public string ten_kh_vat { get; set; }

        [DisplayName("Mã Số Thuế")]
        public string ma_so_thue { get; set; }

        [DisplayName("Diễn Giải")]
        public string dien_giai { get; set; }

        [DisplayName("Tổng Thanh Toán")]
        public decimal t_tt { get; set; }

        [DisplayName("Thuế GTGT")]
        public decimal t_thue { get; set; }
        [DisplayName("Số Hóa Đơn Điện Tử")]
        public string e_InvoiceNo { get; set; }

        [DisplayName("Ngày Hủy Hóa Đơn")]
        public DateTime e_CancelDate { get; set; }
    }
}
