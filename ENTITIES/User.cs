using CORE.Entity;
using CORE.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITIES
{
    public class User : CoreEntity
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string? MailAddress { get; set; }
        public string? UserImagePath { get; set; }
        public Role? Role { get; set; }
        public DateTime? Birthdate { get; set; }
        public virtual List<Product>? Products { get; set; }
    }
}
