using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Ticari.WebMVC.Models;

namespace Ticari.WebMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly INotyfService notyfService;

        public HomeController(ILogger<HomeController> logger,INotyfService notyfService)
        {
            _logger = logger;
            this.notyfService = notyfService;
        }

        public IActionResult Index()
        {

            notyfService.Success("ISlem Basarili");
            notyfService.Error("Hatali iþlem");
            notyfService.Information("ISlem Tamam");
            notyfService.Warning("Dikkat..");



            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
