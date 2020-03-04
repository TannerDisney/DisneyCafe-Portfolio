using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using DisneyCafe.Models.Database;
using DisneyCafe.Data;

namespace DisneyCafe.Controllers
{
    [Authorize(Roles = "Administrator, Owner")]
    public class AuthorizedController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AuthorizedController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            List<Desserts> desserts = await DessertsDb.GetDessertsAsync(_context);
            return View(desserts);
        }

        public IActionResult OrderForm()
        {
            return View();
        }

        public async Task<IActionResult> OrderForm(Desserts dessert)
        {
            if (ModelState.IsValid)
            {
                TempData["WasSuccessful"] = "You have successfully ordered items for DisneyCafe";
                return RedirectToAction("Index", "Home");
            }

            return View(dessert);
        }
    }
}