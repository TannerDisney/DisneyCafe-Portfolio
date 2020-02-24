using System;
using System.Collections.Generic;
using System.Text;
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
        public DbSet<Ingredients> Ingredients { get; set; }
        public DbSet<Desserts> Desserts { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
    }
}
