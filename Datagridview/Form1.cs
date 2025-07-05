using System.ComponentModel;
using System.Data;

namespace Datagridview
{
    public partial class Form1 : Form
    {
        static List<Lop> lops = new List<Lop>()
            {
                new Lop(){MaLop="SD20308",TenLop="SD20308"},
                new Lop(){MaLop="SD20309",TenLop="SD20308"},
                new Lop(){MaLop="NET1021.01",TenLop="NET1021.01"},
                new Lop(){MaLop="NET1021.02",TenLop="NET1021.02"},

            };

        static List<Nganh> nganhs = new List<Nganh>()
            {
                new Nganh(){MaNganh = "NET",TenNganh="C#"},
                new Nganh(){MaNganh = "Java",TenNganh="Java"},
            };

        static BindingList<SinhVien> sinhViens = new BindingList<SinhVien>() { // BindingList List chuyên dụng dành cho datagrid view
            new SinhVien(){MaSV = 1, HoTen="Nguyễn Văn Phúc",Nganh=nganhs[0],Lop=lops[0],
                MaNganh = nganhs[0].MaNganh, MaLop=lops[0].MaLop},
            new SinhVien(){MaSV = 2, HoTen="Nguyễn Thị Linh",Nganh=nganhs[1],Lop=lops[2],
                MaNganh = nganhs[1].MaNganh, MaLop=lops[2].MaLop},
            new SinhVien(){MaSV = 3, HoTen="Đào Văn Nam",Nganh=nganhs[1],Lop=lops[3],
                MaNganh = nganhs[1].MaNganh, MaLop=lops[3].MaLop},
            };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buttonSua.Enabled = false;
            textBoxMa.Text = (sinhViens.Last().MaSV + 1).ToString();

            dataGridView1.DataSource = sinhViens;
            comboBoxLop.DataSource = lops;
            comboBoxLop.DisplayMember = nameof(Lop.TenLop);
            comboBoxLop.ValueMember = nameof(Lop.MaLop);

            comboBoxNganh.DataSource = nganhs;
            comboBoxNganh.DisplayMember = nameof(Nganh.TenNganh);
            comboBoxNganh.ValueMember = nameof(Nganh.TenNganh);

        }


        private void BindingToControls(SinhVien sinhVien) // CHuyển dữ liệu từ model sang controls (textbox, combobox)
        {
            textBoxMa.Text = sinhVien.MaSV.ToString();
            textBoxTen.Text = sinhVien.HoTen;
            comboBoxLop.SelectedItem = sinhVien.Lop;
            comboBoxNganh.SelectedItem = sinhVien.Nganh;
        }



        private void BindingToModel(SinhVien sinhVien) // Chuyển dữ liệu từ control vào model
        {
            sinhVien.MaSV = long.Parse(textBoxMa.Text);
            sinhVien.HoTen = textBoxTen.Text;
            sinhVien.Lop = (Lop)comboBoxLop.SelectedItem;
            sinhVien.Nganh = (Nganh)comboBoxNganh.SelectedItem;
        }



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            buttonSua.Enabled = true;
            SinhVien sinhVien = dataGridView1.CurrentRow.DataBoundItem as SinhVien; // CHuyển dữ liệu từ dòng thành object
            if (sinhVien != null)
            {
                BindingToControls(sinhVien);
            }
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            SinhVien sinhVien = new SinhVien();
            BindingToModel(sinhVien);
            sinhViens.Add(sinhVien);

        }

        private void buttonLamMoi_Click(object sender, EventArgs e)
        {
            textBoxMa.Text = (sinhViens.Last().MaSV + 1).ToString();
            textBoxTen.ResetText();
            comboBoxLop.SelectedIndex = 0;
            comboBoxNganh.SelectedIndex = 0;
            buttonSua.Enabled = false;
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            SinhVien sinhVien = dataGridView1.CurrentRow.DataBoundItem as SinhVien;
            BindingToModel(sinhVien);
            sinhViens[dataGridView1.CurrentRow.Index] = sinhVien;
        }
    }
}
