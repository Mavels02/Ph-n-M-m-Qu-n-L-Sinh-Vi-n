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
    public partial class FormDangNhap : Form
    {
        int Count = 0;
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangky_Click(object sender, EventArgs e)
        {
            ClickVaoDangky();
        }
        void ClickVaoDangky()
        {
            FormDangKy dk = new FormDangKy();
            dk.ShowDialog();
        }
        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            DangNhap();
        }
        
        void DangNhap()
        {
            string taiKhoan = txtTaikhoanDangnhap.Text;
            string matKhau = txtMatkhauDangnhap.Text;
            if(taiKhoan == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập tài khoản!");
                return;
            }
            if (matKhau == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!");
                return;
            }
            bool dangNhapAdmin = UserDangNhap.Instance.KiemtraLoginAdmin(taiKhoan,matKhau);
            bool dangNhapGV = UserDangNhap.Instance.KiemtraLoginGV(taiKhoan, matKhau);
            bool dangNhapSV = UserDangNhap.Instance.KiemtraLoginSVOrKhac(taiKhoan, matKhau);
            FormThongTinSinhVien ttsv = new FormThongTinSinhVien();
            FormMain form = new FormMain();
            if (dangNhapAdmin)
            {
                ClearField();
                this.Hide();
                form.Show();
            }else if (dangNhapGV)
            {
                ClearField();
                this.Hide();
                form.Show();
                form.thôngTinSinhViênToolStripMenuItem.Enabled = false;
                form.usersToolStripMenuItem.Enabled = false;
                form.QuanLyLopHocStripMenuItem.Enabled = false;
            }
            else if(dangNhapSV)
            {
                ClearField();
                this.Hide();
                form.Show();
                form.thôngTinSinhViênToolStripMenuItem.Enabled = false;
                form.điểmSinhViênToolStripMenuItem.Enabled=false;
                form.usersToolStripMenuItem.Enabled = false;
                form.QuanLyLopHocStripMenuItem.Enabled = false;
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        void ClearField()
        {
            txtTaikhoanDangnhap.Text = "";
            txtMatkhauDangnhap.Text = "";
        }
       
        private void btnDisplayPassDangNhap_Click(object sender, EventArgs e)
        {
            if (Count %2 == 0) 
            {
                txtMatkhauDangnhap.PasswordChar = '\0';
                Count++;
            }
            else
            {
                txtMatkhauDangnhap.PasswordChar = '*';
                Count--;
            }
        }

        private void FormDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnQuenmatkhau_Click(object sender, EventArgs e)
        {
            FormQuenMatKhau form = new FormQuenMatKhau();
            form.ShowDialog();
        }
    }
}
