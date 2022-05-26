using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using P22525052022V1.Models;

namespace P22525052022V1.Controllers
{
    public class HomeController : Controller
    {
        private readonly List<Group> _groups;
        public HomeController()
        {
            _groups = new List<Group>
            {
                new Group{Id = 1, Name="P225"},
                new Group{Id = 2, Name="P125"},
                new Group{Id = 3, Name="P309"},
            };

            
        }

        public IActionResult Index()
        {
            return View(_groups);
        }

        public IActionResult Detail(int? id)
        {
            //if (id == null)
            //{
            //    TempData["Error"] = "Id NULL Ola Bilmez";
            //    return RedirectToAction("Error");
            //}

            //if (!_students.Exists(s => s.Id == id))
            //{
            //    TempData["Error"] = $"{id} Id-li Telebe Tapilmadi";
            //    return RedirectToAction("Error");
            //}

            //ViewBag.id = id;

            //Student student = _students.Find(s => s.Id == id);

            //return View(student);

            return View();
        }

        public IActionResult About(int id, string name)
        {
            TempData["id"] = id;
            TempData["name"] = name;

            Teacher teacher = new Teacher
            {
                Name = "Hamid",
                SurName = "Mammadov",
                Age = 32,
                Experiance = 5
            };

            return View(teacher);
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
