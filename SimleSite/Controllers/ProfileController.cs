using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SimleSite.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Title = "Title";
            ViewBag.skypename = "newSkypeName";
            return View();
        }
    }
}