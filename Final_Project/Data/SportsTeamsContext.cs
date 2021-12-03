using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Final_Project.Controllers;

namespace Final_Project.Data
{
    public class SportsTeamsContext : DbContext
    {
        public SportsTeamsContext(DbContextOptions<SportsTeamsContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Teams>().HasData(
    new Teams { Id = 1, Name = "Arsenal FC", Sport = "Soccer", Country = "England", League = "Premier League", Titles = 3},
    new Teams { Id = 2, Name = "Bengals", Sport = "Football", Country = "USA", League = "NFL", Titles = 0},
    new Teams { Id = 3, Name = "Browns", Sport = "Football", Country = "USA", League = "NFL", Titles = 4 },
    new Teams { Id = 4, Name = "Reds", Sport = "Baseball", Country = "USA", League = "MLB", Titles = 5 }
    );
        }

        public DbSet<Teams> BestTeamsTwo { get; set; }
    }
}
    