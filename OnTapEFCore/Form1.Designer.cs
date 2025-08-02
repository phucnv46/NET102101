namespace OnTapEFCore
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
            textBoxID = new TextBox();
            textBoxTilte = new TextBox();
            label2 = new Label();
            label3 = new Label();
            comboBoxGenre = new ComboBox();
            label4 = new Label();
            numericUpDownYear = new NumericUpDown();
            textBoxDev = new TextBox();
            label5 = new Label();
            buttonThem = new Button();
            buttonSua = new Button();
            buttonRF = new Button();
            buttonXoa = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownYear).BeginInit();
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
            dataGridView1.Size = new Size(1650, 318);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(86, 70);
            label1.Name = "label1";
            label1.Size = new Size(28, 25);
            label1.TabIndex = 1;
            label1.Text = "Id";
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(169, 70);
            textBoxID.Name = "textBoxID";
            textBoxID.ReadOnly = true;
            textBoxID.Size = new Size(313, 31);
            textBoxID.TabIndex = 2;
            // 
            // textBoxTilte
            // 
            textBoxTilte.Location = new Point(755, 70);
            textBoxTilte.Name = "textBoxTilte";
            textBoxTilte.Size = new Size(313, 31);
            textBoxTilte.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(672, 70);
            label2.Name = "label2";
            label2.Size = new Size(44, 25);
            label2.TabIndex = 3;
            label2.Text = "Title";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1247, 70);
            label3.Name = "label3";
            label3.Size = new Size(58, 25);
            label3.TabIndex = 5;
            label3.Text = "Genre";
            // 
            // comboBoxGenre
            // 
            comboBoxGenre.FormattingEnabled = true;
            comboBoxGenre.Location = new Point(1340, 70);
            comboBoxGenre.Name = "comboBoxGenre";
            comboBoxGenre.Size = new Size(298, 33);
            comboBoxGenre.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 246);
            label4.Name = "label4";
            label4.Size = new Size(98, 25);
            label4.TabIndex = 7;
            label4.Text = "Relase Year";
            // 
            // numericUpDownYear
            // 
            numericUpDownYear.Location = new Point(169, 240);
            numericUpDownYear.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numericUpDownYear.Name = "numericUpDownYear";
            numericUpDownYear.Size = new Size(313, 31);
            numericUpDownYear.TabIndex = 8;
            // 
            // textBoxDev
            // 
            textBoxDev.Location = new Point(755, 242);
            textBoxDev.Name = "textBoxDev";
            textBoxDev.Size = new Size(313, 31);
            textBoxDev.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(639, 246);
            label5.Name = "label5";
            label5.Size = new Size(93, 25);
            label5.TabIndex = 9;
            label5.Text = "Developer";
            // 
            // buttonThem
            // 
            buttonThem.Location = new Point(268, 427);
            buttonThem.Name = "buttonThem";
            buttonThem.Size = new Size(112, 34);
            buttonThem.TabIndex = 11;
            buttonThem.Text = "Thêm";
            buttonThem.UseVisualStyleBackColor = true;
            buttonThem.Click += buttonThem_Click;
            // 
            // buttonSua
            // 
            buttonSua.Location = new Point(545, 427);
            buttonSua.Name = "buttonSua";
            buttonSua.Size = new Size(112, 34);
            buttonSua.TabIndex = 12;
            buttonSua.Text = "Sửa";
            buttonSua.UseVisualStyleBackColor = true;
            buttonSua.Click += buttonSua_Click;
            // 
            // buttonRF
            // 
            buttonRF.Location = new Point(1041, 427);
            buttonRF.Name = "buttonRF";
            buttonRF.Size = new Size(112, 34);
            buttonRF.TabIndex = 14;
            buttonRF.Text = "Làm mới";
            buttonRF.UseVisualStyleBackColor = true;
            buttonRF.Click += buttonRF_Click;
            // 
            // buttonXoa
            // 
            buttonXoa.Location = new Point(766, 427);
            buttonXoa.Name = "buttonXoa";
            buttonXoa.Size = new Size(112, 34);
            buttonXoa.TabIndex = 13;
            buttonXoa.Text = "Xóa";
            buttonXoa.UseVisualStyleBackColor = true;
            buttonXoa.Click += buttonXoa_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1650, 954);
            Controls.Add(buttonRF);
            Controls.Add(buttonXoa);
            Controls.Add(buttonSua);
            Controls.Add(buttonThem);
            Controls.Add(textBoxDev);
            Controls.Add(label5);
            Controls.Add(numericUpDownYear);
            Controls.Add(label4);
            Controls.Add(comboBoxGenre);
            Controls.Add(label3);
            Controls.Add(textBoxTilte);
            Controls.Add(label2);
            Controls.Add(textBoxID);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownYear).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private TextBox textBoxID;
        private TextBox textBoxTilte;
        private Label label2;
        private Label label3;
        private ComboBox comboBoxGenre;
        private Label label4;
        private NumericUpDown numericUpDownYear;
        private TextBox textBoxDev;
        private Label label5;
        private Button buttonThem;
        private Button buttonSua;
        private Button buttonRF;
        private Button buttonXoa;
    }
}
