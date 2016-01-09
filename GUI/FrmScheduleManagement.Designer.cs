namespace GUI
{
    partial class FrmScheduleManagement
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
            this.cboLTaiKhoan = new System.Windows.Forms.ComboBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.cboGioiTinh = new System.Windows.Forms.ComboBox();
            this.cboBoMon = new System.Windows.Forms.ComboBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTenCanBo = new System.Windows.Forms.TextBox();
            this.txtMaCanBo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rtxDetailSche = new System.Windows.Forms.RichTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtFindWork = new System.Windows.Forms.TextBox();
            this.btnFindWork = new System.Windows.Forms.Button();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPlace = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnSaveSche = new System.Windows.Forms.Button();
            this.btnDelSche = new System.Windows.Forms.Button();
            this.btnEditSche = new System.Windows.Forms.Button();
            this.btnAddSche = new System.Windows.Forms.Button();
            this.dtpBeginDate = new System.Windows.Forms.DateTimePicker();
            this.txtWork = new System.Windows.Forms.TextBox();
            this.txtScheduleId = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvSche = new System.Windows.Forms.DataGridView();
            this.MaLich = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenCongViec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoTaCongViec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayBatDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayKetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaBoMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSche)).BeginInit();
            this.SuspendLayout();
            // 
            // cboLTaiKhoan
            // 
            this.cboLTaiKhoan.FormattingEnabled = true;
            this.cboLTaiKhoan.Location = new System.Drawing.Point(576, 97);
            this.cboLTaiKhoan.Name = "cboLTaiKhoan";
            this.cboLTaiKhoan.Size = new System.Drawing.Size(119, 21);
            this.cboLTaiKhoan.TabIndex = 47;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(576, 55);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(119, 20);
            this.txtdiachi.TabIndex = 46;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(531, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 45;
            this.label9.Text = "Địa chỉ";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(611, 153);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 44;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(500, 153);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 43;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(376, 153);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 42;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(245, 153);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 41;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(130, 153);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 40;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Location = new System.Drawing.Point(181, 56);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(131, 20);
            this.dtpNgaySinh.TabIndex = 39;
            // 
            // cboGioiTinh
            // 
            this.cboGioiTinh.FormattingEnabled = true;
            this.cboGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cboGioiTinh.Location = new System.Drawing.Point(591, 15);
            this.cboGioiTinh.Name = "cboGioiTinh";
            this.cboGioiTinh.Size = new System.Drawing.Size(104, 21);
            this.cboGioiTinh.TabIndex = 38;
            // 
            // cboBoMon
            // 
            this.cboBoMon.FormattingEnabled = true;
            this.cboBoMon.Location = new System.Drawing.Point(178, 97);
            this.cboBoMon.Name = "cboBoMon";
            this.cboBoMon.Size = new System.Drawing.Size(134, 21);
            this.cboBoMon.TabIndex = 37;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(371, 96);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(92, 20);
            this.txtSDT.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(329, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "SDT";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(363, 56);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(155, 20);
            this.txtEmail.TabIndex = 34;
            // 
            // txtTenCanBo
            // 
            this.txtTenCanBo.Location = new System.Drawing.Point(368, 15);
            this.txtTenCanBo.Name = "txtTenCanBo";
            this.txtTenCanBo.Size = new System.Drawing.Size(148, 20);
            this.txtTenCanBo.TabIndex = 33;
            // 
            // txtMaCanBo
            // 
            this.txtMaCanBo.Location = new System.Drawing.Point(182, 15);
            this.txtMaCanBo.Name = "txtMaCanBo";
            this.txtMaCanBo.Size = new System.Drawing.Size(103, 20);
            this.txtMaCanBo.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(121, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Bộ môn";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(487, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = " Loại tài khoản";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(531, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Giới tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Ngày sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(324, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(301, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Tên cán bộ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Mã cán bộ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Beige;
            this.panel1.Controls.Add(this.rtxDetailSche);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtFindWork);
            this.panel1.Controls.Add(this.btnFindWork);
            this.panel1.Controls.Add(this.dtpEndDate);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.txtPlace);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.btnSaveSche);
            this.panel1.Controls.Add(this.btnDelSche);
            this.panel1.Controls.Add(this.btnEditSche);
            this.panel1.Controls.Add(this.btnAddSche);
            this.panel1.Controls.Add(this.dtpBeginDate);
            this.panel1.Controls.Add(this.txtWork);
            this.panel1.Controls.Add(this.txtScheduleId);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 294);
            this.panel1.TabIndex = 48;
            // 
            // rtxDetailSche
            // 
            this.rtxDetailSche.Location = new System.Drawing.Point(145, 158);
            this.rtxDetailSche.Name = "rtxDetailSche";
            this.rtxDetailSche.Size = new System.Drawing.Size(612, 85);
            this.rtxDetailSche.TabIndex = 28;
            this.rtxDetailSche.Text = "";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(40, 158);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "Mô tả công việc";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(265, 267);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Tìm kiếm theo tên";
            // 
            // txtFindWork
            // 
            this.txtFindWork.Location = new System.Drawing.Point(376, 264);
            this.txtFindWork.Name = "txtFindWork";
            this.txtFindWork.Size = new System.Drawing.Size(119, 20);
            this.txtFindWork.TabIndex = 27;
            // 
            // btnFindWork
            // 
            this.btnFindWork.Location = new System.Drawing.Point(523, 262);
            this.btnFindWork.Name = "btnFindWork";
            this.btnFindWork.Size = new System.Drawing.Size(75, 23);
            this.btnFindWork.TabIndex = 26;
            this.btnFindWork.Text = "Tìm kiếm";
            this.btnFindWork.UseVisualStyleBackColor = true;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(416, 74);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(169, 20);
            this.dtpEndDate.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(329, 77);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Ngày kết thúc";
            // 
            // txtPlace
            // 
            this.txtPlace.Location = new System.Drawing.Point(145, 116);
            this.txtPlace.Name = "txtPlace";
            this.txtPlace.Size = new System.Drawing.Size(119, 20);
            this.txtPlace.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(40, 119);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Địa điểm công tác";
            // 
            // btnSaveSche
            // 
            this.btnSaveSche.Location = new System.Drawing.Point(787, 153);
            this.btnSaveSche.Name = "btnSaveSche";
            this.btnSaveSche.Size = new System.Drawing.Size(75, 23);
            this.btnSaveSche.TabIndex = 19;
            this.btnSaveSche.Text = "Lưu";
            this.btnSaveSche.UseVisualStyleBackColor = true;
            this.btnSaveSche.Click += new System.EventHandler(this.btnSaveSche_Click);
            // 
            // btnDelSche
            // 
            this.btnDelSche.Location = new System.Drawing.Point(787, 113);
            this.btnDelSche.Name = "btnDelSche";
            this.btnDelSche.Size = new System.Drawing.Size(75, 23);
            this.btnDelSche.TabIndex = 18;
            this.btnDelSche.Text = "Xóa";
            this.btnDelSche.UseVisualStyleBackColor = true;
            // 
            // btnEditSche
            // 
            this.btnEditSche.Location = new System.Drawing.Point(787, 71);
            this.btnEditSche.Name = "btnEditSche";
            this.btnEditSche.Size = new System.Drawing.Size(75, 23);
            this.btnEditSche.TabIndex = 17;
            this.btnEditSche.Text = "Sửa";
            this.btnEditSche.UseVisualStyleBackColor = true;
            // 
            // btnAddSche
            // 
            this.btnAddSche.Location = new System.Drawing.Point(787, 32);
            this.btnAddSche.Name = "btnAddSche";
            this.btnAddSche.Size = new System.Drawing.Size(75, 23);
            this.btnAddSche.TabIndex = 16;
            this.btnAddSche.Text = "Thêm";
            this.btnAddSche.UseVisualStyleBackColor = true;
            this.btnAddSche.Click += new System.EventHandler(this.btnAddSche_Click);
            // 
            // dtpBeginDate
            // 
            this.dtpBeginDate.Location = new System.Drawing.Point(416, 35);
            this.dtpBeginDate.Name = "dtpBeginDate";
            this.dtpBeginDate.Size = new System.Drawing.Size(169, 20);
            this.dtpBeginDate.TabIndex = 15;
            // 
            // txtWork
            // 
            this.txtWork.Location = new System.Drawing.Point(145, 74);
            this.txtWork.Name = "txtWork";
            this.txtWork.Size = new System.Drawing.Size(148, 20);
            this.txtWork.TabIndex = 8;
            // 
            // txtScheduleId
            // 
            this.txtScheduleId.Location = new System.Drawing.Point(145, 35);
            this.txtScheduleId.Name = "txtScheduleId";
            this.txtScheduleId.Size = new System.Drawing.Size(103, 20);
            this.txtScheduleId.TabIndex = 7;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(329, 37);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(72, 13);
            this.label17.TabIndex = 3;
            this.label17.Text = "Ngày bắt đầu";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(40, 77);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(76, 13);
            this.label19.TabIndex = 1;
            this.label19.Text = "Tên công việc";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(40, 37);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(86, 13);
            this.label20.TabIndex = 0;
            this.label20.Text = "Mã lịch công tác";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvSche);
            this.panel2.Location = new System.Drawing.Point(0, 291);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(933, 232);
            this.panel2.TabIndex = 49;
            // 
            // dgvSche
            // 
            this.dgvSche.AllowUserToAddRows = false;
            this.dgvSche.AllowUserToDeleteRows = false;
            this.dgvSche.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSche.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLich,
            this.TenCongViec,
            this.MoTaCongViec,
            this.DiaDiem,
            this.NgayBatDau,
            this.NgayKetThuc,
            this.MaKhoa,
            this.MaBoMon});
            this.dgvSche.Location = new System.Drawing.Point(3, 3);
            this.dgvSche.Name = "dgvSche";
            this.dgvSche.ReadOnly = true;
            this.dgvSche.Size = new System.Drawing.Size(930, 220);
            this.dgvSche.TabIndex = 0;
            this.dgvSche.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSche_CellClick);
            // 
            // MaLich
            // 
            this.MaLich.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaLich.DataPropertyName = "MaLich";
            this.MaLich.HeaderText = "Mã lịch công tác";
            this.MaLich.Name = "MaLich";
            this.MaLich.ReadOnly = true;
            // 
            // TenCongViec
            // 
            this.TenCongViec.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenCongViec.DataPropertyName = "TenCongViec";
            this.TenCongViec.HeaderText = "Tên công việc";
            this.TenCongViec.Name = "TenCongViec";
            this.TenCongViec.ReadOnly = true;
            // 
            // MoTaCongViec
            // 
            this.MoTaCongViec.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MoTaCongViec.DataPropertyName = "MoTaCongViec";
            this.MoTaCongViec.HeaderText = "Mô tả";
            this.MoTaCongViec.Name = "MoTaCongViec";
            this.MoTaCongViec.ReadOnly = true;
            // 
            // DiaDiem
            // 
            this.DiaDiem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DiaDiem.DataPropertyName = "DiaDiem";
            this.DiaDiem.HeaderText = "Địa điểm";
            this.DiaDiem.Name = "DiaDiem";
            this.DiaDiem.ReadOnly = true;
            // 
            // NgayBatDau
            // 
            this.NgayBatDau.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NgayBatDau.DataPropertyName = "NgayBatDau";
            this.NgayBatDau.HeaderText = "Ngày bắt đầu";
            this.NgayBatDau.Name = "NgayBatDau";
            this.NgayBatDau.ReadOnly = true;
            // 
            // NgayKetThuc
            // 
            this.NgayKetThuc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NgayKetThuc.DataPropertyName = "NgayKetThuc";
            this.NgayKetThuc.HeaderText = "Ngày kết thúc";
            this.NgayKetThuc.Name = "NgayKetThuc";
            this.NgayKetThuc.ReadOnly = true;
            // 
            // MaKhoa
            // 
            this.MaKhoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaKhoa.DataPropertyName = "MaKhoa";
            this.MaKhoa.HeaderText = "Mã khoa";
            this.MaKhoa.Name = "MaKhoa";
            this.MaKhoa.ReadOnly = true;
            // 
            // MaBoMon
            // 
            this.MaBoMon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaBoMon.DataPropertyName = "MaBoMon";
            this.MaBoMon.HeaderText = "Mã bộ môn";
            this.MaBoMon.Name = "MaBoMon";
            this.MaBoMon.ReadOnly = true;
            // 
            // FrmScheduleManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 524);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cboLTaiKhoan);
            this.Controls.Add(this.txtdiachi);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.cboGioiTinh);
            this.Controls.Add(this.cboBoMon);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTenCanBo);
            this.Controls.Add(this.txtMaCanBo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmScheduleManagement";
            this.Text = "FrmScheduleManagement";
            this.Load += new System.EventHandler(this.FrmScheduleManagement_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSche)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboLTaiKhoan;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.ComboBox cboGioiTinh;
        private System.Windows.Forms.ComboBox cboBoMon;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTenCanBo;
        private System.Windows.Forms.TextBox txtMaCanBo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPlace;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnSaveSche;
        private System.Windows.Forms.Button btnDelSche;
        private System.Windows.Forms.Button btnEditSche;
        private System.Windows.Forms.Button btnAddSche;
        private System.Windows.Forms.DateTimePicker dtpBeginDate;
        private System.Windows.Forms.TextBox txtWork;
        private System.Windows.Forms.TextBox txtScheduleId;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RichTextBox rtxDetailSche;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtFindWork;
        private System.Windows.Forms.Button btnFindWork;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvSche;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLich;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenCongViec;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoTaCongViec;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaDiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayBatDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayKetThuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBoMon;
    }
}