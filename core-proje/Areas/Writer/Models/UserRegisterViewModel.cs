using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace core_proje.Areas.Writer.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "Lütfen Adınızı Girin")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Lütfen  Soydınızı Girin")]
        public string Surname { get; set; }
        [Required(ErrorMessage ="Lütfen Resim URL Değeri Girin")]
        public string ImageUrl { get; set; }
        [Required(ErrorMessage = "Lütfen Kullanıcı Adını Girin")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Lütfen Şifre Girin")]
        public string Password{ get; set; }
        [Required(ErrorMessage = "Lütfen Şifreyi tekrar Girin")]
        [Compare("Password",ErrorMessage = "Şifreler uyumlu değil")]
        public string ConfirmPassword{ get; set; }
        [Required(ErrorMessage = "Lütfen Mail Girin")]
        public string Mail{ get; set; }
    }
}
