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
    public partial class frmQuanLyPhieuThu : Form
    {
        public frmQuanLyPhieuThu()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Không cho resize
            this.MaximizeBox = false; // Ẩn nút phóng to
            this.MinimizeBox = true;  // Có thể giữ hoặc bỏ tùy ý
            this.SizeGripStyle = SizeGripStyle.Hide; // Ẩn góc resize
        }

        private void frmQuanLyPhieuThu_Load(object sender, EventArgs e)
        {

        }
    }
}
