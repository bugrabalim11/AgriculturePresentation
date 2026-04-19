using AgriculturePresentation.Models;
using BusinessLayer.Abstarct;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.Controllers
{
    public class ServiceController : Controller
    {
        private readonly IServiceService _serviceService;

        public ServiceController(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }

        public IActionResult Index()
        {
            var values = _serviceService.GetListAll();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddService()
        {
            return View(new ServiceAddViewModel());
        }

        [HttpPost]
        public IActionResult AddService(ServiceAddViewModel serviceAddViewModel)
        {
            if (ModelState.IsValid)
            {
                _serviceService.Insert(new Service()
                {
                    Title = serviceAddViewModel.Title,
                    Image = serviceAddViewModel.Image,
                    Description = serviceAddViewModel.Description
                });
                return RedirectToAction("Index");
            }
            return View(serviceAddViewModel);
        }

        public IActionResult DeleteService(int id)
        {
            var values = _serviceService.GetById(id);
            if(values != null) // Values null değilse silme işlemi yapılır, aksi halde hata mesajı gösterilir.
            {
                _serviceService.Delete(values);
                TempData["Message"] = "Kayıt başarıyla silindi.";
            }
            else
            {
                TempData["ErrorMessage"] = "Silinmek istenen kayıt bulunamadı!";
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditService(int id)
        {
            var values = _serviceService.GetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult EditService(Service service)
        {
            _serviceService.Update(service);
            return RedirectToAction("Index");
        }
    }
}
