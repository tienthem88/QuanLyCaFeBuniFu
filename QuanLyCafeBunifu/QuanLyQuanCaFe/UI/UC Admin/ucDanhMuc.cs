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
    public partial class ucDanhMuc : UserControl
    {
        BindingSource categoryList = new BindingSource();
        public Account loginAccount;
        public ucDanhMuc()
        {
            InitializeComponent();
            Load();
        }


        void Load()
        {
            dtgvCategory.DataSource = categoryList;
            ShowAllCategory();
            AddCategoryBinding();

        }




        private void setResetCategory()
        {
            tbxIDType.ResetText();
            tbxTypeName.ResetText();
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

        public void ShowAllCategory()
        {
            categoryList.DataSource = CategoryDAO.Instance.GetAllCategory();
        }

        List<Category> SearchCategoryByName(string name)
        {
            List<Category> listCategory = CategoryDAO.Instance.SearchCategoryByName(name);

            return listCategory;
        }

      

        private void btnFindCategory_Click(object sender, EventArgs e)
        {
            categoryList.DataSource = SearchCategoryByName(cbCategoryFind.Text);
        }

        private void btnShowCategory_Click(object sender, EventArgs e)
        {
            ShowAllCategory();
        }

        void AddCategoryBinding()
        {
            //string x = tbxIDFood.text;
            tbxTypeName.DataBindings.Add(new Binding("Text", dtgvCategory.DataSource, "Name"));
            tbxIDType.DataBindings.Add(new Binding("Text", dtgvCategory.DataSource, "ID"));
            
            
            //string y = tbxIDFood.text;

           

        }


        private void dtgvCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                tbxIDType.text = dtgvCategory.Rows[index].Cells["id"].Value.ToString();
                tbxTypeName.text = dtgvCategory.Rows[index].Cells["name"].Value.ToString();
            }
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            if (CheckDataCategory())
            {
                string Name = tbxTypeName.text;

                if (CategoryDAO.Instance.insertCategory(Name))
                {
                    ShowAllCategory();
                    setResetCategory();
                    
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
                //LoadCategoryIntoComboBox(cbCategoryFood);
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
                //LoadCategoryIntoComboBox(cbCategoryFood);
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra xin thử lại sau!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnShowCategory_MouseMove(object sender, MouseEventArgs e)
        {
            lbDisplay.Text = "Xem";
            lbDisplay.Visible = true;
            lbDisplay.Location = new Point(74, 21);
        }

        private void btnAddCategory_MouseMove(object sender, MouseEventArgs e)
        {
            lbDisplay.Text = "Thêm";
            lbDisplay.Visible = true;
            lbDisplay.Location = new Point(74, 126);
        }

        private void btnFixCategory_MouseMove(object sender, MouseEventArgs e)
        {
            lbDisplay.Text = "Sửa";
            lbDisplay.Visible = true;
            lbDisplay.Location = new Point(74, 249);
        }

        private void btnDeleteCategory_MouseMove(object sender, MouseEventArgs e)
        {
            lbDisplay.Text = "Xoá";
            lbDisplay.Visible = true;
            lbDisplay.Location = new Point(74, 368);
        }
    }
}
