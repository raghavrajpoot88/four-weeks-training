using Microsoft.EntityFrameworkCore;
using BookStoreAPI.Model;


namespace BookStoreAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
          
            var builder = WebApplication.CreateBuilder(args);


            builder.Services.AddControllers();
            //builder.Services.AddDbContext<BookStoreContext>(opt =>
            //    opt.UseSqlServer(builder.Configuration.GetConnectionString("BookstoreDB")));

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}