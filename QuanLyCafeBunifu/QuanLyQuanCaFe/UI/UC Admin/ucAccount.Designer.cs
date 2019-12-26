namespace QuanLyQuanCaFe.UI.UC_Admin
{
    partial class ucAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucAccount));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ResetPassword = new Bunifu.Framework.UI.BunifuThinButton2();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbDisplay = new System.Windows.Forms.Label();
            this.btnDeleteAccount = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnAddAccount = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnFixAccount = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnShowAccount = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tbxDisplayAcount = new Bunifu.Framework.UI.BunifuTextbox();
            this.tbxNameAcount = new Bunifu.Framework.UI.BunifuTextbox();
            this.dtgvAccount = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFixAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.dtgvAccount);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(944, 449);
            this.panel2.TabIndex = 32;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ResetPassword);
            this.panel3.Controls.Add(this.numericUpDown1);
            this.panel3.Controls.Add(this.bunifuCustomLabel2);
            this.panel3.Controls.Add(this.lbDisplay);
            this.panel3.Controls.Add(this.btnDeleteAccount);
            this.panel3.Controls.Add(this.btnAddAccount);
            this.panel3.Controls.Add(this.btnFixAccount);
            this.panel3.Controls.Add(this.btnShowAccount);
            this.panel3.Controls.Add(this.bunifuCustomLabel3);
            this.panel3.Controls.Add(this.bunifuCustomLabel1);
            this.panel3.Controls.Add(this.tbxDisplayAcount);
            this.panel3.Controls.Add(this.tbxNameAcount);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(455, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(489, 449);
            this.panel3.TabIndex = 29;
            // 
            // ResetPassword
            // 
            this.ResetPassword.ActiveBorderThickness = 1;
            this.ResetPassword.ActiveCornerRadius = 20;
            this.ResetPassword.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.ResetPassword.ActiveForecolor = System.Drawing.Color.White;
            this.ResetPassword.ActiveLineColor = System.Drawing.Color.Teal;
            this.ResetPassword.AllowDrop = true;
            this.ResetPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.ResetPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ResetPassword.BackgroundImage")));
            this.ResetPassword.ButtonText = "Reset PassWord";
            this.ResetPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResetPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetPassword.ForeColor = System.Drawing.Color.SeaGreen;
            this.ResetPassword.IdleBorderThickness = 1;
            this.ResetPassword.IdleCornerRadius = 1;
            this.ResetPassword.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.ResetPassword.IdleForecolor = System.Drawing.Color.White;
            this.ResetPassword.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.ResetPassword.Location = new System.Drawing.Point(328, 369);
            this.ResetPassword.Margin = new System.Windows.Forms.Padding(5);
            this.ResetPassword.Name = "ResetPassword";
            this.ResetPassword.Size = new System.Drawing.Size(149, 41);
            this.ResetPassword.TabIndex = 37;
            this.ResetPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ResetPassword.Click += new System.EventHandler(this.ResetPassword_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(252, 320);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(225, 20);
            this.numericUpDown1.TabIndex = 36;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(103, 316);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(119, 21);
            this.bunifuCustomLabel2.TabIndex = 35;
            this.bunifuCustomLabel2.Text = "Loại tài khoản:";
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
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.btnDeleteAccount.Image = global::QuanLyQuanCaFe.Properties.Resources.delete_1432400_1211078;
            this.btnDeleteAccount.ImageActive = null;
            this.btnDeleteAccount.Location = new System.Drawing.Point(6, 354);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(62, 46);
            this.btnDeleteAccount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDeleteAccount.TabIndex = 33;
            this.btnDeleteAccount.TabStop = false;
            this.btnDeleteAccount.Zoom = 10;
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);
            this.btnDeleteAccount.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnDeleteAccount_MouseMove);
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.btnAddAccount.Image = global::QuanLyQuanCaFe.Properties.Resources.add_plus_512;
            this.btnAddAccount.ImageActive = null;
            this.btnAddAccount.Location = new System.Drawing.Point(6, 112);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(62, 46);
            this.btnAddAccount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAddAccount.TabIndex = 32;
            this.btnAddAccount.TabStop = false;
            this.btnAddAccount.Zoom = 10;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            this.btnAddAccount.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnAddAccount_MouseMove);
            // 
            // btnFixAccount
            // 
            this.btnFixAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.btnFixAccount.Image = global::QuanLyQuanCaFe.Properties.Resources._39_512;
            this.btnFixAccount.ImageActive = null;
            this.btnFixAccount.Location = new System.Drawing.Point(6, 233);
            this.btnFixAccount.Name = "btnFixAccount";
            this.btnFixAccount.Size = new System.Drawing.Size(62, 46);
            this.btnFixAccount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnFixAccount.TabIndex = 31;
            this.btnFixAccount.TabStop = false;
            this.btnFixAccount.Zoom = 10;
            this.btnFixAccount.Click += new System.EventHandler(this.btnFixAccount_Click);
            this.btnFixAccount.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnFixAccount_MouseMove);
            // 
            // btnShowAccount
            // 
            this.btnShowAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.btnShowAccount.Image = global::QuanLyQuanCaFe.Properties.Resources.visibility_512;
            this.btnShowAccount.ImageActive = null;
            this.btnShowAccount.Location = new System.Drawing.Point(6, 7);
            this.btnShowAccount.Name = "btnShowAccount";
            this.btnShowAccount.Size = new System.Drawing.Size(62, 46);
            this.btnShowAccount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnShowAccount.TabIndex = 30;
            this.btnShowAccount.TabStop = false;
            this.btnShowAccount.Zoom = 10;
            this.btnShowAccount.Click += new System.EventHandler(this.btnShowAccount_Click);
            this.btnShowAccount.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnShowAccount_MouseMove);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(103, 195);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(102, 21);
            this.bunifuCustomLabel3.TabIndex = 16;
            this.bunifuCustomLabel3.Text = "Tên hiển thị:";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(103, 78);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(118, 21);
            this.bunifuCustomLabel1.TabIndex = 14;
            this.bunifuCustomLabel1.Text = "Tên tài khoản:";
            // 
            // tbxDisplayAcount
            // 
            this.tbxDisplayAcount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.tbxDisplayAcount.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbxDisplayAcount.BackgroundImage")));
            this.tbxDisplayAcount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbxDisplayAcount.ForeColor = System.Drawing.Color.White;
            this.tbxDisplayAcount.Icon = ((System.Drawing.Image)(resources.GetObject("tbxDisplayAcount.Icon")));
            this.tbxDisplayAcount.Location = new System.Drawing.Point(252, 184);
            this.tbxDisplayAcount.Name = "tbxDisplayAcount";
            this.tbxDisplayAcount.Size = new System.Drawing.Size(225, 32);
            this.tbxDisplayAcount.TabIndex = 19;
            this.tbxDisplayAcount.text = "";
            // 
            // tbxNameAcount
            // 
            this.tbxNameAcount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.tbxNameAcount.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbxNameAcount.BackgroundImage")));
            this.tbxNameAcount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbxNameAcount.ForeColor = System.Drawing.Color.White;
            this.tbxNameAcount.Icon = ((System.Drawing.Image)(resources.GetObject("tbxNameAcount.Icon")));
            this.tbxNameAcount.Location = new System.Drawing.Point(252, 67);
            this.tbxNameAcount.Name = "tbxNameAcount";
            this.tbxNameAcount.Size = new System.Drawing.Size(225, 32);
            this.tbxNameAcount.TabIndex = 18;
            this.tbxNameAcount.text = "";
            // 
            // dtgvAccount
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgvAccount.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dtgvAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvAccount.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dtgvAccount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvAccount.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dtgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvAccount.Dock = System.Windows.Forms.DockStyle.Left;
            this.dtgvAccount.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtgvAccount.Location = new System.Drawing.Point(0, 0);
            this.dtgvAccount.Name = "dtgvAccount";
            this.dtgvAccount.ReadOnly = true;
            this.dtgvAccount.Size = new System.Drawing.Size(455, 449);
            this.dtgvAccount.TabIndex = 28;
            // 
            // ucAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Name = "ucAccount";
            this.Size = new System.Drawing.Size(944, 449);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFixAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.Label lbDisplay;
        private Bunifu.Framework.UI.BunifuImageButton btnDeleteAccount;
        private Bunifu.Framework.UI.BunifuImageButton btnAddAccount;
        private Bunifu.Framework.UI.BunifuImageButton btnFixAccount;
        private Bunifu.Framework.UI.BunifuImageButton btnShowAccount;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuTextbox tbxDisplayAcount;
        private Bunifu.Framework.UI.BunifuTextbox tbxNameAcount;
        private System.Windows.Forms.DataGridView dtgvAccount;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private Bunifu.Framework.UI.BunifuThinButton2 ResetPassword;
    }
}
