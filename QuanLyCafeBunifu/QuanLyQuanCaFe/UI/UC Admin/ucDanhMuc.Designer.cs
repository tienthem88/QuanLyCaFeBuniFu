namespace QuanLyQuanCaFe.UI.UC_Admin
{
    partial class ucDanhMuc
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucDanhMuc));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbDisplay = new System.Windows.Forms.Label();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbCategoryFind = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.dtgvCategory = new System.Windows.Forms.DataGridView();
            this.btnDeleteCategory = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnAddCategory = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnFixCategory = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnShowCategory = new Bunifu.Framework.UI.BunifuImageButton();
            this.tbxTypeName = new Bunifu.Framework.UI.BunifuTextbox();
            this.tbxIDType = new Bunifu.Framework.UI.BunifuTextbox();
            this.btnFindCategory = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFixCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFindCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.dtgvCategory);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(944, 449);
            this.panel2.TabIndex = 30;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbDisplay);
            this.panel3.Controls.Add(this.btnDeleteCategory);
            this.panel3.Controls.Add(this.btnAddCategory);
            this.panel3.Controls.Add(this.btnFixCategory);
            this.panel3.Controls.Add(this.btnShowCategory);
            this.panel3.Controls.Add(this.bunifuCustomLabel3);
            this.panel3.Controls.Add(this.bunifuCustomLabel1);
            this.panel3.Controls.Add(this.tbxTypeName);
            this.panel3.Controls.Add(this.tbxIDType);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(455, 34);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(489, 415);
            this.panel3.TabIndex = 29;
            // 
            // lbDisplay
            // 
            this.lbDisplay.AutoSize = true;
            this.lbDisplay.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDisplay.ForeColor = System.Drawing.Color.White;
            this.lbDisplay.Location = new System.Drawing.Point(74, 21);
            this.lbDisplay.Name = "lbDisplay";
            this.lbDisplay.Size = new System.Drawing.Size(25, 12);
            this.lbDisplay.TabIndex = 34;
            this.lbDisplay.Text = "Xem";
            this.lbDisplay.Visible = false;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(143, 258);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(95, 21);
            this.bunifuCustomLabel3.TabIndex = 16;
            this.bunifuCustomLabel3.Text = "Danh mục:";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(143, 137);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(31, 21);
            this.bunifuCustomLabel1.TabIndex = 14;
            this.bunifuCustomLabel1.Text = "ID:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.btnFindCategory);
            this.panel1.Controls.Add(this.cbCategoryFind);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(455, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(489, 34);
            this.panel1.TabIndex = 0;
            // 
            // cbCategoryFind
            // 
            this.cbCategoryFind.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cbCategoryFind.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cbCategoryFind.ForeColor = System.Drawing.Color.White;
            this.cbCategoryFind.HintForeColor = System.Drawing.Color.White;
            this.cbCategoryFind.HintText = "Search...";
            this.cbCategoryFind.isPassword = false;
            this.cbCategoryFind.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cbCategoryFind.LineIdleColor = System.Drawing.Color.Gray;
            this.cbCategoryFind.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.cbCategoryFind.LineThickness = 3;
            this.cbCategoryFind.Location = new System.Drawing.Point(315, 3);
            this.cbCategoryFind.Margin = new System.Windows.Forms.Padding(4);
            this.cbCategoryFind.Name = "cbCategoryFind";
            this.cbCategoryFind.Size = new System.Drawing.Size(140, 26);
            this.cbCategoryFind.TabIndex = 29;
            this.cbCategoryFind.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // dtgvCategory
            // 
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgvCategory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dtgvCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvCategory.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dtgvCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvCategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dtgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCategory.Dock = System.Windows.Forms.DockStyle.Left;
            this.dtgvCategory.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtgvCategory.Location = new System.Drawing.Point(0, 0);
            this.dtgvCategory.Name = "dtgvCategory";
            this.dtgvCategory.ReadOnly = true;
            this.dtgvCategory.Size = new System.Drawing.Size(455, 449);
            this.dtgvCategory.TabIndex = 28;
            this.dtgvCategory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvCategory_CellContentClick);
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.btnDeleteCategory.Image = global::QuanLyQuanCaFe.Properties.Resources.delete_1432400_1211078;
            this.btnDeleteCategory.ImageActive = null;
            this.btnDeleteCategory.Location = new System.Drawing.Point(6, 354);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(62, 46);
            this.btnDeleteCategory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDeleteCategory.TabIndex = 33;
            this.btnDeleteCategory.TabStop = false;
            this.btnDeleteCategory.Zoom = 10;
            this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
            this.btnDeleteCategory.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnDeleteCategory_MouseMove);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.btnAddCategory.Image = global::QuanLyQuanCaFe.Properties.Resources.add_plus_512;
            this.btnAddCategory.ImageActive = null;
            this.btnAddCategory.Location = new System.Drawing.Point(6, 112);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(62, 46);
            this.btnAddCategory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAddCategory.TabIndex = 32;
            this.btnAddCategory.TabStop = false;
            this.btnAddCategory.Zoom = 10;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            this.btnAddCategory.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnAddCategory_MouseMove);
            // 
            // btnFixCategory
            // 
            this.btnFixCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.btnFixCategory.Image = global::QuanLyQuanCaFe.Properties.Resources._39_512;
            this.btnFixCategory.ImageActive = null;
            this.btnFixCategory.Location = new System.Drawing.Point(6, 233);
            this.btnFixCategory.Name = "btnFixCategory";
            this.btnFixCategory.Size = new System.Drawing.Size(62, 46);
            this.btnFixCategory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnFixCategory.TabIndex = 31;
            this.btnFixCategory.TabStop = false;
            this.btnFixCategory.Zoom = 10;
            this.btnFixCategory.Click += new System.EventHandler(this.btnFixCategory_Click);
            this.btnFixCategory.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnFixCategory_MouseMove);
            // 
            // btnShowCategory
            // 
            this.btnShowCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.btnShowCategory.Image = global::QuanLyQuanCaFe.Properties.Resources.visibility_512;
            this.btnShowCategory.ImageActive = null;
            this.btnShowCategory.Location = new System.Drawing.Point(6, 7);
            this.btnShowCategory.Name = "btnShowCategory";
            this.btnShowCategory.Size = new System.Drawing.Size(62, 46);
            this.btnShowCategory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnShowCategory.TabIndex = 30;
            this.btnShowCategory.TabStop = false;
            this.btnShowCategory.Zoom = 10;
            this.btnShowCategory.Click += new System.EventHandler(this.btnShowCategory_Click);
            this.btnShowCategory.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnShowCategory_MouseMove);
            // 
            // tbxTypeName
            // 
            this.tbxTypeName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.tbxTypeName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbxTypeName.BackgroundImage")));
            this.tbxTypeName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbxTypeName.ForeColor = System.Drawing.Color.White;
            this.tbxTypeName.Icon = ((System.Drawing.Image)(resources.GetObject("tbxTypeName.Icon")));
            this.tbxTypeName.Location = new System.Drawing.Point(252, 247);
            this.tbxTypeName.Name = "tbxTypeName";
            this.tbxTypeName.Size = new System.Drawing.Size(225, 32);
            this.tbxTypeName.TabIndex = 19;
            this.tbxTypeName.text = "";
            // 
            // tbxIDType
            // 
            this.tbxIDType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.tbxIDType.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbxIDType.BackgroundImage")));
            this.tbxIDType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbxIDType.ForeColor = System.Drawing.Color.White;
            this.tbxIDType.Icon = ((System.Drawing.Image)(resources.GetObject("tbxIDType.Icon")));
            this.tbxIDType.Location = new System.Drawing.Point(252, 126);
            this.tbxIDType.Name = "tbxIDType";
            this.tbxIDType.Size = new System.Drawing.Size(225, 32);
            this.tbxIDType.TabIndex = 18;
            this.tbxIDType.text = "";
            // 
            // btnFindCategory
            // 
            this.btnFindCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.btnFindCategory.Image = global::QuanLyQuanCaFe.Properties.Resources._585e4ae9cb11b227491c3394;
            this.btnFindCategory.ImageActive = null;
            this.btnFindCategory.Location = new System.Drawing.Point(462, 3);
            this.btnFindCategory.Name = "btnFindCategory";
            this.btnFindCategory.Size = new System.Drawing.Size(24, 28);
            this.btnFindCategory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnFindCategory.TabIndex = 29;
            this.btnFindCategory.TabStop = false;
            this.btnFindCategory.Zoom = 10;
            this.btnFindCategory.Click += new System.EventHandler(this.btnFindCategory_Click);
            // 
            // ucDanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Name = "ucDanhMuc";
            this.Size = new System.Drawing.Size(944, 449);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFixCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFindCategory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbDisplay;
        private Bunifu.Framework.UI.BunifuImageButton btnDeleteCategory;
        private Bunifu.Framework.UI.BunifuImageButton btnAddCategory;
        private Bunifu.Framework.UI.BunifuImageButton btnFixCategory;
        private Bunifu.Framework.UI.BunifuImageButton btnShowCategory;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuTextbox tbxTypeName;
        private Bunifu.Framework.UI.BunifuTextbox tbxIDType;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton btnFindCategory;
        private Bunifu.Framework.UI.BunifuMaterialTextbox cbCategoryFind;
        private System.Windows.Forms.DataGridView dtgvCategory;
    }
}
