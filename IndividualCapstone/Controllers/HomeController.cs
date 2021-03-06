﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using IndividualCapstone.Models;

namespace IndividualCapstone.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            if (User.IsInRole("Customer"))
            {
                return RedirectToAction("Index", "Customer");
            }
            else if (User.IsInRole("Employee"))
            {
                return RedirectToAction("Index", "Employee");
            }
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        [Route("Pay")]
        public async Task<dynamic> Pay(Models.Payment p)
        {
            return await MakePayment.PayAsync(p.CardNumber, p.Month, p.Year, p.Cvc, p.Value);
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
