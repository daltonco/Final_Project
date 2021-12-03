using Final_Project.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project.Data
{
    public class MountainsContext : DbContext
    {
        //COLTON DALTON
        public MountainsContext(DbContextOptions<MountainsContext> options) : base(options) {}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Mountain>().HasData(
                new Mountain { Id = 1, Name = "Mount Everest", HeightInFeet = 29029, Country = "Nepal", Parent = "N/A", Range = "Mahalangur Himalaya" },
                new Mountain { Id = 2, Name = "K2", HeightInFeet = 28251, Country = "Pakistan", Parent = "Mount Everest", Range = "Baltoro Karakoram" },
                new Mountain { Id = 3, Name = "Kangchenjunga", HeightInFeet = 28169, Country = "Nepal", Parent = "Mount Everest", Range = "Kangchenjunga Himalaya" },
                new Mountain { Id = 4, Name = "Lhoste", HeightInFeet = 27940, Country = "Nepal", Parent = "Mount Everest", Range = "Mahalangur Himalaya" },
                new Mountain { Id = 5, Name = "Makalu", HeightInFeet = 27838, Country = "Nepal", Parent = "Mount Everest", Range = "Mahalangur Himalaya" }
                );
        }

        public DbSet<Mountain> TallestMountains { get; set; }
    }
}
