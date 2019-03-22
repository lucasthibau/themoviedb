using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using TheMovieDb.Util;
using Newtonsoft.Json;
using TheMovieDb.Models;

namespace TheMovieDb.APICalls
{
    public class TheMovieDbApi
    {
        public static ListGenres GetGenres()
        {
            var uri = string.Concat(Helpers.baseUrlV3, "genre/movie/list", Helpers.keyV3);
            IRestResponse response = CallRest(uri);
            return JsonConvert.DeserializeObject<ListGenres>(response.Content);
        }
        public static ListMovies DiscoverMovies(int page = 1, string genre = "", string sort = "")
        {
            var uri = string.Concat(Helpers.baseUrlV3, "discover/movie", Helpers.keyV3, "&page=", page.ToString());
            if(sort == "")
            {
                uri = string.Concat(uri, "&sort_by = popularity.desc");
            }
            if(genre != "")
            {
                uri = string.Concat(uri, "&with_genres=", genre);
            }
            IRestResponse response = CallRest(uri);
            return JsonConvert.DeserializeObject<ListMovies>(response.Content);
        }
        public static MoviesModel GetMovie(int id)
        {
            var uri = string.Concat(Helpers.baseUrlV3, "movie/", id.ToString(), Helpers.keyV3);
            IRestResponse response = CallRest(uri);
            return JsonConvert.DeserializeObject<MoviesModel>(response.Content);
        }
        public static ListMovies SearchMovie(string title, int page)
        {
            var uri = string.Concat(Helpers.baseUrlV3, "search/movie", Helpers.keyV3, "&query=", title, "&page=", page.ToString());
            IRestResponse response = CallRest(uri);
            return JsonConvert.DeserializeObject<ListMovies>(response.Content);
        }
        public static Videos ListVideos(int id)
        {
            var uri = string.Concat(Helpers.baseUrlV3, "movie/", id, "/videos", Helpers.keyV3);
            IRestResponse response = CallRest(uri);
            return JsonConvert.DeserializeObject<Videos>(response.Content);
        }
        private static IRestResponse CallRest(string uri)
        {
            var client = new RestClient(uri);
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            return response;
        }
    }
}