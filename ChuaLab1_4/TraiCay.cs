using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuaLab1_4
{
    internal class TraiCay
    {
        [DisplayName("Mã")]
        public string Ma { get; set; }
        [DisplayName("Tên")]
        public string Ten { get; set; }
        [DisplayName("Loại")]
        public string LoaiTraiCay { get; set; }
        [DisplayName("NCC")]
        public string NhaCungCap { get; set; }
        [DisplayName("Giá")]

        public decimal Gia { get; set; }
        [DisplayName("Số lượng")]

        public int SoLuong { get; set; }
    }
}
