
List<Category> categories = new List<Category>
{
    new Category {CategoryId=1,CategoryName="Bilgisayar"},
    new Category {CategoryId=2,CategoryName="Telefon"}
};

List<Product> products = new List<Product>
{
    new Product {ProductId=1,CategoryId=1,ProductName="Acer Laptop",QuanttityPerUnit="32 GB Ram",UnitPrice=10000,UnitsInStock=5},
    new Product {ProductId=2,CategoryId=1,ProductName="Asus Laptop",QuanttityPerUnit="16 GB Ram",UnitPrice=22000,UnitsInStock=6},
    new Product {ProductId=3,CategoryId=1,ProductName="Hp Laptop",QuanttityPerUnit="32 GB Ram",UnitPrice=15000,UnitsInStock=12},
    new Product {ProductId=4,CategoryId=2,ProductName="Samsung Telefon",QuanttityPerUnit="32 GB Ram",UnitPrice=4000,UnitsInStock=23},
    new Product {ProductId=5,CategoryId=2,ProductName="Apple Telefon",QuanttityPerUnit="64 GB Ram",UnitPrice=8500,UnitsInStock=0},
};
Console.WriteLine("Algoritmik------------------------");
foreach (var product in products)
{
    if (product.UnitPrice >= 5000)
    {
        Console.WriteLine(product.ProductName);
    }
  //  Console.WriteLine(product.ProductName);
}
Console.WriteLine("Linq-------------------------------");
var result=products.Where(x=>x.UnitPrice>5000);
foreach (var product in result)
{
    Console.WriteLine(product.ProductName);
}
static List<Product> GetProduct(List<Product>products)
{
List<Product> filteredProducts=new List<Product>();
    foreach (var  product in products)
    {
        if(product.UnitPrice>5000 && product.UnitsInStock>3)
        {
            filteredProducts.Add(product);
        }
    }
    return filteredProducts;    
}


static List<Product> GetProductsLinq(List<Product>products)
{
    return products.Where(x => x.UnitPrice > 5000).ToList(); ;
}
class Product
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public string QuanttityPerUnit { get; set; }
    public decimal UnitPrice { get; set; }
    public int UnitsInStock { get; set; }
    public int CategoryId { get; set; }
}
class Category
{
    public int CategoryId { get; set; }
    public string CategoryName { get; set; }

}