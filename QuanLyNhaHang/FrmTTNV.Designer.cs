namespace QuanLyNhaHang
{
    partial class FrmTTNV
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label maNVLabel;
            System.Windows.Forms.Label hoTenNVLabel;
            System.Windows.Forms.Label ngaySinhLabel;
            System.Windows.Forms.Label diaChiLabel;
            System.Windows.Forms.Label maChucVuLabel;
            System.Windows.Forms.Label ghiChuLabel;
            System.Windows.Forms.Label gioiTinhLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTTNV));
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.txtStaffCode = new DevExpress.XtraEditors.TextEdit();
            this.txtFullName = new DevExpress.XtraEditors.TextEdit();
            this.dtBirthday = new DevExpress.XtraEditors.DateEdit();
            this.txtAndress = new DevExpress.XtraEditors.TextEdit();
            this.txtPosition = new DevExpress.XtraEditors.TextEdit();
            this.txtNotes = new DevExpress.XtraEditors.TextEdit();
            this.txtGender = new DevExpress.XtraEditors.TextEdit();
            this.btnEdit = new DevComponents.DotNetBar.ButtonX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            maNVLabel = new System.Windows.Forms.Label();
            hoTenNVLabel = new System.Windows.Forms.Label();
            ngaySinhLabel = new System.Windows.Forms.Label();
            diaChiLabel = new System.Windows.Forms.Label();
            maChucVuLabel = new System.Windows.Forms.Label();
            ghiChuLabel = new System.Windows.Forms.Label();
            gioiTinhLabel = new System.Windows.Forms.Label();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtStaffCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFullName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBirthday.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBirthday.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAndress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPosition.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNotes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGender.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // maNVLabel
            // 
            maNVLabel.AutoSize = true;
            maNVLabel.BackColor = System.Drawing.Color.Transparent;
            maNVLabel.ForeColor = System.Drawing.Color.Black;
            maNVLabel.Location = new System.Drawing.Point(389, 20);
            maNVLabel.Name = "maNVLabel";
            maNVLabel.Size = new System.Drawing.Size(41, 13);
            maNVLabel.TabIndex = 0;
            maNVLabel.Text = "Mã NV";
            // 
            // hoTenNVLabel
            // 
            hoTenNVLabel.AutoSize = true;
            hoTenNVLabel.BackColor = System.Drawing.Color.Transparent;
            hoTenNVLabel.ForeColor = System.Drawing.Color.Black;
            hoTenNVLabel.Location = new System.Drawing.Point(15, 20);
            hoTenNVLabel.Name = "hoTenNVLabel";
            hoTenNVLabel.Size = new System.Drawing.Size(57, 13);
            hoTenNVLabel.TabIndex = 2;
            hoTenNVLabel.Text = "Họ Và Tên";
            // 
            // ngaySinhLabel
            // 
            ngaySinhLabel.AutoSize = true;
            ngaySinhLabel.BackColor = System.Drawing.Color.Transparent;
            ngaySinhLabel.ForeColor = System.Drawing.Color.Black;
            ngaySinhLabel.Location = new System.Drawing.Point(15, 72);
            ngaySinhLabel.Name = "ngaySinhLabel";
            ngaySinhLabel.Size = new System.Drawing.Size(59, 13);
            ngaySinhLabel.TabIndex = 4;
            ngaySinhLabel.Text = "Ngày Sinh";
            // 
            // diaChiLabel
            // 
            diaChiLabel.AutoSize = true;
            diaChiLabel.BackColor = System.Drawing.Color.Transparent;
            diaChiLabel.ForeColor = System.Drawing.Color.Black;
            diaChiLabel.Location = new System.Drawing.Point(15, 98);
            diaChiLabel.Name = "diaChiLabel";
            diaChiLabel.Size = new System.Drawing.Size(44, 13);
            diaChiLabel.TabIndex = 6;
            diaChiLabel.Text = "Địa Chỉ";
            // 
            // maChucVuLabel
            // 
            maChucVuLabel.AutoSize = true;
            maChucVuLabel.BackColor = System.Drawing.Color.Transparent;
            maChucVuLabel.ForeColor = System.Drawing.Color.Black;
            maChucVuLabel.Location = new System.Drawing.Point(389, 50);
            maChucVuLabel.Name = "maChucVuLabel";
            maChucVuLabel.Size = new System.Drawing.Size(50, 13);
            maChucVuLabel.TabIndex = 10;
            maChucVuLabel.Text = "Chức Vụ";
            // 
            // ghiChuLabel
            // 
            ghiChuLabel.AutoSize = true;
            ghiChuLabel.BackColor = System.Drawing.Color.Transparent;
            ghiChuLabel.ForeColor = System.Drawing.Color.Black;
            ghiChuLabel.Location = new System.Drawing.Point(389, 76);
            ghiChuLabel.Name = "ghiChuLabel";
            ghiChuLabel.Size = new System.Drawing.Size(49, 13);
            ghiChuLabel.TabIndex = 12;
            ghiChuLabel.Text = "Ghi Chú";
            // 
            // gioiTinhLabel
            // 
            gioiTinhLabel.AutoSize = true;
            gioiTinhLabel.BackColor = System.Drawing.Color.Transparent;
            gioiTinhLabel.ForeColor = System.Drawing.Color.Black;
            gioiTinhLabel.Location = new System.Drawing.Point(15, 46);
            gioiTinhLabel.Name = "gioiTinhLabel";
            gioiTinhLabel.Size = new System.Drawing.Size(53, 13);
            gioiTinhLabel.TabIndex = 14;
            gioiTinhLabel.Text = "Giới Tính";
            // 
            // groupPanel1
            // 
            this.groupPanel1.BackColor = System.Drawing.Color.White;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.btnEdit);
            this.groupPanel1.Controls.Add(this.btnSave);
            this.groupPanel1.Controls.Add(maNVLabel);
            this.groupPanel1.Controls.Add(this.txtStaffCode);
            this.groupPanel1.Controls.Add(hoTenNVLabel);
            this.groupPanel1.Controls.Add(this.txtFullName);
            this.groupPanel1.Controls.Add(ngaySinhLabel);
            this.groupPanel1.Controls.Add(this.dtBirthday);
            this.groupPanel1.Controls.Add(diaChiLabel);
            this.groupPanel1.Controls.Add(this.txtAndress);
            this.groupPanel1.Controls.Add(maChucVuLabel);
            this.groupPanel1.Controls.Add(this.txtPosition);
            this.groupPanel1.Controls.Add(ghiChuLabel);
            this.groupPanel1.Controls.Add(this.txtNotes);
            this.groupPanel1.Controls.Add(gioiTinhLabel);
            this.groupPanel1.Controls.Add(this.txtGender);
            this.groupPanel1.Location = new System.Drawing.Point(12, 12);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(757, 213);
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
            this.groupPanel1.TabIndex = 0;
            this.groupPanel1.Text = "Thông Tin Nhân Viên";
            // 
            // txtStaffCode
            // 
            this.txtStaffCode.Enabled = false;
            this.txtStaffCode.Location = new System.Drawing.Point(481, 17);
            this.txtStaffCode.Name = "txtStaffCode";
            this.txtStaffCode.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtStaffCode.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtStaffCode.Properties.Appearance.Options.UseBackColor = true;
            this.txtStaffCode.Properties.Appearance.Options.UseForeColor = true;
            this.txtStaffCode.Size = new System.Drawing.Size(249, 20);
            this.txtStaffCode.TabIndex = 1;
            // 
            // txtFullName
            // 
            this.txtFullName.Enabled = false;
            this.txtFullName.Location = new System.Drawing.Point(107, 17);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtFullName.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtFullName.Properties.Appearance.Options.UseBackColor = true;
            this.txtFullName.Properties.Appearance.Options.UseForeColor = true;
            this.txtFullName.Size = new System.Drawing.Size(232, 20);
            this.txtFullName.TabIndex = 3;
            // 
            // dtBirthday
            // 
            this.dtBirthday.EditValue = null;
            this.dtBirthday.Enabled = false;
            this.dtBirthday.Location = new System.Drawing.Point(107, 69);
            this.dtBirthday.Name = "dtBirthday";
            this.dtBirthday.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.dtBirthday.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.dtBirthday.Properties.Appearance.Options.UseBackColor = true;
            this.dtBirthday.Properties.Appearance.Options.UseForeColor = true;
            this.dtBirthday.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtBirthday.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtBirthday.Size = new System.Drawing.Size(232, 20);
            this.dtBirthday.TabIndex = 5;
            // 
            // txtAndress
            // 
            this.txtAndress.Enabled = false;
            this.txtAndress.Location = new System.Drawing.Point(107, 95);
            this.txtAndress.Name = "txtAndress";
            this.txtAndress.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtAndress.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtAndress.Properties.Appearance.Options.UseBackColor = true;
            this.txtAndress.Properties.Appearance.Options.UseForeColor = true;
            this.txtAndress.Size = new System.Drawing.Size(232, 20);
            this.txtAndress.TabIndex = 7;
            // 
            // txtPosition
            // 
            this.txtPosition.Enabled = false;
            this.txtPosition.Location = new System.Drawing.Point(481, 47);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtPosition.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtPosition.Properties.Appearance.Options.UseBackColor = true;
            this.txtPosition.Properties.Appearance.Options.UseForeColor = true;
            this.txtPosition.Size = new System.Drawing.Size(249, 20);
            this.txtPosition.TabIndex = 11;
            // 
            // txtNotes
            // 
            this.txtNotes.Enabled = false;
            this.txtNotes.Location = new System.Drawing.Point(481, 73);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtNotes.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtNotes.Properties.Appearance.Options.UseBackColor = true;
            this.txtNotes.Properties.Appearance.Options.UseForeColor = true;
            this.txtNotes.Size = new System.Drawing.Size(249, 20);
            this.txtNotes.TabIndex = 13;
            // 
            // txtGender
            // 
            this.txtGender.Enabled = false;
            this.txtGender.Location = new System.Drawing.Point(107, 43);
            this.txtGender.Name = "txtGender";
            this.txtGender.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtGender.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtGender.Properties.Appearance.Options.UseBackColor = true;
            this.txtGender.Properties.Appearance.Options.UseForeColor = true;
            this.txtGender.Size = new System.Drawing.Size(232, 20);
            this.txtGender.TabIndex = 15;
            // 
            // btnEdit
            // 
            this.btnEdit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEdit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnEdit.Image = global::QuanLyNhaHang.Properties.Resources.Edit;
            this.btnEdit.Location = new System.Drawing.Point(413, 148);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 29);
            this.btnEdit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnEdit.TabIndex = 17;
            this.btnEdit.Text = "SỬA";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Image = global::QuanLyNhaHang.Properties.Resources.save;
            this.btnSave.Location = new System.Drawing.Point(271, 148);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 29);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "LƯU";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FrmTTNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 258);
            this.Controls.Add(this.groupPanel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmTTNV";
            this.Text = "THÔNG TIN NHÂN VIÊN";
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtStaffCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFullName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBirthday.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBirthday.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAndress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPosition.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNotes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGender.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevExpress.XtraEditors.TextEdit txtStaffCode;
        private DevExpress.XtraEditors.TextEdit txtFullName;
        private DevExpress.XtraEditors.DateEdit dtBirthday;
        private DevExpress.XtraEditors.TextEdit txtAndress;
        private DevExpress.XtraEditors.TextEdit txtPosition;
        private DevExpress.XtraEditors.TextEdit txtNotes;
        private DevExpress.XtraEditors.TextEdit txtGender;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.ButtonX btnEdit;
    }
}