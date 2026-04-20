using BusinessLayer.Abstarct;
using BusinessLayer.ValidationRules;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.Controllers
{
    public class TeamController : Controller
    {
        private readonly ITeamService _teamService;

        public TeamController(ITeamService teamService)
        {
            _teamService = teamService;
        }

        public IActionResult Index()
        {
            var values = _teamService.GetListAll();
            if (values == null || !values.Any())
            {
                TempData["AlertMessage"] = "Personel bulunamadı!";
            }
            return View(values);
        }

        [HttpGet]
        public IActionResult AddTeam()
        {
            // DÜZELTME 1: Yeni kayıt eklerken GetById(id) yapmana gerek yok. 
            // Sadece boş bir sayfa döndürmelisin.
            return View();
        }

        [HttpPost]
        public IActionResult AddTeam(Team team)
        {
            TeamValidator validationRules = new TeamValidator();
            ValidationResult result = validationRules.Validate(team);
            if (result.IsValid)
            {
                _teamService.Insert(team);
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
            return View(team);
        }

        public IActionResult DeleteTeam(int id)
        {
            var value = _teamService.GetById(id);
            _teamService.Delete(value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditTeam(int id)
        {
            var values = _teamService.GetById(id);
            if (values == null)
            {
                return NotFound();
            }
            return View(values);
        }

        [HttpPost]
        public IActionResult EditTeam(Team team)
        {
            TeamValidator validationRules = new TeamValidator();
            ValidationResult result = validationRules.Validate(team);
            if (result.IsValid)
            {
                _teamService.Update(team);
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
            return View(team);
        }
    }
}