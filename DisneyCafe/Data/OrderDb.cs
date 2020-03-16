using DisneyCafe.Models;
using DisneyCafe.Models.Database;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DisneyCafe.Data
{
    public static class OrderDb
    {
        public static async Task CompleteOrder(ApplicationDbContext context, IHttpContextAccessor accessor, CustomerInfomation info, string username)
        {
            ApplicationUser user = new ApplicationUser()
            { Email = username };
            List<Desserts> desserts = CartHelper.GetDesserts(accessor);
            Orders order = new Orders()
            {
                OrderNumber = GenerateCode.GenerateOrderNumber(),
                User = user,
                Desserts = desserts,
                CustomerInfomation = info
            };
            await context.AddAsync(order);
            await context.SaveChangesAsync();
        }
    }
}
