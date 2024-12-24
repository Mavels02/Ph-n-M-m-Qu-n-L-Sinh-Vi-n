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
    public partial class FormThongTinUsers : Form
    {
        public FormThongTinUsers()
        {
            InitializeComponent();
            Display();
        }
        void Display()
        {
            dgvDataUsers.DataSource = UserDangNhap.Instance.LayData();
        }
        void ClearField()
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtRole.Text = "";
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvDataUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(e.RowIndex >= 0)
                {
                    DataGridViewRow chon = dgvDataUsers.Rows[e.RowIndex];
                    string username = chon.Cells[0].Value.ToString();
                    string password = chon.Cells[1].Value.ToString();
                    string role = chon.Cells[2].Value != null ? chon.Cells[2].Value.ToString() : "";

                    txtUsername.Text = username;
                    txtPassword.Text = password;
                    txtRole.Text = role;

                }
            }catch 
            {
                MessageBox.Show("Lỗi không xác định!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SuaUser();
        }
        void SuaUser()
        {
            using(var db = new AssignmentCSharp3DataContext())
            {
                string username = txtUsername.Text;
                string password = txtPassword.Text;
                string role = txtRole.Text != string.Empty ? txtRole.Text : "";

                User checkUsername = db.Users.SingleOrDefault(x => x.Username1.Equals(username));
                if(checkUsername != null)
                {
                    checkUsername.Password1 = password;
                    checkUsername.Role1 = role;
                    db.SubmitChanges();
                    MessageBox.Show("Sửa thành công!");
                    ClearField();
                    Display();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy username!");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            XoaUser();
        }
        void XoaUser()
        {
            using( var db = new AssignmentCSharp3DataContext())
            {
                string username = txtUsername.Text;
                User user = db.Users.SingleOrDefault(x => x.Username1.Equals(username));
                if(user != null)
                {
                    db.Users.DeleteOnSubmit(user);
                    db.SubmitChanges();
                    MessageBox.Show("Xóa thành công!");
                    ClearField();
                    Display();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy username!");
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemUser();
        }
        void ThemUser()
        {
            using(var db = new AssignmentCSharp3DataContext())
            {
                User addUser = new User();
                string _username = txtUsername.Text;
                string _password = txtPassword.Text;
                string _role = txtRole.Text;
                if(_username == string.Empty)
                {
                    MessageBox.Show("Vui lòng điền username!"); return;
                }
                if (_password == string.Empty)
                {
                    MessageBox.Show("Vui lòng điền username!"); return;
                }
                if (_role == string.Empty)
                {
                    _role = "";
                }
                var checkUsername = db.Users.FirstOrDefault(x => x.Username1.Equals(_username));
                if (checkUsername != null)
                {
                    MessageBox.Show("User name này đã tồn tại!");
                }
                else
                {
                    addUser.Username1 = _username;
                    addUser.Password1 = _password;
                    addUser.Role1 = _role;
                    db.Users.InsertOnSubmit(addUser);
                    db.SubmitChanges();
                    MessageBox.Show("Thêm thành công!");
                    ClearField();
                    Display();
                }
            }
        }
    }
}
