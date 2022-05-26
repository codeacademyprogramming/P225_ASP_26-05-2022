using Microsoft.AspNetCore.Mvc;
using P22526052022V1.DAL;
using P22526052022V1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P22526052022V1.Controllers
{
    public class CarController : Controller
    {
        //private readonly List<Brand> _brands;
        //private readonly List<Car> _car;

        private readonly AppDbContext _context;

        public CarController(AppDbContext context)
        {
            _context = context;

            //_brands = new List<Brand>
            //{
            //    new Brand{Id=1,Name="Ford"},
            //    new Brand{Id=2,Name="Mercedes"},
            //    new Brand{Id=3,Name="BMW"}
            //};

            //_car = new List<Car>
            //{
            //    new Car{Id=1, Name="Mustang",EngineType="Mechanic",Year=2022,BrandId = 1},
            //    new Car{Id=2, Name="Fox",EngineType="Auto",Year=2012,BrandId = 1},
            //    new Car{Id=3, Name="Chelbi",EngineType="Auto",Year=2010,BrandId = 1},
            //    new Car{Id=4, Name="SLS",EngineType="Mechanic",Year=2022,BrandId = 2},
            //    new Car{Id=5, Name="CLK",EngineType="AUTO",Year=2020,BrandId = 2},
            //    new Car{Id=6, Name="Dord Goz",EngineType="Mechanic",Year=2022,BrandId = 2},
            //    new Car{Id=7, Name="X5",EngineType="Mechanic",Year=2022,BrandId = 3},
            //    new Car{Id=8, Name="Troyka",EngineType="Mechanic",Year=2022,BrandId = 3},
            //};
        }

        public IActionResult Index(int? id)
        {
            if (id == null)
            {
                return View(_context.Cars.ToList());
            }

            if (!_context.Brands.Any(b => b.Id == id))
            {
                return NotFound();
            }

            return View(_context.Cars.Where(c => c.BrandId == id).ToList());

            

            //if (!_brands.Exists(b=>b.Id == id))
            //{
            //    return NotFound();
            //}

            //return View(_car.FindAll(c=>c.BrandId == id));
        }

        public IActionResult Detail(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }

            if (!_context.Cars.Any(c => c.Id == id))
            {
                return NotFound();
            }

            //if (!_car.Exists(c=>c.Id == id))
            //{
            //    return NotFound();
            //}

            //return View(_car.Find(c=>c.Id == id));\
            return View(_context.Cars.FirstOrDefault(c => c.Id == id));
        }
    }
}
