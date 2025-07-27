using KetNoiDatabaseNhieuBang.Views;

namespace KetNoiDatabaseNhieuBang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           LoadPages();
        }

        void LoadPages()
        {
            FormQLS formQLS = new FormQLS();
            formQLS.Dock = DockStyle.Fill;
            formQLS.TopLevel = false;
            formQLS.Show();
            tabControl1.TabPages["QLS"].Controls.Add(formQLS);
        }
      
    }
}
