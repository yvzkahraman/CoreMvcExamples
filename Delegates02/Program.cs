//functionları tetikleyen yapı....

//NetCoreDelegate netCoreDelegate = new NetCoreDelegate(SayHelloOne);
////for (int i = 1; i < 1000; i++) {
////    netCoreDelegate += SayHelloOne;
////}

//netCoreDelegate.Invoke("Yavuz","Selim");
//netCoreDelegate.Invoke("Hakan", "Karabidek");
//netCoreDelegate.Invoke("Cemil", "Kutluca");
//netCoreDelegate.Invoke("Ayberk", "Tombul");

//Console.WriteLine("Hello World");

//Action<string, string> action = new Action<string, string>(SayHelloOne);


// vermiş olduğum parametreler için, tanımlı olan her metod, tek tek çalışır.

//products.ForEach(x =>
//{
//    Console.WriteLine($"Product name: {x.Name}  -  Product price {x.Price}");
//});


//var abc = () =>
//{
//    return "Hello world";
//};

//Func<int, string> funcDelegate = new Func<int, string>(GetNumber);

////Console.WriteLine( funcDelegate.Invoke(50));
////Console.WriteLine(funcDelegate.Invoke(55));
////Console.WriteLine(funcDelegate.Invoke(54));

//Predicate<string> predicate  = new Predicate<string>(CheckName);

//var result1 =  predicate.Invoke("Yavuz");

//// delegate => func, predicate, action => 

//var newProductList = products.Where(CheckName2);

//var funcProduct = (Product x) => x.Name == "Samsung S21 5g";
////var abc = () =>
////{
////    return true;
////};
using Delegates02;

class Program
{
    //delegate void NetCoreDelegate(string firstname, string lastname);
    public static void Main(string[] args)
    {
        List<Category> categories = new List<Category>() {

         new Category {Name = "Elektronik", Id =1},
         new Category {Name ="Beyaz Eşya", Id =2},
        };

        List<Product> products = new List<Product>()
        {

            new Product { Name = "Samsung S21 5g", Price=15000, CategoryId =1},
            new Product {Name = "Iphone 14 pro max", Price=80000, CategoryId=1},
            new Product {Name = "Iphone 14", Price=65000, CategoryId=1},
            new Product {Name ="Buzdolabı", Price=10000, CategoryId = 2},
            new Product {Name ="Çamaşır Makinesi", Price=6000, CategoryId = 2}

        };

        // neye benziyor  => 

        var datas = products.Join(categories, p => p.CategoryId, c => c.Id, (product, category) => new ProductCategoryListObject
        {

            ProductName = product.Name,
            CategoryName = category.Name,
        }).ToList();


        var twoProduct = products.Take(2);

        var avgProductPrice = products.Average(x => x.Price);
        var totalPrice = products.Sum(x => x.Price);
        var maxPrice = products.Max(x => x.Price);

        var maxPriceProduct = products.FirstOrDefault(x => x.Price == products.Max(x=>x.Price));

        var maxPriceProduct2 = products.OrderByDescending(x=>x.Price).FirstOrDefault();
        

        foreach (var item in datas)
        {
            Console.WriteLine($"Product : {item.ProductName} - Category:{item.CategoryName}");
        }



        //var resultII = products.WhereCustom(CheckName3);
        //var resultIII = products.FirstOrDefault();
        //var resultIV = products.FirstOrDefault(CheckName4);

    }

    public class ProductCategoryListObject
    {
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
    }

    //private static bool CheckName4(Product product)
    //{
    //    return product.Name.Contains("Iph");
    //}

    //public static bool CheckName3(Product product)
    //{
    //    return product.Name == "Iphone 14";
    //}



    //public static bool CheckName2(Product product)
    //{
    //    return product.Name.Contains("a");
    //}

    //public static bool CheckName(string name)
    //{
    //    if(name == "Hakan")
    //    {
    //        return true;
    //    }
    //    return false;
    //}

    //public static string GetNumber(int parameter)
    //{
    //    return "Girdiğiniz deger : " + parameter;
    //}

    //public static void GetProduct(Product product)
    //{
    //    Console.WriteLine($"Product name: {product.Name}  -  Product price {product.Price}");
    //}

    //public static void SayHelloOne(string firstname, string lastname)
    //{
    //    Console.WriteLine($"Hello {firstname} - {lastname} Method=2 ");
    //}

    //public static void SayHelloTwo(string firstname, string lastname)
    //{
    //    Console.WriteLine($"Hello {firstname} - {lastname} Method=2 ");
    //}
}
class Product
{
    public int Price { get; set; }
    public string Name { get; set; }

    public int CategoryId { get; set; }
}


class Category
{
    public int Id { get; set; }
    public string Name { get; set; }
}