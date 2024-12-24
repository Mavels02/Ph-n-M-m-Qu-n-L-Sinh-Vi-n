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
    public partial class FormDanhChoSV : Form
    {
        public FormDanhChoSV()
        {
            InitializeComponent();
            Displaythongtin();
            DisplayDiem();
        }
        void Displaythongtin()
        {
            ThongTinSV.Instance.XemInfoSV(dgvTTSV);
        }
        void DisplayDiem()
        {
            DiemSV.Instance.XemDiemSV(dgvDSV);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
