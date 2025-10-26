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
                new LookupItem { ID = (int) LookupCommon.dcVch01M_PaymentMethod.ChuyenKhoan, Name = "Chuyển khoản" },
                new LookupItem { ID = (int)LookupCommon.dcVch01M_PaymentMethod.TienMat, Name = "Tiền mặt" },
            };
        }

        public static List<LookupItem> GetTyGiaList()
        {
            return new List<LookupItem>
            {
                new LookupItem { ID = (int) LookupCommon.dcVch01M_TyGia.VND, Code = "VND", Name = "Việt Nam đồng", ExchangeRate = 1},
                new LookupItem { ID = (int)LookupCommon.dcVch01M_TyGia.USD, Code = "USD", Name = "Đô la Mỹ", ExchangeRate = 25000 },
                new LookupItem { ID = (int)LookupCommon.dcVch01M_TyGia.EUR, Code = "EUR", Name = "Euro", ExchangeRate = 27000 },
                new LookupItem { ID = (int)LookupCommon.dcVch01M_TyGia.JPY, Code = "JPY", Name = "Yên Nhật", ExchangeRate = 170 },
                new LookupItem { ID = (int)LookupCommon.dcVch01M_TyGia.GBP, Code = "GBP", Name = "Bảng Anh", ExchangeRate = 31000 },
                new LookupItem { ID = (int)LookupCommon.dcVch01M_TyGia.CNY, Code = "CNY", Name = "Nhân dân tệ", ExchangeRate = 3400 },
            };
        }
    }

    public class LookupItem
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ExchangeRate { get; set; }
    }
}
