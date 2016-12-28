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
            this.ctxtnenuTabDanhSachBan = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.hiểnThịBànChưaCóNgườiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hiểnThịBànCóNgườiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hiểnThịTấtCảBànToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.pnlGoiMon = new System.Windows.Forms.Panel();
            this.lvDanhSachBan = new System.Windows.Forms.ListView();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnGoimon = new System.Windows.Forms.Button();
            this.btnTinhtien = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvGoiMon = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.ctxtnenuTabDanhSachBan.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoiMon)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctxtnenuTabDanhSachBan
            // 
            this.ctxtnenuTabDanhSachBan.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hiểnThịBànChưaCóNgườiToolStripMenuItem,
            this.hiểnThịBànCóNgườiToolStripMenuItem,
            this.hiểnThịTấtCảBànToolStripMenuItem});
            this.ctxtnenuTabDanhSachBan.Name = "ctxtnenuTabDanhSachBan";
            this.ctxtnenuTabDanhSachBan.Size = new System.Drawing.Size(219, 92);
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
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
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
            // pnlGoiMon
            // 
            this.pnlGoiMon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.pnlGoiMon.ForeColor = System.Drawing.Color.Black;
            this.pnlGoiMon.Location = new System.Drawing.Point(477, 249);
            this.pnlGoiMon.Name = "pnlGoiMon";
            this.pnlGoiMon.Size = new System.Drawing.Size(784, 316);
            this.pnlGoiMon.TabIndex = 16;
            // 
            // lvDanhSachBan
            // 
            this.lvDanhSachBan.BackColor = System.Drawing.Color.White;
            this.lvDanhSachBan.ContextMenuStrip = this.ctxtnenuTabDanhSachBan;
            this.lvDanhSachBan.ForeColor = System.Drawing.Color.Black;
            this.lvDanhSachBan.LargeImageList = this.imageList1;
            this.lvDanhSachBan.Location = new System.Drawing.Point(0, 11);
            this.lvDanhSachBan.Name = "lvDanhSachBan";
            this.lvDanhSachBan.Size = new System.Drawing.Size(471, 554);
            this.lvDanhSachBan.TabIndex = 0;
            this.lvDanhSachBan.UseCompatibleStateImageBehavior = false;
            this.lvDanhSachBan.SelectedIndexChanged += new System.EventHandler(this.lvDanhSachBan_SelectedIndexChanged);
            this.lvDanhSachBan.Click += new System.EventHandler(this.lvDanhSachBan_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.White;
            this.btnMenu.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.Black;
            this.btnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.ImageList = this.imageList1;
            this.btnMenu.Location = new System.Drawing.Point(556, 185);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(120, 58);
            this.btnMenu.TabIndex = 44;
            this.btnMenu.Text = "Menu";
            this.btnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnIn
            // 
            this.btnIn.BackColor = System.Drawing.Color.White;
            this.btnIn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIn.ForeColor = System.Drawing.Color.Black;
            this.btnIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIn.Location = new System.Drawing.Point(934, 185);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(120, 58);
            this.btnIn.TabIndex = 41;
            this.btnIn.Text = "In hóa đơn";
            this.btnIn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIn.UseVisualStyleBackColor = false;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnGoimon
            // 
            this.btnGoimon.BackColor = System.Drawing.Color.White;
            this.btnGoimon.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoimon.ForeColor = System.Drawing.Color.Black;
            this.btnGoimon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGoimon.ImageKey = "catering (1).png";
            this.btnGoimon.ImageList = this.imageList1;
            this.btnGoimon.Location = new System.Drawing.Point(682, 185);
            this.btnGoimon.Name = "btnGoimon";
            this.btnGoimon.Size = new System.Drawing.Size(120, 58);
            this.btnGoimon.TabIndex = 42;
            this.btnGoimon.Text = "Gọi món";
            this.btnGoimon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGoimon.UseVisualStyleBackColor = false;
            this.btnGoimon.Click += new System.EventHandler(this.btnGoimon_Click);
            // 
            // btnTinhtien
            // 
            this.btnTinhtien.BackColor = System.Drawing.Color.White;
            this.btnTinhtien.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTinhtien.ForeColor = System.Drawing.Color.Black;
            this.btnTinhtien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTinhtien.ImageKey = "21216-200.png";
            this.btnTinhtien.ImageList = this.imageList1;
            this.btnTinhtien.Location = new System.Drawing.Point(808, 185);
            this.btnTinhtien.Name = "btnTinhtien";
            this.btnTinhtien.Size = new System.Drawing.Size(120, 58);
            this.btnTinhtien.TabIndex = 43;
            this.btnTinhtien.Text = "Tính tiền";
            this.btnTinhtien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTinhtien.UseVisualStyleBackColor = false;
            this.btnTinhtien.Click += new System.EventHandler(this.btnTinhtien_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.dgvGoiMon);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(477, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(710, 124);
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
            this.dgvGoiMon.Location = new System.Drawing.Point(0, 0);
            this.dgvGoiMon.Name = "dgvGoiMon";
            this.dgvGoiMon.ReadOnly = true;
            this.dgvGoiMon.Size = new System.Drawing.Size(711, 120);
            this.dgvGoiMon.TabIndex = 38;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lblTongTien);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(875, 133);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(313, 33);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 16);
            this.label2.TabIndex = 51;
            this.label2.Text = "Tổng tiền thanh toán :";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.BackColor = System.Drawing.Color.White;
            this.lblTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTongTien.ForeColor = System.Drawing.Color.Black;
            this.lblTongTien.Location = new System.Drawing.Point(169, 14);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(0, 16);
            this.lblTongTien.TabIndex = 50;
            // 
            // FrmGoiMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 529);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.btnGoimon);
            this.Controls.Add(this.btnTinhtien);
            this.Controls.Add(this.pnlGoiMon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvDanhSachBan);
            this.DoubleBuffered = true;
            this.Name = "FrmGoiMon";
            this.Load += new System.EventHandler(this.FrmGoiMon_Load);
            this.ctxtnenuTabDanhSachBan.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoiMon)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.Panel pnlGoiMon;
        private System.Windows.Forms.ListView lvDanhSachBan;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnGoimon;
        private System.Windows.Forms.Button btnTinhtien;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.DataGridView dgvGoiMon;
    }
}