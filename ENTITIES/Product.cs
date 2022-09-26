using CORE.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITIES
{
    public class Product : CoreEntity
    {
        public string? Name { get; set; }
        public decimal? Price { get; set; }
        public short? Stock { get; set; }
        public string? QuantityPerUnit { get; set; }
        public string? ImagePath { get; set; }
        public Guid BasketId { get; set; }//FK
        public Guid UserId { get; set; }//FK
        public virtual Basket Basket { get; set; }
        public virtual User User { get; set; }
    }
}
