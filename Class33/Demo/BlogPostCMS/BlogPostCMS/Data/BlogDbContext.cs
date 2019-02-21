using BlogPostCMS.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogPostCMS.Data
{
    public class BlogDbContext : DbContext
    {
        public BlogDbContext(DbContextOptions<BlogDbContext> options) : base(options)
        {

        }

        public DbSet<Post> Posts { get; set; }
    }
}
