using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DisneyCafe.Data;
using DisneyCafe.Models;
using DisneyCafe.Models.Database;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DisneyCafe.Controllers
{
    public class OrderController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IHttpContextAccessor _accessor;
        public OrderController(ApplicationDbContext context, IHttpContextAccessor accessor)
        {
            _context = context;
            _accessor = accessor;
        }
        public async Task<IActionResult> Catalog()
        {
            List<Desserts> desserts = await DessertsDb.GetDessertsAsync(_context);
            return View(desserts);
        }

        public IActionResult CustomerInfo()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CustomerInfo(CustomerInfomation info)
        {
            if (!ModelState.IsValid)
            {
                Console.WriteLine("Completed");
                await OrderDb.CompleteOrder(_context, _accessor, info, HttpContext.User.Identity.Name);
                return RedirectToAction("Index", "Home");
            }
            return View(info);
        }
    }
}