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
    public class BasketMap : CoreMap<Basket>
    {
        public override void Configure(EntityTypeBuilder<Basket> builder)
        {
            builder.ToTable("baskets");
            builder.Property(x => x.ProductName).HasMaxLength(100).IsRequired(false);
            base.Configure(builder);    
        }
    }
}
