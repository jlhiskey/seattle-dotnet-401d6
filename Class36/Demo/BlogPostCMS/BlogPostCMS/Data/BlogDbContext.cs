using BlogPostCMS.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogPostCMS.Data
{
    public class BlogDbContext : DbContext
    {
        public BlogDbContext(DbContextOptions<BlogDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>().HasData(
                new Post
                {
                    ID = 1,
                    Title = "Cats Rule",
                    Description = "Cats are the best!"
                },
                new Post
                {
                    ID = 2,
                    Title = "Coffee drinkers live longer lives",
                    Description = "It's true, the internet said so"
                },

                new Post
                {
                    ID = 3,
                    Title = "Learning is Fun!",
                    Description = "We all have fun learning. Make our brains exercise!!"
                },

                new Post
                {
                    ID = 4,
                    Title = "Disney Addictions",
                    Description = "Disney Addiction is a real thing. We all love Mickey! He is the happiest mouse on earth!"
                },

                new Post
                {
                    ID = 5,
                    Title = "Code Fellows .NET Cohort 6",
                    Description = "Cohort 6 is the best cohort of 2019!"
                }
                );
        }

        public DbSet<Post> Posts { get; set; }
    }
}
