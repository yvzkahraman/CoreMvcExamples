using Example01.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Example01.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductDbContext context;

        public ProductController(ProductDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            var list = this.context.Products.ToList();
            return View(list);
        }
    }
}
