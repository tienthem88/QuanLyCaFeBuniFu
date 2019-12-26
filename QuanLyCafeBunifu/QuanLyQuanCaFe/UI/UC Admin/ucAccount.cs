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

namespace QuanLyQuanCaFe.UI.UC_Admin
{
    public partial class ucAccount : UserControl
    {

        BindingSource accountList = new BindingSource();
        public Account loginAccount;
        public ucAccount()
        {
            InitializeComponent();
            Load();
        }

        void Load()
        {
            dtgvAccount.DataSource = accountList;
            LoadAccount();
            AddAccountBinding();
        }

        private void setResetAccount()
        {
            tbxNameAcount.ResetText();
            tbxDisplayAcount.ResetText();
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

        private void btnShowAccount_Click(object sender, EventArgs e)
        {
            LoadAccount();
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

        private void ResetPassword_Click(object sender, EventArgs e)
        {
            string userName = tbxNameAcount.text;
            ResetPass(userName);
        }

        private void btnShowAccount_MouseMove(object sender, MouseEventArgs e)
        {
            lbDisplay.Text = "Xem";
            lbDisplay.Visible = true;
            lbDisplay.Location = new Point(74, 21);
        }

        private void btnAddAccount_MouseMove(object sender, MouseEventArgs e)
        {
            lbDisplay.Text = "Thêm";
            lbDisplay.Visible = true;
            lbDisplay.Location = new Point(74, 126);
        }

        private void btnFixAccount_MouseMove(object sender, MouseEventArgs e)
        {
            lbDisplay.Text = "Sửa";
            lbDisplay.Visible = true;
            lbDisplay.Location = new Point(74, 249);
        }

        private void btnDeleteAccount_MouseMove(object sender, MouseEventArgs e)
        {
            lbDisplay.Text = "Xoá";
            lbDisplay.Visible = true;
            lbDisplay.Location = new Point(74, 368);
        }
    }
}
