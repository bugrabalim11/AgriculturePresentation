using System.ComponentModel.DataAnnotations;

namespace AgriculturePresentation.Models
{
    public class ServiceAddViewModel
    {
        [Display(Name = "Başlık")]
        [Required(ErrorMessage = "Başlık boş bırakılamaz.")]
        public string Title { get; set; } = string.Empty;

        [Display(Name = "Görsel")]
        [Required(ErrorMessage = "Görsel boş bırakılamaz.")]
        public string Image { get; set; } = string.Empty;

        [Display(Name = "Açıklama")]
        [Required(ErrorMessage = "Açıklama boş bırakılamaz.")]
        public string Description { get; set; } = string.Empty;
    }
}
