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
        public BaseForm()
        {
            // Cấu hình mặc định cho toàn bộ Form kế thừa
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.LookAndFeel.SkinName = "Office 2019 Colorful";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.MinimizeBox = true;
            this.KeyPreview = true;
            this.IconOptions.Image = global::BT_ERP_DEMO.Properties.Resources.bach_tung_symbol;

            // Sự kiện dùng chung
            this.KeyDown += BaseForm_KeyDown;
        }

        private void BaseForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close(); // Bấm ESC để đóng form
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            // Ví dụ: tự resize form cho màn hình nhỏ
            if (this.Width > Screen.PrimaryScreen.WorkingArea.Width)
                this.Width = Screen.PrimaryScreen.WorkingArea.Width - 50;
        }
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
