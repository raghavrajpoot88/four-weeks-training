using Microsoft.EntityFrameworkCore;

namespace BookStoreAPI.Model
{
    public class BookStoreContext: DbContext
    {
        public BookStoreContext(DbContextOptions<BookStoreContext> options):base (options)
        {
        }
        public DbSet<BookStore> bookStores { get; set; } = null!;




        //public BookStoreContext()
        //{
        //    var folder = Environment.SpecialFolder.LocalApplicationData;
        //    var path = Environment.GetFolderPath(folder);
        //    DbPath = System.IO.Path.Join(path, "blogging.db");
        //}

        //// The following configures EF to create a Sqlite database file in the
        //// special "local" folder for your platform.
        //protected override void OnConfiguring(DbContextOptionsBuilder options)
        //    => options.UseSqlServer($"Data Source=DESKTOP-CD3OO1U;Initial Catalog=BookStoreDB;TrustServerCertificate=True;");
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddDbContext<BookStoreContext>(
                options => options.UseSqlServer(("BookstoreDB")));
        }
        //public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        //{
        //    if (env.IsDevelopment())
        //    {
        //        app.UseDeveloperExceptionPage();
        //        //app.UseExceptionHandler("/error-local-development");
        //    }
        //    else
        //    {
        //        app.UseExceptionHandler("/error");
        //    }
        //}
    }

}
