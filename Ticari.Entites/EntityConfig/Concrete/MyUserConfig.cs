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
    public class MyUserConfig:BaseConfig<MyUser>
    {
        public override void Configure(EntityTypeBuilder<MyUser> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.TcNo)
                .HasMaxLength(11);
            builder.HasIndex(p => p.TcNo).IsUnique();


            builder.Property(p => p.Ad).HasMaxLength(50);
            builder.Property(p => p.Soyad).HasMaxLength(50);
            builder.Property(p => p.Gsm).HasMaxLength(50);
            builder.Property(p => p.Email).HasMaxLength(50);
            builder.Property(p => p.Password).HasMaxLength(500);


            builder.HasIndex(p=>p.Email).IsUnique();
            builder.HasIndex(p => p.Gsm).IsUnique();


        }
    }
}
