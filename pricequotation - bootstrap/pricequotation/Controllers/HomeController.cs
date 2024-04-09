using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using pricequotation.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace pricequotation.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        // HttpGet for Rezor component
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Total = 0;
            ViewBag.DisAmt = 0;
            return View();
        }
        // Httppost for Rezor component
        [HttpPost]
        public IActionResult Index(PriceQuotaionModelForCalc cal)
        {
            if (ModelState.IsValid)
            {
                ViewBag.DisAmt = cal.CalcDisAmt();
                ViewBag.Total = cal.CalcTotal();
            }
            else
            {
                ViewBag.Total = 0;
                ViewBag.DisAmt = 0;
            }
            return View(cal);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
