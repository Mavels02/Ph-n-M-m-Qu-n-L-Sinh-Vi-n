namespace Assignment
{
    partial class FormMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QuanLyLopHocStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.điểmSinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinSinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picFPTPolytechnic = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFPTPolytechnic)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sinhViênToolStripMenuItem,
            this.QuanLyLopHocStripMenuItem,
            this.thôngTinSinhViênToolStripMenuItem,
            this.điểmSinhViênToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(687, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sinhViênToolStripMenuItem
            // 
            this.sinhViênToolStripMenuItem.Name = "sinhViênToolStripMenuItem";
            this.sinhViênToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.sinhViênToolStripMenuItem.Text = "Thông tin sinh viên";
            this.sinhViênToolStripMenuItem.Click += new System.EventHandler(this.sinhViênToolStripMenuItem_Click);
            // 
            // QuanLyLopHocStripMenuItem
            // 
            this.QuanLyLopHocStripMenuItem.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuanLyLopHocStripMenuItem.Name = "QuanLyLopHocStripMenuItem";
            this.QuanLyLopHocStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.QuanLyLopHocStripMenuItem.Text = "Quản lý lớp học";
            this.QuanLyLopHocStripMenuItem.Click += new System.EventHandler(this.QuanLyLopHocStripMenuItem_Click);
            // 
            // điểmSinhViênToolStripMenuItem
            // 
            this.điểmSinhViênToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.điểmSinhViênToolStripMenuItem.Name = "điểmSinhViênToolStripMenuItem";
            this.điểmSinhViênToolStripMenuItem.Size = new System.Drawing.Size(119, 24);
            this.điểmSinhViênToolStripMenuItem.Text = "Quản lý điểm";
            this.điểmSinhViênToolStripMenuItem.Click += new System.EventHandler(this.điểmSinhViênToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // thôngTinSinhViênToolStripMenuItem
            // 
            this.thôngTinSinhViênToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thôngTinSinhViênToolStripMenuItem.Name = "thôngTinSinhViênToolStripMenuItem";
            this.thôngTinSinhViênToolStripMenuItem.Size = new System.Drawing.Size(149, 24);
            this.thôngTinSinhViênToolStripMenuItem.Text = "Quản lý thông tin";
            this.thôngTinSinhViênToolStripMenuItem.Click += new System.EventHandler(this.thôngTinSinhViênToolStripMenuItem_Click);
            // 
            // picFPTPolytechnic
            // 
            this.picFPTPolytechnic.Image = global::Assignment.Properties.Resources.FPT_Polytechnic;
            this.picFPTPolytechnic.Location = new System.Drawing.Point(51, 61);
            this.picFPTPolytechnic.Name = "picFPTPolytechnic";
            this.picFPTPolytechnic.Size = new System.Drawing.Size(582, 277);
            this.picFPTPolytechnic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFPTPolytechnic.TabIndex = 1;
            this.picFPTPolytechnic.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 359);
            this.Controls.Add(this.picFPTPolytechnic);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ SINH VIÊN";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFPTPolytechnic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem điểmSinhViênToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sinhViênToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem QuanLyLopHocStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem thôngTinSinhViênToolStripMenuItem;
        private System.Windows.Forms.PictureBox picFPTPolytechnic;
    }
}

