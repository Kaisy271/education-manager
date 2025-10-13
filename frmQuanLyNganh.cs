using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Education_Manager
{
    public partial class frmQuanLyNganh : Form
    {
        public frmQuanLyNganh()
        {
            InitializeComponent();
            LoadNganh();
            LoadComboBox();
        }

        private void LoadComboBox()
        {
            string queryKhoa = "SELECT MaKhoa, TenKhoa FROM Khoa";
            DataTable dtKhoa = DatabaseHelper.ExecuteQuery(queryKhoa);
            cbKhoa.DataSource = dtKhoa;
            cbKhoa.DisplayMember = "TenKhoa";
            cbKhoa.ValueMember = "MaKhoa";
        }

        private void LoadNganh()
        {
            string query = @"SELECT n.MaNganh, n.TenNganh, n.ThoiGianDaoTao, k.MaKhoa, k.TenKhoa
                           FROM Nganh n
                           JOIN Khoa k ON n.MaKhoa = k.MaKhoa";
            DataTable dt = DatabaseHelper.ExecuteQuery(query);
            dgvNganh.DataSource = dt;
            dgvNganh.Columns["MaKhoa"].Visible = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenNganh.Text))
            {
                MessageBox.Show("Vui lòng nhập tên ngành!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = "INSERT INTO Nganh(TenNganh, ThoiGianDaoTao, MaKhoa) VALUES (@TenNganh, @ThoiGianDaoTao, @MaKhoa)";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@TenNganh", txtTenNganh.Text),
                new SqlParameter("@ThoiGianDaoTao", numThoiGian.Value),
                new SqlParameter("@MaKhoa", cbKhoa.SelectedValue),
            };

            int result = DatabaseHelper.ExecuteNonQuery(query, parameters);
            if (result > 0)
            {
                MessageBox.Show("Thêm ngành thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadNganh();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Thêm ngành thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvNganh.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ngành cần sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = "UPDATE Nganh SET TenNganh=@TenNganh, ThoiGianDaoTao=@ThoiGianDaoTao, MaKhoa=@MaKhoa WHERE MaNganh=@MaNganh";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@TenNganh", txtTenNganh.Text),
                new SqlParameter("@ThoiGianDaoTao", numThoiGian.Value),
                new SqlParameter("@MaKhoa", cbKhoa.SelectedValue),
                new SqlParameter("@MaNganh", dgvNganh.SelectedRows[0].Cells["MaNganh"].Value)
            };

            int result = DatabaseHelper.ExecuteNonQuery(query, parameters);
            if (result > 0)
            {
                MessageBox.Show("Cập nhật ngành thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadNganh();
            }
            else
            {
                MessageBox.Show("Cập nhật ngành thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvNganh.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ngành cần xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa ngành này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string query = "DELETE FROM Nganh WHERE MaNganh=@MaNganh";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@MaNganh", dgvNganh.SelectedRows[0].Cells["MaNganh"].Value)
                };

                int result = DatabaseHelper.ExecuteNonQuery(query, parameters);
                if (result > 0)
                {
                    MessageBox.Show("Xóa ngành thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadNganh();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Xóa ngành thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvLopHoc_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvNganh.SelectedRows.Count > 0)
            {
                try
                {
                    DataGridViewRow row = dgvNganh.SelectedRows[0];

                    txtTenNganh.Text = row.Cells["TenNganh"].Value?.ToString() ?? "";

                    if (row.Cells["ThoiGianDaoTao"].Value != null)
                    {
                        decimal siSoValue;
                        if (decimal.TryParse(row.Cells["ThoiGianDaoTao"].Value.ToString(), out siSoValue))
                        {
                            int siSo = (int)Math.Round(siSoValue);
                            siSo = Math.Max((int)numThoiGian.Minimum, Math.Min((int)numThoiGian.Maximum, siSo));
                            numThoiGian.Value = siSo;
                        }
                        else
                        {
                            numThoiGian.Value = numThoiGian.Minimum;
                        }
                    }
                    else
                    {
                        numThoiGian.Value = numThoiGian.Minimum;
                    }

                    if (row.Cells["MaKhoa"].Value != null)
                        cbKhoa.SelectedValue = row.Cells["MaKhoa"].Value;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();
            string query = @"SELECT n.MaNganh, n.TenNganh, n.ThoiGianDaoTao, k.MaKhoa, k.TenKhoa
                           FROM Nganh n
                           JOIN Khoa k ON n.MaKhoa = k.MaKhoa
                           WHERE n.TenNganh LIKE @Keyword OR k.TenKhoa LIKE @Keyword";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Keyword", $"%{keyword}%")
            };

            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);
            dgvNganh.DataSource = dt;
            dgvNganh.Columns["MaKhoa"].Visible = false;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadNganh();
            ClearFields();
            txtTimKiem.Clear();
        }

        private void ClearFields()
        {
            txtTenNganh.Clear();
            numThoiGian.Minimum = 0;
            numThoiGian.Value = 0;
            if (cbKhoa.Items.Count > 0)
                cbKhoa.SelectedIndex = 0;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void frmQuanLyLop_Load(object sender, EventArgs e)
        {

        }
    }
}