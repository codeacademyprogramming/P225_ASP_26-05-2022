using Microsoft.AspNetCore.Mvc;
using P22526052022V1.DAL;
using P22526052022V1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P22526052022V1.Controllers
{
    public class BrandController : Controller
    {
        //private readonly List<Brand> _brands;
        private readonly AppDbContext _context;

        public BrandController(AppDbContext context)
        {
            _context = context;

            //_brands = new List<Brand>
            //{
            //    new Brand{Id=1,Name="Ford"},
            //    new Brand{Id=2,Name="Mercedes"},
            //    new Brand{Id=3,Name="BMW"},
            //};
        }

        public IActionResult Index()
        {
            //return View(_brands);

            List<Brand> brands = _context.Brands.ToList();

            return View(brands);
        }
    }
}
