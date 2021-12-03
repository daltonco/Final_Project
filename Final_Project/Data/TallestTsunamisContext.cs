
using Final_Project.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project.Data
{
    public class TallestTsunamisContext : DbContext
    {
        public TallestTsunamisContext(DbContextOptions<TallestTsunamisContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Tsunami>().HasData(
                new Tsunami { Id = 1, Element = "Water", Type = "Megatsunami", HeightInFeet = 1720, Where = "Alaska", Year = 1958 },
                new Tsunami { Id = 2, Element = "Water", Type = "Tsunami", HeightInFeet = 820, Where = "Washington", Year = 1980 },
                new Tsunami { Id = 3, Element = "Water", Type = "Tsunami", HeightInFeet = 771, Where = "Italy", Year = 1963 },
                new Tsunami { Id = 4, Element = "Water", Type = "Megatsunami", HeightInFeet = 633, Where = "Alaska", Year = 2015 },
                new Tsunami { Id = 5, Element = "Water", Type = "Tsunami", HeightInFeet = 490, Where = "Alaska", Year = 1936 }

                );
        }

        public DbSet<Tsunami> TallestTsunamis { get; set; }
    }
}
