using KetNoiDatabaseNhieuBang.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Dynamic.Core;

namespace KetNoiDatabaseNhieuBang.Repositories
{
    public class GenericRepository<T> where T : class
    {
        Net1021012Context _context;
        DbSet<T> _dbSet;

        public GenericRepository()
        {
            _context = new Net1021012Context();
            _dbSet = _context.Set<T>();
        }

        public List<T> GetAll() // chuyển toàn bộ bảng thành list 
        {
            return _dbSet.ToList();
        }

        public T? Get(params object[] maT)
        {
            return _dbSet.Find(maT); // Tìm object theo khóa chính 
        }


        public void Add(T nv)  // Thêm object vào bảng 
        {

            _dbSet.Add(nv);
            _context.SaveChanges(); // Lưu lại thay đổi đối với database 
        }
        public void Update(T nv)
        {
            _dbSet.Update(nv);
            _context.SaveChanges();
        }
        public void Delete(T nv)
        {
            _dbSet.Remove(nv);
            _context.SaveChanges();
        }

        public List<T> GetAllWithIncludes(params string[] relations)
        {
            var query = _dbSet.AsQueryable();
            foreach (var rel in relations)
            {
                query = query.Include(rel);
            }
            return query.ToList();
        }


        public List<T> TimKiem(string search)
        {
            

            return null;
        }


        public List<T> SapXep(string prop, string direct)
        {
            // Orderby => tang, OrderbyDescending
            return _dbSet.OrderBy($"{prop} {direct}").ToList();
        }
    }
}
