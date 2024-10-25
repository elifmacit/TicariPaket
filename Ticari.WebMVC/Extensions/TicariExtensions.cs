using Microsoft.AspNetCore.WebSockets;
using Microsoft.EntityFrameworkCore;
using Ticari.BL.Managers.Abstract;
using Ticari.BL.Managers.Concrete;
using Ticari.Entities.DbContexts;

namespace Ticari.WebMVC.Extensions
{
    public static class TicariExtensions
    {
        public static IServiceCollection AddTicariService(this IServiceCollection services) 
        {
            
            services.AddScoped(typeof(IManager<>), typeof(Manager<>));

            return services;
        }
    }
}
