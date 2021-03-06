﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyQuanCaFe.DAO;
using QuanLyQuanCaFe.DTO;
using Menu = QuanLyQuanCaFe.DTO.Menu;
using System.Globalization;

namespace QuanLyQuanCaFe
{
    public partial class ucTable : UserControl
    {
        
        public ucTable()
        {
            InitializeComponent();
            LoadTable();
            LoadCategory();
            LoadComboboxTable(cbChuyenban);
           
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




        void LoadComboboxTable(ComboBox cb)
        {
            cb.DataSource = TableDAO.Instance.LoadTableList();
            cb.DisplayMember = "Name";

        }

        void LoadTable()
        {

            flpTable.Controls.Clear();
            //if (pnMenu.Width == 250)
            //    pnTable.Location = new Point(250, 49);
            Bitmap bitmap = new Bitmap(Application.StartupPath + @"\image\btnTable.png");
            Bitmap bitmap1 = new Bitmap(Application.StartupPath + @"\image\btnTable12.png");
            List<DTO.Table> tableList = TableDAO.Instance.LoadTableList();
            foreach (DTO.Table item in tableList)
            {
                Button btn = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight };
                btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
                btn.BackgroundImage = bitmap;
                btn.UseVisualStyleBackColor = false;
                btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
                btn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
                btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                btn.Text = "                             " + item.Name + Environment.NewLine + " " + item.Status;
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

        #endregion

        #region even

        private void Btn_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as DTO.Table).ID;
            lsvBill.Tag = (sender as Button).Tag;
            ShowBill(tableID);
            

        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            DTO.Table table = lsvBill.Tag as DTO.Table;

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

        private void btnThanhtoan_Click(object sender, EventArgs e)
        {
            DTO.Table table = lsvBill.Tag as DTO.Table;

            int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.ID);
            int discount = (int)nmDiscount.Value;

            double totalPrice = Convert.ToDouble(tbxTotalPrice.Text.Split(',')[0]) * 1000;
            double finaltotalprice = totalPrice - (totalPrice / 100) * discount;

            if (idBill != -1)
            {
                if (MessageBox.Show(string.Format("Bạn có chắc thanh toán hoá đơn cho bàn {0}\n Tổng tiền - (Tổng tiền / 100) x Giảm giá = {1} - ({1} / 100 x {2}) = {3}", table.Name, totalPrice, discount, finaltotalprice), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    BillDAO.Instance.CheckOut(idBill, discount, (float)finaltotalprice);
                    ShowBill(table.ID);
                }
            }

            LoadTable();
        }

        private void btnChuyenban_Click(object sender, EventArgs e)
        {
            int id1 = (lsvBill.Tag as DTO.Table).ID;

            int id2 = (cbChuyenban.SelectedItem as DTO.Table).ID;

            if (MessageBox.Show(string.Format("Bạn có thật sự muốn chuyển bàn {0} qua bàn {1}", (lsvBill.Tag as DTO.Table).Name, (cbChuyenban.SelectedItem as DTO.Table).Name), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                TableDAO.Instance.SwitchTable(id1, id2);

                LoadTable();
            }
        }



        #endregion

        private void flpTable_MouseClick(object sender, MouseEventArgs e)
        {
            //fTableManager.checktemp = 1;
        }

        private void ucTable_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Shift)
            {
                if (e.KeyCode.Equals(Keys.A))
                {
                    btnThem_Click(this, new EventArgs());
                }
                if (e.KeyCode.Equals(Keys.T))
                {
                    btnThanhtoan_Click(this, new EventArgs());
                }

            }
        }

        private void btnXoaMon_Click(object sender, EventArgs e)
        {
            DTO.Table table = lsvBill.Tag as DTO.Table;

            int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.ID);
            int foodID = (cbFood.SelectedItem as Food).ID;
            int count = (int)nmFoodCount.Value;


            BillInfoDAO.Instance.InsertBillInfo(idBill, foodID, -1);



            ShowBill(table.ID);
            LoadTable();
        }
    }
}
