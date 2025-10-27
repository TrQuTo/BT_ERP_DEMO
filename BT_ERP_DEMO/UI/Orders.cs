using BT_ERP_DEMO.Common;
using BT_ERP_DEMO.UI.Common;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT_ERP_DEMO.UI
{
    public partial class Orders :  Base.BaseForm
    {
        string soPhieu = "SO202510-000";
        public Orders()
        {
            InitializeComponent();
            loadGridLookupData();

        }
        BindingSource source = new BindingSource();
        private void gcDetails_Load(object sender, EventArgs e)
        {
            source.DataSource = new BindingList<soVchQuotationDomD0>();
            gcDetails.DataSource = source;
        }

        // Load dữ liệu cho các combobox
        private void loadGridLookupData()
        {
            // load dữ liệu cho glkTrangThai
            glkTrangThai.Properties.DataSource = StatusHelper.GetStatusList();
            glkTrangThai.Properties.DisplayMember = "Name";
            glkTrangThai.Properties.ValueMember = "ID";

            // load dữ liệu cho glkTrangThaGD
            glkTrangThaiGD.Properties.DataSource = StatusHelper.GetStatusList();
            glkTrangThaiGD.Properties.DisplayMember = "Name";
            glkTrangThaiGD.Properties.ValueMember = "ID";

            // load dữ liệu cho glkTrangThaGD
            glkHinhThucTT.Properties.DataSource = StatusHelper.GetPaymentMethodList();
            glkHinhThucTT.Properties.DisplayMember = "Name";
            glkHinhThucTT.Properties.ValueMember = "ID";

            // load dữ liệu cho glkTrangThaGD
            glkTyGia.Properties.DataSource = StatusHelper.GetTyGiaList();
            glkTyGia.Properties.DisplayMember = "Code";
            glkTyGia.Properties.ValueMember = "ID";

            // load dữ liệu cho glkLoaiPhieu
            glkLoaiPhieu.Properties.DataSource = StatusHelper.GetLoaiPhieuList();
            glkLoaiPhieu.Properties.DisplayMember = "Code";
            glkLoaiPhieu.Properties.ValueMember = "ID";
        }

        private bool ValidateInput()
        {
            ClearValidation();
            bool valid = true;

            // Required
            valid &= ValidateRequired(glkLoaiPhieu, "Vui lòng nhập Loại phiếu");
            valid &= ValidateRequired(cboKhachHang, "Vui lòng chọn Khách hàng");
            valid &= ValidateRequired(teDienGiai, "Vui lòng nhập Diễn giải");
            valid &= ValidateRequired(cboHopDong, "Vui lòng chọn Hợp đồng");
            valid &= ValidateRequired(glkHinhThucTT, "Vui lòng chọn Hình thức TT");
            valid &= ValidateRequired(glkTyGia, "Vui lòng chọn Tỷ giá");
            valid &= ValidateRequired(teNguoiMua, "Vui lòng chọn Người mua");
            valid &= ValidateRequired(teSoPhieu, "Vui lòng chọn Số phiếu");
            valid &= ValidateRequired(glkTrangThai, "Vui lòng chọn Trạng thái");
            valid &= ValidateRequired(glkTrangThaiGD, "Vui lòng chọn Trạng thái GD");

            // Ngày tháng
            valid &= ValidateDate(deNgayHachToan, "Ngày hạch toán không hợp lệ");
            valid &= ValidateDate(deNgayXuatPhieu, "Ngày xuất phiếu không hợp lệ");

            return valid;
        }
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Check validate các trường nhập liệu
            if (!ValidateInput())
            {
                XtraMessageBox.Show("Vui lòng nhập đúng thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // TODO: Lưu dữ liệu
        }
        // Hiển thị tạo số phiếu mới
        private void btnNewSoPhieu_Click(object sender, EventArgs e)
        {
            soPhieu = teSoPhieu.Text;
            // Tìm vị trí dấu gạch nối cuối cùng (nếu có)
            int dashIndex = soPhieu.LastIndexOf('-');
            if (dashIndex < 0)
            {
                throw new ArgumentException("Mã không đúng định dạng. Cần có dấu '-' trước số thứ tự.");
            }

            // Tách phần tiền tố và phần số
            string prefix = soPhieu.Substring(0, dashIndex + 1); // "SO202510-"
            string numberPart = soPhieu.Substring(dashIndex + 1); // "000"

            // Chuyển phần số thành int
            if (!int.TryParse(numberPart, out int number))
            {
                throw new ArgumentException("Phần số thứ tự không hợp lệ.");
            }

            // Tăng giá trị lên 1
            number++;

            // Format lại giữ nguyên số chữ số (padding)
            string newNumberPart = number.ToString(new string('0', numberPart.Length));

            // Ghép lại
            teSoPhieu.EditValue = prefix + newNumberPart;
        }

        private void glkTyGia_EditValueChanged(object sender, EventArgs e)
        {
            var edit = sender as DevExpress.XtraEditors.LookUpEdit;
            if (edit?.EditValue == null) return;

            // Lấy DataRowView tương ứng dòng được chọn
            var row = edit.GetSelectedDataRow() as LookupItem;
            if (row != null)
            {
                spnTyGia.Text = row.ExchangeRate.ToString(); // gán giá trị
            }
        }

        private void btnChonBaoGia_Click(object sender, EventArgs e)
        {
            using (var frm = new DKloc())
            {
                frm.ShowDialog(); // form B là modal → Form A bị vô hiệu hóa
            }
        }
    }
}