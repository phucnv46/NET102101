using ChuaDeMau2.Models;
using ChuaDeMau2.Repositories;

namespace ChuaDeMau2
{
    public partial class Form1 : Form
    {
        NhanVienRepository _repository = new NhanVienRepository();
        public Form1()
        {
            InitializeComponent();
            LoadControls(); //gọi
            LoadPhanTuCuoiCung();

        }


        private void LoadControls()
        {
            dataGridView1.DataSource = _repository.LayDanhSach();
        }

        private void LoadPhanTuCuoiCung()
        {
            NhanVien ptc = _repository.LayDanhSach().Last();
            textBoxTen.Text = ptc.TenNhanVien;
            textBoxMa.Text = ptc.MaNhanVien;
            textBoxChucVu.Text = ptc.ChucVu;
            radioButtonNam.Checked = ptc.GioiTinh == "Nam";
            radioButtonNu.Checked = !(ptc.GioiTinh == "Nam");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow.DataBoundItem is NhanVien ptc)
            {
                textBoxTen.Text = ptc.TenNhanVien;
                textBoxMa.Text = ptc.MaNhanVien;
                textBoxChucVu.Text = ptc.ChucVu;
                radioButtonNam.Checked = ptc.GioiTinh == "Nam";
                radioButtonNu.Checked = !(ptc.GioiTinh == "Nam");

            }
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            // Khởi tạo object mới 
            NhanVien nhanVien = new NhanVien()
            {
                MaNhanVien = textBoxMa.Text,
                TenNhanVien = textBoxTen.Text,
                ChucVu = textBoxChucVu.Text,
                GioiTinh = radioButtonNam.Checked ? "Nam" : "Nữ",

            };

            if (KiemTraTrong())
            {
                _repository.Them(nhanVien);
                LoadControls();

            }

        }


        private bool KiemTraTrong()
        {
            if (string.IsNullOrEmpty(textBoxTen.Text.Trim())
                || string.IsNullOrEmpty(textBoxMa.Text.Trim())
                || string.IsNullOrEmpty(textBoxChucVu.Text.Trim())
                )
            {
                MessageBox.Show("Có trường đang trống");
                return false;
            }

            return true;
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            //Tìm đối tượng cẩn sửa
            if (dataGridView1.CurrentRow.DataBoundItem is NhanVien nhanVien)
            {
                nhanVien.MaNhanVien = textBoxMa.Text;
                nhanVien.TenNhanVien = textBoxTen.Text;
                nhanVien.ChucVu = textBoxChucVu.Text;
                nhanVien.GioiTinh = radioButtonNam.Checked ? "Nam" : "Nữ";

                if (KiemTraTrong())
                {
                    _repository.Sua(nhanVien);
                    LoadControls();

                }
            }
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.DataBoundItem is NhanVien nhanVien)
            {
                _repository.Xoa(nhanVien);
                LoadControls();
            }
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
