namespace GUI
{
    partial class FrmFacultyManagement
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
            this.cboMaTruongKhoa = new System.Windows.Forms.ComboBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtKhoa = new System.Windows.Forms.TextBox();
            this.txtMaKhoa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgr = new System.Windows.Forms.DataGridView();
            this.MaKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTruongKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgr)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cboMaTruongKhoa);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.txtKhoa);
            this.panel1.Controls.Add(this.txtMaKhoa);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 214);
            this.panel1.TabIndex = 2;
            // 
            // cboMaTruongKhoa
            // 
            this.cboMaTruongKhoa.FormattingEnabled = true;
            this.cboMaTruongKhoa.Location = new System.Drawing.Point(503, 47);
            this.cboMaTruongKhoa.Name = "cboMaTruongKhoa";
            this.cboMaTruongKhoa.Size = new System.Drawing.Size(161, 21);
            this.cboMaTruongKhoa.TabIndex = 12;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(600, 155);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 11;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(432, 155);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(276, 155);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 9;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(139, 155);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtKhoa
            // 
            this.txtKhoa.Location = new System.Drawing.Point(182, 95);
            this.txtKhoa.Name = "txtKhoa";
            this.txtKhoa.Size = new System.Drawing.Size(230, 20);
            this.txtKhoa.TabIndex = 5;
            // 
            // txtMaKhoa
            // 
            this.txtMaKhoa.Location = new System.Drawing.Point(186, 50);
            this.txtMaKhoa.Name = "txtMaKhoa";
            this.txtMaKhoa.Size = new System.Drawing.Size(154, 20);
            this.txtMaKhoa.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(418, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Trưởng Khoa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Khoa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Khoa";
            // 
            // dtgr
            // 
            this.dtgr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgr.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKhoa,
            this.TenKhoa,
            this.MaTruongKhoa});
            this.dtgr.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgr.Location = new System.Drawing.Point(0, 294);
            this.dtgr.Name = "dtgr";
            this.dtgr.Size = new System.Drawing.Size(933, 230);
            this.dtgr.TabIndex = 3;
            this.dtgr.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgr_CellClick);
            // 
            // MaKhoa
            // 
            this.MaKhoa.DataPropertyName = "MaKhoa";
            this.MaKhoa.HeaderText = "Mã Khoa";
            this.MaKhoa.Name = "MaKhoa";
            this.MaKhoa.Width = 250;
            // 
            // TenKhoa
            // 
            this.TenKhoa.DataPropertyName = "TenKhoa";
            this.TenKhoa.HeaderText = "Tên Khoa";
            this.TenKhoa.Name = "TenKhoa";
            this.TenKhoa.Width = 450;
            // 
            // MaTruongKhoa
            // 
            this.MaTruongKhoa.DataPropertyName = "MaTruongKhoa";
            this.MaTruongKhoa.HeaderText = "Mã Trưởng Khoa";
            this.MaTruongKhoa.Name = "MaTruongKhoa";
            this.MaTruongKhoa.Width = 250;
            // 
            // frmFacultyManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(933, 524);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtgr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFacultyManagement";
            this.Text = "Quản lý Khoa";
            this.Load += new System.EventHandler(this.frmFacultyManagement_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgr)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboMaTruongKhoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtKhoa;
        private System.Windows.Forms.TextBox txtMaKhoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgr;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTruongKhoa;
    }
}