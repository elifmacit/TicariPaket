using AspNetCoreHero.ToastNotification;
using AspNetCoreHero.ToastNotification.Extensions;
using Microsoft.EntityFrameworkCore;
using Ticari.Entities.DbContexts;
using Ticari.WebMVC.Extensions;
using Ticari.WebMVC.MyProfile;

namespace Ticari.WebMVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            #region DbContext Registiration
            var constr = builder.Configuration.GetConnectionString("Ticari");
            builder.Services.AddDbContext<SqlDbContext>(options => options.UseSqlServer(constr));
            #endregion
            builder.Services.AddAutoMapper(p => p.AddProfile<AutoMapperProfile>());
            builder.Services.AddNotyf(p =>
            {
                p.Position = NotyfPosition.BottomRight;
                p.DurationInSeconds = 7;
                p.IsDismissable = true;

            });

           builder.Services.AddTicariService();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();
            app.UseNotyf();
            app.UseRouting();

            app.UseAuthorization();
             app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                  name: "areas",
                  pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                );
            });

            //TODO : Rota Tanimlamasina bakilacak
            //app.MapControllerRoute(

            //   name: "login",
            //    pattern: "login",
            //    defaults: new { controller = "Account", action = "Login" });
             
            app.MapControllerRoute(

                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}"
                );


           
            app.Run();
        }
    }
}
