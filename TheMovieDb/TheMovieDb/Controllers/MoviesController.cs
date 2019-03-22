using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TheMovieDb.APICalls;

namespace TheMovieDb.Controllers
{
    public class MoviesController : Controller
    {
        public ActionResult View(int id)
        {
            var movie = TheMovieDbApi.GetMovie(id);
            var videos = TheMovieDbApi.ListVideos(id);
            ViewBag.Title = movie.title;
            return View(Tuple.Create(movie, videos));
        }
        public ActionResult Search(string title, int page = 1)
        {
            var movieList = TheMovieDbApi.SearchMovie(title, page);
            var genres = TheMovieDbApi.GetGenres();
            ViewBag.Title = title;
            return View(Tuple.Create(movieList, genres));
        }
        public ActionResult Category(int page, int id)
        {
            var movieList = TheMovieDbApi.DiscoverMovies(page, id.ToString(), "");
            var genres = TheMovieDbApi.GetGenres();
            var genre = genres.genres.Find(x => x.id == id);
            ViewBag.Title = genre.name;
            ViewBag.id = genre.id;
            return View(Tuple.Create(movieList, genres));
        }
    }
}