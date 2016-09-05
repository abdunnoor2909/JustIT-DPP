using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(int id = 1)
        {
            ViewBag.NumberOftimes = id;
            return View();
        }

        public ActionResult About(string myName = "" , int myNumber = 1 )
        {
            ViewBag.Message = "Hello " + myName + " you typed in a number " + myNumber;

            return View();
        }

        public ActionResult Contact(int id=5)
        {
            ViewBag.Message = "You chose the number " + id;

            return View();
        }
    }
}