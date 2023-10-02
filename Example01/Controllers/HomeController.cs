using Microsoft.AspNetCore.Mvc;

namespace Example01.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var list = new List<Product>()
            {
                new Product { Id = 1,Name="Samsung s21"},
                new Product { Id = 2, Name = "Iphone 15"},
            };

            // collection => add, update, remove + LINQ


            // db seviyesinde yapabilsek ?? 

            // yapabiliyoruzdur... 


            // LINQ TO DATA => 
            // LINQ TO SQL => Db First || LINQ TO SQL microsoft 


            // EF 

            // EF CORE 




            var eIcerenUrunler = list.Where(x => x.Name.Contains("e"));

            return View();
        }
    }



}
