using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ToDoApp.Business.Interfaces;
using ToDoApp.Business.Services;
using ToDoApp.DataAccess.Contexts;
using ToDoApp.DataAccess.UnitOfWork;

namespace ToDoApp.Business.DependencyResolvers.Microsoft
{
    public static class DependencyExtension
    {
        public static void AddDependencies(this IServiceCollection services)
        {

            services.AddScoped<IUoW, UoW>();
            services.AddScoped<IWorkService, WorkService>();

            services.AddDbContext<ToDoContext>(opt =>
            {
                opt.UseSqlServer("server=(localdb)\\mssqllocaldb; database = TodoDb; integrated security = true");
            });
        }
    }
}
