using CORE.Mapping;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITIES.Mapping
{
    public class UserMap: CoreMap<User>
    {
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("users");
            builder.Property(x => x.Name).HasMaxLength(100).IsRequired(false);
            builder.Property(x => x.Surname).HasMaxLength(100).IsRequired(false);
            builder.Property(x => x.UserName).HasMaxLength(100).IsRequired(false);
            builder.Property(x => x.MailAddress).HasMaxLength(500).IsRequired(false);
            base.Configure(builder);
        }
    }
}
