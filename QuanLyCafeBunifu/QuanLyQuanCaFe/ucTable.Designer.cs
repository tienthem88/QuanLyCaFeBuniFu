namespace QuanLyQuanCaFe
{
    partial class ucTable
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnTable = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThem = new Bunifu.Framework.UI.BunifuFlatButton();
            this.nmFoodCount = new System.Windows.Forms.NumericUpDown();
            this.cbFood = new System.Windows.Forms.ComboBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nmDiscount = new System.Windows.Forms.NumericUpDown();
            this.btnChuyenban = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cbChuyenban = new System.Windows.Forms.ComboBox();
            this.tbxTotalPrice = new System.Windows.Forms.TextBox();
            this.btnDiscound = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnThanhtoan = new Bunifu.Framework.UI.BunifuFlatButton();
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.lsvBill = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnTable.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodCount)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmDiscount)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTable
            // 
            this.pnTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.pnTable.Controls.Add(this.panel3);
            this.pnTable.Controls.Add(this.panel1);
            this.pnTable.Controls.Add(this.panel2);
            this.pnTable.Controls.Add(this.flpTable);
            this.pnTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnTable.Location = new System.Drawing.Point(0, 0);
            this.pnTable.Name = "pnTable";
            this.pnTable.Size = new System.Drawing.Size(944, 495);
            this.pnTable.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.nmFoodCount);
            this.panel1.Controls.Add(this.cbFood);
            this.panel1.Controls.Add(this.cbCategory);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(532, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(412, 60);
            this.panel1.TabIndex = 1;
            // 
            // btnThem
            // 
            this.btnThem.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThem.BorderRadius = 0;
            this.btnThem.ButtonText = "Thêm món";
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.DisabledColor = System.Drawing.Color.Gray;
            this.btnThem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Iconcolor = System.Drawing.Color.Transparent;
            this.btnThem.Iconimage = null;
            this.btnThem.Iconimage_right = null;
            this.btnThem.Iconimage_right_Selected = null;
            this.btnThem.Iconimage_Selected = null;
            this.btnThem.IconMarginLeft = 0;
            this.btnThem.IconMarginRight = 0;
            this.btnThem.IconRightVisible = true;
            this.btnThem.IconRightZoom = 0D;
            this.btnThem.IconVisible = true;
            this.btnThem.IconZoom = 90D;
            this.btnThem.IsTab = false;
            this.btnThem.Location = new System.Drawing.Point(227, 0);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.btnThem.OnHovercolor = System.Drawing.Color.SeaGreen;
            this.btnThem.OnHoverTextColor = System.Drawing.Color.White;
            this.btnThem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnThem.selected = false;
            this.btnThem.Size = new System.Drawing.Size(77, 57);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm món";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnThem.Textcolor = System.Drawing.Color.White;
            this.btnThem.TextFont = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // nmFoodCount
            // 
            this.nmFoodCount.Location = new System.Drawing.Point(308, 20);
            this.nmFoodCount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nmFoodCount.Name = "nmFoodCount";
            this.nmFoodCount.Size = new System.Drawing.Size(101, 20);
            this.nmFoodCount.TabIndex = 3;
            this.nmFoodCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmFoodCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbFood
            // 
            this.cbFood.FormattingEnabled = true;
            this.cbFood.Location = new System.Drawing.Point(0, 36);
            this.cbFood.Name = "cbFood";
            this.cbFood.Size = new System.Drawing.Size(220, 21);
            this.cbFood.TabIndex = 1;
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(0, 3);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(220, 21);
            this.cbCategory.TabIndex = 0;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.panel2.Controls.Add(this.nmDiscount);
            this.panel2.Controls.Add(this.btnChuyenban);
            this.panel2.Controls.Add(this.cbChuyenban);
            this.panel2.Controls.Add(this.tbxTotalPrice);
            this.panel2.Controls.Add(this.btnDiscound);
            this.panel2.Controls.Add(this.btnThanhtoan);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(532, 434);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(412, 61);
            this.panel2.TabIndex = 4;
            // 
            // nmDiscount
            // 
            this.nmDiscount.Location = new System.Drawing.Point(93, 35);
            this.nmDiscount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nmDiscount.Name = "nmDiscount";
            this.nmDiscount.Size = new System.Drawing.Size(89, 20);
            this.nmDiscount.TabIndex = 8;
            this.nmDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnChuyenban
            // 
            this.btnChuyenban.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.btnChuyenban.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.btnChuyenban.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnChuyenban.BorderRadius = 0;
            this.btnChuyenban.ButtonText = "Chuyển bàn";
            this.btnChuyenban.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChuyenban.DisabledColor = System.Drawing.Color.Gray;
            this.btnChuyenban.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChuyenban.Iconcolor = System.Drawing.Color.Transparent;
            this.btnChuyenban.Iconimage = null;
            this.btnChuyenban.Iconimage_right = null;
            this.btnChuyenban.Iconimage_right_Selected = null;
            this.btnChuyenban.Iconimage_Selected = null;
            this.btnChuyenban.IconMarginLeft = 0;
            this.btnChuyenban.IconMarginRight = 0;
            this.btnChuyenban.IconRightVisible = true;
            this.btnChuyenban.IconRightZoom = 0D;
            this.btnChuyenban.IconVisible = true;
            this.btnChuyenban.IconZoom = 90D;
            this.btnChuyenban.IsTab = false;
            this.btnChuyenban.Location = new System.Drawing.Point(0, 0);
            this.btnChuyenban.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnChuyenban.Name = "btnChuyenban";
            this.btnChuyenban.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.btnChuyenban.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnChuyenban.OnHoverTextColor = System.Drawing.Color.White;
            this.btnChuyenban.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnChuyenban.selected = false;
            this.btnChuyenban.Size = new System.Drawing.Size(87, 27);
            this.btnChuyenban.TabIndex = 7;
            this.btnChuyenban.Text = "Chuyển bàn";
            this.btnChuyenban.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnChuyenban.Textcolor = System.Drawing.Color.White;
            this.btnChuyenban.TextFont = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChuyenban.Click += new System.EventHandler(this.btnChuyenban_Click);
            // 
            // cbChuyenban
            // 
            this.cbChuyenban.FormattingEnabled = true;
            this.cbChuyenban.Location = new System.Drawing.Point(0, 34);
            this.cbChuyenban.Name = "cbChuyenban";
            this.cbChuyenban.Size = new System.Drawing.Size(87, 21);
            this.cbChuyenban.TabIndex = 6;
            // 
            // tbxTotalPrice
            // 
            this.tbxTotalPrice.Location = new System.Drawing.Point(192, 18);
            this.tbxTotalPrice.Name = "tbxTotalPrice";
            this.tbxTotalPrice.ReadOnly = true;
            this.tbxTotalPrice.Size = new System.Drawing.Size(136, 20);
            this.tbxTotalPrice.TabIndex = 4;
            // 
            // btnDiscound
            // 
            this.btnDiscound.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.btnDiscound.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.btnDiscound.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDiscound.BorderRadius = 0;
            this.btnDiscound.ButtonText = "Giảm giá";
            this.btnDiscound.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDiscound.DisabledColor = System.Drawing.Color.Gray;
            this.btnDiscound.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiscound.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDiscound.Iconimage = null;
            this.btnDiscound.Iconimage_right = null;
            this.btnDiscound.Iconimage_right_Selected = null;
            this.btnDiscound.Iconimage_Selected = null;
            this.btnDiscound.IconMarginLeft = 0;
            this.btnDiscound.IconMarginRight = 0;
            this.btnDiscound.IconRightVisible = true;
            this.btnDiscound.IconRightZoom = 0D;
            this.btnDiscound.IconVisible = true;
            this.btnDiscound.IconZoom = 90D;
            this.btnDiscound.IsTab = false;
            this.btnDiscound.Location = new System.Drawing.Point(93, 0);
            this.btnDiscound.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDiscound.Name = "btnDiscound";
            this.btnDiscound.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.btnDiscound.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnDiscound.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDiscound.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDiscound.selected = false;
            this.btnDiscound.Size = new System.Drawing.Size(87, 27);
            this.btnDiscound.TabIndex = 3;
            this.btnDiscound.Text = "Giảm giá";
            this.btnDiscound.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDiscound.Textcolor = System.Drawing.Color.White;
            this.btnDiscound.TextFont = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnThanhtoan
            // 
            this.btnThanhtoan.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.btnThanhtoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.btnThanhtoan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThanhtoan.BorderRadius = 0;
            this.btnThanhtoan.ButtonText = "Thanh toán";
            this.btnThanhtoan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThanhtoan.DisabledColor = System.Drawing.Color.Gray;
            this.btnThanhtoan.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhtoan.Iconcolor = System.Drawing.Color.Transparent;
            this.btnThanhtoan.Iconimage = null;
            this.btnThanhtoan.Iconimage_right = null;
            this.btnThanhtoan.Iconimage_right_Selected = null;
            this.btnThanhtoan.Iconimage_Selected = null;
            this.btnThanhtoan.IconMarginLeft = 0;
            this.btnThanhtoan.IconMarginRight = 0;
            this.btnThanhtoan.IconRightVisible = true;
            this.btnThanhtoan.IconRightZoom = 0D;
            this.btnThanhtoan.IconVisible = true;
            this.btnThanhtoan.IconZoom = 90D;
            this.btnThanhtoan.IsTab = false;
            this.btnThanhtoan.Location = new System.Drawing.Point(335, 2);
            this.btnThanhtoan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThanhtoan.Name = "btnThanhtoan";
            this.btnThanhtoan.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.btnThanhtoan.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnThanhtoan.OnHoverTextColor = System.Drawing.Color.White;
            this.btnThanhtoan.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnThanhtoan.selected = false;
            this.btnThanhtoan.Size = new System.Drawing.Size(77, 57);
            this.btnThanhtoan.TabIndex = 2;
            this.btnThanhtoan.Text = "Thanh toán";
            this.btnThanhtoan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnThanhtoan.Textcolor = System.Drawing.Color.White;
            this.btnThanhtoan.TextFont = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhtoan.Click += new System.EventHandler(this.btnThanhtoan_Click);
            // 
            // flpTable
            // 
            this.flpTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.flpTable.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpTable.Location = new System.Drawing.Point(0, 0);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(532, 495);
            this.flpTable.TabIndex = 0;
            // 
            // lsvBill
            // 
            this.lsvBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvBill.GridLines = true;
            this.lsvBill.HideSelection = false;
            this.lsvBill.Location = new System.Drawing.Point(0, 0);
            this.lsvBill.Name = "lsvBill";
            this.lsvBill.Size = new System.Drawing.Size(412, 374);
            this.lsvBill.TabIndex = 8;
            this.lsvBill.UseCompatibleStateImageBehavior = false;
            this.lsvBill.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên món";
            this.columnHeader1.Width = 127;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số lượng";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn giá";
            this.columnHeader3.Width = 67;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành tiền";
            this.columnHeader4.Width = 73;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lsvBill);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(532, 60);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(412, 374);
            this.panel3.TabIndex = 5;
            // 
            // ucTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnTable);
            this.Name = "ucTable";
            this.Size = new System.Drawing.Size(944, 495);
            this.pnTable.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodCount)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmDiscount)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTable;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnThem;
        private System.Windows.Forms.NumericUpDown nmFoodCount;
        private System.Windows.Forms.ComboBox cbFood;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown nmDiscount;
        private Bunifu.Framework.UI.BunifuFlatButton btnChuyenban;
        private System.Windows.Forms.ComboBox cbChuyenban;
        private System.Windows.Forms.TextBox tbxTotalPrice;
        private Bunifu.Framework.UI.BunifuFlatButton btnDiscound;
        private Bunifu.Framework.UI.BunifuFlatButton btnThanhtoan;
        private System.Windows.Forms.FlowLayoutPanel flpTable;
        private System.Windows.Forms.ListView lsvBill;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Panel panel3;
    }
}
