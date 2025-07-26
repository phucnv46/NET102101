namespace KetNoiDatabase
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            textBoxMa = new TextBox();
            textBoxTen = new TextBox();
            label2 = new Label();
            label3 = new Label();
            dateTimePickerNgaySinh = new DateTimePicker();
            textBoxSDT = new TextBox();
            label4 = new Label();
            textBoxDC = new TextBox();
            label5 = new Label();
            label6 = new Label();
            comboBoxCV = new ComboBox();
            radioButtonNam = new RadioButton();
            radioButtonNu = new RadioButton();
            label7 = new Label();
            buttonThem = new Button();
            buttonSua = new Button();
            buttonLM = new Button();
            buttonXoa = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 469);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1579, 319);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 57);
            label1.Name = "label1";
            label1.Size = new Size(118, 25);
            label1.TabIndex = 1;
            label1.Text = "Mã nhân viên";
            // 
            // textBoxMa
            // 
            textBoxMa.Location = new Point(152, 54);
            textBoxMa.Name = "textBoxMa";
            textBoxMa.Size = new Size(303, 31);
            textBoxMa.TabIndex = 2;
            // 
            // textBoxTen
            // 
            textBoxTen.Location = new Point(714, 54);
            textBoxTen.Name = "textBoxTen";
            textBoxTen.Size = new Size(303, 31);
            textBoxTen.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(622, 54);
            label2.Name = "label2";
            label2.Size = new Size(38, 25);
            label2.TabIndex = 3;
            label2.Text = "Tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1129, 54);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 5;
            label3.Text = "Ngày sinh";
            // 
            // dateTimePickerNgaySinh
            // 
            dateTimePickerNgaySinh.Location = new Point(1238, 54);
            dateTimePickerNgaySinh.Name = "dateTimePickerNgaySinh";
            dateTimePickerNgaySinh.Size = new Size(304, 31);
            dateTimePickerNgaySinh.TabIndex = 6;
            // 
            // textBoxSDT
            // 
            textBoxSDT.Location = new Point(152, 151);
            textBoxSDT.Name = "textBoxSDT";
            textBoxSDT.Size = new Size(303, 31);
            textBoxSDT.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(60, 151);
            label4.Name = "label4";
            label4.Size = new Size(43, 25);
            label4.TabIndex = 7;
            label4.Text = "SDT";
            // 
            // textBoxDC
            // 
            textBoxDC.Location = new Point(714, 145);
            textBoxDC.Name = "textBoxDC";
            textBoxDC.Size = new Size(312, 31);
            textBoxDC.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(613, 151);
            label5.Name = "label5";
            label5.Size = new Size(65, 25);
            label5.TabIndex = 9;
            label5.Text = "Địa chỉ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1138, 151);
            label6.Name = "label6";
            label6.Size = new Size(76, 25);
            label6.TabIndex = 11;
            label6.Text = "Chức vụ";
            // 
            // comboBoxCV
            // 
            comboBoxCV.FormattingEnabled = true;
            comboBoxCV.Location = new Point(1240, 153);
            comboBoxCV.Name = "comboBoxCV";
            comboBoxCV.Size = new Size(302, 33);
            comboBoxCV.TabIndex = 12;
            // 
            // radioButtonNam
            // 
            radioButtonNam.AutoSize = true;
            radioButtonNam.Checked = true;
            radioButtonNam.Location = new Point(174, 266);
            radioButtonNam.Name = "radioButtonNam";
            radioButtonNam.Size = new Size(75, 29);
            radioButtonNam.TabIndex = 13;
            radioButtonNam.TabStop = true;
            radioButtonNam.Text = "Nam";
            radioButtonNam.UseVisualStyleBackColor = true;
            // 
            // radioButtonNu
            // 
            radioButtonNu.AutoSize = true;
            radioButtonNu.Location = new Point(331, 266);
            radioButtonNu.Name = "radioButtonNu";
            radioButtonNu.Size = new Size(61, 29);
            radioButtonNu.TabIndex = 14;
            radioButtonNu.Text = "Nữ";
            radioButtonNu.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(60, 270);
            label7.Name = "label7";
            label7.Size = new Size(78, 25);
            label7.TabIndex = 15;
            label7.Text = "Giới tính";
            // 
            // buttonThem
            // 
            buttonThem.Location = new Point(167, 393);
            buttonThem.Name = "buttonThem";
            buttonThem.Size = new Size(112, 34);
            buttonThem.TabIndex = 16;
            buttonThem.Text = "Thêm";
            buttonThem.UseVisualStyleBackColor = true;
            buttonThem.Click += buttonThem_Click;
            // 
            // buttonSua
            // 
            buttonSua.Location = new Point(334, 393);
            buttonSua.Name = "buttonSua";
            buttonSua.Size = new Size(112, 34);
            buttonSua.TabIndex = 17;
            buttonSua.Text = "Sửa";
            buttonSua.UseVisualStyleBackColor = true;
            buttonSua.Click += buttonSua_Click;
            // 
            // buttonLM
            // 
            buttonLM.Location = new Point(705, 393);
            buttonLM.Name = "buttonLM";
            buttonLM.Size = new Size(112, 34);
            buttonLM.TabIndex = 19;
            buttonLM.Text = "Làm mới";
            buttonLM.UseVisualStyleBackColor = true;
            // 
            // buttonXoa
            // 
            buttonXoa.Location = new Point(538, 393);
            buttonXoa.Name = "buttonXoa";
            buttonXoa.Size = new Size(112, 34);
            buttonXoa.TabIndex = 18;
            buttonXoa.Text = "Xóa";
            buttonXoa.UseVisualStyleBackColor = true;
            buttonXoa.Click += buttonXoa_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1579, 788);
            Controls.Add(buttonLM);
            Controls.Add(buttonXoa);
            Controls.Add(buttonSua);
            Controls.Add(buttonThem);
            Controls.Add(label7);
            Controls.Add(radioButtonNu);
            Controls.Add(radioButtonNam);
            Controls.Add(comboBoxCV);
            Controls.Add(label6);
            Controls.Add(textBoxDC);
            Controls.Add(label5);
            Controls.Add(textBoxSDT);
            Controls.Add(label4);
            Controls.Add(dateTimePickerNgaySinh);
            Controls.Add(label3);
            Controls.Add(textBoxTen);
            Controls.Add(label2);
            Controls.Add(textBoxMa);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private TextBox textBoxMa;
        private TextBox textBoxTen;
        private Label label2;
        private Label label3;
        private DateTimePicker dateTimePickerNgaySinh;
        private TextBox textBoxSDT;
        private Label label4;
        private TextBox textBoxDC;
        private Label label5;
        private Label label6;
        private ComboBox comboBoxCV;
        private RadioButton radioButtonNam;
        private RadioButton radioButtonNu;
        private Label label7;
        private Button buttonThem;
        private Button buttonSua;
        private Button buttonLM;
        private Button buttonXoa;
    }
}
