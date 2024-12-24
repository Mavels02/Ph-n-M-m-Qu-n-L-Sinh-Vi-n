using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class FormThongTinSinhVien : Form
    {
        string pathdb = @"Data Source=LAPTOP-2HQQGK0E\NNNN;Initial Catalog=ASM_C#3;Integrated Security=True";
        public FormThongTinSinhVien()
        {
            InitializeComponent();
            Display();
            DanhsachLH();
        }
        void Display()
        {
            ThongTinSV.Instance.XemInfoSV(dgvThongtinSV);
        }
        void DanhsachLH()
        {
            using(var db = new AssignmentCSharp3DataContext())
            {
                var layListLH = db.Classes.Select(x => x.MaLop).ToList();
                foreach(var lay in layListLH)
                {
                    cboLophoc.Items.Add(lay);
                }
            }
        }
        private void dgvThongtinSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >=0)
            {
                DataGridViewRow chon = dgvThongtinSV.Rows[e.RowIndex];
                txtMasv.Text = chon.Cells[0].Value.ToString();
                txtHotensv.Text = chon.Cells[1].Value.ToString();
                txtEmail.Text = chon.Cells[2].Value.ToString();
                txtSodienthoai.Text = chon.Cells[3].Value.ToString();
                string gioiTinh = chon.Cells[4].Value.ToString();
                if (gioiTinh == "Nam")
                {
                    rdoNam.Checked = true;
                }
                else if (gioiTinh == "Nữ")
                {
                    rdoNu.Checked = true;
                }
                txtDiaChi.Text = chon.Cells[5].Value.ToString();
                try
                {
                    txtPathHinh.Text = chon.Cells[6].Value.ToString();
                    System.Data.Linq.Binary imageDataBinary = (System.Data.Linq.Binary)chon.Cells[6].Value;
                    byte[] imageData = imageDataBinary.ToArray();

                    if (imageData != null && imageData.Length > 0)
                    {
                        using (MemoryStream ms = new MemoryStream(imageData))
                        {
                            picThongtinsv.Image = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Dữ liệu hình ảnh không hợp lệ.");
                    }
                }
                catch
                {
                    MessageBox.Show("Không thể hiển thị hình ảnh!");
                    return;
                }
                if (chon != null && chon.Cells[7] != null && chon.Cells[7].Value != null)
                {
                    string maLopHoc = chon.Cells[7].Value.ToString();
                    int index = cboLophoc.FindStringExact(maLopHoc);
                    if (index != -1)
                    {
                        cboLophoc.SelectedIndex = index;
                    }
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemSV();
            
        }
        void ThemSV()
        {
            using (AssignmentCSharp3DataContext db = new AssignmentCSharp3DataContext()) { 
                Student std = new Student();
                string masv = txtMasv.Text.Trim();
                std = db.Students.FirstOrDefault(x => x.MaSV.Equals(masv));
                string hoten = txtHotensv.Text.Trim();
                string email = txtEmail.Text.Trim();
                var checkEmail = db.Students.FirstOrDefault(x => x.Email.Equals(email));
                string soDienThoai = txtSodienthoai.Text;
                var checkSdt = db.Students.FirstOrDefault(x => x.SoDT.Equals(soDienThoai));
                string gioiTinh = CheckGioiTinh();
                string diaChi = txtDiaChi.Text.Trim();
                string pathHinhtxt = txtPathHinh.Text.Trim();
                string chonLop = cboLophoc.SelectedItem.ToString();
                if(masv == string.Empty)
                {
                    MessageBox.Show("Vui lòng nhập mã sinh viên!"); return;
                }
                if (std != null)
                {
                    MessageBox.Show("Đã có mã sinh viên này!");
                    return;
                }
                if (hoten == string.Empty)
                {
                    MessageBox.Show("Vui lòng nhập họ và tên!"); return;
                }
                if (email == string.Empty)
                {
                    MessageBox.Show("Vui lòng nhập email!"); return;
                }
                if(checkEmail != null)
                {
                    MessageBox.Show("Email này đã có!"); return;
                }
                if (soDienThoai == string.Empty)
                {
                    MessageBox.Show("Vui lòng nhập số điện thoại!"); return;
                }
                else
                {

                    if (!long.TryParse(soDienThoai, out long sdt))
                    {
                        MessageBox.Show("Vui lòng nhập số điện thoại là số!");
                        return;
                    }
                }
                if (soDienThoai.Length < 10 || soDienThoai.Length > 13)
                {
                    MessageBox.Show("Số điện thoại phải từ 10 đến 13 chữ số!");
                    return;
                }

                if (checkSdt != null)
                {
                    MessageBox.Show("Số điện thoại này đã có!"); return;
                }
                if (gioiTinh == null)
                {
                    MessageBox.Show("Vui lòng chọn giới tính!"); return;
                }
                if (diaChi == string.Empty)
                {
                    MessageBox.Show("Vui lòng nhập địa chỉ!"); return;
                }
                if (string.IsNullOrEmpty(txtPathHinh.Text))
                {
                    MessageBox.Show("Vui lòng chọn một tệp hình ảnh!");
                    return;
                }
                if(chonLop == "")
                {
                    MessageBox.Show("Vui lòng chọn lớp học!");
                    return;
                }
                byte[] imageData = null;
                try
                {
                    imageData = File.ReadAllBytes(pathHinhtxt);
                }
                catch
                {
                    MessageBox.Show("Lỗi đường truyền ảnh!"); return;
                }
                using (SqlConnection conn = new SqlConnection(pathdb))
                {
                    string queryDiemSV = @"insert into grade values('" + masv + "', '0', '0', '0')";
                    string queryTTSV = @"insert into students values (@MaSV, @HoTen, @Email, @SoDienThoai, @GioiTinh, @DiaChi, @Hinh, @LopHoc)";

                    conn.Open();
                    SqlCommand cmd = new SqlCommand(queryTTSV, conn);
                    cmd.Parameters.AddWithValue("@MaSV", masv);
                    cmd.Parameters.AddWithValue("@HoTen", hoten);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@SoDienThoai", soDienThoai);
                    cmd.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                    cmd.Parameters.AddWithValue("@DiaChi", diaChi);
                    cmd.Parameters.AddWithValue("@Hinh", imageData);
                    cmd.Parameters.AddWithValue("@LopHoc", chonLop);

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        SqlCommand cmd2 = new SqlCommand(queryDiemSV, conn);
                        cmd2.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Thêm thành công!");
                        ClearField();
                        Display();
                    }
                }
            }
        }
        void ClearField()
        {
            txtMasv.Text = "";
            txtHotensv.Text = "";
            txtEmail.Text = "";
            txtSodienthoai.Text = "";
            rdoNam.Checked = true;
            txtDiaChi.Text = "";
            txtPathHinh.Text = "";
            picThongtinsv.Image = null;
            cboLophoc.SelectedIndex = -1;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SuaThongTinSV();
            
        }
        void SuaThongTinSV()
        {
            using(var db = new AssignmentCSharp3DataContext())
            {
                string layMasv = txtMasv.Text;
                Student std = db.Students.FirstOrDefault(x => x.MaSV.Equals(layMasv));
                if (std != null)
                {
                    std.HoTen = txtHotensv.Text;
                    std.Email = txtEmail.Text;
                    std.SoDT = txtSodienthoai.Text;
                    std.Gioitinh = CheckGioiTinh();
                    std.DiaChi = txtDiaChi.Text;
                    try
                    {
                        if (!string.IsNullOrEmpty(txtPathHinh.Text))
                        {
                            string pathHinhMoi = txtPathHinh.Text;
                            byte[] imageData = File.ReadAllBytes(pathHinhMoi);
                            std.Hinh = imageData;
                        }
                        std.LopHoc = cboLophoc.SelectedItem.ToString();
                        db.SubmitChanges();
                        MessageBox.Show("Sửa thành công!");
                        ClearField();
                        Display();
                    }
                    catch
                    {
                        MessageBox.Show("Lỗi đường truyền ảnh!");
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy mã sinh viên này!");
                }
            }
        }
        string CheckGioiTinh()
        {
            if(rdoNam.Checked)
            {
                return "Nam";
            }
            return "Nữ";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            XoaThongTinSV();
            
        }
        void XoaThongTinSV()
        {
            using (var db = new AssignmentCSharp3DataContext())
            {
                string layMasv = txtMasv.Text;
                if(layMasv == "")
                {
                    MessageBox.Show("Không tìm thấy mã sinh viên này!");
                    return;
                }
                var std = db.Students.FirstOrDefault(x => x.MaSV.Equals(layMasv));
                if (std != null)
                {
                    var grade = db.Grades.FirstOrDefault(x => x.MaSV.Equals(layMasv));
                    if (grade != null)
                    {
                        db.Grades.DeleteOnSubmit(grade);
                    }
                    db.Students.DeleteOnSubmit(std);
                    db.SubmitChanges();
                    MessageBox.Show("Xóa thành công!");
                    ClearField();
                    Display();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy mã sinh viên này!");
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearField();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTaianh_Click(object sender, EventArgs e)
        {
            Taianh();
        }
        void Taianh()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                txtPathHinh.Text = filePath;

                try
                {
                    using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                    {
                        picThongtinsv.Image = Image.FromStream(fs);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể tải ảnh lên: " + ex.Message);
                }
            }
        }
    }
}
