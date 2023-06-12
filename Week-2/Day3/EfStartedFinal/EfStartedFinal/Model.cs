using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;


using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

 //static IOrderedEnumerable<TSource> OrderBy<TSource, TKey>(this System.Collections.Generic.IEnumerable<TSource> source, Func<TSource, TKey> keySelector);


public class ECommerceContext : DbContext
{
    public DbSet<ProductFinal> FProducts { get; set; }
    public DbSet<CategoryFinal> CategoriesFinal { get; set; }

    public string DbPath { get; }

    public ECommerceContext()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = System.IO.Path.Join(path, "ECommerce.db");
    }

    // The following configures EF to create a Sqlite database file in the
    // special "local" folder for your platform.
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");
}

public class ProductFinal
{
    [Key]
    public int IdProduct { get; set; }
    public string? ProductFUrl { get; set; }
    //public string? Description { get; set; }

    public List<CategoryFinal> CategoriesFinal { get; } = new();

}
//public static void OrderBy()
//{
//    ProductFinal[] pf = { new ProductFinal { IdProduct=8, ProductFUrl="https://rukminim1.flixcart.com/image/300/300/xif0q/mobile/c/s/x/-original-imagzjhwaaewgj8r.jpeg?q=90" },
//                   new ProductFinal { IdProduct=9, ProductFUrl="https://rukminim1.flixcart.com/image/300/300/ktketu80/mobile/6/n/d/iphone-13-mlpg3hn-a-apple-original-imag6vpyghayhhrh.jpeg?q=90" },
//                   new ProductFinal { IdProduct=10, ProductFUrl="https://rukminim1.flixcart.com/image/300/300/xif0q/mobile/n/v/2/-original-imagmkjfjwtzhaag.jpeg?q=90" } };

//    IEnumerable<ProductFinal> query = pf.OrderBy(product => product.ProductFUrl);

//    foreach (ProductFinal product in query)
//    {
//        Console.WriteLine("{0} - {1}", product.IdProduct, product.ProductFUrl);
//    }
//}

public class CategoryFinal
{
    public int Id { get; set; }
    public string? FName { get; set; }
    public string? FSerialNo { get; set; }

    //public int BlogId { get; set; }
    //public Product Blog { get; set; }
}
//public class Customer
//{
//    public string CustomerId { get; set; }
//    public string CustomerName { get; set; }
//    public string Email { get; set; }
//}
