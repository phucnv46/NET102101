using ChuaDeMau1.Models;
using ChuaDeMau1.Repository;

namespace ChuaDeMau1
{
    public partial class Form1 : Form
    {

        SachRepository _repository;
        public Form1()
        {
            InitializeComponent();
            _repository = new();
            LoadTable();
        }

        private void LoadTable()
        {
            dataGridView1.DataSource = _repository.GetSaches();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Sach sachCuoi = _repository.GetSaches().Last();
            BindingToControl(sachCuoi);
        }

        private void BindingToControl(Sach sach)
        {
            textBoxMaSach.Text = sach.MaSach;
            textBoxTenSach.Text = sach.TenSach;
            numericUpDownDonGia.Value = (decimal)sach.DonGia;
            radioButton100.Checked = sach.SoTrang == 100;
            radioButton1000.Checked = sach.SoTrang == 1000;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow.DataBoundItem is Sach sach)
            {
                BindingToControl(sach);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sach sach = new Sach();
            sach.MaSach = textBoxMaSach.Text;
            sach.TenSach = textBoxTenSach.Text;
            sach.DonGia = numericUpDownDonGia.Value;
            sach.SoTrang = radioButton100.Checked ? 100 : 1000;

            if(_repository.GetSaches().Any(s=>s.MaSach == sach.MaSach))
            {
                MessageBox.Show("Mã sách bị trùng");
                return;
            }
            try
            {

                _repository.Add(sach);
                LoadTable();
                MessageBox.Show("Thêm thành công!");
            }
            catch (Exception ex)
            {

                 MessageBox.Show(ex.Message);
            }
        }
    }

}
