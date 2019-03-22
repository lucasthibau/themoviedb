using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TheMovieDb.Util
{
    public static class Helpers
    {
        public static string baseUrlV3 = "https://api.themoviedb.org/3/";
        public static string keyV3 = "?api_key=6530b33e5a2fd357e2312d859d76636d&language=pt-BR";
        public static string imagePath = "https://image.tmdb.org/t/p/w";
        public static string baseUrlV4 = "https://api.themoviedb.org/4/";
        public static string keyV4 = "?api_key=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJhdWQiOiI2NTMwYjMzZTVhMmZkMzU3ZTIzMTJkODU5ZDc2NjM2ZCIsInN1YiI6IjVjOTQwN2E5YzNhMzY4MmU1ZmYxYzZiNSIsInNjb3BlcyI6WyJhcGlfcmVhZCJdLCJ2ZXJzaW9uIjoxfQ.Wp8QpCyKwRRCQR6U1BenqJSApWwsAAleuHrH9N72yU8&language=pt-BR";

        public static string ConvertMoney(int money)
        {
            var ret = money.ToString("F2");
            return ret;
        }
    }
}