using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace AgriculturePresentation.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Lütfen kullanıcı adınızı giriniz!")]
        public string userName { get; set; }


        [Required(ErrorMessage = "Lütfen şifrenizi giriniz!")]
        public string password { get; set; }
    }
}
