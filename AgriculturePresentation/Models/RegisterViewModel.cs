using System.ComponentModel.DataAnnotations;

namespace AgriculturePresentation.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Lütfen kullanıcı adını giriniz!")]
        public string userName { get; set; }

        [Required(ErrorMessage = "Lütfen mail adresinizi giriniz!")]
        public string mail { get; set; }

        [Required(ErrorMessage = "Lütfen şifrenizi giriniz!")]
        public string password { get; set; }

        [Required(ErrorMessage = "Lütfen şifreyi tekrar giriniz!")]
        [Compare("password", ErrorMessage = "Şifreler eşleşmiyor!")]
        public string passwordConfirm { get; set; }
    }
}
