namespace Assignment
{
    partial class FormQuenMatKhau
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMatkhau = new System.Windows.Forms.TextBox();
            this.txtXacnhanmatkhau = new System.Windows.Forms.TextBox();
            this.btnThaydoimatkhau = new System.Windows.Forms.Button();
            this.btnKiemtramatkhau = new System.Windows.Forms.Button();
            this.btnDisplayConfirmPassQuenMatKhau = new System.Windows.Forms.Button();
            this.btnDisplayPassQuenMatKhau = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(49, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name:";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtUsername.Location = new System.Drawing.Point(171, 64);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(179, 30);
            this.txtUsername.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(49, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Thay đổi mật khẩu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(49, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Xác nhận mật khẩu:";
            // 
            // txtMatkhau
            // 
            this.txtMatkhau.BackColor = System.Drawing.SystemColors.Window;
            this.txtMatkhau.Enabled = false;
            this.txtMatkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMatkhau.Location = new System.Drawing.Point(234, 115);
            this.txtMatkhau.Name = "txtMatkhau";
            this.txtMatkhau.PasswordChar = '*';
            this.txtMatkhau.Size = new System.Drawing.Size(179, 30);
            this.txtMatkhau.TabIndex = 5;
            // 
            // txtXacnhanmatkhau
            // 
            this.txtXacnhanmatkhau.BackColor = System.Drawing.SystemColors.Window;
            this.txtXacnhanmatkhau.Enabled = false;
            this.txtXacnhanmatkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtXacnhanmatkhau.Location = new System.Drawing.Point(234, 163);
            this.txtXacnhanmatkhau.Name = "txtXacnhanmatkhau";
            this.txtXacnhanmatkhau.PasswordChar = '*';
            this.txtXacnhanmatkhau.Size = new System.Drawing.Size(179, 30);
            this.txtXacnhanmatkhau.TabIndex = 6;
            // 
            // btnThaydoimatkhau
            // 
            this.btnThaydoimatkhau.AutoSize = true;
            this.btnThaydoimatkhau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThaydoimatkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnThaydoimatkhau.Image = global::Assignment.Properties.Resources.icons8_change_32;
            this.btnThaydoimatkhau.Location = new System.Drawing.Point(281, 206);
            this.btnThaydoimatkhau.Name = "btnThaydoimatkhau";
            this.btnThaydoimatkhau.Size = new System.Drawing.Size(130, 38);
            this.btnThaydoimatkhau.TabIndex = 8;
            this.btnThaydoimatkhau.Text = "Thay đổi";
            this.btnThaydoimatkhau.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThaydoimatkhau.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThaydoimatkhau.UseVisualStyleBackColor = true;
            this.btnThaydoimatkhau.Click += new System.EventHandler(this.btnThaydoimatkhau_Click);
            // 
            // btnKiemtramatkhau
            // 
            this.btnKiemtramatkhau.AutoSize = true;
            this.btnKiemtramatkhau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKiemtramatkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnKiemtramatkhau.Image = global::Assignment.Properties.Resources.icons8_customs_32;
            this.btnKiemtramatkhau.Location = new System.Drawing.Point(356, 59);
            this.btnKiemtramatkhau.Name = "btnKiemtramatkhau";
            this.btnKiemtramatkhau.Size = new System.Drawing.Size(130, 38);
            this.btnKiemtramatkhau.TabIndex = 7;
            this.btnKiemtramatkhau.Text = "Kiểm tra";
            this.btnKiemtramatkhau.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKiemtramatkhau.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKiemtramatkhau.UseVisualStyleBackColor = true;
            this.btnKiemtramatkhau.Click += new System.EventHandler(this.btnKiemtramatkhau_Click);
            // 
            // btnDisplayConfirmPassQuenMatKhau
            // 
            this.btnDisplayConfirmPassQuenMatKhau.AutoSize = true;
            this.btnDisplayConfirmPassQuenMatKhau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDisplayConfirmPassQuenMatKhau.Enabled = false;
            this.btnDisplayConfirmPassQuenMatKhau.Image = global::Assignment.Properties.Resources.icons8_eye_32;
            this.btnDisplayConfirmPassQuenMatKhau.Location = new System.Drawing.Point(419, 155);
            this.btnDisplayConfirmPassQuenMatKhau.Name = "btnDisplayConfirmPassQuenMatKhau";
            this.btnDisplayConfirmPassQuenMatKhau.Size = new System.Drawing.Size(46, 38);
            this.btnDisplayConfirmPassQuenMatKhau.TabIndex = 10;
            this.btnDisplayConfirmPassQuenMatKhau.UseVisualStyleBackColor = true;
            this.btnDisplayConfirmPassQuenMatKhau.Click += new System.EventHandler(this.btnDisplayConfirmPassQuenMatKhau_Click);
            // 
            // btnDisplayPassQuenMatKhau
            // 
            this.btnDisplayPassQuenMatKhau.AutoSize = true;
            this.btnDisplayPassQuenMatKhau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDisplayPassQuenMatKhau.Enabled = false;
            this.btnDisplayPassQuenMatKhau.Image = global::Assignment.Properties.Resources.icons8_eye_32;
            this.btnDisplayPassQuenMatKhau.Location = new System.Drawing.Point(419, 107);
            this.btnDisplayPassQuenMatKhau.Name = "btnDisplayPassQuenMatKhau";
            this.btnDisplayPassQuenMatKhau.Size = new System.Drawing.Size(46, 38);
            this.btnDisplayPassQuenMatKhau.TabIndex = 9;
            this.btnDisplayPassQuenMatKhau.UseVisualStyleBackColor = true;
            this.btnDisplayPassQuenMatKhau.Click += new System.EventHandler(this.btnDisplayPassQuenMatKhau_Click);
            // 
            // FormQuenMatKhau
            // 
            this.AcceptButton = this.btnKiemtramatkhau;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 269);
            this.Controls.Add(this.btnDisplayConfirmPassQuenMatKhau);
            this.Controls.Add(this.btnDisplayPassQuenMatKhau);
            this.Controls.Add(this.btnThaydoimatkhau);
            this.Controls.Add(this.btnKiemtramatkhau);
            this.Controls.Add(this.txtXacnhanmatkhau);
            this.Controls.Add(this.txtMatkhau);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label1);
            this.Name = "FormQuenMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUÊN MẬT KHẨU";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMatkhau;
        private System.Windows.Forms.TextBox txtXacnhanmatkhau;
        private System.Windows.Forms.Button btnKiemtramatkhau;
        private System.Windows.Forms.Button btnThaydoimatkhau;
        private System.Windows.Forms.Button btnDisplayPassQuenMatKhau;
        private System.Windows.Forms.Button btnDisplayConfirmPassQuenMatKhau;
    }
}