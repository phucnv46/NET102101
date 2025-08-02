using System;
using System.Collections.Generic;

namespace ChuaDeMau1.Models;

public partial class Sach
{
    public string MaSach { get; set; } = null!;

    public string? TenSach { get; set; }

    public decimal? DonGia { get; set; }

    public int? SoTrang { get; set; }
}
