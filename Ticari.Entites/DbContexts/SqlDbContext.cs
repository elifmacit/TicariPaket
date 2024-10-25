
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Ticari.Entities.Entities.Concrete;

namespace Ticari.Entities.DbContexts
{
    public class SqlDbContext:DbContext
    {
        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Menu> Menuler {  get; set; }
        public DbSet<MyUser> Users { get; set; }
        public DbSet<Role> Roller { get; set; }

        public SqlDbContext()
        {
            
        }

        public SqlDbContext(DbContextOptions<SqlDbContext> options):base(options)
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("server=.;Database=TicariDb;Trusted_Connection=true;TrustServerCertificate=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
          modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}

