using Cakes.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cakes.DAL.Interfaces
{
   public interface ICakes
    {
        IEnumerable<Cake> GetCakes { get; }
        Cake GetCake(int id);
    }
}
