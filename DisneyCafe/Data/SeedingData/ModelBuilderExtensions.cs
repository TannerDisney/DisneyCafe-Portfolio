using DisneyCafe.Models.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DisneyCafe.Data.SeedingData
{
    public static class ModelBuilderExtensions
    {
        /// <summary>
        /// Extension method to seed Desserts table with data
        /// </summary>
        /// <param name="model"></param>
        public static void SeedDesserts(this ModelBuilder model)
        {
            model.Entity<Desserts>().HasData
                (
                    new Desserts
                    {
                        Id = 1,
                        Title = "Lemon Meringue Pie",
                        Description = "Pie made with a lemon custard filling, using a shortcrust pastry, with a fluffy meringue topping",
                        Price = 7.45,
                        Stock = 0
                    },
                    new Desserts
                    {
                        Id = 2,
                        Title = "Cheesecake",
                        Description = "graham cracker crust with a mixture of soft cheese, eggs, and sugar",
                        Price = 6.25,
                        Stock = 0
                    },
                    new Desserts
                    {
                        Id = 3,
                        Title = "Ube Roll",
                        Description = "Ube made into a swiss roll filled with butter, sugar, milk, and mashed ube",
                        Price = 9.65,
                        Stock = 0
                    },
                    new Desserts
                    {
                        Id = 4,
                        Title = "Chocolate Cake Pop",
                        Description = "Cake pop made with a devil chocolate cake recipe",
                        Price = 3.60,
                        Stock = 0
                    }
                );
        }
    }
}
