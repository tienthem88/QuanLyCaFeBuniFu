namespace QuanLyQuanCaFe
{
    partial class fAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation6 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation5 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation4 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fAdmin));
            this.head = new System.Windows.Forms.Panel();
            this.lbHeader = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pnMenu = new System.Windows.Forms.Panel();
            this.animationMenuOpen = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.tcadmin = new System.Windows.Forms.TabControl();
            this.tpDoanhthu = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.anmationLogo = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.animationMenuClose = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.btnAccount = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnTable = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnFood = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCatogery = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMenu = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnDoanhthu = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ptbLogo = new System.Windows.Forms.PictureBox();
            this.ptbExit = new System.Windows.Forms.PictureBox();
            this.ptbiconhead = new System.Windows.Forms.PictureBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.head.SuspendLayout();
            this.pnMenu.SuspendLayout();
            this.tcadmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbiconhead)).BeginInit();
            this.SuspendLayout();
            // 
            // head
            // 
            this.head.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.head.Controls.Add(this.ptbExit);
            this.head.Controls.Add(this.ptbiconhead);
            this.head.Controls.Add(this.lbHeader);
            this.head.Cursor = System.Windows.Forms.Cursors.Default;
            this.animationMenuOpen.SetDecoration(this.head, BunifuAnimatorNS.DecorationType.None);
            this.anmationLogo.SetDecoration(this.head, BunifuAnimatorNS.DecorationType.None);
            this.animationMenuClose.SetDecoration(this.head, BunifuAnimatorNS.DecorationType.None);
            this.head.Dock = System.Windows.Forms.DockStyle.Top;
            this.head.Location = new System.Drawing.Point(0, 0);
            this.head.Name = "head";
            this.head.Size = new System.Drawing.Size(990, 55);
            this.head.TabIndex = 2;
            // 
            // lbHeader
            // 
            this.lbHeader.AutoSize = true;
            this.animationMenuClose.SetDecoration(this.lbHeader, BunifuAnimatorNS.DecorationType.None);
            this.anmationLogo.SetDecoration(this.lbHeader, BunifuAnimatorNS.DecorationType.None);
            this.animationMenuOpen.SetDecoration(this.lbHeader, BunifuAnimatorNS.DecorationType.None);
            this.lbHeader.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.lbHeader.Location = new System.Drawing.Point(42, 12);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(242, 21);
            this.lbHeader.TabIndex = 2;
            this.lbHeader.Text = "Phần mềm Quản lý quán Cafe";
            // 
            // pnMenu
            // 
            this.pnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.pnMenu.Controls.Add(this.btnAccount);
            this.pnMenu.Controls.Add(this.btnTable);
            this.pnMenu.Controls.Add(this.btnFood);
            this.pnMenu.Controls.Add(this.btnCatogery);
            this.pnMenu.Controls.Add(this.btnMenu);
            this.pnMenu.Controls.Add(this.btnDoanhthu);
            this.pnMenu.Controls.Add(this.ptbLogo);
            this.animationMenuOpen.SetDecoration(this.pnMenu, BunifuAnimatorNS.DecorationType.None);
            this.anmationLogo.SetDecoration(this.pnMenu, BunifuAnimatorNS.DecorationType.None);
            this.animationMenuClose.SetDecoration(this.pnMenu, BunifuAnimatorNS.DecorationType.None);
            this.pnMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnMenu.Location = new System.Drawing.Point(0, 55);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(45, 482);
            this.pnMenu.TabIndex = 3;
            // 
            // animationMenuOpen
            // 
            this.animationMenuOpen.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.animationMenuOpen.Cursor = null;
            animation6.AnimateOnlyDifferences = true;
            animation6.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.BlindCoeff")));
            animation6.LeafCoeff = 0F;
            animation6.MaxTime = 1F;
            animation6.MinTime = 0F;
            animation6.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.MosaicCoeff")));
            animation6.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation6.MosaicShift")));
            animation6.MosaicSize = 0;
            animation6.Padding = new System.Windows.Forms.Padding(0);
            animation6.RotateCoeff = 0F;
            animation6.RotateLimit = 0F;
            animation6.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.ScaleCoeff")));
            animation6.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.SlideCoeff")));
            animation6.TimeCoeff = 0F;
            animation6.TransparencyCoeff = 0F;
            this.animationMenuOpen.DefaultAnimation = animation6;
            this.animationMenuOpen.Interval = 13;
            // 
            // tcadmin
            // 
            this.tcadmin.Controls.Add(this.tpDoanhthu);
            this.tcadmin.Controls.Add(this.tabPage1);
            this.tcadmin.Controls.Add(this.tabPage2);
            this.tcadmin.Controls.Add(this.tabPage3);
            this.tcadmin.Controls.Add(this.tabPage4);
            this.animationMenuOpen.SetDecoration(this.tcadmin, BunifuAnimatorNS.DecorationType.None);
            this.anmationLogo.SetDecoration(this.tcadmin, BunifuAnimatorNS.DecorationType.None);
            this.animationMenuClose.SetDecoration(this.tcadmin, BunifuAnimatorNS.DecorationType.None);
            this.tcadmin.Location = new System.Drawing.Point(46, 55);
            this.tcadmin.Name = "tcadmin";
            this.tcadmin.SelectedIndex = 0;
            this.tcadmin.Size = new System.Drawing.Size(944, 482);
            this.tcadmin.TabIndex = 4;
            // 
            // tpDoanhthu
            // 
            this.animationMenuClose.SetDecoration(this.tpDoanhthu, BunifuAnimatorNS.DecorationType.None);
            this.anmationLogo.SetDecoration(this.tpDoanhthu, BunifuAnimatorNS.DecorationType.None);
            this.animationMenuOpen.SetDecoration(this.tpDoanhthu, BunifuAnimatorNS.DecorationType.None);
            this.tpDoanhthu.Location = new System.Drawing.Point(4, 22);
            this.tpDoanhthu.Name = "tpDoanhthu";
            this.tpDoanhthu.Padding = new System.Windows.Forms.Padding(3);
            this.tpDoanhthu.Size = new System.Drawing.Size(936, 456);
            this.tpDoanhthu.TabIndex = 1;
            this.tpDoanhthu.Text = "Doanh thu";
            this.tpDoanhthu.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.animationMenuClose.SetDecoration(this.tabPage1, BunifuAnimatorNS.DecorationType.None);
            this.anmationLogo.SetDecoration(this.tabPage1, BunifuAnimatorNS.DecorationType.None);
            this.animationMenuOpen.SetDecoration(this.tabPage1, BunifuAnimatorNS.DecorationType.None);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(936, 456);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Thức ăn";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.animationMenuClose.SetDecoration(this.tabPage2, BunifuAnimatorNS.DecorationType.None);
            this.anmationLogo.SetDecoration(this.tabPage2, BunifuAnimatorNS.DecorationType.None);
            this.animationMenuOpen.SetDecoration(this.tabPage2, BunifuAnimatorNS.DecorationType.None);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(936, 456);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Doanh mục";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // anmationLogo
            // 
            this.anmationLogo.AnimationType = BunifuAnimatorNS.AnimationType.Scale;
            this.anmationLogo.Cursor = null;
            animation5.AnimateOnlyDifferences = true;
            animation5.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.BlindCoeff")));
            animation5.LeafCoeff = 0F;
            animation5.MaxTime = 1F;
            animation5.MinTime = 0F;
            animation5.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicCoeff")));
            animation5.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicShift")));
            animation5.MosaicSize = 0;
            animation5.Padding = new System.Windows.Forms.Padding(0);
            animation5.RotateCoeff = 0F;
            animation5.RotateLimit = 0F;
            animation5.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.ScaleCoeff")));
            animation5.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.SlideCoeff")));
            animation5.TimeCoeff = 0F;
            animation5.TransparencyCoeff = 0F;
            this.anmationLogo.DefaultAnimation = animation5;
            // 
            // animationMenuClose
            // 
            this.animationMenuClose.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.animationMenuClose.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 0;
            animation4.Padding = new System.Windows.Forms.Padding(0);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 0F;
            animation4.TransparencyCoeff = 1F;
            this.animationMenuClose.DefaultAnimation = animation4;
            this.animationMenuClose.Interval = 13;
            // 
            // btnAccount
            // 
            this.btnAccount.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAccount.BorderRadius = 0;
            this.btnAccount.ButtonText = "            Tài khoản";
            this.btnAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animationMenuClose.SetDecoration(this.btnAccount, BunifuAnimatorNS.DecorationType.None);
            this.anmationLogo.SetDecoration(this.btnAccount, BunifuAnimatorNS.DecorationType.None);
            this.animationMenuOpen.SetDecoration(this.btnAccount, BunifuAnimatorNS.DecorationType.None);
            this.btnAccount.DisabledColor = System.Drawing.Color.Gray;
            this.btnAccount.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAccount.Iconimage = global::QuanLyQuanCaFe.Properties.Resources.profile_silhouette_vector_21;
            this.btnAccount.Iconimage_right = null;
            this.btnAccount.Iconimage_right_Selected = null;
            this.btnAccount.Iconimage_Selected = null;
            this.btnAccount.IconMarginLeft = 0;
            this.btnAccount.IconMarginRight = 0;
            this.btnAccount.IconRightVisible = true;
            this.btnAccount.IconRightZoom = 0D;
            this.btnAccount.IconVisible = true;
            this.btnAccount.IconZoom = 50D;
            this.btnAccount.IsTab = true;
            this.btnAccount.Location = new System.Drawing.Point(0, 328);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnAccount.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnAccount.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnAccount.selected = false;
            this.btnAccount.Size = new System.Drawing.Size(253, 48);
            this.btnAccount.TabIndex = 7;
            this.btnAccount.Text = "            Tài khoản";
            this.btnAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccount.Textcolor = System.Drawing.Color.Silver;
            this.btnAccount.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // btnTable
            // 
            this.btnTable.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTable.BorderRadius = 0;
            this.btnTable.ButtonText = "             Bàn ăn";
            this.btnTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animationMenuClose.SetDecoration(this.btnTable, BunifuAnimatorNS.DecorationType.None);
            this.anmationLogo.SetDecoration(this.btnTable, BunifuAnimatorNS.DecorationType.None);
            this.animationMenuOpen.SetDecoration(this.btnTable, BunifuAnimatorNS.DecorationType.None);
            this.btnTable.DisabledColor = System.Drawing.Color.Gray;
            this.btnTable.Iconcolor = System.Drawing.Color.Transparent;
            this.btnTable.Iconimage = global::QuanLyQuanCaFe.Properties.Resources._159635_200;
            this.btnTable.Iconimage_right = null;
            this.btnTable.Iconimage_right_Selected = null;
            this.btnTable.Iconimage_Selected = null;
            this.btnTable.IconMarginLeft = 0;
            this.btnTable.IconMarginRight = 0;
            this.btnTable.IconRightVisible = true;
            this.btnTable.IconRightZoom = 0D;
            this.btnTable.IconVisible = true;
            this.btnTable.IconZoom = 50D;
            this.btnTable.IsTab = true;
            this.btnTable.Location = new System.Drawing.Point(0, 274);
            this.btnTable.Name = "btnTable";
            this.btnTable.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnTable.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnTable.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnTable.selected = false;
            this.btnTable.Size = new System.Drawing.Size(253, 48);
            this.btnTable.TabIndex = 6;
            this.btnTable.Text = "             Bàn ăn";
            this.btnTable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTable.Textcolor = System.Drawing.Color.Silver;
            this.btnTable.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTable.Click += new System.EventHandler(this.btnTable_Click);
            // 
            // btnFood
            // 
            this.btnFood.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnFood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnFood.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFood.BorderRadius = 0;
            this.btnFood.ButtonText = "             Thức ăn";
            this.btnFood.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animationMenuClose.SetDecoration(this.btnFood, BunifuAnimatorNS.DecorationType.None);
            this.anmationLogo.SetDecoration(this.btnFood, BunifuAnimatorNS.DecorationType.None);
            this.animationMenuOpen.SetDecoration(this.btnFood, BunifuAnimatorNS.DecorationType.None);
            this.btnFood.DisabledColor = System.Drawing.Color.Gray;
            this.btnFood.Iconcolor = System.Drawing.Color.Transparent;
            this.btnFood.Iconimage = global::QuanLyQuanCaFe.Properties.Resources.black_and_white_food_icon_png_5;
            this.btnFood.Iconimage_right = null;
            this.btnFood.Iconimage_right_Selected = null;
            this.btnFood.Iconimage_Selected = null;
            this.btnFood.IconMarginLeft = 0;
            this.btnFood.IconMarginRight = 0;
            this.btnFood.IconRightVisible = true;
            this.btnFood.IconRightZoom = 0D;
            this.btnFood.IconVisible = true;
            this.btnFood.IconZoom = 50D;
            this.btnFood.IsTab = true;
            this.btnFood.Location = new System.Drawing.Point(0, 166);
            this.btnFood.Name = "btnFood";
            this.btnFood.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnFood.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnFood.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnFood.selected = false;
            this.btnFood.Size = new System.Drawing.Size(250, 48);
            this.btnFood.TabIndex = 5;
            this.btnFood.Text = "             Thức ăn";
            this.btnFood.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFood.Textcolor = System.Drawing.Color.Silver;
            this.btnFood.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFood.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnCatogery
            // 
            this.btnCatogery.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnCatogery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnCatogery.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCatogery.BorderRadius = 0;
            this.btnCatogery.ButtonText = "             Doanh mục";
            this.btnCatogery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animationMenuClose.SetDecoration(this.btnCatogery, BunifuAnimatorNS.DecorationType.None);
            this.anmationLogo.SetDecoration(this.btnCatogery, BunifuAnimatorNS.DecorationType.None);
            this.animationMenuOpen.SetDecoration(this.btnCatogery, BunifuAnimatorNS.DecorationType.None);
            this.btnCatogery.DisabledColor = System.Drawing.Color.Gray;
            this.btnCatogery.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCatogery.Iconimage = global::QuanLyQuanCaFe.Properties.Resources._1041139_200;
            this.btnCatogery.Iconimage_right = null;
            this.btnCatogery.Iconimage_right_Selected = null;
            this.btnCatogery.Iconimage_Selected = null;
            this.btnCatogery.IconMarginLeft = 0;
            this.btnCatogery.IconMarginRight = 0;
            this.btnCatogery.IconRightVisible = true;
            this.btnCatogery.IconRightZoom = 0D;
            this.btnCatogery.IconVisible = true;
            this.btnCatogery.IconZoom = 50D;
            this.btnCatogery.IsTab = true;
            this.btnCatogery.Location = new System.Drawing.Point(0, 220);
            this.btnCatogery.Name = "btnCatogery";
            this.btnCatogery.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnCatogery.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnCatogery.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnCatogery.selected = false;
            this.btnCatogery.Size = new System.Drawing.Size(253, 48);
            this.btnCatogery.TabIndex = 4;
            this.btnCatogery.Text = "             Doanh mục";
            this.btnCatogery.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCatogery.Textcolor = System.Drawing.Color.Silver;
            this.btnCatogery.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCatogery.Click += new System.EventHandler(this.btnInformation_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.animationMenuOpen.SetDecoration(this.btnMenu, BunifuAnimatorNS.DecorationType.None);
            this.anmationLogo.SetDecoration(this.btnMenu, BunifuAnimatorNS.DecorationType.None);
            this.animationMenuClose.SetDecoration(this.btnMenu, BunifuAnimatorNS.DecorationType.None);
            this.btnMenu.Image = global::QuanLyQuanCaFe.Properties.Resources.mobile_nav_icon;
            this.btnMenu.ImageActive = null;
            this.btnMenu.Location = new System.Drawing.Point(10, 19);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(26, 23);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMenu.TabIndex = 3;
            this.btnMenu.TabStop = false;
            this.btnMenu.Zoom = 10;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnDoanhthu
            // 
            this.btnDoanhthu.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnDoanhthu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnDoanhthu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDoanhthu.BorderRadius = 0;
            this.btnDoanhthu.ButtonText = "             Doanh thu";
            this.btnDoanhthu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animationMenuClose.SetDecoration(this.btnDoanhthu, BunifuAnimatorNS.DecorationType.None);
            this.anmationLogo.SetDecoration(this.btnDoanhthu, BunifuAnimatorNS.DecorationType.None);
            this.animationMenuOpen.SetDecoration(this.btnDoanhthu, BunifuAnimatorNS.DecorationType.None);
            this.btnDoanhthu.DisabledColor = System.Drawing.Color.Gray;
            this.btnDoanhthu.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDoanhthu.Iconimage = global::QuanLyQuanCaFe.Properties.Resources._537_01_512;
            this.btnDoanhthu.Iconimage_right = null;
            this.btnDoanhthu.Iconimage_right_Selected = null;
            this.btnDoanhthu.Iconimage_Selected = null;
            this.btnDoanhthu.IconMarginLeft = 0;
            this.btnDoanhthu.IconMarginRight = 0;
            this.btnDoanhthu.IconRightVisible = true;
            this.btnDoanhthu.IconRightZoom = 0D;
            this.btnDoanhthu.IconVisible = true;
            this.btnDoanhthu.IconZoom = 50D;
            this.btnDoanhthu.IsTab = true;
            this.btnDoanhthu.Location = new System.Drawing.Point(0, 112);
            this.btnDoanhthu.Name = "btnDoanhthu";
            this.btnDoanhthu.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnDoanhthu.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnDoanhthu.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnDoanhthu.selected = true;
            this.btnDoanhthu.Size = new System.Drawing.Size(247, 48);
            this.btnDoanhthu.TabIndex = 2;
            this.btnDoanhthu.Text = "             Doanh thu";
            this.btnDoanhthu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoanhthu.Textcolor = System.Drawing.Color.Silver;
            this.btnDoanhthu.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoanhthu.Click += new System.EventHandler(this.btnDoanhthu_Click);
            // 
            // ptbLogo
            // 
            this.animationMenuClose.SetDecoration(this.ptbLogo, BunifuAnimatorNS.DecorationType.None);
            this.anmationLogo.SetDecoration(this.ptbLogo, BunifuAnimatorNS.DecorationType.None);
            this.animationMenuOpen.SetDecoration(this.ptbLogo, BunifuAnimatorNS.DecorationType.None);
            this.ptbLogo.Image = global::QuanLyQuanCaFe.Properties.Resources.logo1;
            this.ptbLogo.Location = new System.Drawing.Point(22, 19);
            this.ptbLogo.Name = "ptbLogo";
            this.ptbLogo.Size = new System.Drawing.Size(109, 65);
            this.ptbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbLogo.TabIndex = 2;
            this.ptbLogo.TabStop = false;
            this.ptbLogo.Visible = false;
            // 
            // ptbExit
            // 
            this.animationMenuClose.SetDecoration(this.ptbExit, BunifuAnimatorNS.DecorationType.None);
            this.anmationLogo.SetDecoration(this.ptbExit, BunifuAnimatorNS.DecorationType.None);
            this.animationMenuOpen.SetDecoration(this.ptbExit, BunifuAnimatorNS.DecorationType.None);
            this.ptbExit.Image = global::QuanLyQuanCaFe.Properties.Resources.img_186707;
            this.ptbExit.Location = new System.Drawing.Point(958, 12);
            this.ptbExit.Name = "ptbExit";
            this.ptbExit.Size = new System.Drawing.Size(20, 24);
            this.ptbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbExit.TabIndex = 3;
            this.ptbExit.TabStop = false;
            this.ptbExit.Click += new System.EventHandler(this.ptbExit_Click);
            // 
            // ptbiconhead
            // 
            this.animationMenuClose.SetDecoration(this.ptbiconhead, BunifuAnimatorNS.DecorationType.None);
            this.anmationLogo.SetDecoration(this.ptbiconhead, BunifuAnimatorNS.DecorationType.None);
            this.animationMenuOpen.SetDecoration(this.ptbiconhead, BunifuAnimatorNS.DecorationType.None);
            this.ptbiconhead.Image = global::QuanLyQuanCaFe.Properties.Resources.cup2_5121;
            this.ptbiconhead.Location = new System.Drawing.Point(12, 12);
            this.ptbiconhead.Name = "ptbiconhead";
            this.ptbiconhead.Size = new System.Drawing.Size(24, 21);
            this.ptbiconhead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbiconhead.TabIndex = 2;
            this.ptbiconhead.TabStop = false;
            // 
            // tabPage3
            // 
            this.animationMenuClose.SetDecoration(this.tabPage3, BunifuAnimatorNS.DecorationType.None);
            this.anmationLogo.SetDecoration(this.tabPage3, BunifuAnimatorNS.DecorationType.None);
            this.animationMenuOpen.SetDecoration(this.tabPage3, BunifuAnimatorNS.DecorationType.None);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(936, 456);
            this.tabPage3.TabIndex = 4;
            this.tabPage3.Text = "Bàn ăn";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.animationMenuClose.SetDecoration(this.tabPage4, BunifuAnimatorNS.DecorationType.None);
            this.anmationLogo.SetDecoration(this.tabPage4, BunifuAnimatorNS.DecorationType.None);
            this.animationMenuOpen.SetDecoration(this.tabPage4, BunifuAnimatorNS.DecorationType.None);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(936, 456);
            this.tabPage4.TabIndex = 5;
            this.tabPage4.Text = "Tài khoản";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // fAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 537);
            this.Controls.Add(this.pnMenu);
            this.Controls.Add(this.tcadmin);
            this.Controls.Add(this.head);
            this.anmationLogo.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.animationMenuOpen.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.animationMenuClose.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fAdmin";
            this.head.ResumeLayout(false);
            this.head.PerformLayout();
            this.pnMenu.ResumeLayout(false);
            this.tcadmin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbiconhead)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel head;
        private System.Windows.Forms.PictureBox ptbExit;
        private System.Windows.Forms.PictureBox ptbiconhead;
        private Bunifu.Framework.UI.BunifuCustomLabel lbHeader;
        private System.Windows.Forms.Panel pnMenu;
        private Bunifu.Framework.UI.BunifuFlatButton btnAccount;
        private Bunifu.Framework.UI.BunifuFlatButton btnTable;
        private Bunifu.Framework.UI.BunifuFlatButton btnFood;
        private Bunifu.Framework.UI.BunifuFlatButton btnCatogery;
        private Bunifu.Framework.UI.BunifuImageButton btnMenu;
        private Bunifu.Framework.UI.BunifuFlatButton btnDoanhthu;
        private System.Windows.Forms.PictureBox ptbLogo;
        private BunifuAnimatorNS.BunifuTransition animationMenuOpen;
        private BunifuAnimatorNS.BunifuTransition anmationLogo;
        private BunifuAnimatorNS.BunifuTransition animationMenuClose;
        private System.Windows.Forms.TabControl tcadmin;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.TabPage tpDoanhthu;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
    }
}