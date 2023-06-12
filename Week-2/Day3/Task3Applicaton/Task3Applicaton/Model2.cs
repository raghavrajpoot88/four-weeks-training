using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3Applicaton
{
    public class Model2
    {
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
        public class CategoryFinal
        {
            public int Id { get; set; }
            public string? FName { get; set; }
            public string? FSerialNo { get; set; }

            //public int BlogId { get; set; }
            //public Product Blog { get; set; }
        }
    }
}
