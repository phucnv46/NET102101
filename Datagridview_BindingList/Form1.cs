using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

namespace Datagridview_BindingList
{
    public partial class Form1 : Form
    {
        BindingList<Gear> gears = new BindingList<Gear>()
        {
            new Gear(){ Ma =1, Ten="Chuột Fuhen g1", Gia=400_000L,LoaiSanPham="Chuột",MauSac="Hồng",SoLuong=30},
            new Gear(){ Ma =2, Ten="Blue Switch ", Gia=1_000_000L,LoaiSanPham="Bàn phím",MauSac="Xanh",SoLuong=100},
            new Gear(){ Ma =3, Ten="Red cherries", Gia=700_000L,LoaiSanPham="Bàn phím",MauSac="Đỏ",SoLuong=40},
        };
        public Form1()
        {
            InitializeComponent();
            LoadControls();
        }

        private void LoadControls()
        {
            dataGridView1.DataSource = gears;
            comboBoxLoaiSanPham.DataSource = new string[] { "Chuột", "Bàn phím", "Tai nghe", "Mic", "Pad" };
            comboBoxMauSac.DataSource = new List<object>
            {
               new {Mau = "Hồng",Name = "Pink"},
               new {Mau = "Đỏ",Name = "Red"},
               new {Mau = "Xanh",Name = "Blue"},
               new {Mau = "Đen",Name = "Black"},
               new {Mau = "Nâu",Name = "Brown"},
            };
            comboBoxMauSac.DisplayMember = "Mau";
            comboBoxMauSac.ValueMember = "Name";
            GenarateMaMoi();
            if (comboBoxMauSac.SelectedItem != null)
            {
                labelMau.ForeColor = Color.FromName(((dynamic)comboBoxMauSac.SelectedItem).Name);
            }
        }


        private void GenarateMaMoi()
        {
            string MaMoi = !gears.Any() ? "1" : (gears.Last().Ma + 1).ToString();
            textBoxMa.Text = MaMoi;
        }


        private void BindingToControls(Gear gear)
        {
            textBoxMa.Text = gear.Ma.ToString();
            textBoxTen.Text = gear.Ten;
            numericUpDownGia.Value = gear.Gia;
            numericUpDownSoLuong.Value = (decimal)gear.SoLuong;
            comboBoxLoaiSanPham.SelectedItem = gear.LoaiSanPham;
            comboBoxMauSac.ResetText();
            comboBoxMauSac.SelectedText = gear.MauSac;
        }


        private void BindingToModel(Gear gear)
        {
            gear.Ma = long.Parse(textBoxMa.Text.Trim());
            gear.Ten = textBoxTen.Text.Trim();
            gear.Gia = numericUpDownGia.Value;
            gear.SoLuong = (uint)numericUpDownSoLuong.Value;
            gear.LoaiSanPham = (string)comboBoxLoaiSanPham.SelectedItem ?? "";
            if (comboBoxMauSac.SelectedItem != null)
            {
                gear.MauSac = ((dynamic)comboBoxMauSac.SelectedItem).Mau;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Gear? gear = dataGridView1.CurrentRow.DataBoundItem as Gear;
            if (gear != null)
            {

                BindingToControls(gear);
                if (comboBoxMauSac.SelectedItem != null)
                {
                    labelMau.ForeColor = Color.FromName(((dynamic)comboBoxMauSac.SelectedItem).Name);
                }
            }

        }



        private void buttonThem_Click(object sender, EventArgs e)
        {


            Gear gear = new();
            BindingToModel(gear);
            gears.Add(gear);

            GenarateMaMoi();
        }

        private void comboBoxMauSac_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxMauSac.SelectedItem != null)
            {
                labelMau.ForeColor = Color.FromName(((dynamic)comboBoxMauSac.SelectedItem).Name);
            }
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            Gear? gear = dataGridView1.CurrentRow.DataBoundItem as Gear;
            BindingToModel((Gear)gear);
            gears[dataGridView1.CurrentRow.Index] = gear;
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            Gear? gear = dataGridView1.CurrentRow.DataBoundItem as Gear;
            gears.Remove(gear);
        }
    }
}
