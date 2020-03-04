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

        public async Task<IActionResult> OrderForm(int id)
        {
            Desserts dessert = await DessertsDb.GetDessertsById(_context, id);
            return View(dessert);
        }

        [HttpPost]
        public async Task<IActionResult> OrderForm(Desserts d)
        {
            if (ModelState.IsValid)
            {
                await DessertsDb.UpdateDessertAsync(_context, d);
                TempData["WasSuccessful"] = "You have successfully ordered items for DisneyCafe";
                return RedirectToAction("Index", "Home");
            }

            return View(d);
        }

    }
}