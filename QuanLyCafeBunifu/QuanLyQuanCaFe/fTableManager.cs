using QuanLyQuanCaFe.DAO;
using QuanLyQuanCaFe.DTO;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Menu = QuanLyQuanCaFe.DTO.Menu;
using Bunifu;

namespace QuanLyQuanCaFe
{


    public partial class fTableManager : Form
    {
        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccountAdmin(loginAccount.Type); ChangeAccount(loginAccount.Type); }
        }

        public fTableManager(Account acc)
        {
            InitializeComponent();

            this.LoginAccount = acc;

            LoadTable();
            LoadCategory();
            LoadComboboxTable(cbChuyenban);
        }


        #region Method

        void ChangeAccountAdmin(int type)
        {
            if (type == 1)
                btnAdmin.Enabled = true;
            else
                btnAdmin.Enabled = false;
            btnInformation.Text += " (" + LoginAccount.DisplayName + ")";
        }

        void ChangeAccount(int type)
        {
            tbxUserName.Text = LoginAccount.UserName;
            tbxDisplayName.Text = LoginAccount.DisplayName;
        }

        void UpdateAccount()
        {
            string displayName = tbxDisplayName.Text;
            string password = tbxPassWord.Text;
            string newpass = tbxNewPass.Text;
            string repass = tbxRePass.Text;
            string userName = tbxUserName.Text;

            if(!newpass.Equals(repass))
            {
                MessageBox.Show("Vui lòng nhập lại mật khẩu đúng với mật khẩu mới!");

            }
            else
            {
                if(AccountDAO.Instance.UpdateAccount(userName, displayName, password, newpass))
                {
                    MessageBox.Show("Cập nhật thành công");
                }
                else
                {
                    MessageBox.Show("Vui lòng điền đúng mật khẩu");
                }
            }
        }

        void LoadCategory()
        {
            List<Category> listCategory = CategoryDAO.Instance.GetListCategory();
            cbCategory.DataSource = listCategory;
            cbCategory.DisplayMember = "name";
        }

        void LoadFoodListByCategoryID(int id)
        {
            List<Food> listFood = FoodDAO.Instance.GetFoodByCategoryID(id);
            cbFood.DataSource = listFood;
            cbFood.DisplayMember = "name";
        }


        void LoadTable()
        {
            flpTable.Controls.Clear();
            //if (pnMenu.Width == 250)
            //    pnTable.Location = new Point(250, 49);
            Bitmap bitmap = new Bitmap(Application.StartupPath + "\\btnTable.png");
            Bitmap bitmap1 = new Bitmap(Application.StartupPath + "\\btnTable12.png");
            List<Table> tableList = TableDAO.Instance.LoadTableList();
            foreach (Table item in tableList)
            {
                Button btn = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight };
                btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
                btn.BackgroundImage = bitmap;
                btn.UseVisualStyleBackColor = false;
                btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
                btn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
                btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                btn.Text = "                             "+item.Name + Environment.NewLine + " " + item.Status;
                btn.Click += Btn_Click;
                btn.Tag = item;
                switch (item.Status)
                {
                    case "Trống":
                        break;
                    default:
                        btn.BackgroundImage = bitmap1;
                        break;
                }

                flpTable.Controls.Add(btn);

            }
        }

        void ShowBill(int id)
        {
            lsvBill.Items.Clear();
            List<Menu> listBillInfo = MenuDAO.Instances.GetListMenuByTable(id);
            float totalPrice = 0;
            foreach (Menu item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.FoodName.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.TotalPrice.ToString());
                totalPrice += item.TotalPrice;
                lsvBill.Items.Add(lsvItem);
            }
            CultureInfo culture = new CultureInfo("vi-VN");

            //Thread.CurrentThread.CurrentCulture = culture;   // Dòng này để đổi culture cả chương trình sang tiếng việt

            tbxTotalPrice.Text = totalPrice.ToString("c", culture); // CHỉ chạy trong hàm này culture này

        }

        void LoadComboboxTable(ComboBox cb)
        {
            cb.DataSource = TableDAO.Instance.LoadTableList();
            cb.DisplayMember = "Name";

        }
       

       

        #endregion

        private void ptbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if(pnMenu.Width==45)
            {
                pnMenu.Visible = false;
                pnMenu.Width = 250;
                btnMenu.Location = new Point(210, 19);
                pnMenu.BringToFront();
                animationMenuOpen.ShowSync(pnMenu);
                anmationLogo.ShowSync(btnMenu);
                ptbLogo.Visible = true;


            }
            else
            {
                ptbLogo.Visible = false;
                pnMenu.Visible = false;
                pnMenu.Width = 45;
               
                btnMenu.Location = new Point(10, 19);
                animationMenuClose.ShowSync(pnMenu);
                anmationLogo.ShowSync(btnMenu);
                if (pnTable.Location.X == 250)
                    pnTable.Location = new Point(46, 44);
                
            }

        }

        private void btnTable_Click(object sender, EventArgs e)
        {

            if (pnTable.Visible == false)
            {
                //if(pnMenu.Width == 250)
                //{
                //    ptbLogo.Visible = false;
                //    pnMenu.Visible = false;
                //    pnMenu.Width = 45;
                    
                //    btnMenu.Location = new Point(10, 19);
                //    animationMenuClose.ShowSync(pnMenu);
                //    anmationLogo.ShowSync(btnMenu);

                //}
                //pnTable.BringToFront();
                animationTable.ShowSync(pnTable);
               
            }
            //animationTable.Hide(pnAcount);

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            fAdmin a = new fAdmin();
            this.Hide();
            a.ShowDialog();
            this.Show();
        }

        private void btnInformation_Click(object sender, EventArgs e)
        {
            //if (pnMenu.Width == 250)
            //{
            //    ptbLogo.Visible = false;
            //    pnMenu.Visible = false;
            //    pnMenu.Width = 45;
            //    pnTable.Location = new Point(46, 47);
            //    btnMenu.Location = new Point(10, 19);
            //    animationMenuClose.ShowSync(pnMenu);
            //    anmationLogo.ShowSync(btnMenu);

            //}
            animationTable.Hide(pnTable);
            //pnAcount.BringToFront();
        }

        #region Events

        private void Btn_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as Table).ID;
            lsvBill.Tag = (sender as Button).Tag;
            ShowBill(tableID);
            if (pnMenu.Width == 250)
            {
                ptbLogo.Visible = false;
                pnMenu.Visible = false;
                pnMenu.Width = 45;
                btnMenu.Location = new Point(10, 19);
                animationMenuClose.ShowSync(pnMenu);
                anmationLogo.ShowSync(btnMenu);
                if (pnTable.Location.X == 250)
                    pnTable.Location = new Point(46, 44);
            }

        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;

            ComboBox cb = sender as ComboBox;

            if (cb.SelectedItem == null)
                return;
            Category selected = cb.SelectedItem as Category;
            id = selected.ID;

            LoadFoodListByCategoryID(id);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table;

            int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.ID);
            int foodID = (cbFood.SelectedItem as Food).ID;
            int count = (int)nmFoodCount.Value;

            if (idBill == -1)
            {
                BillDAO.Instance.InsertBill(table.ID);
                BillInfoDAO.Instance.InsertBillInfo(BillDAO.Instance.GetMaxIDBill(), foodID, count);

            }
            else
            {
                BillInfoDAO.Instance.InsertBillInfo(idBill, foodID, count);
            }

            ShowBill(table.ID);
            LoadTable();
        }

        private void btnThanhtoan_Click(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table;

            int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.ID);
            int discount = (int)nmDiscount.Value;
           
            double totalPrice = Convert.ToDouble(tbxTotalPrice.Text.Split(',')[0])*1000;
            double finaltotalprice = totalPrice - (totalPrice / 100) * discount;

            if(idBill != -1)
            {
                if(MessageBox.Show(string.Format("Bạn có chắc thanh toán hoá đơn cho bàn {0}\n Tổng tiền - (Tổng tiền / 100) x Giảm giá = {1} - ({1} / 100 x {2}) = {3}"  , table.Name, totalPrice, discount, finaltotalprice), "Thông báo", MessageBoxButtons.OKCancel)== System.Windows.Forms.DialogResult.OK)
                {
                    BillDAO.Instance.CheckOut(idBill, discount, (float)finaltotalprice);
                    ShowBill(table.ID);
                }
            }

            LoadTable();
        }

        private void btnChuyenban_Click(object sender, EventArgs e)
        {
            int id1 = (lsvBill.Tag as Table).ID;

            int id2 = (cbChuyenban.SelectedItem as Table).ID;

            if (MessageBox.Show(string.Format("Bạn có thật sự muốn chuyển bàn {0} qua bàn {1}", (lsvBill.Tag as Table).Name, (cbChuyenban.SelectedItem as Table).Name), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                TableDAO.Instance.SwitchTable(id1, id2);

                LoadTable();
            }
        }

        private void pnTable_MouseClick(object sender, MouseEventArgs e)
        {
            pnMenu.Width = 45;
            btnMenu.Location = new Point(10, 19);
        }


        #endregion

        private void flpTable_MouseClick(object sender, MouseEventArgs e)
        {
            ptbLogo.Visible = false;
            pnMenu.Visible = false;
            pnMenu.Width = 45;

            btnMenu.Location = new Point(10, 19);
            animationMenuClose.ShowSync(pnMenu);
            anmationLogo.ShowSync(btnMenu);
            if (pnTable.Location.X == 250)
                pnTable.Location = new Point(46, 44);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateAccount();
        }

        private void btnExitAcount_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnAcount_MouseClick(object sender, MouseEventArgs e)
        {
            ptbLogo.Visible = false;
            pnMenu.Visible = false;
            pnMenu.Width = 45;

            btnMenu.Location = new Point(10, 19);
            animationMenuClose.ShowSync(pnMenu);
            anmationLogo.ShowSync(btnMenu);
            if (pnTable.Location.X == 250)
                pnTable.Location = new Point(46, 44);
        }
    }
}
