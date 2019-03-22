using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TheMovieDb.APICalls;

namespace TheMovieDb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var genres = TheMovieDbApi.GetGenres();
            var listMovies = TheMovieDbApi.DiscoverMovies();
            ViewBag.Title = "Página principal";
            return View(Tuple.Create(genres, listMovies));
        }
    }
}