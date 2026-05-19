using AgriculturePresentation.Models;
using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.Controllers
{
    public class ChartController : Controller
    {
        private readonly IProductService _productService;

        public ChartController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ProductChart()
        {
            List<ProductClass> productClasses = new List<ProductClass>();
            var values = _productService.GetListAll();
            foreach (var item in values)
            {
                ProductClass productClass = new ProductClass();
                productClass.productname = item.ProductName;
                productClass.productvalue = item.Value;
                productClasses.Add(productClass);
            }
            return Json(new { jsonlist = productClasses }); // eğer geriye bir HTML sayfası (return View) dönüyorsan döngü View'dadır. Geriye saf veri (return Json) dönüyorsan, veriyi Controller'da hazırlar, Javascript'in önüne atarsın.
        }
    }
}
