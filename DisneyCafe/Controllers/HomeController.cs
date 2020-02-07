using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DisneyCafe.Models;
using Microsoft.Extensions.Configuration;

namespace DisneyCafe.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _config;

        public HomeController(ILogger<HomeController> logger, IConfiguration c)
        {
            _logger = logger;
            _config = c;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Contact(ContactForm contact)
        {
            if (ModelState.IsValid)
            {
                string autoMsg = $"<strong>This message was sent via disneycafe.online and from the email address {contact.EmailAddress}</strong><br>" + contact.Body;
                await SendGridEmailHelper.SendEmailToUser(_config, "INSERT COPERATE EMAIL", contact.Subject, autoMsg);
                TempData["WasSuccessful"] = "Your email was sent to DisneyCafe successfully";
                return RedirectToAction("Index");
            }

            return View(contact);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
