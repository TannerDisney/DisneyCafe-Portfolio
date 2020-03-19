using DisneyCafe.Models;
using DisneyCafe.Models.Database;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DisneyCafe.Data
{
    public static class OrderDb
    {
        public static async Task CompleteOrder(ApplicationDbContext context, CustomerInfomation info, ApplicationUser user)
        {
            Orders order = new Orders()
            {
                OrderNumber = GenerateCode.GenerateOrderNumber(),
                User = user,
                CustomerInfomation = info
            };
            context.Entry(user).State = EntityState.Detached;
            await context.AddAsync(order);
            await context.SaveChangesAsync();
        }
    }
}
