using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhiteLagoon.Domain.Entities;

namespace WhiteLagoon.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Villa> Villas {get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
                new Villa
                {
                    Id = 1,
                    Name = "Yash Patel",
                    Descrition = "hello this is yash here",
                    Occupancy = 4,
                    Price=200,
                    Sqft=500
                },
                new Villa
                {
                    Id = 2,
                    Name = "Rushabh Gadhi",
                    Descrition = "hello this is Rushabh Gandhi",
                    Occupancy = 5,
                    Price = 300,
                    Sqft = 600
                }
                );
            // base.OnModelCreating(modelBuilder);
        }
    }
}
