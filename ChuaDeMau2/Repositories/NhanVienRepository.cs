using ChuaDeMau2.Data;
using ChuaDeMau2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuaDeMau2.Repositories
{
    public class NhanVienRepository
    {
        Net1021DeMau2Context _context; // thể hiện của database trong code 
        DbSet<NhanVien> _dbSet; // thể hiện của bảng của database trong code

        public NhanVienRepository() // alt+enter chọn generate constructor
        {
            _context = new();
            _dbSet = _context.NhanViens; // Lấy ra bảng nhân viên
        }

        public List<NhanVien> LayDanhSach()
        {
            return _dbSet.ToList(); // Chuyển bảng thành list
        }

        public void Them(NhanVien nhanVien)
        {
            _dbSet.Add(nhanVien); // Thêm object vào bảng
            _context.SaveChanges(); // lưu lại thay đổi 
        }

        public void Sua(NhanVien nhanVien)
        {
            _dbSet.Update(nhanVien); // Sửa object vào bảng
            _context.SaveChanges(); // lưu lại thay đổi 
        }


        public void Xoa(NhanVien nhanVien)
        {
            _dbSet.Remove(nhanVien); // Xóa object vào bảng
            _context.SaveChanges(); // lưu lại thay đổi 
        }

    }
}
