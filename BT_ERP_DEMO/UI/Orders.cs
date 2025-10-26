using DevExpress.XtraEditors;
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
    public partial class Orders : DevExpress.XtraEditors.XtraForm
    {
        public Orders()
        {
            InitializeComponent();

        }
        BindingSource source = new BindingSource();
        private void gcDetails_Load(object sender, EventArgs e)
        {
            source.DataSource = new BindingList<soVchQuotationDomD0>();
            gcDetails.DataSource = source;
        }
    }
}