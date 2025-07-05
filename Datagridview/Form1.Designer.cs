namespace Datagridview
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
            comboBoxNganh = new ComboBox();
            comboBoxLop = new ComboBox();
            label4 = new Label();
            buttonThem = new Button();
            buttonSua = new Button();
            buttonLamMoi = new Button();
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
            dataGridView1.Location = new Point(0, 335);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1198, 265);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 55);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 1;
            label1.Text = "Mã SV";
            // 
            // textBoxMa
            // 
            textBoxMa.Location = new Point(149, 55);
            textBoxMa.Name = "textBoxMa";
            textBoxMa.ReadOnly = true;
            textBoxMa.Size = new Size(261, 27);
            textBoxMa.TabIndex = 2;
            // 
            // textBoxTen
            // 
            textBoxTen.Location = new Point(774, 55);
            textBoxTen.Name = "textBoxTen";
            textBoxTen.Size = new Size(261, 27);
            textBoxTen.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(691, 55);
            label2.Name = "label2";
            label2.Size = new Size(32, 20);
            label2.TabIndex = 3;
            label2.Text = "Tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(66, 164);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 5;
            label3.Text = "Ngành";
            // 
            // comboBoxNganh
            // 
            comboBoxNganh.FormattingEnabled = true;
            comboBoxNganh.Location = new Point(149, 160);
            comboBoxNganh.Name = "comboBoxNganh";
            comboBoxNganh.Size = new Size(261, 28);
            comboBoxNganh.TabIndex = 6;
            // 
            // comboBoxLop
            // 
            comboBoxLop.FormattingEnabled = true;
            comboBoxLop.Location = new Point(774, 156);
            comboBoxLop.Name = "comboBoxLop";
            comboBoxLop.Size = new Size(261, 28);
            comboBoxLop.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(691, 160);
            label4.Name = "label4";
            label4.Size = new Size(34, 20);
            label4.TabIndex = 7;
            label4.Text = "Lớp";
            // 
            // buttonThem
            // 
            buttonThem.Location = new Point(149, 254);
            buttonThem.Name = "buttonThem";
            buttonThem.Size = new Size(100, 41);
            buttonThem.TabIndex = 9;
            buttonThem.Text = "Thêm";
            buttonThem.UseVisualStyleBackColor = true;
            buttonThem.Click += buttonThem_Click;
            // 
            // buttonSua
            // 
            buttonSua.Location = new Point(310, 254);
            buttonSua.Name = "buttonSua";
            buttonSua.Size = new Size(100, 41);
            buttonSua.TabIndex = 10;
            buttonSua.Text = "Sửa";
            buttonSua.UseVisualStyleBackColor = true;
            buttonSua.Click += buttonSua_Click;
            // 
            // buttonLamMoi
            // 
            buttonLamMoi.Location = new Point(638, 254);
            buttonLamMoi.Name = "buttonLamMoi";
            buttonLamMoi.Size = new Size(100, 41);
            buttonLamMoi.TabIndex = 12;
            buttonLamMoi.Text = "Làm mới";
            buttonLamMoi.UseVisualStyleBackColor = true;
            buttonLamMoi.Click += buttonLamMoi_Click;
            // 
            // buttonXoa
            // 
            buttonXoa.Location = new Point(477, 254);
            buttonXoa.Name = "buttonXoa";
            buttonXoa.Size = new Size(100, 41);
            buttonXoa.TabIndex = 11;
            buttonXoa.Text = "Xoá";
            buttonXoa.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1198, 600);
            Controls.Add(buttonLamMoi);
            Controls.Add(buttonXoa);
            Controls.Add(buttonSua);
            Controls.Add(buttonThem);
            Controls.Add(comboBoxLop);
            Controls.Add(label4);
            Controls.Add(comboBoxNganh);
            Controls.Add(label3);
            Controls.Add(textBoxTen);
            Controls.Add(label2);
            Controls.Add(textBoxMa);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
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
        private ComboBox comboBoxNganh;
        private ComboBox comboBoxLop;
        private Label label4;
        private Button buttonThem;
        private Button buttonSua;
        private Button buttonLamMoi;
        private Button buttonXoa;
    }
}
