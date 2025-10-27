using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BT_ERP_DEMO.Common
{
    public class StatusHelper
    {
        public static List<LookupItem> GetStatusList()
        {
            return new List<LookupItem>
            {
                new LookupItem { ID = (int) LookupCommon.dcVch01M_Status.TaoMoi, Name = "Tạo mới" },
                new LookupItem { ID = (int)LookupCommon.dcVch01M_Status.DaDuyet, Name = "Đã duyệt" },
                new LookupItem { ID = (int)LookupCommon.dcVch01M_Status.YCThayDoi, Name = "Y/C thay đổi" },
                new LookupItem { ID = (int)LookupCommon.dcVch01M_Status.TuChoi, Name = "Từ chối" }
            };
        }

        public static List<LookupItem> GetPaymentMethodList()
        {
            return new List<LookupItem>
            {
                new LookupItem { ID = (int)LookupCommon.dcVch01M_PaymentMethod.ChuyenKhoan, Code = "CK", Name = "Chuyển khoản" },
                new LookupItem { ID = (int)LookupCommon.dcVch01M_PaymentMethod.CanTru, Code = "CT", Name = "Cấn Trừ" },
                new LookupItem { ID = (int)LookupCommon.dcVch01M_PaymentMethod.TienMat, Code = "TM", Name = "Tiền mặt" },
            };
        }

        public static List<LookupItem> GetTyGiaList()
        {
            return new List<LookupItem>
            {
                new LookupItem { ID = (int) LookupCommon.dcVch01M_TyGia.VND, Code = "VND", Name = "Việt Nam đồng", ExchangeRate = 1.00},
                new LookupItem { ID = (int)LookupCommon.dcVch01M_TyGia.USD, Code = "USD", Name = "Đô la Mỹ", ExchangeRate = 25000.00 },
                new LookupItem { ID = (int)LookupCommon.dcVch01M_TyGia.EUR, Code = "EUR", Name = "Euro", ExchangeRate = 27000.00 },
                new LookupItem { ID = (int)LookupCommon.dcVch01M_TyGia.JPY, Code = "JPY", Name = "Yên Nhật", ExchangeRate = 170.00 },
                new LookupItem { ID = (int)LookupCommon.dcVch01M_TyGia.GBP, Code = "GBP", Name = "Bảng Anh", ExchangeRate = 31000.00 },
                new LookupItem { ID = (int)LookupCommon.dcVch01M_TyGia.CNY, Code = "CNY", Name = "Nhân dân tệ", ExchangeRate = 3400.00 },
            };
        }

        public static List<LookupItem> GetLoaiPhieuList()
        {
            return new List<LookupItem>
            {
                new LookupItem { ID = (int) LookupCommon.dcVch01M_LoaiPhieu.TheoPO, Name = "Đơn đặt hàng theo PO" },
                new LookupItem { ID = (int)LookupCommon.dcVch01M_LoaiPhieu.TheoForeCast, Name = "Đơn đặt hàng theo Forecast" },
                new LookupItem { ID = (int)LookupCommon.dcVch01M_LoaiPhieu.ThuongMai, Name = "Đơn đặt hàng thương mại" },
                new LookupItem { ID = (int)LookupCommon.dcVch01M_LoaiPhieu.lapRap, Name = "Đơn đặt hàng lắp ráp" },
            };
        }
    }

    public class LookupItem
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double ExchangeRate { get; set; }
    }
}
