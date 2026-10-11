using Microsoft.EntityFrameworkCore;
using System;
using System.Data;
using QuanLyNhaSach.Models;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyNhaSach
{
    public partial class Form1 : Form
    {
        private readonly QuanLyNhaSachContext _context = new QuanLyNhaSachContext();

        public Form1()
        {
            InitializeComponent();
        }

        // Yêu cầu 3: sự kiện SelectionChanged của DataGridView để hiển thị thông tin chi tiết của thể loại sách được chọn trong các TextBox và Label
        private void dgvTheLoai_SelectionChanged(object sender, EventArgs e)
        {
            dgvTheLoai.AutoGenerateColumns = true;
            if (dgvTheLoai.CurrentRow != null && dgvTheLoai.CurrentRow.DataBoundItem is TheLoaiSach selected)
            {
                txtMaTL.Text = selected.MaTL.ToString();
                txtTenTL.Text = selected.TenTheLoai;
                txtMoTa.Text = selected.MoTa;

                // Hiển thị ngày tạo
                lblNgayTao.Text = selected.NgayTao.HasValue
                    ? $"Ngày tạo: {selected.NgayTao.Value:dd/MM/yyyy HH:mm}"
                    : "Ngày tạo: -";
            }
        }

        private async Task Form1_LoadAsync(object sender, EventArgs e)
        {
            await LoadDataAsync();
        }

        private async Task LoadDataAsync()
        {
            // Tải lại toàn bộ danh sách thể loại sách từ CSDL
            var list = await _context.TheLoaiSach.ToListAsync();
            dgvTheLoai.DataSource = list;

            // Xóa rỗng các ô nhập
            ClearInput();
        }

        private void ClearInput()
        {
            txtMaTL.Clear();
            txtTenTL.Clear();
            txtMoTa.Clear();
            lblNgayTao.Text = "Ngày tạo: -";
            dgvTheLoai.ClearSelection();
        }

        private async void btnThem_Click(object sender, EventArgs e)
        {
            string tenTL = txtTenTL.Text.Trim();

            // Validate: Không được bỏ trống Tên thể loại
            if (string.IsNullOrEmpty(tenTL))
            {
                MessageBox.Show("Vui lòng nhập Tên thể loại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenTL.Focus();
                return;
            }

            // Validate: Không cho phép trùng tên thể loại khi Thêm mới
            bool exists = await _context.TheLoaiSach.AnyAsync(x => x.TenTheLoai.ToLower() == tenTL.ToLower());
            if (exists)
            {
                MessageBox.Show("Tên thể loại này đã tồn tại trong hệ thống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Khởi tạo đối tượng mới
            var newItem = new TheLoaiSach
            {
                TenTheLoai = tenTL,
                MoTa = txtMoTa.Text.Trim(),
                NgayTao = DateTime.Now
            };

            _context.TheLoaiSach.Add(newItem);
            await _context.SaveChangesAsync();

            MessageBox.Show("Thêm mới thể loại thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            await LoadDataAsync();
        }

        private async void btnSua_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtMaTL.Text, out int maTL))
            {
                MessageBox.Show("Vui lòng chọn dòng cần sửa từ bảng dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tenTL = txtTenTL.Text.Trim();

            // Validate: Không được bỏ trống Tên thể loại
            if (string.IsNullOrEmpty(tenTL))
            {
                MessageBox.Show("Tên thể loại không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate: Trùng tên với bản ghi khác trong CSDL
            bool exists = await _context.TheLoaiSach.AnyAsync(x => x.TenTheLoai.ToLower() == tenTL.ToLower() && x.MaTL != maTL);
            if (exists)
            {
                MessageBox.Show("Tên thể loại bị trùng với bản ghi khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Cập nhật dữ liệu
            var item = await _context.TheLoaiSach.FindAsync(maTL);
            if (item != null)
            {
                item.TenTheLoai = tenTL;
                item.MoTa = txtMoTa.Text.Trim();

                await _context.SaveChangesAsync();
                MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await LoadDataAsync();
            }
        }

        private async void btnXoa_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtMaTL.Text, out int maTL))
            {
                MessageBox.Show("Vui lòng chọn thể loại cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Hộp thoại xác nhận xóa Yes/No
            var result = MessageBox.Show($"Bạn có chắc chắn muốn xóa thể loại '{txtTenTL.Text}' không?",
                                         "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    var item = await _context.TheLoaiSach.FindAsync(maTL);
                    if (item != null)
                    {
                        _context.TheLoaiSach.Remove(item);
                        await _context.SaveChangesAsync();

                        MessageBox.Show("Xóa thể loại thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        await LoadDataAsync();
                    }
                }
                catch (DbUpdateException)
                {
                    // Bắt lỗi ràng buộc khóa ngoại (ví dụ thể loại này đã có sách tham chiếu)
                    MessageBox.Show("Không thể xóa thể loại này vì đã có sách thuộc thể loại này trong hệ thống!",
                                    "Lỗi ràng buộc CSDL", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    // Xóa trạng thái lỗi đệm trong DbContext
                    _context.ChangeTracker.Clear();
                }
            }
        }

        private async void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim().ToLower();

            // Sử dụng LINQ Where + Contains để lọc tên
            var filteredList = await _context.TheLoaiSach
                .Where(x => x.TenTheLoai.ToLower().Contains(keyword))
                .ToListAsync();

            // Đổ trực tiếp lên DataGridView không cần nạp lại toàn bộ Form
            dgvTheLoai.DataSource = filteredList;
        }

        private async void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            await LoadDataAsync();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await LoadDataAsync();
        }
    }
}
