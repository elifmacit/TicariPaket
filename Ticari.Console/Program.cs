using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using Ticari.BL.Managers.Concrete;
using Ticari.Entities.DbContexts;
using Ticari.Entities.Entities.Concrete;
namespace Ticari.TestConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var sr =  File.OpenText(@"c:\Shared\116m_gsm.sql");
            // while (sr.Read()>0)
            // {
            //     var line = sr.ReadLine();
            //     Console.WriteLine(line);
            // }
            // Console.WriteLine("Hello, World!");


            //  AddProductWithCategory();

            //UpdateWithProductCategory();
            AddUserAndRole();
            //AddNewRole();
        }
        public static void AddNewRole()
        {
            Manager<Role> roleManager = new Manager<Role>();
            Manager<MyUser> userManager = new Manager<MyUser>();
            var ali = userManager.GetAllInclude(p => p.Ad == "ali", p => p.Roller).FirstOrDefault();
            var adminRole = roleManager.Get(p => p.RoleAdi == "admin");
            ali.Roller.Add(adminRole);
            userManager.Update(ali);

         
        }
        public static void AddUserAndRole()
        {
           
            MyUser user = new MyUser()
            {
                Ad = "ali",
                Soyad= "ali",
                TcNo="12312312312",
                Email="ali@admin.com",
                Password="qweasd",
                Cinsiyet=false,
                Gsm="5321112234",
                CreateDate= DateTime.Now

            };
            Manager<Role> roleManager= new Manager<Role>();
            Role role = new Role() { RoleAdi="user" , CreateDate = DateTime.Now };
            role.Users = new List<MyUser>() { user };
                
            roleManager.Create(role);   


        }
        private static void UpdateWithProductCategory()
        {
            // Varolan bir product'a varolan bir category Ekleme
            //Once Product CEkilir
            SqlDbContext sqlDb = new();

            // Burasi category'leri getirmediginden dolayi hatalidir
            //var product = sqlDb.Products.Where(p => p.ProductName == "Ekmek").FirstOrDefault();
            var product = sqlDb.Products.Include(p=>p.Categories).Where(p => p.ProductName == "Ekmek").FirstOrDefault();

            if (product != null)
            {
               
              
                //Eklenecek olan category bulunur 
                var category = sqlDb.Categories.Where(p => p.CategoryName == "Icecek").FirstOrDefault();
                if (category != null)
                {
                    product.Categories.Add(category);
                    sqlDb.Products.Update(product);
                    sqlDb.SaveChanges();
                }
            }
        }

        public static void AddProductWithCategory()
        {
            SqlDbContext sqlDb = new();
            Category icecek = new Category
            {
                CategoryName = "Icecek",
                CreateDate = DateTime.Now,
                Description = "Icecek"
            };
            Product ayran = new Product()
            {
                ProductCode = "001.002",
                ProductName = "Sutas Ayran",
                Amount = 100,
                UnitPrice = 50,
                Categories = new List<Category> { icecek }

            };
            sqlDb.Products.Add(ayran);
            sqlDb.SaveChanges();
        }
    }
}
