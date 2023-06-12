using System;
using System.Linq;
using System.Reflection.Metadata;

using var db = new ECommerceContext();

// Note: This sample requires the database to be created before running.
Console.WriteLine($"Database path: {db.DbPath}.");

// Create
Console.WriteLine("Inserting a new product");
db.Add(new ProductFinal { ProductFUrl = "http://blogs.msdn.com/adonet" });
db.SaveChanges();

// Read
Console.WriteLine("Querying for a product");
var product = db.FProducts
    .OrderBy(b => b.IdProduct)
    .First();

// Update
Console.WriteLine("Updating the Product and adding a category");
product.ProductFUrl = "https://devblogs.microsoft.com/dotnet";
product.CategoriesFinal.Add(
    new CategoryFinal { FName = "Category Name", FSerialNo = "Category Serial Number" });
db.SaveChanges();

// Delete
Console.WriteLine("Delete the Product");
db.Remove(product);
db.SaveChanges();

