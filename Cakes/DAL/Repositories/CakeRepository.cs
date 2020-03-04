using Cakes.DAL.EFContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cakes.DAL.Interfaces;
using Cakes.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace Cakes.DAL.Repositories
{
    public class CakeRepository : ICakes
    {
        private readonly EFDbContext _context;

        public CakeRepository(EFDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Cake> GetCakes => _context.Cakes.Include(x => x.Category);
        public Cake GetCake(int id) => _context.Cakes.FirstOrDefault(c => c.Id == id);
    }
}
