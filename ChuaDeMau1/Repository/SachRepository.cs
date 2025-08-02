using ChuaDeMau1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuaDeMau1.Repository
{
    public class SachRepository
    {
      public readonly SachContext _context;
      DbSet<Sach> _sachSet;

        public SachRepository()
        {
            _context = new SachContext();
            _sachSet = _context.Saches;
        }

        public List<Sach> GetSaches()
        {
            return _sachSet.ToList();
        }

        public void Add(Sach sach)
        {
            _sachSet.Add(sach);
            _context.SaveChanges();
        }
    }
}
