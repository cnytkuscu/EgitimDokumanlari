using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.DataAccess.Contexts;

namespace ToDoApp.Business.DependencyResolvers.Microsoft
{
    public static class DependencyExtension
    {
        public static void AddDependencies(this IServiceCollection services)
        {
            services.AddDbContext<ToDoContext>(opt =>
            {
                opt.UseSqlServer("server=(localdb)\\mssqllocaldb; database = TodoDb; integrated security = true");
            });
        }
    }
}
