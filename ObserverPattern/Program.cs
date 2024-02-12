
//Observer Design Pattern

var xiaomi = new Product("Xiaomi 13t pro", 20000);
var sony = new Product("sony pro", 100000);

var trendyol = new Trendyol();
var kaanObserver = new KaanObserver("Kaan Boyaci");
var ahmetObserver = new AhmetObserver("Ahmet Bulut");

trendyol.Register(kaanObserver, xiaomi);
trendyol.Register(ahmetObserver, sony);
//trendyol.NotifyForProductName("Xiaomi 13t pro");
trendyol.NotifyAll();
Console.ReadLine();


class Product
{
    public Product(string name, decimal price)
    {
        Name = name;
        Price = price;
    }

    public string Name { get; set; }

    public decimal Price { get; set; }
}

class Trendyol
{
    private Dictionary<IObserver, Product> observers = new();
    public void Register(IObserver observer, Product product) 
    {
        observers.TryAdd(observer, product);
    }  
    public void UnRegister(IObserver observer) 
    {
        observers.Remove(observer);
    }
    public void NotifyAll()
    {
        foreach (var kv in observers)
        {
            kv.Key.StockUpdate(kv.Value);
        }
    }    public void NotifyForProductName(string productName)
    {
        foreach (var kv in observers)
        {
            if (kv.Value.Name.Equals(productName))
                kv.Key.StockUpdate(kv.Value);
        }
    }
}

class KaanObserver : IObserver
{
    public string FullName { get; set; }

    public KaanObserver(string fullName)
    {
        FullName = fullName;
    }

    public void StockUpdate(Product product)
    {
        Console.WriteLine($"{FullName}, Product {product.Name} in stock now!");
    }
}
class AhmetObserver : IObserver
{
    public string FullName { get; set; }

    public AhmetObserver(string fullName)
    {
        FullName = fullName;
    }

    public void StockUpdate(Product product)
    {
        Console.WriteLine($"{FullName}, Product {product.Name} in stock now!");
    }
}
interface IObserver
{
    string FullName { get; set; }
    void StockUpdate(Product product);
}