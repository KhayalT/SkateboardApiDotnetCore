using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete
{
    public class SkateboardContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-72FTU3Q\SQLEXPRESS01;Database=Skateboard;Trusted_Connection=true");
        }

        public DbSet<Skateboard> Skateboards { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<SkateboardType> SkateboardTypes { get; set; }
    }
}
