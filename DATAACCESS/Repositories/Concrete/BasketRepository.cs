using DATAACCESS.Context;
using ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATAACCESS.Repositories.Concrete
{
    public class BasketRepository : Repository<Basket>
    {
        private readonly AppDbContext _context;
        public BasketRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
