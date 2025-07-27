namespace KetNoiDatabaseNhieuBang.Views
{
    partial class QuanLySach
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            label1 = new Label();
            textBoxMaSach = new TextBox();
            textBoxTen = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            numericUpDownNamSX = new NumericUpDown();
            numericUpDownSL = new NumericUpDown();
            label5 = new Label();
            textBoxISBN = new TextBox();
            label6 = new Label();
            comboBoxTG = new ComboBox();
            buttonThem = new Button();
            buttonSua = new Button();
            buttonXoa = new Button();
            buttonLM = new Button();
            textBoxTK = new TextBox();
            label7 = new Label();
            label8 = new Label();
            comboBoxSX = new ComboBox();
            comboBoxCSX = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNamSX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSL).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 636);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1508, 290);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 94);
            label1.Name = "label1";
            label1.Size = new Size(79, 25);
            label1.TabIndex = 1;
            label1.Text = "Mã Sách";
            // 
            // textBoxMaSach
            // 
            textBoxMaSach.Location = new Point(126, 94);
            textBoxMaSach.Name = "textBoxMaSach";
            textBoxMaSach.ReadOnly = true;
            textBoxMaSach.Size = new Size(263, 31);
            textBoxMaSach.TabIndex = 2;
            // 
            // textBoxTen
            // 
            textBoxTen.Location = new Point(662, 94);
            textBoxTen.Name = "textBoxTen";
            textBoxTen.Size = new Size(263, 31);
            textBoxTen.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(577, 94);
            label2.Name = "label2";
            label2.Size = new Size(69, 25);
            label2.TabIndex = 3;
            label2.Text = "Tiêu đề";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1051, 105);
            label3.Name = "label3";
            label3.Size = new Size(65, 25);
            label3.TabIndex = 5;
            label3.Text = "Tác giả";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 257);
            label4.Name = "label4";
            label4.Size = new Size(120, 25);
            label4.TabIndex = 7;
            label4.Text = "Năm sản xuất";
            // 
            // numericUpDownNamSX
            // 
            numericUpDownNamSX.Location = new Point(145, 255);
            numericUpDownNamSX.Name = "numericUpDownNamSX";
            numericUpDownNamSX.Size = new Size(244, 31);
            numericUpDownNamSX.TabIndex = 8;
            // 
            // numericUpDownSL
            // 
            numericUpDownSL.Location = new Point(681, 257);
            numericUpDownSL.Name = "numericUpDownSL";
            numericUpDownSL.Size = new Size(244, 31);
            numericUpDownSL.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(555, 259);
            label5.Name = "label5";
            label5.Size = new Size(85, 25);
            label5.TabIndex = 9;
            label5.Text = "Số lượng";
            // 
            // textBoxISBN
            // 
            textBoxISBN.Location = new Point(1122, 259);
            textBoxISBN.Name = "textBoxISBN";
            textBoxISBN.Size = new Size(263, 31);
            textBoxISBN.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1051, 259);
            label6.Name = "label6";
            label6.Size = new Size(50, 25);
            label6.TabIndex = 11;
            label6.Text = "ISBN";
            // 
            // comboBoxTG
            // 
            comboBoxTG.FormattingEnabled = true;
            comboBoxTG.Location = new Point(1122, 102);
            comboBoxTG.Name = "comboBoxTG";
            comboBoxTG.Size = new Size(263, 33);
            comboBoxTG.TabIndex = 13;
            // 
            // buttonThem
            // 
            buttonThem.Location = new Point(164, 437);
            buttonThem.Name = "buttonThem";
            buttonThem.Size = new Size(112, 34);
            buttonThem.TabIndex = 14;
            buttonThem.Text = "Thêm";
            buttonThem.UseVisualStyleBackColor = true;
            buttonThem.Click += buttonThem_Click;
            // 
            // buttonSua
            // 
            buttonSua.Location = new Point(351, 437);
            buttonSua.Name = "buttonSua";
            buttonSua.Size = new Size(112, 34);
            buttonSua.TabIndex = 15;
            buttonSua.Text = "Cập nhật";
            buttonSua.UseVisualStyleBackColor = true;
            // 
            // buttonXoa
            // 
            buttonXoa.Location = new Point(530, 437);
            buttonXoa.Name = "buttonXoa";
            buttonXoa.Size = new Size(112, 34);
            buttonXoa.TabIndex = 16;
            buttonXoa.Text = "Xóa";
            buttonXoa.UseVisualStyleBackColor = true;
            // 
            // buttonLM
            // 
            buttonLM.Location = new Point(681, 437);
            buttonLM.Name = "buttonLM";
            buttonLM.Size = new Size(112, 34);
            buttonLM.TabIndex = 17;
            buttonLM.Text = "Làm mới";
            buttonLM.UseVisualStyleBackColor = true;
            // 
            // textBoxTK
            // 
            textBoxTK.Location = new Point(988, 357);
            textBoxTK.Name = "textBoxTK";
            textBoxTK.Size = new Size(263, 31);
            textBoxTK.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(898, 360);
            label7.Name = "label7";
            label7.Size = new Size(84, 25);
            label7.TabIndex = 18;
            label7.Text = "Tìm kiếm";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(898, 446);
            label8.Name = "label8";
            label8.Size = new Size(75, 25);
            label8.TabIndex = 20;
            label8.Text = "Sắp xếp";
            // 
            // comboBoxSX
            // 
            comboBoxSX.FormattingEnabled = true;
            comboBoxSX.Location = new Point(988, 439);
            comboBoxSX.Name = "comboBoxSX";
            comboBoxSX.Size = new Size(263, 33);
            comboBoxSX.TabIndex = 21;
            // 
            // comboBoxCSX
            // 
            comboBoxCSX.FormattingEnabled = true;
            comboBoxCSX.Location = new Point(1281, 439);
            comboBoxCSX.Name = "comboBoxCSX";
            comboBoxCSX.Size = new Size(104, 33);
            comboBoxCSX.TabIndex = 22;
            // 
            // QuanLySach
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(comboBoxCSX);
            Controls.Add(comboBoxSX);
            Controls.Add(label8);
            Controls.Add(textBoxTK);
            Controls.Add(label7);
            Controls.Add(buttonLM);
            Controls.Add(buttonXoa);
            Controls.Add(buttonSua);
            Controls.Add(buttonThem);
            Controls.Add(comboBoxTG);
            Controls.Add(textBoxISBN);
            Controls.Add(label6);
            Controls.Add(numericUpDownSL);
            Controls.Add(label5);
            Controls.Add(numericUpDownNamSX);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBoxTen);
            Controls.Add(label2);
            Controls.Add(textBoxMaSach);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "QuanLySach";
            Size = new Size(1508, 926);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNamSX).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSL).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private TextBox textBoxMaSach;
        private TextBox textBoxTen;
        private Label label2;
        private Label label3;
        private Label label4;
        private NumericUpDown numericUpDownNamSX;
        private NumericUpDown numericUpDownSL;
        private Label label5;
        private TextBox textBoxISBN;
        private Label label6;
        private ComboBox comboBoxTG;
        private Button buttonThem;
        private Button buttonSua;
        private Button buttonXoa;
        private Button buttonLM;
        private TextBox textBoxTK;
        private Label label7;
        private Label label8;
        private ComboBox comboBoxSX;
        private ComboBox comboBoxCSX;
    }
}
