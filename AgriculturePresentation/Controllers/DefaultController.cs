using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.Controllers
{
    public class DefaultController : Controller
    {
        ServiceManager _serviceManager = new ServiceManager(new EfServiceDal());
        public IActionResult Index()
        {
            var values= _serviceManager.GetListAll();
            return View(values);
        }
    }
}
