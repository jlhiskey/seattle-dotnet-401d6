using EFStudentEnrollment.Models;
using Microsoft.EntityFrameworkCore;

namespace EFStudentEnrollment.Data
{
    public class SchoolEnrollmentDbContext : DbContext
    {
        public SchoolEnrollmentDbContext(DbContextOptions<SchoolEnrollmentDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Add our composite key associations
            modelBuilder.Entity<CourseEnrollments>().HasKey(ce => new { ce.CourseID, ce.StudentID });

            modelBuilder.Entity<Student>().HasData(
                new Student
                {
                    ID = 1,
                    FirstName = "Jack",
                    LastName = "Shepard",
                    Age = 35
                },
                new Student
                {
                    ID = 2,
                    FirstName = "Kate",
                    LastName = "Austin",
                    Age = 30
                },

                new Student
                {
                    ID = 3,
                    FirstName = "Hermione",
                    LastName = "Granger",
                    Age = 20
                }
                );

            modelBuilder.Entity<Course>().HasData(
                new Course
                {
                    ID = 1,
                    Name = ".NET",
                    Technology = Tech.DotNet,
                    Price = 100.00m
                },

                   new Course
                   {
                       ID = 2,
                       Name = "Python",
                       Technology = Tech.Python,
                       Price = 100.00m
                   },

                   new Course
                   {
                       ID = 3,
                       Name = "Android Development",
                       Technology = Tech.Java,
                       Price = 150m
                   }

                );

        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseEnrollments> CourseEnrollments { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Transcript> Transcripts { get; set; }


    }
}
