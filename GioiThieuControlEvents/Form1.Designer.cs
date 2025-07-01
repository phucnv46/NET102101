namespace GioiThieuControlEvents
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
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            numericUpDownKQ = new NumericUpDown();
            label3 = new Label();
            buttonCong = new Button();
            buttonTru = new Button();
            buttonNhan = new Button();
            buttonChia = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownKQ).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(75, 76);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 0;
            label1.Text = "Số thứ nhất";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(75, 199);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 1;
            label2.Text = "Số thứ hai";
            // 
            // numericUpDown1
            // 
            numericUpDown1.DecimalPlaces = 2;
            numericUpDown1.Location = new Point(187, 76);
            numericUpDown1.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(345, 27);
            numericUpDown1.TabIndex = 2;
            // 
            // numericUpDown2
            // 
            numericUpDown2.DecimalPlaces = 2;
            numericUpDown2.Location = new Point(187, 197);
            numericUpDown2.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(345, 27);
            numericUpDown2.TabIndex = 3;
            // 
            // numericUpDownKQ
            // 
            numericUpDownKQ.DecimalPlaces = 2;
            numericUpDownKQ.Location = new Point(187, 326);
            numericUpDownKQ.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            numericUpDownKQ.Name = "numericUpDownKQ";
            numericUpDownKQ.Size = new Size(345, 27);
            numericUpDownKQ.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(75, 328);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 4;
            label3.Text = "Kết quả";
            // 
            // buttonCong
            // 
            buttonCong.Location = new Point(187, 419);
            buttonCong.Name = "buttonCong";
            buttonCong.Size = new Size(94, 29);
            buttonCong.TabIndex = 6;
            buttonCong.Text = "+";
            buttonCong.UseVisualStyleBackColor = true;
            buttonCong.Click += OnButton_Click;
            // 
            // buttonTru
            // 
            buttonTru.Location = new Point(332, 419);
            buttonTru.Name = "buttonTru";
            buttonTru.Size = new Size(94, 29);
            buttonTru.TabIndex = 7;
            buttonTru.Text = "-";
            buttonTru.UseVisualStyleBackColor = true;
            buttonTru.Click += OnButton_Click;
            // 
            // buttonNhan
            // 
            buttonNhan.Location = new Point(463, 419);
            buttonNhan.Name = "buttonNhan";
            buttonNhan.Size = new Size(94, 29);
            buttonNhan.TabIndex = 8;
            buttonNhan.Text = "*";
            buttonNhan.UseVisualStyleBackColor = true;
            buttonNhan.Click += OnButton_Click;
            // 
            // buttonChia
            // 
            buttonChia.Location = new Point(593, 419);
            buttonChia.Name = "buttonChia";
            buttonChia.Size = new Size(94, 29);
            buttonChia.TabIndex = 9;
            buttonChia.Text = "/";
            buttonChia.UseVisualStyleBackColor = true;
            buttonChia.Click += OnButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1014, 570);
            Controls.Add(buttonChia);
            Controls.Add(buttonNhan);
            Controls.Add(buttonTru);
            Controls.Add(buttonCong);
            Controls.Add(numericUpDownKQ);
            Controls.Add(label3);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownKQ).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDownKQ;
        private Label label3;
        private Button buttonCong;
        private Button buttonTru;
        private Button buttonNhan;
        private Button buttonChia;
    }
}
