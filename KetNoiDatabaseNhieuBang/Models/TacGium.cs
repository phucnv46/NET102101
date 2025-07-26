using System;
using System.Collections.Generic;

namespace KetNoiDatabaseNhieuBang.Models;

public partial class TacGium
{
    public int MaTacGia { get; set; }

    public string HoTen { get; set; } = null!;

    public string? QuocTich { get; set; }

    public virtual ICollection<Sach> Saches { get; set; } = new List<Sach>();
}
