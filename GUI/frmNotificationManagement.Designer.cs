namespace GUI
{
    partial class frmNotificationManagement
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDetail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.searchBox1 = new CustomControl.SearchBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DimGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCheck,
            this.colTitle,
            this.colDetail,
            this.colTime});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.GridColor = System.Drawing.Color.Gray;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(930, 290);
            this.dataGridView1.TabIndex = 0;
            // 
            // colCheck
            // 
            this.colCheck.HeaderText = "";
            this.colCheck.Name = "colCheck";
            this.colCheck.ReadOnly = true;
            this.colCheck.Width = 50;
            // 
            // colTitle
            // 
            this.colTitle.HeaderText = "Tiêu đề";
            this.colTitle.Name = "colTitle";
            this.colTitle.ReadOnly = true;
            this.colTitle.Width = 230;
            // 
            // colDetail
            // 
            this.colDetail.HeaderText = "Nội dung";
            this.colDetail.Name = "colDetail";
            this.colDetail.ReadOnly = true;
            this.colDetail.Width = 450;
            // 
            // colTime
            // 
            this.colTime.HeaderText = "Thời gian nhận";
            this.colTime.Name = "colTime";
            this.colTime.ReadOnly = true;
            this.colTime.Width = 163;
            // 
            // btnRead
            // 
            this.btnRead.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRead.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnRead.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnRead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRead.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRead.Location = new System.Drawing.Point(138, 363);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(88, 39);
            this.btnRead.TabIndex = 1;
            this.btnRead.Text = "Đọc";
            this.btnRead.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(353, 363);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(88, 39);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // searchBox1
            // 
            this.searchBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.searchBox1.Location = new System.Drawing.Point(605, 290);
            this.searchBox1.Name = "searchBox1";
            this.searchBox1.SearchByDate = false;
            this.searchBox1.Size = new System.Drawing.Size(325, 167);
            this.searchBox1.TabIndex = 3;
            // 
            // frmNotificationManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(930, 457);
            this.Controls.Add(this.searchBox1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNotificationManagement";
            this.Text = "frmNotificationManagement";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTime;
        private CustomControl.SearchBox searchBox1;
    }
}