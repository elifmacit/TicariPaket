using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticari.Entities.Entities.Concrete;
using Ticari.Entities.EntityConfig.Abstract;

namespace Ticari.Entities.EntityConfig.Concrete
{
    public class ProductConfig : BaseConfig<Product>
    {
        public override void Configure(EntityTypeBuilder<Product> builder)
        {
            base.Configure(builder);
            builder.Property(p=>p.ProductCode).HasMaxLength(100);
            builder.HasIndex(p => p.ProductCode).IsUnique();

            builder.Property(p => p.ProductName).HasMaxLength(100);
            builder.HasIndex(p=>p.ProductName).IsUnique();

            builder.Property(p => p.Description).HasMaxLength(1000);


        }
    }
}
