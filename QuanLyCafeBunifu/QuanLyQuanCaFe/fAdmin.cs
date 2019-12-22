using QuanLyQuanCafe.DAO;
using QuanLyQuanCaFe.DAO;
using QuanLyQuanCaFe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCaFe
{
    public partial class fAdmin : Form
    {
        BindingSource foodlist = new BindingSource();
        BindingSource tableList = new BindingSource();
        BindingSource accountList = new BindingSource();
        BindingSource categoryList = new BindingSource();
        public Account loginAccount;

        public fAdmin()
        {
            InitializeComponent();

            Load();
            
            
        }

        #region Themes

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (pnMenu.Width == 45)
            {
                tcadmin.Location = new Point(253, 55);
                tcadmin.Size = new Size(737, 479);
                pnMenu.Visible = false;
                pnMenu.Width = 250;
                btnMenu.Location = new Point(210, 19);
                animationMenuOpen.ShowSync(pnMenu);
                anmationLogo.ShowSync(btnMenu);
                ptbLogo.Visible = true;
               


            }
            else
            {
                tcadmin.Location = new Point(46, 55);
                tcadmin.Size = new Size(944, 482);
                ptbLogo.Visible = false;
                pnMenu.Visible = false;
                pnMenu.Width = 45;
                
               
                btnMenu.Location = new Point(10, 19);
                animationMenuClose.ShowSync(pnMenu);
                anmationLogo.ShowSync(btnMenu);

            }
        }

        private void ptbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDoanhthu_Click(object sender, EventArgs e)
        {
            tcadmin.SelectedTab = tcadmin.TabPages[0];
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            tcadmin.SelectedTab = tcadmin.TabPages[1];
        }

        private void btnInformation_Click(object sender, EventArgs e)
        {
            tcadmin.SelectedTab = tcadmin.TabPages[2];
        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            tcadmin.SelectedTab = tcadmin.TabPages[3];
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            tcadmin.SelectedTab = tcadmin.TabPages[4];
        }

        #endregion

        #region methods

        void Load()
        {
            dtgvFood.DataSource = foodlist;
            dtgvAccount.DataSource = accountList;
            dtgvTable.DataSource = tableList;
            dtgvCategory.DataSource = categoryList;
            LoadDateTimePickerBill();
            ShowAllCategory();
            ShowAllTable();
            LoadAccount();
            AddTableBinding();
            AddAccountBinding();
            LoadListBillDate(dtpkFromDate.Value, dtpkToDate.Value);
            LoadListFood();
            AddFoodBinding();
            LoadCategoryIntoCombobox(cbCategoryFood);
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

        //void LoadAccount()
        //{
        //    accountList.DataSource = AccountDAO.Instance.GetListAccount();
        //}

        void LoadListFood()
        {
            foodlist.DataSource = FoodDAO.Instance.GetListFood();
        }

        void AddFoodBinding()
        {
            //string x = tbxIDFood.text;
            tbxFoodName.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "Name"));
            tbxIDFood.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "ID"));
            tbxTemp.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "ID"));
            tbxPriceFood.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "Price"));
            //string y = tbxIDFood.text;

            if (dtgvFood.SelectedCells.Count > 0)
            {
                int id = (int)dtgvFood.SelectedCells[0].OwningRow.Cells["CategoryID"].Value;

                Category category = CategoryDAO.Instance.GetCategoryByID(id);

                cbCategoryFood.SelectedItem = category;

                int index = -1;
                int i = 0;
                foreach (Category item in cbCategoryFood.Items)
                {
                    if (item.ID == category.ID)
                    {
                        index = i;
                        break;
                    }
                    i++;
                }

                cbCategoryFood.SelectedIndex = index;
            }


        }

        void LoadCategoryIntoCombobox(ComboBox cb)
        {
            cb.DataSource = CategoryDAO.Instance.GetListCategory();
            cb.DisplayMember = "Name";
        }


        #endregion
        
        #region eventsBTN
        private void btnThongke_Click(object sender, EventArgs e)
        {
            LoadListBillDate(dtpkFromDate.Value, dtpkToDate.Value);
        }

         private void btnShowFood_Click(object sender, EventArgs e)
        {
            LoadListFood();
        }

        private void tbxIDFood_BindingContextChanged(object sender, EventArgs e)
        {
           
        }

        private void tbxTemp_TextChanged(object sender, EventArgs e)
        {
            if (dtgvFood.SelectedCells.Count > 0)
            {
                int id = (int)dtgvFood.SelectedCells[0].OwningRow.Cells["CategoryID"].Value;

                Category category = CategoryDAO.Instance.GetCategoryByID(id);

                cbCategoryFood.SelectedItem = category;

                int index = -1;
                int i = 0;
                foreach (Category item in cbCategoryFood.Items)
                {
                    if (item.ID == category.ID)
                    {
                        index = i;
                        break;
                    }
                    i++;
                }

                cbCategoryFood.SelectedIndex = index;
            }
        }
        #endregion


        #region reset_textbox
        private void setResetFood()
        {
            tbxIDFood.ResetText();
            tbxFoodName.ResetText();
            tbxPriceFood.ResetText();
        }
        private void setResetCategory()
        {
            tbxIDType.ResetText();
            tbxTypeName.ResetText();
        }
        private void setResetTable()
        {
            tbxIDTable.ResetText();
            tbxTableName.ResetText();
        }
        private void setResetAccount()
        {
            tbxNameAcount.ResetText();
            tbxDisplayAcount.ResetText();
        }
        #endregion
        #region  Check_Data
        public bool CheckDataFood()
        {
            if (tbxFoodName.text == "" || tbxPriceFood.text == "")
            {
                MessageBox.Show("Bạn nhập dữ liệu chưa đủ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else return true;


        }
        public bool CheckDataCategory()
        {
            if (tbxTypeName.text == "")
            {
                MessageBox.Show("Bạn nhập dữ liệu chưa đủ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else return true;
        }
        public bool CheckDataTable()
        {
            if (tbxTableName.text == "")
            {
                MessageBox.Show("Bạn nhập dữ liệu chưa đủ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else return true;
        }
        public bool CheckDataAccount()
        {
            if (tbxNameAcount.text == "" || tbxDisplayAcount.text == "")
            {
                MessageBox.Show("Bạn nhập dữ liệu chưa đủ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else return true;

        }

        #endregion
        #region Food
       
        private void btnFindFood_Click_1(object sender, EventArgs e)
        {
            foodlist.DataSource = SearchFoodByName(cbFoodFind.Text);
        }
        List<Food> SearchFoodByName(string name)
        {
            List<Food> listFood = FoodDAO.Instance.SearchFoodByName(name);

            return listFood;
        }
        public void ShowAllFood()
        {
            foodlist.DataSource = FoodDAO.Instance.GetListFood();
        }
        private void btnFood_Click(object sender, EventArgs e)
        {
            tcadmin.SelectedTab = tcadmin.TabPages[1];
        }
        void LoadCategoryIntoComboBox(ComboBox cb)
        {
            cb.DataSource = CategoryDAO.Instance.GetListCategory();
            cb.DisplayMember = "name";
        }

        private void DGFood_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
       
      
        private event EventHandler insertFood;
        public event EventHandler InsertFood
        {
            add { insertFood += value; }
            remove { insertFood -= value; }
        }

        private event EventHandler deleteFood;
        public event EventHandler DeleteFood
        {
            add { deleteFood += value; }
            remove { deleteFood -= value; }
        }

        private event EventHandler updateFood;
        public event EventHandler UpdateFood
        {
            add { updateFood += value; }
            remove { updateFood -= value; }
        }



        #endregion
        #region Category
        public void ShowAllCategory()
        {
            categoryList.DataSource = CategoryDAO.Instance.GetAllCategory();
        }
        private void btnCategory_Click(object sender, EventArgs e)
        {
            tcadmin.SelectedTab = tcadmin.TabPages[2];
        }
        private void DGCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                tbxIDType.text = dtgvCategory.Rows[index].Cells["id"].Value.ToString();
                tbxTypeName.text = dtgvCategory.Rows[index].Cells["name"].Value.ToString();
            }
        }
        private void btnShowCategory_Click(object sender, EventArgs e)
        {
            ShowAllCategory();
        }
       
        #endregion
        #region Table
        public void ShowAllTable()
        {
            tableList.DataSource = TableDAO.Instance.GetTableList();
        }

        private void btnShowAllTable_Click(object sender, EventArgs e)
        {
            ShowAllTable();
        }
        void LoadStatusIntoComboBox(ComboBox cb)
        {
            cb.DataSource = TableDAO.Instance.GetTableList();
            cb.DisplayMember = "status";
        }
        void AddTableBinding()
        {
            tbxIDTable.DataBindings.Add(new Binding("text", dtgvTable.DataSource, "id", true, DataSourceUpdateMode.Never));
            tbxTableName.DataBindings.Add(new Binding("text", dtgvTable.DataSource, "name", true, DataSourceUpdateMode.Never));
            dmStatus.DataBindings.Add(new Binding("text", dtgvTable.DataSource, "status", true, DataSourceUpdateMode.Never));

        }
      
        private void BtnFineTable_Click(object sender, EventArgs e)
        {
            tableList.DataSource = SearchTableByName(cbFoodFind.Text);
        }
        List<DTO.Table> SearchTableByName(string name)
        {
            List<DTO.Table> listTable = TableDAO.Instance.SearchTableByName(name);
            return listTable;
        }
       
        #endregion
        #region Account
       
        void AddAccountBinding()
        {
            tbxNameAcount.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "UserName", true, DataSourceUpdateMode.Never));
            tbxDisplayAcount.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "DisplayName", true, DataSourceUpdateMode.Never));
            numericUpDown1.DataBindings.Add(new Binding("Value", dtgvAccount.DataSource, "Type", true, DataSourceUpdateMode.Never));
        }
        public void LoadAccount()
        {
            accountList.DataSource = AccountDAO.Instance.GetListAccount();
        }
        private void btnShowAllAcount_Click(object sender, EventArgs e)
        {
            LoadAccount();
        }
        #endregion
        #region Insert_Update_Delete_Food
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (CheckDataFood())
            {
                string Name = tbxFoodName.text;
                int CategoryID = (cbCategoryFood.SelectedItem as Category).ID;
                float price = float.Parse(tbxPriceFood.text);
                if (FoodDAO.Instance.InsertFood(Name, CategoryID, price))
                {
                    ShowAllFood();
                    MessageBox.Show("Đã thêm thành công", "Thông báo");
                    if (insertFood != null)
                        insertFood(this, new EventArgs());

                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra xin thử lại sau!", "Thông báo lỗi");
                }
            }
        }

        private void btnFixFood_Click(object sender, EventArgs e)
        {
            if (CheckDataFood())
            {

                int ID = int.Parse(tbxIDFood.text);
                string Name = tbxFoodName.text;
                int CategoryID = (cbCategoryFood.SelectedItem as Category).ID;
                float price = float.Parse(tbxPriceFood.text);
                if (FoodDAO.Instance.UpdateFood(ID, Name, CategoryID, price))
                {
                    ShowAllFood();
                    MessageBox.Show("Đã sửa thành công");
                    if (updateFood != null)
                        updateFood(this, new EventArgs());
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra xin thử lại sau!");
                }
            }
        }

        private void btnDeleteFood_Click(object sender, EventArgs e)
        {
            if (CheckDataFood())
            {
                int ID = int.Parse(tbxIDFood.text);
                if (FoodDAO.Instance.DeleteFood(ID))
                {
                    ShowAllFood();
                    MessageBox.Show("Đã xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (deleteFood != null)
                        deleteFood(this, new EventArgs());

                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra xin thử lại sau!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }




        #endregion
        #region Insert_Update_Delete_Category

                private void btnAddCategory_Click(object sender, EventArgs e)
                {
                    if (CheckDataCategory())
                    {
                        string Name = tbxTypeName.text;

                        if (CategoryDAO.Instance.insertCategory(Name))
                        {
                            ShowAllCategory();
                            setResetCategory();
                            LoadCategoryIntoComboBox(cbCategoryFood);
                            MessageBox.Show("Đã thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Đã có lỗi xảy ra xin thử lại sau!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

                private void btnFixCategory_Click(object sender, EventArgs e)
                {
                    int ID = int.Parse(tbxIDType.text);
                    string Name = tbxTypeName.text;
                    if (CategoryDAO.Instance.UpdateCategory(ID, Name))
                    {
                        ShowAllCategory();
                        LoadCategoryIntoComboBox(cbCategoryFood);
                        MessageBox.Show("Đã sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Đã có lỗi xảy ra xin thử lại sau!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                private void btnDeleteCategory_Click(object sender, EventArgs e)
                {
                    int ID = int.Parse(tbxIDType.text);
                    string Name = tbxTypeName.text;
                    if (CategoryDAO.Instance.DeleteCategory(ID))
                    {
                        ShowAllCategory();
                        MessageBox.Show("Đã xoá thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadCategoryIntoComboBox(cbCategoryFood);
                    }
                    else
                    {
                        MessageBox.Show("Đã có lỗi xảy ra xin thử lại sau!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                #endregion
        #region Insert_Update_Delete_Table

        private void btnAddTable_Click(object sender, EventArgs e)
        {
            if (CheckDataTable())
            {

                string Name = tbxTableName.text.ToString();
                string Status = dmStatus.Text;
                if (TableDAO.Instance.InsertTable(Name, Status))
                {
                    ShowAllTable();
                    setResetTable();
                    MessageBox.Show("Đã thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra xin thử lại sau!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnFixTable_Click(object sender, EventArgs e)
        {
            if (CheckDataTable())
            {

                int ID = int.Parse(tbxIDTable.text);
                string Name = tbxTableName.text;
                string Status = dmStatus.Text;
                if (TableDAO.Instance.UpdateTable(Name, Status, ID))
                {
                    ShowAllTable();
                    MessageBox.Show("Đã sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra xin thử lại sau!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDeleteTable_Click(object sender, EventArgs e)
        {
            if (CheckDataTable())
            {

                int ID = int.Parse(tbxIDTable.text);
                if (TableDAO.Instance.DeleteTable(ID))
                {
                    ShowAllTable();
                    MessageBox.Show("Đã xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra xin thử lại sau!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        #endregion
        #region Insert_Update_Delete_resetPassword_Account

        void AddAccount(string userName, string displayName, int type)
        {
            if (AccountDAO.Instance.InsertAccount(userName, displayName, type))
            {
                MessageBox.Show("Thêm tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Thêm tài khoản thất bại");
            }

            LoadAccount();
        }

        void EditAccount(string userName, string displayName, int type)
        {
            if (AccountDAO.Instance.UpdateAccount(userName, displayName, type))
            {
                MessageBox.Show("Cập nhật tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Cập nhật tài khoản thất bại");
            }

            LoadAccount();
        }

        void DeleteAccount(string userName)
        {
            if (loginAccount.UserName.Equals(userName))
            {
                MessageBox.Show("Vui lòng đừng xóa chính bạn chứ");
                return;
            }
            if (AccountDAO.Instance.DeleteAccount(userName))
            {
                MessageBox.Show("Xóa tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Xóa tài khoản thất bại");
            }

            LoadAccount();
        }

        void ResetPass(string userName)
        {
            if (AccountDAO.Instance.ResetPassword(userName))
            {
                MessageBox.Show("Đặt lại mật khẩu thành công");
            }
            else
            {
                MessageBox.Show("Đặt lại mật khẩu thất bại");
            }
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {

            if (CheckDataAccount())
            {
                
                string userName = tbxNameAcount.text;
                string displayName = tbxDisplayAcount.text;
                int type = (int)numericUpDown1.Value;

                AddAccount(userName, displayName, type);
            }
        }

        private void btnFixAccount_Click(object sender, EventArgs e)
        {
            string userName = tbxNameAcount.text;
            string displayName = tbxDisplayAcount.text;
            int type = (int)numericUpDown1.Value;
            EditAccount(userName, displayName, type);
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            string userName = tbxNameAcount.text;
            DeleteAccount(userName);
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            string userName = tbxNameAcount.text;
            ResetPass(userName);
        }


        #endregion

        
    }
}
