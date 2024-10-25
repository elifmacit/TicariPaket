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
    public class MenuConfig:BaseConfig<Menu>
    {
        public override void Configure(EntityTypeBuilder<Menu> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.MenuName).HasMaxLength(50);
            builder.Property(p=>p.ActionName).HasMaxLength(50);
            builder.Property(p=>p.ControllerName).HasMaxLength(50);
            builder.Property(p => p.AreaName).HasMaxLength(50);
            builder.Property(p => p.CssName).HasMaxLength(50);
            builder.Property(p => p.IConName).HasMaxLength(50);

            builder.HasData(new Menu
            {
                Id = 1,
                MenuName ="Home",
                ControllerName = "Home",
                ActionName = "Index",
                AreaName = "Admin",
                ClassName = "far da-circle nav-icon",
                CreateDate = DateTime.Now,
                CssName = ""
            },

          new Menu
            {
                Id = 2,
                MenuName ="Product",

              ControllerName = "Product",
                ActionName = "Product",
                AreaName = "Admin",
                ClassName = "far da-circle nav-icon",
                CreateDate = DateTime.Now,
                CssName = ""
            },
          new Menu
            {
                Id = 3,
              MenuName = "Kullanicilar",
              ControllerName = "Account",
                ActionName = "Index",
                AreaName = "Admin",
                ClassName = "far da-circle nav-icon",
                CreateDate = DateTime.Now,
                CssName = ""
            });
             


        }
    }
}
