using BusinessLayer.Abstarct;
using BusinessLayer.ValidationRules;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.Controllers
{
    public class ImageController : Controller
    {
        private readonly IImageService _imageService;

        public ImageController(IImageService imageService)
        {
            _imageService = imageService;
        }

        public IActionResult Index()
        {
            var values = _imageService.GetListAll();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddImage()
        {
            // DÜZELTME 1: Yeni kayıt eklerken GetById(id) yapmana gerek yok. 
            // Sadece boş bir sayfa döndürmelisin.
            return View();
        }

        [HttpPost]
        public IActionResult AddImage(Image image)
        {
            ImageValidator validationRules = new ImageValidator();
            ValidationResult result = validationRules.Validate(image);
            if (result.IsValid)
            {
                _imageService.Insert(image);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            // DÜZELTME 2: Hata olduğunda 'team' nesnesini geri gönderiyoruz ki 
            // kullanıcının yazdığı veriler kutucuklardan silinmesin!
            return View(image);
        }

        public IActionResult DeleteImage(int id)
        {
            var value = _imageService.GetById(id);
            _imageService.Delete(value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditImage(int id)
        {
            var values = _imageService.GetById(id);
            if (values == null)
            {
                return NotFound();
            }
            return View(values);
        }

        [HttpPost]
        public IActionResult EditImage(Image image)
        {
            ImageValidator validationRules = new ImageValidator();
            ValidationResult result = validationRules.Validate(image);
            if (result.IsValid)
            {
                _imageService.Update(image);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            // DÜZELTME 3: Yine aynı şekilde, hata varsa girilen verileri geri gönderiyoruz.
            return View(image);
        }
    }
}
