using KetNoiDatabase.Models;
using KetNoiDatabase.Repositories;
using System.ComponentModel;

namespace KetNoiDatabase
{
    public partial class Form1 : Form
    {
        NhanVienRepository repository = new NhanVienRepository();
        public Form1()
        {
            InitializeComponent();
            LoadComponent();
        }


        void LoadComponent()
        {

            dataGridView1.DataSource = new BindingList<NhanVien>(repository.GetAll());
            comboBoxCV.DataSource = new List<string>()
            {
            "Nhân viên bán hàng",
            "Kế toán",
            "Quản lý",
            "Trưởng phòng nhân sự",
            "Nhân viên IT",
            };
        }

        private void BindingToControl(NhanVien nhanVien)  //Chuyển object từ trong list lên controls
        {
            textBoxMa.Text = nhanVien.MaNhanVien;
            textBoxTen.Text = nhanVien.TenNhanVien;
            textBoxSDT.Text = nhanVien.Sdt;
            textBoxDC.Text = nhanVien.DiaChi;
            DateOnly ngaySinh = nhanVien.NgaySinh;
            dateTimePickerNgaySinh.Value = new DateTime(ngaySinh.Year, ngaySinh.Month, ngaySinh.Day);
            radioButtonNam.Checked = nhanVien.GioiTinh;
            radioButtonNu.Checked = !nhanVien.GioiTinh;
            comboBoxCV.SelectedItem = nhanVien.ChucVu;
        }

        private void BindingToModel(NhanVien nhanVien)
        {
            nhanVien.MaNhanVien = textBoxMa.Text;
            nhanVien.TenNhanVien = textBoxTen.Text;
            nhanVien.Sdt = textBoxSDT.Text;
            nhanVien.DiaChi = textBoxDC.Text;
            nhanVien.ChucVu = (string)comboBoxCV.SelectedItem;
            nhanVien.NgaySinh = DateOnly.FromDateTime(dateTimePickerNgaySinh.Value);
            nhanVien.GioiTinh = radioButtonNam.Checked;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow.DataBoundItem is NhanVien nhanVien && nhanVien != null)
            {
                BindingToControl(nhanVien);
            }
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            NhanVien nhanVien = new NhanVien();
            BindingToModel(nhanVien);
            repository.Add(nhanVien);
            LoadComponent();
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.DataBoundItem is NhanVien nhanVien && nhanVien != null)
            {
                int index = dataGridView1.CurrentRow.Index;
                BindingToModel(nhanVien);
                repository.Update(nhanVien);
                LoadComponent();
                dataGridView1.Rows[index].Selected = true;
            }
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.DataBoundItem is NhanVien nhanVien && nhanVien != null)
            {
                repository.Delete(nhanVien);
                LoadComponent();
              
            }
        }
    }
}
