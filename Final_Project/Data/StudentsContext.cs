using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Final_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace Final_Project.Data
{
    public class StudentsContext : DbContext
    {
        public StudentsContext(DbContextOptions<StudentsContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder) 
        {
            builder.Entity<Students>().HasData(
                new Students { Id = 1, FirstName = "David", LastName = "Draginoff", Birthday = "6-20-200", Major = "IT CyberSecurity", Year = "junior" },
                new Students { Id = 2, FirstName = "Colton", LastName = "Dalton", Birthday = "4-4-1999", Major = "IT Software Dev", Year = "junior" },
                new Students { Id = 3, FirstName = "Alex", LastName = "Gajic", Birthday = "3-18-2000", Major = "IT ", Year = "Senior" },
                new Students { Id = 4, FirstName = "Samuel", LastName = "Untener", Birthday = "5-1-2001", Major = "IT Game Development and Simulation", Year = "junior" }

                );
        }

        public DbSet<Students> StudentInfo { get; set; }
    }
}
