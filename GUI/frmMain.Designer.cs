namespace GUI
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvNotification = new System.Windows.Forms.ListView();
            this.colTiTle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDetail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnExpandedMenu = new System.Windows.Forms.Panel();
            this.lbStaff = new System.Windows.Forms.Label();
            this.btnStaff = new System.Windows.Forms.Button();
            this.btnNotification = new System.Windows.Forms.Button();
            this.btnSchedule = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSignOut = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnExpandedMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvNotification);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(764, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 483);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // lvNotification
            // 
            this.lvNotification.BackColor = System.Drawing.Color.DimGray;
            this.lvNotification.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTiTle,
            this.colDetail});
            this.lvNotification.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvNotification.Location = new System.Drawing.Point(3, 51);
            this.lvNotification.Name = "lvNotification";
            this.lvNotification.Size = new System.Drawing.Size(232, 429);
            this.lvNotification.TabIndex = 1;
            this.lvNotification.UseCompatibleStateImageBehavior = false;
            this.lvNotification.View = System.Windows.Forms.View.Details;
            // 
            // colTiTle
            // 
            this.colTiTle.Text = "Tiêu đề";
            // 
            // colDetail
            // 
            this.colDetail.Text = "Nội dung";
            this.colDetail.Width = 167;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightGray;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(3, 16);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(232, 35);
            this.panel4.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnExpandedMenu);
            this.panel2.Controls.Add(this.btnStaff);
            this.panel2.Controls.Add(this.btnNotification);
            this.panel2.Controls.Add(this.btnSchedule);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1002, 40);
            this.panel2.TabIndex = 4;
            // 
            // pnExpandedMenu
            // 
            this.pnExpandedMenu.Controls.Add(this.lbStaff);
            this.pnExpandedMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnExpandedMenu.Location = new System.Drawing.Point(764, 0);
            this.pnExpandedMenu.Name = "pnExpandedMenu";
            this.pnExpandedMenu.Size = new System.Drawing.Size(238, 40);
            this.pnExpandedMenu.TabIndex = 3;
            // 
            // lbStaff
            // 
            this.lbStaff.AutoSize = true;
            this.lbStaff.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStaff.Location = new System.Drawing.Point(3, 11);
            this.lbStaff.Name = "lbStaff";
            this.lbStaff.Size = new System.Drawing.Size(56, 16);
            this.lbStaff.TabIndex = 0;
            this.lbStaff.Text = "label1";
            this.lbStaff.Click += new System.EventHandler(this.lbStaff_Click);
            // 
            // btnStaff
            // 
            this.btnStaff.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnStaff.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnStaff.FlatAppearance.BorderSize = 0;
            this.btnStaff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnStaff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaff.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaff.Location = new System.Drawing.Point(244, 0);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(77, 40);
            this.btnStaff.TabIndex = 2;
            this.btnStaff.Text = "CÁN BỘ";
            this.btnStaff.UseVisualStyleBackColor = true;
            // 
            // btnNotification
            // 
            this.btnNotification.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnNotification.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnNotification.FlatAppearance.BorderSize = 0;
            this.btnNotification.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnNotification.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnNotification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotification.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotification.Location = new System.Drawing.Point(142, 0);
            this.btnNotification.Name = "btnNotification";
            this.btnNotification.Size = new System.Drawing.Size(102, 40);
            this.btnNotification.TabIndex = 1;
            this.btnNotification.Text = "THÔNG BÁO";
            this.btnNotification.UseVisualStyleBackColor = true;
            this.btnNotification.Click += new System.EventHandler(this.btnNotification_Click);
            // 
            // btnSchedule
            // 
            this.btnSchedule.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSchedule.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnSchedule.FlatAppearance.BorderSize = 0;
            this.btnSchedule.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnSchedule.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSchedule.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSchedule.Location = new System.Drawing.Point(0, 0);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(142, 40);
            this.btnSchedule.TabIndex = 0;
            this.btnSchedule.Text = "LỊCH CÔNG VIỆC";
            this.btnSchedule.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1002, 36);
            this.panel1.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(966, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(36, 36);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông báo";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCáNhânToolStripMenuItem,
            this.toolStripMenuItem1,
            this.tsmiSignOut});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(212, 54);
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(208, 6);
            // 
            // tsmiSignOut
            // 
            this.tsmiSignOut.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiSignOut.Name = "tsmiSignOut";
            this.tsmiSignOut.Size = new System.Drawing.Size(211, 22);
            this.tsmiSignOut.Text = "Đăng xuất";
            this.tsmiSignOut.Click += new System.EventHandler(this.tsmiSignOut_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1002, 559);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.pnExpandedMenu.ResumeLayout(false);
            this.pnExpandedMenu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvNotification;
        private System.Windows.Forms.ColumnHeader colTiTle;
        private System.Windows.Forms.ColumnHeader colDetail;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnExpandedMenu;
        private System.Windows.Forms.Label lbStaff;
        private System.Windows.Forms.Button btnStaff;
        private System.Windows.Forms.Button btnNotification;
        private System.Windows.Forms.Button btnSchedule;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmiSignOut;
    }
}