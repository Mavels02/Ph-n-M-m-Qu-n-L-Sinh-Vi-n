namespace Assignment
{
    partial class FormDangNhap
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
            this.txtTaikhoanDangnhap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMatkhauDangnhap = new System.Windows.Forms.TextBox();
            this.btnDangnhap = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnDangky = new System.Windows.Forms.Button();
            this.btnDisplayPassDangNhap = new System.Windows.Forms.Button();
            this.btnQuenmatkhau = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài khoản:";
            // 
            // txtTaikhoanDangnhap
            // 
            this.txtTaikhoanDangnhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTaikhoanDangnhap.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaikhoanDangnhap.Location = new System.Drawing.Point(164, 46);
            this.txtTaikhoanDangnhap.Name = "txtTaikhoanDangnhap";
            this.txtTaikhoanDangnhap.Size = new System.Drawing.Size(209, 32);
            this.txtTaikhoanDangnhap.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật khẩu:";
            // 
            // txtMatkhauDangnhap
            // 
            this.txtMatkhauDangnhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMatkhauDangnhap.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatkhauDangnhap.Location = new System.Drawing.Point(164, 93);
            this.txtMatkhauDangnhap.Name = "txtMatkhauDangnhap";
            this.txtMatkhauDangnhap.PasswordChar = '*';
            this.txtMatkhauDangnhap.Size = new System.Drawing.Size(209, 32);
            this.txtMatkhauDangnhap.TabIndex = 2;
            // 
            // btnDangnhap
            // 
            this.btnDangnhap.AutoSize = true;
            this.btnDangnhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangnhap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDangnhap.Font = new System.Drawing.Font("Verdana", 12F);
            this.btnDangnhap.Location = new System.Drawing.Point(60, 153);
            this.btnDangnhap.Name = "btnDangnhap";
            this.btnDangnhap.Size = new System.Drawing.Size(179, 43);
            this.btnDangnhap.TabIndex = 4;
            this.btnDangnhap.Text = "Đăng nhập";
            this.btnDangnhap.UseVisualStyleBackColor = true;
            this.btnDangnhap.Click += new System.EventHandler(this.btnDangnhap_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.AutoSize = true;
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThoat.Font = new System.Drawing.Font("Verdana", 12F);
            this.btnThoat.Location = new System.Drawing.Point(267, 218);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(106, 43);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnDangky
            // 
            this.btnDangky.AutoSize = true;
            this.btnDangky.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangky.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDangky.Font = new System.Drawing.Font("Verdana", 12F);
            this.btnDangky.Location = new System.Drawing.Point(267, 153);
            this.btnDangky.Name = "btnDangky";
            this.btnDangky.Size = new System.Drawing.Size(106, 43);
            this.btnDangky.TabIndex = 5;
            this.btnDangky.Text = "Đăng ký";
            this.btnDangky.UseVisualStyleBackColor = true;
            this.btnDangky.Click += new System.EventHandler(this.btnDangky_Click);
            // 
            // btnDisplayPassDangNhap
            // 
            this.btnDisplayPassDangNhap.AutoSize = true;
            this.btnDisplayPassDangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDisplayPassDangNhap.Image = global::Assignment.Properties.Resources.icons8_eye_32;
            this.btnDisplayPassDangNhap.Location = new System.Drawing.Point(379, 87);
            this.btnDisplayPassDangNhap.Name = "btnDisplayPassDangNhap";
            this.btnDisplayPassDangNhap.Size = new System.Drawing.Size(46, 38);
            this.btnDisplayPassDangNhap.TabIndex = 7;
            this.btnDisplayPassDangNhap.UseVisualStyleBackColor = true;
            this.btnDisplayPassDangNhap.Click += new System.EventHandler(this.btnDisplayPassDangNhap_Click);
            // 
            // btnQuenmatkhau
            // 
            this.btnQuenmatkhau.AutoSize = true;
            this.btnQuenmatkhau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuenmatkhau.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQuenmatkhau.Font = new System.Drawing.Font("Verdana", 12F);
            this.btnQuenmatkhau.Location = new System.Drawing.Point(60, 218);
            this.btnQuenmatkhau.Name = "btnQuenmatkhau";
            this.btnQuenmatkhau.Size = new System.Drawing.Size(179, 44);
            this.btnQuenmatkhau.TabIndex = 8;
            this.btnQuenmatkhau.Text = "Quên Mật Khẩu";
            this.btnQuenmatkhau.UseVisualStyleBackColor = true;
            this.btnQuenmatkhau.Click += new System.EventHandler(this.btnQuenmatkhau_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnQuenmatkhau);
            this.groupBox1.Controls.Add(this.btnDisplayPassDangNhap);
            this.groupBox1.Controls.Add(this.btnDangky);
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnDangnhap);
            this.groupBox1.Controls.Add(this.txtMatkhauDangnhap);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTaikhoanDangnhap);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(50, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(485, 284);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đăng nhập";
            // 
            // FormDangNhap
            // 
            this.AcceptButton = this.btnDangnhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 348);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐĂNG NHẬP";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDangNhap_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTaikhoanDangnhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMatkhauDangnhap;
        private System.Windows.Forms.Button btnDangnhap;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnDangky;
        private System.Windows.Forms.Button btnDisplayPassDangNhap;
        private System.Windows.Forms.Button btnQuenmatkhau;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}