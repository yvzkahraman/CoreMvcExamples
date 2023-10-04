using Microsoft.AspNetCore.Mvc;

namespace Example01.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
