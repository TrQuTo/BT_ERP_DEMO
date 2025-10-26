using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_ERP_DEMO.Common
{
    public static class LookupCommon
    {
        public enum dcVch01M_Status
        {
            TaoMoi = 0,
            DaDuyet = 1,
            YCThayDoi = 2,
            TuChoi = 3
        }

        public enum dcVch01M_PaymentMethod {
            ChuyenKhoan = 0,
            TienMat = 1,
        }

        public enum dcVch01M_TyGia {
            VND = 0,
            USD = 1,
            EUR = 2,
            JPY = 3,
            GBP = 4,
            CNY = 5
        }
    }
}
