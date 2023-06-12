using Demo2Application.Model;

namespace Demo2Application
{
   
        public class Program
        {
            public static void Main(string[] args)
            {

                var builder = WebApplication.CreateBuilder(args);


                builder.Services.AddControllers();
                builder.Services.AddDbContext<BookStoreContext>(opt =>
                    opt.UseInMemoryDatabase("Server=localhost\\MSSQLSERVER01;Database=master;Trusted_Connection=True;"));

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