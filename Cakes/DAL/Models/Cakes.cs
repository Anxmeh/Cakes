using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cakes.DAL.Models
{
    public class Cake
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public int Price { get; set; }
        public double Weight { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
