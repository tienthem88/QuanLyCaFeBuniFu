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

        public static int checktemp=0;

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
        private void ptbExit_Click_1(object sender, EventArgs e)
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
                pnTheme.Location = new Point(46, 36);
                btnTable.Location = new Point(12, 200);
                btnInformation.Location = new Point(12, 270);
                btnAdmin.Location = new Point(12, 340);
                Sperate.Visible = true;
                ptbLogo.Location = new Point(49, 19);
                ptbLogo.Size = new Size(146, 141);
                ptbxLogoMini.Visible = false;

            }
            else
            {
                Sperate.Visible = false;
                ptbLogo.Visible = false;
                pnMenu.Visible = false;
                pnMenu.Width = 45;
                btnTable.Location = new Point(0, 200);
                btnInformation.Location = new Point(0, 270);
                btnAdmin.Location = new Point(0, 340);
                btnMenu.Location = new Point(10, 19);
                animationMenuClose.ShowSync(pnMenu);
                anmationLogo.ShowSync(btnMenu);
                pnTheme.Location = new Point(46, 36);
                ptbxLogoMini.Visible = true;



            }

        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            setSelectForecolor((Bunifu.Framework.UI.BunifuFlatButton)sender);
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
            setSelectForecolor((Bunifu.Framework.UI.BunifuFlatButton)sender);
            fAdmin a = new fAdmin();
            a.loginAccount = LoginAccount;
            this.Hide();
            a.ShowDialog();
            this.Show();
            


        }

       
        void setSelectForecolor(Bunifu.Framework.UI.BunifuFlatButton sender)
        {

            btnTable.selected = false;
            btnInformation.selected = false;
            btnAdmin.selected = false;
            btnTable.Textcolor = Color.DimGray;
            btnInformation.Textcolor = Color.DimGray;
            btnAdmin.Textcolor = Color.DimGray;
            sender.selected = true;
            sender.Textcolor = Color.White;

        }

        private void btnInformation_Click(object sender, EventArgs e)
        {
            setSelectForecolor((Bunifu.Framework.UI.BunifuFlatButton)sender);
            pnTheme.Controls.Clear();
            ucAcount ucAcount = new ucAcount();
            ucAcount.LoginAccount = LoginAccount;
            ucAcount.Dock = DockStyle.Fill;

            ucAcount.Visible = false;
            pnTheme.Controls.Add(ucAcount);

            animationTable.ShowSync(ucAcount);
            

        }






        #endregion

        private void pnTheme_MouseMove(object sender, MouseEventArgs e)
        {
            if(checktemp==1)
            {
                Sperate.Visible = false;
                ptbLogo.Visible = false;
                pnMenu.Visible = false;
                pnMenu.Width = 45;
                btnTable.Location = new Point(0, 200);
                btnInformation.Location = new Point(0, 270);
                btnAdmin.Location = new Point(0, 340);
                btnMenu.Location = new Point(10, 19);
                animationMenuClose.ShowSync(pnMenu);
                anmationLogo.ShowSync(btnMenu);
                pnTheme.Location = new Point(46, 36);
                ptbxLogoMini.Visible = true;
            }
        }
    }
}
