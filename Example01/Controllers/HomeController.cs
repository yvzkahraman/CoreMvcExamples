using Example01.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Example01.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ProductDbContext context;


        //public HomeController()
        //{
        //    context = new ProductDbContext();
        //}

        //public HomeController(ProductDbContext context)
        //{
        //    this.context = context;
        //}





        public IActionResult Index()
        {

            //var products = context.Products.AsNoTracking().ToList();

            //var product = products[0];
            //var state = context.Entry(product).State;

            //products[0].Name = "Samsung S22";

            //var state2 = context.Entry(product).State;


            ////context.Products.Update(products[0]);

            ////var state3= context.Entry(product).State;

            //context.Products.Update(products[0]);

            ////connected Entity => ben veritabanından bir veri çekeceğim, o çekeceğim veri üstünde 

            ////disconnected Entity 

            //Product product2 = new Product { };
            //context.Products.Add(product2);
            //context.SaveChanges();



            ////ASLA YAPMA !!


            //Product product3 = new Product { Id=2 };
            //context.Products.Update(product2);
            //context.SaveChanges();




            //context.Entry(product).State = EntityState.Modified;

            ////context.Products.Add()

            ////if(state != EntityState.Detached)
            ////{
            ////    if (state == EntityState.Modified)
            ////    {
            ////        /*adonet sorgusu */
            ////    }
            ////    else if (state == EntityState.Added)
            ////    {
            ////        /* ekleme adonet */
            ////    }
            ////}
          

            //// olayı yapan değiştiren ekleyen bu arkadaş ... 


            //// adoyu 
            //// modified => update added => insert detach , unchanged
            //// kayıtları izlemesi ... 

            ////connected entity
            ////disconnected entity


            //context.SaveChanges();

            return View();
        }
    }


    //public class Test
    //{
    //    public void TestMethod()
    //    {
    //        HomeController controller =new HomeController()
    //    }
    //}



}
