using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnTap3.Data;
using OnTap3.Models;

namespace OnTap3.Repositories
{
    public class GenericRepository<T> where T : class
    {
        OnTap3Net1021Context _context;
        DbSet<T> _dbSet;

        public GenericRepository()
        {
            _context = new OnTap3Net1021Context();
            _dbSet = _context.Set<T>();
        }


        public List<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public void Add(T model)
        {
            _dbSet.Add(model);
            _context.SaveChanges();
        }

        public void Update(T model)
        {
            _dbSet.Update(model);
            _context.SaveChanges();
        }

        public void Remove(T model)
        {
            _dbSet.Remove(model);
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

    }
}
