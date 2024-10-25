using AspNetCoreHero.ToastNotification.Abstractions;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Ticari.BL.Managers.Abstract;
using Ticari.Entities.Entities.Concrete;
using Ticari.WebMVC.Models.VMs.Account;

namespace Ticari.WebMVC.Controllers
{
    public class AccountController(IManager<Role> roleManager
                                   ,IManager<MyUser> userManager
                                   ,INotyfService notyfService
                                    ,IMapper mapper) : Controller
    {
       

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Users()
        {
            var users = userManager.GetAllInclude(null,p=>p.Roller).ToList();
            return View(users);
        }

        public IActionResult UserInsert()
        {

            UserInsertVM userInsertVM = new UserInsertVM();
            return View(userInsertVM);
        }
        [HttpPost]
        public IActionResult UserInsert(UserInsertVM insertVM)
        {

            if (!ModelState.IsValid)
            {
                
                notyfService.Error("Düzeltilmesi gereken yerler var");
                return View(insertVM);
            }
            // Burada insertvm MyUser sinifina çevrilmesi lazim

            #region Amele Yontemi

            //MyUser myUser = new MyUser();
            //myUser.Cinsiyet=insertVM.Cinsiyet;
            //myUser.Ad=insertVM.Ad;
            //myUser.Soyad=insertVM.Soyad;
            //myUser.Email=insertVM.Email;
            //myUser.TcNo=insertVM.TcNo;
            //myUser.Gsm=insertVM.Gsm;
            //myUser.CreateDate=DateTime.Now;
            //myUser.Password=insertVM.Password;
           #endregion

            var myUser =mapper.Map<MyUser>(insertVM);
            userManager.Create(myUser);

            #region Kullaniciya Default olarak user rolü eklenir
            var role = roleManager.Get(p => p.RoleAdi == "user"); // user role db'den cekilir
            myUser.Roller = new List<Role>();
            myUser.Roller.Add(role);
            userManager.Update(myUser); 
            #endregion
            notyfService.Success("Islem Basarili");

           

            // userManager.Create(insertVM);

            return RedirectToAction("Index", "Account",new { Area="Admin"});
           
        }
    }
}
