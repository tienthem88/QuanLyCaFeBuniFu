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
    public partial class ucBanAn : UserControl
    {
        BindingSource tableList = new BindingSource();
        public Account loginAccount;

        public ucBanAn()
        {
            InitializeComponent();
            Load();
        }

        void Load()
        {
            dtgvTable.DataSource = tableList;
            ShowAllTable();
            AddTableBinding();
           
        }

        private void setResetTable()
        {
            tbxIDTable.ResetText();
            tbxTableName.ResetText();
        }

        public void ShowAllTable()
        {
            tableList.DataSource = TableDAO.Instance.GetTableList();
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

       
        List<DTO.Table> SearchTableByName(string name)
        {
            List<DTO.Table> listTable = TableDAO.Instance.SearchTableByName(name);
            return listTable;
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





        

       

        private void btnFindTable_Click(object sender, EventArgs e)
        {
            tableList.DataSource = SearchTableByName(cbTableFind.Text);
        }

        private void btnShowTable_Click(object sender, EventArgs e)
        {
            ShowAllTable();
        }

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

        private void btnShowTable_MouseMove(object sender, MouseEventArgs e)
        {
            lbDisplay.Text = "Xem";
            lbDisplay.Visible = true;
            lbDisplay.Location = new Point(74, 21);
        }

        private void btnAddTable_MouseMove(object sender, MouseEventArgs e)
        {
            lbDisplay.Text = "Thêm";
            lbDisplay.Visible = true;
            lbDisplay.Location = new Point(74, 126);
        }

        private void btnFixTable_MouseMove(object sender, MouseEventArgs e)
        {
            lbDisplay.Text = "Sửa";
            lbDisplay.Visible = true;
            lbDisplay.Location = new Point(74, 249);
        }

       
        private void btnDeleteTable_MouseMove(object sender, MouseEventArgs e)
        {
            lbDisplay.Text = "Xoá";
            lbDisplay.Visible = true;
            lbDisplay.Location = new Point(74, 368);
        }
    }
}
