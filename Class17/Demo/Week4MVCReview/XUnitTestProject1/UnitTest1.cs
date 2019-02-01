using Microsoft.EntityFrameworkCore;
using System.Linq;
using Week4MVCReview.Data;
using Week4MVCReview.Models;
using Week4MVCReview.Models.Services;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void CanGetNameOfCourse()
        {
            Course course = new Course();
            course.Name = "DotNet";

            Assert.Equal("DotNet", course.Name);
        }

        [Fact]
        public void CanSetNameOfCourse()
        {
            Course course = new Course();
            course.Name = "DotNet";
            course.Name = ".NET";

            Assert.Equal(".NET", course.Name);
        }

        [Fact]
        public async void CanCreateCourse()
        {
            DbContextOptions<DemoDbContext> options = new DbContextOptionsBuilder<DemoDbContext>().UseInMemoryDatabase("CreateCourse").Options;

            using (DemoDbContext context = new DemoDbContext(options))
            {
                // Arrange
                Course course = new Course();
                course.ID = 1;
                course.Name = "DotNet";
                course.Price = 15;

                //Act
                CourseService courseServices = new CourseService(context);

               await courseServices.CreateCourse(course);

                var result = context.Courses.FirstOrDefault(c => c.ID == course.ID);
                //Assert
                Assert.Equal(course, result);
            }
        }

    }
}
