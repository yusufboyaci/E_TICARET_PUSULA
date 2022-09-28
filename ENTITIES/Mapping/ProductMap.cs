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
    public class ProductMap : CoreMap<Product>
    {
        public override void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("products");
            builder.Property(x => x.Name).HasMaxLength(100).IsRequired(false);
            base.Configure(builder);    
        }
    }
}
