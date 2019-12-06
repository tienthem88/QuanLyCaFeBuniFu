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

namespace QuanLyQuanCaFe
{
    public partial class fTableManager : Form
    {
        public fTableManager()
        {
            InitializeComponent();
            LoadTable();
            LoadCategory();
        }


        #region Method

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
            List<Table> tableList = TableDAO.Instance.LoadTableList();
            foreach (Table item in tableList)
            {
                Button btn = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight };
                btn.Text = item.Name + Environment.NewLine + item.Status;
                btn.Click += Btn_Click;
                btn.Tag = item;
                switch (item.Status)
                {
                    case "Trống":
                        btn.BackColor = Color.Aqua;
                        break;
                    default:
                        btn.BackColor = Color.Azure;
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

            }
        }

        private void btnTable_Click(object sender, EventArgs e)
        {

            if (pnTable.Visible == false)
            {
                if(pnMenu.Width == 250)
                {
                    ptbLogo.Visible = false;
                    pnMenu.Visible = false;
                    pnMenu.Width = 45;
                    
                    btnMenu.Location = new Point(10, 19);
                    animationMenuClose.ShowSync(pnMenu);
                    anmationLogo.ShowSync(btnMenu);

                }
                pnTable.BringToFront();
                animationTable.ShowSync(pnTable);
               
            }
           
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            fAdmin a = new fAdmin();
            this.Hide();
            
            //animationTable.ShowSync(a);
           
            a.ShowDialog();
            this.Show();
        }

        private void btnInformation_Click(object sender, EventArgs e)
        {
            if (pnMenu.Width == 250)
            {
                ptbLogo.Visible = false;
                pnMenu.Visible = false;
                pnMenu.Width = 45;

                btnMenu.Location = new Point(10, 19);
                animationMenuClose.ShowSync(pnMenu);
                anmationLogo.ShowSync(btnMenu);

            }
            animationTable.Hide(pnTable);
            //pnAcount.BringToFront();
        }

        #region Events

        private void Btn_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as Table).ID;
            lsvBill.Tag = (sender as Button).Tag;
            ShowBill(tableID);
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
        }
        #endregion
    }
}
