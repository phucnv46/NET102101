namespace ChuaDeMau2
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
            textBoxMa = new TextBox();
            textBoxChucVu = new TextBox();
            label3 = new Label();
            textBoxTen = new TextBox();
            label4 = new Label();
            radioButtonNam = new RadioButton();
            radioButtonNu = new RadioButton();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            buttonThem = new Button();
            buttonSua = new Button();
            buttonXoa = new Button();
            buttonThoat = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F);
            label1.Location = new Point(640, 95);
            label1.Name = "label1";
            label1.Size = new Size(223, 36);
            label1.TabIndex = 0;
            label1.Text = "Quản lý nhân viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 225);
            label2.Name = "label2";
            label2.Size = new Size(118, 25);
            label2.TabIndex = 1;
            label2.Text = "Mã nhân viên";
            // 
            // textBoxMa
            // 
            textBoxMa.Location = new Point(192, 219);
            textBoxMa.Name = "textBoxMa";
            textBoxMa.Size = new Size(340, 31);
            textBoxMa.TabIndex = 2;
            // 
            // textBoxChucVu
            // 
            textBoxChucVu.Location = new Point(1051, 216);
            textBoxChucVu.Name = "textBoxChucVu";
            textBoxChucVu.Size = new Size(340, 31);
            textBoxChucVu.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(943, 219);
            label3.Name = "label3";
            label3.Size = new Size(76, 25);
            label3.TabIndex = 3;
            label3.Text = "Chức vụ";
            // 
            // textBoxTen
            // 
            textBoxTen.Location = new Point(192, 367);
            textBoxTen.Name = "textBoxTen";
            textBoxTen.Size = new Size(340, 31);
            textBoxTen.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(84, 370);
            label4.Name = "label4";
            label4.Size = new Size(38, 25);
            label4.TabIndex = 5;
            label4.Text = "Tên";
            // 
            // radioButtonNam
            // 
            radioButtonNam.AutoSize = true;
            radioButtonNam.Location = new Point(1051, 369);
            radioButtonNam.Name = "radioButtonNam";
            radioButtonNam.Size = new Size(75, 29);
            radioButtonNam.TabIndex = 7;
            radioButtonNam.TabStop = true;
            radioButtonNam.Text = "Nam";
            radioButtonNam.UseVisualStyleBackColor = true;
            // 
            // radioButtonNu
            // 
            radioButtonNu.AutoSize = true;
            radioButtonNu.Location = new Point(1250, 369);
            radioButtonNu.Name = "radioButtonNu";
            radioButtonNu.Size = new Size(61, 29);
            radioButtonNu.TabIndex = 8;
            radioButtonNu.TabStop = true;
            radioButtonNu.Text = "Nữ";
            radioButtonNu.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(943, 373);
            label5.Name = "label5";
            label5.Size = new Size(78, 25);
            label5.TabIndex = 9;
            label5.Text = "Giới tính";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(148, 490);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(963, 363);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // buttonThem
            // 
            buttonThem.Location = new Point(1299, 494);
            buttonThem.Name = "buttonThem";
            buttonThem.Size = new Size(145, 59);
            buttonThem.TabIndex = 11;
            buttonThem.Text = "Thêm";
            buttonThem.UseVisualStyleBackColor = true;
            buttonThem.Click += buttonThem_Click;
            // 
            // buttonSua
            // 
            buttonSua.Location = new Point(1299, 636);
            buttonSua.Name = "buttonSua";
            buttonSua.Size = new Size(145, 59);
            buttonSua.TabIndex = 12;
            buttonSua.Text = "Sửa";
            buttonSua.UseVisualStyleBackColor = true;
            buttonSua.Click += buttonSua_Click;
            // 
            // buttonXoa
            // 
            buttonXoa.Location = new Point(1299, 794);
            buttonXoa.Name = "buttonXoa";
            buttonXoa.Size = new Size(145, 59);
            buttonXoa.TabIndex = 13;
            buttonXoa.Text = "Xóa";
            buttonXoa.UseVisualStyleBackColor = true;
            buttonXoa.Click += buttonXoa_Click;
            // 
            // buttonThoat
            // 
            buttonThoat.Location = new Point(1299, 935);
            buttonThoat.Name = "buttonThoat";
            buttonThoat.Size = new Size(145, 59);
            buttonThoat.TabIndex = 14;
            buttonThoat.Text = "Thoát";
            buttonThoat.UseVisualStyleBackColor = true;
            buttonThoat.Click += buttonThoat_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1564, 1095);
            Controls.Add(buttonThoat);
            Controls.Add(buttonXoa);
            Controls.Add(buttonSua);
            Controls.Add(buttonThem);
            Controls.Add(dataGridView1);
            Controls.Add(label5);
            Controls.Add(radioButtonNu);
            Controls.Add(radioButtonNam);
            Controls.Add(textBoxTen);
            Controls.Add(label4);
            Controls.Add(textBoxChucVu);
            Controls.Add(label3);
            Controls.Add(textBoxMa);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxMa;
        private TextBox textBoxChucVu;
        private Label label3;
        private TextBox textBoxTen;
        private Label label4;
        private RadioButton radioButtonNam;
        private RadioButton radioButtonNu;
        private Label label5;
        private DataGridView dataGridView1;
        private Button buttonThem;
        private Button buttonSua;
        private Button buttonXoa;
        private Button buttonThoat;
    }
}
