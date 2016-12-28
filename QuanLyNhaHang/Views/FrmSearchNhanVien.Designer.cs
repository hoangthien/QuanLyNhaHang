namespace QuanLyNhaHang.Views
{
    partial class FrmSearchNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSearchNhanVien));
            this.dgvDanhSachNV = new System.Windows.Forms.DataGridView();
            this.grDanhSachNV = new System.Windows.Forms.GroupBox();
            this.cmbFind = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachNV)).BeginInit();
            this.grDanhSachNV.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDanhSachNV
            // 
            this.dgvDanhSachNV.AllowUserToAddRows = false;
            this.dgvDanhSachNV.AllowUserToDeleteRows = false;
            this.dgvDanhSachNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachNV.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvDanhSachNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSachNV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvDanhSachNV.Location = new System.Drawing.Point(3, 16);
            this.dgvDanhSachNV.Name = "dgvDanhSachNV";
            this.dgvDanhSachNV.ReadOnly = true;
            this.dgvDanhSachNV.Size = new System.Drawing.Size(1073, 374);
            this.dgvDanhSachNV.TabIndex = 60;
            // 
            // grDanhSachNV
            // 
            this.grDanhSachNV.BackColor = System.Drawing.Color.Transparent;
            this.grDanhSachNV.Controls.Add(this.dgvDanhSachNV);
            this.grDanhSachNV.ForeColor = System.Drawing.Color.Transparent;
            this.grDanhSachNV.Location = new System.Drawing.Point(3, 101);
            this.grDanhSachNV.Name = "grDanhSachNV";
            this.grDanhSachNV.Size = new System.Drawing.Size(1079, 393);
            this.grDanhSachNV.TabIndex = 62;
            this.grDanhSachNV.TabStop = false;
            // 
            // cmbFind
            // 
            this.cmbFind.BackColor = System.Drawing.Color.White;
            this.cmbFind.ForeColor = System.Drawing.Color.Black;
            this.cmbFind.FormattingEnabled = true;
            this.cmbFind.Location = new System.Drawing.Point(246, 28);
            this.cmbFind.Name = "cmbFind";
            this.cmbFind.Size = new System.Drawing.Size(235, 21);
            this.cmbFind.TabIndex = 63;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(93, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 17);
            this.label1.TabIndex = 64;
            this.label1.Text = "TÌM KIẾM THEO";
            // 
            // txtFind
            // 
            this.txtFind.BackColor = System.Drawing.Color.White;
            this.txtFind.ForeColor = System.Drawing.Color.Black;
            this.txtFind.Location = new System.Drawing.Point(515, 28);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(244, 20);
            this.txtFind.TabIndex = 65;
            this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChanged);
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.White;
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnFind.ForeColor = System.Drawing.Color.Black;
            this.btnFind.Image = global::QuanLyNhaHang.Properties.Resources.Edit;
            this.btnFind.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFind.Location = new System.Drawing.Point(787, 22);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(129, 29);
            this.btnFind.TabIndex = 66;
            this.btnFind.Text = "TÌM KIẾM";
            this.btnFind.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(433, 72);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(160, 17);
            this.label12.TabIndex = 67;
            this.label12.Text = "KẾT QUẢ TÌM KIẾM";
            // 
            // groupPanel1
            // 
            this.groupPanel1.BackColor = System.Drawing.Color.White;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.label1);
            this.groupPanel1.Controls.Add(this.label12);
            this.groupPanel1.Controls.Add(this.grDanhSachNV);
            this.groupPanel1.Controls.Add(this.btnFind);
            this.groupPanel1.Controls.Add(this.cmbFind);
            this.groupPanel1.Controls.Add(this.txtFind);
            this.groupPanel1.Location = new System.Drawing.Point(12, 12);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(1105, 518);
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
            this.groupPanel1.TabIndex = 68;
            this.groupPanel1.Text = "Tìm Kiếm Nhân Viên";
            // 
            // FrmSearchNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 542);
            this.Controls.Add(this.groupPanel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSearchNhanVien";
            this.Text = "TÌM KIẾM NHÂN VIÊN";
            this.Load += new System.EventHandler(this.FrmSearchNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachNV)).EndInit();
            this.grDanhSachNV.ResumeLayout(false);
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDanhSachNV;
        private System.Windows.Forms.GroupBox grDanhSachNV;
        private System.Windows.Forms.ComboBox cmbFind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label label12;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
    }
}