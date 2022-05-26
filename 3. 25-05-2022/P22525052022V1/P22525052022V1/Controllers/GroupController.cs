using Microsoft.AspNetCore.Mvc;
using P22525052022V1.Models;
using P22525052022V1.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P22525052022V1.Controllers
{
    public class GroupController : Controller
    {
        private readonly List<Group> _groups;
        private readonly List<Student> _students;

        public GroupController()
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

            _groups = new List<Group>
            {
                new Group{Id = 1, Name="P225"},
                new Group{Id = 2, Name="P125"},
                new Group{Id = 3, Name="P309"},
            };
        }


        public IActionResult Index()
        {
            GroupViewModel test = new GroupViewModel
            {
                Students = _students,
                Groups = _groups
            };

            return View(test);
        }
    }

}
