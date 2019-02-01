using Microsoft.EntityFrameworkCore;
using MusicPlayerAPI.Model;

namespace MusicPlayerAPI.Data
{
    public class MusicDbContext : DbContext
    {
        public MusicDbContext(DbContextOptions<MusicDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Song>().HasData(
                new Song
                {
                    ID = 1,
                    Title = "Shake it Off",
                    Artist = "Taylor Swift"
                },
                new Song
                {
                    ID = 2,
                    Title = "Hakuna Matata",
                    Artist = "The Lion King"
                }

                );
        }

        public DbSet<Song> Songs { get; set; }
    }
}
