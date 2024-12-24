namespace Assignment
{
    partial class FormDiemSinhVien
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTimsinhvien = new System.Windows.Forms.Button();
            this.txtTimmasv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDiemTB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTheduc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTinhoc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTienganh = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTensinhvien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMasv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvQLDSV = new System.Windows.Forms.DataGridView();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLDSV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(210, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(432, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ ĐIỂM SINH VIÊN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTimsinhvien);
            this.groupBox1.Controls.Add(this.txtTimmasv);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(143, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(475, 110);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm sinh viên";
            // 
            // btnTimsinhvien
            // 
            this.btnTimsinhvien.AutoSize = true;
            this.btnTimsinhvien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimsinhvien.Image = global::Assignment.Properties.Resources.icons8_search_32;
            this.btnTimsinhvien.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimsinhvien.Location = new System.Drawing.Point(300, 40);
            this.btnTimsinhvien.Name = "btnTimsinhvien";
            this.btnTimsinhvien.Size = new System.Drawing.Size(114, 38);
            this.btnTimsinhvien.TabIndex = 2;
            this.btnTimsinhvien.Text = "Tìm";
            this.btnTimsinhvien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimsinhvien.UseVisualStyleBackColor = true;
            this.btnTimsinhvien.Click += new System.EventHandler(this.btnTimsinhvien_Click);
            // 
            // txtTimmasv
            // 
            this.txtTimmasv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimmasv.Location = new System.Drawing.Point(148, 46);
            this.txtTimmasv.Name = "txtTimmasv";
            this.txtTimmasv.Size = new System.Drawing.Size(129, 32);
            this.txtTimmasv.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10F);
            this.label2.Location = new System.Drawing.Point(17, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã sinh viên:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtDiemTB);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtTheduc);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtTinhoc);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtTienganh);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtTensinhvien);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtMasv);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(413, 228);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(362, 327);
            this.panel1.TabIndex = 2;
            // 
            // txtDiemTB
            // 
            this.txtDiemTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtDiemTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiemTB.Font = new System.Drawing.Font("Verdana", 15F);
            this.txtDiemTB.Location = new System.Drawing.Point(152, 260);
            this.txtDiemTB.Name = "txtDiemTB";
            this.txtDiemTB.ReadOnly = true;
            this.txtDiemTB.Size = new System.Drawing.Size(133, 38);
            this.txtDiemTB.TabIndex = 11;
            this.txtDiemTB.TabStop = false;
            this.txtDiemTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 12F);
            this.label8.Location = new System.Drawing.Point(55, 267);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 25);
            this.label8.TabIndex = 10;
            this.label8.Text = "Điểm TB:";
            // 
            // txtTheduc
            // 
            this.txtTheduc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTheduc.Font = new System.Drawing.Font("Verdana", 10F);
            this.txtTheduc.Location = new System.Drawing.Point(128, 211);
            this.txtTheduc.Name = "txtTheduc";
            this.txtTheduc.Size = new System.Drawing.Size(209, 28);
            this.txtTheduc.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 10F);
            this.label7.Location = new System.Drawing.Point(25, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Vovinam:";
            // 
            // txtTinhoc
            // 
            this.txtTinhoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTinhoc.Font = new System.Drawing.Font("Verdana", 10F);
            this.txtTinhoc.Location = new System.Drawing.Point(128, 163);
            this.txtTinhoc.Name = "txtTinhoc";
            this.txtTinhoc.Size = new System.Drawing.Size(209, 28);
            this.txtTinhoc.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 10F);
            this.label6.Location = new System.Drawing.Point(25, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Tin học:";
            // 
            // txtTienganh
            // 
            this.txtTienganh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTienganh.Font = new System.Drawing.Font("Verdana", 10F);
            this.txtTienganh.Location = new System.Drawing.Point(128, 116);
            this.txtTienganh.Name = "txtTienganh";
            this.txtTienganh.Size = new System.Drawing.Size(209, 28);
            this.txtTienganh.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 10F);
            this.label5.Location = new System.Drawing.Point(25, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tiếng anh:";
            // 
            // txtTensinhvien
            // 
            this.txtTensinhvien.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtTensinhvien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTensinhvien.Font = new System.Drawing.Font("Verdana", 10F);
            this.txtTensinhvien.ForeColor = System.Drawing.Color.White;
            this.txtTensinhvien.Location = new System.Drawing.Point(128, 70);
            this.txtTensinhvien.Name = "txtTensinhvien";
            this.txtTensinhvien.ReadOnly = true;
            this.txtTensinhvien.Size = new System.Drawing.Size(209, 28);
            this.txtTensinhvien.TabIndex = 3;
            this.txtTensinhvien.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 10F);
            this.label4.Location = new System.Drawing.Point(25, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Họ tên:";
            // 
            // txtMasv
            // 
            this.txtMasv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMasv.Font = new System.Drawing.Font("Verdana", 10F);
            this.txtMasv.Location = new System.Drawing.Point(128, 27);
            this.txtMasv.Name = "txtMasv";
            this.txtMasv.Size = new System.Drawing.Size(209, 28);
            this.txtMasv.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10F);
            this.label3.Location = new System.Drawing.Point(25, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã sv:";
            // 
            // dgvQLDSV
            // 
            this.dgvQLDSV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvQLDSV.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvQLDSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQLDSV.Location = new System.Drawing.Point(32, 228);
            this.dgvQLDSV.Name = "dgvQLDSV";
            this.dgvQLDSV.RowHeadersWidth = 51;
            this.dgvQLDSV.RowTemplate.Height = 24;
            this.dgvQLDSV.Size = new System.Drawing.Size(346, 327);
            this.dgvQLDSV.TabIndex = 10;
            this.dgvQLDSV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQLDSV_CellClick);
            // 
            // btnThoat
            // 
            this.btnThoat.AutoSize = true;
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnThoat.Image = global::Assignment.Properties.Resources.icons8_exit_32;
            this.btnThoat.Location = new System.Drawing.Point(32, 30);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(105, 39);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnReset
            // 
            this.btnReset.AutoSize = true;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.Font = new System.Drawing.Font("Verdana", 12F);
            this.btnReset.Image = global::Assignment.Properties.Resources.icons8_reset_32;
            this.btnReset.Location = new System.Drawing.Point(600, 561);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(151, 64);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSua
            // 
            this.btnSua.AutoSize = true;
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.Font = new System.Drawing.Font("Verdana", 12F);
            this.btnSua.Image = global::Assignment.Properties.Resources.icons8_edit_32;
            this.btnSua.Location = new System.Drawing.Point(443, 561);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(150, 64);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // FormDiemSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 655);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.dgvQLDSV);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormDiemSinhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐIỂM CỦA SINH VIÊN";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLDSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTimmasv;
        private System.Windows.Forms.Button btnTimsinhvien;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtMasv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTheduc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTinhoc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTienganh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTensinhvien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDiemTB;
        private System.Windows.Forms.DataGridView dgvQLDSV;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnReset;
        internal System.Windows.Forms.Button btnThoat;
    }
}