using DATAACCESS.Context;
using ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATAACCESS.Repositories.Concrete
{
    public class UserRepository : Repository<User>
    {
        private readonly AppDbContext _context;
        public UserRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }
        public bool CheckCredential(string userName, string password)
        {
            return Any(x => x.UserName == userName && x.Password == password);
        }
    }
}
