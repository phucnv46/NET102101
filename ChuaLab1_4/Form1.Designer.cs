namespace ChuaLab1_4
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
            buttonLM = new Button();
            buttonXoa = new Button();
            buttonCN = new Button();
            buttonThem = new Button();
            numericUpDownSL = new NumericUpDown();
            label6 = new Label();
            numericUpDownGia = new NumericUpDown();
            label5 = new Label();
            comboBoxNCC = new ComboBox();
            label4 = new Label();
            comboBoxLoai = new ComboBox();
            label3 = new Label();
            textBoxTen = new TextBox();
            label2 = new Label();
            textBoxMa = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSL).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownGia).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonLM);
            groupBox1.Controls.Add(buttonXoa);
            groupBox1.Controls.Add(buttonCN);
            groupBox1.Controls.Add(buttonThem);
            groupBox1.Controls.Add(numericUpDownSL);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(numericUpDownGia);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(comboBoxNCC);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(comboBoxLoai);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBoxTen);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBoxMa);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1635, 597);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin";
            // 
            // buttonLM
            // 
            buttonLM.Location = new Point(1050, 465);
            buttonLM.Name = "buttonLM";
            buttonLM.Size = new Size(112, 34);
            buttonLM.TabIndex = 15;
            buttonLM.Text = "Làm mới";
            buttonLM.UseVisualStyleBackColor = true;
            buttonLM.Click += buttonLM_Click;
            // 
            // buttonXoa
            // 
            buttonXoa.Location = new Point(793, 465);
            buttonXoa.Name = "buttonXoa";
            buttonXoa.Size = new Size(112, 34);
            buttonXoa.TabIndex = 14;
            buttonXoa.Text = "Xóa";
            buttonXoa.UseVisualStyleBackColor = true;
            buttonXoa.Click += buttonXoa_Click;
            // 
            // buttonCN
            // 
            buttonCN.Location = new Point(565, 465);
            buttonCN.Name = "buttonCN";
            buttonCN.Size = new Size(112, 34);
            buttonCN.TabIndex = 13;
            buttonCN.Text = "Cập nhật";
            buttonCN.UseVisualStyleBackColor = true;
            buttonCN.Click += buttonCN_Click;
            // 
            // buttonThem
            // 
            buttonThem.Location = new Point(317, 465);
            buttonThem.Name = "buttonThem";
            buttonThem.Size = new Size(112, 34);
            buttonThem.TabIndex = 12;
            buttonThem.Text = "Thêm";
            buttonThem.UseVisualStyleBackColor = true;
            buttonThem.Click += buttonThem_Click;
            // 
            // numericUpDownSL
            // 
            numericUpDownSL.Location = new Point(1254, 265);
            numericUpDownSL.Maximum = new decimal(new int[] { 1316134912, 2328, 0, 0 });
            numericUpDownSL.Name = "numericUpDownSL";
            numericUpDownSL.Size = new Size(319, 31);
            numericUpDownSL.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1147, 265);
            label6.Name = "label6";
            label6.Size = new Size(85, 25);
            label6.TabIndex = 10;
            label6.Text = "Số lượng";
            // 
            // numericUpDownGia
            // 
            numericUpDownGia.Location = new Point(737, 259);
            numericUpDownGia.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numericUpDownGia.Name = "numericUpDownGia";
            numericUpDownGia.Size = new Size(319, 31);
            numericUpDownGia.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(652, 265);
            label5.Name = "label5";
            label5.Size = new Size(37, 25);
            label5.TabIndex = 8;
            label5.Text = "Giá";
            // 
            // comboBoxNCC
            // 
            comboBoxNCC.FormattingEnabled = true;
            comboBoxNCC.Location = new Point(147, 257);
            comboBoxNCC.Name = "comboBoxNCC";
            comboBoxNCC.Size = new Size(328, 33);
            comboBoxNCC.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 262);
            label4.Name = "label4";
            label4.Size = new Size(121, 25);
            label4.TabIndex = 6;
            label4.Text = "Nhà cung cấp";
            // 
            // comboBoxLoai
            // 
            comboBoxLoai.FormattingEnabled = true;
            comboBoxLoai.Location = new Point(1268, 102);
            comboBoxLoai.Name = "comboBoxLoai";
            comboBoxLoai.Size = new Size(288, 33);
            comboBoxLoai.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1169, 105);
            label3.Name = "label3";
            label3.Size = new Size(44, 25);
            label3.TabIndex = 4;
            label3.Text = "Loại";
            // 
            // textBoxTen
            // 
            textBoxTen.Location = new Point(728, 99);
            textBoxTen.Name = "textBoxTen";
            textBoxTen.Size = new Size(328, 31);
            textBoxTen.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(652, 102);
            label2.Name = "label2";
            label2.Size = new Size(38, 25);
            label2.TabIndex = 2;
            label2.Text = "Tên";
            // 
            // textBoxMa
            // 
            textBoxMa.Location = new Point(147, 102);
            textBoxMa.Name = "textBoxMa";
            textBoxMa.Size = new Size(328, 31);
            textBoxMa.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 102);
            label1.Name = "label1";
            label1.Size = new Size(37, 25);
            label1.TabIndex = 0;
            label1.Text = "Mã";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 597);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1635, 390);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 27);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1629, 360);
            dataGridView1.TabIndex = 0;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1635, 987);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSL).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownGia).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private Button buttonLM;
        private Button buttonXoa;
        private Button buttonCN;
        private Button buttonThem;
        private NumericUpDown numericUpDownSL;
        private Label label6;
        private NumericUpDown numericUpDownGia;
        private Label label5;
        private ComboBox comboBoxNCC;
        private Label label4;
        private ComboBox comboBoxLoai;
        private Label label3;
        private TextBox textBoxTen;
        private Label label2;
        private TextBox textBoxMa;
    }
}
