namespace QuanLyQuanCaFe
{
    partial class fTableManager
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
            BunifuAnimatorNS.Animation animation7 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fTableManager));
            BunifuAnimatorNS.Animation animation11 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation10 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation9 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation12 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation8 = new BunifuAnimatorNS.Animation();
            this.animationAdmin = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.pnTheme = new System.Windows.Forms.Panel();
            this.pnMenu = new System.Windows.Forms.Panel();
            this.ptbxLogoMini = new System.Windows.Forms.PictureBox();
            this.Sperate = new Bunifu.Framework.UI.BunifuSeparator();
            this.btnAdmin = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnInformation = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMenu = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnTable = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ptbLogo = new System.Windows.Forms.PictureBox();
            this.pnhead = new System.Windows.Forms.Panel();
            this.ptbExit = new System.Windows.Forms.PictureBox();
            this.ptbiconhead = new System.Windows.Forms.PictureBox();
            this.lbHeader = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.animationTable = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.animationInfo = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.animationMenuOpen = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.anmationLogo = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.animationMenuClose = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.pnMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbxLogoMini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).BeginInit();
            this.pnhead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbiconhead)).BeginInit();
            this.SuspendLayout();
            // 
            // animationAdmin
            // 
            this.animationAdmin.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.animationAdmin.Cursor = null;
            animation7.AnimateOnlyDifferences = true;
            animation7.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation7.BlindCoeff")));
            animation7.LeafCoeff = 0F;
            animation7.MaxTime = 1F;
            animation7.MinTime = 0F;
            animation7.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation7.MosaicCoeff")));
            animation7.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation7.MosaicShift")));
            animation7.MosaicSize = 0;
            animation7.Padding = new System.Windows.Forms.Padding(0);
            animation7.RotateCoeff = 0F;
            animation7.RotateLimit = 0F;
            animation7.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation7.ScaleCoeff")));
            animation7.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation7.SlideCoeff")));
            animation7.TimeCoeff = 0F;
            animation7.TransparencyCoeff = 0F;
            this.animationAdmin.DefaultAnimation = animation7;
            // 
            // pnTheme
            // 
            this.pnTheme.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.animationMenuClose.SetDecoration(this.pnTheme, BunifuAnimatorNS.DecorationType.None);
            this.animationInfo.SetDecoration(this.pnTheme, BunifuAnimatorNS.DecorationType.None);
            this.animationMenuOpen.SetDecoration(this.pnTheme, BunifuAnimatorNS.DecorationType.None);
            this.animationAdmin.SetDecoration(this.pnTheme, BunifuAnimatorNS.DecorationType.None);
            this.anmationLogo.SetDecoration(this.pnTheme, BunifuAnimatorNS.DecorationType.None);
            this.animationTable.SetDecoration(this.pnTheme, BunifuAnimatorNS.DecorationType.None);
            this.pnTheme.Location = new System.Drawing.Point(46, 36);
            this.pnTheme.Name = "pnTheme";
            this.pnTheme.Size = new System.Drawing.Size(944, 501);
            this.pnTheme.TabIndex = 2;
            this.pnTheme.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnTheme_MouseMove);
            // 
            // pnMenu
            // 
            this.pnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.pnMenu.Controls.Add(this.ptbxLogoMini);
            this.pnMenu.Controls.Add(this.Sperate);
            this.pnMenu.Controls.Add(this.btnAdmin);
            this.pnMenu.Controls.Add(this.btnInformation);
            this.pnMenu.Controls.Add(this.btnMenu);
            this.pnMenu.Controls.Add(this.btnTable);
            this.pnMenu.Controls.Add(this.ptbLogo);
            this.animationMenuClose.SetDecoration(this.pnMenu, BunifuAnimatorNS.DecorationType.None);
            this.animationInfo.SetDecoration(this.pnMenu, BunifuAnimatorNS.DecorationType.None);
            this.animationMenuOpen.SetDecoration(this.pnMenu, BunifuAnimatorNS.DecorationType.None);
            this.animationAdmin.SetDecoration(this.pnMenu, BunifuAnimatorNS.DecorationType.None);
            this.anmationLogo.SetDecoration(this.pnMenu, BunifuAnimatorNS.DecorationType.None);
            this.animationTable.SetDecoration(this.pnMenu, BunifuAnimatorNS.DecorationType.None);
            this.pnMenu.Location = new System.Drawing.Point(0, 40);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(45, 501);
            this.pnMenu.TabIndex = 0;
            // 
            // ptbxLogoMini
            // 
            this.anmationLogo.SetDecoration(this.ptbxLogoMini, BunifuAnimatorNS.DecorationType.None);
            this.animationInfo.SetDecoration(this.ptbxLogoMini, BunifuAnimatorNS.DecorationType.None);
            this.animationMenuOpen.SetDecoration(this.ptbxLogoMini, BunifuAnimatorNS.DecorationType.None);
            this.animationAdmin.SetDecoration(this.ptbxLogoMini, BunifuAnimatorNS.DecorationType.None);
            this.animationTable.SetDecoration(this.ptbxLogoMini, BunifuAnimatorNS.DecorationType.None);
            this.animationMenuClose.SetDecoration(this.ptbxLogoMini, BunifuAnimatorNS.DecorationType.None);
            this.ptbxLogoMini.Image = global::QuanLyQuanCaFe.Properties.Resources.aaaaa;
            this.ptbxLogoMini.Location = new System.Drawing.Point(-25, 63);
            this.ptbxLogoMini.Name = "ptbxLogoMini";
            this.ptbxLogoMini.Size = new System.Drawing.Size(90, 117);
            this.ptbxLogoMini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbxLogoMini.TabIndex = 0;
            this.ptbxLogoMini.TabStop = false;
            // 
            // Sperate
            // 
            this.Sperate.BackColor = System.Drawing.Color.Transparent;
            this.animationMenuClose.SetDecoration(this.Sperate, BunifuAnimatorNS.DecorationType.None);
            this.animationTable.SetDecoration(this.Sperate, BunifuAnimatorNS.DecorationType.None);
            this.animationAdmin.SetDecoration(this.Sperate, BunifuAnimatorNS.DecorationType.None);
            this.animationMenuOpen.SetDecoration(this.Sperate, BunifuAnimatorNS.DecorationType.None);
            this.animationInfo.SetDecoration(this.Sperate, BunifuAnimatorNS.DecorationType.None);
            this.anmationLogo.SetDecoration(this.Sperate, BunifuAnimatorNS.DecorationType.None);
            this.Sperate.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Sperate.LineThickness = 1;
            this.Sperate.Location = new System.Drawing.Point(29, 159);
            this.Sperate.Name = "Sperate";
            this.Sperate.Size = new System.Drawing.Size(187, 35);
            this.Sperate.TabIndex = 0;
            this.Sperate.Transparency = 255;
            this.Sperate.Vertical = false;
            // 
            // btnAdmin
            // 
            this.btnAdmin.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(39)))), ((int)(((byte)(176)))));
            this.btnAdmin.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAdmin.BackColor = System.Drawing.Color.White;
            this.btnAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdmin.BorderRadius = 7;
            this.btnAdmin.ButtonText = "     Admin";
            this.btnAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.anmationLogo.SetDecoration(this.btnAdmin, BunifuAnimatorNS.DecorationType.None);
            this.animationTable.SetDecoration(this.btnAdmin, BunifuAnimatorNS.DecorationType.None);
            this.animationAdmin.SetDecoration(this.btnAdmin, BunifuAnimatorNS.DecorationType.None);
            this.animationMenuOpen.SetDecoration(this.btnAdmin, BunifuAnimatorNS.DecorationType.None);
            this.animationInfo.SetDecoration(this.btnAdmin, BunifuAnimatorNS.DecorationType.None);
            this.animationMenuClose.SetDecoration(this.btnAdmin, BunifuAnimatorNS.DecorationType.None);
            this.btnAdmin.DisabledColor = System.Drawing.Color.Gray;
            this.btnAdmin.ForeColor = System.Drawing.Color.LightGray;
            this.btnAdmin.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAdmin.Iconimage = global::QuanLyQuanCaFe.Properties.Resources._4_512;
            this.btnAdmin.Iconimage_right = null;
            this.btnAdmin.Iconimage_right_Selected = null;
            this.btnAdmin.Iconimage_Selected = null;
            this.btnAdmin.IconMarginLeft = 0;
            this.btnAdmin.IconMarginRight = 0;
            this.btnAdmin.IconRightVisible = true;
            this.btnAdmin.IconRightZoom = 0D;
            this.btnAdmin.IconVisible = true;
            this.btnAdmin.IconZoom = 50D;
            this.btnAdmin.IsTab = true;
            this.btnAdmin.Location = new System.Drawing.Point(0, 340);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Normalcolor = System.Drawing.Color.White;
            this.btnAdmin.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(49)))), ((int)(((byte)(186)))));
            this.btnAdmin.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAdmin.selected = false;
            this.btnAdmin.Size = new System.Drawing.Size(221, 48);
            this.btnAdmin.TabIndex = 5;
            this.btnAdmin.Text = "     Admin";
            this.btnAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmin.Textcolor = System.Drawing.Color.DimGray;
            this.btnAdmin.TextFont = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnInformation
            // 
            this.btnInformation.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(39)))), ((int)(((byte)(176)))));
            this.btnInformation.BackColor = System.Drawing.Color.White;
            this.btnInformation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInformation.BorderRadius = 7;
            this.btnInformation.ButtonText = "     Info";
            this.btnInformation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.anmationLogo.SetDecoration(this.btnInformation, BunifuAnimatorNS.DecorationType.None);
            this.animationTable.SetDecoration(this.btnInformation, BunifuAnimatorNS.DecorationType.None);
            this.animationAdmin.SetDecoration(this.btnInformation, BunifuAnimatorNS.DecorationType.None);
            this.animationMenuOpen.SetDecoration(this.btnInformation, BunifuAnimatorNS.DecorationType.None);
            this.animationInfo.SetDecoration(this.btnInformation, BunifuAnimatorNS.DecorationType.None);
            this.animationMenuClose.SetDecoration(this.btnInformation, BunifuAnimatorNS.DecorationType.None);
            this.btnInformation.DisabledColor = System.Drawing.Color.Gray;
            this.btnInformation.ForeColor = System.Drawing.Color.White;
            this.btnInformation.Iconcolor = System.Drawing.Color.Transparent;
            this.btnInformation.Iconimage = global::QuanLyQuanCaFe.Properties.Resources.source_change_password_icon_115632113989lfjrixlx81;
            this.btnInformation.Iconimage_right = null;
            this.btnInformation.Iconimage_right_Selected = null;
            this.btnInformation.Iconimage_Selected = null;
            this.btnInformation.IconMarginLeft = 0;
            this.btnInformation.IconMarginRight = 0;
            this.btnInformation.IconRightVisible = true;
            this.btnInformation.IconRightZoom = 0D;
            this.btnInformation.IconVisible = true;
            this.btnInformation.IconZoom = 50D;
            this.btnInformation.IsTab = true;
            this.btnInformation.Location = new System.Drawing.Point(0, 270);
            this.btnInformation.Name = "btnInformation";
            this.btnInformation.Normalcolor = System.Drawing.Color.White;
            this.btnInformation.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(49)))), ((int)(((byte)(186)))));
            this.btnInformation.OnHoverTextColor = System.Drawing.Color.White;
            this.btnInformation.selected = false;
            this.btnInformation.Size = new System.Drawing.Size(221, 48);
            this.btnInformation.TabIndex = 4;
            this.btnInformation.Text = "     Info";
            this.btnInformation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInformation.Textcolor = System.Drawing.Color.DimGray;
            this.btnInformation.TextFont = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInformation.Click += new System.EventHandler(this.btnInformation_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.animationMenuClose.SetDecoration(this.btnMenu, BunifuAnimatorNS.DecorationType.None);
            this.animationTable.SetDecoration(this.btnMenu, BunifuAnimatorNS.DecorationType.None);
            this.animationAdmin.SetDecoration(this.btnMenu, BunifuAnimatorNS.DecorationType.None);
            this.animationMenuOpen.SetDecoration(this.btnMenu, BunifuAnimatorNS.DecorationType.None);
            this.animationInfo.SetDecoration(this.btnMenu, BunifuAnimatorNS.DecorationType.None);
            this.anmationLogo.SetDecoration(this.btnMenu, BunifuAnimatorNS.DecorationType.None);
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
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
            // btnTable
            // 
            this.btnTable.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(39)))), ((int)(((byte)(176)))));
            this.btnTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(39)))), ((int)(((byte)(176)))));
            this.btnTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTable.BorderRadius = 7;
            this.btnTable.ButtonText = "    TableManager";
            this.btnTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.anmationLogo.SetDecoration(this.btnTable, BunifuAnimatorNS.DecorationType.None);
            this.animationTable.SetDecoration(this.btnTable, BunifuAnimatorNS.DecorationType.None);
            this.animationAdmin.SetDecoration(this.btnTable, BunifuAnimatorNS.DecorationType.None);
            this.animationMenuOpen.SetDecoration(this.btnTable, BunifuAnimatorNS.DecorationType.None);
            this.animationInfo.SetDecoration(this.btnTable, BunifuAnimatorNS.DecorationType.None);
            this.animationMenuClose.SetDecoration(this.btnTable, BunifuAnimatorNS.DecorationType.None);
            this.btnTable.DisabledColor = System.Drawing.Color.Gray;
            this.btnTable.ForeColor = System.Drawing.Color.LightGray;
            this.btnTable.Iconcolor = System.Drawing.Color.Transparent;
            this.btnTable.Iconimage = global::QuanLyQuanCaFe.Properties.Resources.coffee_table_36_976489;
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
            this.btnTable.Location = new System.Drawing.Point(0, 200);
            this.btnTable.Name = "btnTable";
            this.btnTable.Normalcolor = System.Drawing.Color.White;
            this.btnTable.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(49)))), ((int)(((byte)(186)))));
            this.btnTable.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTable.selected = true;
            this.btnTable.Size = new System.Drawing.Size(221, 48);
            this.btnTable.TabIndex = 2;
            this.btnTable.Text = "    TableManager";
            this.btnTable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTable.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.btnTable.TextFont = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTable.Click += new System.EventHandler(this.btnTable_Click);
            // 
            // ptbLogo
            // 
            this.ptbLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.anmationLogo.SetDecoration(this.ptbLogo, BunifuAnimatorNS.DecorationType.None);
            this.animationInfo.SetDecoration(this.ptbLogo, BunifuAnimatorNS.DecorationType.None);
            this.animationMenuOpen.SetDecoration(this.ptbLogo, BunifuAnimatorNS.DecorationType.None);
            this.animationAdmin.SetDecoration(this.ptbLogo, BunifuAnimatorNS.DecorationType.None);
            this.animationTable.SetDecoration(this.ptbLogo, BunifuAnimatorNS.DecorationType.None);
            this.animationMenuClose.SetDecoration(this.ptbLogo, BunifuAnimatorNS.DecorationType.None);
            this.ptbLogo.Image = global::QuanLyQuanCaFe.Properties.Resources._79804229_516863478912631_5982905223037845504_n;
            this.ptbLogo.Location = new System.Drawing.Point(49, 19);
            this.ptbLogo.Name = "ptbLogo";
            this.ptbLogo.Size = new System.Drawing.Size(146, 141);
            this.ptbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbLogo.TabIndex = 2;
            this.ptbLogo.TabStop = false;
            // 
            // pnhead
            // 
            this.pnhead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.pnhead.Controls.Add(this.ptbExit);
            this.pnhead.Controls.Add(this.ptbiconhead);
            this.pnhead.Controls.Add(this.lbHeader);
            this.pnhead.Cursor = System.Windows.Forms.Cursors.Default;
            this.animationMenuClose.SetDecoration(this.pnhead, BunifuAnimatorNS.DecorationType.None);
            this.animationInfo.SetDecoration(this.pnhead, BunifuAnimatorNS.DecorationType.None);
            this.animationMenuOpen.SetDecoration(this.pnhead, BunifuAnimatorNS.DecorationType.None);
            this.animationAdmin.SetDecoration(this.pnhead, BunifuAnimatorNS.DecorationType.None);
            this.anmationLogo.SetDecoration(this.pnhead, BunifuAnimatorNS.DecorationType.None);
            this.animationTable.SetDecoration(this.pnhead, BunifuAnimatorNS.DecorationType.None);
            this.pnhead.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnhead.Location = new System.Drawing.Point(0, 0);
            this.pnhead.Name = "pnhead";
            this.pnhead.Size = new System.Drawing.Size(990, 40);
            this.pnhead.TabIndex = 3;
            // 
            // ptbExit
            // 
            this.ptbExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.anmationLogo.SetDecoration(this.ptbExit, BunifuAnimatorNS.DecorationType.None);
            this.animationInfo.SetDecoration(this.ptbExit, BunifuAnimatorNS.DecorationType.None);
            this.animationMenuOpen.SetDecoration(this.ptbExit, BunifuAnimatorNS.DecorationType.None);
            this.animationAdmin.SetDecoration(this.ptbExit, BunifuAnimatorNS.DecorationType.None);
            this.animationTable.SetDecoration(this.ptbExit, BunifuAnimatorNS.DecorationType.None);
            this.animationMenuClose.SetDecoration(this.ptbExit, BunifuAnimatorNS.DecorationType.None);
            this.ptbExit.Image = global::QuanLyQuanCaFe.Properties.Resources.close_delete_exit_no_remove_stop_icon_1320191167239715440;
            this.ptbExit.Location = new System.Drawing.Point(954, 12);
            this.ptbExit.Name = "ptbExit";
            this.ptbExit.Size = new System.Drawing.Size(24, 21);
            this.ptbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbExit.TabIndex = 3;
            this.ptbExit.TabStop = false;
            this.ptbExit.Click += new System.EventHandler(this.ptbExit_Click_1);
            // 
            // ptbiconhead
            // 
            this.ptbiconhead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.anmationLogo.SetDecoration(this.ptbiconhead, BunifuAnimatorNS.DecorationType.None);
            this.animationInfo.SetDecoration(this.ptbiconhead, BunifuAnimatorNS.DecorationType.None);
            this.animationMenuOpen.SetDecoration(this.ptbiconhead, BunifuAnimatorNS.DecorationType.None);
            this.animationAdmin.SetDecoration(this.ptbiconhead, BunifuAnimatorNS.DecorationType.None);
            this.animationTable.SetDecoration(this.ptbiconhead, BunifuAnimatorNS.DecorationType.None);
            this.animationMenuClose.SetDecoration(this.ptbiconhead, BunifuAnimatorNS.DecorationType.None);
            this.ptbiconhead.Image = global::QuanLyQuanCaFe.Properties.Resources.cup2_5121;
            this.ptbiconhead.Location = new System.Drawing.Point(12, 12);
            this.ptbiconhead.Name = "ptbiconhead";
            this.ptbiconhead.Size = new System.Drawing.Size(24, 21);
            this.ptbiconhead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbiconhead.TabIndex = 2;
            this.ptbiconhead.TabStop = false;
            // 
            // lbHeader
            // 
            this.lbHeader.AutoSize = true;
            this.lbHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.animationMenuClose.SetDecoration(this.lbHeader, BunifuAnimatorNS.DecorationType.None);
            this.animationTable.SetDecoration(this.lbHeader, BunifuAnimatorNS.DecorationType.None);
            this.animationAdmin.SetDecoration(this.lbHeader, BunifuAnimatorNS.DecorationType.None);
            this.animationMenuOpen.SetDecoration(this.lbHeader, BunifuAnimatorNS.DecorationType.None);
            this.animationInfo.SetDecoration(this.lbHeader, BunifuAnimatorNS.DecorationType.None);
            this.anmationLogo.SetDecoration(this.lbHeader, BunifuAnimatorNS.DecorationType.None);
            this.lbHeader.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeader.ForeColor = System.Drawing.Color.White;
            this.lbHeader.Location = new System.Drawing.Point(45, 12);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(226, 18);
            this.lbHeader.TabIndex = 2;
            this.lbHeader.Text = "Phần mềm Quản lý quán Cafe";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.pnhead;
            this.bunifuDragControl1.Vertical = true;
            // 
            // animationTable
            // 
            this.animationTable.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.animationTable.Cursor = null;
            animation11.AnimateOnlyDifferences = true;
            animation11.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation11.BlindCoeff")));
            animation11.LeafCoeff = 0F;
            animation11.MaxTime = 1F;
            animation11.MinTime = 0F;
            animation11.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation11.MosaicCoeff")));
            animation11.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation11.MosaicShift")));
            animation11.MosaicSize = 0;
            animation11.Padding = new System.Windows.Forms.Padding(0);
            animation11.RotateCoeff = 0F;
            animation11.RotateLimit = 0F;
            animation11.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation11.ScaleCoeff")));
            animation11.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation11.SlideCoeff")));
            animation11.TimeCoeff = 0F;
            animation11.TransparencyCoeff = 0F;
            this.animationTable.DefaultAnimation = animation11;
            this.animationTable.Interval = 20;
            // 
            // animationInfo
            // 
            this.animationInfo.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.animationInfo.Cursor = null;
            animation10.AnimateOnlyDifferences = true;
            animation10.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation10.BlindCoeff")));
            animation10.LeafCoeff = 0F;
            animation10.MaxTime = 1F;
            animation10.MinTime = 0F;
            animation10.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation10.MosaicCoeff")));
            animation10.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation10.MosaicShift")));
            animation10.MosaicSize = 0;
            animation10.Padding = new System.Windows.Forms.Padding(0);
            animation10.RotateCoeff = 0F;
            animation10.RotateLimit = 0F;
            animation10.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation10.ScaleCoeff")));
            animation10.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation10.SlideCoeff")));
            animation10.TimeCoeff = 0F;
            animation10.TransparencyCoeff = 0F;
            this.animationInfo.DefaultAnimation = animation10;
            // 
            // animationMenuOpen
            // 
            this.animationMenuOpen.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.animationMenuOpen.Cursor = null;
            animation9.AnimateOnlyDifferences = true;
            animation9.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation9.BlindCoeff")));
            animation9.LeafCoeff = 0F;
            animation9.MaxTime = 1F;
            animation9.MinTime = 0F;
            animation9.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation9.MosaicCoeff")));
            animation9.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation9.MosaicShift")));
            animation9.MosaicSize = 0;
            animation9.Padding = new System.Windows.Forms.Padding(0);
            animation9.RotateCoeff = 0F;
            animation9.RotateLimit = 0F;
            animation9.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation9.ScaleCoeff")));
            animation9.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation9.SlideCoeff")));
            animation9.TimeCoeff = 0F;
            animation9.TransparencyCoeff = 0F;
            this.animationMenuOpen.DefaultAnimation = animation9;
            this.animationMenuOpen.Interval = 13;
            // 
            // anmationLogo
            // 
            this.anmationLogo.AnimationType = BunifuAnimatorNS.AnimationType.Scale;
            this.anmationLogo.Cursor = null;
            animation12.AnimateOnlyDifferences = true;
            animation12.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation12.BlindCoeff")));
            animation12.LeafCoeff = 0F;
            animation12.MaxTime = 1F;
            animation12.MinTime = 0F;
            animation12.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation12.MosaicCoeff")));
            animation12.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation12.MosaicShift")));
            animation12.MosaicSize = 0;
            animation12.Padding = new System.Windows.Forms.Padding(0);
            animation12.RotateCoeff = 0F;
            animation12.RotateLimit = 0F;
            animation12.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation12.ScaleCoeff")));
            animation12.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation12.SlideCoeff")));
            animation12.TimeCoeff = 0F;
            animation12.TransparencyCoeff = 0F;
            this.anmationLogo.DefaultAnimation = animation12;
            // 
            // animationMenuClose
            // 
            this.animationMenuClose.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.animationMenuClose.Cursor = null;
            animation8.AnimateOnlyDifferences = true;
            animation8.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation8.BlindCoeff")));
            animation8.LeafCoeff = 0F;
            animation8.MaxTime = 1F;
            animation8.MinTime = 0F;
            animation8.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation8.MosaicCoeff")));
            animation8.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation8.MosaicShift")));
            animation8.MosaicSize = 0;
            animation8.Padding = new System.Windows.Forms.Padding(0);
            animation8.RotateCoeff = 0F;
            animation8.RotateLimit = 0F;
            animation8.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation8.ScaleCoeff")));
            animation8.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation8.SlideCoeff")));
            animation8.TimeCoeff = 0F;
            animation8.TransparencyCoeff = 1F;
            this.animationMenuClose.DefaultAnimation = animation8;
            this.animationMenuClose.Interval = 13;
            // 
            // fTableManager
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(990, 537);
            this.Controls.Add(this.pnhead);
            this.Controls.Add(this.pnMenu);
            this.Controls.Add(this.pnTheme);
            this.animationMenuClose.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.animationAdmin.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.animationMenuOpen.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.animationInfo.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.animationTable.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.anmationLogo.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fTableManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fTableManager";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fTableManager_KeyUp);
            this.pnMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbxLogoMini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).EndInit();
            this.pnhead.ResumeLayout(false);
            this.pnhead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbiconhead)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private BunifuAnimatorNS.BunifuTransition animationAdmin;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private BunifuAnimatorNS.BunifuTransition animationTable;
        private BunifuAnimatorNS.BunifuTransition animationInfo;
        private BunifuAnimatorNS.BunifuTransition animationMenuOpen;
        private BunifuAnimatorNS.BunifuTransition anmationLogo;
        private BunifuAnimatorNS.BunifuTransition animationMenuClose;
        private System.Windows.Forms.Panel pnTheme;
        private System.Windows.Forms.Panel pnMenu;
        private Bunifu.Framework.UI.BunifuFlatButton btnAdmin;
        private Bunifu.Framework.UI.BunifuFlatButton btnInformation;
        private Bunifu.Framework.UI.BunifuImageButton btnMenu;
        private Bunifu.Framework.UI.BunifuFlatButton btnTable;
        private System.Windows.Forms.PictureBox ptbLogo;
        private System.Windows.Forms.Panel pnhead;
        private System.Windows.Forms.PictureBox ptbExit;
        private System.Windows.Forms.PictureBox ptbiconhead;
        private Bunifu.Framework.UI.BunifuCustomLabel lbHeader;
        private Bunifu.Framework.UI.BunifuSeparator Sperate;
        private System.Windows.Forms.PictureBox ptbxLogoMini;
    }
}