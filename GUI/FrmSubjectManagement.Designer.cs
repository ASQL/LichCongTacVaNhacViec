namespace GUI
{
    partial class FrmSubjectManagement
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.cboTruongBoMon = new System.Windows.Forms.ComboBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.cboMaKhoa = new System.Windows.Forms.ComboBox();
            this.txtTenBoMon = new System.Windows.Forms.TextBox();
            this.txtMaBoMon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgr = new System.Windows.Forms.DataGridView();
            this.MaBoMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenBoMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTruongBoMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgr)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.cboTruongBoMon);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.cboMaKhoa);
            this.panel1.Controls.Add(this.txtTenBoMon);
            this.panel1.Controls.Add(this.txtMaBoMon);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 173);
            this.panel1.TabIndex = 0;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(805, 133);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 13;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // cboTruongBoMon
            // 
            this.cboTruongBoMon.FormattingEnabled = true;
            this.cboTruongBoMon.Location = new System.Drawing.Point(210, 76);
            this.cboTruongBoMon.Name = "cboTruongBoMon";
            this.cboTruongBoMon.Size = new System.Drawing.Size(161, 21);
            this.cboTruongBoMon.TabIndex = 12;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(628, 133);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 11;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(433, 133);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(233, 133);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 9;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(58, 133);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cboMaKhoa
            // 
            this.cboMaKhoa.FormattingEnabled = true;
            this.cboMaKhoa.Location = new System.Drawing.Point(603, 75);
            this.cboMaKhoa.Name = "cboMaKhoa";
            this.cboMaKhoa.Size = new System.Drawing.Size(131, 21);
            this.cboMaKhoa.TabIndex = 7;
            // 
            // txtTenBoMon
            // 
            this.txtTenBoMon.Location = new System.Drawing.Point(603, 32);
            this.txtTenBoMon.Name = "txtTenBoMon";
            this.txtTenBoMon.Size = new System.Drawing.Size(192, 20);
            this.txtTenBoMon.TabIndex = 5;
            // 
            // txtMaBoMon
            // 
            this.txtMaBoMon.Location = new System.Drawing.Point(210, 28);
            this.txtMaBoMon.Name = "txtMaBoMon";
            this.txtMaBoMon.Size = new System.Drawing.Size(204, 20);
            this.txtMaBoMon.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(536, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã khoa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Trưởng bộ môn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(531, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên bộ môn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã bộ môn";
            // 
            // dtgr
            // 
            this.dtgr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgr.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaBoMon,
            this.TenBoMon,
            this.MaTruongBoMon,
            this.MaKhoa});
            this.dtgr.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtgr.Location = new System.Drawing.Point(0, 173);
            this.dtgr.Name = "dtgr";
            this.dtgr.ReadOnly = true;
            this.dtgr.Size = new System.Drawing.Size(933, 171);
            this.dtgr.TabIndex = 1;
            this.dtgr.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgr_CellClick);
            // 
            // MaBoMon
            // 
            this.MaBoMon.DataPropertyName = "MaBoMon";
            this.MaBoMon.HeaderText = "Mã Bộ Môn";
            this.MaBoMon.Name = "MaBoMon";
            this.MaBoMon.ReadOnly = true;
            this.MaBoMon.Width = 200;
            // 
            // TenBoMon
            // 
            this.TenBoMon.DataPropertyName = "TenBoMon";
            this.TenBoMon.HeaderText = "Tên Bộ Môn";
            this.TenBoMon.Name = "TenBoMon";
            this.TenBoMon.ReadOnly = true;
            this.TenBoMon.Width = 300;
            // 
            // MaTruongBoMon
            // 
            this.MaTruongBoMon.DataPropertyName = "MaTruongBoMon";
            this.MaTruongBoMon.HeaderText = "Trưởng Bộ Môn";
            this.MaTruongBoMon.Name = "MaTruongBoMon";
            this.MaTruongBoMon.ReadOnly = true;
            this.MaTruongBoMon.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MaTruongBoMon.Width = 200;
            // 
            // MaKhoa
            // 
            this.MaKhoa.DataPropertyName = "MaKhoa";
            this.MaKhoa.HeaderText = "Mã Khoa";
            this.MaKhoa.Name = "MaKhoa";
            this.MaKhoa.ReadOnly = true;
            this.MaKhoa.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MaKhoa.Width = 200;
            // 
            // FrmSubjectManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(933, 524);
            this.Controls.Add(this.dtgr);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSubjectManagement";
            this.Text = "Quản lý bộ môn";
            this.Load += new System.EventHandler(this.frmSubject_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgr)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgr;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cboMaKhoa;
        private System.Windows.Forms.TextBox txtTenBoMon;
        private System.Windows.Forms.TextBox txtMaBoMon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboTruongBoMon;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBoMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenBoMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTruongBoMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKhoa;
    }
}