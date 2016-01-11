namespace GUI
{
    partial class FrmSelectStaff
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
            this.dgvSelectStaff = new System.Windows.Forms.DataGridView();
            this.MaCanBo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenCanBo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaBoMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelectStaff = new System.Windows.Forms.Button();
            this.btnCancelSelect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectStaff)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSelectStaff
            // 
            this.dgvSelectStaff.AllowUserToAddRows = false;
            this.dgvSelectStaff.AllowUserToDeleteRows = false;
            this.dgvSelectStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelectStaff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaCanBo,
            this.TenCanBo,
            this.MaBoMon,
            this.Email,
            this.SoDienThoai});
            this.dgvSelectStaff.Location = new System.Drawing.Point(12, 37);
            this.dgvSelectStaff.Name = "dgvSelectStaff";
            this.dgvSelectStaff.ReadOnly = true;
            this.dgvSelectStaff.Size = new System.Drawing.Size(645, 239);
            this.dgvSelectStaff.TabIndex = 0;
            // 
            // MaCanBo
            // 
            this.MaCanBo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaCanBo.DataPropertyName = "MaCanBo";
            this.MaCanBo.HeaderText = "Mã cán bộ";
            this.MaCanBo.Name = "MaCanBo";
            this.MaCanBo.ReadOnly = true;
            // 
            // TenCanBo
            // 
            this.TenCanBo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenCanBo.DataPropertyName = "TenCanBo";
            this.TenCanBo.HeaderText = "Họ và tên";
            this.TenCanBo.Name = "TenCanBo";
            this.TenCanBo.ReadOnly = true;
            // 
            // MaBoMon
            // 
            this.MaBoMon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaBoMon.DataPropertyName = "MaBoMon";
            this.MaBoMon.HeaderText = "Mã bộ môn";
            this.MaBoMon.Name = "MaBoMon";
            this.MaBoMon.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // SoDienThoai
            // 
            this.SoDienThoai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SoDienThoai.DataPropertyName = "SoDienThoai";
            this.SoDienThoai.HeaderText = "Số điện thoại";
            this.SoDienThoai.Name = "SoDienThoai";
            this.SoDienThoai.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(229, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lựa chọn nhân viên";
            // 
            // btnSelectStaff
            // 
            this.btnSelectStaff.Location = new System.Drawing.Point(158, 290);
            this.btnSelectStaff.Name = "btnSelectStaff";
            this.btnSelectStaff.Size = new System.Drawing.Size(75, 23);
            this.btnSelectStaff.TabIndex = 2;
            this.btnSelectStaff.Text = "OK";
            this.btnSelectStaff.UseVisualStyleBackColor = true;
            this.btnSelectStaff.Click += new System.EventHandler(this.btnSelectStaff_Click);
            // 
            // btnCancelSelect
            // 
            this.btnCancelSelect.Location = new System.Drawing.Point(431, 290);
            this.btnCancelSelect.Name = "btnCancelSelect";
            this.btnCancelSelect.Size = new System.Drawing.Size(75, 23);
            this.btnCancelSelect.TabIndex = 3;
            this.btnCancelSelect.Text = "Cancel";
            this.btnCancelSelect.UseVisualStyleBackColor = true;
            this.btnCancelSelect.Click += new System.EventHandler(this.btnCancelSelect_Click);
            // 
            // FrmSelectStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(669, 325);
            this.Controls.Add(this.btnCancelSelect);
            this.Controls.Add(this.btnSelectStaff);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSelectStaff);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSelectStaff";
            this.Text = "FrmSelectStaff";
            this.Load += new System.EventHandler(this.FrmSelectStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectStaff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSelectStaff;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCanBo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenCanBo;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBoMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDienThoai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelectStaff;
        private System.Windows.Forms.Button btnCancelSelect;
    }
}