using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VideoForU.Models;
using System.Data.Entity;
using VideoForU.ViewModels;


namespace VideoForU.Controllers
{
    public class MoviesController : Controller
    {
        private readonly ApplicationDbContext _context;


        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Movies
        public ActionResult Index()
        {
            //Customer Obj created to load as well as MembershipType hence include method ,eager loading 
            var movies = _context.Movies.Include(c => c.Genre).ToList();
            return View(movies);
        }

        public ActionResult Details(int id)
        {
            var movies = _context.Movies.Include(c => c.Genre).FirstOrDefault(t => t.Id == id);
            if (movies == null)
            {
                return HttpNotFound();
            }

            return View(movies);
        }

        public ActionResult New()
        {
            var genres = _context.Genres.ToList();
            var moviesFormViewModel = new MoviesFormViewModel {Genres = genres};


            return View("MoviesForm", moviesFormViewModel);
        }

        [HttpPost]
        public ActionResult Save(Movie movie)
        {
            _context.Movies.Add(movie);
            _context.SaveChanges();
            return RedirectToAction("Index", "Movies");
        }
        [HttpPost]
        public ActionResult Create(Movie movie)
        {
            _context.Movies.Add(movie);
            _context.SaveChanges();
            return RedirectToAction("Index", "Movies");
        }
    }
}