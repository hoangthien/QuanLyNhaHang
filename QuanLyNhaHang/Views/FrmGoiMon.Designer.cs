namespace QuanLyNhaHang.Views
{
    partial class FrmGoiMon
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGoiMon));
            this.ctxtnenuTabDanhSachBan = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.hiểnThịBànChưaCóNgườiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hiểnThịBànCóNgườiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hiểnThịTấtCảBànToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lvDanhSachBan = new System.Windows.Forms.ListView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvGoiMon = new System.Windows.Forms.DataGridView();
            this.ctxtnenuTabDanhSachBan.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoiMon)).BeginInit();
            this.SuspendLayout();
            // 
            // ctxtnenuTabDanhSachBan
            // 
            this.ctxtnenuTabDanhSachBan.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hiểnThịBànChưaCóNgườiToolStripMenuItem,
            this.hiểnThịBànCóNgườiToolStripMenuItem,
            this.hiểnThịTấtCảBànToolStripMenuItem});
            this.ctxtnenuTabDanhSachBan.Name = "ctxtnenuTabDanhSachBan";
            this.ctxtnenuTabDanhSachBan.Size = new System.Drawing.Size(219, 70);
            // 
            // hiểnThịBànChưaCóNgườiToolStripMenuItem
            // 
            this.hiểnThịBànChưaCóNgườiToolStripMenuItem.Name = "hiểnThịBànChưaCóNgườiToolStripMenuItem";
            this.hiểnThịBànChưaCóNgườiToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.hiểnThịBànChưaCóNgườiToolStripMenuItem.Text = "Hiển thị bàn chưa có người";
            this.hiểnThịBànChưaCóNgườiToolStripMenuItem.Click += new System.EventHandler(this.hiểnThịBànChưaCóNgườiToolStripMenuItem_Click);
            // 
            // hiểnThịBànCóNgườiToolStripMenuItem
            // 
            this.hiểnThịBànCóNgườiToolStripMenuItem.Name = "hiểnThịBànCóNgườiToolStripMenuItem";
            this.hiểnThịBànCóNgườiToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.hiểnThịBànCóNgườiToolStripMenuItem.Text = "Hiển thị bàn có người";
            this.hiểnThịBànCóNgườiToolStripMenuItem.Click += new System.EventHandler(this.hiểnThịBànCóNgườiToolStripMenuItem_Click);
            // 
            // hiểnThịTấtCảBànToolStripMenuItem
            // 
            this.hiểnThịTấtCảBànToolStripMenuItem.Name = "hiểnThịTấtCảBànToolStripMenuItem";
            this.hiểnThịTấtCảBànToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.hiểnThịTấtCảBànToolStripMenuItem.Text = "Cập nhật danh sách bàn";
            this.hiểnThịTấtCảBànToolStripMenuItem.Click += new System.EventHandler(this.hiểnThịTấtCảBànToolStripMenuItem_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "BanTrong.png");
            this.imageList1.Images.SetKeyName(1, "QLKhachHang.png");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Enabled = false;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // lvDanhSachBan
            // 
            this.lvDanhSachBan.BackColor = System.Drawing.Color.White;
            this.lvDanhSachBan.ContextMenuStrip = this.ctxtnenuTabDanhSachBan;
            this.lvDanhSachBan.ForeColor = System.Drawing.Color.Black;
            this.lvDanhSachBan.LargeImageList = this.imageList1;
            this.lvDanhSachBan.Location = new System.Drawing.Point(3, 45);
            this.lvDanhSachBan.Name = "lvDanhSachBan";
            this.lvDanhSachBan.Size = new System.Drawing.Size(379, 458);
            this.lvDanhSachBan.TabIndex = 0;
            this.lvDanhSachBan.UseCompatibleStateImageBehavior = false;
            this.lvDanhSachBan.SelectedIndexChanged += new System.EventHandler(this.lvDanhSachBan_SelectedIndexChanged);
            this.lvDanhSachBan.Click += new System.EventHandler(this.lvDanhSachBan_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lblTongTien);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(728, 435);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(396, 59);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 20);
            this.label2.TabIndex = 51;
            this.label2.Text = "TỔNG TIỀN THANH TOÁN: ";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.BackColor = System.Drawing.Color.Transparent;
            this.lblTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTongTien.ForeColor = System.Drawing.Color.Black;
            this.lblTongTien.Location = new System.Drawing.Point(233, 19);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(0, 20);
            this.lblTongTien.TabIndex = 50;
            // 
            // groupPanel1
            // 
            this.groupPanel1.BackColor = System.Drawing.Color.White;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.groupPanel1.Controls.Add(this.labelControl2);
            this.groupPanel1.Controls.Add(this.labelControl1);
            this.groupPanel1.Controls.Add(this.btnLuu);
            this.groupPanel1.Controls.Add(this.btnSua);
            this.groupPanel1.Controls.Add(this.groupBox2);
            this.groupPanel1.Controls.Add(this.groupBox1);
            this.groupPanel1.Controls.Add(this.lvDanhSachBan);
            this.groupPanel1.Location = new System.Drawing.Point(6, 11);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(1143, 532);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 47;
            this.groupPanel1.Text = "THÔNG TIN THANH TOÁN";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl2.Location = new System.Drawing.Point(510, 12);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(510, 23);
            this.labelControl2.TabIndex = 78;
            this.labelControl2.Text = "THÔNG TIN BÀN VÀ DANH SÁCH MÓN ĂN ĐƯỢC GỌI";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl1.Location = new System.Drawing.Point(71, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(197, 23);
            this.labelControl1.TabIndex = 77;
            this.labelControl1.Text = "DANH SÁCH BÀN ĂN";
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.White;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.Black;
            this.btnLuu.Image = global::QuanLyNhaHang.Properties.Resources.ThanhToan;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(568, 437);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(154, 57);
            this.btnLuu.TabIndex = 75;
            this.btnLuu.Text = "IN HÓA ĐƠN";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.White;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.Black;
            this.btnSua.Image = global::QuanLyNhaHang.Properties.Resources.TinhLuong;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(404, 437);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(150, 57);
            this.btnSua.TabIndex = 76;
            this.btnSua.Text = "TÍNH TIỀN";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnTinhtien_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.dgvGoiMon);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(402, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(728, 374);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            // 
            // dgvGoiMon
            // 
            this.dgvGoiMon.AllowUserToAddRows = false;
            this.dgvGoiMon.AllowUserToDeleteRows = false;
            this.dgvGoiMon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGoiMon.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvGoiMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGoiMon.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvGoiMon.Location = new System.Drawing.Point(6, 15);
            this.dgvGoiMon.Name = "dgvGoiMon";
            this.dgvGoiMon.ReadOnly = true;
            this.dgvGoiMon.Size = new System.Drawing.Size(716, 353);
            this.dgvGoiMon.TabIndex = 38;
            // 
            // FrmGoiMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 544);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmGoiMon";
            this.Text = "TÍNH TIỀN THANH TOÁN";
            this.Load += new System.EventHandler(this.FrmGoiMon_Load);
            this.ctxtnenuTabDanhSachBan.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoiMon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip ctxtnenuTabDanhSachBan;
        private System.Windows.Forms.ToolStripMenuItem hiểnThịBànChưaCóNgườiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hiểnThịBànCóNgườiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hiểnThịTấtCảBànToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvDanhSachBan;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTongTien;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvGoiMon;
    }
}