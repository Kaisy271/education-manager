using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Education_Manager
{
    public partial class frmQuanLyHocSinh : Form
    {

        public frmQuanLyHocSinh()
        {
            InitializeComponent();
            this.Text = "Quản lý Thông tin Sinh viên";
            LoadComboBox();
            LoadSinhVien();
        }

        private void LoadComboBox()
        {
            try
            {
                // 🔹 Load danh sách lớp
                string queryLop = "SELECT id_lop, ten_lop FROM Lop";
                cbLop.DataSource = DatabaseHelper.ExecuteQuery(queryLop);
                cbLop.DisplayMember = "ten_lop";
                cbLop.ValueMember = "id_lop";

                // 🔹 Load trạng thái
                cbTrangThai.Items.Clear();
                cbTrangThai.Items.Add("Đang học");
                cbTrangThai.Items.Add("Bảo lưu");
                cbTrangThai.Items.Add("Đã tốt nghiệp");
                cbTrangThai.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải ComboBox: " + ex.Message);
            }
        }

        private void LoadSinhVien()
        {
            try
            {
                // Lấy dữ liệu rõ ràng (lấy ten_lop bằng JOIN, chuyển gioi_tinh thành Nam/Nữ)
                string query = @"
            SELECT sv.id_sinh_vien,
              
                   sv.ho_ten,
                   sv.ngay_sinh,
                   CASE WHEN sv.gioi_tinh = 1 THEN N'Nam' ELSE N'Nữ' END AS gioi_tinh,
                   sv.dia_chi,
                   sv.email,
                   sv.sdt,
                   sv.trang_thai,
               
                   l.ten_lop,
                   sv.id_lop
            FROM Sinh_vien sv
            LEFT JOIN Lop l ON sv.id_lop = l.id_lop
            ORDER BY sv.id_sinh_vien";

                DataTable dt = DatabaseHelper.ExecuteQuery(query);

                if (dt == null)
                {
                    dgvSinhVien.DataSource = null;
                    return;
                }

                // Thêm cột STT và gán giá trị thứ tự (1..n)
                if (!dt.Columns.Contains("STT"))
                    dt.Columns.Add("STT", typeof(int));

                for (int i = 0; i < dt.Rows.Count; i++)
                    dt.Rows[i]["STT"] = i + 1;

                // Di chuyển cột STT lên đầu
                dt.Columns["STT"].SetOrdinal(0);

                // Bind DataTable vào DataGridView
                dgvSinhVien.DataSource = dt;

                // Hiển thị/định dạng cột
                if (dgvSinhVien.Columns.Contains("ngay_sinh")) { dgvSinhVien.Columns["ngay_sinh"].DefaultCellStyle.Format = "dd/MM/yyyy";
                    dgvSinhVien.Columns["ngay_sinh"].HeaderText = "Ngày sinh";
                }

                if (dgvSinhVien.Columns.Contains("id_sinh_vien"))
                    dgvSinhVien.Columns["id_sinh_vien"].HeaderText = "Mã sinh viên";

                if (dgvSinhVien.Columns.Contains("dia_chi"))
                    dgvSinhVien.Columns["dia_chi"].HeaderText = "Địa chỉ";

                if (dgvSinhVien.Columns.Contains("ho_ten"))
                    dgvSinhVien.Columns["ho_ten"].HeaderText = "Họ tên";

                if (dgvSinhVien.Columns.Contains("email"))
                    dgvSinhVien.Columns["email"].HeaderText = "Email";

                if (dgvSinhVien.Columns.Contains("sdt"))
                    dgvSinhVien.Columns["sdt"].HeaderText = "Số điện thoại";

                if (dgvSinhVien.Columns.Contains("trang_thai"))
                    dgvSinhVien.Columns["trang_thai"].HeaderText = "Trạng thái";

                if (dgvSinhVien.Columns.Contains("ten_lop"))
                    dgvSinhVien.Columns["ten_lop"].HeaderText = "Lớp";

                if (dgvSinhVien.Columns.Contains("gioi_tinh"))
                    dgvSinhVien.Columns["gioi_tinh"].HeaderText = "Giới tính";

                if (dgvSinhVien.Columns.Contains("STT"))
                {
                    dgvSinhVien.Columns["STT"].HeaderText = "STT";
                    dgvSinhVien.Columns["STT"].Width = 50;
                    dgvSinhVien.Columns["STT"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }

                // Ẩn cột id_lop nếu không muốn hiển thị mã lớp (dùng để set SelectedValue)
                if (dgvSinhVien.Columns.Contains("id_lop"))
                    dgvSinhVien.Columns["id_lop"].Visible = false;

                // Nếu muốn ẩn id_nguoi_dung: (tuỳ bạn)
                // if (dgvSinhVien.Columns.Contains("id_nguoi_dung")) dgvSinhVien.Columns["id_nguoi_dung"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi LoadSinhVien: " + ex.Message);
            }

        }
        private bool ValidateData()
        {
            if (string.IsNullOrWhiteSpace(txtMaSV.Text))
            {
                MessageBox.Show("Vui lòng nhập mã sinh viên!", "Cảnh báo");
                txtMaSV.Focus();
                return false;
            }


            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên!", "Cảnh báo");
                txtHoTen.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDiaChi.Text))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ!", "Cảnh báo");
                txtDiaChi.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại!", "Cảnh báo");
                txtSDT.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Vui lòng nhập email!", "Cảnh báo");
                txtEmail.Focus();
                return false;
            }

            if (cbLop.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn lớp!", "Cảnh báo");
                cbLop.Focus();
                return false;
            }

            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateData()) return;

                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

         
                    // Thêm sinh viên
                    string insertQuery = @"
                    INSERT INTO Sinh_vien
                    (id_sinh_vien, id_nguoi_dung, ho_ten, ngay_sinh, gioi_tinh, dia_chi, email, sdt, trang_thai, khoa_hoc, id_lop)
                    VALUES (@id_sinh_vien, @id_nguoi_dung, @ho_ten, @ngay_sinh, @gioi_tinh, @dia_chi, @email, @sdt, @trang_thai, @khoa_hoc, @id_lop)";

                    SqlCommand cmd = new SqlCommand(insertQuery, conn);
                    cmd.Parameters.AddWithValue("@id_sinh_vien", txtMaSV.Text.Trim());
               
                    cmd.Parameters.AddWithValue("@ho_ten", txtHoTen.Text.Trim());
                    cmd.Parameters.AddWithValue("@ngay_sinh", dtpNgaySinh.Value);
                    cmd.Parameters.AddWithValue("@gioi_tinh", rbNam.Checked ? 1 : 0);
                    cmd.Parameters.AddWithValue("@dia_chi", txtDiaChi.Text.Trim());
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                    cmd.Parameters.AddWithValue("@sdt", txtSDT.Text.Trim());
                    cmd.Parameters.AddWithValue("@trang_thai", cbTrangThai.Text.Trim());
                    cmd.Parameters.AddWithValue("@khoa_hoc", DBNull.Value);
                    cmd.Parameters.AddWithValue("@id_lop", cbLop.SelectedValue);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Thêm sinh viên thành công!");
                    LoadSinhVien();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm sinh viên: " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMaSV.Text))
                {
                    MessageBox.Show("Vui lòng chọn sinh viên cần sửa!");
                    return;
                }

                string query = @"UPDATE Sinh_vien 
                     SET ho_ten=@ho_ten, ngay_sinh=@ngay_sinh, gioi_tinh=@gioi_tinh, 
                         dia_chi=@dia_chi, email=@email, sdt=@sdt, trang_thai=@trang_thai, 
                         id_lop=@id_lop
                     WHERE id_sinh_vien=@id_sinh_vien";

                SqlParameter[] p = {
                    new SqlParameter("@id_sinh_vien", txtMaSV.Text),
                    new SqlParameter("@ho_ten", txtHoTen.Text),
                    new SqlParameter("@ngay_sinh", dtpNgaySinh.Value),
                    new SqlParameter("@gioi_tinh", rbNam.Checked ? 1 : 0),
                    new SqlParameter("@dia_chi", txtDiaChi.Text),
                    new SqlParameter("@email", txtEmail.Text),
                    new SqlParameter("@sdt", txtSDT.Text),
                    new SqlParameter("@trang_thai", cbTrangThai.Text),
                    new SqlParameter("@id_lop", cbLop.SelectedValue),
                   
                };

                if (DatabaseHelper.ExecuteNonQuery(query, p) > 0)
                {
                    MessageBox.Show("Cập nhật sinh viên thành công!");
                    LoadSinhVien();
                }
                else MessageBox.Show("Cập nhật thất bại!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sửa: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSV.Text))
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa!");
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa sinh viên này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string query = "DELETE FROM Sinh_vien WHERE id_sinh_vien=@id_sinh_vien";
                SqlParameter[] p = { new SqlParameter("@id_sinh_vien", txtMaSV.Text) };

                if (DatabaseHelper.ExecuteNonQuery(query, p) > 0)
                {
                    MessageBox.Show("Xóa sinh viên thành công!");
                    LoadSinhVien();
                    ClearFields();
                }
            }
        }


        private void btnTimKiem_Click(object sender, EventArgs e)
        {

            string keyword = txtTimKiem.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string query = @"SELECT * FROM Sinh_vien 
                 WHERE id_sinh_vien LIKE @kw 
                    OR id_lop LIKE @kw 
                    OR ho_ten LIKE @kw 
                    OR trang_thai LIKE @kw";

            SqlParameter[] parameters = { new SqlParameter("@kw", "%" + keyword + "%") };
            dgvSinhVien.DataSource = DatabaseHelper.ExecuteQuery(query, parameters);
        }



        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearFields();
            LoadSinhVien();
        }

        private void ClearFields()
        {
            txtMaSV.Clear();
            txtHoTen.Clear();
            txtDiaChi.Clear();
            txtEmail.Clear();
            txtSDT.Clear();
            rbNam.Checked = true;
            cbTrangThai.SelectedIndex = 0;
            dtpNgaySinh.Value = DateTime.Now;
            cbLop.SelectedIndex = 0;
        }

        private void cbLop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void frmQuanLyHocSinh_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void OpenChildForm(Form childForm)
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }
            childForm.MdiParent = this;
            childForm.Dock = DockStyle.Fill;
            childForm.Show();
        }

        private void thôngTinSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmQuanLyHocSinh());
        }

        private void đăngKýHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmDangKyHoc());
        }

        private void dgvHocSinh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvSinhVien.Rows[e.RowIndex];

            // Các cột có thể là null => kiểm tra an toàn
            txtMaSV.Text = row.Cells["id_sinh_vien"].Value?.ToString() ?? "";
            txtHoTen.Text = row.Cells["ho_ten"].Value?.ToString() ?? "";

            // Ngày sinh (kiểm tra null)
            var nsVal = row.Cells["ngay_sinh"].Value;
            if (nsVal != null && nsVal != DBNull.Value)
            {
                DateTime dt;
                if (DateTime.TryParse(nsVal.ToString(), out dt)) dtpNgaySinh.Value = dt;
            }
            else
            {
                dtpNgaySinh.Value = DateTime.Now;
            }

            txtDiaChi.Text = row.Cells["dia_chi"].Value?.ToString() ?? "";
            txtEmail.Text = row.Cells["email"].Value?.ToString() ?? "";
            txtSDT.Text = row.Cells["sdt"].Value?.ToString() ?? "";
            cbTrangThai.Text = row.Cells["trang_thai"].Value?.ToString() ?? "";

            // Set lớp: dùng id_lop ẩn nếu có (an toàn hơn)
            if (row.Cells["id_lop"].Value != null && row.Cells["id_lop"].Value != DBNull.Value)
                cbLop.SelectedValue = row.Cells["id_lop"].Value;
            else if (row.Cells["ten_lop"].Value != null)
                cbLop.Text = row.Cells["ten_lop"].Value.ToString();

            // Giới tính: bây giờ là chuỗi "Nam"/"Nữ"
            string gt = row.Cells["gioi_tinh"].Value?.ToString() ?? "";
            if (gt == "Nam") rbNam.Checked = true;
            else rbNu.Checked = true;

        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}