using CQRS.CQRS.Handlers;
using CQRS.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CQRS
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers().AddNewtonsoftJson(opt =>
            {
                opt.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
            });

            builder.Services.AddMediatR(typeof(Program));

            //builder.Services.AddScoped<GetStudentByIdQueryHandler>();
            //builder.Services.AddScoped<GetAllStudentQueryHandler>();
            //builder.Services.AddScoped<CreateStudentCommandHandler>();
            //builder.Services.AddScoped<DeleteStudentByIdCommandHandler>();
            //builder.Services.AddScoped<UpdateStudentCommandHandler>();


            builder.Services.AddDbContext<StudentContext>(opt =>
            {
                opt.UseSqlServer("server=DESKTOP-1R04VTM\\TyenucDB; database = StudentDb; integrated security = true; TrustServerCertificate=True;");
            });


            var app = builder.Build();
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.MapGet("/", () => "Hello World!");

            app.Run();
        }
    }
}