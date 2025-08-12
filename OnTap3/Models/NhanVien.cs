using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnTap3.Models;

public partial class NhanVien
{
    [DisplayName("Mã nhân viên")]
    public int MaNhanVien { get; set; }

    [DisplayName("Họ tên")]

    public string? HoTen { get; set; }

    [DisplayName("Giới tính")]

    public string? GioiTinh { get; set; }

    [DisplayName("Ngày sinh")]

    public DateOnly? NgaySinh { get; set; }

    [DisplayName("Số CCCD")]

    public string? SoCmndCccd { get; set; }

    [DisplayName("Ngày vào làm")]

    public DateOnly? NgayVaoLam { get; set; }

    [Browsable(false)]
    public int? MaVaiTro { get; set; }

    [Browsable(false)]

    public int? MaPhongBan { get; set; }


    public double? HeSoLuong { get; set; }
    [Browsable(false)]

    public virtual PhongBan? MaPhongBanNavigation { get; set; }
    [Browsable(false)]

    public virtual VaiTro? MaVaiTroNavigation { get; set; }

    [DisplayName("Tên phòng ban")]

    public string TenPhongBan
    {
        get
        {
            return MaPhongBanNavigation?.TenPhongBan ?? "Chưa rõ";
        }

    }

    [DisplayName("Vai trò")]
    public string TenVaiTro
    {
        get
        {
            return MaVaiTroNavigation?.TenVaiTro ?? "Chưa rõ";
        }

    }
}
