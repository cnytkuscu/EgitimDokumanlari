using Microsoft.EntityFrameworkCore;

namespace CQRS.Data
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options) : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(new Student[]
            {
                new Student()
                {
                    Name = "Cuneyt",
                    Age = 27,
                    Surname = "Kuscu",
                    Id = 1
                },
                new Student()
                {
                    Name = "Almira",
                    Age = 26,
                    Surname = "Kuscu",
                    Id = 2
                }
            });
            base.OnModelCreating(modelBuilder);
        }
    }
}
