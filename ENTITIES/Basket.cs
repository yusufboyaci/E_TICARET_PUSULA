using CORE.Entity;
using CORE.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITIES
{
    public class Basket : CoreEntity
    {
        public string? ProductName { get; set; }
        public decimal? Price { get; set; }
        public decimal? TotalPrice { get; set; }
        public virtual List<Product> Products { get; set; }
    }
}
