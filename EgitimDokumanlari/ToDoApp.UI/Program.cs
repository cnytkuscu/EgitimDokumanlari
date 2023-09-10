using Microsoft.Extensions.FileProviders;
using ToDoApp.Business.DependencyResolvers.Microsoft;

namespace ToDoApp.UI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDependencies();
            builder.Services.AddControllersWithViews();

            // Add services to the container.
            builder.Services.AddRazorPages();

            var app = builder.Build();

            app.UseStaticFiles(new StaticFileOptions()
            {
                FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(),"node_modules")),
                RequestPath = "/node_modules"
            });
            

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
            });

            app.UseAuthorization();

            app.MapRazorPages();

            app.Run();
        }
    }
}