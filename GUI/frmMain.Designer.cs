﻿namespace GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnFaculty = new System.Windows.Forms.Button();
            this.btnSubject = new System.Windows.Forms.Button();
            this.pnExpandedMenu = new System.Windows.Forms.Panel();
            this.lbStaff = new System.Windows.Forms.Label();
            this.btnStaff = new System.Windows.Forms.Button();
            this.btnNotification = new System.Windows.Forms.Button();
            this.btnSchedule = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPersonalInformation = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSignOut = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lvNotification = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.pnExpandedMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnFaculty);
            this.panel2.Controls.Add(this.btnSubject);
            this.panel2.Controls.Add(this.pnExpandedMenu);
            this.panel2.Controls.Add(this.btnStaff);
            this.panel2.Controls.Add(this.btnNotification);
            this.panel2.Controls.Add(this.btnSchedule);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1250, 40);
            this.panel2.TabIndex = 4;
            // 
            // btnFaculty
            // 
            this.btnFaculty.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnFaculty.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnFaculty.FlatAppearance.BorderSize = 0;
            this.btnFaculty.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnFaculty.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnFaculty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFaculty.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFaculty.ForeColor = System.Drawing.Color.Black;
            this.btnFaculty.Location = new System.Drawing.Point(398, 0);
            this.btnFaculty.Name = "btnFaculty";
            this.btnFaculty.Size = new System.Drawing.Size(77, 40);
            this.btnFaculty.TabIndex = 5;
            this.btnFaculty.Text = "KHOA";
            this.btnFaculty.UseVisualStyleBackColor = true;
            this.btnFaculty.Click += new System.EventHandler(this.btnFaculty_Click);
            // 
            // btnSubject
            // 
            this.btnSubject.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSubject.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnSubject.FlatAppearance.BorderSize = 0;
            this.btnSubject.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnSubject.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubject.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubject.ForeColor = System.Drawing.Color.Black;
            this.btnSubject.Location = new System.Drawing.Point(321, 0);
            this.btnSubject.Name = "btnSubject";
            this.btnSubject.Size = new System.Drawing.Size(77, 40);
            this.btnSubject.TabIndex = 4;
            this.btnSubject.Text = "BỘ MÔN";
            this.btnSubject.UseVisualStyleBackColor = true;
            this.btnSubject.Click += new System.EventHandler(this.btnSubject_Click);
            // 
            // pnExpandedMenu
            // 
            this.pnExpandedMenu.Controls.Add(this.lbStaff);
            this.pnExpandedMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnExpandedMenu.Location = new System.Drawing.Point(1064, 0);
            this.pnExpandedMenu.Name = "pnExpandedMenu";
            this.pnExpandedMenu.Size = new System.Drawing.Size(186, 40);
            this.pnExpandedMenu.TabIndex = 3;
            // 
            // lbStaff
            // 
            this.lbStaff.AutoSize = true;
            this.lbStaff.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStaff.ForeColor = System.Drawing.Color.Black;
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
            this.btnStaff.ForeColor = System.Drawing.Color.Black;
            this.btnStaff.Location = new System.Drawing.Point(244, 0);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(77, 40);
            this.btnStaff.TabIndex = 2;
            this.btnStaff.Text = "CÁN BỘ";
            this.btnStaff.UseVisualStyleBackColor = true;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
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
            this.btnNotification.ForeColor = System.Drawing.Color.Black;
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
            this.btnSchedule.ForeColor = System.Drawing.Color.Black;
            this.btnSchedule.Location = new System.Drawing.Point(0, 0);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(142, 40);
            this.btnSchedule.TabIndex = 0;
            this.btnSchedule.Text = "LỊCH CÔNG VIỆC";
            this.btnSchedule.UseVisualStyleBackColor = true;
            this.btnSchedule.Click += new System.EventHandler(this.btnSchedule_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1250, 36);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(2, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Essential Studio";
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1214, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(36, 36);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiChangePassword,
            this.tsmiPersonalInformation,
            this.toolStripMenuItem1,
            this.tsmiSignOut});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(212, 76);
            // 
            // tsmiChangePassword
            // 
            this.tsmiChangePassword.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiChangePassword.Name = "tsmiChangePassword";
            this.tsmiChangePassword.Size = new System.Drawing.Size(211, 22);
            this.tsmiChangePassword.Text = "Đổi mật khẩu";
            this.tsmiChangePassword.Click += new System.EventHandler(this.tsmiChangePassword_Click);
            // 
            // tsmiPersonalInformation
            // 
            this.tsmiPersonalInformation.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiPersonalInformation.Name = "tsmiPersonalInformation";
            this.tsmiPersonalInformation.Size = new System.Drawing.Size(211, 22);
            this.tsmiPersonalInformation.Text = "Thông tin cá nhân";
            this.tsmiPersonalInformation.Click += new System.EventHandler(this.tsmiPersonalInformation_Click);
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
            // panel3
            // 
            this.panel3.Controls.Add(this.lvNotification);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(940, 76);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(310, 524);
            this.panel3.TabIndex = 7;
            // 
            // lvNotification
            // 
            this.lvNotification.BackColor = System.Drawing.Color.DimGray;
            this.lvNotification.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvNotification.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvNotification.FullRowSelect = true;
            this.lvNotification.GridLines = true;
            this.lvNotification.Location = new System.Drawing.Point(0, 35);
            this.lvNotification.Name = "lvNotification";
            this.lvNotification.Size = new System.Drawing.Size(310, 489);
            this.lvNotification.TabIndex = 3;
            this.lvNotification.UseCompatibleStateImageBehavior = false;
            this.lvNotification.View = System.Windows.Forms.View.Details;
            this.lvNotification.DoubleClick += new System.EventHandler(this.lvNotification_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tiêu đề";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nội dung";
            this.columnHeader2.Width = 245;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightGray;
            this.panel5.Controls.Add(this.label2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(310, 35);
            this.panel5.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "Thông báo";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1250, 600);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.panel2.ResumeLayout(false);
            this.pnExpandedMenu.ResumeLayout(false);
            this.pnExpandedMenu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnExpandedMenu;
        private System.Windows.Forms.Label lbStaff;
        private System.Windows.Forms.Button btnStaff;
        private System.Windows.Forms.Button btnNotification;
        private System.Windows.Forms.Button btnSchedule;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiPersonalInformation;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmiSignOut;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView lvNotification;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFaculty;
        private System.Windows.Forms.Button btnSubject;
        private System.Windows.Forms.ToolStripMenuItem tsmiChangePassword;
    }
}