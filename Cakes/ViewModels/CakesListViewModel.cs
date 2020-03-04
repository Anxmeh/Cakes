using Cakes.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cakes.ViewModels
{
    public class CakesListViewModel
    {
        public IEnumerable<Cake> GetCakes { get; set; }
        public string CakeCategory { get; set; }
    }
}
