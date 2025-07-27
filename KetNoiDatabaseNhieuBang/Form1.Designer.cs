namespace KetNoiDatabaseNhieuBang
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
            tabControl1 = new TabControl();
            qls = new TabPage();
            qltg = new TabPage();
            qldg = new TabPage();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(qls);
            tabControl1.Controls.Add(qltg);
            tabControl1.Controls.Add(qldg);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1699, 960);
            tabControl1.TabIndex = 0;
            // 
            // qls
            // 
            qls.Location = new Point(4, 34);
            qls.Name = "qls";
            qls.Padding = new Padding(3);
            qls.Size = new Size(1691, 922);
            qls.TabIndex = 0;
            qls.Text = "Quản lý sách";
            qls.UseVisualStyleBackColor = true;
            // 
            // qltg
            // 
            qltg.Location = new Point(4, 34);
            qltg.Name = "qltg";
            qltg.Padding = new Padding(3);
            qltg.Size = new Size(1691, 922);
            qltg.TabIndex = 1;
            qltg.Text = "Quản lý tác giả";
            qltg.UseVisualStyleBackColor = true;
            // 
            // qldg
            // 
            qldg.Location = new Point(4, 34);
            qldg.Name = "qldg";
            qldg.Size = new Size(1691, 922);
            qldg.TabIndex = 2;
            qldg.Text = "Quản lý đọc giả";
            qldg.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1699, 960);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage qls;
        private TabPage qltg;
        private TabPage qldg;
    }
}
