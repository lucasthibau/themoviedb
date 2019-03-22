using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TheMovieDb.Models
{
    public class ListMovies
    {
        public int page { get; set; }
        public int total_results { get; set; }
        public int total_pages { get; set; }
        public List<MoviesModel> results { get; set; }
    }
    public class MoviesModel
    {
        public int id { get; set; }
        public int vote_count { get; set; }
        public double vote_average { get; set; }
        public string title { get; set; }
        public string poster_path { get; set; }
        public string original_language { get; set; }
        public string original_title { get; set; }
        public List<int> genre_ids { get; set; }
        public bool adult { get; set; }
        public string overview { get; set; }
        public DateTime? release_date { get; set; }
        public int budget { get; set; }
        public List<GenresModel> genres { get; set; }
        public string homepage { get; set; }
        public string imdb_id { get; set; }
        public List<CompaniesModel> production_companies { get; set; }
        public int revenue { get; set; }
        public string status { get; set; }
        public string tagline { get; set; }

    }
    public class Videos
    {
        public int id { get; set; }
        public List<Video> results { get; set; }
    }
    public class Video
    {
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string site { get; set; }
        public string type { get; set; }
    }
}