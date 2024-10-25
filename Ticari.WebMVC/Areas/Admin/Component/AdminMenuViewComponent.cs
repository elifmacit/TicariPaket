using Microsoft.AspNetCore.Mvc;
using Ticari.BL.Managers.Abstract;
using Ticari.Entities.Entities.Concrete;

namespace Ticari.WebMVC.Areas.Admin.Components
{
    public class AdminMenuViewComponent : ViewComponent
    {
        private readonly IManager<Menu> menuManager;

        public AdminMenuViewComponent(IManager<Menu> menuManager)
        {
            this.menuManager = menuManager;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            // Bu bolum Daha sonra degistirilecek. Gelen Kullanicinin Role'une gore veriler cekilecek
            var menuler = menuManager.GetAll();
            return View(menuler);
        }
    }
}