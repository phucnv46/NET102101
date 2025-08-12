using OnTap3.Models;
using OnTap3.Repositories;

namespace OnTap3
{
    public partial class Form1 : Form
    {
        GenericRepository<NhanVien> _nhanVienRepository = new();
        GenericRepository<PhongBan> _phongBanRepository = new();
        GenericRepository<VaiTro> _VaiTroRepository = new();
        List<NhanVien> _nhanViens;

        public Form1()
        {
            InitializeComponent();
            LoadControls();
        }


        public void LoadControls()
        {
            _nhanViens = _nhanVienRepository.GetAllWithIncludes("MaPhongBanNavigation",
                "MaVaiTroNavigation");

            dataGridView1.DataSource = _nhanViens;

            comboBoxPB.DataSource = _phongBanRepository.GetAll();
            comboBoxPB.DisplayMember = nameof(PhongBan.TenPhongBan); // SelectedText
            comboBoxPB.ValueMember = nameof(PhongBan.MaPhongBan); // SelectedValue

            comboBoxVT.DataSource = _VaiTroRepository.GetAll();
            comboBoxVT.DisplayMember = nameof(VaiTro.TenVaiTro);
            comboBoxVT.ValueMember = nameof(VaiTro.MaVaiTro);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NhanVien nhanVien = _nhanViens[0];
            textBoxMa.Text = nhanVien.MaNhanVien.ToString();
        }
    }
}
