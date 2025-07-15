using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datagridview_BindingList
{
    public class Gear
    {
        [DisplayName("Mã")]
        public long Ma { get; set; }

        [DisplayName("Tên")]
        public string Ten { get; set; }
        [DisplayName("Giá")]
        public decimal Gia { get; set; }

        [DisplayName("Số lượng")]
        public uint SoLuong { get; set; } = 0;
        [DisplayName("Loại sản phẩm")]
       
        public string? LoaiSanPham { get; set; }
        [DisplayName("Màu sắc")]
        public string? MauSac {get; set; }

    }
}
