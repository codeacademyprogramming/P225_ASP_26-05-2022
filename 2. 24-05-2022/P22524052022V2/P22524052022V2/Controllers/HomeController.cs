using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P22524052022V2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Detail(int? id,string name,string surname)
        {
            if (id == null)
            {
                TempData["Error"] = "Id Deyeri Null Ola Bilmez";
                return RedirectToAction("Error");
            }

            if (id > 5)
            {
                TempData["Error"] = "Id Deyeri 5-den Boyuk Ola Bilmez";
                return RedirectToAction("Error");
            }

            ViewBag.Id = id;
            ViewBag.name = name;
            ViewBag.surname = surname;

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
