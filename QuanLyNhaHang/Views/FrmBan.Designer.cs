namespace QuanLyNhaHang.Views
{
    partial class FrmBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBan));
            this.grDanhSachBan = new System.Windows.Forms.GroupBox();
            this.dgvDanhSachBan = new System.Windows.Forms.DataGridView();
            this.IdBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhuVucb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DienGiaib = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThaib = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.grThongTinBan = new System.Windows.Forms.GroupBox();
            this.cmbTenKhuVuc = new System.Windows.Forms.ComboBox();
            this.cmbTrangThaiBan = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDienGiaiBan = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTenBan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdBan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.grDanhSachBan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachBan)).BeginInit();
            this.grThongTinBan.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grDanhSachBan
            // 
            this.grDanhSachBan.BackColor = System.Drawing.Color.Transparent;
            this.grDanhSachBan.Controls.Add(this.dgvDanhSachBan);
            this.grDanhSachBan.ForeColor = System.Drawing.Color.Black;
            this.grDanhSachBan.Location = new System.Drawing.Point(70, 230);
            this.grDanhSachBan.Name = "grDanhSachBan";
            this.grDanhSachBan.Size = new System.Drawing.Size(982, 244);
            this.grDanhSachBan.TabIndex = 90;
            this.grDanhSachBan.TabStop = false;
            // 
            // dgvDanhSachBan
            // 
            this.dgvDanhSachBan.AllowUserToAddRows = false;
            this.dgvDanhSachBan.AllowUserToDeleteRows = false;
            this.dgvDanhSachBan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachBan.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvDanhSachBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachBan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdBan,
            this.TenKhuVucb,
            this.TenBan,
            this.DienGiaib,
            this.TrangThaib});
            this.dgvDanhSachBan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDanhSachBan.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvDanhSachBan.Location = new System.Drawing.Point(3, 11);
            this.dgvDanhSachBan.Name = "dgvDanhSachBan";
            this.dgvDanhSachBan.ReadOnly = true;
            this.dgvDanhSachBan.Size = new System.Drawing.Size(976, 230);
            this.dgvDanhSachBan.TabIndex = 88;
            // 
            // IdBan
            // 
            this.IdBan.DataPropertyName = "IdBan";
            this.IdBan.HeaderText = "Id bàn";
            this.IdBan.Name = "IdBan";
            this.IdBan.ReadOnly = true;
            // 
            // TenKhuVucb
            // 
            this.TenKhuVucb.DataPropertyName = "TenKhuVuc";
            this.TenKhuVucb.HeaderText = "Tên khu vực";
            this.TenKhuVucb.Name = "TenKhuVucb";
            this.TenKhuVucb.ReadOnly = true;
            // 
            // TenBan
            // 
            this.TenBan.DataPropertyName = "TenBan";
            this.TenBan.HeaderText = "Tên bàn";
            this.TenBan.Name = "TenBan";
            this.TenBan.ReadOnly = true;
            // 
            // DienGiaib
            // 
            this.DienGiaib.DataPropertyName = "DienGiai";
            this.DienGiaib.HeaderText = "Diễn giải";
            this.DienGiaib.Name = "DienGiaib";
            this.DienGiaib.ReadOnly = true;
            // 
            // TrangThaib
            // 
            this.TrangThaib.DataPropertyName = "TrangThai";
            this.TrangThaib.HeaderText = "Trạng thái";
            this.TrangThaib.Name = "TrangThaib";
            this.TrangThaib.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(469, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 17);
            this.label1.TabIndex = 87;
            this.label1.Text = "DANH SÁCH BÀN";
            // 
            // grThongTinBan
            // 
            this.grThongTinBan.BackColor = System.Drawing.Color.Transparent;
            this.grThongTinBan.Controls.Add(this.cmbTenKhuVuc);
            this.grThongTinBan.Controls.Add(this.cmbTrangThaiBan);
            this.grThongTinBan.Controls.Add(this.label10);
            this.grThongTinBan.Controls.Add(this.txtDienGiaiBan);
            this.grThongTinBan.Controls.Add(this.label8);
            this.grThongTinBan.Controls.Add(this.txtTenBan);
            this.grThongTinBan.Controls.Add(this.label2);
            this.grThongTinBan.Controls.Add(this.txtIdBan);
            this.grThongTinBan.Controls.Add(this.label3);
            this.grThongTinBan.Controls.Add(this.label6);
            this.grThongTinBan.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grThongTinBan.ForeColor = System.Drawing.Color.Black;
            this.grThongTinBan.Location = new System.Drawing.Point(70, 14);
            this.grThongTinBan.Name = "grThongTinBan";
            this.grThongTinBan.Size = new System.Drawing.Size(979, 105);
            this.grThongTinBan.TabIndex = 99;
            this.grThongTinBan.TabStop = false;
            this.grThongTinBan.Text = "THÔNG TIN BÀN ĂN";
            // 
            // cmbTenKhuVuc
            // 
            this.cmbTenKhuVuc.BackColor = System.Drawing.Color.White;
            this.cmbTenKhuVuc.ForeColor = System.Drawing.Color.Black;
            this.cmbTenKhuVuc.FormattingEnabled = true;
            this.cmbTenKhuVuc.Location = new System.Drawing.Point(149, 61);
            this.cmbTenKhuVuc.Name = "cmbTenKhuVuc";
            this.cmbTenKhuVuc.Size = new System.Drawing.Size(171, 23);
            this.cmbTenKhuVuc.TabIndex = 97;
            // 
            // cmbTrangThaiBan
            // 
            this.cmbTrangThaiBan.BackColor = System.Drawing.Color.White;
            this.cmbTrangThaiBan.ForeColor = System.Drawing.Color.Black;
            this.cmbTrangThaiBan.FormattingEnabled = true;
            this.cmbTrangThaiBan.Location = new System.Drawing.Point(437, 61);
            this.cmbTrangThaiBan.Name = "cmbTrangThaiBan";
            this.cmbTrangThaiBan.Size = new System.Drawing.Size(197, 23);
            this.cmbTrangThaiBan.TabIndex = 96;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(354, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 15);
            this.label10.TabIndex = 94;
            this.label10.Text = "Trạng Thái :";
            // 
            // txtDienGiaiBan
            // 
            this.txtDienGiaiBan.BackColor = System.Drawing.Color.White;
            this.txtDienGiaiBan.ForeColor = System.Drawing.Color.Black;
            this.txtDienGiaiBan.Location = new System.Drawing.Point(733, 25);
            this.txtDienGiaiBan.Multiline = true;
            this.txtDienGiaiBan.Name = "txtDienGiaiBan";
            this.txtDienGiaiBan.Size = new System.Drawing.Size(177, 60);
            this.txtDienGiaiBan.TabIndex = 90;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(660, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 95;
            this.label8.Text = "Diễn Giải :";
            // 
            // txtTenBan
            // 
            this.txtTenBan.BackColor = System.Drawing.Color.White;
            this.txtTenBan.ForeColor = System.Drawing.Color.Black;
            this.txtTenBan.Location = new System.Drawing.Point(437, 26);
            this.txtTenBan.Name = "txtTenBan";
            this.txtTenBan.Size = new System.Drawing.Size(197, 22);
            this.txtTenBan.TabIndex = 89;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(354, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 91;
            this.label2.Text = "Tên Bàn :";
            // 
            // txtIdBan
            // 
            this.txtIdBan.BackColor = System.Drawing.Color.White;
            this.txtIdBan.Enabled = false;
            this.txtIdBan.ForeColor = System.Drawing.Color.Black;
            this.txtIdBan.Location = new System.Drawing.Point(149, 29);
            this.txtIdBan.Name = "txtIdBan";
            this.txtIdBan.Size = new System.Drawing.Size(171, 22);
            this.txtIdBan.TabIndex = 93;
            this.txtIdBan.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(62, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 92;
            this.label3.Text = "Tên Khu Vực :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(62, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 15);
            this.label6.TabIndex = 92;
            this.label6.Text = "Id Bàn :";
            // 
            // groupPanel1
            // 
            this.groupPanel1.BackColor = System.Drawing.Color.White;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.groupPanel1.Controls.Add(this.btnThemMoi);
            this.groupPanel1.Controls.Add(this.label1);
            this.groupPanel1.Controls.Add(this.btnHuy);
            this.groupPanel1.Controls.Add(this.grThongTinBan);
            this.groupPanel1.Controls.Add(this.btnXoa);
            this.groupPanel1.Controls.Add(this.grDanhSachBan);
            this.groupPanel1.Controls.Add(this.btnLuu);
            this.groupPanel1.Controls.Add(this.btnSua);
            this.groupPanel1.Location = new System.Drawing.Point(12, 12);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(1117, 514);
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
            this.groupPanel1.TabIndex = 100;
            this.groupPanel1.Text = "Thông Tin BÀN ĂN";
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.BackColor = System.Drawing.Color.White;
            this.btnThemMoi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThemMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMoi.ForeColor = System.Drawing.Color.Black;
            this.btnThemMoi.Image = global::QuanLyNhaHang.Properties.Resources.Them;
            this.btnThemMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemMoi.Location = new System.Drawing.Point(246, 136);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(107, 57);
            this.btnThemMoi.TabIndex = 79;
            this.btnThemMoi.Text = "Thêm ";
            this.btnThemMoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemMoi.UseVisualStyleBackColor = false;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.White;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.Black;
            this.btnHuy.Image = global::QuanLyNhaHang.Properties.Resources.Huy;
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(698, 136);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(107, 57);
            this.btnHuy.TabIndex = 78;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.White;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Black;
            this.btnXoa.Image = global::QuanLyNhaHang.Properties.Resources.Xoa;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(585, 136);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(107, 57);
            this.btnXoa.TabIndex = 77;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.White;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.Black;
            this.btnLuu.Image = global::QuanLyNhaHang.Properties.Resources.Luu;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(472, 136);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(107, 57);
            this.btnLuu.TabIndex = 75;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.White;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.Black;
            this.btnSua.Image = global::QuanLyNhaHang.Properties.Resources.Sua;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(359, 136);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(107, 57);
            this.btnSua.TabIndex = 76;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // FrmBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 531);
            this.Controls.Add(this.groupPanel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmBan";
            this.Text = "QUẢN LÝ DANH SÁCH BÀN";
            this.Load += new System.EventHandler(this.FrmBan_Load);
            this.grDanhSachBan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachBan)).EndInit();
            this.grThongTinBan.ResumeLayout(false);
            this.grThongTinBan.PerformLayout();
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grDanhSachBan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grThongTinBan;
        private System.Windows.Forms.ComboBox cmbTrangThaiBan;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDienGiaiBan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTenBan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdBan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbTenKhuVuc;
        private System.Windows.Forms.DataGridView dgvDanhSachBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhuVucb;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn DienGiaib;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThaib;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
    }
}