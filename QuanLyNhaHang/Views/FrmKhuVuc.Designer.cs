namespace QuanLyNhaHang.Views
{
    partial class FrmKhuVuc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKhuVuc));
            this.txtDienGiaiKV = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grQuanLyNV = new System.Windows.Forms.GroupBox();
            this.cmbTrangThaiKV = new System.Windows.Forms.ComboBox();
            this.txtTenKV = new System.Windows.Forms.TextBox();
            this.txtIdKhuVuc = new System.Windows.Forms.TextBox();
            this.grDanhSachKV = new System.Windows.Forms.GroupBox();
            this.dgvDanhSachKV = new System.Windows.Forms.DataGridView();
            this.IdKhuVuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhuVuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DienGiai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label12 = new System.Windows.Forms.Label();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.grQuanLyNV.SuspendLayout();
            this.grDanhSachKV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachKV)).BeginInit();
            this.groupPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDienGiaiKV
            // 
            this.txtDienGiaiKV.BackColor = System.Drawing.Color.White;
            this.txtDienGiaiKV.ForeColor = System.Drawing.Color.Black;
            this.txtDienGiaiKV.Location = new System.Drawing.Point(741, 19);
            this.txtDienGiaiKV.Multiline = true;
            this.txtDienGiaiKV.Name = "txtDienGiaiKV";
            this.txtDienGiaiKV.Size = new System.Drawing.Size(269, 64);
            this.txtDienGiaiKV.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(34, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 77;
            this.label10.Text = "Trạng Thái :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(669, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 78;
            this.label8.Text = "Diễn Giải :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(330, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 65;
            this.label2.Text = "Tên Khu Vực :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(33, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 71;
            this.label6.Text = "Id Khu Vực :";
            // 
            // grQuanLyNV
            // 
            this.grQuanLyNV.BackColor = System.Drawing.Color.Transparent;
            this.grQuanLyNV.Controls.Add(this.cmbTrangThaiKV);
            this.grQuanLyNV.Controls.Add(this.label10);
            this.grQuanLyNV.Controls.Add(this.txtDienGiaiKV);
            this.grQuanLyNV.Controls.Add(this.label8);
            this.grQuanLyNV.Controls.Add(this.txtTenKV);
            this.grQuanLyNV.Controls.Add(this.label2);
            this.grQuanLyNV.Controls.Add(this.txtIdKhuVuc);
            this.grQuanLyNV.Controls.Add(this.label6);
            this.grQuanLyNV.ForeColor = System.Drawing.Color.Black;
            this.grQuanLyNV.Location = new System.Drawing.Point(43, 36);
            this.grQuanLyNV.Name = "grQuanLyNV";
            this.grQuanLyNV.Size = new System.Drawing.Size(1031, 104);
            this.grQuanLyNV.TabIndex = 87;
            this.grQuanLyNV.TabStop = false;
            this.grQuanLyNV.Text = "THÔNG TIN KHU VỰC";
            // 
            // cmbTrangThaiKV
            // 
            this.cmbTrangThaiKV.BackColor = System.Drawing.Color.White;
            this.cmbTrangThaiKV.ForeColor = System.Drawing.Color.Black;
            this.cmbTrangThaiKV.FormattingEnabled = true;
            this.cmbTrangThaiKV.Location = new System.Drawing.Point(114, 62);
            this.cmbTrangThaiKV.Name = "cmbTrangThaiKV";
            this.cmbTrangThaiKV.Size = new System.Drawing.Size(151, 21);
            this.cmbTrangThaiKV.TabIndex = 79;
            // 
            // txtTenKV
            // 
            this.txtTenKV.BackColor = System.Drawing.Color.White;
            this.txtTenKV.ForeColor = System.Drawing.Color.Black;
            this.txtTenKV.Location = new System.Drawing.Point(412, 43);
            this.txtTenKV.Name = "txtTenKV";
            this.txtTenKV.Size = new System.Drawing.Size(222, 20);
            this.txtTenKV.TabIndex = 0;
            // 
            // txtIdKhuVuc
            // 
            this.txtIdKhuVuc.BackColor = System.Drawing.Color.White;
            this.txtIdKhuVuc.Enabled = false;
            this.txtIdKhuVuc.ForeColor = System.Drawing.Color.Black;
            this.txtIdKhuVuc.Location = new System.Drawing.Point(114, 25);
            this.txtIdKhuVuc.Name = "txtIdKhuVuc";
            this.txtIdKhuVuc.Size = new System.Drawing.Size(151, 20);
            this.txtIdKhuVuc.TabIndex = 73;
            this.txtIdKhuVuc.TabStop = false;
            // 
            // grDanhSachKV
            // 
            this.grDanhSachKV.BackColor = System.Drawing.Color.White;
            this.grDanhSachKV.Controls.Add(this.dgvDanhSachKV);
            this.grDanhSachKV.ForeColor = System.Drawing.Color.Black;
            this.grDanhSachKV.Location = new System.Drawing.Point(40, 284);
            this.grDanhSachKV.Name = "grDanhSachKV";
            this.grDanhSachKV.Size = new System.Drawing.Size(1034, 181);
            this.grDanhSachKV.TabIndex = 88;
            this.grDanhSachKV.TabStop = false;
            // 
            // dgvDanhSachKV
            // 
            this.dgvDanhSachKV.AllowUserToAddRows = false;
            this.dgvDanhSachKV.AllowUserToDeleteRows = false;
            this.dgvDanhSachKV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachKV.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvDanhSachKV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachKV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdKhuVuc,
            this.TenKhuVuc,
            this.DienGiai,
            this.TrangThai});
            this.dgvDanhSachKV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvDanhSachKV.Location = new System.Drawing.Point(3, 0);
            this.dgvDanhSachKV.Name = "dgvDanhSachKV";
            this.dgvDanhSachKV.ReadOnly = true;
            this.dgvDanhSachKV.Size = new System.Drawing.Size(1031, 181);
            this.dgvDanhSachKV.TabIndex = 89;
            // 
            // IdKhuVuc
            // 
            this.IdKhuVuc.DataPropertyName = "IdKhuVuc";
            this.IdKhuVuc.HeaderText = "Id Khu Vực";
            this.IdKhuVuc.Name = "IdKhuVuc";
            this.IdKhuVuc.ReadOnly = true;
            // 
            // TenKhuVuc
            // 
            this.TenKhuVuc.DataPropertyName = "TenKhuVuc";
            this.TenKhuVuc.HeaderText = "Tên Khu Vực";
            this.TenKhuVuc.Name = "TenKhuVuc";
            this.TenKhuVuc.ReadOnly = true;
            // 
            // DienGiai
            // 
            this.DienGiai.DataPropertyName = "DienGiai";
            this.DienGiai.HeaderText = "Diễn Giải";
            this.DienGiai.Name = "DienGiai";
            this.DienGiai.ReadOnly = true;
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng Thái";
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(455, 254);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(175, 17);
            this.label12.TabIndex = 94;
            this.label12.Text = "DANH SÁCH KHU VỰC";
            // 
            // groupPanel1
            // 
            this.groupPanel1.BackColor = System.Drawing.Color.White;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.groupPanel1.Controls.Add(this.btnThemMoi);
            this.groupPanel1.Controls.Add(this.label12);
            this.groupPanel1.Controls.Add(this.btnHuy);
            this.groupPanel1.Controls.Add(this.grDanhSachKV);
            this.groupPanel1.Controls.Add(this.btnXoa);
            this.groupPanel1.Controls.Add(this.grQuanLyNV);
            this.groupPanel1.Controls.Add(this.btnLuu);
            this.groupPanel1.Controls.Add(this.btnSua);
            this.groupPanel1.Location = new System.Drawing.Point(12, 12);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(1114, 506);
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
            this.groupPanel1.TabIndex = 96;
            this.groupPanel1.Text = "Thông Tin Khu Vực";
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.BackColor = System.Drawing.Color.White;
            this.btnThemMoi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThemMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMoi.ForeColor = System.Drawing.Color.Black;
            this.btnThemMoi.Image = global::QuanLyNhaHang.Properties.Resources.Them;
            this.btnThemMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemMoi.Location = new System.Drawing.Point(263, 171);
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
            this.btnHuy.Location = new System.Drawing.Point(715, 171);
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
            this.btnXoa.Location = new System.Drawing.Point(602, 171);
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
            this.btnLuu.Location = new System.Drawing.Point(489, 171);
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
            this.btnSua.Location = new System.Drawing.Point(376, 171);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(107, 57);
            this.btnSua.TabIndex = 76;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // FrmKhuVuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1138, 530);
            this.Controls.Add(this.groupPanel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmKhuVuc";
            this.Text = "Quản Lý Khu Vực";
            this.Load += new System.EventHandler(this.FrmKhuVuc_Load);
            this.grQuanLyNV.ResumeLayout(false);
            this.grQuanLyNV.PerformLayout();
            this.grDanhSachKV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachKV)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtDienGiaiKV;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grQuanLyNV;
        private System.Windows.Forms.TextBox txtTenKV;
        private System.Windows.Forms.TextBox txtIdKhuVuc;
        private System.Windows.Forms.GroupBox grDanhSachKV;
        private System.Windows.Forms.ComboBox cmbTrangThaiKV;
        private System.Windows.Forms.DataGridView dgvDanhSachKV;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdKhuVuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhuVuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn DienGiai;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.Label label12;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
    }
}