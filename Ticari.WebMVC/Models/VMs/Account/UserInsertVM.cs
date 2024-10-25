using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Ticari.WebMVC.Models.VMs.Account
{
    public class UserInsertVM
    {
        [Required(ErrorMessage ="Ad Alani zorunludur")]
        [MinLength(2,ErrorMessage ="En az 2 karakter olmalidir")]
        [MaxLength(50, ErrorMessage = "En fazla 50 karakter olmalidir")]
        public string Ad { get; set; }



        [Required(ErrorMessage = "Soyad Alani zorunludur")]
        [MinLength(2, ErrorMessage = "En az 2 karakter olmalidir")]
        [MaxLength(50, ErrorMessage = "En fazla 50 karakter olmalidir")]
        public string Soyad { get; set; }



        [Required(ErrorMessage = "TcNo Alani zorunludur")]
        [StringLength(11,ErrorMessage ="TcNo 11 Karakter olmalidir")]
        public string TcNo { get; set; }

        [Required(ErrorMessage = "Email Alani zorunludur")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }


        [Required(ErrorMessage = "Gsm Alani zorunludur")]
        [DataType(DataType.PhoneNumber)]
        public string Gsm { get; set; }

        public bool Cinsiyet { get; set; }


        [Required(ErrorMessage = "Şifre Alani zorunludur")]
        [MinLength(2, ErrorMessage = "En az 3 karakter olmalidir")]
        [MaxLength(50, ErrorMessage = "En fazla 50 karakter olmalidir")]
        [DisplayName("Şifre")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Şifre Alani zorunludur")]
        [MinLength(2, ErrorMessage = "En az 3 karakter olmalidir")]
        [MaxLength(50, ErrorMessage = "En fazla 50 karakter olmalidir")]
        [DisplayName("Şifre Tekrar")]
        [DataType(DataType.Password)]
        public string RePassword { get; set; }
    }
}
