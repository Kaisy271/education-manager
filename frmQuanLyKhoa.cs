using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Education_Manager
{
    public partial class frmQuanLyKhoa : Form
    {
        public frmQuanLyKhoa()
        {
            InitializeComponent();
            LoadKhoa();
        }

        private void LoadKhoa()
        {
            string query = "SELECT * FROM Khoa";
            DataTable dt = DatabaseHelper.ExecuteQuery(query);
            dgvKhoa.DataSource = dt;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenKhoa.Text))
            {
                MessageBox.Show("Vui lòng nhập tên khoa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = "INSERT INTO Khoa(TenKhoa) VALUES (@TenKhoa)";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@TenKhoa", txtTenKhoa.Text),
            };

            int result = DatabaseHelper.ExecuteNonQuery(query, parameters);
            if (result > 0)
            {
                MessageBox.Show("Thêm khoa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadKhoa();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Thêm khoa thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvKhoa.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn khoa cần sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = "UPDATE Khoa SET TenKhoa=@TenKhoa WHERE MaKhoa=@MaKhoa";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@TenKhoa", txtTenKhoa.Text),
                new SqlParameter("@MaKhoa", dgvKhoa.SelectedRows[0].Cells["MaKhoa"].Value)
            };

            int result = DatabaseHelper.ExecuteNonQuery(query, parameters);
            if (result > 0)
            {
                MessageBox.Show("Cập nhật khoa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadKhoa();
            }
            else
            {
                MessageBox.Show("Cập nhật khoa thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvKhoa.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn khoa cần xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa khoa này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string query = "DELETE FROM Khoa WHERE MaKhoa=@MaKhoa";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@MaKhoa", dgvKhoa.SelectedRows[0].Cells["MaKhoa"].Value)
                };

                int result = DatabaseHelper.ExecuteNonQuery(query, parameters);
                if (result > 0)
                {
                    MessageBox.Show("Xóa khoa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadKhoa();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Xóa khoa thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvKhoa_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvKhoa.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvKhoa.SelectedRows[0];
                txtTenKhoa.Text = row.Cells["TenKhoa"].Value.ToString();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();
            string query = "SELECT * FROM Khoa WHERE TenKhoa LIKE @Keyword";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Keyword", $"%{keyword}%")
            };

            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);
            dgvKhoa.DataSource = dt;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadKhoa();
            ClearFields();
            txtTimKiem.Clear();
        }

        private void ClearFields()
        {
            txtTenKhoa.Clear();
        }
    }
}