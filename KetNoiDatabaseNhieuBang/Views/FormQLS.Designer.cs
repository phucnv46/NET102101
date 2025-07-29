namespace KetNoiDatabaseNhieuBang.Views
{
    partial class FormQLS
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
            comboBoxCSX = new ComboBox();
            comboBoxSX = new ComboBox();
            label8 = new Label();
            textBoxTM = new TextBox();
            label7 = new Label();
            buttonLM = new Button();
            buttonXoa = new Button();
            buttonSua = new Button();
            buttonThem = new Button();
            comboBoxTG = new ComboBox();
            textBoxISBN = new TextBox();
            label6 = new Label();
            numericUpDownSL = new NumericUpDown();
            label5 = new Label();
            numericUpDownNamSX = new NumericUpDown();
            label4 = new Label();
            label3 = new Label();
            textBoxTen = new TextBox();
            label2 = new Label();
            textBoxMaSach = new TextBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSL).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNamSX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // comboBoxCSX
            // 
            comboBoxCSX.FormattingEnabled = true;
            comboBoxCSX.Location = new Point(1281, 392);
            comboBoxCSX.Name = "comboBoxCSX";
            comboBoxCSX.Size = new Size(104, 33);
            comboBoxCSX.TabIndex = 44;
            comboBoxCSX.SelectedIndexChanged += comboBoxCSX_SelectedIndexChanged;
            // 
            // comboBoxSX
            // 
            comboBoxSX.FormattingEnabled = true;
            comboBoxSX.Location = new Point(988, 392);
            comboBoxSX.Name = "comboBoxSX";
            comboBoxSX.Size = new Size(263, 33);
            comboBoxSX.TabIndex = 43;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(898, 399);
            label8.Name = "label8";
            label8.Size = new Size(75, 25);
            label8.TabIndex = 42;
            label8.Text = "Sắp xếp";
            // 
            // textBoxTM
            // 
            textBoxTM.Location = new Point(988, 310);
            textBoxTM.Name = "textBoxTM";
            textBoxTM.Size = new Size(263, 31);
            textBoxTM.TabIndex = 41;
            textBoxTM.KeyPress += textBoxTM_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(898, 313);
            label7.Name = "label7";
            label7.Size = new Size(84, 25);
            label7.TabIndex = 40;
            label7.Text = "Tìm kiếm";
            // 
            // buttonLM
            // 
            buttonLM.Location = new Point(681, 390);
            buttonLM.Name = "buttonLM";
            buttonLM.Size = new Size(112, 34);
            buttonLM.TabIndex = 39;
            buttonLM.Text = "Làm mới";
            buttonLM.UseVisualStyleBackColor = true;
            buttonLM.Click += buttonLM_Click;
            // 
            // buttonXoa
            // 
            buttonXoa.Location = new Point(530, 390);
            buttonXoa.Name = "buttonXoa";
            buttonXoa.Size = new Size(112, 34);
            buttonXoa.TabIndex = 38;
            buttonXoa.Text = "Xóa";
            buttonXoa.UseVisualStyleBackColor = true;
            buttonXoa.Click += buttonXoa_Click;
            // 
            // buttonSua
            // 
            buttonSua.Location = new Point(351, 390);
            buttonSua.Name = "buttonSua";
            buttonSua.Size = new Size(112, 34);
            buttonSua.TabIndex = 37;
            buttonSua.Text = "Cập nhật";
            buttonSua.UseVisualStyleBackColor = true;
            buttonSua.Click += buttonSua_Click;
            // 
            // buttonThem
            // 
            buttonThem.Location = new Point(164, 390);
            buttonThem.Name = "buttonThem";
            buttonThem.Size = new Size(112, 34);
            buttonThem.TabIndex = 36;
            buttonThem.Text = "Thêm";
            buttonThem.UseVisualStyleBackColor = true;
            buttonThem.Click += buttonThem_Click;
            // 
            // comboBoxTG
            // 
            comboBoxTG.FormattingEnabled = true;
            comboBoxTG.Location = new Point(1122, 55);
            comboBoxTG.Name = "comboBoxTG";
            comboBoxTG.Size = new Size(263, 33);
            comboBoxTG.TabIndex = 35;
            // 
            // textBoxISBN
            // 
            textBoxISBN.Location = new Point(1122, 212);
            textBoxISBN.Name = "textBoxISBN";
            textBoxISBN.Size = new Size(263, 31);
            textBoxISBN.TabIndex = 34;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1051, 212);
            label6.Name = "label6";
            label6.Size = new Size(50, 25);
            label6.TabIndex = 33;
            label6.Text = "ISBN";
            // 
            // numericUpDownSL
            // 
            numericUpDownSL.Location = new Point(681, 210);
            numericUpDownSL.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numericUpDownSL.Name = "numericUpDownSL";
            numericUpDownSL.Size = new Size(244, 31);
            numericUpDownSL.TabIndex = 32;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(555, 212);
            label5.Name = "label5";
            label5.Size = new Size(85, 25);
            label5.TabIndex = 31;
            label5.Text = "Số lượng";
            // 
            // numericUpDownNamSX
            // 
            numericUpDownNamSX.Location = new Point(145, 208);
            numericUpDownNamSX.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDownNamSX.Name = "numericUpDownNamSX";
            numericUpDownNamSX.Size = new Size(244, 31);
            numericUpDownNamSX.TabIndex = 30;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 210);
            label4.Name = "label4";
            label4.Size = new Size(120, 25);
            label4.TabIndex = 29;
            label4.Text = "Năm sản xuất";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1051, 58);
            label3.Name = "label3";
            label3.Size = new Size(65, 25);
            label3.TabIndex = 28;
            label3.Text = "Tác giả";
            // 
            // textBoxTen
            // 
            textBoxTen.Location = new Point(662, 47);
            textBoxTen.Name = "textBoxTen";
            textBoxTen.Size = new Size(263, 31);
            textBoxTen.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(577, 47);
            label2.Name = "label2";
            label2.Size = new Size(69, 25);
            label2.TabIndex = 26;
            label2.Text = "Tiêu đề";
            // 
            // textBoxMaSach
            // 
            textBoxMaSach.Location = new Point(126, 47);
            textBoxMaSach.Name = "textBoxMaSach";
            textBoxMaSach.ReadOnly = true;
            textBoxMaSach.Size = new Size(263, 31);
            textBoxMaSach.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 47);
            label1.Name = "label1";
            label1.Size = new Size(79, 25);
            label1.TabIndex = 24;
            label1.Text = "Mã Sách";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 531);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1427, 290);
            dataGridView1.TabIndex = 23;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // FormQLS
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1427, 821);
            Controls.Add(comboBoxCSX);
            Controls.Add(comboBoxSX);
            Controls.Add(label8);
            Controls.Add(textBoxTM);
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
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormQLS";
            Text = "FormQLS";
            ((System.ComponentModel.ISupportInitialize)numericUpDownSL).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNamSX).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxCSX;
        private ComboBox comboBoxSX;
        private Label label8;
        private TextBox textBoxTM;
        private Label label7;
        private Button buttonLM;
        private Button buttonXoa;
        private Button buttonSua;
        private Button buttonThem;
        private ComboBox comboBoxTG;
        private TextBox textBoxISBN;
        private Label label6;
        private NumericUpDown numericUpDownSL;
        private Label label5;
        private NumericUpDown numericUpDownNamSX;
        private Label label4;
        private Label label3;
        private TextBox textBoxTen;
        private Label label2;
        private TextBox textBoxMaSach;
        private Label label1;
        private DataGridView dataGridView1;
    }
}