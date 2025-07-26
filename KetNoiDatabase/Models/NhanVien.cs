using System;
using System.Collections.Generic;

namespace KetNoiDatabase.Models;

public partial class NhanVien
{
    public string MaNhanVien { get; set; } = null!;

    public string TenNhanVien { get; set; } = null!;

    public DateOnly NgaySinh { get; set; }

    public string? Sdt { get; set; }

    public string? DiaChi { get; set; }

    public bool GioiTinh { get; set; }

    public string? ChucVu { get; set; }
}
