using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Education_Manager
{
    public partial class frmQuanLyTaiChinhMain : Form
    {
        public frmQuanLyTaiChinhMain()
        {
            InitializeComponent();
        }

        private void OpenChildForm(Form childForm)
        {
            // Đóng các form con cũ nếu cần
            foreach (Form form in this.OwnedForms)
            {
                form.Close();
            }
            childForm.Owner = this; // Gán owner nếu muốn
            childForm.StartPosition = FormStartPosition.CenterParent;
            childForm.Show(); // hoặc ShowDialog() nếu muốn modal
        }

        private void frmQuanLyTaiChinhMain_Load(object sender, EventArgs e)
        {

        }

        private void btnQlyHocPhiSV_Click(object sender, EventArgs e)
        {
            var f = new frmQuanLyHocPhiSinhVien();
            f.StartPosition = FormStartPosition.CenterParent;
            f.Show(this); // hoặc f.ShowDialog(this);
        }

        private void btnQlyHocPhiNganh_Click(object sender, EventArgs e)
        {
            var f = new frmQuanLyHocPhiNganh();
            f.StartPosition = FormStartPosition.CenterParent;
            f.Show(this); // hoặc f.ShowDialog(this);
        }

        private void btnQlyPhieuThu_Click(object sender, EventArgs e)
        {
            var f = new frmQuanLyPhieuThu();
            f.StartPosition = FormStartPosition.CenterParent;
            f.Show(this); // hoặc f.ShowDialog(this);
        }

        private void btnQlyThuChi_Click(object sender, EventArgs e)
        {
            var f = new frmQuanLyLoaiThuChi();
            f.StartPosition = FormStartPosition.CenterParent;
            f.Show(this); // hoặc f.ShowDialog(this);
        }
    }
}
