using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;

namespace QuanLyQuanCaFe
{
    public partial class fTableManager : Form
    {
        public fTableManager()
        {
            InitializeComponent();
        }

      


        private void ptbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if(pnMenu.Width==45)
            {
                pnMenu.Visible = false;
                pnMenu.Width = 250;
                btnMenu.Location = new Point(210, 19);
                pnMenu.BringToFront();
                animationMenuOpen.ShowSync(pnMenu);
                anmationLogo.ShowSync(btnMenu);
                ptbLogo.Visible = true;


            }
            else
            {
                ptbLogo.Visible = false;
                pnMenu.Visible = false;
                pnMenu.Width = 45;
               
                btnMenu.Location = new Point(10, 19);
                animationMenuClose.ShowSync(pnMenu);
                anmationLogo.ShowSync(btnMenu);

            }
        }

        private void btnTable_Click(object sender, EventArgs e)
        {

            if (pnTable.Visible == false)
            {
                if(pnMenu.Width == 250)
                {
                    ptbLogo.Visible = false;
                    pnMenu.Visible = false;
                    pnMenu.Width = 45;
                    
                    btnMenu.Location = new Point(10, 19);
                    animationMenuClose.ShowSync(pnMenu);
                    anmationLogo.ShowSync(btnMenu);

                }
                pnTable.BringToFront();
                animationTable.ShowSync(pnTable);
               
            }
           
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            fAdmin a = new fAdmin();
            this.Hide();
            
            //animationTable.ShowSync(a);
           
            a.ShowDialog();
            this.Show();
        }

        private void btnInformation_Click(object sender, EventArgs e)
        {
            
            animationTable.Hide(pnTable);
            //pnAcount.BringToFront();
        }
    }
}
