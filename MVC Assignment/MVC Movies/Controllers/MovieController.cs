using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcMovies.Models;

namespace MvcMovies.Controllers
{
    public class MovieController : Controller
    {
        MoviesEntities me = new MoviesEntities();
        // GET: Movie
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetMoviesScaffolded()
        {
            List<MovieTable> mt = me.MovieTables.ToList();
            return View(mt);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(MovieTable MT)
        {
            me.MovieTables.Add(MT);
            me.SaveChanges();
            return RedirectToAction("GetMoviesScaffolded");
        }

        public ActionResult Details(int id)
        {
            MovieTable m = me.MovieTables.Find(id);
            return View(m);
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            MovieTable ms = me.MovieTables.Find(id);
            return View(ms);
        }
        [HttpPost]
        public ActionResult Edit(MovieTable mt)
        {
            MovieTable n = me.MovieTables.Find(mt.MovieId);
            n.MovieName = mt.MovieName;
            n.ReleaseDate = mt.ReleaseDate;
            me.SaveChanges();
            return RedirectToAction("GetMoviesScaffolded");
        }
        public ActionResult Delete(int id)
        {
            MovieTable md = me.MovieTables.Find(id);
            me.MovieTables.Remove(md);
            me.SaveChanges();
            return RedirectToAction("GetMoviesScaffolded");
        }
    }
}
   