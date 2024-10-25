using AutoMapper;
using Ticari.Entities.Entities.Concrete;
using Ticari.WebMVC.Models.VMs.Account;

namespace Ticari.WebMVC.MyProfile
{
    public class AutoMapperProfile :Profile
    {
        public AutoMapperProfile()
        {
            // UserInsertVM => MyUser'a cevir , ReverseMap ile bu islemin terside dogrudur demek istiyoruz
            CreateMap<UserInsertVM, MyUser>().ReverseMap();
        }
    }
}
