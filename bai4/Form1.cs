using bai4.Models;
using Microsoft.EntityFrameworkCore;
using System.Drawing.Text;

namespace bai4
{
    public partial class Form1 : Form
    {
        private static readonly DbContextOptions<bai4vpsqlContext> options =
            new DbContextOptionsBuilder<bai4vpsqlContext>().
            UseSqlServer(@"Server=.\SQLEXPRESS;Database=bai4vpsql;Trusted_Connection=True;TrustServerCertificate=True;").Options;
        private bai4vpsqlContext db = new bai4vpsqlContext(options);
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadComboBoxBacSi();
            LoadComboBoxTrangThai();
            LoadData();
        }
        private void LoadComboBoxBacSi()
        {
            var listBacSi = db.BacSis.Select(b => new { b.MaBs, HienThi = b.TenBs + "-" + b.ChuyenKhoa }).ToList();
            cbBacSi.DataSource = listBacSi;
            cbBacSi.DisplayMember = "HienThi";
            cbBacSi.ValueMember = "MaBS";

        }
        private void LoadComboBoxTrangThai()
        {
            cbTrangThai.DataSource = new List<string> { "Chờ khám", "Đã khám", "Đã hủy" };
        }
        private void LoadData()
        {
            var listLichKham = db.LichKhams.Include(x => x.MaBsNavigation).Select(x => new
            {

                Malich = x.MaLich,
                TenBenhNhan = x.TenBenhNhan,
                SDT = x.Sdt,
                NgayKham = x.NgayKham,
                BacSi = x.MaBsNavigation != null ? x.MaBsNavigation.TenBs : "",
                ChuyenKhoa = x.MaBsNavigation != null ? x.MaBsNavigation.ChuyenKhoa : "",
                TrangThai = x.TrangThai
            }).ToList();
            dgvShow.DataSource = listLichKham;
        }
        private void dgvShow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvShow.Rows[e.RowIndex];
                if (row.Cells["Malich"].Value == null) return;
                int maLich = Convert.ToInt32(row.Cells["Malich"].Value);
                var lk = db.LichKhams.FirstOrDefault(x => x.MaLich == maLich);
                if (lk != null)
                {
                    txtTenBenhNhan.Text = lk.TenBenhNhan;
                    txtSoDienThoai.Text = lk.Sdt;
                    dtpNgayKham.Value = lk.NgayKham.ToDateTime(TimeOnly.MinValue);
                    dudGioKham.Text = lk.GioKham.ToString("HH:mm");
                    cbBacSi.SelectedValue = lk.MaBs;
                    cbTrangThai.SelectedItem = lk.TrangThai?.Trim();

                }
            }
        }

        private void btnThemBacSi_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtTenBenhNhan.Text))
                {
                    MessageBox.Show("Ten benh nhan khong duoc trong ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtSoDienThoai.Text) && txtSoDienThoai.Text.Trim().Length > 11 && txtSoDienThoai.Text.Trim().All(char.IsDigit))
                {
                    MessageBox.Show("So dien thoai khong dc trong va khong qua 11 so", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (cbBacSi.SelectedValue == null)
                {
                    MessageBox.Show("Bac si khong duoc de trong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (cbTrangThai.SelectedItem == null)
                {
                    MessageBox.Show("Trang thai khong duoc de trong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                LichKham lk = new LichKham()
                {
                    TenBenhNhan = txtTenBenhNhan.Text,
                    Sdt = txtSoDienThoai.Text,
                    MaBs = (int)cbBacSi.SelectedValue,
                    TrangThai = cbTrangThai.SelectedItem.ToString(),
                    NgayKham = DateOnly.FromDateTime(dtpNgayKham.Value),
                    GioKham = TimeOnly.Parse(dudGioKham.Text),
                };
                db.Add(lk);
                db.SaveChanges();
                MessageBox.Show("Thêm lịch khám thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("loi" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtTenBenhNhan.Text))
                {
                    MessageBox.Show("Ten Benh Nhan khong de trong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtSoDienThoai.Text) && txtSoDienThoai.Text.Trim().Length > 11
                    && txtSoDienThoai.Text.Trim().All(char.IsDigit))
                {
                    MessageBox.Show("So dien thoai khong duoc de trong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (cbBacSi.SelectedValue == null)
                {
                    MessageBox.Show("Bac si khong duoc bo trong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (cbTrangThai.SelectedValue == null)
                {
                    MessageBox.Show("Trang thai khong duoc de trong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int maLich = Convert.ToInt32(dgvShow.CurrentRow?.Cells["Malich"].Value);
                var lk = db.LichKhams.Find(maLich);
                if (lk != null)
                {
                    lk.TenBenhNhan = txtTenBenhNhan.Text;
                    lk.Sdt = txtSoDienThoai.Text;
                    lk.MaBs = (int)cbBacSi.SelectedValue;
                    lk.TrangThai = cbTrangThai.SelectedItem?.ToString();
                    lk.NgayKham = DateOnly.FromDateTime(dtpNgayKham.Value);
                    lk.GioKham = TimeOnly.Parse(dudGioKham.Text);
                    db.SaveChanges();
                    MessageBox.Show("Thay doi thnah cong ", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvShow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTenBenhNhan.Clear();
            txtSoDienThoai.Clear();
            dtpNgayKham.Value = DateTime.Now;
            if (cbBacSi.Items.Count > 0) cbBacSi.SelectedIndex = 0;
            if (cbTrangThai.Items.Count > 0) cbTrangThai.SelectedIndex = 0;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvShow.CurrentRow == null || dgvShow.CurrentRow.Index < 0)
                {
                    MessageBox.Show("Vui long chon 1 dong de xoa", "Check", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (dgvShow.CurrentRow.Cells["Malich"].Value == null) return;
                int maLich = Convert.ToInt32(dgvShow.CurrentRow.Cells["Malich"].Value);
                DialogResult result = MessageBox.Show("ban cho chac muon xoa lich voi ma {Malich} cua benh nhan '{txtTenBenhNhan.Text}' khong", "Inform", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {

                    var lk = db.LichKhams.Find(maLich);
                    if (lk != null)
                    {
                        db.LichKhams.Remove(lk);
                        db.SaveChanges();
                        MessageBox.Show("Da xoa thanh cong ", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnLamMoi.Enabled = true;
                        LoadData();

                    }
                    else
                    {
                        MessageBox.Show("Lich kham khong ton tai", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        LoadData();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TimKiem()
        {
            String key = cbTimKiem.Text.Trim().ToLower();
            var query = db.LichKhams.Include(x => x.MaBsNavigation).AsQueryable();
            if (!string.IsNullOrWhiteSpace(key))
            {
                query = query.Where(x => x.TenBenhNhan.ToLower().Contains(key) || (x.Sdt != null && x.Sdt.Contains(key)));
            }
            var listLichKham = query.Select(x => new
            {
                Malich = x.MaLich,
                TenBenhNhan = x.TenBenhNhan,
                SDT = x.Sdt,
                NgayKham = x.NgayKham,
                BacSi = x.MaBsNavigation != null ? x.MaBsNavigation.TenBs : "",
                ChuyenKhoa = x.MaBsNavigation != null ? x.MaBsNavigation.ChuyenKhoa : "",
                TrangThai = x.TrangThai
            }).ToList();

            dgvShow.DataSource = listLichKham;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            TimKiem();
        }
    }
}
