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
    public partial class FormDiemSinhVien : Form
    {
        public FormDiemSinhVien()
        {
            InitializeComponent();
            Display();
        }
        void Display()
        {
            DiemSV.Instance.XemDiemSV(dgvQLDSV);
        }
        void ClearField()
        {
            txtMasv.Text = "";
            txtTensinhvien.Text = "";
            txtTienganh.Text = "";
            txtTinhoc.Text = "";
            txtTheduc.Text = "";
        }
        private void dgvQLDSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow chon = dgvQLDSV.Rows[e.RowIndex];
                    txtMasv.Text = chon.Cells[0].Value.ToString();
                    txtTensinhvien.Text = chon.Cells[1].Value.ToString();
                    txtTienganh.Text = chon.Cells[2].Value.ToString();
                    txtTinhoc.Text = chon.Cells[3].Value.ToString();
                    txtTheduc.Text = chon.Cells[4].Value.ToString();
                    float diemTA = float.Parse(chon.Cells[2].Value.ToString());
                    float diemTH = float.Parse(chon.Cells[3].Value.ToString());
                    float diemVovinam = float.Parse(chon.Cells[4].Value.ToString());
                    txtDiemTB.Text = DiemTB(diemTA, diemTH, diemVovinam);
                }
            }
            catch
            {
                MessageBox.Show("Vượt quá phạm vi cần chọn");
            }
            
        }
        string DiemTB(float diemTA, float diemTH, float diemVovinam)
        {
            return ((diemTA + diemTH + diemVovinam) / 3).ToString();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemDiemSV();
            Display();
        }
        void ThemDiemSV()
        {
            using(var db = new AssignmentCSharp3DataContext())
            {
                Grade gr = new Grade();
                string masv = txtMasv.Text;
                Student std = db.Students.FirstOrDefault(x => x.MaSV.Equals(masv));
                Grade checkMa = db.Grades.FirstOrDefault(x => x.MaSV.Equals(masv));
                float diemTA;
                string sDiemTA = txtTienganh.Text;
                float diemTH;
                string sDiemTH = txtTinhoc.Text;
                float diemVovinam;
                string sDiemVovinam = txtTheduc.Text;
                
                if (masv == string.Empty)
                {
                    MessageBox.Show("Vui lòng điền mã sinh viên!"); return;
                }
                if(std == null)
                {
                    MessageBox.Show("Không tìm thấy mã sinh viên!"); return;
                }
                if(checkMa != null)
                {
                    MessageBox.Show("Mã sinh viên này đã có!"); return;
                }
                if(sDiemTA == string.Empty)
                {
                    MessageBox.Show("Vui lòng điền điểm tiếng anh!"); return;
                }
                if(!float.TryParse(sDiemTA, out diemTA))
                {
                    MessageBox.Show("Vui lòng điền điểm tiếng anh là số!"); return;
                }
                if(diemTA < 0 || diemTA > 10)
                {
                    MessageBox.Show("Điền điểm tiếng anh trong khoảng 0-10!"); return;
                }
                if (sDiemTH == string.Empty)
                {
                    MessageBox.Show("Vui lòng điền điểm tin học!"); return;
                }
                if (!float.TryParse(sDiemTH, out diemTH))
                {
                    MessageBox.Show("Vui lòng điền điểm tin học là số!"); return;
                }
                if (diemTH < 0 || diemTH > 10)
                {
                    MessageBox.Show("Điền điểm tin học trong khoảng 0-10!"); return;
                }
                if (sDiemVovinam == string.Empty)
                {
                    MessageBox.Show("Vui lòng điền điểm vovinam!"); return;
                }
                if (!float.TryParse(sDiemVovinam, out diemVovinam))
                {
                    MessageBox.Show("Vui lòng điền điểm vovinam là số!"); return;
                }
                if (diemVovinam < 0 || diemVovinam > 10)
                {
                    MessageBox.Show("Điền điểm vovinam trong khoảng 0-10!"); return;
                }
                gr.MaSV = masv;
                gr.TiengAnh = diemTA;
                gr.TinHoc = diemTH;
                gr.Vovinam = diemVovinam;
                db.Grades.InsertOnSubmit(gr);
                db.SubmitChanges();
                MessageBox.Show("Thêm thành công!");
                ClearField();
                Display();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SuaDiemSV();
        }
        void SuaDiemSV()
        {
            using(var db = new AssignmentCSharp3DataContext())
            {
                string maSV = txtMasv.Text;
                if(maSV == string.Empty)
                {
                    MessageBox.Show("Vui lòng điền mã sinh viên muốn sửa!"); return;
                }
                Grade layMa = db.Grades.FirstOrDefault(x => x.MaSV.Equals(maSV));
                float diemTA;
                string sDiemTA = txtTienganh.Text;
                float diemTH;
                string sDiemTH = txtTinhoc.Text;
                float diemVovinam;
                string sDiemVovinam = txtTheduc.Text;
                if (!float.TryParse(sDiemTA, out diemTA))
                {
                    MessageBox.Show("Vui lòng điền điểm tiếng anh là số!"); return;
                }
                if (diemTA < 0 || diemTA > 10)
                {
                    MessageBox.Show("Điền điểm tiếng anh trong khoảng 0-10!"); return;
                }
                if (!float.TryParse(sDiemTH, out diemTH))
                {
                    MessageBox.Show("Vui lòng điền điểm tin học là số!"); return;
                }
                if (diemTH < 0 || diemTH > 10)
                {
                    MessageBox.Show("Điền điểm tin học trong khoảng 0-10!"); return;
                }
                if (!float.TryParse(sDiemVovinam, out diemVovinam))
                {
                    MessageBox.Show("Vui lòng điền điểm vovinam là số!"); return;
                }
                if (diemVovinam < 0 || diemVovinam > 10)
                {
                    MessageBox.Show("Điền điểm vovinam trong khoảng 0-10!"); return;
                }
                if (layMa != null)
                {
                    layMa.TiengAnh = diemTA;
                    layMa.TinHoc = diemTH;
                    layMa.Vovinam = diemVovinam;
                    db.SubmitChanges();
                    MessageBox.Show("Sửa thành công!");
                    ClearField();
                    Display();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy mã sinh viên!");
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearField();
        }

        private void btnTimsinhvien_Click(object sender, EventArgs e)
        {
            TimSinhVien();
        }
        void TimSinhVien()
        {
            string masvToFind = txtTimmasv.Text;
            DataGridViewRow tim = null;
            foreach (DataGridViewRow row in dgvQLDSV.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == masvToFind)
                {
                    tim = row;
                    break;
                }
            }
            if(tim != null)
            {
                txtMasv.Text = tim.Cells[0].Value.ToString();
                txtTensinhvien.Text = tim.Cells[1].Value.ToString();
                txtTienganh.Text = tim.Cells[2].Value.ToString();
                txtTinhoc.Text = tim.Cells[3].Value.ToString();
                txtTheduc.Text = tim.Cells[4].Value.ToString();
                float diemTA = float.Parse(tim.Cells[2].Value.ToString());
                float diemTH = float.Parse(tim.Cells[3].Value.ToString());
                float diemVovinam = float.Parse(tim.Cells[4].Value.ToString());
                txtDiemTB.Text = DiemTB(diemTA,diemTH,diemVovinam);
                int rowIndex = tim.Index;
                int columnIndex = 0;
                dgvQLDSV.CurrentCell = dgvQLDSV.Rows[rowIndex].Cells[columnIndex];
                txtTimmasv.Text = "";
            }
            else
            {
                MessageBox.Show("Không tìm thấy mã sinh viên này!");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
