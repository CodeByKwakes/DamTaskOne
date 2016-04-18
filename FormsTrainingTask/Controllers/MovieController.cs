using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FormsTrainingTask.Models;

namespace FormsTrainingTask.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        private static Movies movies = new Movies();
        public ActionResult Index()
        {
            return View(movies.movieList);
        }

        // Add a Movie 
        public ActionResult MovieAdd()
        {
            return View();
        }
        [HttpPost]
        public ActionResult MovieAdd(MovieModel movieModel)
        {
            movies.CreateMovie(movieModel);
            return View("Index", movies.movieList);
        }

        // Details View
        [HttpGet]
        public ActionResult Details(int id)
        {
            return View(movies.movieList.FirstOrDefault(x => x.Id == id));
        }
        [HttpPost]
        public ActionResult Details()
        {
            return View("Index", movies.movieList);
        }
        //Action for Edit View
        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View(movies.movieList.FirstOrDefault(x => x.Id == id));
        }
        [HttpPost]
        public ActionResult Edit(MovieModel movieModel)
        {
            movies.UpdateMovie(movieModel);
            return View("Index", movies.movieList);
        }

        //Action for Delete View
        [HttpGet]
        public ActionResult Delete(int id)
        {
            return View(movies.movieList.FirstOrDefault(x => x.Id == id));
        }
        [HttpPost]
        public ActionResult Delete(MovieModel movieModel)
        {
            movies.DeleteMovie(movieModel);
            return View("Index", movies.movieList);
        }

}

}
