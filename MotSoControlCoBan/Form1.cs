namespace MotSoControlCoBan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadComponents();
        }


        private void LoadComponents()
        {
            List<object> ngheNghieps = new List<object> {
                new { MaNgheNghiep = 1, TenNgheNghiep ="Phụ hồ" },
                new { MaNgheNghiep = 2, TenNgheNghiep ="Đầu bếp" },
                new { MaNgheNghiep = 3, TenNgheNghiep ="Lái xe" },

            };

            comboBoxNgheNghiep.DataSource = ngheNghieps;
            comboBoxNgheNghiep.DisplayMember = "TenNgheNghiep"; // Quyết định thuộc tính sẽ hiển thị
            comboBoxNgheNghiep.ValueMember = "MaNgheNghiep"; // Quyết định giá trị ẩn (sẽ ảnh hưởng đến selected value)

            comboBoxNgheNghiep.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxNgheNghiep.AutoCompleteSource = AutoCompleteSource.ListItems;

            List<object> sothichs = new List<object> {
                new { MaNgheNghiep = 1, TenNgheNghiep ="code" },
                new { MaNgheNghiep = 2, TenNgheNghiep ="Múa quạt" },
                new { MaNgheNghiep = 3, TenNgheNghiep ="Nhảy dây" },

            };

            comboboxSoThich.DataSource = sothichs;
            comboboxSoThich.DisplayMember = "TenNgheNghiep"; // Quyết định thuộc tính sẽ hiển thị
            comboboxSoThich.ValueMember = "MaNgheNghiep"; // Quyết định giá trị ẩn (sẽ ảnh hưởng đến selected value)

            comboboxSoThich.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboboxSoThich.AutoCompleteSource = AutoCompleteSource.ListItems;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var casi = CS.Controls.OfType<CheckBox>().ToList() // truy cập vào groupbox chứa các checkbox
                .Where(c=>c.Checked) // Cái nào được checked
                .Select(c=>c.Text); // Thì chọn cái đấy
            string tenCasis = string.Join(", ",casi); // Nối các tên ca sĩ với dấu ,
            string gioiTinh = radioButtonNam.Checked ?"Nam" :"Nữ";

            MessageBox.Show($"Nghề nghiệp: {comboBoxNgheNghiep.SelectedText}" +
                $"\nSở thích: {comboboxSoThich.SelectedText}" +
                $"\n Giới tính: {gioiTinh}" +
                $"\n Ca sĩ yêu thích: {tenCasis}");
        }
    }
}
