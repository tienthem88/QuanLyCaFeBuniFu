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

namespace QuanLyQuanCaFe
{
    public partial class ucAcount : UserControl
    {
        public ucAcount()
        {
            InitializeComponent();
        }

        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value;  ChangeAccount(loginAccount.Type); }
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

            if (!newpass.Equals(repass))
            {
                MessageBox.Show("Vui lòng nhập lại mật khẩu đúng với mật khẩu mới!");

            }
            else
            {
                if (AccountDAO.Instance.UpdateAccount(userName, displayName, password, newpass))
                {
                    MessageBox.Show("Cập nhật thành công");
                }
                else
                {
                    MessageBox.Show("Vui lòng điền đúng mật khẩu");
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateAccount();
        }

        private void btnExitAcount_Click(object sender, EventArgs e)
        {
            fTableManager.ActiveForm.Close();
        }
    }
}
