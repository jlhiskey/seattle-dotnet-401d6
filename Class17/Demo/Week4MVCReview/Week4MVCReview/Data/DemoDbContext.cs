using Microsoft.EntityFrameworkCore;
using Week4MVCReview.Models;

namespace Week4MVCReview.Data
{
    public class DemoDbContext : DbContext
    {
        public DemoDbContext(DbContextOptions<DemoDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // set our composite keys (if we had any)

            modelBuilder.Entity<Course>().HasData(
                new Course
                {
                    ID = 1,
                    Name = "Basket Weaving",
                    Price = 100
                },
                new Course
                {
                    ID = 2,
                    Name = "RacketBall",
                    Price = 50
                }
                );

            modelBuilder.Entity<Student>().HasData(
                new Student
                {
                    ID = 1,
                    FirstName = "Barbie",
                    LastName = "Doll",
                    Age = 50
                },
                new Student
                {
                    ID = 2,
                    FirstName = "Donald",
                    LastName = "Duck",
                    Age = 80
                }
                );
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }

    }
}
