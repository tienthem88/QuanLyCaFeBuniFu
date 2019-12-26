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
using QuanLyQuanCafe.DAO;
using QuanLyQuanCaFe.DAO;

namespace QuanLyQuanCaFe.UI.UC_Admin
{
    public partial class ucAdmin : UserControl
    {

        BindingSource foodlist = new BindingSource();
        BindingSource tableList = new BindingSource();
        BindingSource accountList = new BindingSource();
        BindingSource categoryList = new BindingSource();
        public Account loginAccount;
        public ucAdmin()
        {
            InitializeComponent();
            //Load();
            ucDoanhThu ucdoanhthu = new ucDoanhThu();

            ucdoanhthu.loginAccount = loginAccount;

            pnThemes.Controls.Clear();

            ucdoanhthu.Dock = DockStyle.Fill;

            pnThemes.Controls.Add(ucdoanhthu);
        }

       

        private void lbDoanhThu_Click(object sender, EventArgs e)
        {
            bunifuSeparator1.Width = ((Bunifu.Framework.UI.BunifuCustomLabel)sender).Width;
            bunifuSeparator1.Left = ((Bunifu.Framework.UI.BunifuCustomLabel)sender).Left;
            ucDoanhThu ucdoanhthu = new ucDoanhThu();

            ucdoanhthu.loginAccount = loginAccount;
            
            pnThemes.Controls.Clear();

            ucdoanhthu.Dock = DockStyle.Fill;


            ucdoanhthu.Visible = false;
            pnThemes.Controls.Add(ucdoanhthu);

            ADoanhThu.ShowSync(ucdoanhthu);
        }

        private void lbThucAn_Click(object sender, EventArgs e)
        {
            bunifuSeparator1.Width = ((Bunifu.Framework.UI.BunifuCustomLabel)sender).Width;
            bunifuSeparator1.Left = ((Bunifu.Framework.UI.BunifuCustomLabel)sender).Left;
            ucThucAn ucthucan = new ucThucAn();

            ucthucan.loginAccount = loginAccount;

            pnThemes.Controls.Clear();

            ucthucan.Dock = DockStyle.Fill;

            ucthucan.Visible = false;
            pnThemes.Controls.Add(ucthucan);

            ADoanhThu.ShowSync(ucthucan);
        }

        private void lbDoanhMuc_Click(object sender, EventArgs e)
        {
            bunifuSeparator1.Width = ((Bunifu.Framework.UI.BunifuCustomLabel)sender).Width;
            bunifuSeparator1.Left = ((Bunifu.Framework.UI.BunifuCustomLabel)sender).Left;

            ucDanhMuc ucdanhmuc = new ucDanhMuc();

            ucdanhmuc.loginAccount = loginAccount;

            pnThemes.Controls.Clear();

            ucdanhmuc.Dock = DockStyle.Fill;

            ucdanhmuc.Visible = false;
            pnThemes.Controls.Add(ucdanhmuc);

            ADoanhThu.ShowSync(ucdanhmuc);
        }

        private void lbBanAn_Click(object sender, EventArgs e)
        {
            bunifuSeparator1.Width = ((Bunifu.Framework.UI.BunifuCustomLabel)sender).Width;
            bunifuSeparator1.Left = ((Bunifu.Framework.UI.BunifuCustomLabel)sender).Left;

            ucBanAn ucbanan = new ucBanAn();

            ucbanan.loginAccount = loginAccount;

            pnThemes.Controls.Clear();

            ucbanan.Dock = DockStyle.Fill;

            ucbanan.Visible = false;
            pnThemes.Controls.Add(ucbanan);

            ADoanhThu.ShowSync(ucbanan);

        }

        private void lbTaiKhoan_Click(object sender, EventArgs e)
        {
            bunifuSeparator1.Width = ((Bunifu.Framework.UI.BunifuCustomLabel)sender).Width;
            bunifuSeparator1.Left = ((Bunifu.Framework.UI.BunifuCustomLabel)sender).Left;

            ucAccount uctaikhoan = new ucAccount();

            uctaikhoan.loginAccount = loginAccount;

            pnThemes.Controls.Clear();

            uctaikhoan.Dock = DockStyle.Fill;

            uctaikhoan.Visible = false;
            pnThemes.Controls.Add(uctaikhoan);

            ADoanhThu.ShowSync(uctaikhoan);
        }


        //#region methods
        //void Load()
        //{
        //    dtgvFood.DataSource = foodlist;
        //    dtgvAccount.DataSource = accountList;
        //    dtgvTable.DataSource = tableList;
        //    dtgvCategory.DataSource = categoryList;
        //    LoadDateTimePickerBill();
        //    ShowAllCategory();
        //    ShowAllTable();
        //    LoadAccount();
        //    AddTableBinding();
        //    AddAccountBinding();
        //    LoadListBillDate(dtpkFromDate.Value, dtpkToDate.Value);
        //    LoadListFood();
        //    AddFoodBinding();
        //    LoadCategoryIntoCombobox(cbCategoryFood);
        //}

        //void LoadDateTimePickerBill()
        //{
        //    DateTime today = DateTime.Now;
        //    dtpkFromDate.Value = new DateTime(today.Year, today.Month, 1);
        //    dtpkToDate.Value = dtpkFromDate.Value.AddMonths(1).AddDays(-1);
        //}

        //void LoadListFood()
        //{
        //    foodlist.DataSource = FoodDAO.Instance.GetListFood();
        //}

        //#endregion
    }
}
