using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SimleSite.Controllers
{
    public class PricingController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Title = "Payment page";
            return View();
        }
    }
}