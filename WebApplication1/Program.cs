using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddMemoryCache();
            builder.Services.AddSession();
            // Add services to the container.
            builder.Services.AddControllersWithViews().AddNewtonsoftJson();

            builder.Services.AddDbContext<SportsContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("SportsContext")));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseSession();

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();
            
            app.MapControllerRoute(
                name: "olympics",
                pattern: "Olympics/{SelectedGame}/{SelectedCategory?}",
                defaults: new { controller = "Olympics", action = "Index" });
            
            app.MapControllerRoute(
                name: "details",
                pattern: "Olympics/Details/{id}/{SelectedGame?}/{SelectedCatergory?}",
                defaults: new { controller = "Olympics", action = "Details" });


            app.MapControllerRoute(
               name: "default",
               pattern: "{controller=Olympics}/{action=Index}/{id?}");

            

            app.Run();
        }
    }
}
