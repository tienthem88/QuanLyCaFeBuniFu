namespace QuanLyQuanCaFe.UI.UC_Admin
{
    partial class ucDoanhThu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucDoanhThu));
            this.dtgvBill = new System.Windows.Forms.DataGridView();
            this.dtpkToDate = new Bunifu.Framework.UI.BunifuDatepicker();
            this.dtpkFromDate = new Bunifu.Framework.UI.BunifuDatepicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThongke = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvBill
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgvBill.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvBill.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dtgvBill.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvBill.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgvBill.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtgvBill.Location = new System.Drawing.Point(0, 39);
            this.dtgvBill.Name = "dtgvBill";
            this.dtgvBill.Size = new System.Drawing.Size(944, 410);
            this.dtgvBill.TabIndex = 28;
            // 
            // dtpkToDate
            // 
            this.dtpkToDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(185)))), ((int)(((byte)(201)))));
            this.dtpkToDate.BorderRadius = 0;
            this.dtpkToDate.ForeColor = System.Drawing.Color.White;
            this.dtpkToDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpkToDate.FormatCustom = null;
            this.dtpkToDate.Location = new System.Drawing.Point(713, 0);
            this.dtpkToDate.Name = "dtpkToDate";
            this.dtpkToDate.Size = new System.Drawing.Size(231, 42);
            this.dtpkToDate.TabIndex = 30;
            this.dtpkToDate.Value = new System.DateTime(2019, 12, 6, 17, 11, 37, 856);
            // 
            // dtpkFromDate
            // 
            this.dtpkFromDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(185)))), ((int)(((byte)(201)))));
            this.dtpkFromDate.BorderRadius = 0;
            this.dtpkFromDate.ForeColor = System.Drawing.Color.White;
            this.dtpkFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpkFromDate.FormatCustom = null;
            this.dtpkFromDate.Location = new System.Drawing.Point(0, 0);
            this.dtpkFromDate.Name = "dtpkFromDate";
            this.dtpkFromDate.Size = new System.Drawing.Size(228, 42);
            this.dtpkFromDate.TabIndex = 29;
            this.dtpkFromDate.Value = new System.DateTime(2019, 12, 6, 17, 11, 37, 856);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.dtpkFromDate);
            this.panel1.Controls.Add(this.dtpkToDate);
            this.panel1.Controls.Add(this.btnThongke);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(944, 39);
            this.panel1.TabIndex = 32;
            // 
            // btnThongke
            // 
            this.btnThongke.ActiveBorderThickness = 1;
            this.btnThongke.ActiveCornerRadius = 20;
            this.btnThongke.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(185)))), ((int)(((byte)(201)))));
            this.btnThongke.ActiveForecolor = System.Drawing.Color.White;
            this.btnThongke.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(185)))), ((int)(((byte)(201)))));
            this.btnThongke.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.btnThongke.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThongke.BackgroundImage")));
            this.btnThongke.ButtonText = "Thống kê";
            this.btnThongke.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThongke.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongke.ForeColor = System.Drawing.Color.White;
            this.btnThongke.IdleBorderThickness = 1;
            this.btnThongke.IdleCornerRadius = 20;
            this.btnThongke.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(62)))), ((int)(((byte)(121)))));
            this.btnThongke.IdleForecolor = System.Drawing.Color.White;
            this.btnThongke.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(62)))), ((int)(((byte)(121)))));
            this.btnThongke.Location = new System.Drawing.Point(413, 0);
            this.btnThongke.Margin = new System.Windows.Forms.Padding(5);
            this.btnThongke.Name = "btnThongke";
            this.btnThongke.Size = new System.Drawing.Size(133, 42);
            this.btnThongke.TabIndex = 31;
            this.btnThongke.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnThongke.Click += new System.EventHandler(this.btnThongke_Click);
            // 
            // ucDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtgvBill);
            this.Name = "ucDoanhThu";
            this.Size = new System.Drawing.Size(944, 449);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvBill;
        private Bunifu.Framework.UI.BunifuThinButton2 btnThongke;
        private Bunifu.Framework.UI.BunifuDatepicker dtpkToDate;
        private Bunifu.Framework.UI.BunifuDatepicker dtpkFromDate;
        private System.Windows.Forms.Panel panel1;
    }
}
