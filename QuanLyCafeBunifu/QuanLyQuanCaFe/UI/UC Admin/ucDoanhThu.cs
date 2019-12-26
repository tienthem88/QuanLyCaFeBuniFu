using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyQuanCaFe.DTO;
using QuanLyQuanCaFe.DAO;

namespace QuanLyQuanCaFe.UI.UC_Admin
{
    public partial class ucDoanhThu : UserControl
    {
        public Account loginAccount;
        public ucDoanhThu()
        {
            InitializeComponent();
            Load();
        }


        void Load()
        {
            LoadDateTimePickerBill();
            LoadListBillDate(dtpkFromDate.Value, dtpkToDate.Value);
        }

        void LoadDateTimePickerBill()
        {
            DateTime today = DateTime.Now;
            dtpkFromDate.Value = new DateTime(today.Year, today.Month, 1);
            dtpkToDate.Value = dtpkFromDate.Value.AddMonths(1).AddDays(-1);
        }

        void LoadListBillDate(DateTime checkIn, DateTime checkOut)
        {
            dtgvBill.DataSource = BillDAO.Instance.GetBillListDate(checkIn, checkOut);
        }

        private void btnThongke_Click(object sender, EventArgs e)
        {
            LoadListBillDate(dtpkFromDate.Value, dtpkToDate.Value);
        }
    }
}
