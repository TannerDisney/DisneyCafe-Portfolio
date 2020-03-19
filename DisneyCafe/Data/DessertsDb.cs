using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DisneyCafe.Models.Database;
using Microsoft.EntityFrameworkCore;

namespace DisneyCafe.Data
{
    public static class DessertsDb
    {
        public static async Task<List<Desserts>> GetDessertsAsync(ApplicationDbContext context)
        {
            List<Desserts> desserts =
                await (from d in context.Desserts
                       select d).AsNoTracking().ToListAsync();
            return desserts;
        }

        public static async Task<Desserts> GetDessertsById(ApplicationDbContext context, int id)
        {
            Desserts dessert =
                await (from d in context.Desserts
                       where d.Id == id
                       select d).AsNoTracking().SingleOrDefaultAsync();
            return dessert;
        }

        public static async Task UpdateDessertAsync(ApplicationDbContext context, Desserts dessert)
        {
            context.Update(dessert);
            await context.SaveChangesAsync();
        }
    }
}
