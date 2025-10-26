using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT_ERP_DEMO.Base
{
    public class BaseForm : XtraForm
    {
        protected DXErrorProvider dxErrorProvider = new DXErrorProvider();
        #region 🔹 Cơ bản
        protected void ClearValidation()
        {
            dxErrorProvider.ClearErrors();
        }

        protected void SetError(Control control, string message)
        {
            dxErrorProvider.SetError(control, message);
        }
        #endregion
        protected bool ValidateRequired(Control control, string message)
        {
            if (control is TextEdit txt && string.IsNullOrWhiteSpace(txt.Text))
            {
                dxErrorProvider.SetError(txt, message);
                return false;
            }

            if (control is LookUpEdit look && (look.EditValue == null || string.IsNullOrWhiteSpace(look.EditValue.ToString())))
            {
                dxErrorProvider.SetError(look, message);
                return false;
            }

            if (control is DateEdit date && date.EditValue == null)
            {
                dxErrorProvider.SetError(date, message);
                return false;
            }

            return true;
        }
        #region 🔹 Kiểm tra độ dài chuỗi
        protected bool ValidateLength(TextEdit control, int min, int max, string message)
        {
            if (control == null) return false;

            int length = control.Text.Trim().Length;
            if (length < min || length > max)
            {
                SetError(control, message);
                return false;
            }
            return true;
        }
        #endregion

        #region 🔹 Kiểm tra số
        protected bool ValidateNumber(TextEdit control, string message)
        {
            if (control == null) return false;

            if (!decimal.TryParse(control.Text.Trim(), out _))
            {
                SetError(control, message);
                return false;
            }
            return true;
        }
        #endregion

        #region 🔹 Kiểm tra email
        protected bool ValidateEmail(TextEdit control, string message)
        {
            if (control == null) return false;

            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(control.Text.Trim(), pattern))
            {
                SetError(control, message);
                return false;
            }
            return true;
        }
        #endregion

        #region 🔹 Kiểm tra ngày tháng
        protected bool ValidateDate(DateEdit control, string message)
        {
            if (control == null) return false;

            if (control.EditValue == null || !(control.EditValue is DateTime))
            {
                SetError(control, message);
                return false;
            }
            return true;
        }
        #endregion

        #region 🔹 Kiểm tra Regex tùy chỉnh
        protected bool ValidateRegex(TextEdit control, string pattern, string message)
        {
            if (control == null) return false;

            if (!Regex.IsMatch(control.Text.Trim(), pattern))
            {
                SetError(control, message);
                return false;
            }
            return true;
        }
        #endregion
    }
}
