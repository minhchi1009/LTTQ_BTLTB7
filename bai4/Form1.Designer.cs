namespace bai4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtTenBenhNhan = new TextBox();
            txtSoDienThoai = new TextBox();
            dtpNgayKham = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            dudGioKham = new DomainUpDown();
            cbBacSi = new ComboBox();
            label6 = new Label();
            cbTrangThai = new ComboBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            label7 = new Label();
            label8 = new Label();
            dtpTuNgay = new DateTimePicker();
            dtpDenNgay = new DateTimePicker();
            cbTimKiem = new ComboBox();
            btnDelete = new Button();
            btnLamMoi = new Button();
            btnTimKiem = new Button();
            dgvShow = new DataGridView();
            btnThemBacSi = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvShow).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên bệnh nhân :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 41);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 1;
            label2.Text = "Số điện thoại :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 73);
            label3.Name = "label3";
            label3.Size = new Size(93, 20);
            label3.TabIndex = 2;
            label3.Text = "Ngày Khám :";
            // 
            // txtTenBenhNhan
            // 
            txtTenBenhNhan.Location = new Point(130, 7);
            txtTenBenhNhan.Name = "txtTenBenhNhan";
            txtTenBenhNhan.Size = new Size(262, 27);
            txtTenBenhNhan.TabIndex = 0;
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Location = new Point(130, 41);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(262, 27);
            txtSoDienThoai.TabIndex = 1;
            // 
            // dtpNgayKham
            // 
            dtpNgayKham.Location = new Point(130, 73);
            dtpNgayKham.Name = "dtpNgayKham";
            dtpNgayKham.Size = new Size(262, 27);
            dtpNgayKham.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(425, 48);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 6;
            label4.Text = "Giờ khám";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(612, 48);
            label5.Name = "label5";
            label5.Size = new Size(47, 20);
            label5.TabIndex = 8;
            label5.Text = "Bác sĩ";
            // 
            // dudGioKham
            // 
            dudGioKham.Items.Add("7:00");
            dudGioKham.Items.Add("8:00");
            dudGioKham.Items.Add("9:00");
            dudGioKham.Items.Add("10:00");
            dudGioKham.Items.Add("11:00");
            dudGioKham.Items.Add("13:00");
            dudGioKham.Items.Add("14:00");
            dudGioKham.Items.Add("15:00");
            dudGioKham.Items.Add("16:00");
            dudGioKham.Items.Add("17:00");
            dudGioKham.Location = new Point(425, 73);
            dudGioKham.Name = "dudGioKham";
            dudGioKham.Size = new Size(150, 27);
            dudGioKham.TabIndex = 3;
            // 
            // cbBacSi
            // 
            cbBacSi.FormattingEnabled = true;
            cbBacSi.Location = new Point(612, 75);
            cbBacSi.Name = "cbBacSi";
            cbBacSi.Size = new Size(375, 28);
            cbBacSi.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1007, 47);
            label6.Name = "label6";
            label6.Size = new Size(75, 20);
            label6.TabIndex = 12;
            label6.Text = "Trạng thái";
            // 
            // cbTrangThai
            // 
            cbTrangThai.FormattingEnabled = true;
            cbTrangThai.Items.AddRange(new object[] { "Đã khám", "Chờ khám", "Đã hủy" });
            cbTrangThai.Location = new Point(1007, 75);
            cbTrangThai.Name = "cbTrangThai";
            cbTrangThai.Size = new Size(221, 28);
            cbTrangThai.TabIndex = 4;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(812, 12);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 14;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(924, 12);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 15;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(1036, 12);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 16;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 146);
            label7.Name = "label7";
            label7.Size = new Size(69, 20);
            label7.TabIndex = 17;
            label7.Text = "Từ ngày :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(313, 146);
            label8.Name = "label8";
            label8.Size = new Size(79, 20);
            label8.TabIndex = 18;
            label8.Text = "Đến ngày :";
            // 
            // dtpTuNgay
            // 
            dtpTuNgay.Location = new Point(12, 176);
            dtpTuNgay.Name = "dtpTuNgay";
            dtpTuNgay.Size = new Size(262, 27);
            dtpTuNgay.TabIndex = 5;
            // 
            // dtpDenNgay
            // 
            dtpDenNgay.Location = new Point(315, 176);
            dtpDenNgay.Name = "dtpDenNgay";
            dtpDenNgay.Size = new Size(260, 27);
            dtpDenNgay.TabIndex = 6;
            // 
            // cbTimKiem
            // 
            cbTimKiem.FormattingEnabled = true;
            cbTimKiem.Location = new Point(612, 172);
            cbTimKiem.Name = "cbTimKiem";
            cbTimKiem.Size = new Size(418, 28);
            cbTimKiem.TabIndex = 7;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(1146, 172);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 23;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(1146, 12);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(94, 29);
            btnLamMoi.TabIndex = 24;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(1036, 171);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(94, 29);
            btnTimKiem.TabIndex = 25;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // dgvShow
            // 
            dgvShow.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvShow.Location = new Point(12, 222);
            dgvShow.Name = "dgvShow";
            dgvShow.RowHeadersWidth = 51;
            dgvShow.Size = new Size(1228, 380);
            dgvShow.TabIndex = 26;
            dgvShow.CellClick += dgvShow_CellClick;
            dgvShow.CellContentClick += dgvShow_CellContentClick;
            // 
            // btnThemBacSi
            // 
            btnThemBacSi.Location = new Point(612, 109);
            btnThemBacSi.Name = "btnThemBacSi";
            btnThemBacSi.Size = new Size(154, 29);
            btnThemBacSi.TabIndex = 27;
            btnThemBacSi.Text = "Thêm Bác sĩ";
            btnThemBacSi.UseVisualStyleBackColor = true;
            btnThemBacSi.Click += btnThemBacSi_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1252, 614);
            Controls.Add(btnThemBacSi);
            Controls.Add(dgvShow);
            Controls.Add(btnTimKiem);
            Controls.Add(btnLamMoi);
            Controls.Add(btnDelete);
            Controls.Add(cbTimKiem);
            Controls.Add(dtpDenNgay);
            Controls.Add(dtpTuNgay);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(cbTrangThai);
            Controls.Add(label6);
            Controls.Add(cbBacSi);
            Controls.Add(dudGioKham);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dtpNgayKham);
            Controls.Add(txtSoDienThoai);
            Controls.Add(txtTenBenhNhan);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvShow).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtTenBenhNhan;
        private TextBox txtSoDienThoai;
        private DateTimePicker dtpNgayKham;
        private Label label4;
        private Label label5;
        private DomainUpDown dudGioKham;
        private ComboBox cbBacSi;
        private Label label6;
        private ComboBox cbTrangThai;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Label label7;
        private Label label8;
        private DateTimePicker dtpTuNgay;
        private DateTimePicker dtpDenNgay;
        private ComboBox cbTimKiem;
        private Button btnDelete;
        private Button btnLamMoi;
        private Button btnTimKiem;
        private DataGridView dgvShow;
        private Button btnThemBacSi;
    }
}
