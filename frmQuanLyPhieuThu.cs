using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Education_Manager
{
    public partial class frmQuanLyPhieuThu : Form
    {
        private string selected_id_phieu_thu = null; // Biến lưu ID phiếu thu

        public frmQuanLyPhieuThu()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void frmQuanLyPhieuThu_Load(object sender, EventArgs e)
        {
            LoadComboBoxes();
            LoadData();

            // Gán sự kiện
            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
            btnThem.Click += btnThem_Click;
            btnSua.Click += btnSua_Click;
            btnXoa.Click += btnXoa_Click;
            btnTimKiem.Click += btnTimKiem_Click;
            btnLamMoi.Click += btnLamMoi_Click;
        }

        private void LoadComboBoxes()
        {
            // Load Sinh viên
            cbHocKy.DataSource = DatabaseHelper.ExecuteQuery("SELECT id_sinh_vien, ho_ten FROM Sinh_vien");
            cbHocKy.DisplayMember = "ho_ten";
            cbHocKy.ValueMember = "id_sinh_vien";

            // Load Loại thu chi
            cbTinhTrang.DataSource = DatabaseHelper.ExecuteQuery("SELECT id_loai_tc, ten_loai FROM Loai_thu_chi");
            cbTinhTrang.DisplayMember = "ten_loai";
            cbTinhTrang.ValueMember = "id_loai_tc";

            // Load Người dùng (Người lập phiếu)
            comboBox1.DataSource = DatabaseHelper.ExecuteQuery("SELECT id_nguoi_dung, tai_khoan FROM Nguoi_dung");
            comboBox1.DisplayMember = "tai_khoan";
            comboBox1.ValueMember = "id_nguoi_dung";
        }

        private void LoadData()
        {
            string query = @"
                SELECT 
                    pt.id_phieu_thu,
                    pt.id_sinh_vien,
                    sv.ho_ten,
                    pt.id_loai_tc,
                    ltc.ten_loai,
                    pt.id_nguoi_dung,
                    nd.tai_khoan AS nguoi_lap_phieu,
                    pt.so_tien,
                    pt.ngay_thu
                FROM 
                    Phieu_thu pt
                LEFT JOIN 
                    Sinh_vien sv ON pt.id_sinh_vien = sv.id_sinh_vien
                LEFT JOIN 
                    Loai_thu_chi ltc ON pt.id_loai_tc = ltc.id_loai_tc
                LEFT JOIN 
                    Nguoi_dung nd ON pt.id_nguoi_dung = nd.id_nguoi_dung;";
            try
            {
                DataTable dt = DatabaseHelper.ExecuteQuery(query);
                dataGridView1.DataSource = dt;

                // Cấu hình các cột ẩn và tên cột hiển thị
                dataGridView1.Columns["id_sinh_vien"].Visible = false;
                dataGridView1.Columns["id_loai_tc"].Visible = false;
                dataGridView1.Columns["id_nguoi_dung"].Visible = false;

                dataGridView1.Columns["id_phieu_thu"].HeaderText = "Mã Phiếu";
                dataGridView1.Columns["ho_ten"].HeaderText = "Sinh Viên";
                dataGridView1.Columns["ten_loai"].HeaderText = "Loại Thu Chi";
                dataGridView1.Columns["nguoi_lap_phieu"].HeaderText = "Người Lập";
                dataGridView1.Columns["so_tien"].HeaderText = "Số Tiền";
                dataGridView1.Columns["ngay_thu"].HeaderText = "Ngày Thu";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu phiếu thu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                selected_id_phieu_thu = row.Cells["id_phieu_thu"].Value?.ToString();

                txtMaSV.Text = selected_id_phieu_thu; // txtMaSV tương ứng mã phiếu thu
                dateTimePicker1.Value = Convert.ToDateTime(row.Cells["ngay_thu"].Value);
                numTongSoTien.Value = Convert.ToDecimal(row.Cells["so_tien"].Value);

                // Chọn đúng item trong ComboBox
                cbHocKy.SelectedValue = row.Cells["id_sinh_vien"].Value;
                cbTinhTrang.SelectedValue = row.Cells["id_loai_tc"].Value;
                comboBox1.SelectedValue = row.Cells["id_nguoi_dung"].Value;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string query = @"
                INSERT INTO Phieu_thu (id_phieu_thu, id_sinh_vien, id_loai_tc, id_nguoi_dung, so_tien, ngay_thu) 
                VALUES (@id_phieu, @id_sv, @id_loai, @id_user, @so_tien, @ngay_thu)";

            string newId = "PT" + DateTime.Now.Ticks;

            SqlParameter[] parameters = {
                new SqlParameter("@id_phieu", newId),
                new SqlParameter("@id_sv", cbHocKy.SelectedValue),
                new SqlParameter("@id_loai", cbTinhTrang.SelectedValue),
                new SqlParameter("@id_user", comboBox1.SelectedValue),
                new SqlParameter("@so_tien", numTongSoTien.Value),
                new SqlParameter("@ngay_thu", dateTimePicker1.Value)
            };

            try
            {
                if (DatabaseHelper.ExecuteNonQuery(query, parameters) > 0)
                {
                    MessageBox.Show("Thêm phiếu thu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm phiếu thu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selected_id_phieu_thu))
            {
                MessageBox.Show("Vui lòng chọn một phiếu thu để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = @"
                UPDATE Phieu_thu SET 
                    id_sinh_vien = @id_sv, 
                    id_loai_tc = @id_loai, 
                    id_nguoi_dung = @id_user, 
                    so_tien = @so_tien, 
                    ngay_thu = @ngay_thu
                WHERE id_phieu_thu = @id_phieu";

            SqlParameter[] parameters = {
                new SqlParameter("@id_sv", cbHocKy.SelectedValue),
                new SqlParameter("@id_loai", cbTinhTrang.SelectedValue),
                new SqlParameter("@id_user", comboBox1.SelectedValue),
                new SqlParameter("@so_tien", numTongSoTien.Value),
                new SqlParameter("@ngay_thu", dateTimePicker1.Value),
                new SqlParameter("@id_phieu", selected_id_phieu_thu)
            };

            try
            {
                if (DatabaseHelper.ExecuteNonQuery(query, parameters) > 0)
                {
                    MessageBox.Show("Cập nhật phiếu thu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật phiếu thu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selected_id_phieu_thu))
            {
                MessageBox.Show("Vui lòng chọn một phiếu thu để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa phiếu thu này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string query = "DELETE FROM Phieu_thu WHERE id_phieu_thu = @id_phieu";
                SqlParameter[] parameters = { new SqlParameter("@id_phieu", selected_id_phieu_thu) };

                try
                {
                    DatabaseHelper.ExecuteNonQuery(query, parameters);
                    MessageBox.Show("Xóa phiếu thu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa phiếu thu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string query = @"
                SELECT pt.*, sv.ho_ten, ltc.ten_loai, nd.tai_khoan as nguoi_lap_phieu
                FROM Phieu_thu pt
                LEFT JOIN Sinh_vien sv ON pt.id_sinh_vien = sv.id_sinh_vien
                LEFT JOIN Loai_thu_chi ltc ON pt.id_loai_tc = ltc.id_loai_tc
                LEFT JOIN Nguoi_dung nd ON pt.id_nguoi_dung = nd.id_nguoi_dung
                WHERE pt.id_phieu_thu LIKE @keyword OR sv.ho_ten LIKE @keyword";

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

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearFields();
            LoadData();
        }

        private void ClearFields()
        {
            txtMaSV.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            numTongSoTien.Value = numTongSoTien.Minimum;
            cbHocKy.SelectedIndex = -1;
            cbTinhTrang.SelectedIndex = -1;
            comboBox1.SelectedIndex = -1;
            txtTimKiem.Text = "";
            selected_id_phieu_thu = null;
            dataGridView1.ClearSelection();
        }
    }
}