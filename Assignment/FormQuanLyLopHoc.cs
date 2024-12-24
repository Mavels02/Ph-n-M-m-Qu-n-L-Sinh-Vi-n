using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class FormQuanLyLopHoc : Form
    {
        string pathdb = @"Data Source=LAPTOP-2HQQGK0E\NNNN;Initial Catalog=ASM_C#3;Integrated Security=True";
        public FormQuanLyLopHoc()
        {
            InitializeComponent();
            Display();
            DanhsachLH();
        }
        void Display()
        {
            LopHoc.Instance.XemLopHoc(dgvLopHoc);
        }
        void DanhsachLH()
        {
            using (var db = new AssignmentCSharp3DataContext())
            {
                var layListLH = db.Classes.Select(x => x.MaLop).ToList();
                foreach (var lay in layListLH)
                {
                    cboDanhsachlophoc.Items.Add(lay);
                }
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemLH();
        }
        void ThemLH()
        {
            string malop = txtMalop.Text.Trim();
            string tenLop = txtTenlop.Text.Trim();
            if(malop == "")
            {
                MessageBox.Show("Vui lòng điền mã lớp"); return;
            }
            if (tenLop == "")
            {
                MessageBox.Show("Vui lòng điền tên lớp"); return;
            }
            try
            {
                using (SqlConnection conn = new SqlConnection(pathdb))
                {
                    string query = @"insert into Classes values(@maLop, @tenLop)";
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@maLop", malop);
                    cmd.Parameters.AddWithValue("@tenLop", tenLop);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Thêm thành công!");
                    ClearField();
                    Display();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void ClearField()
        {
            txtMalop.Text = "";
            txtTenlop.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string malop = txtMalop.Text.Trim();
            string tenLop = txtTenlop.Text.Trim();
            if (tenLop == "")
            {
                MessageBox.Show("Vui lòng điền tên lớp bạn muốn sửa"); return;
            }
            try
            {
                using (var db = new AssignmentCSharp3DataContext())
                {
                    Class checkMalop = db.Classes.FirstOrDefault(x => x.MaLop.Equals(malop));
                    if(checkMalop != null)
                    {
                        checkMalop.TenLop = tenLop;
                        db.SubmitChanges();
                        MessageBox.Show("Sửa thành công!");
                        ClearField();
                        Display();
                    }
                    else
                    {
                        MessageBox.Show("Mã lớp mà bạn muốn sửa không tìm thấy!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvLopHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow chon = dgvLopHoc.Rows[e.RowIndex];
                    txtMalop.Text = chon.Cells[0].Value.ToString();
                    txtTenlop.Text = chon.Cells[1].Value.ToString();
                }
            }
            catch
            {
                MessageBox.Show("Quá vùng cho phép!");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearField();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            XoaLH();
        }
        void XoaLH()
        {
            using(var db = new AssignmentCSharp3DataContext())
            {
                string maLop = txtMalop.Text;
                if(maLop == "")
                {
                    MessageBox.Show("Điền mã lớp mà bạn muốn xóa!"); return;
                }
                Class checkMalh = db.Classes.FirstOrDefault(x => x.MaLop.Equals(maLop));
                if (checkMalh != null)
                {
                    var students = db.Students.Where(x => x.LopHoc.Equals(maLop));
                    foreach(var s in students)
                    {
                        s.LopHoc = null;
                    }
                    db.Classes.DeleteOnSubmit(checkMalh);
                    db.SubmitChanges();
                    MessageBox.Show("Xóa thành công!");
                    ClearField();
                    Display();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy mã lớp mà bạn muốn xóa!");
                }
            }
        }

        private void cboDanhsachlophoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedClass = cboDanhsachlophoc.SelectedItem.ToString();

            var db = new AssignmentCSharp3DataContext();
            var studentsInClass = db.Students.Where(s => s.LopHoc == selectedClass).ToList();
            dgvDanhsachlophoc.DataSource = studentsInClass;
            int numberOfStudents = studentsInClass.Count;
            txtSoluongsinhvien.Text = numberOfStudents + "";
        }
    }
}
