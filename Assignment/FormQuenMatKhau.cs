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
    public partial class FormQuenMatKhau : Form
    {
        int CountPass = 0;
        int CountConfirmPass = 0;
        public FormQuenMatKhau()
        {
            InitializeComponent();
        }

        private void btnKiemtramatkhau_Click(object sender, EventArgs e)
        {
            KiemTraMatKhau();
        }
        void KiemTraMatKhau()
        {
            using(var db = new AssignmentCSharp3DataContext())
            {
                string username = txtUsername.Text.Trim();
                if(username == string.Empty)
                {
                    MessageBox.Show("Vui lòng nhập user name!"); return;
                }
                User checkUsername = db.Users.FirstOrDefault(x => x.Username1.Equals(username));
                if(checkUsername != null)
                {
                    MessageBox.Show("Kiểm tra thành công!");
                    txtMatkhau.Enabled = true;
                    txtXacnhanmatkhau.Enabled = true;
                    btnDisplayPassQuenMatKhau.Enabled = true;
                    btnDisplayConfirmPassQuenMatKhau.Enabled = true;                    txtUsername.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Không có user name này!");
                }
            }
        }
        private void btnThaydoimatkhau_Click(object sender, EventArgs e)
        {
            ThayDoiMatKhau();
        }
        void ThayDoiMatKhau()
        {
            using (var db = new AssignmentCSharp3DataContext())
            {
                string username = txtUsername.Text.Trim();
                string matKhau = txtMatkhau.Text.Trim();
                string xacNhanmatkhau = txtXacnhanmatkhau.Text.Trim();
                if (username == string.Empty)
                {
                    MessageBox.Show("Vui lòng nhập user name!"); return;
                }
                if (matKhau == string.Empty)
                {
                    MessageBox.Show("Vui lòng nhập mật khẩu!"); return;
                }
                if (xacNhanmatkhau == string.Empty)
                {
                    MessageBox.Show("Vui lòng xác nhận mật khẩu!"); return;
                }
                if (xacNhanmatkhau != matKhau)
                {
                    MessageBox.Show("Mật khẩu xác nhận không trùng khớp!"); return;
                }
                User checkUsername = db.Users.FirstOrDefault(x => x.Username1.Equals(username));
                if (checkUsername != null)
                {
                    checkUsername.Password1 = matKhau;
                    db.SubmitChanges();
                    MessageBox.Show("Thay đổi mật khẩu thành công!");
                    txtUsername.Enabled = true;
                    txtMatkhau.Enabled = false;
                    txtXacnhanmatkhau.Enabled = false;
                    btnDisplayPassQuenMatKhau.Enabled = false;
                    btnDisplayConfirmPassQuenMatKhau.Enabled = false;
                    ClearField();
                }
                else
                {
                    MessageBox.Show("Không có user name này!");
                }
            }
        }
        void ClearField()
        {
            txtUsername.Text = "";
            txtMatkhau.Text = "";
            txtXacnhanmatkhau.Text = "";
        }

        private void btnDisplayPassQuenMatKhau_Click(object sender, EventArgs e)
        {
            if (CountPass % 2 == 0)
            {
                txtMatkhau.PasswordChar = '\0';
                CountPass++;
            }
            else
            {
                txtMatkhau.PasswordChar = '*';
                CountPass--;
            }
        }

        private void btnDisplayConfirmPassQuenMatKhau_Click(object sender, EventArgs e)
        {
            if (CountConfirmPass % 2 == 0)
            {
                txtXacnhanmatkhau.PasswordChar = '\0';
                CountConfirmPass++;
            }
            else
            {
                txtXacnhanmatkhau.PasswordChar = '*';
                CountConfirmPass--;
            }
        }
    }
}
