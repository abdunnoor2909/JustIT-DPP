using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebPartyTutoriol.Models;

namespace WebPartyTutoriol.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
        
            return View();
        }

        public ViewResult RsvpForm()
        {
            return View();
        }
        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestresponse)
        {
            
            if (ModelState.IsValid)
            {
                return View("Thanks", guestresponse);

            }
            else
            {
                return View();
            }
        }
    }
}