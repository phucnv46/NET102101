namespace MotSoControlCoBan
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
            comboBoxNgheNghiep = new ComboBox();
            groupBox2 = new GroupBox();
            comboboxSoThich = new ComboBox();
            groupBox3 = new GroupBox();
            radioButtonNu = new RadioButton();
            radioButtonNam = new RadioButton();
            CS = new GroupBox();
            checkBoxMono = new CheckBox();
            checkBoxJ97 = new CheckBox();
            checkBoxMTP = new CheckBox();
            button1 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            CS.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBoxNgheNghiep);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(371, 167);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nghề nghiệp";
            // 
            // comboBoxNgheNghiep
            // 
            comboBoxNgheNghiep.FormattingEnabled = true;
            comboBoxNgheNghiep.Location = new Point(18, 59);
            comboBoxNgheNghiep.Name = "comboBoxNgheNghiep";
            comboBoxNgheNghiep.Size = new Size(286, 28);
            comboBoxNgheNghiep.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(comboboxSoThich);
            groupBox2.Location = new Point(389, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(399, 167);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Sở thich";
            // 
            // comboboxSoThich
            // 
            comboboxSoThich.FormattingEnabled = true;
            comboboxSoThich.Location = new Point(59, 59);
            comboboxSoThich.Name = "comboboxSoThich";
            comboboxSoThich.Size = new Size(286, 28);
            comboboxSoThich.TabIndex = 1;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(radioButtonNu);
            groupBox3.Controls.Add(radioButtonNam);
            groupBox3.Location = new Point(12, 194);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(371, 167);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Giới tính";
            // 
            // radioButtonNu
            // 
            radioButtonNu.AutoSize = true;
            radioButtonNu.Location = new Point(222, 69);
            radioButtonNu.Name = "radioButtonNu";
            radioButtonNu.Size = new Size(50, 24);
            radioButtonNu.TabIndex = 1;
            radioButtonNu.TabStop = true;
            radioButtonNu.Text = "Nữ";
            radioButtonNu.UseVisualStyleBackColor = true;
            // 
            // radioButtonNam
            // 
            radioButtonNam.AutoSize = true;
            radioButtonNam.Location = new Point(31, 69);
            radioButtonNam.Name = "radioButtonNam";
            radioButtonNam.Size = new Size(62, 24);
            radioButtonNam.TabIndex = 0;
            radioButtonNam.TabStop = true;
            radioButtonNam.Text = "Nam";
            radioButtonNam.UseVisualStyleBackColor = true;
            // 
            // CS
            // 
            CS.Controls.Add(checkBoxMono);
            CS.Controls.Add(checkBoxJ97);
            CS.Controls.Add(checkBoxMTP);
            CS.Location = new Point(389, 194);
            CS.Name = "CS";
            CS.Size = new Size(371, 167);
            CS.TabIndex = 3;
            CS.TabStop = false;
            CS.Text = "Ca sĩ yêu thích";
            // 
            // checkBoxMono
            // 
            checkBoxMono.AutoSize = true;
            checkBoxMono.Location = new Point(29, 137);
            checkBoxMono.Name = "checkBoxMono";
            checkBoxMono.Size = new Size(70, 24);
            checkBoxMono.TabIndex = 2;
            checkBoxMono.Text = "Mono";
            checkBoxMono.UseVisualStyleBackColor = true;
            // 
            // checkBoxJ97
            // 
            checkBoxJ97.AutoSize = true;
            checkBoxJ97.Location = new Point(31, 92);
            checkBoxJ97.Name = "checkBoxJ97";
            checkBoxJ97.Size = new Size(52, 24);
            checkBoxJ97.TabIndex = 1;
            checkBoxJ97.Text = "J97";
            checkBoxJ97.UseVisualStyleBackColor = true;
            // 
            // checkBoxMTP
            // 
            checkBoxMTP.AutoSize = true;
            checkBoxMTP.Location = new Point(29, 44);
            checkBoxMTP.Name = "checkBoxMTP";
            checkBoxMTP.Size = new Size(60, 24);
            checkBoxMTP.TabIndex = 0;
            checkBoxMTP.Text = "MTP";
            checkBoxMTP.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(73, 390);
            button1.Name = "button1";
            button1.Size = new Size(112, 29);
            button1.TabIndex = 4;
            button1.Text = "Hiển thị";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(CS);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            CS.ResumeLayout(false);
            CS.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox comboBoxNgheNghiep;
        private GroupBox groupBox2;
        private ComboBox comboboxSoThich;
        private GroupBox groupBox3;
        private RadioButton radioButtonNu;
        private RadioButton radioButtonNam;
        private GroupBox CS;
        private CheckBox checkBoxMono;
        private CheckBox checkBoxJ97;
        private CheckBox checkBoxMTP;
        private Button button1;
    }
}
