using Microsoft.EntityFrameworkCore;
using SoccerTeamTracker.Models;

namespace SoccerTeamTracker.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Team>().HasData(
                new Team
                {
                    Id = 1,
                    Name = "Bears",
                    Color = "Brown"
                },
                new Team 
                {
                    Id = 2, 
                    Name = "Alligators",
                    Color = "Green"
                },
                new Team 
                {
                    Id = 3,
                    Name = "Cheetahs",
                    Color = "Yellow"
                });
        }
    }
}
