using Microsoft.AspNetCore.Mvc;
using SablonWebApp.Data;
using SablonWebApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SablonWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly MovieContext _context;
        public HomeController(MovieContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            //Movie m = new Movie
            //{
            //    Title = "Movie 3",
            //    Description = "acıklma 3",
            //    ImageUrl = "1.jpg",
            //    GenreId = 5
            //};
            //_context.Movies.Add(m);
            //_context.SaveChanges();



            var list = _context.Movies.ToList();
            return View();
        }
    }
}
