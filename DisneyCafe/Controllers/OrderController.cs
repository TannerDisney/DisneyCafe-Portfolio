using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DisneyCafe.Data;
using DisneyCafe.Models;
using DisneyCafe.Models.Database;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DisneyCafe.Controllers
{
    public class OrderController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IHttpContextAccessor _accessor;
        private readonly UserManager<IdentityUser> _userManager;
        public OrderController(ApplicationDbContext context, IHttpContextAccessor accessor, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _accessor = accessor;
            _userManager = userManager;
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
            var uSearch = await _userManager.GetUserAsync(HttpContext.User);
            ApplicationUser user = new ApplicationUser()
            { 
                Id = uSearch.Id,
                Email = uSearch.Email,
                UserName = uSearch.UserName
            };
            if (!ModelState.IsValid)
            {
                Console.WriteLine("Completed");
                await OrderDb.CompleteOrder(_context, info, user);
                CartHelper.ClearCookie(_accessor);
                return RedirectToAction("Index", "Home");
            }
            return View(info);
        }
    }
}