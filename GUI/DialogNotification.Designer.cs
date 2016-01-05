namespace GUI
{
    partial class DialogNotification
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
            this.btnClose = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbDeadLine = new System.Windows.Forms.Label();
            this.lbReceiveTime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnReject = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rtxtbDetail = new System.Windows.Forms.RichTextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.lbTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(417, 34);
            this.panel1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(381, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(36, 34);
            this.btnClose.TabIndex = 1;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Location = new System.Drawing.Point(12, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(64, 16);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Tiêu đề";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbDeadLine);
            this.panel2.Controls.Add(this.lbReceiveTime);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 34);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(417, 62);
            this.panel2.TabIndex = 1;
            // 
            // lbDeadLine
            // 
            this.lbDeadLine.AutoSize = true;
            this.lbDeadLine.Location = new System.Drawing.Point(156, 34);
            this.lbDeadLine.Name = "lbDeadLine";
            this.lbDeadLine.Size = new System.Drawing.Size(136, 16);
            this.lbDeadLine.TabIndex = 5;
            this.lbDeadLine.Text = "Thời gian nhận: ";
            // 
            // lbReceiveTime
            // 
            this.lbReceiveTime.AutoSize = true;
            this.lbReceiveTime.Location = new System.Drawing.Point(143, 9);
            this.lbReceiveTime.Name = "lbReceiveTime";
            this.lbReceiveTime.Size = new System.Drawing.Size(136, 16);
            this.lbReceiveTime.TabIndex = 4;
            this.lbReceiveTime.Text = "Thời gian nhận: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Thời hạn trả lời: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Thời gian nhận: ";
            // 
            // btnAccept
            // 
            this.btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccept.Location = new System.Drawing.Point(71, 346);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(108, 31);
            this.btnAccept.TabIndex = 2;
            this.btnAccept.Text = "Chấp nhận";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnReject
            // 
            this.btnReject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReject.Location = new System.Drawing.Point(251, 346);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(108, 31);
            this.btnReject.TabIndex = 3;
            this.btnReject.Text = "Từ chối";
            this.btnReject.UseVisualStyleBackColor = true;
            this.btnReject.Click += new System.EventHandler(this.btnReject_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rtxtbDetail);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 96);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(417, 231);
            this.panel3.TabIndex = 4;
            // 
            // rtxtbDetail
            // 
            this.rtxtbDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxtbDetail.Location = new System.Drawing.Point(0, 0);
            this.rtxtbDetail.Name = "rtxtbDetail";
            this.rtxtbDetail.Size = new System.Drawing.Size(417, 231);
            this.rtxtbDetail.TabIndex = 0;
            this.rtxtbDetail.Text = "";
            // 
            // btnOk
            // 
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Location = new System.Drawing.Point(150, 346);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(108, 31);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Visible = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // DialogNotification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 396);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnReject);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DialogNotification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DialogNotification";
            this.Load += new System.EventHandler(this.DialogNotification_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Button btnAccept;
        public System.Windows.Forms.Button btnReject;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.RichTextBox rtxtbDetail;
        private System.Windows.Forms.Label lbDeadLine;
        private System.Windows.Forms.Label lbReceiveTime;
    }
}