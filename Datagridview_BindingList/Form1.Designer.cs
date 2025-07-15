namespace Datagridview_BindingList
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
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox2 = new GroupBox();
            buttonLamMoi = new Button();
            buttonSua = new Button();
            buttonXoa = new Button();
            buttonThem = new Button();
            comboBoxMauSac = new ComboBox();
            labelMau = new Label();
            comboBoxLoaiSanPham = new ComboBox();
            label5 = new Label();
            numericUpDownSoLuong = new NumericUpDown();
            label4 = new Label();
            numericUpDownGia = new NumericUpDown();
            label3 = new Label();
            textBoxTen = new TextBox();
            label2 = new Label();
            textBoxMa = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSoLuong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownGia).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(0, 545);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1559, 394);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 27);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1553, 364);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(buttonLamMoi);
            groupBox2.Controls.Add(buttonSua);
            groupBox2.Controls.Add(buttonXoa);
            groupBox2.Controls.Add(buttonThem);
            groupBox2.Controls.Add(comboBoxMauSac);
            groupBox2.Controls.Add(labelMau);
            groupBox2.Controls.Add(comboBoxLoaiSanPham);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(numericUpDownSoLuong);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(numericUpDownGia);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(textBoxTen);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(textBoxMa);
            groupBox2.Controls.Add(label1);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1559, 550);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin";
            // 
            // buttonLamMoi
            // 
            buttonLamMoi.Location = new Point(1027, 449);
            buttonLamMoi.Name = "buttonLamMoi";
            buttonLamMoi.Size = new Size(135, 48);
            buttonLamMoi.TabIndex = 14;
            buttonLamMoi.Text = "Làm mới";
            buttonLamMoi.UseVisualStyleBackColor = true;
            // 
            // buttonSua
            // 
            buttonSua.Location = new Point(615, 449);
            buttonSua.Name = "buttonSua";
            buttonSua.Size = new Size(135, 48);
            buttonSua.TabIndex = 13;
            buttonSua.Text = "Sửa";
            buttonSua.UseVisualStyleBackColor = true;
            buttonSua.Click += buttonSua_Click;
            // 
            // buttonXoa
            // 
            buttonXoa.Location = new Point(809, 449);
            buttonXoa.Name = "buttonXoa";
            buttonXoa.Size = new Size(135, 48);
            buttonXoa.TabIndex = 13;
            buttonXoa.Text = "Xóa";
            buttonXoa.UseVisualStyleBackColor = true;
            buttonXoa.Click += buttonXoa_Click;
            // 
            // buttonThem
            // 
            buttonThem.Location = new Point(393, 449);
            buttonThem.Name = "buttonThem";
            buttonThem.Size = new Size(135, 48);
            buttonThem.TabIndex = 12;
            buttonThem.Text = "Thêm";
            buttonThem.UseVisualStyleBackColor = true;
            buttonThem.Click += buttonThem_Click;
            // 
            // comboBoxMauSac
            // 
            comboBoxMauSac.FormattingEnabled = true;
            comboBoxMauSac.Location = new Point(1047, 344);
            comboBoxMauSac.Name = "comboBoxMauSac";
            comboBoxMauSac.Size = new Size(392, 33);
            comboBoxMauSac.TabIndex = 11;
            comboBoxMauSac.SelectedIndexChanged += comboBoxMauSac_SelectedIndexChanged;
            // 
            // labelMau
            // 
            labelMau.AutoSize = true;
            labelMau.Font = new Font("Segoe UI", 11F);
            labelMau.Location = new Point(934, 347);
            labelMau.Name = "labelMau";
            labelMau.Size = new Size(92, 30);
            labelMau.TabIndex = 10;
            labelMau.Text = "Màu sắc";
            // 
            // comboBoxLoaiSanPham
            // 
            comboBoxLoaiSanPham.FormattingEnabled = true;
            comboBoxLoaiSanPham.Location = new Point(211, 335);
            comboBoxLoaiSanPham.Name = "comboBoxLoaiSanPham";
            comboBoxLoaiSanPham.Size = new Size(392, 33);
            comboBoxLoaiSanPham.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.Location = new Point(29, 335);
            label5.Name = "label5";
            label5.Size = new Size(151, 30);
            label5.TabIndex = 8;
            label5.Text = "Loại sản phẩm";
            // 
            // numericUpDownSoLuong
            // 
            numericUpDownSoLuong.Font = new Font("Segoe UI", 11F);
            numericUpDownSoLuong.Location = new Point(1047, 204);
            numericUpDownSoLuong.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            numericUpDownSoLuong.Name = "numericUpDownSoLuong";
            numericUpDownSoLuong.Size = new Size(399, 37);
            numericUpDownSoLuong.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(926, 204);
            label4.Name = "label4";
            label4.Size = new Size(100, 30);
            label4.TabIndex = 6;
            label4.Text = "Số lượng";
            // 
            // numericUpDownGia
            // 
            numericUpDownGia.DecimalPlaces = 2;
            numericUpDownGia.Font = new Font("Segoe UI", 11F);
            numericUpDownGia.Location = new Point(204, 212);
            numericUpDownGia.Maximum = new decimal(new int[] { 276447231, 23283, 0, 0 });
            numericUpDownGia.Name = "numericUpDownGia";
            numericUpDownGia.Size = new Size(399, 37);
            numericUpDownGia.TabIndex = 5;
            numericUpDownGia.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(136, 211);
            label3.Name = "label3";
            label3.Size = new Size(44, 30);
            label3.TabIndex = 4;
            label3.Text = "Giá";
            // 
            // textBoxTen
            // 
            textBoxTen.Font = new Font("Segoe UI", 11F);
            textBoxTen.Location = new Point(1047, 71);
            textBoxTen.Name = "textBoxTen";
            textBoxTen.Size = new Size(399, 37);
            textBoxTen.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(880, 74);
            label2.Name = "label2";
            label2.Size = new Size(146, 30);
            label2.TabIndex = 2;
            label2.Text = "Tên sản phẩm";
            // 
            // textBoxMa
            // 
            textBoxMa.Font = new Font("Segoe UI", 11F);
            textBoxMa.Location = new Point(204, 75);
            textBoxMa.Name = "textBoxMa";
            textBoxMa.ReadOnly = true;
            textBoxMa.Size = new Size(399, 37);
            textBoxMa.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(37, 78);
            label1.Name = "label1";
            label1.Size = new Size(143, 30);
            label1.TabIndex = 0;
            label1.Text = "Mã sản phẩm";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1559, 934);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSoLuong).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownGia).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private Label label1;
        private ComboBox comboBoxMauSac;
        private Label labelMau;
        private ComboBox comboBoxLoaiSanPham;
        private Label label5;
        private NumericUpDown numericUpDownSoLuong;
        private Label label4;
        private NumericUpDown numericUpDownGia;
        private Label label3;
        private TextBox textBoxTen;
        private Label label2;
        private TextBox textBoxMa;
        private Button buttonLamMoi;
        private Button buttonSua;
        private Button buttonXoa;
        private Button buttonThem;
    }
}
