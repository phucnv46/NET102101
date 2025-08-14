using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ChuaDeMau1.Models;

public partial class Sach
{
    [DisplayName("Mã sách")]
    public string MaSach { get; set; } = null!;

    [DisplayName("Tên sách")]

    public string? TenSach { get; set; }

    [DisplayName("Đơn giá")]

    public decimal? DonGia { get; set; }

    [DisplayName("Số trang")]

    public int? SoTrang { get; set; }
}
