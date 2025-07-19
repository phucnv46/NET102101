using System.ComponentModel;

namespace ChuaLab1_4
{
    public partial class Form1 : Form
    {
        BindingList<TraiCay> traiCays = new BindingList<TraiCay>()
        {
            new TraiCay(){Ma = "TC1",Ten="Đào",LoaiTraiCay="Quả mọng",Gia=1000,NhaCungCap="HCC",SoLuong=30},
            new TraiCay(){Ma = "TC2",Ten="Vai",LoaiTraiCay="Quả Nhập",Gia=2000,NhaCungCap="ACX",SoLuong=40},
            new TraiCay(){Ma = "TC3",Ten="Đào",LoaiTraiCay="Quả VIP",Gia=3000,NhaCungCap="TAS",SoLuong=50},
        };
        public Form1()
        {
            InitializeComponent();
            LoadComponent();
        }


        private void LoadComponent()
        {
            dataGridView1.DataSource = traiCays;
            comboBoxLoai.DataSource = new List<string>()
            {
                "Quả mọng","Quả Nhập","Quả VIP"
            };
            comboBoxNCC.DataSource = new List<string>()
            {
                "HCC","ACX","TAS"
            };

        }

        private void BidingToControl(TraiCay traiCay)
        {
            textBoxMa.Text = traiCay.Ma;
            textBoxTen.Text = traiCay.Ten;
            comboBoxLoai.SelectedItem = traiCay.LoaiTraiCay;
            comboBoxNCC.SelectedItem = traiCay.NhaCungCap;
            numericUpDownGia.Value = traiCay.Gia;
            numericUpDownSL.Value = traiCay.SoLuong;
        }
        private void BindingToModel(TraiCay traiCay)
        {
            traiCay.Ma = textBoxMa.Text;
            traiCay.Ten = textBoxTen.Text;
            traiCay.NhaCungCap = comboBoxNCC.SelectedItem.ToString();
            traiCay.LoaiTraiCay = comboBoxLoai.SelectedItem.ToString();
            traiCay.SoLuong = (int)numericUpDownSL.Value;
            traiCay.Gia = numericUpDownGia.Value;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0 && dataGridView1.CurrentRow.DataBoundItem is not null
                && dataGridView1.SelectedRows[0].DataBoundItem is TraiCay traiCay)

            {
                BidingToControl(traiCay);
            }
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            TraiCay traiCay = new TraiCay();
            BindingToModel(traiCay);
            traiCays.Add(traiCay);
        }

        private void buttonCN_Click(object sender, EventArgs e)
        {
            TraiCay? traiCay = dataGridView1.CurrentRow.DataBoundItem as TraiCay;
            BindingToModel(traiCay);
            traiCays[dataGridView1.CurrentRow.Index] = traiCay;
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            TraiCay? traiCay = dataGridView1.CurrentRow.DataBoundItem as TraiCay;
            traiCays.Remove(traiCay);
        }

        private void buttonLM_Click(object sender, EventArgs e)
        {
            textBoxMa.ResetText();
            textBoxTen.ResetText();
            comboBoxLoai.SelectedIndex = 0;
            comboBoxNCC.SelectedIndex = 0;
            numericUpDownGia.Value = 0;
            numericUpDownSL.Value = 0;
        }
    }
}
