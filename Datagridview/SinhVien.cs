using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datagridview
{
    public class SinhVien
    {
        [DisplayName("Mã Sinh viên")]
        public long MaSV { get; set; } // Auto property

        [DisplayName("Họ tên")]
        public string HoTen { get; set; }

        [Browsable(false)]
        public Nganh? Nganh { get; set; }

        [Browsable(false)]
        public string? MaNganh { get; set; }

        [Browsable(false)]
        public Lop? Lop { get; set; }
        [Browsable(false)]
        public string? MaLop { get; set; }

        [DisplayName("Tên lớp")]
        public string? TenLop
        {
            get
            {
                return Lop?.TenLop ?? "Chưa rõ";
            }
        }
        [DisplayName("Tên ngành")]
        public string? TenNganh
        {
            get
            {
                return Nganh?.TenNganh ?? "Chưa rõ";
            }
        }

    }

    public class Nganh
    {
        public string MaNganh { get; set; }
        public string TenNganh { get; set; }


    }

    public class Lop
    {
        public string MaLop { get; set; }
        public string TenLop { get; set; }
    }


}
