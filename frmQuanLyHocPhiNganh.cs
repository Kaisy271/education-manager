using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Education_Manager
{
    public partial class frmQuanLyHocPhiNganh : Form
    {
        // Biến để lưu ID của dòng đang được chọn trong DataGridView
        private string selected_id_hoc_phi_nganh = null;

        public frmQuanLyHocPhiNganh()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void frmQuanLyHocPhiNganh_Load(object sender, EventArgs e)
        {
            // Tải dữ liệu cho các ComboBox trước
            LoadComboBoxes();
            // Tải dữ liệu chính cho DataGridView
            LoadData();

            // Gán các sự kiện cho nút bấm và DataGridView
            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
            btnThem.Click += btnThem_Click;
            btnSua.Click += btnSua_Click;
            btnXoa.Click += btnXoa_Click;
            btnTimKiem.Click += btnTimKiem_Click;
            btnLamMoi.Click += btnLamMoi_Click;

            // Cấu hình lại các control không cần thiết
            label9.Visible = false;       // Ẩn label "Tổng số tín chỉ"
            numTongSoTien.Visible = false; // Ẩn NumericUpDown không dùng
        }

        // Tải dữ liệu cho ComboBox Ngành và Học kỳ
        private void LoadComboBoxes()
        {
            try
            {
                // Load danh sách Ngành vào ComboBox Ngành (tên control là cbHocKy)
                cbHocKy.DataSource = DatabaseHelper.ExecuteQuery("SELECT id_nganh, ten_nganh FROM Nganh");
                cbHocKy.DisplayMember = "ten_nganh";
                cbHocKy.ValueMember = "id_nganh";

                // Load danh sách các học kỳ duy nhất từ bảng Lop_hoc_phan
                // Đây là cách tốt để đảm bảo chỉ có các học kỳ hợp lệ
                comboBox1.DataSource = DatabaseHelper.ExecuteQuery("SELECT DISTINCT id_hoc_ky FROM Lop_hoc_phan");
                comboBox1.DisplayMember = "id_hoc_ky";
                comboBox1.ValueMember = "id_hoc_ky";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách Ngành/Học kỳ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Tải và hiển thị dữ liệu học phí ngành
        private void LoadData()
        {
            string query = @"
                SELECT 
                    hpn.id_hoc_phi_nganh, 
                    hpn.id_nganh, 
                    n.ten_nganh, 
                    hpn.id_hoc_ky, 
                    hpn.so_tien 
                FROM 
                    Hoc_phi_nganh hpn
                JOIN 
                    Nganh n ON hpn.id_nganh = n.id_nganh;";
            try
            {
                DataTable dt = DatabaseHelper.ExecuteQuery(query);
                dataGridView1.DataSource = dt;

                // Cấu hình các cột trong DataGridView để dễ nhìn hơn
                dataGridView1.Columns["id_nganh"].Visible = false; // Ẩn cột ID ngành
                dataGridView1.Columns["id_hoc_phi_nganh"].HeaderText = "Mã HP Ngành";
                dataGridView1.Columns["ten_nganh"].HeaderText = "Tên Ngành";
                dataGridView1.Columns["id_hoc_ky"].HeaderText = "Học Kỳ";
                dataGridView1.Columns["so_tien"].HeaderText = "Số Tiền / Tín Chỉ";

                dataGridView1.Columns["so_tien"].DefaultCellStyle.Format = "N0"; // Định dạng số tiền
                dataGridView1.Columns["ten_nganh"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu học phí ngành: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Sự kiện khi người dùng chọn một dòng khác trong DataGridView
        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                selected_id_hoc_phi_nganh = row.Cells["id_hoc_phi_nganh"].Value?.ToString();

                // Hiển thị dữ liệu từ dòng được chọn lên các control
                txtMaSV.Text = selected_id_hoc_phi_nganh;
                cbHocKy.SelectedValue = row.Cells["id_nganh"].Value;
                comboBox1.SelectedValue = row.Cells["id_hoc_ky"].Value;
                // numericUpDown1 là control cho "Số tiền"
                numericUpDown1.Value = Convert.ToDecimal(row.Cells["so_tien"].Value);
            }
        }

        // Xử lý sự kiện nút "Thêm"
        private void btnThem_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Hoc_phi_nganh (id_hoc_phi_nganh, id_nganh, id_hoc_ky, so_tien) VALUES (@id, @id_nganh, @id_hoc_ky, @so_tien)";
            string newId = "HPN" + DateTime.Now.Ticks;

            SqlParameter[] parameters = {
                new SqlParameter("@id", newId),
                new SqlParameter("@id_nganh", cbHocKy.SelectedValue),
                new SqlParameter("@id_hoc_ky", comboBox1.SelectedValue),
                new SqlParameter("@so_tien", numericUpDown1.Value)
            };

            try
            {
                if (DatabaseHelper.ExecuteNonQuery(query, parameters) > 0)
                {
                    MessageBox.Show("Thêm học phí ngành thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Xử lý sự kiện nút "Sửa"
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selected_id_hoc_phi_nganh))
            {
                MessageBox.Show("Vui lòng chọn một mục để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "UPDATE Hoc_phi_nganh SET id_nganh = @id_nganh, id_hoc_ky = @id_hoc_ky, so_tien = @so_tien WHERE id_hoc_phi_nganh = @id";
            SqlParameter[] parameters = {
                new SqlParameter("@id_nganh", cbHocKy.SelectedValue),
                new SqlParameter("@id_hoc_ky", comboBox1.SelectedValue),
                new SqlParameter("@so_tien", numericUpDown1.Value),
                new SqlParameter("@id", selected_id_hoc_phi_nganh)
            };

            try
            {
                if (DatabaseHelper.ExecuteNonQuery(query, parameters) > 0)
                {
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Xử lý sự kiện nút "Xóa"
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selected_id_hoc_phi_nganh))
            {
                MessageBox.Show("Vui lòng chọn một mục để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa mục này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string query = "DELETE FROM Hoc_phi_nganh WHERE id_hoc_phi_nganh = @id";
                SqlParameter[] parameters = { new SqlParameter("@id", selected_id_hoc_phi_nganh) };

                try
                {
                    DatabaseHelper.ExecuteNonQuery(query, parameters);
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Xử lý sự kiện nút "Tìm kiếm"
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string query = @"
                SELECT hpn.*, n.ten_nganh 
                FROM Hoc_phi_nganh hpn
                JOIN Nganh n ON hpn.id_nganh = n.id_nganh
                WHERE n.ten_nganh LIKE @keyword OR hpn.id_hoc_ky LIKE @keyword";

            SqlParameter[] parameters = { new SqlParameter("@keyword", "%" + txtTimKiem.Text.Trim() + "%") };

            try
            {
                DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Xử lý sự kiện nút "Làm mới"
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearFields();
            LoadData();
        }

        // Phương thức dọn dẹp các control nhập liệu
        private void ClearFields()
        {
            txtMaSV.Text = "";
            txtTimKiem.Text = "";
            if (cbHocKy.Items.Count > 0) cbHocKy.SelectedIndex = 0;
            if (comboBox1.Items.Count > 0) comboBox1.SelectedIndex = 0;
            numericUpDown1.Value = numericUpDown1.Minimum;
            selected_id_hoc_phi_nganh = null;
            dataGridView1.ClearSelection();
        }
    }
}