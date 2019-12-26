namespace QuanLyQuanCaFe.UI.UC_Admin
{
    partial class ucThucAn
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucThucAn));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbFoodFind = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.dtgvFood = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cbCategoryFood = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbDisplay = new System.Windows.Forms.Label();
            this.tbxTemp = new System.Windows.Forms.TextBox();
            this.btnDeleteFood = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnAddFood = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnFixFood = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnShowFood = new Bunifu.Framework.UI.BunifuImageButton();
            this.tbxPriceFood = new Bunifu.Framework.UI.BunifuTextbox();
            this.tbxFoodName = new Bunifu.Framework.UI.BunifuTextbox();
            this.tbxIDFood = new Bunifu.Framework.UI.BunifuTextbox();
            this.btnFindFood = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFood)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFixFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFindFood)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.btnFindFood);
            this.panel1.Controls.Add(this.cbFoodFind);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(455, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(489, 34);
            this.panel1.TabIndex = 0;
            // 
            // cbFoodFind
            // 
            this.cbFoodFind.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cbFoodFind.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cbFoodFind.ForeColor = System.Drawing.Color.White;
            this.cbFoodFind.HintForeColor = System.Drawing.Color.White;
            this.cbFoodFind.HintText = "Search...";
            this.cbFoodFind.isPassword = false;
            this.cbFoodFind.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cbFoodFind.LineIdleColor = System.Drawing.Color.Gray;
            this.cbFoodFind.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.cbFoodFind.LineThickness = 3;
            this.cbFoodFind.Location = new System.Drawing.Point(315, 3);
            this.cbFoodFind.Margin = new System.Windows.Forms.Padding(4);
            this.cbFoodFind.Name = "cbFoodFind";
            this.cbFoodFind.Size = new System.Drawing.Size(140, 26);
            this.cbFoodFind.TabIndex = 29;
            this.cbFoodFind.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // dtgvFood
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgvFood.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvFood.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvFood.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dtgvFood.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvFood.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvFood.Dock = System.Windows.Forms.DockStyle.Left;
            this.dtgvFood.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtgvFood.Location = new System.Drawing.Point(0, 0);
            this.dtgvFood.Name = "dtgvFood";
            this.dtgvFood.ReadOnly = true;
            this.dtgvFood.Size = new System.Drawing.Size(455, 449);
            this.dtgvFood.TabIndex = 28;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.dtgvFood);
            this.panel2.Controls.Add(this.tbxTemp);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(944, 449);
            this.panel2.TabIndex = 29;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbDisplay);
            this.panel3.Controls.Add(this.btnDeleteFood);
            this.panel3.Controls.Add(this.btnAddFood);
            this.panel3.Controls.Add(this.btnFixFood);
            this.panel3.Controls.Add(this.btnShowFood);
            this.panel3.Controls.Add(this.tbxPriceFood);
            this.panel3.Controls.Add(this.bunifuCustomLabel4);
            this.panel3.Controls.Add(this.cbCategoryFood);
            this.panel3.Controls.Add(this.bunifuCustomLabel3);
            this.panel3.Controls.Add(this.bunifuCustomLabel2);
            this.panel3.Controls.Add(this.bunifuCustomLabel1);
            this.panel3.Controls.Add(this.tbxFoodName);
            this.panel3.Controls.Add(this.tbxIDFood);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(455, 34);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(489, 415);
            this.panel3.TabIndex = 29;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(143, 379);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(42, 21);
            this.bunifuCustomLabel4.TabIndex = 17;
            this.bunifuCustomLabel4.Text = "Giá:";
            // 
            // cbCategoryFood
            // 
            this.cbCategoryFood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.cbCategoryFood.ForeColor = System.Drawing.Color.White;
            this.cbCategoryFood.FormattingEnabled = true;
            this.cbCategoryFood.Location = new System.Drawing.Point(252, 258);
            this.cbCategoryFood.Name = "cbCategoryFood";
            this.cbCategoryFood.Size = new System.Drawing.Size(225, 21);
            this.cbCategoryFood.TabIndex = 21;
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
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(143, 137);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(81, 21);
            this.bunifuCustomLabel2.TabIndex = 15;
            this.bunifuCustomLabel2.Text = "Tên món:";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(143, 32);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(31, 21);
            this.bunifuCustomLabel1.TabIndex = 14;
            this.bunifuCustomLabel1.Text = "ID:";
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
            // tbxTemp
            // 
            this.tbxTemp.Location = new System.Drawing.Point(207, 137);
            this.tbxTemp.Name = "tbxTemp";
            this.tbxTemp.Size = new System.Drawing.Size(100, 20);
            this.tbxTemp.TabIndex = 35;
            this.tbxTemp.Visible = false;
            this.tbxTemp.TextChanged += new System.EventHandler(this.tbxTemp_TextChanged);
            // 
            // btnDeleteFood
            // 
            this.btnDeleteFood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.btnDeleteFood.Image = global::QuanLyQuanCaFe.Properties.Resources.delete_1432400_1211078;
            this.btnDeleteFood.ImageActive = null;
            this.btnDeleteFood.Location = new System.Drawing.Point(6, 354);
            this.btnDeleteFood.Name = "btnDeleteFood";
            this.btnDeleteFood.Size = new System.Drawing.Size(62, 46);
            this.btnDeleteFood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDeleteFood.TabIndex = 33;
            this.btnDeleteFood.TabStop = false;
            this.btnDeleteFood.Zoom = 10;
            this.btnDeleteFood.Click += new System.EventHandler(this.btnDeleteFood_Click);
            this.btnDeleteFood.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnDeleteFood_MouseMove);
            // 
            // btnAddFood
            // 
            this.btnAddFood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.btnAddFood.Image = global::QuanLyQuanCaFe.Properties.Resources.add_plus_512;
            this.btnAddFood.ImageActive = null;
            this.btnAddFood.Location = new System.Drawing.Point(6, 112);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(62, 46);
            this.btnAddFood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAddFood.TabIndex = 32;
            this.btnAddFood.TabStop = false;
            this.btnAddFood.Zoom = 10;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            this.btnAddFood.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnAddFood_MouseMove);
            // 
            // btnFixFood
            // 
            this.btnFixFood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.btnFixFood.Image = global::QuanLyQuanCaFe.Properties.Resources._39_512;
            this.btnFixFood.ImageActive = null;
            this.btnFixFood.Location = new System.Drawing.Point(6, 233);
            this.btnFixFood.Name = "btnFixFood";
            this.btnFixFood.Size = new System.Drawing.Size(62, 46);
            this.btnFixFood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnFixFood.TabIndex = 31;
            this.btnFixFood.TabStop = false;
            this.btnFixFood.Zoom = 10;
            this.btnFixFood.Click += new System.EventHandler(this.btnFixFood_Click);
            this.btnFixFood.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnFixFood_MouseMove);
            // 
            // btnShowFood
            // 
            this.btnShowFood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.btnShowFood.Image = global::QuanLyQuanCaFe.Properties.Resources.visibility_512;
            this.btnShowFood.ImageActive = null;
            this.btnShowFood.Location = new System.Drawing.Point(6, 7);
            this.btnShowFood.Name = "btnShowFood";
            this.btnShowFood.Size = new System.Drawing.Size(62, 46);
            this.btnShowFood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnShowFood.TabIndex = 30;
            this.btnShowFood.TabStop = false;
            this.btnShowFood.Zoom = 10;
            this.btnShowFood.Click += new System.EventHandler(this.btnShowFood_Click);
            this.btnShowFood.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnShowFood_MouseMove);
            // 
            // tbxPriceFood
            // 
            this.tbxPriceFood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.tbxPriceFood.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbxPriceFood.BackgroundImage")));
            this.tbxPriceFood.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbxPriceFood.ForeColor = System.Drawing.Color.White;
            this.tbxPriceFood.Icon = ((System.Drawing.Image)(resources.GetObject("tbxPriceFood.Icon")));
            this.tbxPriceFood.Location = new System.Drawing.Point(252, 368);
            this.tbxPriceFood.Name = "tbxPriceFood";
            this.tbxPriceFood.Size = new System.Drawing.Size(225, 32);
            this.tbxPriceFood.TabIndex = 20;
            this.tbxPriceFood.text = "";
            // 
            // tbxFoodName
            // 
            this.tbxFoodName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.tbxFoodName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbxFoodName.BackgroundImage")));
            this.tbxFoodName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbxFoodName.ForeColor = System.Drawing.Color.White;
            this.tbxFoodName.Icon = ((System.Drawing.Image)(resources.GetObject("tbxFoodName.Icon")));
            this.tbxFoodName.Location = new System.Drawing.Point(252, 126);
            this.tbxFoodName.Name = "tbxFoodName";
            this.tbxFoodName.Size = new System.Drawing.Size(225, 32);
            this.tbxFoodName.TabIndex = 19;
            this.tbxFoodName.text = "";
            // 
            // tbxIDFood
            // 
            this.tbxIDFood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.tbxIDFood.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbxIDFood.BackgroundImage")));
            this.tbxIDFood.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbxIDFood.ForeColor = System.Drawing.Color.White;
            this.tbxIDFood.Icon = ((System.Drawing.Image)(resources.GetObject("tbxIDFood.Icon")));
            this.tbxIDFood.Location = new System.Drawing.Point(252, 21);
            this.tbxIDFood.Name = "tbxIDFood";
            this.tbxIDFood.Size = new System.Drawing.Size(225, 32);
            this.tbxIDFood.TabIndex = 18;
            this.tbxIDFood.text = "";
            // 
            // btnFindFood
            // 
            this.btnFindFood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.btnFindFood.Image = global::QuanLyQuanCaFe.Properties.Resources._585e4ae9cb11b227491c3394;
            this.btnFindFood.ImageActive = null;
            this.btnFindFood.Location = new System.Drawing.Point(462, 3);
            this.btnFindFood.Name = "btnFindFood";
            this.btnFindFood.Size = new System.Drawing.Size(24, 28);
            this.btnFindFood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnFindFood.TabIndex = 29;
            this.btnFindFood.TabStop = false;
            this.btnFindFood.Zoom = 10;
            this.btnFindFood.Click += new System.EventHandler(this.btnFindFood_Click);
            // 
            // ucThucAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Name = "ucThucAn";
            this.Size = new System.Drawing.Size(944, 449);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFood)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFixFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFindFood)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgvFood;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuImageButton btnFindFood;
        private Bunifu.Framework.UI.BunifuMaterialTextbox cbFoodFind;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuTextbox tbxPriceFood;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private System.Windows.Forms.ComboBox cbCategoryFood;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuTextbox tbxFoodName;
        private Bunifu.Framework.UI.BunifuTextbox tbxIDFood;
        private Bunifu.Framework.UI.BunifuImageButton btnDeleteFood;
        private Bunifu.Framework.UI.BunifuImageButton btnAddFood;
        private Bunifu.Framework.UI.BunifuImageButton btnFixFood;
        private Bunifu.Framework.UI.BunifuImageButton btnShowFood;
        private System.Windows.Forms.Label lbDisplay;
        private System.Windows.Forms.TextBox tbxTemp;
    }
}
