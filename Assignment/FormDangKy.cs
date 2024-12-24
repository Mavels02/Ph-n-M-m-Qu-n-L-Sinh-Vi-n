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
    public partial class FormDangKy : Form
    {
        int CountPass = 0;
        int CountConfirmPass = 0;
        public FormDangKy()
        {
            InitializeComponent();
        }

        private void btnDangkyFormDangky_Click(object sender, EventArgs e)
        {
            KiemTraField();
        }
        void KiemTraField()
        {
            string taiKhoan = txtTaikhoanDangky.Text;
            string matKhau = txtMatkhaudangky.Text;
            string xacnhanMk = txtXacnhanmatkhaudangky.Text;
            if (KiemtraInputField(taiKhoan,matKhau,xacnhanMk))
            {
                DangKy(taiKhoan, matKhau);
                MessageBox.Show("Đăng ký thành công!");
                ClearField();
            }
        }
        bool KiemtraInputField(string taikhoan, string matkhau, string xacnhanmk)
        {
            if (taikhoan == string.Empty)
            {
                MessageBox.Show("Chưa nhập tên tài khoản!");
                return false;
            }
            if (matkhau == string.Empty)
            {
                MessageBox.Show("Chưa nhập mật khẩu!");
                return false;
            }
            if (xacnhanmk == string.Empty)
            {
                MessageBox.Show("Vui lòng xác nhận mật khẩu!");
                return false;
            }
            if (matkhau != xacnhanmk)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp!");
                return false;
            }
            return true;
        }
        void DangKy(string taiKhoan, string matKhau)
        {
            using (var db = new AssignmentCSharp3DataContext())
            {
                User user = new User();
                user.Username1 = taiKhoan;
                user.Password1 = matKhau;
                db.Users.InsertOnSubmit(user);
                db.SubmitChanges();
            }
        }
        private void btnThoatFormDangky_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                this.Close();
            }
        }
        void ClearField()
        {
            txtTaikhoanDangky.Text = "";
            txtMatkhaudangky.Text = "";
            txtXacnhanmatkhaudangky.Text = "";
        }

        private void btnDisplayPassDangKy_Click(object sender, EventArgs e)
        {
            if (CountPass % 2 == 0)
            {
                txtMatkhaudangky.PasswordChar = '\0';
                CountPass++;
            }
            else
            {
                txtMatkhaudangky.PasswordChar = '*';
                CountPass--;
            }
        }

        private void btnDisplayConfirmPassDangKy_Click(object sender, EventArgs e)
        {
            if (CountConfirmPass % 2 == 0)
            {
                txtXacnhanmatkhaudangky.PasswordChar = '\0';
                CountConfirmPass++;
            }
            else
            {
                txtXacnhanmatkhaudangky.PasswordChar = '*';
                CountConfirmPass--;
            }
        }
    }
}
