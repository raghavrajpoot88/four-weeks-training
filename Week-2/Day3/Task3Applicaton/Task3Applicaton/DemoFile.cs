using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3Applicaton
{
    public class DemoFile
    {
        // The element type of the data source.
        public class Product
        {
            public int ID { get; set; }
            public string? Name { get; set; }
            public int Price { get; set; }

        }

        public static List<Product> GetProducts()
        {
            // Use a collection initializer to create the data source. Note that each element
            //  in the list contains an inner sequence of scores.
            List<Product> products = new List<Product>
                {
               new Product { ID=111, Name="Mobile",     Price=20000},
               new Product { ID=112, Name="Charger",    Price=234},
               new Product { ID=113, Name="ToolKit",    Price=509},
               new Product { ID=114, Name="Case",       Price=58},
               new Product { ID=115, Name="Glassgard",  Price=78},
            };

            return products;
        }
        static void Main(string[] args)
        {
            // Create the data source.
            List<Product> products = GetProducts();

            // Create the query.
            IEnumerable<Product> sortedProducts =
                from product in products
                orderby product.Price ascending, product.Name ascending
                select product;

            // Execute the query.
            Console.WriteLine("sortedProducts:");
            foreach (Product product in sortedProducts)
                Console.WriteLine(product.Price + " " + product.Name);

            List<Product> productsByName = GetProducts();

            IEnumerable<Product> sortedByName=
                from product in productsByName
                orderby product.Name ascending
                select product;

            Console.WriteLine("Sorted By Name");
            foreach (Product product in sortedByName)
                Console.WriteLine(product.Name);


            // Keep the console window open in debug mode
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
