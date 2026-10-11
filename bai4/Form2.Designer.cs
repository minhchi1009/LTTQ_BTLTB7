namespace bai4
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            label3 = new Label();
            btnLamMoi = new Button();
            dgvTTBacSi = new DataGridView();
            txtChuyenKhoa = new TextBox();
            txtTiemKiem = new TextBox();
            btnTiemKiem = new Button();
            txtTenBacSi = new TextBox();
            btnThem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTTBacSi).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 21);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên Bác sĩ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 73);
            label3.Name = "label3";
            label3.Size = new Size(95, 20);
            label3.TabIndex = 2;
            label3.Text = "Chuyên Khoa";
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(1013, 11);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(94, 29);
            btnLamMoi.TabIndex = 9;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // dgvTTBacSi
            // 
            dgvTTBacSi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTTBacSi.Location = new Point(12, 173);
            dgvTTBacSi.Name = "dgvTTBacSi";
            dgvTTBacSi.RowHeadersWidth = 51;
            dgvTTBacSi.Size = new Size(1095, 265);
            dgvTTBacSi.TabIndex = 10;
            dgvTTBacSi.CellClick += dgvTTBacSi_CellClick;
            // 
            // txtChuyenKhoa
            // 
            txtChuyenKhoa.Location = new Point(113, 70);
            txtChuyenKhoa.Name = "txtChuyenKhoa";
            txtChuyenKhoa.Size = new Size(227, 27);
            txtChuyenKhoa.TabIndex = 11;
            // 
            // txtTiemKiem
            // 
            txtTiemKiem.Location = new Point(12, 134);
            txtTiemKiem.Name = "txtTiemKiem";
            txtTiemKiem.Size = new Size(450, 27);
            txtTiemKiem.TabIndex = 12;
            // 
            // btnTiemKiem
            // 
            btnTiemKiem.Location = new Point(484, 134);
            btnTiemKiem.Name = "btnTiemKiem";
            btnTiemKiem.Size = new Size(94, 29);
            btnTiemKiem.TabIndex = 13;
            btnTiemKiem.Text = "Tìm kiếm";
            btnTiemKiem.UseVisualStyleBackColor = true;
            btnTiemKiem.Click += btnTiemKiem_Click;
            // 
            // txtTenBacSi
            // 
            txtTenBacSi.Location = new Point(113, 13);
            txtTenBacSi.Name = "txtTenBacSi";
            txtTenBacSi.Size = new Size(227, 27);
            txtTenBacSi.TabIndex = 14;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(645, 11);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 15;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(757, 11);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 16;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(890, 11);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 17;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1119, 450);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(txtTenBacSi);
            Controls.Add(btnTiemKiem);
            Controls.Add(txtTiemKiem);
            Controls.Add(txtChuyenKhoa);
            Controls.Add(dgvTTBacSi);
            Controls.Add(btnLamMoi);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTTBacSi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button btnLamMoi;
        private DataGridView dgvTTBacSi;
        private TextBox txtChuyenKhoa;
        private TextBox txtTiemKiem;
        private Button btnTiemKiem;
        private TextBox txtTenBacSi;
        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;
    }
}