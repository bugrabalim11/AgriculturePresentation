using BusinessLayer.Abstarct;
using BusinessLayer.ValidationRules;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        public IActionResult Index()
        {
            var values = _contactService.GetListAll();
            if (values == null || !values.Any())
            {
                TempData["AlertMessage"] = "Harita bilgisi bulunamadı!";
            }
            return View(values);
        }

        public IActionResult DeleteMessage(int id)
        {
            var values = _contactService.GetById(id);
            if (values == null)
            {
                return NotFound("Silinecek veri bulunamadı!");
            }
            _contactService.Delete(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult MessageDetails(int id)
        {
            var values = _contactService.GetById(id);
            if (values == null)
            {
                return NotFound("Mesaj bulunamadı!");
            }
            return View(values);
        }
    }
}
