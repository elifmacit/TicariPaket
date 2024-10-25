using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Ticari.Entities.Entities.Abstract;

namespace Ticari.Entities.Entities.Concrete
{
    public class MyUser:BaseEntity
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TcNo { get; set; }
        public string Email { get; set; }
        public string Gsm { get; set; }
        public bool? Cinsiyet { get; set; }
        public string Password { get; set; }

        public List<Role>? Roller{ get; set; }
    }
}
