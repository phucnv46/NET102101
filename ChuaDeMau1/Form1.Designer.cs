namespace ChuaDeMau1
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
            textBoxMaSach = new TextBox();
            label3 = new Label();
            textBoxTenSach = new TextBox();
            label4 = new Label();
            label5 = new Label();
            radioButton100 = new RadioButton();
            radioButton1000 = new RadioButton();
            numericUpDownDonGia = new NumericUpDown();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDonGia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 29F);
            label1.Location = new Point(469, 32);
            label1.Name = "label1";
            label1.Size = new Size(362, 77);
            label1.TabIndex = 0;
            label1.Text = "Quản lý sách";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(76, 174);
            label2.Name = "label2";
            label2.Size = new Size(92, 30);
            label2.TabIndex = 1;
            label2.Text = "Mã sách";
            // 
            // textBoxMaSach
            // 
            textBoxMaSach.Font = new Font("Segoe UI", 11F);
            textBoxMaSach.Location = new Point(183, 171);
            textBoxMaSach.Name = "textBoxMaSach";
            textBoxMaSach.Size = new Size(225, 37);
            textBoxMaSach.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(826, 171);
            label3.Name = "label3";
            label3.Size = new Size(88, 30);
            label3.TabIndex = 3;
            label3.Text = "Đơn giá";
            // 
            // textBoxTenSach
            // 
            textBoxTenSach.Font = new Font("Segoe UI", 11F);
            textBoxTenSach.Location = new Point(183, 279);
            textBoxTenSach.Name = "textBoxTenSach";
            textBoxTenSach.Size = new Size(225, 37);
            textBoxTenSach.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(76, 282);
            label4.Name = "label4";
            label4.Size = new Size(95, 30);
            label4.TabIndex = 5;
            label4.Text = "Tên sách";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.Location = new Point(826, 285);
            label5.Name = "label5";
            label5.Size = new Size(95, 30);
            label5.TabIndex = 7;
            label5.Text = "Số trang";
            // 
            // radioButton100
            // 
            radioButton100.AutoSize = true;
            radioButton100.Font = new Font("Segoe UI", 11F);
            radioButton100.Location = new Point(933, 282);
            radioButton100.Name = "radioButton100";
            radioButton100.Size = new Size(74, 34);
            radioButton100.TabIndex = 8;
            radioButton100.TabStop = true;
            radioButton100.Text = "100";
            radioButton100.UseVisualStyleBackColor = true;
            // 
            // radioButton1000
            // 
            radioButton1000.AutoSize = true;
            radioButton1000.Font = new Font("Segoe UI", 11F);
            radioButton1000.Location = new Point(1060, 285);
            radioButton1000.Name = "radioButton1000";
            radioButton1000.Size = new Size(86, 34);
            radioButton1000.TabIndex = 9;
            radioButton1000.TabStop = true;
            radioButton1000.Text = "1000";
            radioButton1000.UseVisualStyleBackColor = true;
            // 
            // numericUpDownDonGia
            // 
            numericUpDownDonGia.Font = new Font("Segoe UI", 11F);
            numericUpDownDonGia.Location = new Point(933, 165);
            numericUpDownDonGia.Maximum = new decimal(new int[] { -727379968, 232, 0, 0 });
            numericUpDownDonGia.Name = "numericUpDownDonGia";
            numericUpDownDonGia.Size = new Size(268, 37);
            numericUpDownDonGia.TabIndex = 10;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(27, 415);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1046, 309);
            dataGridView1.TabIndex = 11;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // button1
            // 
            button1.Location = new Point(1177, 415);
            button1.Name = "button1";
            button1.Size = new Size(118, 58);
            button1.TabIndex = 12;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1402, 763);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(numericUpDownDonGia);
            Controls.Add(radioButton1000);
            Controls.Add(radioButton100);
            Controls.Add(label5);
            Controls.Add(textBoxTenSach);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBoxMaSach);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownDonGia).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxMaSach;
        private Label label3;
        private TextBox textBoxTenSach;
        private Label label4;
        private Label label5;
        private RadioButton radioButton100;
        private RadioButton radioButton1000;
        private NumericUpDown numericUpDownDonGia;
        private DataGridView dataGridView1;
        private Button button1;
    }
}
