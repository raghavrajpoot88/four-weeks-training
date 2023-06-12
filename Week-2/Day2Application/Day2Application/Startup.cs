using Microsoft.Extensions.Configuration;

namespace Day2Application
{
    public class Startup
    {

        public Startup(IConfiguration configuration)
        {
            configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            // Configure services here
            // Example:
            services.AddControllersWithViews();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "Default",
                    pattern: "{controller=Home}/{action=Index}/{id?}") ;
            });
        }
    }
}
