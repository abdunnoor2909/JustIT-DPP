using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCExample.Models;

namespace MVCExample.Controllers
{
    public class HomeController : Controller
    {
        List<Album> albums = new List<Album>();
        // GET: Home
        public ActionResult Index()
        {
            Album album1 = new Album("Dark Side of the moon", "Pink Floyd", "Vinyl", 9.99m);
            albums.Add(album1);

            Album album2 = new Album("Tubalar bells", "Mike Oldfield", "Vinyl", 10.99m);
            albums.Add(album2);

            Album album3 = new Album("tubalr car", "Mike Newfield", "classic", 12.99m);
            albums.Add(album2);
            return View(albums);
        }
    }
}