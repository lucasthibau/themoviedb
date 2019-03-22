using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TheMovieDb.Models
{
    public class ListGenres
    {
        public List<GenresModel> genres { get; set; }
    }
    public class GenresModel
    {
        public int id { get; set; }
        public string name { get; set; }
    }
}