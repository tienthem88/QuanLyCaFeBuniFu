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
    public partial class ucThucAn : UserControl
    {
        BindingSource foodlist = new BindingSource();
        public Account loginAccount;
        public ucThucAn()
        {
            InitializeComponent();
            Load();
        }

        void Load()
        {
            dtgvFood.DataSource = foodlist;
            LoadListFood();
            AddFoodBinding();
            LoadCategoryIntoCombobox(cbCategoryFood);
        }

        void LoadListFood()
        {
            foodlist.DataSource = FoodDAO.Instance.GetListFood();
        }

        void AddFoodBinding()
        {
            //string x = tbxIDFood.text;
            tbxFoodName.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "Name"));
            //tbxIDFood.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "ID"));
            tbxTemp.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "ID"));
            tbxIDFood.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "ID"));
            tbxPriceFood.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "Price"));
            //string y = tbxIDFood.text;

           


        }

        void LoadCategoryIntoCombobox(ComboBox cb)
        {
            cb.DataSource = CategoryDAO.Instance.GetListCategory();
            cb.DisplayMember = "Name";
        }

        private void setResetFood()
        {
            tbxIDFood.ResetText();
            tbxFoodName.ResetText();
            tbxPriceFood.ResetText();
        }

        public bool CheckDataFood()
        {
            if (tbxFoodName.text == "" || tbxPriceFood.text == "")
            {
                MessageBox.Show("Bạn nhập dữ liệu chưa đủ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else return true;


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

        private void btnShowFood_MouseMove(object sender, MouseEventArgs e)
        {
            lbDisplay.Text = "Xem";
            lbDisplay.Visible = true;
            lbDisplay.Location = new Point(74, 21);
        }

        private void btnAddFood_MouseMove(object sender, MouseEventArgs e)
        {
            lbDisplay.Text = "Thêm";
            lbDisplay.Visible = true;
            lbDisplay.Location = new Point(74, 126);

           
        }

       

        private void btnDeleteFood_MouseMove(object sender, MouseEventArgs e)
        {
            lbDisplay.Text = "Xoá";
            lbDisplay.Visible = true;
            lbDisplay.Location = new Point(74, 368);

           
        }

        private void btnFixFood_MouseMove(object sender, MouseEventArgs e)
        {
            lbDisplay.Text = "Sửa";
            lbDisplay.Visible = true;
            lbDisplay.Location = new Point(74, 249);

           
        }

        private void btnFindFood_Click(object sender, EventArgs e)
        {
            foodlist.DataSource = SearchFoodByName(cbFoodFind.Text);
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

        private void btnShowFood_Click(object sender, EventArgs e)
        {
            LoadListFood();
        }

        private void btnAddFood_Click(object sender, EventArgs e)
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
    }
}
