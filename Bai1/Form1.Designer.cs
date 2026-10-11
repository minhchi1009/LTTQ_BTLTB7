namespace QuanLyNhaSach
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
            txtMaTL = new TextBox();
            txtTenTL = new TextBox();
            txtTimKiem = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnTimKiem = new Button();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            txtMoTa = new TextBox();
            dgvTheLoai = new DataGridView();
            lblNgayTao = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTheLoai).BeginInit();
            SuspendLayout();
            // 
            // txtMaTL
            // 
            txtMaTL.Location = new Point(145, 12);
            txtMaTL.Name = "txtMaTL";
            txtMaTL.ReadOnly = true;
            txtMaTL.Size = new Size(161, 27);
            txtMaTL.TabIndex = 0;
            // 
            // txtTenTL
            // 
            txtTenTL.Location = new Point(145, 60);
            txtTenTL.Name = "txtTenTL";
            txtTenTL.Size = new Size(161, 27);
            txtTenTL.TabIndex = 1;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(33, 273);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(273, 27);
            txtTimKiem.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 14);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 4;
            label1.Text = "Mã Thể Loại";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 63);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 4;
            label2.Text = "Tên Thể Loại";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 107);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 4;
            label3.Text = "Mô tả";
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(326, 273);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(94, 29);
            btnTimKiem.TabIndex = 6;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(326, 14);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 6;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(438, 14);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 6;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(550, 14);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 6;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(661, 14);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(94, 29);
            btnLamMoi.TabIndex = 6;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // txtMoTa
            // 
            txtMoTa.Location = new Point(145, 107);
            txtMoTa.Multiline = true;
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(161, 121);
            txtMoTa.TabIndex = 7;
            // 
            // dgvTheLoai
            // 
            dgvTheLoai.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTheLoai.Dock = DockStyle.Bottom;
            dgvTheLoai.Location = new Point(0, 335);
            dgvTheLoai.MultiSelect = false;
            dgvTheLoai.Name = "dgvTheLoai";
            dgvTheLoai.RowHeadersWidth = 51;
            dgvTheLoai.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTheLoai.Size = new Size(758, 211);
            dgvTheLoai.TabIndex = 8;
            dgvTheLoai.SelectionChanged += dgvTheLoai_SelectionChanged;
            // 
            // lblNgayTao
            // 
            lblNgayTao.AutoSize = true;
            lblNgayTao.Location = new Point(478, 273);
            lblNgayTao.Name = "lblNgayTao";
            lblNgayTao.Size = new Size(83, 20);
            lblNgayTao.TabIndex = 9;
            lblNgayTao.Text = "Ngày tạo: -";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(758, 546);
            Controls.Add(lblNgayTao);
            Controls.Add(dgvTheLoai);
            Controls.Add(txtMoTa);
            Controls.Add(btnLamMoi);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(btnTimKiem);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTimKiem);
            Controls.Add(txtTenTL);
            Controls.Add(txtMaTL);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTheLoai).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMaTL;
        private TextBox txtTenTL;
        private TextBox txtTimKiem;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnTimKiem;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLamMoi;
        private TextBox txtMoTa;
        private DataGridView dgvTheLoai;
        private Label lblNgayTao;
    }
}
