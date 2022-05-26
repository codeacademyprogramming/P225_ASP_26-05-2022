using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P22524052022.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(string name,string surname,byte age)
        {
            if (!string.IsNullOrWhiteSpace(name) && !string.IsNullOrWhiteSpace(surname) && age>0)
            {
                var obj = new
                {
                    name = name,
                    surname = surname,
                    age = age
                };

                //JsonResult jsonResult = new JsonResult(obj);
                //return jsonResult;
                return Json(obj);
            }
            else if(!string.IsNullOrWhiteSpace(name))
            {
                //ContentResult contentResult = new ContentResult();
                //contentResult.Content = $"Hello P225 Code Academy {name} {surname} {age}";
                //return contentResult;

                return Content($"Hello P225 Code Academy {name} {surname} {age}");
            }
            else
            {
                //ViewResult viewResult = new ViewResult();
                //viewResult.ViewName = "Test";
                //return viewResult

                //return View("Test");

                return View();
            }
        }

        public IActionResult Detail(string name, string surname,byte age)
        {
            //ViewData["name"] = name;
            //ViewData["sarname"] = surname;
            //ViewData["Age"] = age;


            //ViewBag.surname = surname;
            //ViewBag.age = age;
            //ViewBag.name = name;


            //ViewData["age"] = 55;

            //var a = ViewBag.age;
            //var b = ViewData["age"];


            //ViewData["name"] = name;
            //ViewBag.surname = surname;

            //TempData["age"] = age.ToString();

            //return RedirectToAction("Check");
            return View();
        }

        public IActionResult Check()
        {

            return View();
        }
    }
}
