using BusinessLayer.Abstarct;
using BusinessLayer.ValidationRules;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.Controllers
{
    public class AddressController : Controller
    {

        private readonly IAddressService _addressService;

        public AddressController(IAddressService addressService)
        {
            _addressService = addressService;
        }

        public IActionResult Index()
        {
            var values = _addressService.GetListAll();
            if (values == null || !values.Any())
            {
                TempData["AlertMessage"] = "Adres bulunamadı!";
            }
            return View(values);
        }

        [HttpGet]
        public IActionResult EditAddress(int id)
        {
            var values = _addressService.GetById(id);
            if (values == null)
            {
                return NotFound();
            }
            return View(values);
        }

        [HttpPost]
        public IActionResult EditAddress(Address address)
        {
            AddressValidator validationRules = new AddressValidator();
            ValidationResult result = validationRules.Validate(address);
            if (result.IsValid)
            {
                _addressService.Update(address);
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
            return View(address);
        }
    }
}
