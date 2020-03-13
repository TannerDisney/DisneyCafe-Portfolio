using System;
using System.Collections.Generic;
using System.Text;
using DisneyCafe.Data.SeedingData;
using DisneyCafe.Models;
using DisneyCafe.Models.Database;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DisneyCafe.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Desserts> Desserts { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<CustomerInfomation> CustomerInfomations { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.SeedDesserts();
            base.OnModelCreating(builder);
        }
    }
}
