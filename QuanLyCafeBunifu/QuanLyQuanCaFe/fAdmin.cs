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
        public fAdmin()
        {
            InitializeComponent();
        }

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
    }
}
