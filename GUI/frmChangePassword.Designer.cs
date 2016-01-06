namespace GUI
{
    partial class FrmChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChangePassword));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtbConfirmPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbNewPass = new System.Windows.Forms.TextBox();
            this.txtbOldPass = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.lbError1 = new System.Windows.Forms.Label();
            this.lbError2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(328, 36);
            this.panel1.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(292, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(36, 36);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtbConfirmPass
            // 
            this.txtbConfirmPass.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbConfirmPass.Location = new System.Drawing.Point(175, 178);
            this.txtbConfirmPass.Name = "txtbConfirmPass";
            this.txtbConfirmPass.Size = new System.Drawing.Size(129, 22);
            this.txtbConfirmPass.TabIndex = 2;
            this.txtbConfirmPass.Leave += new System.EventHandler(this.txtbConfirmPass_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mật khẩu cũ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mật khẩu mới";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Xác nhận mật khẩu";
            // 
            // txtbNewPass
            // 
            this.txtbNewPass.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbNewPass.Location = new System.Drawing.Point(175, 124);
            this.txtbNewPass.Name = "txtbNewPass";
            this.txtbNewPass.Size = new System.Drawing.Size(129, 22);
            this.txtbNewPass.TabIndex = 1;
            // 
            // txtbOldPass
            // 
            this.txtbOldPass.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbOldPass.Location = new System.Drawing.Point(175, 70);
            this.txtbOldPass.Name = "txtbOldPass";
            this.txtbOldPass.Size = new System.Drawing.Size(129, 22);
            this.txtbOldPass.TabIndex = 0;
            this.txtbOldPass.Leave += new System.EventHandler(this.txtbOldPass_Leave);
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(110, 256);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(102, 31);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lbError1
            // 
            this.lbError1.AutoSize = true;
            this.lbError1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbError1.ForeColor = System.Drawing.Color.Red;
            this.lbError1.Location = new System.Drawing.Point(46, 224);
            this.lbError1.Name = "lbError1";
            this.lbError1.Size = new System.Drawing.Size(224, 16);
            this.lbError1.TabIndex = 9;
            this.lbError1.Text = "Mật khẩu cũ không chính xác";
            // 
            // lbError2
            // 
            this.lbError2.AutoSize = true;
            this.lbError2.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbError2.ForeColor = System.Drawing.Color.Red;
            this.lbError2.Location = new System.Drawing.Point(28, 224);
            this.lbError2.Name = "lbError2";
            this.lbError2.Size = new System.Drawing.Size(272, 16);
            this.lbError2.TabIndex = 10;
            this.lbError2.Text = "Mật khẩu xác nhận không chính xác";
            // 
            // frmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 303);
            this.Controls.Add(this.lbError2);
            this.Controls.Add(this.lbError1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtbOldPass);
            this.Controls.Add(this.txtbNewPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbConfirmPass);
            this.Controls.Add(this.panel1);
            this.Name = "frmChangePassword";
            this.Text = "frmChangePassword";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtbConfirmPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbNewPass;
        private System.Windows.Forms.TextBox txtbOldPass;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lbError1;
        private System.Windows.Forms.Label lbError2;
    }
}