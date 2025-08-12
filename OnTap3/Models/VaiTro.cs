using System;
using System.Collections.Generic;

namespace OnTap3.Models;

public partial class VaiTro
{
    public int MaVaiTro { get; set; }

    public string? TenVaiTro { get; set; }

    public virtual ICollection<NhanVien> NhanViens { get; set; } = new List<NhanVien>();
}
