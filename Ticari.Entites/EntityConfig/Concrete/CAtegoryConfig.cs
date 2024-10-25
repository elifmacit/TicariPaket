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
    public class CategoryConfig :BaseConfig<Category>
    {
        public override void Configure(EntityTypeBuilder<Category> builder)
        {
            base.Configure(builder);
            builder.Property(p=>p.CategoryName).HasMaxLength(100);
            builder.HasIndex(p => p.CategoryName).IsUnique(); 

            builder.Property(p=>p.Description).HasMaxLength(500);

        }
    }
}
