using BT_ERP_DEMO.Repo;
using DevExpress.XtraEditors;
using DevExpress.XtraTab;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BT_ERP_DEMO
{
    public partial class OrderReport : DevExpress.XtraEditors.XtraForm
    {
        private readonly SoVch03MRepository _repo;
        public OrderReport()
        {
            InitializeComponent();
            _repo = new SoVch03MRepository();
        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            if (true)
            {
                //XtraMessageBox.Show("Kết nói database thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tabConOrderReport.SelectedTabPage = tabPageKetQua;
                var data = _repo.GetAll();
                gcKetQua.DataSource = data;

                gvKetQua.BestFitColumns(); // Tự căn độ rộng cột
                gvKetQua.OptionsBehavior.Editable = false; // Không cho sửa dữ liệu
                gvKetQua.OptionsView.ShowGroupPanel = false;
            }
            else
            {
                XtraMessageBox.Show("Kết nối database thất bại.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
