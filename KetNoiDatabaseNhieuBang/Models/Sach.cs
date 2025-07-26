using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace KetNoiDatabaseNhieuBang.Models;

public partial class Sach
{
    [DisplayName("Mã sách")]
    public int MaSach { get; set; }

    [DisplayName("Tên sách")]

    public string TieuDe { get; set; } = null!;

    [Browsable(false)]

    public int? MaTacGia { get; set; }
    [DisplayName("Năm xuất bản")]

    public int? NamXuatBan { get; set; }
    [DisplayName("ISBN")]

    public string? Isbn { get; set; }
    [DisplayName("Số lượng")]

    public int? SoLuongTonKho { get; set; }

    [Browsable(false)]
    public virtual TacGium? MaTacGiaNavigation { get; set; }

    [NotMapped]
    public string TenTacGia
    {
        get
        {
            return MaTacGiaNavigation?.HoTen ?? "Chưa rõ";
        }

            
    }
}
