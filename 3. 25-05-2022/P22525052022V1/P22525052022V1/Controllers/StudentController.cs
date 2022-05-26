using Microsoft.AspNetCore.Mvc;
using P22525052022V1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P22525052022V1.Controllers
{
    public class StudentController : Controller
    {
        private readonly List<Student> _students;

        public StudentController()
        {
            _students = new List<Student>
            {
                new Student{ Id=2,Name="Vusal", SurName="Imanov", Age=21,AvgPoint=65, GroupId = 1},
                new Student{ Id=3,Name="Maqsud", SurName="Seferov", Age=18,AvgPoint=55, GroupId = 1},
                new Student{ Id=4,Name="Yamil", SurName="Layicov", Age=35,AvgPoint=67, GroupId = 1},
                new Student{ Id=5,Name="Ismayil", SurName="Cabbarli", Age=21,AvgPoint=84, GroupId = 2},
                new Student{ Id=6,Name="Abdulla", SurName="Rehimli", Age=27,AvgPoint=88, GroupId = 2},
                new Student{ Id=7,Name="Eltac", SurName="MelikMemmedov", Age=21,AvgPoint=77, GroupId = 3},
                new Student{ Id=8,Name="Ishaq", SurName="Yaqublu", Age=23,AvgPoint=78, GroupId = 3},
                new Student{Id = 1, Name = "Murad",SurName="Haqverdiyev",Age = 18,AvgPoint = 55, GroupId = 3}

            };
        }
        public IActionResult Index(int? id)
        {
            if (id == null)
            {
                return View(_students);
            }

            if (!_students.Exists(s=>s.GroupId == id))
            {
                TempData["Error"] = $"{id} Id-li Telebe Tapilmadi";
                return RedirectToAction("error", "home");
            }

            List<Student> students = _students.FindAll(s => s.GroupId == id);

            return View(students);
        }

        public IActionResult Detail(int? id)
        {
            if (id == null)
            {
                TempData["Error"] = $"Id NULL Ola Bilemz";
                return RedirectToAction("error", "home");
            }

            if (!_students.Exists(s=>s.Id == id))
            {
                TempData["Error"] = $"{id} Id-li Telebe Tapilmadi";
                return RedirectToAction("error", "home");
            }

            Student student = _students.Find(s => s.Id == id);

            return View(student);
        }
    }
}
