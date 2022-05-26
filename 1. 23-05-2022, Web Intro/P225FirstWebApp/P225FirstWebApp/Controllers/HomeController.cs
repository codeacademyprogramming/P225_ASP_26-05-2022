using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P225FirstWebApp.Controllers
{
    public class HomeController : Controller
    {

        public ViewResult Index()
        {
            ViewResult viewResult = new ViewResult();
            viewResult.ViewName = "P225FirtView";

            return viewResult;
        }

        //public ContentResult Index()
        //{
        //    ContentResult contentResult = new ContentResult();
        //    contentResult.Content = "P225 Content Result";

        //    return contentResult;
        //}

        //public JsonResult Index()
        //{
        //    var obj = new
        //    {
        //        name = "Hamid",
        //        surname = "Mammadov"
        //    };


        //    JsonResult jsonResult = new JsonResult(obj);

        //    return jsonResult;
        //}

        public string Test()
        {
            //JsonResult jsonResult = new JsonResult("");
            //ViewResult viewResult = new ViewResult();
            //ContentResult contentResult = new ContentResult();
            //FileResult fileResult;

            return $"P225 First Action";
        }

        public string Test1()
        {
            return "Test 1";
        }
    }
}
