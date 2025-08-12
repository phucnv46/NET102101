using System;
using System.Collections.Generic;

namespace OnTap3.Models;

public partial class PhongBan
{
    public int MaPhongBan { get; set; }

    public string? TenPhongBan { get; set; }

    public string? TruongPhong { get; set; }

    public virtual ICollection<NhanVien> NhanViens { get; set; } = new List<NhanVien>();
}
