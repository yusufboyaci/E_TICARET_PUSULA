using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace UI.Models
{
    public class LoginVM
    {
        [Display(Name = "Kullanıcı Adı")]
        [Required(ErrorMessage = "Lütfen Kullanıcı Adı Giriniz!")]
        public string? UserName { get; set; }
        [Display(Name = "Şifre")]
        [Required(ErrorMessage = "Lütfen Şifre Giriniz!")]
        public string? Password { get; set; }
    }
}
