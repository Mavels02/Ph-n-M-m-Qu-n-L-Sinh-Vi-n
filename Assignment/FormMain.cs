using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class FormMain : Form
    {
        FormDangNhap form = new FormDangNhap();
        public FormMain()
        {
            InitializeComponent();
            //AnhFPT();
        }
        void Thoat()
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát?", "Quit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dg == DialogResult.OK)
            {
                form.Show();
                this.Hide();
            }
        }
        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thoat();
        }

        private void điểmSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDiemSinhVien form = new FormDiemSinhVien();
            form.ShowDialog();
        }

        private void thôngTinSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormThongTinSinhVien form = new FormThongTinSinhVien();
            form.ShowDialog();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.Show();
            this.Hide();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormThongTinUsers form = new FormThongTinUsers();
            form.ShowDialog();
        }

        private void sinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDanhChoSV form = new FormDanhChoSV();
            form.ShowDialog();
        }

        private void QuanLyLopHocStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQuanLyLopHoc form = new FormQuanLyLopHoc();
            form.ShowDialog();
        }
        void AnhFPT()
        {
            picFPTPolytechnic.Image = new Bitmap("E:\\C#\\C# 3\\Assignment\\Assignment\\bin\\Debug\\Resources\\FPT_Polytechnic.png");
        }
    }
}
