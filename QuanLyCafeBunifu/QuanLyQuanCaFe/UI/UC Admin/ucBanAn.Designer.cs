namespace QuanLyQuanCaFe.UI.UC_Admin
{
    partial class ucBanAn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucBanAn));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbDisplay = new System.Windows.Forms.Label();
            this.btnDeleteTable = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnAddTable = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnFixTable = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnShowTable = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tbxTableName = new Bunifu.Framework.UI.BunifuTextbox();
            this.tbxIDTable = new Bunifu.Framework.UI.BunifuTextbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFindTable = new Bunifu.Framework.UI.BunifuImageButton();
            this.cbTableFind = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.dtgvTable = new System.Windows.Forms.DataGridView();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dmStatus = new System.Windows.Forms.DomainUpDown();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFixTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowTable)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFindTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.dtgvTable);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(944, 449);
            this.panel2.TabIndex = 31;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dmStatus);
            this.panel3.Controls.Add(this.bunifuCustomLabel2);
            this.panel3.Controls.Add(this.lbDisplay);
            this.panel3.Controls.Add(this.btnDeleteTable);
            this.panel3.Controls.Add(this.btnAddTable);
            this.panel3.Controls.Add(this.btnFixTable);
            this.panel3.Controls.Add(this.btnShowTable);
            this.panel3.Controls.Add(this.bunifuCustomLabel3);
            this.panel3.Controls.Add(this.bunifuCustomLabel1);
            this.panel3.Controls.Add(this.tbxTableName);
            this.panel3.Controls.Add(this.tbxIDTable);
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
            // btnDeleteTable
            // 
            this.btnDeleteTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.btnDeleteTable.Image = global::QuanLyQuanCaFe.Properties.Resources.delete_1432400_1211078;
            this.btnDeleteTable.ImageActive = null;
            this.btnDeleteTable.Location = new System.Drawing.Point(6, 354);
            this.btnDeleteTable.Name = "btnDeleteTable";
            this.btnDeleteTable.Size = new System.Drawing.Size(62, 46);
            this.btnDeleteTable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDeleteTable.TabIndex = 33;
            this.btnDeleteTable.TabStop = false;
            this.btnDeleteTable.Zoom = 10;
            this.btnDeleteTable.Click += new System.EventHandler(this.btnDeleteTable_Click);
            this.btnDeleteTable.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnDeleteTable_MouseMove);
            // 
            // btnAddTable
            // 
            this.btnAddTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.btnAddTable.Image = global::QuanLyQuanCaFe.Properties.Resources.add_plus_512;
            this.btnAddTable.ImageActive = null;
            this.btnAddTable.Location = new System.Drawing.Point(6, 112);
            this.btnAddTable.Name = "btnAddTable";
            this.btnAddTable.Size = new System.Drawing.Size(62, 46);
            this.btnAddTable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAddTable.TabIndex = 32;
            this.btnAddTable.TabStop = false;
            this.btnAddTable.Zoom = 10;
            this.btnAddTable.Click += new System.EventHandler(this.btnAddTable_Click);
            this.btnAddTable.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnAddTable_MouseMove);
            // 
            // btnFixTable
            // 
            this.btnFixTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.btnFixTable.Image = global::QuanLyQuanCaFe.Properties.Resources._39_512;
            this.btnFixTable.ImageActive = null;
            this.btnFixTable.Location = new System.Drawing.Point(6, 233);
            this.btnFixTable.Name = "btnFixTable";
            this.btnFixTable.Size = new System.Drawing.Size(62, 46);
            this.btnFixTable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnFixTable.TabIndex = 31;
            this.btnFixTable.TabStop = false;
            this.btnFixTable.Zoom = 10;
            this.btnFixTable.Click += new System.EventHandler(this.btnFixTable_Click);
            this.btnFixTable.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnFixTable_MouseMove);
            // 
            // btnShowTable
            // 
            this.btnShowTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.btnShowTable.Image = global::QuanLyQuanCaFe.Properties.Resources.visibility_512;
            this.btnShowTable.ImageActive = null;
            this.btnShowTable.Location = new System.Drawing.Point(6, 7);
            this.btnShowTable.Name = "btnShowTable";
            this.btnShowTable.Size = new System.Drawing.Size(62, 46);
            this.btnShowTable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnShowTable.TabIndex = 30;
            this.btnShowTable.TabStop = false;
            this.btnShowTable.Zoom = 10;
            this.btnShowTable.Click += new System.EventHandler(this.btnShowTable_Click);
            this.btnShowTable.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnShowTable_MouseMove);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(143, 195);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(78, 21);
            this.bunifuCustomLabel3.TabIndex = 16;
            this.bunifuCustomLabel3.Text = "Tên bàn:";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(143, 78);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(31, 21);
            this.bunifuCustomLabel1.TabIndex = 14;
            this.bunifuCustomLabel1.Text = "ID:";
            // 
            // tbxTableName
            // 
            this.tbxTableName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.tbxTableName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbxTableName.BackgroundImage")));
            this.tbxTableName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbxTableName.ForeColor = System.Drawing.Color.White;
            this.tbxTableName.Icon = ((System.Drawing.Image)(resources.GetObject("tbxTableName.Icon")));
            this.tbxTableName.Location = new System.Drawing.Point(252, 184);
            this.tbxTableName.Name = "tbxTableName";
            this.tbxTableName.Size = new System.Drawing.Size(225, 32);
            this.tbxTableName.TabIndex = 19;
            this.tbxTableName.text = "";
            // 
            // tbxIDTable
            // 
            this.tbxIDTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.tbxIDTable.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbxIDTable.BackgroundImage")));
            this.tbxIDTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbxIDTable.ForeColor = System.Drawing.Color.White;
            this.tbxIDTable.Icon = ((System.Drawing.Image)(resources.GetObject("tbxIDTable.Icon")));
            this.tbxIDTable.Location = new System.Drawing.Point(252, 67);
            this.tbxIDTable.Name = "tbxIDTable";
            this.tbxIDTable.Size = new System.Drawing.Size(225, 32);
            this.tbxIDTable.TabIndex = 18;
            this.tbxIDTable.text = "";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.btnFindTable);
            this.panel1.Controls.Add(this.cbTableFind);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(455, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(489, 34);
            this.panel1.TabIndex = 0;
            // 
            // btnFindTable
            // 
            this.btnFindTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.btnFindTable.Image = global::QuanLyQuanCaFe.Properties.Resources._585e4ae9cb11b227491c3394;
            this.btnFindTable.ImageActive = null;
            this.btnFindTable.Location = new System.Drawing.Point(462, 3);
            this.btnFindTable.Name = "btnFindTable";
            this.btnFindTable.Size = new System.Drawing.Size(24, 28);
            this.btnFindTable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnFindTable.TabIndex = 29;
            this.btnFindTable.TabStop = false;
            this.btnFindTable.Zoom = 10;
            this.btnFindTable.Click += new System.EventHandler(this.btnFindTable_Click);
            // 
            // cbTableFind
            // 
            this.cbTableFind.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cbTableFind.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cbTableFind.ForeColor = System.Drawing.Color.White;
            this.cbTableFind.HintForeColor = System.Drawing.Color.White;
            this.cbTableFind.HintText = "Search...";
            this.cbTableFind.isPassword = false;
            this.cbTableFind.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cbTableFind.LineIdleColor = System.Drawing.Color.Gray;
            this.cbTableFind.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.cbTableFind.LineThickness = 3;
            this.cbTableFind.Location = new System.Drawing.Point(315, 3);
            this.cbTableFind.Margin = new System.Windows.Forms.Padding(4);
            this.cbTableFind.Name = "cbTableFind";
            this.cbTableFind.Size = new System.Drawing.Size(140, 26);
            this.cbTableFind.TabIndex = 29;
            this.cbTableFind.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // dtgvTable
            // 
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgvTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle21;
            this.dtgvTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvTable.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dtgvTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.dtgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTable.Dock = System.Windows.Forms.DockStyle.Left;
            this.dtgvTable.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtgvTable.Location = new System.Drawing.Point(0, 0);
            this.dtgvTable.Name = "dtgvTable";
            this.dtgvTable.ReadOnly = true;
            this.dtgvTable.Size = new System.Drawing.Size(455, 449);
            this.dtgvTable.TabIndex = 28;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(143, 320);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(92, 21);
            this.bunifuCustomLabel2.TabIndex = 35;
            this.bunifuCustomLabel2.Text = "Trạng thái:";
            // 
            // dmStatus
            // 
            this.dmStatus.Location = new System.Drawing.Point(252, 321);
            this.dmStatus.Name = "dmStatus";
            this.dmStatus.Size = new System.Drawing.Size(225, 20);
            this.dmStatus.TabIndex = 36;
            this.dmStatus.Text = "Trống";
            // 
            // ucBanAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Name = "ucBanAn";
            this.Size = new System.Drawing.Size(944, 449);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFixTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowTable)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnFindTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbDisplay;
        private Bunifu.Framework.UI.BunifuImageButton btnDeleteTable;
        private Bunifu.Framework.UI.BunifuImageButton btnAddTable;
        private Bunifu.Framework.UI.BunifuImageButton btnFixTable;
        private Bunifu.Framework.UI.BunifuImageButton btnShowTable;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuTextbox tbxTableName;
        private Bunifu.Framework.UI.BunifuTextbox tbxIDTable;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton btnFindTable;
        private Bunifu.Framework.UI.BunifuMaterialTextbox cbTableFind;
        private System.Windows.Forms.DataGridView dtgvTable;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.DomainUpDown dmStatus;
    }
}
