class Program
{

    //delegate void FunctionDelegates(string value1, string value2);


    /* Assembly -> C  -> C++ -> Java | C#  Seviye yükseldikçe, işler kolaylaşır. */
    /* functionları tetikleyen function */
    public static void Main(string[] args)
    {


        //FunctionDelegates delegates = new FunctionDelegates(SayHello);
        //delegates += SayWelcome;


        //delegates.Invoke("Yavuz", "Selim");


        //Func<string, int> func = new Func<string, int>(ConvertToInt);
        //var returnValue = func.Invoke("yavuz");

        //Func<string,string> func2 = new Func<string, string>()

        //Linq yapısı doğrudan delegeler ile çalışır.

        //Predicate<string> predicate = new Predicate<string>()

        //Action<string> action = new Action<string>(SayHello2);
        //action.Invoke("Yavuz");

        //Console.WriteLine("gelen number " + returnValue);



        //Action<Product> actionProduct = new Action<Product>(GetProductName);
        //actionProduct += GetProductId;


        //products.ForEach(GetProductName);

        //Func
        //Predicate

        //Action
        // Delegate=> 
        // Hızlı function

        //List<Product> products = new List<Product>()
        //{
        //    new Product() {Id=1, Name ="IPhone"},
        //    new Product() {Id=2, Name ="Samsung"}
        //};

        //products.ForEach((x) => { Console.WriteLine(x.Name); });

        //products.ForEach(x=> Console.WriteLine(x.Name));

        //var a = (string x) => "Yavuz";

        //var abc = () => { Console.WriteLine("Test"); };

        //products.ForEach(GetProductName);


        //products.Where(x => x.Name == "Abc");
        //abc += Test;

        //abc.Invoke();
    }

    public static void Test()
    {
        Console.WriteLine("Test2");
    }


    public static void GetProductName(Product product)
    {
        Console.WriteLine("Product name - "+product.Name);
    }

    public static void GetProductId(Product product)
    {
        Console.WriteLine("Product Id - " + product.Id);
    }

    public static void SayHello2(string name)
    {
        Console.WriteLine("Hello" + name);
    }

    public static int ConvertToInt(string value)
    {
        var control = int.TryParse(value, out var returnValue);

        if (control)
        {
            return returnValue;
        }
        return -1;

    }

    public static void SayHello(string name1, string name2)
    {
        Console.WriteLine("Hello" + name1 + "-" + name2);
    }

    public static void SayWelcome(string name1, string name2)
    {
        Console.WriteLine("Welcome" + name1 + "-" + name2);
    }

    public class Product
    {
        //DAPPER  | LINQ | 
        public int Id { get; set; }
        public string Name { get; set; }
    }

}
