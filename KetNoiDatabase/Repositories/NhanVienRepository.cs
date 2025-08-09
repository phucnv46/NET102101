using KetNoiDatabase.Data;
using KetNoiDatabase.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KetNoiDatabase.Repositories
{
    public class NhanVienRepository
    {
        //Khởi tạo context 
        Net102101Context _context;
        DbSet<NhanVien> _dbSet;

        public NhanVienRepository()
        {
            _context = new Net102101Context();
            _dbSet = _context.Set<NhanVien>();
        }

        public List<NhanVien> GetAll() // chuyển toàn bộ bảng thành list 
        {
            return _dbSet.ToList();
        }

        public NhanVien? Get(string maNhanVien)
        {
            return _dbSet.Find(maNhanVien); // Tìm object theo khóa chính 
        }


        public void Add(NhanVien nv)  // Thêm object vào bảng 
        {
            
             _dbSet.Add(nv); // Thêm vào bảng
             _context.SaveChanges(); // Lưu lại thay đổi đối với database 
        }
        public void Update(NhanVien nv)
        {
             _dbSet.Update(nv);
             _context.SaveChanges();
        }
        public void Delete(NhanVien nv)
        {
             _dbSet.Remove(nv);
             _context.SaveChanges();
        }

    }
}
