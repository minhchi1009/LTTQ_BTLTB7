using bai4.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace bai4
{
    public partial class Form2 : Form
    {
        private bai4vpsqlContext db = new bai4vpsqlContext();
        public Form2()
        {
            InitializeComponent();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTenBacSi.Clear();
            txtChuyenKhoa.Clear();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            var listBacSi = db.BacSis.Select(x => new
            {
                bacSi = x.MaBs,
                tenBacSi = x.TenBs,
                chuyenKhoa = x.ChuyenKhoa
            }).ToList();
            dgvTTBacSi.DataSource = listBacSi;

        }

        private void dgvTTBacSi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTTBacSi.Rows[e.RowIndex];
                if (row.Cells["bacSi"].Value == null) return;
                int maBacSi = Convert.ToInt32(row.Cells["bacSi"].Value);
                var bacSi = db.BacSis.FirstOrDefault(x => x.MaBs == maBacSi);
                if (bacSi != null)
                {
                    txtTenBacSi.Text = bacSi.TenBs;
                    txtChuyenKhoa.Text = bacSi.ChuyenKhoa;
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtTenBacSi.Text))
                {
                    MessageBox.Show("Loi", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtChuyenKhoa.Text))
                {
                    MessageBox.Show("loi", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                BacSi bs = new BacSi()
                {
                    TenBs = txtTenBacSi.Text,
                    ChuyenKhoa = txtChuyenKhoa.Text

                };
                db.Add(bs);
                db.SaveChanges();
                MessageBox.Show("ok", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();

            }
            catch (Exception ex)
            {
                MessageBox.Show("loi" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvTTBacSi.CurrentRow == null || dgvTTBacSi.CurrentRow.Index < 0)
                {
                    MessageBox.Show("loi", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (dgvTTBacSi.CurrentRow.Cells["bacSi"].Value == null) return;
                int maBacSi = Convert.ToInt32(dgvTTBacSi.CurrentRow.Cells["bacSi"].Value);
                bool coLichKham = db.LichKhams.Any(x => x.MaBs == maBacSi);
                if (coLichKham)
                {
                    MessageBox.Show("Loi khong xoa dc bac si nay dang co lich kham", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DialogResult result = MessageBox.Show("Co chac xoa khong", "Choice", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    var bs = db.BacSis.Find(maBacSi);
                    if (bs != null)
                    {
                        db.BacSis.Remove(bs);
                        db.SaveChanges();
                        MessageBox.Show("Completed", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnLamMoi.Enabled = true;
                        LoadData();
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("loi" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtTenBacSi.Text))
                {
                    MessageBox.Show("loi", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtChuyenKhoa.Text))
                {
                    MessageBox.Show("loi", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int mabs = Convert.ToInt32(dgvTTBacSi.CurrentRow?.Cells["bacSi"].Value);
                var bs = db.BacSis.Find(mabs);
                if (bs != null)
                {
                    bs.TenBs = txtTenBacSi.Text;
                    bs.ChuyenKhoa = txtChuyenKhoa.Text;
                    db.SaveChanges();
                    MessageBox.Show("ok", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LoadData();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("loi" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnTiemKiem_Click(object sender, EventArgs e)
        {
            TimKiem();
        }
        private void TimKiem()
        {
            string key=txtTiemKiem.Text.Trim().ToLower();
            var query=db.BacSis.AsQueryable();
            if (!string.IsNullOrWhiteSpace(key)){
                query = query.Where(x => x.TenBs.ToLower().Contains(key)||x.ChuyenKhoa.ToLower().Contains(key));
            }
            var bs = query.Select(x => new
            {
                bacSi = x.MaBs,
                TenBs = x.TenBs,
                ChuyenKhoa = x.ChuyenKhoa,
            }).ToList();
            dgvTTBacSi.DataSource = bs; 
            
        }
    }
}
