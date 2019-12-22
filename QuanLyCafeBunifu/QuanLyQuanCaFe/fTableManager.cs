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
        public Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccountAdmin(loginAccount.Type); }
        }



        public fTableManager(Account acc)
        {
            InitializeComponent();

            this.LoginAccount = acc;
            pnTheme.Controls.Clear();
            ucTable uctable = new ucTable();
            uctable.Dock = DockStyle.Fill;
            pnTheme.Controls.Add(uctable);


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

        #endregion



        #region Events
        private void ptbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (pnMenu.Width == 45)
            {
                
                pnMenu.Visible = false;
                pnMenu.Width = 250;
                btnMenu.Location = new Point(210, 19);
                pnMenu.BringToFront();
                animationMenuOpen.ShowSync(pnMenu);
                anmationLogo.ShowSync(btnMenu);
                ptbLogo.Visible = true;
                pnTheme.Location = new Point(46, 42);

            }
            else
            {
                
                ptbLogo.Visible = false;
                pnMenu.Visible = false;
                pnMenu.Width = 45;

                btnMenu.Location = new Point(10, 19);
                animationMenuClose.ShowSync(pnMenu);
                anmationLogo.ShowSync(btnMenu);
                pnTheme.Location = new Point(46, 42);

            }

        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            pnTheme.Location = new Point(46, 42);
            pnTheme.Controls.Clear();
            ucTable uctable = new ucTable();
            uctable.Dock = DockStyle.Fill;
            uctable.Visible = false;
            pnTheme.Controls.Add(uctable);

            animationTable.ShowSync(uctable);
            

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            fAdmin a = new fAdmin();
            a.loginAccount = LoginAccount;
            this.Hide();
            a.ShowDialog();
            this.Show();

        }

        private void btnInformation_Click(object sender, EventArgs e)
        {
            
            pnTheme.Controls.Clear();
            ucAcount ucAcount = new ucAcount();
            ucAcount.LoginAccount = LoginAccount;
            ucAcount.Dock = DockStyle.Fill;

            ucAcount.Visible = false;
            pnTheme.Controls.Add(ucAcount);

            animationTable.ShowSync(ucAcount);
            

        }

        #endregion





    }
}
