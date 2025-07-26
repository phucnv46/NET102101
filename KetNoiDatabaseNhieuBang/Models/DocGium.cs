using System;
using System.Collections.Generic;

namespace KetNoiDatabaseNhieuBang.Models;

public partial class DocGium
{
    public int MaDocGia { get; set; }

    public string? HoTen { get; set; }

    public string? Email { get; set; }

    public string? SoDienThoai { get; set; }

    public DateOnly? NgayDangKy { get; set; }
}
